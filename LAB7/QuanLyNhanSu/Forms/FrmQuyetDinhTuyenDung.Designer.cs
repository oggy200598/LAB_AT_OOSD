
namespace QuanLyNhanSu.Forms
{
    partial class FrmQuyetDinhTuyenDung
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaQDTD;
        private System.Windows.Forms.Label lblSoQuyetDinh;
        private System.Windows.Forms.Label lblNgayQuyetDinh;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.Label lblLuongThuViec;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.Label lblDieuKhoan;
        private System.Windows.Forms.Label lblTimKiem;

        private System.Windows.Forms.TextBox txtMaQDTD;
        private System.Windows.Forms.TextBox txtSoQuyetDinh;
        private System.Windows.Forms.TextBox txtLuongThuViec;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtDieuKhoan;
        private System.Windows.Forms.TextBox txtTimKiem;

        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.ComboBox cboPhongBan;

        private System.Windows.Forms.DateTimePicker dtpNgayQuyetDinh;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvTuyenDung;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMaQDTD = new System.Windows.Forms.Label();
            this.lblSoQuyetDinh = new System.Windows.Forms.Label();
            this.lblNgayQuyetDinh = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblPhongBan = new System.Windows.Forms.Label();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.lblLuongThuViec = new System.Windows.Forms.Label();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.lblDieuKhoan = new System.Windows.Forms.Label();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtMaQDTD = new System.Windows.Forms.TextBox();
            this.txtSoQuyetDinh = new System.Windows.Forms.TextBox();
            this.txtLuongThuViec = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtDieuKhoan = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.dtpNgayQuyetDinh = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvTuyenDung = new System.Windows.Forms.DataGridView();
            this.grpThongTin.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyenDung)).BeginInit();
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
            this.lblTieuDe.Text = "QUẢN LÝ QUYẾT ĐỊNH TUYỂN DỤNG";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaQDTD
            // 
            this.lblMaQDTD.AutoSize = true;
            this.lblMaQDTD.Location = new System.Drawing.Point(20, 38);
            this.lblMaQDTD.Name = "lblMaQDTD";
            this.lblMaQDTD.Size = new System.Drawing.Size(176, 32);
            this.lblMaQDTD.TabIndex = 0;
            this.lblMaQDTD.Text = "Mã quyết định:";
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
            // lblNgayQuyetDinh
            // 
            this.lblNgayQuyetDinh.AutoSize = true;
            this.lblNgayQuyetDinh.Location = new System.Drawing.Point(20, 82);
            this.lblNgayQuyetDinh.Name = "lblNgayQuyetDinh";
            this.lblNgayQuyetDinh.Size = new System.Drawing.Size(198, 32);
            this.lblNgayQuyetDinh.TabIndex = 2;
            this.lblNgayQuyetDinh.Text = "Ngày quyết định:";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(540, 82);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(129, 32);
            this.lblNhanVien.TabIndex = 3;
            this.lblNhanVien.Text = "Nhân viên:";
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.AutoSize = true;
            this.lblPhongBan.Location = new System.Drawing.Point(20, 126);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(135, 32);
            this.lblPhongBan.TabIndex = 4;
            this.lblPhongBan.Text = "Phòng ban:";
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Location = new System.Drawing.Point(540, 126);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(192, 32);
            this.lblNgayBatDau.TabIndex = 5;
            this.lblNgayBatDau.Text = "Bắt đầu thử việc:";
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Location = new System.Drawing.Point(20, 170);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(200, 32);
            this.lblNgayKetThuc.TabIndex = 6;
            this.lblNgayKetThuc.Text = "Kết thúc thử việc:";
            // 
            // lblLuongThuViec
            // 
            this.lblLuongThuViec.AutoSize = true;
            this.lblLuongThuViec.Location = new System.Drawing.Point(540, 170);
            this.lblLuongThuViec.Name = "lblLuongThuViec";
            this.lblLuongThuViec.Size = new System.Drawing.Size(178, 32);
            this.lblLuongThuViec.TabIndex = 7;
            this.lblLuongThuViec.Text = "Lương thử việc:";
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Location = new System.Drawing.Point(20, 215);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(120, 32);
            this.lblNoiDung.TabIndex = 8;
            this.lblNoiDung.Text = "Nội dung:";
            // 
            // lblDieuKhoan
            // 
            this.lblDieuKhoan.AutoSize = true;
            this.lblDieuKhoan.Location = new System.Drawing.Point(540, 215);
            this.lblDieuKhoan.Name = "lblDieuKhoan";
            this.lblDieuKhoan.Size = new System.Drawing.Size(142, 32);
            this.lblDieuKhoan.TabIndex = 9;
            this.lblDieuKhoan.Text = "Điều khoản:";
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
            // txtMaQDTD
            // 
            this.txtMaQDTD.Location = new System.Drawing.Point(180, 34);
            this.txtMaQDTD.MaxLength = 20;
            this.txtMaQDTD.Name = "txtMaQDTD";
            this.txtMaQDTD.Size = new System.Drawing.Size(310, 39);
            this.txtMaQDTD.TabIndex = 0;
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
            // txtLuongThuViec
            // 
            this.txtLuongThuViec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLuongThuViec.Location = new System.Drawing.Point(695, 166);
            this.txtLuongThuViec.Name = "txtLuongThuViec";
            this.txtLuongThuViec.Size = new System.Drawing.Size(330, 39);
            this.txtLuongThuViec.TabIndex = 7;
            this.txtLuongThuViec.Text = "0";
            this.txtLuongThuViec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(180, 211);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNoiDung.Size = new System.Drawing.Size(310, 59);
            this.txtNoiDung.TabIndex = 8;
            // 
            // txtDieuKhoan
            // 
            this.txtDieuKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDieuKhoan.Location = new System.Drawing.Point(695, 211);
            this.txtDieuKhoan.Multiline = true;
            this.txtDieuKhoan.Name = "txtDieuKhoan";
            this.txtDieuKhoan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDieuKhoan.Size = new System.Drawing.Size(330, 59);
            this.txtDieuKhoan.TabIndex = 9;
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
            this.cboNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(695, 78);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(330, 39);
            this.cboNhanVien.TabIndex = 3;
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Location = new System.Drawing.Point(180, 122);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(310, 39);
            this.cboPhongBan.TabIndex = 4;
            // 
            // dtpNgayQuyetDinh
            // 
            this.dtpNgayQuyetDinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayQuyetDinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayQuyetDinh.Location = new System.Drawing.Point(180, 78);
            this.dtpNgayQuyetDinh.Name = "dtpNgayQuyetDinh";
            this.dtpNgayQuyetDinh.Size = new System.Drawing.Size(310, 39);
            this.dtpNgayQuyetDinh.TabIndex = 2;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(695, 122);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(330, 39);
            this.dtpNgayBatDau.TabIndex = 5;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(180, 166);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(310, 39);
            this.dtpNgayKetThuc.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SeaGreen;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(25, 425);
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
            this.btnSua.Location = new System.Drawing.Point(145, 425);
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
            this.btnXoa.Location = new System.Drawing.Point(265, 425);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 40);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(385, 425);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(130, 40);
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
            this.btnTimKiem.Size = new System.Drawing.Size(132, 41);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Location = new System.Drawing.Point(965, 425);
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
            this.grpThongTin.Controls.Add(this.lblMaQDTD);
            this.grpThongTin.Controls.Add(this.lblSoQuyetDinh);
            this.grpThongTin.Controls.Add(this.lblNgayQuyetDinh);
            this.grpThongTin.Controls.Add(this.lblNhanVien);
            this.grpThongTin.Controls.Add(this.lblPhongBan);
            this.grpThongTin.Controls.Add(this.lblNgayBatDau);
            this.grpThongTin.Controls.Add(this.lblNgayKetThuc);
            this.grpThongTin.Controls.Add(this.lblLuongThuViec);
            this.grpThongTin.Controls.Add(this.lblNoiDung);
            this.grpThongTin.Controls.Add(this.lblDieuKhoan);
            this.grpThongTin.Controls.Add(this.txtMaQDTD);
            this.grpThongTin.Controls.Add(this.txtSoQuyetDinh);
            this.grpThongTin.Controls.Add(this.dtpNgayQuyetDinh);
            this.grpThongTin.Controls.Add(this.cboNhanVien);
            this.grpThongTin.Controls.Add(this.cboPhongBan);
            this.grpThongTin.Controls.Add(this.dtpNgayBatDau);
            this.grpThongTin.Controls.Add(this.dtpNgayKetThuc);
            this.grpThongTin.Controls.Add(this.txtLuongThuViec);
            this.grpThongTin.Controls.Add(this.txtNoiDung);
            this.grpThongTin.Controls.Add(this.txtDieuKhoan);
            this.grpThongTin.Location = new System.Drawing.Point(25, 75);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1050, 335);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin quyết định tuyển dụng";
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDanhSach.Controls.Add(this.lblTimKiem);
            this.grpDanhSach.Controls.Add(this.txtTimKiem);
            this.grpDanhSach.Controls.Add(this.btnTimKiem);
            this.grpDanhSach.Controls.Add(this.dgvTuyenDung);
            this.grpDanhSach.Location = new System.Drawing.Point(25, 480);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(1050, 280);
            this.grpDanhSach.TabIndex = 7;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách quyết định tuyển dụng";
            // 
            // dgvTuyenDung
            // 
            this.dgvTuyenDung.AllowUserToAddRows = false;
            this.dgvTuyenDung.AllowUserToDeleteRows = false;
            this.dgvTuyenDung.AllowUserToResizeRows = false;
            this.dgvTuyenDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTuyenDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTuyenDung.BackgroundColor = System.Drawing.Color.White;
            this.dgvTuyenDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTuyenDung.Location = new System.Drawing.Point(20, 75);
            this.dgvTuyenDung.MultiSelect = false;
            this.dgvTuyenDung.Name = "dgvTuyenDung";
            this.dgvTuyenDung.ReadOnly = true;
            this.dgvTuyenDung.RowHeadersVisible = false;
            this.dgvTuyenDung.RowHeadersWidth = 72;
            this.dgvTuyenDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTuyenDung.Size = new System.Drawing.Size(1005, 185);
            this.dgvTuyenDung.TabIndex = 2;
            this.dgvTuyenDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTuyenDung_CellClick);
            // 
            // FrmQuyetDinhTuyenDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 785);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(1100, 820);
            this.Name = "FrmQuyetDinhTuyenDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý quyết định tuyển dụng";
            this.Load += new System.EventHandler(this.FrmQuyetDinhTuyenDung_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.grpDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyenDung)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
