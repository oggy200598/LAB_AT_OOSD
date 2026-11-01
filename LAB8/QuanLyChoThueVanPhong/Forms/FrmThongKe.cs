using System;
using System.Data;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Forms
{
    public class FrmThongKe : Form
    {
        private readonly DataGridView grid = Ui.Grid();
        private readonly ComboBox report = new ComboBox { Width = 240, DropDownStyle = ComboBoxStyle.DropDownList };
        public FrmThongKe()
        {
            Text = "Thống kê quản lý cao ốc";
            Width = 1020;
            Height = 650;
            report.Items.AddRange(new object[] { "Tổng hợp", "Phòng theo tầng", "Doanh thu thanh toán theo tháng", "Kiểm tra phòng gần nhất", "Vi phạm chưa xử lý" });
            report.SelectedIndex = 0;
            Controls.Add(grid);
            Controls.Add(Ui.Actions(report, Ui.Button("Xem báo cáo", (s, e) => RefreshList())));
            Load += (s, e) => RefreshList();
        }
        private void RefreshList()
        {
            Ui.Run(() =>
            {
                string sql;
                switch (report.SelectedIndex)
                {
                    case 1:
                        sql = @"SELECT t.MaTang,t.SoTang,COUNT(p.MaPhong) AS SoPhong,
SUM(CASE WHEN p.TrangThai=N'SanSang' THEN 1 ELSE 0 END) AS PhongSanSang
FROM dbo.Tang t LEFT JOIN dbo.Phong p ON p.MaTang=t.MaTang GROUP BY t.MaTang,t.SoTang ORDER BY t.SoTang";
                        break;
                    case 2:
                        sql = @"SELECT YEAR(NgayThanhToan) AS Nam,MONTH(NgayThanhToan) AS Thang,LoaiThanhToan,
COUNT(*) AS SoLanThu,SUM(SoTien) AS TongTien FROM dbo.ThanhToan
GROUP BY YEAR(NgayThanhToan),MONTH(NgayThanhToan),LoaiThanhToan ORDER BY Nam DESC,Thang DESC";
                        break;
                    case 3:
                        sql = @"SELECT p.MaPhong,t.SoTang,MAX(k.NgayKiemTra) AS LanKiemTraGanNhat,
CASE WHEN MAX(k.NgayKiemTra) IS NULL OR MAX(k.NgayKiemTra)<DATEADD(YEAR,-1,CAST(GETDATE() AS DATE))
THEN N'Cần kiểm tra' ELSE N'Đúng hạn' END AS TrangThaiKiemTra
FROM dbo.Phong p JOIN dbo.Tang t ON t.MaTang=p.MaTang LEFT JOIN dbo.PhieuKiemTra k ON k.MaPhong=p.MaPhong
GROUP BY p.MaPhong,t.SoTang ORDER BY t.SoTang,p.MaPhong";
                        break;
                    case 4:
                        sql = @"SELECT v.MaPVP,c.MaPhong,v.NgayLap,v.NoiDungViPham,v.SoTienPhat,v.TrangThai
FROM dbo.PhieuViPham v JOIN dbo.ChiTietHopDong c ON c.MaCTHD=v.MaCTHD
WHERE v.TrangThai=N'ChuaXuLy' ORDER BY v.NgayLap DESC";
                        break;
                    default:
                        sql = @"SELECT N'Số tầng' AS ChiTieu,CAST(COUNT(*) AS DECIMAL(18,2)) AS GiaTri FROM dbo.Tang
UNION ALL SELECT N'Số phòng',COUNT(*) FROM dbo.Phong
UNION ALL SELECT N'Số hợp đồng đang hiệu lực',COUNT(*) FROM dbo.HopDong WHERE TrangThai=N'HieuLuc'
UNION ALL SELECT N'Tổng đã thu',ISNULL(SUM(SoTien),0) FROM dbo.ThanhToan
UNION ALL SELECT N'Tổng tiền phạt chưa xử lý',ISNULL(SUM(SoTienPhat),0) FROM dbo.PhieuViPham WHERE TrangThai=N'ChuaXuLy'";
                        break;
                }
                grid.DataSource = Database.Query(sql);
            });
        }
    }
}
