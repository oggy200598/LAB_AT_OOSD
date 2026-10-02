namespace eSHOPPING.UI
{
    partial class FrmChiTietSanPham
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblNhaSanXuat;
        private System.Windows.Forms.Label lblNhom;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblTonKho;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblThongSo;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtNhaSanXuat;
        private System.Windows.Forms.TextBox txtNhom;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtTonKho;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtThongSo;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnClose;
        protected override void Dispose(bool disposing){if(disposing&&components!=null)components.Dispose();base.Dispose(disposing);}
        private void InitializeComponent()
        {
            components=new System.ComponentModel.Container(); lblTitle=new System.Windows.Forms.Label(); lblMaSP=new System.Windows.Forms.Label(); lblNhaSanXuat=new System.Windows.Forms.Label(); lblNhom=new System.Windows.Forms.Label(); lblGiaBan=new System.Windows.Forms.Label(); lblTonKho=new System.Windows.Forms.Label(); lblMoTa=new System.Windows.Forms.Label(); lblThongSo=new System.Windows.Forms.Label(); lblQty=new System.Windows.Forms.Label(); txtMaSP=new System.Windows.Forms.TextBox(); txtNhaSanXuat=new System.Windows.Forms.TextBox(); txtNhom=new System.Windows.Forms.TextBox(); txtGiaBan=new System.Windows.Forms.TextBox(); txtTonKho=new System.Windows.Forms.TextBox(); txtMoTa=new System.Windows.Forms.TextBox(); txtThongSo=new System.Windows.Forms.TextBox(); numQuantity=new System.Windows.Forms.NumericUpDown(); btnAdd=new System.Windows.Forms.Button(); btnCart=new System.Windows.Forms.Button(); btnClose=new System.Windows.Forms.Button(); ((System.ComponentModel.ISupportInitialize)(numQuantity)).BeginInit(); SuspendLayout();
            lblTitle.AutoSize=true; lblTitle.Font=new System.Drawing.Font("Segoe UI",18F,System.Drawing.FontStyle.Bold); lblTitle.Location=new System.Drawing.Point(25,20); lblTitle.Text="Chi tiết sản phẩm";
            SetupLabel(lblMaSP,"Mã sản phẩm",25,75); SetupLabel(lblNhaSanXuat,"Nhà sản xuất",25,110); SetupLabel(lblNhom,"Nhóm",25,145); SetupLabel(lblGiaBan,"Giá bán",25,180); SetupLabel(lblTonKho,"Tồn kho",25,215); SetupLabel(lblMoTa,"Mô tả",25,260); SetupLabel(lblThongSo,"Thông số kỹ thuật",25,350);
            SetupReadonly(txtMaSP,145,71,500,23); SetupReadonly(txtNhaSanXuat,145,106,500,23); SetupReadonly(txtNhom,145,141,500,23); SetupReadonly(txtGiaBan,145,176,500,23); SetupReadonly(txtTonKho,145,211,500,23); SetupReadonly(txtMoTa,145,256,500,70); txtMoTa.Multiline=true; txtMoTa.ScrollBars=System.Windows.Forms.ScrollBars.Vertical; SetupReadonly(txtThongSo,145,346,500,70); txtThongSo.Multiline=true; txtThongSo.ScrollBars=System.Windows.Forms.ScrollBars.Vertical;
            lblQty.AutoSize=true; lblQty.Location=new System.Drawing.Point(25,445); lblQty.Text="Số lượng"; numQuantity.Location=new System.Drawing.Point(110,441); numQuantity.Size=new System.Drawing.Size(80,23); numQuantity.Minimum=1; numQuantity.Maximum=1;
            btnAdd.Location=new System.Drawing.Point(215,438); btnAdd.Size=new System.Drawing.Size(125,34); btnAdd.Text="Thêm vào giỏ"; btnAdd.Click+=new System.EventHandler(Add_Click); btnCart.Location=new System.Drawing.Point(350,438); btnCart.Size=new System.Drawing.Size(125,34); btnCart.Text="Mở giỏ hàng"; btnCart.Click+=new System.EventHandler(Cart_Click); btnClose.Location=new System.Drawing.Point(485,438); btnClose.Size=new System.Drawing.Size(90,34); btnClose.Text="Đóng"; btnClose.Click+=new System.EventHandler(Close_Click);
            AutoScaleDimensions=new System.Drawing.SizeF(7F,15F); ClientSize=new System.Drawing.Size(700,520); Controls.AddRange(new System.Windows.Forms.Control[]{lblTitle,lblMaSP,lblNhaSanXuat,lblNhom,lblGiaBan,lblTonKho,lblMoTa,lblThongSo,lblQty,txtMaSP,txtNhaSanXuat,txtNhom,txtGiaBan,txtTonKho,txtMoTa,txtThongSo,numQuantity,btnAdd,btnCart,btnClose}); Name="FrmChiTietSanPham"; StartPosition=System.Windows.Forms.FormStartPosition.CenterParent; Text="e-SHOPPING - Chi tiết sản phẩm"; ((System.ComponentModel.ISupportInitialize)(numQuantity)).EndInit(); ResumeLayout(false); PerformLayout();
        }
        private void SetupLabel(System.Windows.Forms.Label c,string text,int x,int y){c.AutoSize=true;c.Location=new System.Drawing.Point(x,y);c.Text=text;}
        private void SetupReadonly(System.Windows.Forms.TextBox c,int x,int y,int w,int h){c.Location=new System.Drawing.Point(x,y);c.Size=new System.Drawing.Size(w,h);c.ReadOnly=true;}
    }
}
