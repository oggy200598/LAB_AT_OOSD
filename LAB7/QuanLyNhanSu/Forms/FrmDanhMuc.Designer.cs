
namespace QuanLyNhanSu.Forms
{
    partial class FrmDanhMuc
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnPhongBan;
        private System.Windows.Forms.Button btnChucVu;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnPhongBan = new System.Windows.Forms.Button();
            this.btnChucVu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTieuDe.Font = new System.Drawing.Font(
                "Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor =
                System.Drawing.Color.FromArgb(35, 60, 90);
            this.lblTieuDe.Location = new System.Drawing.Point(40, 30);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(720, 65);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ DANH MỤC";
            this.lblTieuDe.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            this.lblMoTa.Font = new System.Drawing.Font(
                "Segoe UI", 11F);
            this.lblMoTa.ForeColor = System.Drawing.Color.DimGray;
            this.lblMoTa.Location = new System.Drawing.Point(80, 105);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(640, 35);
            this.lblMoTa.TabIndex = 1;
            this.lblMoTa.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            this.btnNhanVien.BackColor = System.Drawing.Color.White;
            this.btnNhanVien.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.FlatAppearance.BorderColor =
                System.Drawing.Color.LightSteelBlue;
            this.btnNhanVien.Font = new System.Drawing.Font(
                "Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnNhanVien.ForeColor =
                System.Drawing.Color.FromArgb(35, 60, 90);
            this.btnNhanVien.Location =
                new System.Drawing.Point(165, 160);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size =
                new System.Drawing.Size(470, 65);
            this.btnNhanVien.TabIndex = 2;
            this.btnNhanVien.Text = "Quản lý nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click +=
                new System.EventHandler(this.btnNhanVien_Click);

            this.btnPhongBan.BackColor = System.Drawing.Color.White;
            this.btnPhongBan.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnPhongBan.FlatAppearance.BorderColor =
                System.Drawing.Color.LightSteelBlue;
            this.btnPhongBan.Font = new System.Drawing.Font(
                "Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnPhongBan.ForeColor =
                System.Drawing.Color.FromArgb(35, 60, 90);
            this.btnPhongBan.Location =
                new System.Drawing.Point(165, 245);
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.Size =
                new System.Drawing.Size(470, 65);
            this.btnPhongBan.TabIndex = 3;
            this.btnPhongBan.Text = "Quản lý phòng ban";
            this.btnPhongBan.UseVisualStyleBackColor = false;
            this.btnPhongBan.Click +=
                new System.EventHandler(this.btnPhongBan_Click);

            this.btnChucVu.BackColor = System.Drawing.Color.White;
            this.btnChucVu.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnChucVu.FlatAppearance.BorderColor =
                System.Drawing.Color.LightSteelBlue;
            this.btnChucVu.Font = new System.Drawing.Font(
                "Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnChucVu.ForeColor =
                System.Drawing.Color.FromArgb(35, 60, 90);
            this.btnChucVu.Location =
                new System.Drawing.Point(165, 330);
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.Size =
                new System.Drawing.Size(470, 65);
            this.btnChucVu.TabIndex = 4;
            this.btnChucVu.Text = "Quản lý chức vụ";
            this.btnChucVu.UseVisualStyleBackColor = false;
            this.btnChucVu.Click +=
                new System.EventHandler(this.btnChucVu_Click);

            this.btnThoat.BackColor = System.Drawing.Color.Firebrick;
            this.btnThoat.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Font = new System.Drawing.Font(
                "Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location =
                new System.Drawing.Point(310, 425);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size =
                new System.Drawing.Size(180, 45);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Quay lại";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click +=
                new System.EventHandler(this.btnThoat_Click);

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.btnNhanVien);
            this.Controls.Add(this.btnPhongBan);
            this.Controls.Add(this.btnChucVu);
            this.Controls.Add(this.btnThoat);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDanhMuc";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh mục - Quản lý nhân sự";
            this.ResumeLayout(false);
        }
    }
}
