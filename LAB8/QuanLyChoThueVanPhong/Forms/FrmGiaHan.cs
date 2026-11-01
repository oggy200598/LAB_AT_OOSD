using System;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public class FrmGiaHan : Form
    {
        private readonly ComboBox detail = new ComboBox();
        private readonly ComboBox manager = new ComboBox();
        private readonly NumericUpDown months = Ui.Number(1, 60, 1);
        private readonly DataGridView grid = Ui.Grid();

        public FrmGiaHan()
        {
            Text = "Lập phiếu gia hạn thuê văn phòng";
            Width = 1080;
            Height = 690;
            var form = new TableLayoutPanel { Dock = DockStyle.Top, Height = 115, ColumnCount = 2, RowCount = 3, Padding = new Padding(10) };
            form.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170));
            form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            Ui.Line(form, "Phòng cần gia hạn:", detail, 0);
            Ui.Line(form, "Nhân viên quản lý:", manager, 1);
            Ui.Line(form, "Số tháng gia hạn:", months, 2);
            var actions = Ui.Actions(
                Ui.Button("Lập phiếu gia hạn", (s, e) => Extend(), 170),
                Ui.Button("Làm mới", (s, e) => RefreshList()));
            Controls.Add(grid);
            Controls.Add(actions);
            Controls.Add(form);
            Load += (s, e) => Ui.Run(() =>
            {
                Ui.Bind(detail, @"SELECT c.MaCTHD AS Ma,c.MaPhong+N' / '+c.MaHD+N' (hết: '+CONVERT(NVARCHAR(10),c.NgayKetThuc,103)+N')' AS Ten
FROM dbo.ChiTietHopDong c JOIN dbo.HopDong h ON h.MaHD=c.MaHD WHERE h.TrangThai=N'HieuLuc' ORDER BY c.MaPhong");
                Ui.Bind(manager, "SELECT MaNVQL AS Ma,HoTen AS Ten FROM dbo.NhanVienQuanLy ORDER BY HoTen");
                RefreshList();
            });
        }

        private void RefreshList() { Ui.Run(() => grid.DataSource = GiaHanService.Renewals()); }

        private void Extend()
        {
            Ui.Run(() =>
            {
                string id = GiaHanService.Extend(Ui.Selected(detail), Ui.Selected(manager), (int)months.Value);
                MessageBox.Show("Lập phiếu gia hạn thành công: " + id);
                Ui.Bind(detail, @"SELECT c.MaCTHD AS Ma,c.MaPhong+N' / '+c.MaHD+N' (hết: '+CONVERT(NVARCHAR(10),c.NgayKetThuc,103)+N')' AS Ten
FROM dbo.ChiTietHopDong c JOIN dbo.HopDong h ON h.MaHD=c.MaHD WHERE h.TrangThai=N'HieuLuc' ORDER BY c.MaPhong");
                RefreshList();
            });
        }
    }
}
