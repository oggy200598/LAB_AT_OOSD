namespace eSHOPPING.UI
{
    partial class FrmGioHang
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnClose;
        protected override void Dispose(bool disposing){if(disposing&&components!=null)components.Dispose();base.Dispose(disposing);}
        private void InitializeComponent()
        {
            components=new System.ComponentModel.Container(); lblTitle=new System.Windows.Forms.Label(); grid=new System.Windows.Forms.DataGridView(); lblTotal=new System.Windows.Forms.Label(); btnUpdate=new System.Windows.Forms.Button(); btnRemove=new System.Windows.Forms.Button(); btnCheckout=new System.Windows.Forms.Button(); btnClose=new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(grid)).BeginInit(); SuspendLayout();
            lblTitle.AutoSize=true; lblTitle.Font=new System.Drawing.Font("Segoe UI",18F,System.Drawing.FontStyle.Bold); lblTitle.Location=new System.Drawing.Point(25,20); lblTitle.Text="GIỎ HÀNG";
            grid.Location=new System.Drawing.Point(25,70); grid.Size=new System.Drawing.Size(830,360); grid.ReadOnly=true; grid.AutoGenerateColumns=false; grid.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; grid.MultiSelect=false; grid.AllowUserToAddRows=false;
            grid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn{HeaderText="Mã SP",DataPropertyName="MaSP",Width=70});
            grid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn{HeaderText="Sản phẩm",DataPropertyName="TenSP",Width=290});
            grid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn{HeaderText="Đơn giá",DataPropertyName="GiaBan",Width=130,DefaultCellStyle=new System.Windows.Forms.DataGridViewCellStyle{Format="N0"}});
            grid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn{HeaderText="Số lượng",DataPropertyName="SoLuong",Width=90});
            grid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn{HeaderText="Thành tiền",DataPropertyName="ThanhTien",Width=160,DefaultCellStyle=new System.Windows.Forms.DataGridViewCellStyle{Format="N0"}});
            lblTotal.AutoSize=true; lblTotal.Font=new System.Drawing.Font("Segoe UI",13F,System.Drawing.FontStyle.Bold); lblTotal.Location=new System.Drawing.Point(540,450); lblTotal.Text="Tổng: 0 đ";
            SetupButton(btnUpdate,"Cập nhật số lượng",25,445,135,34,new System.EventHandler(Update_Click)); SetupButton(btnRemove,"Xóa sản phẩm",170,445,120,34,new System.EventHandler(Remove_Click)); SetupButton(btnCheckout,"Tính tiền / Đặt hàng",300,445,165,34,new System.EventHandler(Checkout_Click)); SetupButton(btnClose,"Đóng",720,445,100,34,new System.EventHandler(Close_Click));
            AutoScaleDimensions=new System.Drawing.SizeF(7F,15F); ClientSize=new System.Drawing.Size(900,510); Controls.AddRange(new System.Windows.Forms.Control[]{lblTitle,grid,lblTotal,btnUpdate,btnRemove,btnCheckout,btnClose}); Name="FrmGioHang"; StartPosition=System.Windows.Forms.FormStartPosition.CenterParent; Text="e-SHOPPING - Giỏ hàng"; ((System.ComponentModel.ISupportInitialize)(grid)).EndInit(); ResumeLayout(false); PerformLayout();
        }
        private void SetupButton(System.Windows.Forms.Button c,string text,int x,int y,int w,int h,System.EventHandler handler){c.Location=new System.Drawing.Point(x,y);c.Size=new System.Drawing.Size(w,h);c.Text=text;c.Click+=handler;}
    }
}
