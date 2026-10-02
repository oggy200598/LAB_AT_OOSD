namespace eSHOPPING.UI
{
    partial class FrmSanPham
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.DataGridView grid;
        protected override void Dispose(bool disposing){if(disposing&&components!=null)components.Dispose();base.Dispose(disposing);}
        private void InitializeComponent()
        {
            components=new System.ComponentModel.Container(); lblTitle=new System.Windows.Forms.Label(); lblUser=new System.Windows.Forms.Label(); btnLogin=new System.Windows.Forms.Button(); btnRegister=new System.Windows.Forms.Button(); lblGroup=new System.Windows.Forms.Label(); cboGroup=new System.Windows.Forms.ComboBox(); lblSearch=new System.Windows.Forms.Label(); txtSearch=new System.Windows.Forms.TextBox(); btnDetail=new System.Windows.Forms.Button(); btnAdd=new System.Windows.Forms.Button(); btnCart=new System.Windows.Forms.Button(); lblCart=new System.Windows.Forms.Label(); grid=new System.Windows.Forms.DataGridView(); ((System.ComponentModel.ISupportInitialize)(grid)).BeginInit(); SuspendLayout();
            lblTitle.AutoSize=true; lblTitle.Font=new System.Drawing.Font("Segoe UI",22F,System.Drawing.FontStyle.Bold); lblTitle.Location=new System.Drawing.Point(25,18); lblTitle.Text="e-SHOPPING";
            lblUser.AutoSize=true; lblUser.Location=new System.Drawing.Point(780,28); lblUser.Text="Khách chưa đăng nhập"; btnLogin.Location=new System.Drawing.Point(930,20); btnLogin.Size=new System.Drawing.Size(95,32); btnLogin.Text="Đăng nhập"; btnLogin.Click+=new System.EventHandler(Login_Click); btnRegister.Location=new System.Drawing.Point(1030,20); btnRegister.Size=new System.Drawing.Size(95,32); btnRegister.Text="Đăng ký"; btnRegister.Click+=new System.EventHandler(Register_Click);
            lblGroup.AutoSize=true; lblGroup.Location=new System.Drawing.Point(25,80); lblGroup.Text="Nhóm sản phẩm"; cboGroup.Location=new System.Drawing.Point(125,76); cboGroup.Size=new System.Drawing.Size(220,23); cboGroup.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList; cboGroup.SelectedIndexChanged+=new System.EventHandler(GroupOrSearchChanged);
            lblSearch.AutoSize=true; lblSearch.Location=new System.Drawing.Point(370,80); lblSearch.Text="Tìm kiếm"; txtSearch.Location=new System.Drawing.Point(430,76); txtSearch.Size=new System.Drawing.Size(260,23); txtSearch.TextChanged+=new System.EventHandler(GroupOrSearchChanged);
            btnDetail.Location=new System.Drawing.Point(705,74); btnDetail.Size=new System.Drawing.Size(110,32); btnDetail.Text="Xem chi tiết"; btnDetail.Click+=new System.EventHandler(Detail_Click); btnAdd.Location=new System.Drawing.Point(820,74); btnAdd.Size=new System.Drawing.Size(120,32); btnAdd.Text="Thêm vào giỏ"; btnAdd.Click+=new System.EventHandler(Add_Click); btnCart.Location=new System.Drawing.Point(945,74); btnCart.Size=new System.Drawing.Size(100,32); btnCart.Text="Giỏ hàng"; btnCart.Click+=new System.EventHandler(Cart_Click); lblCart.AutoSize=true; lblCart.Location=new System.Drawing.Point(1055,82); lblCart.Text="0 sản phẩm";
            grid.Location=new System.Drawing.Point(25,125); grid.Size=new System.Drawing.Size(1110,520); grid.ReadOnly=true; grid.AutoGenerateColumns=false; grid.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; grid.MultiSelect=false; grid.AllowUserToAddRows=false; grid.DoubleClick+=new System.EventHandler(Grid_DoubleClick);
            grid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn{HeaderText="Mã SP",DataPropertyName="MaSP",Width=70}); grid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn{HeaderText="Tên sản phẩm",DataPropertyName="TenSP",Width=260}); grid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn{HeaderText="Nhà sản xuất",DataPropertyName="NhaSanXuat",Width=160}); grid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn{HeaderText="Nhóm",DataPropertyName="TenNhom",Width=180}); grid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn{HeaderText="Giá bán",DataPropertyName="GiaBan",Width=130,DefaultCellStyle=new System.Windows.Forms.DataGridViewCellStyle{Format="N0"}}); grid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn{HeaderText="Tồn kho",DataPropertyName="TonKho",Width=90});
            AutoScaleDimensions=new System.Drawing.SizeF(7F,15F); ClientSize=new System.Drawing.Size(1180,680); Controls.AddRange(new System.Windows.Forms.Control[]{lblTitle,lblUser,btnLogin,btnRegister,lblGroup,cboGroup,lblSearch,txtSearch,btnDetail,btnAdd,btnCart,lblCart,grid}); Name="FrmSanPham"; StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen; Text="e-SHOPPING - Sản phẩm"; MinimumSize=new System.Drawing.Size(1000,650); ((System.ComponentModel.ISupportInitialize)(grid)).EndInit(); ResumeLayout(false); PerformLayout();
        }
    }
}
