
using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyBenhAn_GiaHuy.Data;
using QuanLyBenhAn_GiaHuy.Services;

namespace QuanLyBenhAn_GiaHuy.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            BuildMenu();
            ShowHome();
        }

        private void BuildMenu()
        {
            int y = 0;

            AddNav("Tổng quan", null, ref y);

            foreach (var t in Catalog.Tables)
            {
                AddNav(t.Title, t, ref y);
            }
        }

        private void AddNav(string caption, TableDef table, ref int y)
        {
            Button b = new Button();

            b.Text = caption;
            b.TextAlign = ContentAlignment.MiddleLeft;
            b.Font = new Font("Segoe UI", 10F);

            b.SetBounds(10, y, 215, 40);

            b.Click += (s, e) =>
            {
                if (table == null)
                    ShowHome();
                else
                    ShowTable(table);
            };

            nav.Controls.Add(b);
            y += 43;
        }

        private void ClearContent()
        {
            content.Controls.Clear();
        }

        private void ShowHome()
        {
            ClearContent();

            title.Text = "Tổng quan quản lý";

            Label intro = new Label();
            intro.Text = "Quản lý hồ sơ bệnh án";
            intro.Font = new Font("Segoe UI", 14F);
            intro.AutoSize = true;
            intro.Location = new Point(30, 25);

            content.Controls.Add(intro);

            string[] labels =
            {
                "Bệnh nhân",
                "Hồ sơ bệnh án",
                "Phiếu khám",
                "Toa thuốc"
            };

            string[] names =
            {
                "BenhNhan",
                "HoSoBenhAn",
                "PhieuKham",
                "ToaThuoc"
            };

            int y = 85;

            for (int i = 0; i < 4; i++)
            {
                int n = 0;
                string status = "";

                try
                {
                    var dt = Db.Query(
                        "SELECT COUNT(*) FROM [" + names[i] + "]"
                    );

                    n = Convert.ToInt32(dt.Rows[0][0]);
                }
                catch (Exception)
                {
                    status = "Chưa kết nối SQL";
                }

                Label lbl = new Label();

                lbl.Text = labels[i] + ": " +
                    (status == "" ? n.ToString() : status);

                lbl.Font = new Font("Segoe UI", 11F);
                lbl.AutoSize = true;
                lbl.Location = new Point(30, y);

                content.Controls.Add(lbl);

                y += 45;
            }

            Label hint = new Label();

            hint.Text =
                "Chọn chức năng bên trái để quản lý dữ liệu.\n" +
                "Cấu hình SQL Server trong App.config.";

            hint.Font = new Font("Segoe UI", 10F);
            hint.AutoSize = true;
            hint.Location = new Point(30, 300);

            content.Controls.Add(hint);
        }

        private void ShowTable(TableDef t)
        {
            ClearContent();

            title.Text = t.Title;

            FrmDanhSach f = new FrmDanhSach(t);

            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;

            content.Controls.Add(f);
            f.Show();
        }

        private void summary_Click(object sender, EventArgs e)
        {
            ShowHome();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
