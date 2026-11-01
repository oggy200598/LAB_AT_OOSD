using System;
using System.Data;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public static class ThanhToanService
    {
        public static DataTable Debts()
        {
            return Database.Query(@"SELECT N'THUE' AS Loai, i.MaHDT AS MaHoaDon, c.MaPhong, i.MaHD,
i.HanThanhToan,i.TongTien,ISNULL(x.DaThu,0) AS DaThu,i.TongTien-ISNULL(x.DaThu,0) AS ConNo
FROM dbo.HoaDonTienThue i JOIN dbo.ChiTietHopDong c ON c.MaCTHD=i.MaCTHD
OUTER APPLY (SELECT SUM(SoTien) DaThu FROM dbo.ThanhToan WHERE MaHDT=i.MaHDT) x
WHERE i.TongTien>ISNULL(x.DaThu,0)
UNION ALL
SELECT N'DICHVU',i.MaHDDV,c.MaPhong,i.MaHD,i.HanThanhToan,i.TongTien,ISNULL(x.DaThu,0),i.TongTien-ISNULL(x.DaThu,0)
FROM dbo.HoaDonDichVu i JOIN dbo.ChiTietHopDong c ON c.MaCTHD=i.MaCTHD
OUTER APPLY (SELECT SUM(SoTien) DaThu FROM dbo.ThanhToan WHERE MaHDDV=i.MaHDDV) x
WHERE i.TongTien>ISNULL(x.DaThu,0)
ORDER BY HanThanhToan,Loai,MaHoaDon");
        }

        public static string Pay(string type, string billId, decimal amount, string method)
        {
            ServiceUtils.Require(type == "THUE" || type == "DICHVU", "Loại hóa đơn không hợp lệ.");
            ServiceUtils.Require(amount > 0 && !string.IsNullOrWhiteSpace(method), "Số tiền và phương thức thanh toán không hợp lệ.");
            string table = type == "THUE" ? "HoaDonTienThue" : "HoaDonDichVu";
            string key = type == "THUE" ? "MaHDT" : "MaHDDV";
            using (var connection = Database.Open())
            using (var transaction = connection.BeginTransaction(IsolationLevel.Serializable))
            {
                try
                {
                    object totalObj = Database.Scalar(connection, transaction,
                        "SELECT TongTien FROM dbo." + table + " WITH (UPDLOCK,HOLDLOCK) WHERE " + key + "=@id", Database.P("@id", billId));
                    ServiceUtils.Require(totalObj != null && totalObj != DBNull.Value, "Không tìm thấy hóa đơn.");
                    decimal total = Convert.ToDecimal(totalObj);
                    decimal paid = Convert.ToDecimal(Database.Scalar(connection, transaction,
                        "SELECT ISNULL(SUM(SoTien),0) FROM dbo.ThanhToan WHERE " + key + "=@id", Database.P("@id", billId)));
                    ServiceUtils.Require(amount <= total - paid, "Số tiền thu vượt quá công nợ còn lại.");
                    string id = IdGenerator.New("TT");
                    Database.Execute(connection, transaction,
                        "INSERT INTO dbo.ThanhToan(MaTT,NgayThanhToan,SoTien,PhuongThuc,LoaiThanhToan," + key + ") VALUES(@id,SYSDATETIME(),@money,@method,@type,@bill)",
                        Database.P("@id", id), Database.P("@money", amount), Database.P("@method", method),
                        Database.P("@type", type), Database.P("@bill", billId));
                    string status = total == paid + amount ? "DaThanhToan" : "ThanhToanMotPhan";
                    Database.Execute(connection, transaction,
                        "UPDATE dbo." + table + " SET TrangThai=@status WHERE " + key + "=@id",
                        Database.P("@status", status), Database.P("@id", billId));
                    transaction.Commit();
                    return id;
                }
                catch { transaction.Rollback(); throw; }
            }
        }

        public static DataTable Payments()
        {
            return Database.Query("SELECT MaTT,NgayThanhToan,SoTien,PhuongThuc,LoaiThanhToan,MaHDT,MaHDDV FROM dbo.ThanhToan ORDER BY NgayThanhToan DESC");
        }
    }
}
