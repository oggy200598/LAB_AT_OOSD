namespace eSHOPPING.UI
{
    partial class FrmNhapSoLuong
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container(); lblQuantity=new System.Windows.Forms.Label(); num=new System.Windows.Forms.NumericUpDown(); btnOk=new System.Windows.Forms.Button(); btnCancel=new System.Windows.Forms.Button(); ((System.ComponentModel.ISupportInitialize)(num)).BeginInit(); SuspendLayout();
            lblQuantity.AutoSize=true; lblQuantity.Location=new System.Drawing.Point(30,30); lblQuantity.Text="Số lượng";
            num.Location=new System.Drawing.Point(110,26); num.Size=new System.Drawing.Size(100,23); num.Minimum=1; num.Maximum=1;
            btnOk.Location=new System.Drawing.Point(75,75); btnOk.Size=new System.Drawing.Size(70,30); btnOk.Text="OK"; btnOk.Click+=new System.EventHandler(Ok_Click);
            btnCancel.Location=new System.Drawing.Point(155,75); btnCancel.Size=new System.Drawing.Size(70,30); btnCancel.Text="Hủy"; btnCancel.Click+=new System.EventHandler(Cancel_Click);
            AutoScaleDimensions=new System.Drawing.SizeF(7F,15F); ClientSize=new System.Drawing.Size(300,140); Controls.AddRange(new System.Windows.Forms.Control[]{lblQuantity,num,btnOk,btnCancel}); Name="FrmNhapSoLuong"; StartPosition=System.Windows.Forms.FormStartPosition.CenterParent; Text="Cập nhật số lượng"; ((System.ComponentModel.ISupportInitialize)(num)).EndInit(); ResumeLayout(false); PerformLayout();
        }
    }
}
