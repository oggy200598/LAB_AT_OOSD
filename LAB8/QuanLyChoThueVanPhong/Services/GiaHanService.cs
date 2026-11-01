using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public static class GiaHanService
    {
        public static string Extend(string detailId, string managerId, int months)
        {
            ServiceUtils.Require(months >= 1, "Số tháng gia hạn phải lớn hơn 0.");
            ServiceUtils.Require(!string.IsNullOrWhiteSpace(detailId) && !string.IsNullOrWhiteSpace(managerId), "Chưa chọn phòng thuê và người quản lý.");
            HoaDonService.GenerateRent(DateTime.Today, detailId);
            using (var connection = Database.Open())
            using (var tx = connection.BeginTransaction(IsolationLevel.Serializable))
            {
                try
                {
                    var info = ServiceUtils.Query(connection, tx,
                        @"SELECT c.MaHD,c.MaPhong,c.NgayKetThuc,c.SoThangGoc,h.TrangThai
FROM dbo.ChiTietHopDong c WITH (UPDLOCK,HOLDLOCK)
JOIN dbo.HopDong h ON h.MaHD=c.MaHD WHERE c.MaCTHD=@id", Database.P("@id", detailId));
                    ServiceUtils.Require(info.Rows.Count == 1, "Không tìm thấy phòng trong hợp đồng.");
                    var row = info.Rows[0];
                    ServiceUtils.Require(Convert.ToString(row["TrangThai"]) == "HieuLuc", "Hợp đồng đã thanh lý.");
                    int initialMonths = Convert.ToInt32(row["SoThangGoc"]);
                    ServiceUtils.Require(months <= initialMonths / 2, "Gia hạn không vượt quá 1/2 thời gian thuê ban đầu (tối đa " + (initialMonths / 2) + " tháng).");
                    string countSql = @"SELECT
(SELECT COUNT(*) FROM dbo.HoaDonTienThue WHERE MaCTHD=@id AND TrangThai<>N'DaThanhToan') +
(SELECT COUNT(*) FROM dbo.HoaDonDichVu WHERE MaCTHD=@id AND TrangThai<>N'DaThanhToan') +
(SELECT COUNT(*) FROM dbo.SuDungDichVu s WHERE s.MaCTHD=@id AND NOT EXISTS
(SELECT 1 FROM dbo.ChiTietHoaDonDV x WHERE x.MaSDDV=s.MaSDDV))";
                    int debt = Convert.ToInt32(Database.Scalar(connection, tx, countSql, Database.P("@id", detailId)));
                    ServiceUtils.Require(debt == 0, "Không được gia hạn: còn hóa đơn chưa thanh toán hoặc dịch vụ chưa xuất hóa đơn.");
                    DateTime oldEnd = ServiceUtils.AsDate(row["NgayKetThuc"]);
                    DateTime newEnd = oldEnd.AddDays(1).AddMonths(months).AddDays(-1);
                    string room = Convert.ToString(row["MaPhong"]);
                    int collision = Convert.ToInt32(Database.Scalar(connection, tx,
                        @"SELECT COUNT(*) FROM dbo.ChiTietHopDong c JOIN dbo.HopDong h ON h.MaHD=c.MaHD
WHERE c.MaPhong=@room AND c.MaCTHD<>@id AND h.TrangThai=N'HieuLuc'
AND c.NgayBatDau<=@end AND c.NgayKetThuc>@oldEnd",
                        Database.P("@room", room), Database.P("@id", detailId), Database.P("@end", newEnd), Database.P("@oldEnd", oldEnd)));
                    ServiceUtils.Require(collision == 0, "Phòng đã được đặt thuê bởi hợp đồng khác trong thời gian gia hạn.");
                    string noteId = IdGenerator.New("GH");
                    Database.Execute(connection, tx,
                        @"INSERT INTO dbo.PhieuGiaHan(MaPGH,MaCTHD,MaNVQL,NgayLap,SoThangGiaHan,NgayKetThucCu,NgayKetThucMoi,TrangThai)
VALUES (@id,@ct,@manager,@date,@months,@old,@new,N'CoHieuLuc')",
                        Database.P("@id", noteId), Database.P("@ct", detailId), Database.P("@manager", managerId),
                        Database.P("@date", DateTime.Today), Database.P("@months", months),
                        Database.P("@old", oldEnd), Database.P("@new", newEnd));
                    Database.Execute(connection, tx, "UPDATE dbo.ChiTietHopDong SET NgayKetThuc=@end WHERE MaCTHD=@id",
                        Database.P("@end", newEnd), Database.P("@id", detailId));
                    Database.Execute(connection, tx,
                        @"UPDATE h SET NgayKetThuc=x.NgayMax,
TongTienThue=(SELECT SUM(c.DonGiaThue*(c.SoThangGoc+ISNULL((SELECT SUM(p.SoThangGiaHan) FROM dbo.PhieuGiaHan p WHERE p.MaCTHD=c.MaCTHD),0))) FROM dbo.ChiTietHopDong c WHERE c.MaHD=h.MaHD)
FROM dbo.HopDong h CROSS APPLY (SELECT MAX(NgayKetThuc) NgayMax FROM dbo.ChiTietHopDong WHERE MaHD=h.MaHD) x
WHERE h.MaHD=@hd",
                        Database.P("@hd", row["MaHD"]));
                    tx.Commit();
                    return noteId;
                }
                catch { tx.Rollback(); throw; }
            }
        }

        public static DataTable Renewals()
        {
            return Database.Query(@"SELECT p.MaPGH,c.MaPhong,p.MaCTHD,p.NgayLap,p.SoThangGiaHan,p.NgayKetThucCu,p.NgayKetThucMoi,m.HoTen AS NguoiLap
FROM dbo.PhieuGiaHan p JOIN dbo.ChiTietHopDong c ON c.MaCTHD=p.MaCTHD
JOIN dbo.NhanVienQuanLy m ON m.MaNVQL=p.MaNVQL ORDER BY p.NgayLap DESC");
        }
    }
}
