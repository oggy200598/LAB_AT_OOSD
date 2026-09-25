namespace QuanLyKhachSan.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblFooter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();

            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnPhong = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();

            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();

            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(900, 600);
            this.pnlMain.TabIndex = 0;

            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(20, 55, 95);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 145);
            this.pnlHeader.TabIndex = 0;

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                24F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point
            );
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(205, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(490, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HỆ THỐNG QUẢN LÝ KHÁCH SẠN";

            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point
            );
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            this.lblSubTitle.Location = new System.Drawing.Point(314, 88);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(272, 19);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Phần mềm quản lý và vận hành khách sạn";

            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 145);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(900, 455);
            this.pnlContent.TabIndex = 1;

            this.btnDanhMuc.BackColor = System.Drawing.Color.White;
            this.btnDanhMuc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 220, 230);
            this.btnDanhMuc.FlatAppearance.BorderSize = 1;
            this.btnDanhMuc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(232, 240, 250);
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.Font = new System.Drawing.Font(
                "Segoe UI",
                12F,
                System.Drawing.FontStyle.Bold
            );
            this.btnDanhMuc.ForeColor = System.Drawing.Color.FromArgb(25, 65, 105);
            this.btnDanhMuc.Location = new System.Drawing.Point(115, 45);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(300, 70);
            this.btnDanhMuc.TabIndex = 0;
            this.btnDanhMuc.Text = "DANH MỤC";
            this.btnDanhMuc.UseVisualStyleBackColor = false;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);

            this.btnPhong.BackColor = System.Drawing.Color.White;
            this.btnPhong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 220, 230);
            this.btnPhong.FlatAppearance.BorderSize = 1;
            this.btnPhong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(232, 240, 250);
            this.btnPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhong.Font = new System.Drawing.Font(
                "Segoe UI",
                12F,
                System.Drawing.FontStyle.Bold
            );
            this.btnPhong.ForeColor = System.Drawing.Color.FromArgb(25, 65, 105);
            this.btnPhong.Location = new System.Drawing.Point(485, 45);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(300, 70);
            this.btnPhong.TabIndex = 1;
            this.btnPhong.Text = "PHÒNG & TIỆN NGHI";
            this.btnPhong.UseVisualStyleBackColor = false;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);

            this.btnDatPhong.BackColor = System.Drawing.Color.White;
            this.btnDatPhong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 220, 230);
            this.btnDatPhong.FlatAppearance.BorderSize = 1;
            this.btnDatPhong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(232, 240, 250);
            this.btnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatPhong.Font = new System.Drawing.Font(
                "Segoe UI",
                12F,
                System.Drawing.FontStyle.Bold
            );
            this.btnDatPhong.ForeColor = System.Drawing.Color.FromArgb(25, 65, 105);
            this.btnDatPhong.Location = new System.Drawing.Point(115, 135);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(300, 70);
            this.btnDatPhong.TabIndex = 2;
            this.btnDatPhong.Text = "ĐẶT PHÒNG";
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);

            this.btnDichVu.BackColor = System.Drawing.Color.White;
            this.btnDichVu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 220, 230);
            this.btnDichVu.FlatAppearance.BorderSize = 1;
            this.btnDichVu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(232, 240, 250);
            this.btnDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDichVu.Font = new System.Drawing.Font(
                "Segoe UI",
                12F,
                System.Drawing.FontStyle.Bold
            );
            this.btnDichVu.ForeColor = System.Drawing.Color.FromArgb(25, 65, 105);
            this.btnDichVu.Location = new System.Drawing.Point(485, 135);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(300, 70);
            this.btnDichVu.TabIndex = 3;
            this.btnDichVu.Text = "SỬ DỤNG DỊCH VỤ";
            this.btnDichVu.UseVisualStyleBackColor = false;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);

            this.btnTraPhong.BackColor = System.Drawing.Color.White;
            this.btnTraPhong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 220, 230);
            this.btnTraPhong.FlatAppearance.BorderSize = 1;
            this.btnTraPhong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(232, 240, 250);
            this.btnTraPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraPhong.Font = new System.Drawing.Font(
                "Segoe UI",
                12F,
                System.Drawing.FontStyle.Bold
            );
            this.btnTraPhong.ForeColor = System.Drawing.Color.FromArgb(25, 65, 105);
            this.btnTraPhong.Location = new System.Drawing.Point(115, 225);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(300, 70);
            this.btnTraPhong.TabIndex = 4;
            this.btnTraPhong.Text = "TRẢ PHÒNG";
            this.btnTraPhong.UseVisualStyleBackColor = false;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);

            this.btnThongKe.BackColor = System.Drawing.Color.White;
            this.btnThongKe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 220, 230);
            this.btnThongKe.FlatAppearance.BorderSize = 1;
            this.btnThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(232, 240, 250);
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font(
                "Segoe UI",
                12F,
                System.Drawing.FontStyle.Bold
            );
            this.btnThongKe.ForeColor = System.Drawing.Color.FromArgb(25, 65, 105);
            this.btnThongKe.Location = new System.Drawing.Point(485, 225);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(300, 70);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "THỐNG KÊ - BÁO CÁO";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);

            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(190, 55, 55);
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(160, 40, 40);
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font(
                "Segoe UI",
                11F,
                System.Drawing.FontStyle.Bold
            );
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(350, 320);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(200, 50);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Regular
            );
            this.lblFooter.ForeColor = System.Drawing.Color.Gray;
            this.lblFooter.Location = new System.Drawing.Point(337, 390);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(226, 15);
            this.lblFooter.TabIndex = 7;
            this.lblFooter.Text = "Quản lý khách sạn - Version 1.0";

            this.pnlContent.Controls.Add(this.btnDanhMuc);
            this.pnlContent.Controls.Add(this.btnPhong);
            this.pnlContent.Controls.Add(this.btnDatPhong);
            this.pnlContent.Controls.Add(this.btnDichVu);
            this.pnlContent.Controls.Add(this.btnTraPhong);
            this.pnlContent.Controls.Add(this.btnThongKe);
            this.pnlContent.Controls.Add(this.btnThoat);
            this.pnlContent.Controls.Add(this.lblFooter);

            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubTitle);

            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlHeader);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách sạn";
            this.BackColor = System.Drawing.Color.White;

            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}