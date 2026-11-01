
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmMain : Form
    {
        private FlowLayoutPanel menuPanel;
        private Panel contentPanel;
        private Label lblTieuDe;
        private Form currentForm;

        public FrmMain()
        {
            Text = "Quản lý cho thuê văn phòng ở cao ốc";
            WindowState = FormWindowState.Maximized;
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(1000, 650);

            KhoiTaoGiaoDien();
            KhoiTaoMenu();
        }

        private void KhoiTaoGiaoDien()
        {
            MenuStrip menuStrip = new MenuStrip();

            ToolStripMenuItem tongQuan =
                new ToolStripMenuItem("Tổng quan");

            tongQuan.Click += (s, e) => HienThiTrangChu();

            ToolStripMenuItem heThong =
                new ToolStripMenuItem("Hệ thống");

            ToolStripMenuItem ketNoi =
                new ToolStripMenuItem("Kết nối SQL Server");

            ketNoi.Click += (s, e) =>
            {
                using (FrmKetNoi form = new FrmKetNoi())
                {
                    form.ShowDialog(this);
                }
            };

            ToolStripMenuItem thoat =
                new ToolStripMenuItem("Thoát");

            thoat.Click += (s, e) => Close();

            heThong.DropDownItems.Add(ketNoi);
            heThong.DropDownItems.Add(thoat);

            menuStrip.Items.Add(tongQuan);
            menuStrip.Items.Add(heThong);

            MainMenuStrip = menuStrip;
            Controls.Add(menuStrip);

            SplitContainer split = new SplitContainer();
            split.Dock = DockStyle.Fill;
            split.Orientation = Orientation.Vertical;
            split.FixedPanel = FixedPanel.Panel1;
            split.IsSplitterFixed = true;
            split.SplitterWidth = 4;
            split.Panel1MinSize = 160;
            split.SplitterDistance = 180;

            Controls.Add(split);
            split.BringToFront();

            menuPanel = new FlowLayoutPanel();
            menuPanel.Dock = DockStyle.Fill;
            menuPanel.FlowDirection = FlowDirection.TopDown;
            menuPanel.WrapContents = false;
            menuPanel.AutoScroll = true;
            menuPanel.Padding = new Padding(5);

            split.Panel1.Controls.Add(menuPanel);

            Panel mainPanel = new Panel();
            mainPanel.Dock = DockStyle.Fill;

            split.Panel2.Controls.Add(mainPanel);

            lblTieuDe = new Label();
            lblTieuDe.Text = "TỔNG QUAN";
            lblTieuDe.Dock = DockStyle.Top;
            lblTieuDe.Height = 40;
            lblTieuDe.TextAlign = ContentAlignment.MiddleLeft;
            lblTieuDe.Padding = new Padding(10, 0, 0, 0);
            lblTieuDe.Font = new Font("Microsoft Sans Serif", 11);

            mainPanel.Controls.Add(lblTieuDe);

            contentPanel = new Panel();
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Padding = new Padding(10);

            mainPanel.Controls.Add(contentPanel);
            contentPanel.BringToFront();

            HienThiTrangChu();
        }

        private void ThemNhom(string tenNhom)
        {
            Label lbl = new Label();
            lbl.Text = tenNhom;
            lbl.Width = 160;
            lbl.Height = 28;
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            lbl.Margin = new Padding(2, 10, 2, 2);

            menuPanel.Controls.Add(lbl);
        }

        private void ThemChucNang(
            string ten,
            Func<Form> taoForm)
        {
            Button btn = new Button();
            btn.Text = ten;
            btn.Width = 160;
            btn.Height = 32;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Margin = new Padding(2, 2, 2, 2);
            btn.UseVisualStyleBackColor = true;

            btn.Click += (s, e) =>
            {
                MoForm(ten, taoForm);
            };

            menuPanel.Controls.Add(btn);
        }

        private void KhoiTaoMenu()
        {
            ThemNhom("DANH MỤC");

            ThemChucNang("Tầng", () => new FrmTang());
            ThemChucNang("Phòng", () => new FrmPhong());
            ThemChucNang("Khách hàng", () => new FrmKhachHang());
            ThemChucNang("Nhân viên quản lý", () => new FrmNhanVienQuanLy());
            ThemChucNang("Dịch vụ", () => new FrmDichVu());

            ThemNhom("THUÊ VĂN PHÒNG");

            ThemChucNang("Ký hợp đồng", () => new FrmHopDong());
            ThemChucNang("Danh sách phòng thuê", () => new FrmChiTietHopDong());
            ThemChucNang("Gia hạn hợp đồng", () => new FrmGiaHan());

            ThemNhom("THANH TOÁN");

            ThemChucNang("Hóa đơn tiền thuê", () => new FrmHoaDonTienThue());
            ThemChucNang("Sử dụng dịch vụ", () => new FrmSuDungDichVu());
            ThemChucNang("Hóa đơn dịch vụ", () => new FrmHoaDonDichVu());
            ThemChucNang("Chi tiết hóa đơn DV", () => new FrmChiTietHoaDonDV());
            ThemChucNang("Thu tiền", () => new FrmThanhToan());
            ThemChucNang("Công nợ", () => new FrmCongNo());

            ThemNhom("NHÂN SỰ");

            ThemChucNang("Nhân viên công ty", () => new FrmNhanVien());
            ThemChucNang("Thẻ giữ xe", () => new FrmTheGiuXe());

            ThemNhom("KIỂM TRA");

            ThemChucNang("Phiếu kiểm tra phòng", () => new FrmPhieuKiemTra());
            ThemChucNang("Phiếu vi phạm", () => new FrmPhieuViPham());

            ThemNhom("BÁO CÁO");

            ThemChucNang("Thống kê", () => new FrmThongKe());
        }

        private void MoForm(string tieuDe, Func<Form> taoForm)
        {
            try
            {
                Form form = taoForm();

                if (currentForm != null)
                {
                    contentPanel.Controls.Remove(currentForm);
                    currentForm.Close();
                    currentForm.Dispose();
                }

                currentForm = form;

                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;

                contentPanel.Controls.Add(form);
                contentPanel.Tag = form;

                lblTieuDe.Text = tieuDe.ToUpper();

                form.Show();
                form.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể mở chức năng:\n" + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void HienThiTrangChu()
        {
            if (contentPanel == null)
                return;

            if (currentForm != null)
            {
                contentPanel.Controls.Remove(currentForm);
                currentForm.Close();
                currentForm.Dispose();
                currentForm = null;
            }

            contentPanel.Controls.Clear();

            lblTieuDe.Text = "TỔNG QUAN";

            Label lbl = new Label();
            lbl.Text = "HỆ THỐNG QUẢN LÝ CHO THUÊ VĂN PHÒNG Ở CAO ỐC";
            lbl.Dock = DockStyle.Top;
            lbl.Height = 60;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Font = new Font(
                "Microsoft Sans Serif",
                13,
                FontStyle.Bold
            );

            contentPanel.Controls.Add(lbl);
        }
    }
}
