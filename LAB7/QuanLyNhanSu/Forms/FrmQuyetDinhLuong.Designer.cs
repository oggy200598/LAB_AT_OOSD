
namespace QuanLyNhanSu.Forms
{
    partial class FrmQuyetDinhLuong
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaQDL;
        private System.Windows.Forms.Label lblSoQuyetDinh;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblNgayQuyetDinh;
        private System.Windows.Forms.Label lblNgayHieuLuc;
        private System.Windows.Forms.Label lblLuongCoBan;
        private System.Windows.Forms.Label lblPhuCapLuong;
        private System.Windows.Forms.Label lblPhuCapDocHai;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.Label lblTongLuong;
        private System.Windows.Forms.Label lblTimKiem;

        private System.Windows.Forms.TextBox txtMaQDL;
        private System.Windows.Forms.TextBox txtSoQuyetDinh;
        private System.Windows.Forms.TextBox txtLuongCoBan;
        private System.Windows.Forms.TextBox txtPhuCapLuong;
        private System.Windows.Forms.TextBox txtPhuCapDocHai;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtTimKiem;

        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgayQuyetDinh;
        private System.Windows.Forms.DateTimePicker dtpNgayHieuLuc;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvQuyetDinhLuong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMaQDL = new System.Windows.Forms.Label();
            this.lblSoQuyetDinh = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblNgayQuyetDinh = new System.Windows.Forms.Label();
            this.lblNgayHieuLuc = new System.Windows.Forms.Label();
            this.lblLuongCoBan = new System.Windows.Forms.Label();
            this.lblPhuCapLuong = new System.Windows.Forms.Label();
            this.lblPhuCapDocHai = new System.Windows.Forms.Label();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.lblTongLuong = new System.Windows.Forms.Label();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtMaQDL = new System.Windows.Forms.TextBox();
            this.txtSoQuyetDinh = new System.Windows.Forms.TextBox();
            this.txtLuongCoBan = new System.Windows.Forms.TextBox();
            this.txtPhuCapLuong = new System.Windows.Forms.TextBox();
            this.txtPhuCapDocHai = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.dtpNgayQuyetDinh = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayHieuLuc = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvQuyetDinhLuong = new System.Windows.Forms.DataGridView();
            this.grpThongTin.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyetDinhLuong)).BeginInit();
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
            this.lblTieuDe.Text = "QUẢN LÝ QUYẾT ĐỊNH LƯƠNG";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaQDL
            // 
            this.lblMaQDL.AutoSize = true;
            this.lblMaQDL.Location = new System.Drawing.Point(20, 38);
            this.lblMaQDL.Name = "lblMaQDL";
            this.lblMaQDL.Size = new System.Drawing.Size(176, 32);
            this.lblMaQDL.TabIndex = 0;
            this.lblMaQDL.Text = "Mã quyết định:";
            // 
            // lblSoQuyetDinh
            // 
            this.lblSoQuyetDinh.AutoSize = true;
            this.lblSoQuyetDinh.Location = new System.Drawing.Point(540, 38);
            this.lblSoQuyetDinh.Name = "lblSoQuyetDinh";
            this.lblSoQuyetDinh.Size = new System.Drawing.Size(169, 32);
            this.lblSoQuyetDinh.TabIndex = 1;
            this.lblSoQuyetDinh.Text = "Số quyết định:";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(20, 82);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(129, 32);
            this.lblNhanVien.TabIndex = 2;
            this.lblNhanVien.Text = "Nhân viên:";
            // 
            // lblNgayQuyetDinh
            // 
            this.lblNgayQuyetDinh.AutoSize = true;
            this.lblNgayQuyetDinh.Location = new System.Drawing.Point(540, 82);
            this.lblNgayQuyetDinh.Name = "lblNgayQuyetDinh";
            this.lblNgayQuyetDinh.Size = new System.Drawing.Size(198, 32);
            this.lblNgayQuyetDinh.TabIndex = 3;
            this.lblNgayQuyetDinh.Text = "Ngày quyết định:";
            // 
            // lblNgayHieuLuc
            // 
            this.lblNgayHieuLuc.AutoSize = true;
            this.lblNgayHieuLuc.Location = new System.Drawing.Point(20, 126);
            this.lblNgayHieuLuc.Name = "lblNgayHieuLuc";
            this.lblNgayHieuLuc.Size = new System.Drawing.Size(167, 32);
            this.lblNgayHieuLuc.TabIndex = 4;
            this.lblNgayHieuLuc.Text = "Ngày hiệu lực:";
            // 
            // lblLuongCoBan
            // 
            this.lblLuongCoBan.AutoSize = true;
            this.lblLuongCoBan.Location = new System.Drawing.Point(540, 126);
            this.lblLuongCoBan.Name = "lblLuongCoBan";
            this.lblLuongCoBan.Size = new System.Drawing.Size(165, 32);
            this.lblLuongCoBan.TabIndex = 5;
            this.lblLuongCoBan.Text = "Lương cơ bản:";
            // 
            // lblPhuCapLuong
            // 
            this.lblPhuCapLuong.AutoSize = true;
            this.lblPhuCapLuong.Location = new System.Drawing.Point(20, 170);
            this.lblPhuCapLuong.Name = "lblPhuCapLuong";
            this.lblPhuCapLuong.Size = new System.Drawing.Size(173, 32);
            this.lblPhuCapLuong.TabIndex = 6;
            this.lblPhuCapLuong.Text = "Phụ cấp lương:";
            // 
            // lblPhuCapDocHai
            // 
            this.lblPhuCapDocHai.AutoSize = true;
            this.lblPhuCapDocHai.Location = new System.Drawing.Point(540, 170);
            this.lblPhuCapDocHai.Name = "lblPhuCapDocHai";
            this.lblPhuCapDocHai.Size = new System.Drawing.Size(189, 32);
            this.lblPhuCapDocHai.TabIndex = 7;
            this.lblPhuCapDocHai.Text = "Phụ cấp độc hại:";
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Location = new System.Drawing.Point(20, 214);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(120, 32);
            this.lblNoiDung.TabIndex = 8;
            this.lblNoiDung.Text = "Nội dung:";
            // 
            // lblTongLuong
            // 
            this.lblTongLuong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongLuong.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTongLuong.Location = new System.Drawing.Point(187, 244);
            this.lblTongLuong.Name = "lblTongLuong";
            this.lblTongLuong.Size = new System.Drawing.Size(845, 40);
            this.lblTongLuong.TabIndex = 9;
            this.lblTongLuong.Text = "Tổng lương + phụ cấp: 0";
            this.lblTongLuong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // txtMaQDL
            // 
            this.txtMaQDL.Location = new System.Drawing.Point(180, 34);
            this.txtMaQDL.MaxLength = 20;
            this.txtMaQDL.Name = "txtMaQDL";
            this.txtMaQDL.Size = new System.Drawing.Size(310, 39);
            this.txtMaQDL.TabIndex = 0;
            // 
            // txtSoQuyetDinh
            // 
            this.txtSoQuyetDinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoQuyetDinh.Location = new System.Drawing.Point(695, 34);
            this.txtSoQuyetDinh.MaxLength = 30;
            this.txtSoQuyetDinh.Name = "txtSoQuyetDinh";
            this.txtSoQuyetDinh.Size = new System.Drawing.Size(330, 39);
            this.txtSoQuyetDinh.TabIndex = 1;
            // 
            // txtLuongCoBan
            // 
            this.txtLuongCoBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLuongCoBan.Location = new System.Drawing.Point(695, 122);
            this.txtLuongCoBan.Name = "txtLuongCoBan";
            this.txtLuongCoBan.Size = new System.Drawing.Size(330, 39);
            this.txtLuongCoBan.TabIndex = 5;
            this.txtLuongCoBan.Text = "0";
            this.txtLuongCoBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLuongCoBan.TextChanged += new System.EventHandler(this.CapNhatTongLuong);
            // 
            // txtPhuCapLuong
            // 
            this.txtPhuCapLuong.Location = new System.Drawing.Point(180, 166);
            this.txtPhuCapLuong.Name = "txtPhuCapLuong";
            this.txtPhuCapLuong.Size = new System.Drawing.Size(310, 39);
            this.txtPhuCapLuong.TabIndex = 6;
            this.txtPhuCapLuong.Text = "0";
            this.txtPhuCapLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPhuCapLuong.TextChanged += new System.EventHandler(this.CapNhatTongLuong);
            // 
            // txtPhuCapDocHai
            // 
            this.txtPhuCapDocHai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhuCapDocHai.Location = new System.Drawing.Point(695, 166);
            this.txtPhuCapDocHai.Name = "txtPhuCapDocHai";
            this.txtPhuCapDocHai.Size = new System.Drawing.Size(330, 39);
            this.txtPhuCapDocHai.TabIndex = 7;
            this.txtPhuCapDocHai.Text = "0";
            this.txtPhuCapDocHai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPhuCapDocHai.TextChanged += new System.EventHandler(this.CapNhatTongLuong);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoiDung.Location = new System.Drawing.Point(180, 210);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNoiDung.Size = new System.Drawing.Size(415, 48);
            this.txtNoiDung.TabIndex = 8;
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
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(180, 78);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(310, 39);
            this.cboNhanVien.TabIndex = 2;
            // 
            // dtpNgayQuyetDinh
            // 
            this.dtpNgayQuyetDinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayQuyetDinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayQuyetDinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayQuyetDinh.Location = new System.Drawing.Point(695, 78);
            this.dtpNgayQuyetDinh.Name = "dtpNgayQuyetDinh";
            this.dtpNgayQuyetDinh.Size = new System.Drawing.Size(330, 39);
            this.dtpNgayQuyetDinh.TabIndex = 3;
            // 
            // dtpNgayHieuLuc
            // 
            this.dtpNgayHieuLuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHieuLuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHieuLuc.Location = new System.Drawing.Point(193, 122);
            this.dtpNgayHieuLuc.Name = "dtpNgayHieuLuc";
            this.dtpNgayHieuLuc.Size = new System.Drawing.Size(310, 39);
            this.dtpNgayHieuLuc.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SeaGreen;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(25, 395);
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
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(145, 395);
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
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(265, 395);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 40);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(385, 395);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(119, 40);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
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
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Location = new System.Drawing.Point(965, 395);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 40);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grpThongTin
            // 
            this.grpThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTin.Controls.Add(this.lblMaQDL);
            this.grpThongTin.Controls.Add(this.lblSoQuyetDinh);
            this.grpThongTin.Controls.Add(this.lblNhanVien);
            this.grpThongTin.Controls.Add(this.lblNgayQuyetDinh);
            this.grpThongTin.Controls.Add(this.lblNgayHieuLuc);
            this.grpThongTin.Controls.Add(this.lblLuongCoBan);
            this.grpThongTin.Controls.Add(this.lblPhuCapLuong);
            this.grpThongTin.Controls.Add(this.lblPhuCapDocHai);
            this.grpThongTin.Controls.Add(this.lblNoiDung);
            this.grpThongTin.Controls.Add(this.lblTongLuong);
            this.grpThongTin.Controls.Add(this.txtMaQDL);
            this.grpThongTin.Controls.Add(this.txtSoQuyetDinh);
            this.grpThongTin.Controls.Add(this.cboNhanVien);
            this.grpThongTin.Controls.Add(this.dtpNgayQuyetDinh);
            this.grpThongTin.Controls.Add(this.dtpNgayHieuLuc);
            this.grpThongTin.Controls.Add(this.txtLuongCoBan);
            this.grpThongTin.Controls.Add(this.txtPhuCapLuong);
            this.grpThongTin.Controls.Add(this.txtPhuCapDocHai);
            this.grpThongTin.Controls.Add(this.txtNoiDung);
            this.grpThongTin.Location = new System.Drawing.Point(25, 75);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1050, 305);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin quyết định lương";
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDanhSach.Controls.Add(this.lblTimKiem);
            this.grpDanhSach.Controls.Add(this.txtTimKiem);
            this.grpDanhSach.Controls.Add(this.btnTimKiem);
            this.grpDanhSach.Controls.Add(this.dgvQuyetDinhLuong);
            this.grpDanhSach.Location = new System.Drawing.Point(25, 450);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(1050, 290);
            this.grpDanhSach.TabIndex = 7;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách quyết định lương";
            // 
            // dgvQuyetDinhLuong
            // 
            this.dgvQuyetDinhLuong.AllowUserToAddRows = false;
            this.dgvQuyetDinhLuong.AllowUserToDeleteRows = false;
            this.dgvQuyetDinhLuong.AllowUserToResizeRows = false;
            this.dgvQuyetDinhLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQuyetDinhLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvQuyetDinhLuong.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuyetDinhLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuyetDinhLuong.Location = new System.Drawing.Point(20, 75);
            this.dgvQuyetDinhLuong.MultiSelect = false;
            this.dgvQuyetDinhLuong.Name = "dgvQuyetDinhLuong";
            this.dgvQuyetDinhLuong.ReadOnly = true;
            this.dgvQuyetDinhLuong.RowHeadersVisible = false;
            this.dgvQuyetDinhLuong.RowHeadersWidth = 72;
            this.dgvQuyetDinhLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuyetDinhLuong.Size = new System.Drawing.Size(1005, 195);
            this.dgvQuyetDinhLuong.TabIndex = 2;
            this.dgvQuyetDinhLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuyetDinhLuong_CellClick);
            // 
            // FrmQuyetDinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 765);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(1100, 800);
            this.Name = "FrmQuyetDinhLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý quyết định lương";
            this.Load += new System.EventHandler(this.FrmQuyetDinhLuong_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.grpDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyetDinhLuong)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
