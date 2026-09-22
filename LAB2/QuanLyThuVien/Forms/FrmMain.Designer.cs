namespace QuanLyThuVien.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTieuDe;

        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Button btnDocGia;
        private System.Windows.Forms.Button btnMuonTra;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();

            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.btnDocGia = new System.Windows.Forms.Button();
            this.btnMuonTra = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();

            this.pnlMain.SuspendLayout();
            this.SuspendLayout();

            this.pnlMain.BackColor =
                System.Drawing.Color.WhiteSmoke;

            this.pnlMain.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlMain.Controls.Add(this.lblTieuDe);

            this.pnlMain.Controls.Add(this.btnDanhMuc);
            this.pnlMain.Controls.Add(this.btnSach);

            this.pnlMain.Controls.Add(this.btnDocGia);
            this.pnlMain.Controls.Add(this.btnMuonTra);

            this.pnlMain.Controls.Add(this.btnThongKe);
            this.pnlMain.Controls.Add(this.btnThoat);

            this.pnlMain.Location =
                new System.Drawing.Point(0, 0);

            this.pnlMain.Name =
                "pnlMain";

            this.pnlMain.Size =
                new System.Drawing.Size(974, 598);

            this.pnlMain.TabIndex = 0;

            this.lblTieuDe.AutoSize = true;

            this.lblTieuDe.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    20F,
                    System.Drawing.FontStyle.Bold);

            this.lblTieuDe.ForeColor =
                System.Drawing.Color.FromArgb(31, 73, 110);

            this.lblTieuDe.Location =
                new System.Drawing.Point(264, 39);

            this.lblTieuDe.Name =
                "lblTieuDe";

            this.lblTieuDe.Size =
                new System.Drawing.Size(445, 37);

            this.lblTieuDe.TabIndex = 0;

            this.lblTieuDe.Text =
                "HỆ THỐNG QUẢN LÝ THƯ VIỆN";

            this.btnDanhMuc.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    12F,
                    System.Drawing.FontStyle.Regular);

            this.btnDanhMuc.Location =
                new System.Drawing.Point(96, 133);

            this.btnDanhMuc.Name =
                "btnDanhMuc";

            this.btnDanhMuc.Size =
                new System.Drawing.Size(296, 58);

            this.btnDanhMuc.TabIndex = 1;

            this.btnDanhMuc.Text =
                "Danh mục / Nhân viên";

            this.btnDanhMuc.UseVisualStyleBackColor =
                true;

            this.btnDanhMuc.Click +=
                new System.EventHandler(
                    this.btnDanhMuc_Click);

            this.btnSach.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    12F,
                    System.Drawing.FontStyle.Regular);

            this.btnSach.Location =
                new System.Drawing.Point(582, 133);

            this.btnSach.Name =
                "btnSach";

            this.btnSach.Size =
                new System.Drawing.Size(296, 58);

            this.btnSach.TabIndex = 2;

            this.btnSach.Text =
                "Quản lý đầu sách";

            this.btnSach.UseVisualStyleBackColor =
                true;

            this.btnSach.Click +=
                new System.EventHandler(
                    this.btnSach_Click);

            this.btnDocGia.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    12F,
                    System.Drawing.FontStyle.Regular);

            this.btnDocGia.Location =
                new System.Drawing.Point(96, 239);

            this.btnDocGia.Name =
                "btnDocGia";

            this.btnDocGia.Size =
                new System.Drawing.Size(296, 58);

            this.btnDocGia.TabIndex = 3;

            this.btnDocGia.Text =
                "Độc giả và thẻ";

            this.btnDocGia.UseVisualStyleBackColor =
                true;

            this.btnDocGia.Click +=
                new System.EventHandler(
                    this.btnDocGia_Click);

            this.btnMuonTra.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    12F,
                    System.Drawing.FontStyle.Regular);

            this.btnMuonTra.Location =
                new System.Drawing.Point(582, 239);

            this.btnMuonTra.Name =
                "btnMuonTra";

            this.btnMuonTra.Size =
                new System.Drawing.Size(296, 58);

            this.btnMuonTra.TabIndex = 4;

            this.btnMuonTra.Text =
                "Mượn - Trả sách";

            this.btnMuonTra.UseVisualStyleBackColor =
                true;

            this.btnMuonTra.Click +=
                new System.EventHandler(
                    this.btnMuonTra_Click);

            this.btnThongKe.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    12F,
                    System.Drawing.FontStyle.Regular);

            this.btnThongKe.Location =
                new System.Drawing.Point(96, 345);

            this.btnThongKe.Name =
                "btnThongKe";

            this.btnThongKe.Size =
                new System.Drawing.Size(296, 58);

            this.btnThongKe.TabIndex = 5;

            this.btnThongKe.Text =
                "Thống kê";

            this.btnThongKe.UseVisualStyleBackColor =
                true;

            this.btnThongKe.Click +=
                new System.EventHandler(
                    this.btnThongKe_Click);

            this.btnThoat.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    12F,
                    System.Drawing.FontStyle.Regular);

            this.btnThoat.Location =
                new System.Drawing.Point(582, 345);

            this.btnThoat.Name =
                "btnThoat";

            this.btnThoat.Size =
                new System.Drawing.Size(296, 58);

            this.btnThoat.TabIndex = 6;

            this.btnThoat.Text =
                "Thoát";

            this.btnThoat.UseVisualStyleBackColor =
                true;

            this.btnThoat.Click +=
                new System.EventHandler(
                    this.btnThoat_Click);

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(974, 598);

            this.Controls.Add(this.pnlMain);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.Name =
                "FrmMain";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Quản lý thư viện";

            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();

            this.ResumeLayout(false);
        }

        #endregion
    }
}