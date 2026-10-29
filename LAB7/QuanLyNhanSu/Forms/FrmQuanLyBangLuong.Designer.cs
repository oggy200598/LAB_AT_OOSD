namespace QuanLyNhanSu.Forms
{
    partial class FrmQuanLyBangLuong
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnBangLuong;
        private System.Windows.Forms.Button btnChiTietBangLuong;
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
            this.btnBangLuong = new System.Windows.Forms.Button();
            this.btnChiTietBangLuong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTieuDe.Font = new System.Drawing.Font(
                "Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor =
                System.Drawing.Color.FromArgb(35, 60, 90);
            this.lblTieuDe.Location = new System.Drawing.Point(20, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(760, 75);
            this.lblTieuDe.Text = "QUẢN LÝ BẢNG LƯƠNG";
            this.lblTieuDe.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            this.btnBangLuong.Font = new System.Drawing.Font(
                "Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnBangLuong.Location =
                new System.Drawing.Point(175, 130);
            this.btnBangLuong.Name = "btnBangLuong";
            this.btnBangLuong.Size = new System.Drawing.Size(450, 65);
            this.btnBangLuong.Text = "Quản lý bảng lương";
            this.btnBangLuong.UseVisualStyleBackColor = true;
            this.btnBangLuong.Click +=
                new System.EventHandler(this.btnBangLuong_Click);

            this.btnChiTietBangLuong.Font = new System.Drawing.Font(
                "Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnChiTietBangLuong.Location =
                new System.Drawing.Point(175, 220);
            this.btnChiTietBangLuong.Name = "btnChiTietBangLuong";
            this.btnChiTietBangLuong.Size =
                new System.Drawing.Size(450, 65);
            this.btnChiTietBangLuong.Text = "Quản lý chi tiết bảng lương";
            this.btnChiTietBangLuong.UseVisualStyleBackColor = true;
            this.btnChiTietBangLuong.Click +=
                new System.EventHandler(this.btnChiTietBangLuong_Click);

            this.btnThoat.BackColor = System.Drawing.Color.Firebrick;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(310, 325);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(180, 45);
            this.btnThoat.Text = "Quay lại";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click +=
                new System.EventHandler(this.btnThoat_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.btnBangLuong);
            this.Controls.Add(this.btnChiTietBangLuong);
            this.Controls.Add(this.btnThoat);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmQuanLyBangLuong";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý bảng lương";
            this.ResumeLayout(false);
        }
    }
}