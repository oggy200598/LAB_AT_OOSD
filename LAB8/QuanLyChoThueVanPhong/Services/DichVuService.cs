using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public static class DichVuService
    {
        public static DataTable UsageList()
        {
            return Database.Query(@"SELECT s.MaSDDV,c.MaPhong,s.MaCTHD,d.TenDV,s.MaDV,s.Thang,s.Nam,s.SoLuong,s.DonGia,
CAST(s.SoLuong*s.DonGia AS DECIMAL(18,2)) AS ThanhTien,
CASE WHEN b.MaCTHDDV IS NULL THEN N'Chưa lập hóa đơn' ELSE N'Đã lập hóa đơn' END AS TrangThai
FROM dbo.SuDungDichVu s JOIN dbo.DichVu d ON d.MaDV=s.MaDV
JOIN dbo.ChiTietHopDong c ON c.MaCTHD=s.MaCTHD
LEFT JOIN dbo.ChiTietHoaDonDV b ON b.MaSDDV=s.MaSDDV
ORDER BY s.Nam DESC,s.Thang DESC,c.MaPhong");
        }

        public static string Record(string detailId, string serviceId, int month, int year, decimal quantity)
        {
            ServiceUtils.Require(quantity > 0, "Số lượng sử dụng phải lớn hơn 0.");
            ServiceUtils.Require(month >= 1 && month <= 12 && year >= 2000 && year <= 2100, "Kỳ sử dụng không hợp lệ.");
            DateTime from = new DateTime(year, month, 1);
            DateTime to = from.AddMonths(1).AddDays(-1);
            ServiceUtils.Require(from <= DateTime.Today, "Không thể ghi dịch vụ cho tháng tương lai.");
            using (var connection = Database.Open())
            using (var tx = connection.BeginTransaction(IsolationLevel.Serializable))
            {
                try
                {
                    var details = ServiceUtils.Query(connection, tx, "SELECT NgayBatDau,NgayKetThuc FROM dbo.ChiTietHopDong WITH (UPDLOCK,HOLDLOCK) WHERE MaCTHD=@ct", Database.P("@ct", detailId));
                    ServiceUtils.Require(details.Rows.Count == 1, "Chưa chọn chi tiết hợp đồng hợp lệ.");
                    var row = details.Rows[0];
                    ServiceUtils.Require(ServiceUtils.AsDate(row["NgayBatDau"]) <= to && ServiceUtils.AsDate(row["NgayKetThuc"]) >= from,
                        "Phòng không được thuê trong tháng ghi nhận.");
                    object price = Database.Scalar(connection, tx, "SELECT DonGia FROM dbo.DichVu WHERE MaDV=@id", Database.P("@id", serviceId));
                    ServiceUtils.Require(price != null, "Không tìm thấy dịch vụ.");
                    int billed = Convert.ToInt32(Database.Scalar(connection, tx,
                        "SELECT COUNT(*) FROM dbo.HoaDonDichVu WITH (UPDLOCK,HOLDLOCK) WHERE MaCTHD=@ct AND Thang=@m AND Nam=@y",
                        Database.P("@ct", detailId), Database.P("@m", month), Database.P("@y", year)));
                    ServiceUtils.Require(billed == 0, "Tháng này đã lập hóa đơn dịch vụ, không được sửa lượng sử dụng.");
                    string id = IdGenerator.New("SD");
                    Database.Execute(connection, tx,
                        @"INSERT INTO dbo.SuDungDichVu(MaSDDV,MaCTHD,MaDV,Thang,Nam,SoLuong,DonGia)
VALUES (@id,@ct,@dv,@m,@y,@qty,@price)",
                        Database.P("@id", id), Database.P("@ct", detailId), Database.P("@dv", serviceId),
                        Database.P("@m", month), Database.P("@y", year), Database.P("@qty", quantity), Database.P("@price", price));
                    tx.Commit();
                    return id;
                }
                catch { tx.Rollback(); throw; }
            }
        }

        public static void Remove(string usageId)
        {
            int rows = Database.Execute(@"DELETE FROM dbo.SuDungDichVu WHERE MaSDDV=@id
AND NOT EXISTS (SELECT 1 FROM dbo.ChiTietHoaDonDV WHERE MaSDDV=@id)", Database.P("@id", usageId));
            ServiceUtils.Require(rows == 1, "Không thể xóa dịch vụ đã lập hóa đơn hoặc không tồn tại.");
        }
    }
}
