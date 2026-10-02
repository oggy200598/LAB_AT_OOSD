namespace eSHOPPING.UI
{
    partial class FrmDangKy
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitle = new System.Windows.Forms.Label();
            lblHoTen = new System.Windows.Forms.Label(); lblNgaySinh = new System.Windows.Forms.Label(); lblCMND = new System.Windows.Forms.Label(); lblDiaChi = new System.Windows.Forms.Label(); lblDienThoai = new System.Windows.Forms.Label(); lblUsername = new System.Windows.Forms.Label(); lblPassword = new System.Windows.Forms.Label(); lblEmail = new System.Windows.Forms.Label();
            txtHoTen = new System.Windows.Forms.TextBox(); txtNgaySinh = new System.Windows.Forms.TextBox(); txtCMND = new System.Windows.Forms.TextBox(); txtDiaChi = new System.Windows.Forms.TextBox(); txtDienThoai = new System.Windows.Forms.TextBox(); txtUsername = new System.Windows.Forms.TextBox(); txtPassword = new System.Windows.Forms.TextBox(); txtEmail = new System.Windows.Forms.TextBox();
            btnRegister = new System.Windows.Forms.Button();
            SuspendLayout();
            lblTitle.AutoSize = true; lblTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold); lblTitle.Location = new System.Drawing.Point(135,20); lblTitle.Text = "ĐĂNG KÝ KHÁCH HÀNG";
            SetupLabel(lblHoTen, "Họ tên", 45, 79); SetupLabel(lblNgaySinh, "Ngày sinh (dd/MM/yyyy)", 45,124); SetupLabel(lblCMND, "CMND/Passport",45,169); SetupLabel(lblDiaChi,"Địa chỉ",45,214); SetupLabel(lblDienThoai,"Điện thoại",45,259); SetupLabel(lblUsername,"Tên đăng nhập",45,304); SetupLabel(lblPassword,"Mật khẩu",45,349); SetupLabel(lblEmail,"Email",45,394);
            SetupText(txtHoTen,205,75); SetupText(txtNgaySinh,205,120); SetupText(txtCMND,205,165); SetupText(txtDiaChi,205,210); SetupText(txtDienThoai,205,255); SetupText(txtUsername,205,300); SetupText(txtPassword,205,345); txtPassword.UseSystemPasswordChar = true; SetupText(txtEmail,205,390);
            btnRegister.Location = new System.Drawing.Point(195,445); btnRegister.Size = new System.Drawing.Size(140,36); btnRegister.Text="Tạo tài khoản"; btnRegister.Click += new System.EventHandler(Register_Click);
            AutoScaleDimensions = new System.Drawing.SizeF(7F,15F); ClientSize = new System.Drawing.Size(550,500); Controls.AddRange(new System.Windows.Forms.Control[]{lblTitle,lblHoTen,lblNgaySinh,lblCMND,lblDiaChi,lblDienThoai,lblUsername,lblPassword,lblEmail,txtHoTen,txtNgaySinh,txtCMND,txtDiaChi,txtDienThoai,txtUsername,txtPassword,txtEmail,btnRegister}); Name="FrmDangKy"; StartPosition=System.Windows.Forms.FormStartPosition.CenterParent; Text="e-SHOPPING - Đăng ký khách hàng"; ResumeLayout(false); PerformLayout();
        }

        private void SetupLabel(System.Windows.Forms.Label c, string text, int x, int y)
        {
            c.AutoSize = true; c.Location = new System.Drawing.Point(x,y); c.Text=text;
        }
        private void SetupText(System.Windows.Forms.TextBox c, int x, int y)
        {
            c.Location = new System.Drawing.Point(x,y); c.Size = new System.Drawing.Size(280,23);
        }
    }
}
