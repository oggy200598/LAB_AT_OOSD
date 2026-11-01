using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Forms
{
    public class FrmKetNoi : Form
    {
        private readonly TextBox server = new TextBox();
        private readonly TextBox user = new TextBox();
        private readonly TextBox password = new TextBox();
        private readonly CheckBox windows = new CheckBox();
        private readonly Label notice = new Label();

        public FrmKetNoi()
        {
            Text = "Kết nối và khởi tạo SQL Server";
            Width = 560;
            Height = 335;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            var builder = new SqlConnectionStringBuilder(Database.ConnectionString);
            server.Text = builder.DataSource;
            windows.Text = "Windows Authentication";
            windows.Checked = builder.IntegratedSecurity;
            windows.CheckedChanged += (s, e) => ToggleAuth();
            user.Text = builder.UserID;
            password.UseSystemPasswordChar = true;
            password.Text = builder.Password;
            AddLine("Máy chủ SQL Server:", server, 20);
            windows.SetBounds(160, 59, 250, 25);
            Controls.Add(windows);
            AddLine("Tên đăng nhập:", user, 94);
            AddLine("Mật khẩu:", password, 132);
            var test = new Button { Text = "Kết nối / Khởi tạo CSDL", Left = 160, Top = 174, Width = 205, Height = 35 };
            test.Click += Connect;
            Controls.Add(test);
            var close = new Button { Text = "Thoát", Left = 375, Top = 174, Width = 100, Height = 35 };
            close.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
            Controls.Add(close);
            notice.SetBounds(20, 219, 500, 70);
            notice.Text = "Có thể dùng (localdb)\\MSSQLLocalDB hoặc .\\SQLEXPRESS.\nChương trình tự tạo bảng và dữ liệu mẫu khi kết nối thành công.";
            Controls.Add(notice);
            ToggleAuth();
        }

        private void AddLine(string label, TextBox field, int top)
        {
            Controls.Add(new Label { Text = label, Left = 20, Top = top + 5, Width = 140 });
            field.SetBounds(160, top, 315, 24);
            Controls.Add(field);
        }

        private void ToggleAuth()
        {
            user.Enabled = !windows.Checked;
            password.Enabled = !windows.Checked;
        }

        private void Connect(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(server.Text)) { MessageBox.Show("Chưa nhập máy chủ SQL Server."); return; }
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = server.Text.Trim(),
                InitialCatalog = "QuanLyChoThueVanPhong",
                IntegratedSecurity = windows.Checked,
                ConnectTimeout = 8,
                TrustServerCertificate = true,
                MultipleActiveResultSets = false
            };
            if (!windows.Checked)
            {
                builder.UserID = user.Text.Trim();
                builder.Password = password.Text;
            }
            try
            {
                Cursor = Cursors.WaitCursor;
                Database.Initialize(builder.ConnectionString);
                Database.SaveConnectionString(builder.ConnectionString);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối/khởi tạo CSDL:\n" + ex.Message, "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { Cursor = Cursors.Default; }
        }
    }
}
