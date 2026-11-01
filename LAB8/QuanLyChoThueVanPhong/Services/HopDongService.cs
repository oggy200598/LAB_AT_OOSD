using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public static class HopDongService
    {
        public static DataTable AvailableRooms(DateTime start, int months)
        {
            ServiceUtils.Require(months >= 6, "Thời hạn thuê tối thiểu 6 tháng.");
            var end = start.Date.AddMonths(months).AddDays(-1);
            return Database.Query(@"SELECT p.MaPhong, t.SoTang, p.DienTich, p.HuongPhong, p.GiaThue
FROM dbo.Phong p JOIN dbo.Tang t ON p.MaTang=t.MaTang
WHERE p.TrangThai=N'SanSang' AND NOT EXISTS (
SELECT 1 FROM dbo.ChiTietHopDong c JOIN dbo.HopDong h ON h.MaHD=c.MaHD
WHERE c.MaPhong=p.MaPhong AND h.TrangThai=N'HieuLuc'
AND c.NgayBatDau<=@Den AND c.NgayKetThuc>=@Tu)
ORDER BY t.SoTang,p.MaPhong", Database.P("@Tu", start.Date), Database.P("@Den", end));
        }

        public static string SignContract(string customerId, string managerId, DateTime start, int months,
            IList<string> roomIds, string terms, string paymentMethod)
        {
            ServiceUtils.Require(!string.IsNullOrWhiteSpace(customerId) && !string.IsNullOrWhiteSpace(managerId), "Chọn khách hàng và nhân viên quản lý.");
            ServiceUtils.Require(months >= 6, "Thời hạn thuê phải từ 6 tháng trở lên.");
            ServiceUtils.Require(roomIds != null && roomIds.Count > 0, "Chọn ít nhất một phòng.");
            ServiceUtils.Require(roomIds.Distinct().Count() == roomIds.Count, "Danh sách phòng bị trùng.");
            ServiceUtils.Require(!string.IsNullOrWhiteSpace(paymentMethod), "Chọn phương thức đã thu tiền.");
            DateTime first = start.Date;
            DateTime last = first.AddMonths(months).AddDays(-1);
            string contractId = IdGenerator.New("HD");
            using (var connection = Database.Open())
            using (var tx = connection.BeginTransaction(IsolationLevel.Serializable))
            {
                try
                {
                    var selected = new List<KeyValuePair<string, decimal>>();
                    foreach (string room in roomIds)
                    {
                        var info = ServiceUtils.Query(connection, tx,
                            "SELECT MaPhong,GiaThue,TrangThai FROM dbo.Phong WITH (UPDLOCK,HOLDLOCK) WHERE MaPhong=@p",
                            Database.P("@p", room));
                        ServiceUtils.Require(info.Rows.Count == 1 && Convert.ToString(info.Rows[0]["TrangThai"]) == "SanSang", "Phòng " + room + " không sẵn sàng.");
                        var overlaps = Convert.ToInt32(Database.Scalar(connection, tx,
                            @"SELECT COUNT(*) FROM dbo.ChiTietHopDong c JOIN dbo.HopDong h ON h.MaHD=c.MaHD
WHERE c.MaPhong=@p AND h.TrangThai=N'HieuLuc' AND c.NgayBatDau<=@end AND c.NgayKetThuc>=@start",
                            Database.P("@p", room), Database.P("@start", first), Database.P("@end", last)));
                        ServiceUtils.Require(overlaps == 0, "Phòng " + room + " đã được thuê trong khoảng ngày chọn.");
                        selected.Add(new KeyValuePair<string, decimal>(room, ServiceUtils.Money(info.Rows[0]["GiaThue"])));
                    }
                    decimal totalPerMonth = selected.Sum(x => x.Value);
                    decimal prepaid = totalPerMonth * 6;
                    Database.Execute(connection, tx,
                        @"INSERT INTO dbo.HopDong(MaHD,MaKH,MaNVQL,NgayKy,NgayBatDau,NgayKetThuc,SoThangBanDau,TongTienThue,TienTraTruoc,DieuKhoan,TrangThai)
VALUES (@id,@customer,@manager,@date,@start,@end,@months,@total,@prepaid,@terms,N'HieuLuc')",
                        Database.P("@id", contractId), Database.P("@customer", customerId), Database.P("@manager", managerId),
                        Database.P("@date", DateTime.Today), Database.P("@start", first), Database.P("@end", last),
                        Database.P("@months", months), Database.P("@total", totalPerMonth * months), Database.P("@prepaid", prepaid), Database.P("@terms", terms));
                    foreach (var item in selected)
                    {
                        string detailId = IdGenerator.New("CT");
                        string invoiceId = IdGenerator.New("HT");
                        Database.Execute(connection, tx,
                            @"INSERT INTO dbo.ChiTietHopDong(MaCTHD,MaHD,MaPhong,DonGiaThue,NgayBatDau,NgayKetThuc,SoThangGoc)
VALUES (@id,@hd,@room,@price,@start,@end,@months)",
                            Database.P("@id", detailId), Database.P("@hd", contractId), Database.P("@room", item.Key),
                            Database.P("@price", item.Value), Database.P("@start", first), Database.P("@end", last), Database.P("@months", months));
                        Database.Execute(connection, tx,
                            @"INSERT INTO dbo.HoaDonTienThue(MaHDT,MaHD,MaCTHD,KyThanhToan,KyTu,KyDen,NgayLap,HanThanhToan,TongTien,TrangThai)
VALUES (@id,@hd,@ct,N'Trả trước 6 tháng',@start,@end,@today,@today,@total,N'DaThanhToan')",
                            Database.P("@id", invoiceId), Database.P("@hd", contractId), Database.P("@ct", detailId),
                            Database.P("@start", first), Database.P("@end", first.AddMonths(6).AddDays(-1)),
                            Database.P("@today", DateTime.Today), Database.P("@total", 6 * item.Value));
                        Database.Execute(connection, tx,
                            @"INSERT INTO dbo.ThanhToan(MaTT,NgayThanhToan,SoTien,PhuongThuc,LoaiThanhToan,MaHDT)
VALUES (@id,SYSDATETIME(),@money,@method,N'THUE',@bill)",
                            Database.P("@id", IdGenerator.New("TT")), Database.P("@money", 6 * item.Value),
                            Database.P("@method", paymentMethod), Database.P("@bill", invoiceId));
                    }
                    tx.Commit();
                    return contractId;
                }
                catch { tx.Rollback(); throw; }
            }
        }

        public static DataTable ListContracts()
        {
            return Database.Query(@"SELECT h.MaHD,kh.TenKH,h.NgayKy,h.NgayBatDau,h.NgayKetThuc,h.SoThangBanDau,h.TongTienThue,h.TienTraTruoc,h.TrangThai
FROM dbo.HopDong h JOIN dbo.KhachHang kh ON h.MaKH=kh.MaKH ORDER BY h.NgayKy DESC,h.MaHD DESC");
        }

        public static DataTable ListDetails()
        {
            return Database.Query(@"SELECT c.MaCTHD,c.MaHD,c.MaPhong,kh.TenKH,c.DonGiaThue,c.NgayBatDau,c.NgayKetThuc,c.SoThangGoc
FROM dbo.ChiTietHopDong c JOIN dbo.HopDong h ON h.MaHD=c.MaHD JOIN dbo.KhachHang kh ON kh.MaKH=h.MaKH
ORDER BY c.NgayBatDau DESC,c.MaPhong");
        }

        public static void Liquidate(string contractId)
        {
            using (var connection = Database.Open())
            using (var tx = connection.BeginTransaction(IsolationLevel.Serializable))
            {
                try
                {
                    int balance = Convert.ToInt32(Database.Scalar(connection, tx,
                        @"SELECT (SELECT COUNT(*) FROM dbo.HoaDonTienThue i WHERE i.MaHD=@id AND i.TrangThai<>N'DaThanhToan') +
(SELECT COUNT(*) FROM dbo.HoaDonDichVu d WHERE d.MaHD=@id AND d.TrangThai<>N'DaThanhToan')",
                        Database.P("@id", contractId)));
                    ServiceUtils.Require(balance == 0, "Không thể thanh lý khi còn hóa đơn chưa thanh toán.");
                    int rows = Database.Execute(connection, tx,
                        "UPDATE dbo.HopDong SET TrangThai=N'DaThanhLy' WHERE MaHD=@id AND TrangThai=N'HieuLuc' AND NgayKetThuc < CAST(GETDATE() AS DATE)",
                        Database.P("@id", contractId));
                    ServiceUtils.Require(rows == 1, "Chỉ thanh lý hợp đồng đã hết hạn và đang hiệu lực.");
                    tx.Commit();
                }
                catch { tx.Rollback(); throw; }
            }
        }
    }
}
