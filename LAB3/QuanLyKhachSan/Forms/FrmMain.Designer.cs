namespace QuanLyKhachSan.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;

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
            this.pnlMenu = new System.Windows.Forms.Panel();

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblMenuTitle = new System.Windows.Forms.Label();
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
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();

            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1000, 650);
            this.pnlMain.TabIndex = 0;

            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(25, 55, 90);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 155);
            this.pnlHeader.TabIndex = 0;

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                25F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point
            );
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(260, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(481, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HỆ THỐNG QUẢN LÝ KHÁCH SẠN";

            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                10.5F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point
            );
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            this.lblSubTitle.Location = new System.Drawing.Point(318, 91);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(365, 19);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "PHẦN MỀM QUẢN LÝ VÀ VẬN HÀNH KHÁCH SẠN";

            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 155);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1000, 495);
            this.pnlContent.TabIndex = 1;

            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Location = new System.Drawing.Point(95, 25);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(810, 375);
            this.pnlMenu.TabIndex = 0;

            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                13F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point
            );
            this.lblMenuTitle.ForeColor = System.Drawing.Color.FromArgb(35, 65, 100);
            this.lblMenuTitle.Location = new System.Drawing.Point(32, 20);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(169, 23);
            this.lblMenuTitle.TabIndex = 0;
            this.lblMenuTitle.Text = "CHỨC NĂNG CHÍNH";

            this.btnDanhMuc.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.btnDanhMuc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 220, 230);
            this.btnDanhMuc.FlatAppearance.BorderSize = 1;
            this.btnDanhMuc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(220, 230, 240);
            this.btnDanhMuc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(230, 239, 249);
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.Font = new System.Drawing.Font(
                "Segoe UI",
                11F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point
            );
            this.btnDanhMuc.ForeColor = System.Drawing.Color.FromArgb(30, 70, 110);
            this.btnDanhMuc.Location = new System.Drawing.Point(35, 65);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(355, 62);
            this.btnDanhMuc.TabIndex = 1;
            this.btnDanhMuc.Text = "DANH MỤC";
            this.btnDanhMuc.UseVisualStyleBackColor = false;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);

            this.btnPhong.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.btnPhong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 220, 230);
            this.btnPhong.FlatAppearance.BorderSize = 1;
            this.btnPhong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(220, 230, 240);
            this.btnPhong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(230, 239, 249);
            this.btnPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhong.Font = new System.Drawing.Font(
                "Segoe UI",
                11F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point
            );
            this.btnPhong.ForeColor = System.Drawing.Color.FromArgb(30, 70, 110);
            this.btnPhong.Location = new System.Drawing.Point(420, 65);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(355, 62);
            this.btnPhong.TabIndex = 2;
            this.btnPhong.Text = "PHÒNG & TIỆN NGHI";
            this.btnPhong.UseVisualStyleBackColor = false;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);

            this.btnDatPhong.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.btnDatPhong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 220, 230);
            this.btnDatPhong.FlatAppearance.BorderSize = 1;
            this.btnDatPhong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(220, 230, 240);
            this.btnDatPhong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(230, 239, 249);
            this.btnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatPhong.Font = new System.Drawing.Font(
                "Segoe UI",
                11F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point
            );
            this.btnDatPhong.ForeColor = System.Drawing.Color.FromArgb(30, 70, 110);
            this.btnDatPhong.Location = new System.Drawing.Point(35, 142);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(355, 62);
            this.btnDatPhong.TabIndex = 3;
            this.btnDatPhong.Text = "ĐẶT PHÒNG";
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);

            this.btnDichVu.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.btnDichVu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 220, 230);
            this.btnDichVu.FlatAppearance.BorderSize = 1;
            this.btnDichVu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(220, 230, 240);
            this.btnDichVu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(230, 239, 249);
            this.btnDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDichVu.Font = new System.Drawing.Font(
                "Segoe UI",
                11F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point
            );
            this.btnDichVu.ForeColor = System.Drawing.Color.FromArgb(30, 70, 110);
            this.btnDichVu.Location = new System.Drawing.Point(420, 142);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(355, 62);
            this.btnDichVu.TabIndex = 4;
            this.btnDichVu.Text = "SỬ DỤNG DỊCH VỤ";
            this.btnDichVu.UseVisualStyleBackColor = false;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);

            this.btnTraPhong.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.btnTraPhong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 220, 230);
            this.btnTraPhong.FlatAppearance.BorderSize = 1;
            this.btnTraPhong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(220, 230, 240);
            this.btnTraPhong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(230, 239, 249);
            this.btnTraPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraPhong.Font = new System.Drawing.Font(
                "Segoe UI",
                11F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point
            );
            this.btnTraPhong.ForeColor = System.Drawing.Color.FromArgb(30, 70, 110);
            this.btnTraPhong.Location = new System.Drawing.Point(35, 219);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(355, 62);
            this.btnTraPhong.TabIndex = 5;
            this.btnTraPhong.Text = "TRẢ PHÒNG";
            this.btnTraPhong.UseVisualStyleBackColor = false;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);

            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.btnThongKe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 220, 230);
            this.btnThongKe.FlatAppearance.BorderSize = 1;
            this.btnThongKe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(220, 230, 240);
            this.btnThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(230, 239, 249);
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font(
                "Segoe UI",
                11F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point
            );
            this.btnThongKe.ForeColor = System.Drawing.Color.FromArgb(30, 70, 110);
            this.btnThongKe.Location = new System.Drawing.Point(420, 219);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(355, 62);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "THỐNG KÊ - BÁO CÁO";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);

            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(190, 55, 55);
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(135, 35, 35);
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(165, 45, 45);
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font(
                "Segoe UI",
                10.5F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point
            );
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(305, 305);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(200, 48);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point
            );
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(120, 130, 140);
            this.lblFooter.Location = new System.Drawing.Point(386, 420);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(228, 15);
            this.lblFooter.TabIndex = 2;
            this.lblFooter.Text = "Quản lý khách sạn - Version 1.0";

            this.pnlMenu.Controls.Add(this.lblMenuTitle);
            this.pnlMenu.Controls.Add(this.btnDanhMuc);
            this.pnlMenu.Controls.Add(this.btnPhong);
            this.pnlMenu.Controls.Add(this.btnDatPhong);
            this.pnlMenu.Controls.Add(this.btnDichVu);
            this.pnlMenu.Controls.Add(this.btnTraPhong);
            this.pnlMenu.Controls.Add(this.btnThongKe);
            this.pnlMenu.Controls.Add(this.btnThoat);

            this.pnlContent.Controls.Add(this.pnlMenu);
            this.pnlContent.Controls.Add(this.lblFooter);

            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubTitle);

            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlHeader);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách sạn";
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);

            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}