namespace QuanLyNhanSu.Forms
{
    partial class FrmQuanLyPhuTroi
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnPhieuPhuTroi;
        private System.Windows.Forms.Button btnChiTietPhuTroi;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnPhieuPhuTroi = new System.Windows.Forms.Button();
            this.btnChiTietPhuTroi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTieuDe.Font = new System.Drawing.Font(
                "Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor =
                System.Drawing.Color.FromArgb(35, 60, 90);
            this.lblTieuDe.Location = new System.Drawing.Point(25, 25);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(750, 75);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ PHỤ TRỘI";
            this.lblTieuDe.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            this.btnPhieuPhuTroi.BackColor = System.Drawing.Color.White;
            this.btnPhieuPhuTroi.Font = new System.Drawing.Font(
                "Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnPhieuPhuTroi.Location =
                new System.Drawing.Point(175, 140);
            this.btnPhieuPhuTroi.Name = "btnPhieuPhuTroi";
            this.btnPhieuPhuTroi.Size =
                new System.Drawing.Size(450, 70);
            this.btnPhieuPhuTroi.TabIndex = 1;
            this.btnPhieuPhuTroi.Text = "Quản lý phiếu phụ trội";
            this.btnPhieuPhuTroi.UseVisualStyleBackColor = false;
            this.btnPhieuPhuTroi.Click +=
                new System.EventHandler(this.btnPhieuPhuTroi_Click);

            this.btnChiTietPhuTroi.BackColor = System.Drawing.Color.White;
            this.btnChiTietPhuTroi.Font = new System.Drawing.Font(
                "Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnChiTietPhuTroi.Location =
                new System.Drawing.Point(175, 230);
            this.btnChiTietPhuTroi.Name = "btnChiTietPhuTroi";
            this.btnChiTietPhuTroi.Size =
                new System.Drawing.Size(450, 70);
            this.btnChiTietPhuTroi.TabIndex = 2;
            this.btnChiTietPhuTroi.Text = "Quản lý chi tiết phụ trội";
            this.btnChiTietPhuTroi.UseVisualStyleBackColor = false;
            this.btnChiTietPhuTroi.Click +=
                new System.EventHandler(this.btnChiTietPhuTroi_Click);

            this.btnThoat.BackColor = System.Drawing.Color.Firebrick;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location =
                new System.Drawing.Point(310, 340);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(180, 45);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Quay lại";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click +=
                new System.EventHandler(this.btnThoat_Click);

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.btnPhieuPhuTroi);
            this.Controls.Add(this.btnChiTietPhuTroi);
            this.Controls.Add(this.btnThoat);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmQuanLyPhuTroi";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý phụ trội";
            this.ResumeLayout(false);
        }
    }
}