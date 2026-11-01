using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public static class HoaDonService
    {
        public static int GenerateRent(DateTime asOf, string detailId = null)
        {
            int added = 0;
            using (var connection = Database.Open())
            using (var tx = connection.BeginTransaction(IsolationLevel.Serializable))
            {
                try
                {
                    var details = ServiceUtils.Query(connection, tx,
                        @"SELECT c.MaCTHD,c.MaHD,c.NgayBatDau,c.NgayKetThuc,c.DonGiaThue
FROM dbo.ChiTietHopDong c JOIN dbo.HopDong h ON h.MaHD=c.MaHD
WHERE h.TrangThai=N'HieuLuc' AND (@id IS NULL OR c.MaCTHD=@id)", Database.P("@id", detailId));
                    foreach (DataRow row in details.Rows)
                    {
                        string ct = Convert.ToString(row["MaCTHD"]);
                        DateTime start = ServiceUtils.AsDate(row["NgayBatDau"]);
                        DateTime end = ServiceUtils.AsDate(row["NgayKetThuc"]);
                        decimal price = ServiceUtils.Money(row["DonGiaThue"]);
                        for (int month = 6; month < 1200; month++)
                        {
                            DateTime current = start.AddMonths(month);
                            if (current > end || current > asOf.Date) break;
                            int existing = Convert.ToInt32(Database.Scalar(connection, tx,
                                "SELECT COUNT(*) FROM dbo.HoaDonTienThue WITH (UPDLOCK,HOLDLOCK) WHERE MaCTHD=@ct AND KyTu=@date",
                                Database.P("@ct", ct), Database.P("@date", current)));
                            if (existing != 0) continue;
                            DateTime periodEnd = start.AddMonths(month + 1).AddDays(-1);
                            if (periodEnd > end) periodEnd = end;
                            Database.Execute(connection, tx,
                                @"INSERT INTO dbo.HoaDonTienThue(MaHDT,MaHD,MaCTHD,KyThanhToan,KyTu,KyDen,NgayLap,HanThanhToan,TongTien,TrangThai)
VALUES (@id,@hd,@ct,@label,@from,@to,@today,@due,@money,N'ChuaThanhToan')",
                                Database.P("@id", IdGenerator.New("HT")), Database.P("@hd", row["MaHD"]),
                                Database.P("@ct", ct), Database.P("@label", "Tháng thuê " + (month + 1)),
                                Database.P("@from", current), Database.P("@to", periodEnd),
                                Database.P("@today", DateTime.Today), Database.P("@due", current), Database.P("@money", price));
                            added++;
                        }
                    }
                    tx.Commit();
                }
                catch { tx.Rollback(); throw; }
            }
            return added;
        }

        public static DataTable RentBills()
        {
            return Database.Query(@"SELECT i.MaHDT,i.MaHD,c.MaPhong,i.KyThanhToan,i.KyTu,i.KyDen,i.HanThanhToan,i.TongTien,
ISNULL((SELECT SUM(t.SoTien) FROM dbo.ThanhToan t WHERE t.MaHDT=i.MaHDT),0) AS DaThu,
i.TongTien-ISNULL((SELECT SUM(t.SoTien) FROM dbo.ThanhToan t WHERE t.MaHDT=i.MaHDT),0) AS ConNo,i.TrangThai
FROM dbo.HoaDonTienThue i JOIN dbo.ChiTietHopDong c ON c.MaCTHD=i.MaCTHD
ORDER BY i.HanThanhToan DESC,i.MaHDT DESC");
        }

        public static int GenerateServices(int month, int year)
        {
            ServiceUtils.Require(month >= 1 && month <= 12, "Tháng không hợp lệ.");
            DateTime period = new DateTime(year, month, 1);
            ServiceUtils.Require(DateTime.Today.Date >= period.AddMonths(1).AddDays(-1), "Chỉ lập hóa đơn dịch vụ vào ngày cuối tháng hoặc sau đó.");
            int added = 0;
            using (var connection = Database.Open())
            using (var tx = connection.BeginTransaction(IsolationLevel.Serializable))
            {
                try
                {
                    var rooms = ServiceUtils.Query(connection, tx,
                        @"SELECT DISTINCT s.MaCTHD,c.MaHD FROM dbo.SuDungDichVu s
JOIN dbo.ChiTietHopDong c ON s.MaCTHD=c.MaCTHD
WHERE s.Thang=@month AND s.Nam=@year",
                        Database.P("@month", month), Database.P("@year", year));
                    foreach (DataRow room in rooms.Rows)
                    {
                        string detailId = Convert.ToString(room["MaCTHD"]);
                        int exists = Convert.ToInt32(Database.Scalar(connection, tx,
                            "SELECT COUNT(*) FROM dbo.HoaDonDichVu WITH (UPDLOCK,HOLDLOCK) WHERE MaCTHD=@ct AND Thang=@month AND Nam=@year",
                            Database.P("@ct", detailId), Database.P("@month", month), Database.P("@year", year)));
                        if (exists != 0) continue;
                        var usages = ServiceUtils.Query(connection, tx,
                            @"SELECT s.MaSDDV,s.SoLuong*s.DonGia AS ThanhTien FROM dbo.SuDungDichVu s
WHERE s.MaCTHD=@ct AND s.Thang=@month AND s.Nam=@year",
                            Database.P("@ct", detailId), Database.P("@month", month), Database.P("@year", year));
                        if (usages.Rows.Count == 0) continue;
                        decimal sum = 0;
                        foreach (DataRow item in usages.Rows) sum += ServiceUtils.Money(item["ThanhTien"]);
                        string billId = IdGenerator.New("DVH");
                        DateTime lastDay = period.AddMonths(1).AddDays(-1);
                        Database.Execute(connection, tx,
                            @"INSERT INTO dbo.HoaDonDichVu(MaHDDV,MaHD,MaCTHD,Thang,Nam,NgayLap,HanThanhToan,TongTien,TrangThai)
VALUES (@id,@hd,@ct,@month,@year,@today,@due,@money,@state)",
                            Database.P("@id", billId), Database.P("@hd", room["MaHD"]), Database.P("@ct", detailId),
                            Database.P("@month", month), Database.P("@year", year), Database.P("@today", DateTime.Today),
                            Database.P("@due", lastDay), Database.P("@money", sum), Database.P("@state", sum == 0 ? "DaThanhToan" : "ChuaThanhToan"));
                        foreach (DataRow item in usages.Rows)
                        {
                            Database.Execute(connection, tx,
                                "INSERT INTO dbo.ChiTietHoaDonDV(MaCTHDDV,MaHDDV,MaSDDV,ThanhTien) VALUES(@id,@bill,@usage,@amount)",
                                Database.P("@id", IdGenerator.New("CDV")), Database.P("@bill", billId),
                                Database.P("@usage", item["MaSDDV"]), Database.P("@amount", item["ThanhTien"]));
                        }
                        added++;
                    }
                    tx.Commit();
                }
                catch { tx.Rollback(); throw; }
            }
            return added;
        }

        public static DataTable ServiceBills()
        {
            return Database.Query(@"SELECT i.MaHDDV,i.MaHD,c.MaPhong,i.Thang,i.Nam,i.HanThanhToan,i.TongTien,
ISNULL((SELECT SUM(t.SoTien) FROM dbo.ThanhToan t WHERE t.MaHDDV=i.MaHDDV),0) AS DaThu,
i.TongTien-ISNULL((SELECT SUM(t.SoTien) FROM dbo.ThanhToan t WHERE t.MaHDDV=i.MaHDDV),0) AS ConNo,i.TrangThai
FROM dbo.HoaDonDichVu i JOIN dbo.ChiTietHopDong c ON c.MaCTHD=i.MaCTHD
ORDER BY i.Nam DESC,i.Thang DESC,i.MaHDDV DESC");
        }
    }
}
