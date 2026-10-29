namespace QuanLyNhanSu.Forms
{
    partial class FrmKhenThuongKyLuat
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnQuyetDinhKhenThuong;
        private System.Windows.Forms.Button btnPhieuChiKhenThuong;
        private System.Windows.Forms.Button btnQuyetDinhKyLuat;
        private System.Windows.Forms.Button btnPhieuThuNopPhat;
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
            this.btnQuyetDinhKhenThuong = new System.Windows.Forms.Button();
            this.btnPhieuChiKhenThuong = new System.Windows.Forms.Button();
            this.btnQuyetDinhKyLuat = new System.Windows.Forms.Button();
            this.btnPhieuThuNopPhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTieuDe.Font = new System.Drawing.Font(
                "Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor =
                System.Drawing.Color.FromArgb(35, 60, 90);
            this.lblTieuDe.Location = new System.Drawing.Point(20, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(760, 65);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ KHEN THƯỞNG - KỶ LUẬT";
            this.lblTieuDe.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            this.btnQuyetDinhKhenThuong.Location =
                new System.Drawing.Point(175, 110);
            this.btnQuyetDinhKhenThuong.Name =
                "btnQuyetDinhKhenThuong";
            this.btnQuyetDinhKhenThuong.Size =
                new System.Drawing.Size(450, 55);
            this.btnQuyetDinhKhenThuong.TabIndex = 1;
            this.btnQuyetDinhKhenThuong.Text =
                "Quản lý quyết định khen thưởng";
            this.btnQuyetDinhKhenThuong.UseVisualStyleBackColor = true;
            this.btnQuyetDinhKhenThuong.Click +=
                new System.EventHandler(
                    this.btnQuyetDinhKhenThuong_Click);

            this.btnPhieuChiKhenThuong.Location =
                new System.Drawing.Point(175, 180);
            this.btnPhieuChiKhenThuong.Name = "btnPhieuChiKhenThuong";
            this.btnPhieuChiKhenThuong.Size =
                new System.Drawing.Size(450, 55);
            this.btnPhieuChiKhenThuong.TabIndex = 2;
            this.btnPhieuChiKhenThuong.Text =
                "Quản lý phiếu chi khen thưởng";
            this.btnPhieuChiKhenThuong.UseVisualStyleBackColor = true;
            this.btnPhieuChiKhenThuong.Click +=
                new System.EventHandler(
                    this.btnPhieuChiKhenThuong_Click);

            this.btnQuyetDinhKyLuat.Location =
                new System.Drawing.Point(175, 250);
            this.btnQuyetDinhKyLuat.Name = "btnQuyetDinhKyLuat";
            this.btnQuyetDinhKyLuat.Size =
                new System.Drawing.Size(450, 55);
            this.btnQuyetDinhKyLuat.TabIndex = 3;
            this.btnQuyetDinhKyLuat.Text =
                "Quản lý quyết định kỷ luật";
            this.btnQuyetDinhKyLuat.UseVisualStyleBackColor = true;
            this.btnQuyetDinhKyLuat.Click +=
                new System.EventHandler(
                    this.btnQuyetDinhKyLuat_Click);

            this.btnPhieuThuNopPhat.Location =
                new System.Drawing.Point(175, 320);
            this.btnPhieuThuNopPhat.Name = "btnPhieuThuNopPhat";
            this.btnPhieuThuNopPhat.Size =
                new System.Drawing.Size(450, 55);
            this.btnPhieuThuNopPhat.TabIndex = 4;
            this.btnPhieuThuNopPhat.Text =
                "Quản lý phiếu thu nộp phạt";
            this.btnPhieuThuNopPhat.UseVisualStyleBackColor = true;
            this.btnPhieuThuNopPhat.Click +=
                new System.EventHandler(
                    this.btnPhieuThuNopPhat_Click);

            this.btnThoat.BackColor = System.Drawing.Color.Firebrick;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(310, 410);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(180, 45);
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
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.btnQuyetDinhKhenThuong);
            this.Controls.Add(this.btnPhieuChiKhenThuong);
            this.Controls.Add(this.btnQuyetDinhKyLuat);
            this.Controls.Add(this.btnPhieuThuNopPhat);
            this.Controls.Add(this.btnThoat);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmKhenThuongKyLuat";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý khen thưởng - kỷ luật";
            this.ResumeLayout(false);
        }
    }
}