using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCongTyDuLich.Forms
{
    public class FrmMain : Form
    {
        private readonly Color navy = Color.FromArgb(25, 39, 58);
        private readonly Color navyLight = Color.FromArgb(38, 55, 77);
        private readonly Color champagne = Color.FromArgb(197, 164, 103);
        private readonly Color champagneLight = Color.FromArgb(244, 235, 216);
        private readonly Color background = Color.FromArgb(250, 249, 246);
        private readonly Color textColor = Color.FromArgb(48, 53, 60);

        public FrmMain()
        {
            Text = "Luxury Travel | Quản lý công ty du lịch";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(1180, 780);
            MinimumSize = new Size(900, 620);
            BackColor = background;
            Font = new Font("Segoe UI", 10F);
            AutoScaleMode = AutoScaleMode.Font;

            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 3,
                BackColor = background,
                Margin = Padding.Empty,
                Padding = Padding.Empty
            };

            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 145F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));

            var header = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = navy,
                Padding = new Padding(35, 20, 25, 15),
                Margin = Padding.Empty
            };

            var brand = new Label
            {
                Text = "L U X U R Y   T R A V E L",
                Dock = DockStyle.Top,
                Height = 27,
                ForeColor = champagne,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            };

            var title = new Label
            {
                Text = "QUẢN LÝ CÔNG TY DU LỊCH",
                Dock = DockStyle.Top,
                Height = 48,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 20F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            };

            var subtitle = new Label
            {
                Text = "Quản lý tour, khách hàng, hướng dẫn viên và hoạt động kinh doanh",
                Dock = DockStyle.Top,
                Height = 28,
                ForeColor = champagneLight,
                Font = new Font("Segoe UI", 9.5F),
                TextAlign = ContentAlignment.MiddleLeft
            };

            header.Controls.Add(subtitle);
            header.Controls.Add(title);
            header.Controls.Add(brand);

            var content = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = background,
                Padding = new Padding(30, 20, 30, 18),
                Margin = Padding.Empty
            };

            var section = new Panel
            {
                Dock = DockStyle.Top,
                Height = 65,
                BackColor = background
            };

            var sectionTitle = new Label
            {
                Text = "DANH MỤC CHỨC NĂNG",
                Dock = DockStyle.Top,
                Height = 30,
                ForeColor = navy,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            };

            var sectionSubtitle = new Label
            {
                Text = "Chọn chức năng cần thực hiện",
                Dock = DockStyle.Top,
                Height = 25,
                ForeColor = Color.FromArgb(125, 119, 108),
                Font = new Font("Segoe UI", 9F),
                TextAlign = ContentAlignment.MiddleLeft
            };

            section.Controls.Add(sectionSubtitle);
            section.Controls.Add(sectionTitle);

            var scrollPanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = background,
                Padding = new Padding(0, 5, 0, 5)
            };

            var menu = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                ColumnCount = 2,
                RowCount = 5,
                BackColor = background,
                Margin = Padding.Empty,
                Padding = Padding.Empty
            };

            menu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            menu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            for (int i = 0; i < 5; i++)
            {
                menu.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            }

            AddMenuButton(menu, "01", "Quản lý danh mục",
                () => new FrmDanhMuc().ShowDialog(), 0, 0);

            AddMenuButton(menu, "02", "Quản lý tour",
                () => new FrmTour().ShowDialog(), 1, 0);

            AddMenuButton(menu, "03", "Quản lý chuyến khách lẻ",
                () => new FrmChuyenLe().ShowDialog(), 0, 1);

            AddMenuButton(menu, "04", "Đăng ký khách lẻ",
                () => new FrmDangKyLe().ShowDialog(), 1, 1);

            AddMenuButton(menu, "05", "Đăng ký đoàn khách",
                () => new FrmDangKyDoan().ShowDialog(), 0, 2);

            AddMenuButton(menu, "06", "Phân công hướng dẫn viên",
                () => new FrmPhanCongHDV().ShowDialog(), 1, 2);

            AddMenuButton(menu, "07", "Kết thúc tour / khảo sát",
                () => new FrmKetThucKhaoSat().ShowDialog(), 0, 3);

            AddMenuButton(menu, "08", "Lương và thống kê",
                () => new FrmLuongThongKe().ShowDialog(), 1, 3);

            AddMenuButton(menu, "09", "Kiểm tra kết nối SQL",
                CheckConnection, 0, 4);

            scrollPanel.Controls.Add(menu);
            content.Controls.Add(scrollPanel);
            content.Controls.Add(section);

            var footer = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Margin = Padding.Empty
            };

            var footerLine = new Panel
            {
                Dock = DockStyle.Top,
                Height = 1,
                BackColor = Color.FromArgb(225, 220, 210)
            };

            var footerText = new Label
            {
                Text = "LUXURY TRAVEL   |   HỆ THỐNG QUẢN LÝ DU LỊCH",
                Dock = DockStyle.Fill,
                ForeColor = Color.FromArgb(125, 119, 108),
                Font = new Font("Segoe UI", 8F, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.White
            };

            footer.Controls.Add(footerText);
            footer.Controls.Add(footerLine);

            layout.Controls.Add(header, 0, 0);
            layout.Controls.Add(content, 0, 1);
            layout.Controls.Add(footer, 0, 2);

            Controls.Add(layout);
        }

        private void AddMenuButton(
            TableLayoutPanel panel,
            string number,
            string text,
            Action action,
            int column,
            int row)
        {
            var button = new Button
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(7),
                BackColor = Color.White,
                ForeColor = navy,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(18, 0, 10, 0),
                UseVisualStyleBackColor = false
            };

            button.Text = number + "     " + text;
            button.FlatAppearance.BorderColor = Color.FromArgb(225, 220, 210);
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.MouseOverBackColor = champagneLight;
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(232, 219, 190);

            button.Paint += (sender, e) =>
            {
                using (var brush = new SolidBrush(champagne))
                {
                    e.Graphics.FillRectangle(
                        brush, 0, 0, 4, button.Height);
                }
            };

            button.Click += (sender, e) => action();
            panel.Controls.Add(button, column, row);
        }

        private void CheckConnection()
        {
            try
            {
                var result = Data.Db.Scalar("SELECT DB_NAME()");

                MessageBox.Show(
                    "Kết nối SQL Server thành công.\nCơ sở dữ liệu: " + result,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi kết nối",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}