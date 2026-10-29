
namespace QuanLyNhanSu.Forms
{
    partial class FrmKeHoachChamCong
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnKeHoachTuan;
        private System.Windows.Forms.Button btnCaLamViec;
        private System.Windows.Forms.Button btnChiTietPhanCong;
        private System.Windows.Forms.Button btnBangChamCong;
        private System.Windows.Forms.Button btnChiTietChamCong;
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
            this.btnKeHoachTuan = new System.Windows.Forms.Button();
            this.btnCaLamViec = new System.Windows.Forms.Button();
            this.btnChiTietPhanCong = new System.Windows.Forms.Button();
            this.btnBangChamCong = new System.Windows.Forms.Button();
            this.btnChiTietChamCong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTieuDe.Font = new System.Drawing.Font(
                "Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor =
                System.Drawing.Color.FromArgb(35, 60, 90);
            this.lblTieuDe.Location = new System.Drawing.Point(25, 25);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(750, 65);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "KẾ HOẠCH - CHẤM CÔNG";
            this.lblTieuDe.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            this.btnKeHoachTuan.Location =
                new System.Drawing.Point(175, 110);
            this.btnKeHoachTuan.Name = "btnKeHoachTuan";
            this.btnKeHoachTuan.Size =
                new System.Drawing.Size(450, 55);
            this.btnKeHoachTuan.TabIndex = 1;
            this.btnKeHoachTuan.Text = "Quản lý kế hoạch tuần";
            this.btnKeHoachTuan.UseVisualStyleBackColor = true;
            this.btnKeHoachTuan.Click +=
                new System.EventHandler(this.btnKeHoachTuan_Click);

            this.btnCaLamViec.Location =
                new System.Drawing.Point(175, 180);
            this.btnCaLamViec.Name = "btnCaLamViec";
            this.btnCaLamViec.Size =
                new System.Drawing.Size(450, 55);
            this.btnCaLamViec.TabIndex = 2;
            this.btnCaLamViec.Text = "Quản lý ca làm việc";
            this.btnCaLamViec.UseVisualStyleBackColor = true;
            this.btnCaLamViec.Click +=
                new System.EventHandler(this.btnCaLamViec_Click);

            this.btnChiTietPhanCong.Location =
                new System.Drawing.Point(175, 250);
            this.btnChiTietPhanCong.Name = "btnChiTietPhanCong";
            this.btnChiTietPhanCong.Size =
                new System.Drawing.Size(450, 55);
            this.btnChiTietPhanCong.TabIndex = 3;
            this.btnChiTietPhanCong.Text = "Chi tiết phân công";
            this.btnChiTietPhanCong.UseVisualStyleBackColor = true;
            this.btnChiTietPhanCong.Click +=
                new System.EventHandler(this.btnChiTietPhanCong_Click);

            this.btnBangChamCong.Location =
                new System.Drawing.Point(175, 320);
            this.btnBangChamCong.Name = "btnBangChamCong";
            this.btnBangChamCong.Size =
                new System.Drawing.Size(450, 55);
            this.btnBangChamCong.TabIndex = 4;
            this.btnBangChamCong.Text = "Quản lý bảng chấm công";
            this.btnBangChamCong.UseVisualStyleBackColor = true;
            this.btnBangChamCong.Click +=
                new System.EventHandler(this.btnBangChamCong_Click);

            this.btnChiTietChamCong.Location =
                new System.Drawing.Point(175, 390);
            this.btnChiTietChamCong.Name = "btnChiTietChamCong";
            this.btnChiTietChamCong.Size =
                new System.Drawing.Size(450, 55);
            this.btnChiTietChamCong.TabIndex = 5;
            this.btnChiTietChamCong.Text = "Chi tiết chấm công";
            this.btnChiTietChamCong.UseVisualStyleBackColor = true;
            this.btnChiTietChamCong.Click +=
                new System.EventHandler(this.btnChiTietChamCong_Click);

            this.btnThoat.BackColor = System.Drawing.Color.Firebrick;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location =
                new System.Drawing.Point(310, 470);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size =
                new System.Drawing.Size(180, 45);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Quay lại";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click +=
                new System.EventHandler(this.btnThoat_Click);

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.btnKeHoachTuan);
            this.Controls.Add(this.btnCaLamViec);
            this.Controls.Add(this.btnChiTietPhanCong);
            this.Controls.Add(this.btnBangChamCong);
            this.Controls.Add(this.btnChiTietChamCong);
            this.Controls.Add(this.btnThoat);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmKeHoachChamCong";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kế hoạch - Chấm công";
            this.ResumeLayout(false);
        }
    }
}
