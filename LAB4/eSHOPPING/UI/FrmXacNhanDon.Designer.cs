namespace eSHOPPING.UI
{
    partial class FrmXacNhanDon
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.Button btnClose;
        protected override void Dispose(bool disposing){if(disposing&&components!=null)components.Dispose();base.Dispose(disposing);}
        private void InitializeComponent()
        {
            components=new System.ComponentModel.Container(); lblTitle=new System.Windows.Forms.Label(); info=new System.Windows.Forms.TextBox(); btnClose=new System.Windows.Forms.Button(); SuspendLayout();
            lblTitle.AutoSize=true; lblTitle.Font=new System.Drawing.Font("Segoe UI",18F,System.Drawing.FontStyle.Bold); lblTitle.Location=new System.Drawing.Point(135,30); lblTitle.Text="ĐẶT HÀNG THÀNH CÔNG";
            info.Location=new System.Drawing.Point(50,90); info.Size=new System.Drawing.Size(450,190); info.Multiline=true; info.ReadOnly=true; info.ScrollBars=System.Windows.Forms.ScrollBars.Vertical;
            btnClose.Location=new System.Drawing.Point(225,300); btnClose.Size=new System.Drawing.Size(100,35); btnClose.Text="Đóng"; btnClose.Click+=new System.EventHandler(Close_Click);
            AutoScaleDimensions=new System.Drawing.SizeF(7F,15F); ClientSize=new System.Drawing.Size(560,360); Controls.AddRange(new System.Windows.Forms.Control[]{lblTitle,info,btnClose}); Name="FrmXacNhanDon"; StartPosition=System.Windows.Forms.FormStartPosition.CenterParent; Text="e-SHOPPING - Xác nhận đơn hàng"; ResumeLayout(false); PerformLayout();
        }
    }
}
