namespace eSHOPPING.UI
{
    partial class FrmThanhToan
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCardType;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblExpiry;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCsv;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtExpiry;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCsv;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnClose;
        protected override void Dispose(bool disposing){if(disposing&&components!=null)components.Dispose();base.Dispose(disposing);}
        private void InitializeComponent()
        {
            components=new System.ComponentModel.Container(); lblTitle=new System.Windows.Forms.Label(); lblCardType=new System.Windows.Forms.Label(); lblNumber=new System.Windows.Forms.Label(); lblExpiry=new System.Windows.Forms.Label(); lblName=new System.Windows.Forms.Label(); lblCsv=new System.Windows.Forms.Label(); cboType=new System.Windows.Forms.ComboBox(); txtNumber=new System.Windows.Forms.TextBox(); txtExpiry=new System.Windows.Forms.TextBox(); txtName=new System.Windows.Forms.TextBox(); txtCsv=new System.Windows.Forms.TextBox(); lblAmount=new System.Windows.Forms.Label(); btnPay=new System.Windows.Forms.Button(); btnClose=new System.Windows.Forms.Button(); SuspendLayout();
            lblTitle.AutoSize=true; lblTitle.Font=new System.Drawing.Font("Segoe UI",17F,System.Drawing.FontStyle.Bold); lblTitle.Location=new System.Drawing.Point(135,20); lblTitle.Text="THANH TOÁN THẺ TÍN DỤNG";
            SetupLabel(lblCardType,"Loại thẻ",50,85); SetupLabel(lblNumber,"Số hiệu thẻ",50,130); SetupLabel(lblExpiry,"Ngày hết hạn (MM/yyyy)",50,178); SetupLabel(lblName,"Họ tên chủ thẻ",50,226); SetupLabel(lblCsv,"Mã an ninh (CSV)",50,274);
            cboType.Location=new System.Drawing.Point(210,80); cboType.Size=new System.Drawing.Size(300,23); cboType.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList; cboType.Items.AddRange(new object[]{"VISA","MasterCard","Discover","American Express"}); cboType.SelectedIndex=0;
            SetupText(txtNumber,210,125); SetupText(txtExpiry,210,173); SetupText(txtName,210,221); SetupText(txtCsv,210,269); txtCsv.UseSystemPasswordChar=true;
            lblAmount.AutoSize=true; lblAmount.Font=new System.Drawing.Font("Segoe UI",12F,System.Drawing.FontStyle.Bold); lblAmount.Location=new System.Drawing.Point(210,325); lblAmount.Text="Số tiền: 0 đ";
            btnPay.Location=new System.Drawing.Point(210,370); btnPay.Size=new System.Drawing.Size(170,38); btnPay.Text="Xác nhận thanh toán"; btnPay.Click+=new System.EventHandler(Pay_Click); btnClose.Location=new System.Drawing.Point(390,370); btnClose.Size=new System.Drawing.Size(100,38); btnClose.Text="Hủy"; btnClose.Click+=new System.EventHandler(Close_Click);
            AutoScaleDimensions=new System.Drawing.SizeF(7F,15F); ClientSize=new System.Drawing.Size(620,445); Controls.AddRange(new System.Windows.Forms.Control[]{lblTitle,lblCardType,lblNumber,lblExpiry,lblName,lblCsv,cboType,txtNumber,txtExpiry,txtName,txtCsv,lblAmount,btnPay,btnClose}); Name="FrmThanhToan"; StartPosition=System.Windows.Forms.FormStartPosition.CenterParent; Text="e-SHOPPING - Thanh toán"; ResumeLayout(false); PerformLayout();
        }
        private void SetupLabel(System.Windows.Forms.Label c,string text,int x,int y){c.AutoSize=true;c.Location=new System.Drawing.Point(x,y);c.Text=text;}
        private void SetupText(System.Windows.Forms.TextBox c,int x,int y){c.Location=new System.Drawing.Point(x,y);c.Size=new System.Drawing.Size(300,23);}
    }
}
