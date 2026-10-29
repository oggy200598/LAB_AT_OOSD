namespace QuanLyNhanSu.Forms
{
    partial class FrmQuyetDinhKyLuat
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaQDKL;
        private System.Windows.Forms.Label lblSoQuyetDinh;
        private System.Windows.Forms.Label lblNgayQuyetDinh;
        private System.Windows.Forms.Label lblLoaiDoiTuong;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.Label lblHinhThuc;
        private System.Windows.Forms.Label lblSoTienPhat;
        private System.Windows.Forms.Label lblNguoiKy;
        private System.Windows.Forms.Label lblTimKiem;

        private System.Windows.Forms.TextBox txtMaQDKL;
        private System.Windows.Forms.TextBox txtSoQuyetDinh;
        private System.Windows.Forms.TextBox txtLyDoKyLuat;
        private System.Windows.Forms.TextBox txtHinhThucKyLuat;
        private System.Windows.Forms.TextBox txtNguoiKy;
        private System.Windows.Forms.TextBox txtTimKiem;

        private System.Windows.Forms.ComboBox cboLoaiDoiTuong;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.ComboBox cboPhongBan;

        private System.Windows.Forms.DateTimePicker dtpNgayQuyetDinh;
        private System.Windows.Forms.NumericUpDown nudSoTienPhat;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvQuyetDinh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMaQDKL = new System.Windows.Forms.Label();
            this.lblSoQuyetDinh = new System.Windows.Forms.Label();
            this.lblNgayQuyetDinh = new System.Windows.Forms.Label();
            this.lblLoaiDoiTuong = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblPhongBan = new System.Windows.Forms.Label();
            this.lblLyDo = new System.Windows.Forms.Label();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.lblSoTienPhat = new System.Windows.Forms.Label();
            this.lblNguoiKy = new System.Windows.Forms.Label();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtMaQDKL = new System.Windows.Forms.TextBox();
            this.txtSoQuyetDinh = new System.Windows.Forms.TextBox();
            this.txtLyDoKyLuat = new System.Windows.Forms.TextBox();
            this.txtHinhThucKyLuat = new System.Windows.Forms.TextBox();
            this.txtNguoiKy = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cboLoaiDoiTuong = new System.Windows.Forms.ComboBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.dtpNgayQuyetDinh = new System.Windows.Forms.DateTimePicker();
            this.nudSoTienPhat = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvQuyetDinh = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTienPhat)).BeginInit();
            this.grpThongTin.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyetDinh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1120, 65);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ QUYẾT ĐỊNH KỶ LUẬT";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaQDKL
            // 
            this.lblMaQDKL.AutoSize = true;
            this.lblMaQDKL.Location = new System.Drawing.Point(20, 36);
            this.lblMaQDKL.Name = "lblMaQDKL";
            this.lblMaQDKL.Size = new System.Drawing.Size(176, 32);
            this.lblMaQDKL.TabIndex = 0;
            this.lblMaQDKL.Text = "Mã quyết định:";
            // 
            // lblSoQuyetDinh
            // 
            this.lblSoQuyetDinh.AutoSize = true;
            this.lblSoQuyetDinh.Location = new System.Drawing.Point(550, 36);
            this.lblSoQuyetDinh.Name = "lblSoQuyetDinh";
            this.lblSoQuyetDinh.Size = new System.Drawing.Size(169, 32);
            this.lblSoQuyetDinh.TabIndex = 1;
            this.lblSoQuyetDinh.Text = "Số quyết định:";
            // 
            // lblNgayQuyetDinh
            // 
            this.lblNgayQuyetDinh.AutoSize = true;
            this.lblNgayQuyetDinh.Location = new System.Drawing.Point(20, 80);
            this.lblNgayQuyetDinh.Name = "lblNgayQuyetDinh";
            this.lblNgayQuyetDinh.Size = new System.Drawing.Size(198, 32);
            this.lblNgayQuyetDinh.TabIndex = 2;
            this.lblNgayQuyetDinh.Text = "Ngày quyết định:";
            // 
            // lblLoaiDoiTuong
            // 
            this.lblLoaiDoiTuong.AutoSize = true;
            this.lblLoaiDoiTuong.Location = new System.Drawing.Point(550, 80);
            this.lblLoaiDoiTuong.Name = "lblLoaiDoiTuong";
            this.lblLoaiDoiTuong.Size = new System.Drawing.Size(174, 32);
            this.lblLoaiDoiTuong.TabIndex = 3;
            this.lblLoaiDoiTuong.Text = "Loại đối tượng:";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(20, 124);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(129, 32);
            this.lblNhanVien.TabIndex = 4;
            this.lblNhanVien.Text = "Nhân viên:";
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.AutoSize = true;
            this.lblPhongBan.Location = new System.Drawing.Point(550, 124);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(135, 32);
            this.lblPhongBan.TabIndex = 5;
            this.lblPhongBan.Text = "Phòng ban:";
            // 
            // lblLyDo
            // 
            this.lblLyDo.AutoSize = true;
            this.lblLyDo.Location = new System.Drawing.Point(20, 260);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Size = new System.Drawing.Size(154, 32);
            this.lblLyDo.TabIndex = 9;
            this.lblLyDo.Text = "Lý do kỷ luật:";
            // 
            // lblHinhThuc
            // 
            this.lblHinhThuc.AutoSize = true;
            this.lblHinhThuc.Location = new System.Drawing.Point(20, 168);
            this.lblHinhThuc.Name = "lblHinhThuc";
            this.lblHinhThuc.Size = new System.Drawing.Size(202, 32);
            this.lblHinhThuc.TabIndex = 6;
            this.lblHinhThuc.Text = "Hình thức kỷ luật:";
            // 
            // lblSoTienPhat
            // 
            this.lblSoTienPhat.AutoSize = true;
            this.lblSoTienPhat.Location = new System.Drawing.Point(550, 168);
            this.lblSoTienPhat.Name = "lblSoTienPhat";
            this.lblSoTienPhat.Size = new System.Drawing.Size(149, 32);
            this.lblSoTienPhat.TabIndex = 7;
            this.lblSoTienPhat.Text = "Số tiền phạt:";
            // 
            // lblNguoiKy
            // 
            this.lblNguoiKy.AutoSize = true;
            this.lblNguoiKy.Location = new System.Drawing.Point(20, 212);
            this.lblNguoiKy.Name = "lblNguoiKy";
            this.lblNguoiKy.Size = new System.Drawing.Size(116, 32);
            this.lblNguoiKy.TabIndex = 8;
            this.lblNguoiKy.Text = "Người ký:";
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
            // txtMaQDKL
            // 
            this.txtMaQDKL.Location = new System.Drawing.Point(190, 32);
            this.txtMaQDKL.MaxLength = 20;
            this.txtMaQDKL.Name = "txtMaQDKL";
            this.txtMaQDKL.Size = new System.Drawing.Size(310, 39);
            this.txtMaQDKL.TabIndex = 0;
            // 
            // txtSoQuyetDinh
            // 
            this.txtSoQuyetDinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoQuyetDinh.Location = new System.Drawing.Point(720, 32);
            this.txtSoQuyetDinh.MaxLength = 30;
            this.txtSoQuyetDinh.Name = "txtSoQuyetDinh";
            this.txtSoQuyetDinh.Size = new System.Drawing.Size(325, 39);
            this.txtSoQuyetDinh.TabIndex = 1;
            // 
            // txtLyDoKyLuat
            // 
            this.txtLyDoKyLuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLyDoKyLuat.Location = new System.Drawing.Point(190, 256);
            this.txtLyDoKyLuat.MaxLength = 500;
            this.txtLyDoKyLuat.Multiline = true;
            this.txtLyDoKyLuat.Name = "txtLyDoKyLuat";
            this.txtLyDoKyLuat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLyDoKyLuat.Size = new System.Drawing.Size(855, 60);
            this.txtLyDoKyLuat.TabIndex = 9;
            // 
            // txtHinhThucKyLuat
            // 
            this.txtHinhThucKyLuat.Location = new System.Drawing.Point(190, 164);
            this.txtHinhThucKyLuat.MaxLength = 100;
            this.txtHinhThucKyLuat.Name = "txtHinhThucKyLuat";
            this.txtHinhThucKyLuat.Size = new System.Drawing.Size(310, 39);
            this.txtHinhThucKyLuat.TabIndex = 6;
            // 
            // txtNguoiKy
            // 
            this.txtNguoiKy.Location = new System.Drawing.Point(190, 208);
            this.txtNguoiKy.MaxLength = 100;
            this.txtNguoiKy.Name = "txtNguoiKy";
            this.txtNguoiKy.Size = new System.Drawing.Size(310, 39);
            this.txtNguoiKy.TabIndex = 8;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(115, 31);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(800, 39);
            this.txtTimKiem.TabIndex = 0;
            // 
            // cboLoaiDoiTuong
            // 
            this.cboLoaiDoiTuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLoaiDoiTuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiDoiTuong.Items.AddRange(new object[] {
            "Cá nhân",
            "Tập thể"});
            this.cboLoaiDoiTuong.Location = new System.Drawing.Point(720, 76);
            this.cboLoaiDoiTuong.Name = "cboLoaiDoiTuong";
            this.cboLoaiDoiTuong.Size = new System.Drawing.Size(325, 39);
            this.cboLoaiDoiTuong.TabIndex = 3;
            this.cboLoaiDoiTuong.SelectedIndexChanged += new System.EventHandler(this.cboLoaiDoiTuong_SelectedIndexChanged);
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.Location = new System.Drawing.Point(190, 120);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(310, 39);
            this.cboNhanVien.TabIndex = 4;
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongBan.Location = new System.Drawing.Point(720, 120);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(325, 39);
            this.cboPhongBan.TabIndex = 5;
            // 
            // dtpNgayQuyetDinh
            // 
            this.dtpNgayQuyetDinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayQuyetDinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayQuyetDinh.Location = new System.Drawing.Point(224, 76);
            this.dtpNgayQuyetDinh.Name = "dtpNgayQuyetDinh";
            this.dtpNgayQuyetDinh.Size = new System.Drawing.Size(310, 39);
            this.dtpNgayQuyetDinh.TabIndex = 2;
            // 
            // nudSoTienPhat
            // 
            this.nudSoTienPhat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSoTienPhat.DecimalPlaces = 2;
            this.nudSoTienPhat.Location = new System.Drawing.Point(720, 164);
            this.nudSoTienPhat.Maximum = new decimal(new int[] {
            -1,
            999999999,
            0,
            0});
            this.nudSoTienPhat.Name = "nudSoTienPhat";
            this.nudSoTienPhat.Size = new System.Drawing.Size(325, 39);
            this.nudSoTienPhat.TabIndex = 7;
            this.nudSoTienPhat.ThousandsSeparator = true;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SeaGreen;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(25, 430);
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
            this.btnSua.Location = new System.Drawing.Point(145, 430);
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
            this.btnXoa.Location = new System.Drawing.Point(265, 430);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 40);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(385, 430);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(123, 40);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(925, 28);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(139, 42);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Location = new System.Drawing.Point(985, 430);
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
            this.grpThongTin.Controls.Add(this.lblMaQDKL);
            this.grpThongTin.Controls.Add(this.txtMaQDKL);
            this.grpThongTin.Controls.Add(this.lblSoQuyetDinh);
            this.grpThongTin.Controls.Add(this.txtSoQuyetDinh);
            this.grpThongTin.Controls.Add(this.lblNgayQuyetDinh);
            this.grpThongTin.Controls.Add(this.dtpNgayQuyetDinh);
            this.grpThongTin.Controls.Add(this.lblLoaiDoiTuong);
            this.grpThongTin.Controls.Add(this.cboLoaiDoiTuong);
            this.grpThongTin.Controls.Add(this.lblNhanVien);
            this.grpThongTin.Controls.Add(this.cboNhanVien);
            this.grpThongTin.Controls.Add(this.lblPhongBan);
            this.grpThongTin.Controls.Add(this.cboPhongBan);
            this.grpThongTin.Controls.Add(this.lblHinhThuc);
            this.grpThongTin.Controls.Add(this.txtHinhThucKyLuat);
            this.grpThongTin.Controls.Add(this.lblSoTienPhat);
            this.grpThongTin.Controls.Add(this.nudSoTienPhat);
            this.grpThongTin.Controls.Add(this.lblNguoiKy);
            this.grpThongTin.Controls.Add(this.txtNguoiKy);
            this.grpThongTin.Controls.Add(this.lblLyDo);
            this.grpThongTin.Controls.Add(this.txtLyDoKyLuat);
            this.grpThongTin.Location = new System.Drawing.Point(25, 75);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1070, 340);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin quyết định kỷ luật";
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDanhSach.Controls.Add(this.lblTimKiem);
            this.grpDanhSach.Controls.Add(this.txtTimKiem);
            this.grpDanhSach.Controls.Add(this.btnTimKiem);
            this.grpDanhSach.Controls.Add(this.dgvQuyetDinh);
            this.grpDanhSach.Location = new System.Drawing.Point(25, 485);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(1070, 280);
            this.grpDanhSach.TabIndex = 7;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách quyết định kỷ luật";
            // 
            // dgvQuyetDinh
            // 
            this.dgvQuyetDinh.AllowUserToAddRows = false;
            this.dgvQuyetDinh.AllowUserToDeleteRows = false;
            this.dgvQuyetDinh.AllowUserToResizeRows = false;
            this.dgvQuyetDinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQuyetDinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvQuyetDinh.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuyetDinh.ColumnHeadersHeight = 40;
            this.dgvQuyetDinh.Location = new System.Drawing.Point(20, 75);
            this.dgvQuyetDinh.MultiSelect = false;
            this.dgvQuyetDinh.Name = "dgvQuyetDinh";
            this.dgvQuyetDinh.ReadOnly = true;
            this.dgvQuyetDinh.RowHeadersVisible = false;
            this.dgvQuyetDinh.RowHeadersWidth = 72;
            this.dgvQuyetDinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuyetDinh.Size = new System.Drawing.Size(1025, 185);
            this.dgvQuyetDinh.TabIndex = 2;
            this.dgvQuyetDinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuyetDinh_CellClick);
            // 
            // FrmQuyetDinhKyLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1120, 790);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grpDanhSach);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(1120, 825);
            this.Name = "FrmQuyetDinhKyLuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý quyết định kỷ luật";
            this.Load += new System.EventHandler(this.FrmQuyetDinhKyLuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTienPhat)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.grpDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyetDinh)).EndInit();
            this.ResumeLayout(false);

        }
    }
}