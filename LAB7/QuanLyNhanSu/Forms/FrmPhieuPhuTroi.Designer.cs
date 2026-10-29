namespace QuanLyNhanSu.Forms
{
    partial class FrmPhieuPhuTroi
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.Label lblSoPhieu;
        private System.Windows.Forms.Label lblNgayPhuTroi;
        private System.Windows.Forms.Label lblSoGio;
        private System.Windows.Forms.Label lblHinhThuc;
        private System.Windows.Forms.Label lblNguoiLap;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblTimKiem;

        private System.Windows.Forms.TextBox txtMaPhieuPhuTroi;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.TextBox txtNguoiLap;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTimKiem;

        private System.Windows.Forms.DateTimePicker dtpNgayPhuTroi;
        private System.Windows.Forms.NumericUpDown nudSoGioPhuTroi;
        private System.Windows.Forms.ComboBox cboHinhThuc;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvPhieuPhuTroi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.lblNgayPhuTroi = new System.Windows.Forms.Label();
            this.lblSoGio = new System.Windows.Forms.Label();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.lblNguoiLap = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtMaPhieuPhuTroi = new System.Windows.Forms.TextBox();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.txtNguoiLap = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dtpNgayPhuTroi = new System.Windows.Forms.DateTimePicker();
            this.nudSoGioPhuTroi = new System.Windows.Forms.NumericUpDown();
            this.cboHinhThuc = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvPhieuPhuTroi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoGioPhuTroi)).BeginInit();
            this.grpThongTin.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuPhuTroi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1050, 65);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ PHIẾU PHỤ TRỘI";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaPhieu
            // 
            this.lblMaPhieu.AutoSize = true;
            this.lblMaPhieu.Location = new System.Drawing.Point(20, 40);
            this.lblMaPhieu.Name = "lblMaPhieu";
            this.lblMaPhieu.Size = new System.Drawing.Size(213, 32);
            this.lblMaPhieu.TabIndex = 0;
            this.lblMaPhieu.Text = "Mã phiếu phụ trội:";
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.AutoSize = true;
            this.lblSoPhieu.Location = new System.Drawing.Point(525, 40);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(114, 32);
            this.lblSoPhieu.TabIndex = 1;
            this.lblSoPhieu.Text = "Số phiếu:";
            // 
            // lblNgayPhuTroi
            // 
            this.lblNgayPhuTroi.AutoSize = true;
            this.lblNgayPhuTroi.Location = new System.Drawing.Point(20, 85);
            this.lblNgayPhuTroi.Name = "lblNgayPhuTroi";
            this.lblNgayPhuTroi.Size = new System.Drawing.Size(167, 32);
            this.lblNgayPhuTroi.TabIndex = 2;
            this.lblNgayPhuTroi.Text = "Ngày phụ trội:";
            // 
            // lblSoGio
            // 
            this.lblSoGio.AutoSize = true;
            this.lblSoGio.Location = new System.Drawing.Point(525, 85);
            this.lblSoGio.Name = "lblSoGio";
            this.lblSoGio.Size = new System.Drawing.Size(179, 32);
            this.lblSoGio.TabIndex = 3;
            this.lblSoGio.Text = "Số giờ phụ trội:";
            // 
            // lblHinhThuc
            // 
            this.lblHinhThuc.AutoSize = true;
            this.lblHinhThuc.Location = new System.Drawing.Point(20, 130);
            this.lblHinhThuc.Name = "lblHinhThuc";
            this.lblHinhThuc.Size = new System.Drawing.Size(124, 32);
            this.lblHinhThuc.TabIndex = 4;
            this.lblHinhThuc.Text = "Hình thức:";
            // 
            // lblNguoiLap
            // 
            this.lblNguoiLap.AutoSize = true;
            this.lblNguoiLap.Location = new System.Drawing.Point(525, 130);
            this.lblNguoiLap.Name = "lblNguoiLap";
            this.lblNguoiLap.Size = new System.Drawing.Size(124, 32);
            this.lblNguoiLap.TabIndex = 5;
            this.lblNguoiLap.Text = "Người lập:";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(20, 178);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(101, 32);
            this.lblGhiChu.TabIndex = 6;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(20, 35);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(118, 32);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tìm kiếm:";
            // 
            // txtMaPhieuPhuTroi
            // 
            this.txtMaPhieuPhuTroi.Location = new System.Drawing.Point(229, 36);
            this.txtMaPhieuPhuTroi.MaxLength = 20;
            this.txtMaPhieuPhuTroi.Name = "txtMaPhieuPhuTroi";
            this.txtMaPhieuPhuTroi.Size = new System.Drawing.Size(275, 39);
            this.txtMaPhieuPhuTroi.TabIndex = 0;
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoPhieu.Location = new System.Drawing.Point(675, 36);
            this.txtSoPhieu.MaxLength = 30;
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(300, 39);
            this.txtSoPhieu.TabIndex = 1;
            // 
            // txtNguoiLap
            // 
            this.txtNguoiLap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNguoiLap.Location = new System.Drawing.Point(675, 126);
            this.txtNguoiLap.MaxLength = 100;
            this.txtNguoiLap.Name = "txtNguoiLap";
            this.txtNguoiLap.Size = new System.Drawing.Size(300, 39);
            this.txtNguoiLap.TabIndex = 5;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.Location = new System.Drawing.Point(185, 174);
            this.txtGhiChu.MaxLength = 500;
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGhiChu.Size = new System.Drawing.Size(790, 60);
            this.txtGhiChu.TabIndex = 6;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(115, 31);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(730, 39);
            this.txtTimKiem.TabIndex = 0;
            // 
            // dtpNgayPhuTroi
            // 
            this.dtpNgayPhuTroi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayPhuTroi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayPhuTroi.Location = new System.Drawing.Point(185, 81);
            this.dtpNgayPhuTroi.Name = "dtpNgayPhuTroi";
            this.dtpNgayPhuTroi.Size = new System.Drawing.Size(275, 39);
            this.dtpNgayPhuTroi.TabIndex = 2;
            // 
            // nudSoGioPhuTroi
            // 
            this.nudSoGioPhuTroi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSoGioPhuTroi.DecimalPlaces = 2;
            this.nudSoGioPhuTroi.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudSoGioPhuTroi.Location = new System.Drawing.Point(710, 85);
            this.nudSoGioPhuTroi.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudSoGioPhuTroi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudSoGioPhuTroi.Name = "nudSoGioPhuTroi";
            this.nudSoGioPhuTroi.Size = new System.Drawing.Size(262, 39);
            this.nudSoGioPhuTroi.TabIndex = 3;
            this.nudSoGioPhuTroi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboHinhThuc
            // 
            this.cboHinhThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThuc.FormattingEnabled = true;
            this.cboHinhThuc.Items.AddRange(new object[] {
            "Tăng ca",
            "Ngày lễ",
            "Ngày nghỉ"});
            this.cboHinhThuc.Location = new System.Drawing.Point(185, 126);
            this.cboHinhThuc.Name = "cboHinhThuc";
            this.cboHinhThuc.Size = new System.Drawing.Size(275, 39);
            this.cboHinhThuc.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SeaGreen;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(25, 350);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 40);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(145, 350);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 40);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Firebrick;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(265, 350);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 40);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(385, 350);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(116, 40);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(855, 28);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(145, 42);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Location = new System.Drawing.Point(915, 350);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 40);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grpThongTin
            // 
            this.grpThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTin.Controls.Add(this.lblMaPhieu);
            this.grpThongTin.Controls.Add(this.lblSoPhieu);
            this.grpThongTin.Controls.Add(this.lblNgayPhuTroi);
            this.grpThongTin.Controls.Add(this.lblSoGio);
            this.grpThongTin.Controls.Add(this.lblHinhThuc);
            this.grpThongTin.Controls.Add(this.lblNguoiLap);
            this.grpThongTin.Controls.Add(this.lblGhiChu);
            this.grpThongTin.Controls.Add(this.txtMaPhieuPhuTroi);
            this.grpThongTin.Controls.Add(this.txtSoPhieu);
            this.grpThongTin.Controls.Add(this.dtpNgayPhuTroi);
            this.grpThongTin.Controls.Add(this.nudSoGioPhuTroi);
            this.grpThongTin.Controls.Add(this.cboHinhThuc);
            this.grpThongTin.Controls.Add(this.txtNguoiLap);
            this.grpThongTin.Controls.Add(this.txtGhiChu);
            this.grpThongTin.Location = new System.Drawing.Point(25, 75);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1000, 260);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin phiếu phụ trội";
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDanhSach.Controls.Add(this.lblTimKiem);
            this.grpDanhSach.Controls.Add(this.txtTimKiem);
            this.grpDanhSach.Controls.Add(this.btnTimKiem);
            this.grpDanhSach.Controls.Add(this.dgvPhieuPhuTroi);
            this.grpDanhSach.Location = new System.Drawing.Point(25, 405);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(1000, 315);
            this.grpDanhSach.TabIndex = 7;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách phiếu phụ trội";
            // 
            // dgvPhieuPhuTroi
            // 
            this.dgvPhieuPhuTroi.AllowUserToAddRows = false;
            this.dgvPhieuPhuTroi.AllowUserToDeleteRows = false;
            this.dgvPhieuPhuTroi.AllowUserToResizeRows = false;
            this.dgvPhieuPhuTroi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhieuPhuTroi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuPhuTroi.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuPhuTroi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuPhuTroi.Location = new System.Drawing.Point(20, 75);
            this.dgvPhieuPhuTroi.MultiSelect = false;
            this.dgvPhieuPhuTroi.Name = "dgvPhieuPhuTroi";
            this.dgvPhieuPhuTroi.ReadOnly = true;
            this.dgvPhieuPhuTroi.RowHeadersVisible = false;
            this.dgvPhieuPhuTroi.RowHeadersWidth = 72;
            this.dgvPhieuPhuTroi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuPhuTroi.Size = new System.Drawing.Size(955, 220);
            this.dgvPhieuPhuTroi.TabIndex = 2;
            this.dgvPhieuPhuTroi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuPhuTroi_CellClick);
            // 
            // FrmPhieuPhuTroi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1050, 745);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(1050, 780);
            this.Name = "FrmPhieuPhuTroi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý phiếu phụ trội";
            this.Load += new System.EventHandler(this.FrmPhieuPhuTroi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoGioPhuTroi)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.grpDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuPhuTroi)).EndInit();
            this.ResumeLayout(false);

        }
    }
}