namespace QuanLyNhanSu.Forms
{
    partial class FrmPhieuThuNopPhat
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaPhieuThu;
        private System.Windows.Forms.Label lblQuyetDinh;
        private System.Windows.Forms.Label lblNgayThu;
        private System.Windows.Forms.Label lblSoTienThu;
        private System.Windows.Forms.Label lblNguoiLap;
        private System.Windows.Forms.Label lblHinhThucThu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblTimKiem;

        private System.Windows.Forms.TextBox txtMaPhieuThu;
        private System.Windows.Forms.TextBox txtNguoiLap;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTimKiem;

        private System.Windows.Forms.ComboBox cboQuyetDinh;
        private System.Windows.Forms.ComboBox cboHinhThucThu;
        private System.Windows.Forms.DateTimePicker dtpNgayThu;
        private System.Windows.Forms.NumericUpDown nudSoTienThu;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvPhieuThu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMaPhieuThu = new System.Windows.Forms.Label();
            this.lblQuyetDinh = new System.Windows.Forms.Label();
            this.lblNgayThu = new System.Windows.Forms.Label();
            this.lblSoTienThu = new System.Windows.Forms.Label();
            this.lblNguoiLap = new System.Windows.Forms.Label();
            this.lblHinhThucThu = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtMaPhieuThu = new System.Windows.Forms.TextBox();
            this.txtNguoiLap = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cboQuyetDinh = new System.Windows.Forms.ComboBox();
            this.cboHinhThucThu = new System.Windows.Forms.ComboBox();
            this.dtpNgayThu = new System.Windows.Forms.DateTimePicker();
            this.nudSoTienThu = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvPhieuThu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTienThu)).BeginInit();
            this.grpThongTin.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1100, 65);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ PHIẾU THU NỘP PHẠT";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaPhieuThu
            // 
            this.lblMaPhieuThu.AutoSize = true;
            this.lblMaPhieuThu.Location = new System.Drawing.Point(20, 39);
            this.lblMaPhieuThu.Name = "lblMaPhieuThu";
            this.lblMaPhieuThu.Size = new System.Drawing.Size(164, 32);
            this.lblMaPhieuThu.TabIndex = 0;
            this.lblMaPhieuThu.Text = "Mã phiếu thu:";
            // 
            // lblQuyetDinh
            // 
            this.lblQuyetDinh.AutoSize = true;
            this.lblQuyetDinh.Location = new System.Drawing.Point(540, 39);
            this.lblQuyetDinh.Name = "lblQuyetDinh";
            this.lblQuyetDinh.Size = new System.Drawing.Size(217, 32);
            this.lblQuyetDinh.TabIndex = 1;
            this.lblQuyetDinh.Text = "Quyết định kỷ luật:";
            // 
            // lblNgayThu
            // 
            this.lblNgayThu.AutoSize = true;
            this.lblNgayThu.Location = new System.Drawing.Point(20, 84);
            this.lblNgayThu.Name = "lblNgayThu";
            this.lblNgayThu.Size = new System.Drawing.Size(118, 32);
            this.lblNgayThu.TabIndex = 2;
            this.lblNgayThu.Text = "Ngày thu:";
            // 
            // lblSoTienThu
            // 
            this.lblSoTienThu.AutoSize = true;
            this.lblSoTienThu.Location = new System.Drawing.Point(540, 84);
            this.lblSoTienThu.Name = "lblSoTienThu";
            this.lblSoTienThu.Size = new System.Drawing.Size(137, 32);
            this.lblSoTienThu.TabIndex = 3;
            this.lblSoTienThu.Text = "Số tiền thu:";
            // 
            // lblNguoiLap
            // 
            this.lblNguoiLap.AutoSize = true;
            this.lblNguoiLap.Location = new System.Drawing.Point(20, 129);
            this.lblNguoiLap.Name = "lblNguoiLap";
            this.lblNguoiLap.Size = new System.Drawing.Size(124, 32);
            this.lblNguoiLap.TabIndex = 4;
            this.lblNguoiLap.Text = "Người lập:";
            // 
            // lblHinhThucThu
            // 
            this.lblHinhThucThu.AutoSize = true;
            this.lblHinhThucThu.Location = new System.Drawing.Point(540, 129);
            this.lblHinhThucThu.Name = "lblHinhThucThu";
            this.lblHinhThucThu.Size = new System.Drawing.Size(167, 32);
            this.lblHinhThucThu.TabIndex = 5;
            this.lblHinhThucThu.Text = "Hình thức thu:";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(20, 208);
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
            // txtMaPhieuThu
            // 
            this.txtMaPhieuThu.Location = new System.Drawing.Point(180, 35);
            this.txtMaPhieuThu.MaxLength = 20;
            this.txtMaPhieuThu.Name = "txtMaPhieuThu";
            this.txtMaPhieuThu.Size = new System.Drawing.Size(310, 39);
            this.txtMaPhieuThu.TabIndex = 0;
            // 
            // txtNguoiLap
            // 
            this.txtNguoiLap.Location = new System.Drawing.Point(180, 125);
            this.txtNguoiLap.MaxLength = 100;
            this.txtNguoiLap.Name = "txtNguoiLap";
            this.txtNguoiLap.Size = new System.Drawing.Size(310, 39);
            this.txtNguoiLap.TabIndex = 4;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.Location = new System.Drawing.Point(180, 204);
            this.txtGhiChu.MaxLength = 500;
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGhiChu.Size = new System.Drawing.Size(845, 60);
            this.txtGhiChu.TabIndex = 6;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(115, 31);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(780, 39);
            this.txtTimKiem.TabIndex = 0;
            // 
            // cboQuyetDinh
            // 
            this.cboQuyetDinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboQuyetDinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuyetDinh.FormattingEnabled = true;
            this.cboQuyetDinh.Location = new System.Drawing.Point(725, 35);
            this.cboQuyetDinh.Name = "cboQuyetDinh";
            this.cboQuyetDinh.Size = new System.Drawing.Size(300, 39);
            this.cboQuyetDinh.TabIndex = 1;
            this.cboQuyetDinh.SelectedIndexChanged += new System.EventHandler(this.cboQuyetDinh_SelectedIndexChanged);
            // 
            // cboHinhThucThu
            // 
            this.cboHinhThucThu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboHinhThucThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThucThu.FormattingEnabled = true;
            this.cboHinhThucThu.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản",
            "Trừ lương"});
            this.cboHinhThucThu.Location = new System.Drawing.Point(725, 125);
            this.cboHinhThucThu.Name = "cboHinhThucThu";
            this.cboHinhThucThu.Size = new System.Drawing.Size(300, 39);
            this.cboHinhThucThu.TabIndex = 5;
            // 
            // dtpNgayThu
            // 
            this.dtpNgayThu.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThu.Location = new System.Drawing.Point(180, 80);
            this.dtpNgayThu.Name = "dtpNgayThu";
            this.dtpNgayThu.Size = new System.Drawing.Size(310, 39);
            this.dtpNgayThu.TabIndex = 2;
            // 
            // nudSoTienThu
            // 
            this.nudSoTienThu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSoTienThu.DecimalPlaces = 2;
            this.nudSoTienThu.Location = new System.Drawing.Point(725, 80);
            this.nudSoTienThu.Maximum = new decimal(new int[] {
            -1,
            999999999,
            0,
            0});
            this.nudSoTienThu.Name = "nudSoTienThu";
            this.nudSoTienThu.Size = new System.Drawing.Size(300, 39);
            this.nudSoTienThu.TabIndex = 3;
            this.nudSoTienThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSoTienThu.ThousandsSeparator = true;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SeaGreen;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(25, 380);
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
            this.btnSua.Location = new System.Drawing.Point(145, 380);
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
            this.btnXoa.Location = new System.Drawing.Point(265, 380);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 40);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(385, 380);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(130, 40);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(905, 28);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(139, 42);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Location = new System.Drawing.Point(965, 380);
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
            this.grpThongTin.Controls.Add(this.lblMaPhieuThu);
            this.grpThongTin.Controls.Add(this.lblQuyetDinh);
            this.grpThongTin.Controls.Add(this.lblNgayThu);
            this.grpThongTin.Controls.Add(this.lblSoTienThu);
            this.grpThongTin.Controls.Add(this.lblNguoiLap);
            this.grpThongTin.Controls.Add(this.lblHinhThucThu);
            this.grpThongTin.Controls.Add(this.lblGhiChu);
            this.grpThongTin.Controls.Add(this.txtMaPhieuThu);
            this.grpThongTin.Controls.Add(this.cboQuyetDinh);
            this.grpThongTin.Controls.Add(this.dtpNgayThu);
            this.grpThongTin.Controls.Add(this.nudSoTienThu);
            this.grpThongTin.Controls.Add(this.txtNguoiLap);
            this.grpThongTin.Controls.Add(this.cboHinhThucThu);
            this.grpThongTin.Controls.Add(this.txtGhiChu);
            this.grpThongTin.Location = new System.Drawing.Point(25, 75);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1050, 290);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin phiếu thu nộp phạt";
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDanhSach.Controls.Add(this.lblTimKiem);
            this.grpDanhSach.Controls.Add(this.txtTimKiem);
            this.grpDanhSach.Controls.Add(this.btnTimKiem);
            this.grpDanhSach.Controls.Add(this.dgvPhieuThu);
            this.grpDanhSach.Location = new System.Drawing.Point(25, 435);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(1050, 315);
            this.grpDanhSach.TabIndex = 7;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách phiếu thu nộp phạt";
            // 
            // dgvPhieuThu
            // 
            this.dgvPhieuThu.AllowUserToAddRows = false;
            this.dgvPhieuThu.AllowUserToDeleteRows = false;
            this.dgvPhieuThu.AllowUserToResizeRows = false;
            this.dgvPhieuThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhieuThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPhieuThu.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuThu.Location = new System.Drawing.Point(20, 75);
            this.dgvPhieuThu.MultiSelect = false;
            this.dgvPhieuThu.Name = "dgvPhieuThu";
            this.dgvPhieuThu.ReadOnly = true;
            this.dgvPhieuThu.RowHeadersVisible = false;
            this.dgvPhieuThu.RowHeadersWidth = 72;
            this.dgvPhieuThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuThu.Size = new System.Drawing.Size(1005, 220);
            this.dgvPhieuThu.TabIndex = 2;
            this.dgvPhieuThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuThu_CellClick);
            // 
            // FrmPhieuThuNopPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 775);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(1100, 810);
            this.Name = "FrmPhieuThuNopPhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý phiếu thu nộp phạt";
            this.Load += new System.EventHandler(this.FrmPhieuThuNopPhat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTienThu)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.grpDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThu)).EndInit();
            this.ResumeLayout(false);

        }
    }
}