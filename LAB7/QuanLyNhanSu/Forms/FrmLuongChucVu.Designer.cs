
namespace QuanLyNhanSu.Forms
{
    partial class FrmLuongChucVu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnQuyetDinhLuong;
        private System.Windows.Forms.Button btnQuyetDinhChucVu;
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
            this.btnQuyetDinhLuong = new System.Windows.Forms.Button();
            this.btnQuyetDinhChucVu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTieuDe.Font = new System.Drawing.Font(
                "Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor =
                System.Drawing.Color.FromArgb(35, 60, 90);
            this.lblTieuDe.Location = new System.Drawing.Point(30, 30);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(740, 75);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUYẾT ĐỊNH LƯƠNG - CHỨC VỤ";
            this.lblTieuDe.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            this.btnQuyetDinhLuong.BackColor = System.Drawing.Color.White;
            this.btnQuyetDinhLuong.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnQuyetDinhLuong.FlatAppearance.BorderColor =
                System.Drawing.Color.LightSteelBlue;
            this.btnQuyetDinhLuong.Font = new System.Drawing.Font(
                "Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnQuyetDinhLuong.ForeColor =
                System.Drawing.Color.FromArgb(35, 60, 90);
            this.btnQuyetDinhLuong.Location =
                new System.Drawing.Point(165, 140);
            this.btnQuyetDinhLuong.Name = "btnQuyetDinhLuong";
            this.btnQuyetDinhLuong.Size =
                new System.Drawing.Size(470, 70);
            this.btnQuyetDinhLuong.TabIndex = 1;
            this.btnQuyetDinhLuong.Text = "Quản lý quyết định lương";
            this.btnQuyetDinhLuong.UseVisualStyleBackColor = false;
            this.btnQuyetDinhLuong.Click +=
                new System.EventHandler(this.btnQuyetDinhLuong_Click);

            this.btnQuyetDinhChucVu.BackColor = System.Drawing.Color.White;
            this.btnQuyetDinhChucVu.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnQuyetDinhChucVu.FlatAppearance.BorderColor =
                System.Drawing.Color.LightSteelBlue;
            this.btnQuyetDinhChucVu.Font = new System.Drawing.Font(
                "Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnQuyetDinhChucVu.ForeColor =
                System.Drawing.Color.FromArgb(35, 60, 90);
            this.btnQuyetDinhChucVu.Location =
                new System.Drawing.Point(165, 230);
            this.btnQuyetDinhChucVu.Name = "btnQuyetDinhChucVu";
            this.btnQuyetDinhChucVu.Size =
                new System.Drawing.Size(470, 70);
            this.btnQuyetDinhChucVu.TabIndex = 2;
            this.btnQuyetDinhChucVu.Text = "Quản lý quyết định chức vụ";
            this.btnQuyetDinhChucVu.UseVisualStyleBackColor = false;
            this.btnQuyetDinhChucVu.Click +=
                new System.EventHandler(this.btnQuyetDinhChucVu_Click);

            this.btnThoat.BackColor = System.Drawing.Color.Firebrick;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Font = new System.Drawing.Font(
                "Segoe UI", 11F, System.Drawing.FontStyle.Bold);
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

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.btnQuyetDinhLuong);
            this.Controls.Add(this.btnQuyetDinhChucVu);
            this.Controls.Add(this.btnThoat);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLuongChucVu";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quyết định lương - chức vụ";
            this.ResumeLayout(false);
        }
    }
}
