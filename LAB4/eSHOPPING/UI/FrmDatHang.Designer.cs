namespace eSHOPPING.UI
{
    partial class FrmDatHang
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblKhuVuc;
        private System.Windows.Forms.Label lblLoaiGiao;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.ComboBox cboKhuVuc;
        private System.Windows.Forms.ComboBox cboGiaoHang;
        private System.Windows.Forms.Label lblFree;
        private System.Windows.Forms.Label lblTienHang;
        private System.Windows.Forms.Label lblPhi;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnClose;
        protected override void Dispose(bool disposing){if(disposing&&components!=null)components.Dispose();base.Dispose(disposing);}
        private void InitializeComponent()
        {
            components=new System.ComponentModel.Container(); lblTitle=new System.Windows.Forms.Label(); lblHoTen=new System.Windows.Forms.Label(); lblDiaChi=new System.Windows.Forms.Label(); lblDienThoai=new System.Windows.Forms.Label(); lblKhuVuc=new System.Windows.Forms.Label(); lblLoaiGiao=new System.Windows.Forms.Label(); txtHoTen=new System.Windows.Forms.TextBox(); txtDiaChi=new System.Windows.Forms.TextBox(); txtDienThoai=new System.Windows.Forms.TextBox(); cboKhuVuc=new System.Windows.Forms.ComboBox(); cboGiaoHang=new System.Windows.Forms.ComboBox(); lblFree=new System.Windows.Forms.Label(); lblTienHang=new System.Windows.Forms.Label(); lblPhi=new System.Windows.Forms.Label(); lblTong=new System.Windows.Forms.Label(); btnPay=new System.Windows.Forms.Button(); btnClose=new System.Windows.Forms.Button(); SuspendLayout();
            lblTitle.AutoSize=true; lblTitle.Font=new System.Drawing.Font("Segoe UI",17F,System.Drawing.FontStyle.Bold); lblTitle.Location=new System.Drawing.Point(150,20); lblTitle.Text="THÔNG TIN ĐẶT HÀNG";
            SetupLabel(lblHoTen,"Họ tên người nhận",50,85); SetupLabel(lblDiaChi,"Địa chỉ",50,130); SetupLabel(lblDienThoai,"Điện thoại",50,175); SetupLabel(lblKhuVuc,"Khu vực",50,220); SetupLabel(lblLoaiGiao,"Loại giao hàng",50,265);
            SetupText(txtHoTen,210,80); SetupText(txtDiaChi,210,125); SetupText(txtDienThoai,210,170); SetupCombo(cboKhuVuc,210,215,new object[]{"TP.HCM","Long An","Đồng Nai","Bình Dương","Tỉnh khác"}); SetupCombo(cboGiaoHang,210,260,new object[]{"Thường","Chuyển phát nhanh","Chuyển phát nhanh trong ngày"});
            cboKhuVuc.SelectedIndex=0; cboGiaoHang.SelectedIndex=0; cboKhuVuc.SelectedIndexChanged+=new System.EventHandler(ShippingChanged); cboGiaoHang.SelectedIndexChanged+=new System.EventHandler(ShippingChanged);
            lblFree.AutoSize=true; lblFree.Location=new System.Drawing.Point(50,325); lblFree.Text=""; lblTienHang.AutoSize=true; lblTienHang.Location=new System.Drawing.Point(370,325); lblTienHang.Text="Tiền hàng: 0 đ"; lblPhi.AutoSize=true; lblPhi.Location=new System.Drawing.Point(370,357); lblPhi.Text="Phí giao hàng: 0 đ"; lblTong.AutoSize=true; lblTong.Font=new System.Drawing.Font("Segoe UI",13F,System.Drawing.FontStyle.Bold); lblTong.Location=new System.Drawing.Point(300,389); lblTong.Text="Tổng thanh toán: 0 đ";
            btnPay.Location=new System.Drawing.Point(200,450); btnPay.Size=new System.Drawing.Size(180,38); btnPay.Text="Tiếp tục thanh toán"; btnPay.Click+=new System.EventHandler(Pay_Click); btnClose.Location=new System.Drawing.Point(390,450); btnClose.Size=new System.Drawing.Size(100,38); btnClose.Text="Hủy"; btnClose.Click+=new System.EventHandler(Close_Click);
            AutoScaleDimensions=new System.Drawing.SizeF(7F,15F); ClientSize=new System.Drawing.Size(620,525); Controls.AddRange(new System.Windows.Forms.Control[]{lblTitle,lblHoTen,lblDiaChi,lblDienThoai,lblKhuVuc,lblLoaiGiao,txtHoTen,txtDiaChi,txtDienThoai,cboKhuVuc,cboGiaoHang,lblFree,lblTienHang,lblPhi,lblTong,btnPay,btnClose}); Name="FrmDatHang"; StartPosition=System.Windows.Forms.FormStartPosition.CenterParent; Text="e-SHOPPING - Đặt hàng"; ResumeLayout(false); PerformLayout();
        }
        private void SetupLabel(System.Windows.Forms.Label c,string text,int x,int y){c.AutoSize=true;c.Location=new System.Drawing.Point(x,y);c.Text=text;}
        private void SetupText(System.Windows.Forms.TextBox c,int x,int y){c.Location=new System.Drawing.Point(x,y);c.Size=new System.Drawing.Size(300,23);}
        private void SetupCombo(System.Windows.Forms.ComboBox c,int x,int y,object[] items){c.Location=new System.Drawing.Point(x,y);c.Size=new System.Drawing.Size(300,23);c.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;c.Items.AddRange(items);}
    }
}
