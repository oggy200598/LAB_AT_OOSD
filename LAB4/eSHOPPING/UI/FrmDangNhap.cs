using System;
using System.Windows.Forms;
using eSHOPPING.Services;

namespace eSHOPPING.UI
{
    public partial class FrmDangNhap : Form
    {
        private readonly AuthService _service = new AuthService();

        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            try
            {
                var user = _service.Login(txtUsername.Text, txtPassword.Text);
                if (user == null)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
                    return;
                }
                SessionService.CurrentCustomer = user;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể đăng nhập: " + ex.Message);
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            new FrmDangKy().ShowDialog(this);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
