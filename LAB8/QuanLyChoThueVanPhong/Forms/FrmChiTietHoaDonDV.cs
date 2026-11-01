using System;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Forms
{
    public class FrmChiTietHoaDonDV : Form
    {
        private readonly DataGridView grid = Ui.Grid();
        public FrmChiTietHoaDonDV()
        {
            Text = "Chi tiết hóa đơn dịch vụ";
            Width = 1020;
            Height = 640;
            Controls.Add(grid);
            Controls.Add(Ui.Actions(Ui.Button("Tải danh sách", (s, e) => RefreshList())));
            Load += (s, e) => RefreshList();
        }
        private void RefreshList()
        {
            Ui.Run(() => grid.DataSource = Database.Query(@"SELECT ct.MaCTHDDV,ct.MaHDDV,c.MaPhong,d.TenDV,s.Thang,s.Nam,
s.SoLuong,s.DonGia,ct.ThanhTien
FROM dbo.ChiTietHoaDonDV ct JOIN dbo.SuDungDichVu s ON s.MaSDDV=ct.MaSDDV
JOIN dbo.DichVu d ON d.MaDV=s.MaDV JOIN dbo.ChiTietHopDong c ON c.MaCTHD=s.MaCTHD
ORDER BY s.Nam DESC,s.Thang DESC,c.MaPhong"));
        }
    }
}
