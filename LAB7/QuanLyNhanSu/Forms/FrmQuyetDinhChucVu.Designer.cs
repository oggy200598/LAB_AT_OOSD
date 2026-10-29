
namespace QuanLyNhanSu.Forms
{
    partial class FrmQuyetDinhChucVu
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaQDCV;
        private System.Windows.Forms.Label lblSoQuyetDinh;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblNgayQuyetDinh;
        private System.Windows.Forms.Label lblNgayHieuLuc;
        private System.Windows.Forms.Label lblPhuCapChucVu;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.Label lblTimKiem;

        private System.Windows.Forms.TextBox txtMaQDCV;
        private System.Windows.Forms.TextBox txtSoQuyetDinh;
        private System.Windows.Forms.TextBox txtPhuCapChucVu;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtTimKiem;

        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.ComboBox cboChucVu;

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
        private System.Windows.Forms.DataGridView dgvQuyetDinhChucVu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMaQDCV = new System.Windows.Forms.Label();
            this.lblSoQuyetDinh = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblNgayQuyetDinh = new System.Windows.Forms.Label();
            this.lblNgayHieuLuc = new System.Windows.Forms.Label();
            this.lblPhuCapChucVu = new System.Windows.Forms.Label();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtMaQDCV = new System.Windows.Forms.TextBox();
            this.txtSoQuyetDinh = new System.Windows.Forms.TextBox();
            this.txtPhuCapChucVu = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
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
            this.dgvQuyetDinhChucVu = new System.Windows.Forms.DataGridView();
            this.grpThongTin.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyetDinhChucVu)).BeginInit();
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
            this.lblTieuDe.Text = "QUẢN LÝ QUYẾT ĐỊNH CHỨC VỤ";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaQDCV
            // 
            this.lblMaQDCV.AutoSize = true;
            this.lblMaQDCV.Location = new System.Drawing.Point(20, 38);
            this.lblMaQDCV.Name = "lblMaQDCV";
            this.lblMaQDCV.Size = new System.Drawing.Size(176, 32);
            this.lblMaQDCV.TabIndex = 0;
            this.lblMaQDCV.Text = "Mã quyết định:";
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
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(540, 82);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(106, 32);
            this.lblChucVu.TabIndex = 3;
            this.lblChucVu.Text = "Chức vụ:";
            // 
            // lblNgayQuyetDinh
            // 
            this.lblNgayQuyetDinh.AutoSize = true;
            this.lblNgayQuyetDinh.Location = new System.Drawing.Point(20, 126);
            this.lblNgayQuyetDinh.Name = "lblNgayQuyetDinh";
            this.lblNgayQuyetDinh.Size = new System.Drawing.Size(198, 32);
            this.lblNgayQuyetDinh.TabIndex = 4;
            this.lblNgayQuyetDinh.Text = "Ngày quyết định:";
            // 
            // lblNgayHieuLuc
            // 
            this.lblNgayHieuLuc.AutoSize = true;
            this.lblNgayHieuLuc.Location = new System.Drawing.Point(522, 126);
            this.lblNgayHieuLuc.Name = "lblNgayHieuLuc";
            this.lblNgayHieuLuc.Size = new System.Drawing.Size(167, 32);
            this.lblNgayHieuLuc.TabIndex = 5;
            this.lblNgayHieuLuc.Text = "Ngày hiệu lực:";
            // 
            // lblPhuCapChucVu
            // 
            this.lblPhuCapChucVu.AutoSize = true;
            this.lblPhuCapChucVu.Location = new System.Drawing.Point(20, 170);
            this.lblPhuCapChucVu.Name = "lblPhuCapChucVu";
            this.lblPhuCapChucVu.Size = new System.Drawing.Size(194, 32);
            this.lblPhuCapChucVu.TabIndex = 6;
            this.lblPhuCapChucVu.Text = "Phụ cấp chức vụ:";
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Location = new System.Drawing.Point(540, 170);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(120, 32);
            this.lblNoiDung.TabIndex = 7;
            this.lblNoiDung.Text = "Nội dung:";
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
            // txtMaQDCV
            // 
            this.txtMaQDCV.Location = new System.Drawing.Point(180, 34);
            this.txtMaQDCV.MaxLength = 20;
            this.txtMaQDCV.Name = "txtMaQDCV";
            this.txtMaQDCV.Size = new System.Drawing.Size(310, 39);
            this.txtMaQDCV.TabIndex = 0;
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
            // txtPhuCapChucVu
            // 
            this.txtPhuCapChucVu.Location = new System.Drawing.Point(180, 166);
            this.txtPhuCapChucVu.Name = "txtPhuCapChucVu";
            this.txtPhuCapChucVu.Size = new System.Drawing.Size(310, 39);
            this.txtPhuCapChucVu.TabIndex = 6;
            this.txtPhuCapChucVu.Text = "0";
            this.txtPhuCapChucVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoiDung.Location = new System.Drawing.Point(695, 166);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNoiDung.Size = new System.Drawing.Size(330, 61);
            this.txtNoiDung.TabIndex = 7;
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
            // cboChucVu
            // 
            this.cboChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(695, 78);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(330, 39);
            this.cboChucVu.TabIndex = 3;
            this.cboChucVu.SelectedIndexChanged += new System.EventHandler(this.cboChucVu_SelectedIndexChanged);
            // 
            // dtpNgayQuyetDinh
            // 
            this.dtpNgayQuyetDinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayQuyetDinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayQuyetDinh.Location = new System.Drawing.Point(224, 126);
            this.dtpNgayQuyetDinh.Name = "dtpNgayQuyetDinh";
            this.dtpNgayQuyetDinh.Size = new System.Drawing.Size(266, 39);
            this.dtpNgayQuyetDinh.TabIndex = 4;
            this.dtpNgayQuyetDinh.ValueChanged += new System.EventHandler(this.dtpNgayQuyetDinh_ValueChanged);
            // 
            // dtpNgayHieuLuc
            // 
            this.dtpNgayHieuLuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayHieuLuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHieuLuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHieuLuc.Location = new System.Drawing.Point(695, 122);
            this.dtpNgayHieuLuc.Name = "dtpNgayHieuLuc";
            this.dtpNgayHieuLuc.Size = new System.Drawing.Size(330, 39);
            this.dtpNgayHieuLuc.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SeaGreen;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(25, 370);
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
            this.btnSua.Location = new System.Drawing.Point(145, 370);
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
            this.btnXoa.Location = new System.Drawing.Point(265, 370);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 40);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(385, 370);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(117, 40);
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
            this.btnTimKiem.Size = new System.Drawing.Size(139, 33);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Location = new System.Drawing.Point(965, 370);
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
            this.grpThongTin.Controls.Add(this.lblMaQDCV);
            this.grpThongTin.Controls.Add(this.lblSoQuyetDinh);
            this.grpThongTin.Controls.Add(this.lblNhanVien);
            this.grpThongTin.Controls.Add(this.lblChucVu);
            this.grpThongTin.Controls.Add(this.lblNgayQuyetDinh);
            this.grpThongTin.Controls.Add(this.lblNgayHieuLuc);
            this.grpThongTin.Controls.Add(this.lblPhuCapChucVu);
            this.grpThongTin.Controls.Add(this.lblNoiDung);
            this.grpThongTin.Controls.Add(this.txtMaQDCV);
            this.grpThongTin.Controls.Add(this.txtSoQuyetDinh);
            this.grpThongTin.Controls.Add(this.cboNhanVien);
            this.grpThongTin.Controls.Add(this.cboChucVu);
            this.grpThongTin.Controls.Add(this.dtpNgayQuyetDinh);
            this.grpThongTin.Controls.Add(this.dtpNgayHieuLuc);
            this.grpThongTin.Controls.Add(this.txtPhuCapChucVu);
            this.grpThongTin.Controls.Add(this.txtNoiDung);
            this.grpThongTin.Location = new System.Drawing.Point(25, 75);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1050, 280);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin quyết định chức vụ";
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDanhSach.Controls.Add(this.lblTimKiem);
            this.grpDanhSach.Controls.Add(this.txtTimKiem);
            this.grpDanhSach.Controls.Add(this.btnTimKiem);
            this.grpDanhSach.Controls.Add(this.dgvQuyetDinhChucVu);
            this.grpDanhSach.Location = new System.Drawing.Point(25, 425);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(1050, 320);
            this.grpDanhSach.TabIndex = 7;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách quyết định chức vụ";
            // 
            // dgvQuyetDinhChucVu
            // 
            this.dgvQuyetDinhChucVu.AllowUserToAddRows = false;
            this.dgvQuyetDinhChucVu.AllowUserToDeleteRows = false;
            this.dgvQuyetDinhChucVu.AllowUserToResizeRows = false;
            this.dgvQuyetDinhChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQuyetDinhChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvQuyetDinhChucVu.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuyetDinhChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuyetDinhChucVu.Location = new System.Drawing.Point(20, 75);
            this.dgvQuyetDinhChucVu.MultiSelect = false;
            this.dgvQuyetDinhChucVu.Name = "dgvQuyetDinhChucVu";
            this.dgvQuyetDinhChucVu.ReadOnly = true;
            this.dgvQuyetDinhChucVu.RowHeadersVisible = false;
            this.dgvQuyetDinhChucVu.RowHeadersWidth = 72;
            this.dgvQuyetDinhChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuyetDinhChucVu.Size = new System.Drawing.Size(1005, 225);
            this.dgvQuyetDinhChucVu.TabIndex = 2;
            this.dgvQuyetDinhChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuyetDinhChucVu_CellClick);
            // 
            // FrmQuyetDinhChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 770);
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
            this.Name = "FrmQuyetDinhChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý quyết định chức vụ";
            this.Load += new System.EventHandler(this.FrmQuyetDinhChucVu_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.grpDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyetDinhChucVu)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
