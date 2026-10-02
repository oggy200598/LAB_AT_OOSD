using System;
using System.Windows.Forms;
using eSHOPPING.Models;
using eSHOPPING.Services;

namespace eSHOPPING.UI
{
    public partial class FrmDangKy : Form
    {
        private readonly AuthService _service = new AuthService();

        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Họ tên, tên đăng nhập và mật khẩu là bắt buộc.");
                return;
            }
            try
            {
                string message;
                var user = new KhachHang
                {
                    HoTen = txtHoTen.Text,
                    NgaySinh = txtNgaySinh.Text,
                    CMNDPassport = txtCMND.Text,
                    DiaChi = txtDiaChi.Text,
                    DienThoai = txtDienThoai.Text,
                    TenDangNhap = txtUsername.Text,
                    MatKhau = txtPassword.Text,
                    Email = txtEmail.Text
                };
                if (_service.Register(user, out message))
                {
                    MessageBox.Show("Đăng ký thành công.");
                    Close();
                }
                else MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể đăng ký: " + ex.Message);
            }
        }
    }
}
