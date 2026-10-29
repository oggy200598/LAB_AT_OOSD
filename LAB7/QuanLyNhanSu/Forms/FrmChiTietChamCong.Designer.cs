
namespace QuanLyNhanSu.Forms
{
    partial class FrmChiTietChamCong
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaChiTiet;
        private System.Windows.Forms.Label lblBangChamCong;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblCaLamViec;
        private System.Windows.Forms.Label lblNgayChamCong;
        private System.Windows.Forms.Label lblGioVao;
        private System.Windows.Forms.Label lblGioRa;
        private System.Windows.Forms.Label lblSoGioLam;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblTimKiem;

        private System.Windows.Forms.TextBox txtMaChiTiet;
        private System.Windows.Forms.TextBox txtSoGioLam;
        private System.Windows.Forms.TextBox txtTimKiem;

        private System.Windows.Forms.ComboBox cboBangChamCong;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.ComboBox cboCaLamViec;
        private System.Windows.Forms.ComboBox cboTrangThai;

        private System.Windows.Forms.DateTimePicker dtpNgayChamCong;
        private System.Windows.Forms.DateTimePicker dtpGioVao;
        private System.Windows.Forms.DateTimePicker dtpGioRa;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvChiTiet;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMaChiTiet = new System.Windows.Forms.Label();
            this.lblBangChamCong = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblCaLamViec = new System.Windows.Forms.Label();
            this.lblNgayChamCong = new System.Windows.Forms.Label();
            this.lblGioVao = new System.Windows.Forms.Label();
            this.lblGioRa = new System.Windows.Forms.Label();
            this.lblSoGioLam = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtMaChiTiet = new System.Windows.Forms.TextBox();
            this.txtSoGioLam = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cboBangChamCong = new System.Windows.Forms.ComboBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.cboCaLamViec = new System.Windows.Forms.ComboBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.dtpNgayChamCong = new System.Windows.Forms.DateTimePicker();
            this.dtpGioVao = new System.Windows.Forms.DateTimePicker();
            this.dtpGioRa = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.grpThongTin.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
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
            this.lblTieuDe.Text = "QUẢN LÝ CHI TIẾT CHẤM CÔNG";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaChiTiet
            // 
            this.lblMaChiTiet.AutoSize = true;
            this.lblMaChiTiet.Location = new System.Drawing.Point(20, 38);
            this.lblMaChiTiet.Name = "lblMaChiTiet";
            this.lblMaChiTiet.Size = new System.Drawing.Size(133, 32);
            this.lblMaChiTiet.TabIndex = 0;
            this.lblMaChiTiet.Text = "Mã chi tiết:";
            // 
            // lblBangChamCong
            // 
            this.lblBangChamCong.AutoSize = true;
            this.lblBangChamCong.Location = new System.Drawing.Point(535, 38);
            this.lblBangChamCong.Name = "lblBangChamCong";
            this.lblBangChamCong.Size = new System.Drawing.Size(198, 32);
            this.lblBangChamCong.TabIndex = 1;
            this.lblBangChamCong.Text = "Bảng chấm công:";
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
            // lblCaLamViec
            // 
            this.lblCaLamViec.AutoSize = true;
            this.lblCaLamViec.Location = new System.Drawing.Point(535, 82);
            this.lblCaLamViec.Name = "lblCaLamViec";
            this.lblCaLamViec.Size = new System.Drawing.Size(141, 32);
            this.lblCaLamViec.TabIndex = 3;
            this.lblCaLamViec.Text = "Ca làm việc:";
            // 
            // lblNgayChamCong
            // 
            this.lblNgayChamCong.AutoSize = true;
            this.lblNgayChamCong.Location = new System.Drawing.Point(20, 126);
            this.lblNgayChamCong.Name = "lblNgayChamCong";
            this.lblNgayChamCong.Size = new System.Drawing.Size(200, 32);
            this.lblNgayChamCong.TabIndex = 4;
            this.lblNgayChamCong.Text = "Ngày chấm công:";
            // 
            // lblGioVao
            // 
            this.lblGioVao.AutoSize = true;
            this.lblGioVao.Location = new System.Drawing.Point(20, 170);
            this.lblGioVao.Name = "lblGioVao";
            this.lblGioVao.Size = new System.Drawing.Size(100, 32);
            this.lblGioVao.TabIndex = 6;
            this.lblGioVao.Text = "Giờ vào:";
            // 
            // lblGioRa
            // 
            this.lblGioRa.AutoSize = true;
            this.lblGioRa.Location = new System.Drawing.Point(535, 170);
            this.lblGioRa.Name = "lblGioRa";
            this.lblGioRa.Size = new System.Drawing.Size(82, 32);
            this.lblGioRa.TabIndex = 7;
            this.lblGioRa.Text = "Giờ ra:";
            // 
            // lblSoGioLam
            // 
            this.lblSoGioLam.AutoSize = true;
            this.lblSoGioLam.Location = new System.Drawing.Point(20, 214);
            this.lblSoGioLam.Name = "lblSoGioLam";
            this.lblSoGioLam.Size = new System.Drawing.Size(133, 32);
            this.lblSoGioLam.TabIndex = 8;
            this.lblSoGioLam.Text = "Số giờ làm:";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(535, 126);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(125, 32);
            this.lblTrangThai.TabIndex = 5;
            this.lblTrangThai.Text = "Trạng thái:";
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
            // txtMaChiTiet
            // 
            this.txtMaChiTiet.Location = new System.Drawing.Point(175, 34);
            this.txtMaChiTiet.MaxLength = 20;
            this.txtMaChiTiet.Name = "txtMaChiTiet";
            this.txtMaChiTiet.Size = new System.Drawing.Size(320, 39);
            this.txtMaChiTiet.TabIndex = 0;
            // 
            // txtSoGioLam
            // 
            this.txtSoGioLam.Location = new System.Drawing.Point(175, 210);
            this.txtSoGioLam.Name = "txtSoGioLam";
            this.txtSoGioLam.ReadOnly = true;
            this.txtSoGioLam.Size = new System.Drawing.Size(320, 39);
            this.txtSoGioLam.TabIndex = 8;
            this.txtSoGioLam.Text = "0";
            this.txtSoGioLam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // cboBangChamCong
            // 
            this.cboBangChamCong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBangChamCong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBangChamCong.Location = new System.Drawing.Point(710, 34);
            this.cboBangChamCong.Name = "cboBangChamCong";
            this.cboBangChamCong.Size = new System.Drawing.Size(335, 39);
            this.cboBangChamCong.TabIndex = 1;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.Location = new System.Drawing.Point(175, 78);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(320, 39);
            this.cboNhanVien.TabIndex = 2;
            // 
            // cboCaLamViec
            // 
            this.cboCaLamViec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCaLamViec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaLamViec.Location = new System.Drawing.Point(710, 78);
            this.cboCaLamViec.Name = "cboCaLamViec";
            this.cboCaLamViec.Size = new System.Drawing.Size(335, 39);
            this.cboCaLamViec.TabIndex = 3;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Có mặt",
            "Vắng mặt",
            "Nghỉ phép",
            "Nghỉ lễ"});
            this.cboTrangThai.Location = new System.Drawing.Point(710, 122);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(335, 39);
            this.cboTrangThai.TabIndex = 5;
            this.cboTrangThai.SelectedIndexChanged += new System.EventHandler(this.CapNhatGio);
            // 
            // dtpNgayChamCong
            // 
            this.dtpNgayChamCong.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayChamCong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayChamCong.Location = new System.Drawing.Point(226, 121);
            this.dtpNgayChamCong.Name = "dtpNgayChamCong";
            this.dtpNgayChamCong.Size = new System.Drawing.Size(320, 39);
            this.dtpNgayChamCong.TabIndex = 4;
            this.dtpNgayChamCong.ValueChanged += new System.EventHandler(this.dtpNgayChamCong_ValueChanged);
            // 
            // dtpGioVao
            // 
            this.dtpGioVao.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpGioVao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGioVao.Location = new System.Drawing.Point(175, 166);
            this.dtpGioVao.Name = "dtpGioVao";
            this.dtpGioVao.ShowCheckBox = true;
            this.dtpGioVao.Size = new System.Drawing.Size(320, 39);
            this.dtpGioVao.TabIndex = 6;
            this.dtpGioVao.ValueChanged += new System.EventHandler(this.CapNhatGio);
            // 
            // dtpGioRa
            // 
            this.dtpGioRa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpGioRa.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpGioRa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGioRa.Location = new System.Drawing.Point(710, 170);
            this.dtpGioRa.Name = "dtpGioRa";
            this.dtpGioRa.ShowCheckBox = true;
            this.dtpGioRa.Size = new System.Drawing.Size(335, 39);
            this.dtpGioRa.TabIndex = 7;
            this.dtpGioRa.ValueChanged += new System.EventHandler(this.CapNhatGio);
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
            this.btnLamMoi.Size = new System.Drawing.Size(119, 40);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(925, 28);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(130, 42);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Location = new System.Drawing.Point(985, 350);
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
            this.grpThongTin.Controls.Add(this.lblMaChiTiet);
            this.grpThongTin.Controls.Add(this.txtMaChiTiet);
            this.grpThongTin.Controls.Add(this.lblBangChamCong);
            this.grpThongTin.Controls.Add(this.cboBangChamCong);
            this.grpThongTin.Controls.Add(this.lblNhanVien);
            this.grpThongTin.Controls.Add(this.cboNhanVien);
            this.grpThongTin.Controls.Add(this.lblCaLamViec);
            this.grpThongTin.Controls.Add(this.cboCaLamViec);
            this.grpThongTin.Controls.Add(this.lblNgayChamCong);
            this.grpThongTin.Controls.Add(this.dtpNgayChamCong);
            this.grpThongTin.Controls.Add(this.lblTrangThai);
            this.grpThongTin.Controls.Add(this.cboTrangThai);
            this.grpThongTin.Controls.Add(this.lblGioVao);
            this.grpThongTin.Controls.Add(this.dtpGioVao);
            this.grpThongTin.Controls.Add(this.lblGioRa);
            this.grpThongTin.Controls.Add(this.dtpGioRa);
            this.grpThongTin.Controls.Add(this.lblSoGioLam);
            this.grpThongTin.Controls.Add(this.txtSoGioLam);
            this.grpThongTin.Location = new System.Drawing.Point(25, 75);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1070, 260);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin chấm công";
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDanhSach.Controls.Add(this.lblTimKiem);
            this.grpDanhSach.Controls.Add(this.txtTimKiem);
            this.grpDanhSach.Controls.Add(this.btnTimKiem);
            this.grpDanhSach.Controls.Add(this.dgvChiTiet);
            this.grpDanhSach.Location = new System.Drawing.Point(25, 405);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(1070, 335);
            this.grpDanhSach.TabIndex = 7;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách chi tiết chấm công";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AllowUserToDeleteRows = false;
            this.dgvChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTiet.ColumnHeadersHeight = 40;
            this.dgvChiTiet.Location = new System.Drawing.Point(20, 75);
            this.dgvChiTiet.MultiSelect = false;
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.RowHeadersVisible = false;
            this.dgvChiTiet.RowHeadersWidth = 72;
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(1025, 240);
            this.dgvChiTiet.TabIndex = 2;
            this.dgvChiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTiet_CellClick);
            // 
            // FrmChiTietChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1120, 765);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grpDanhSach);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(1120, 800);
            this.Name = "FrmChiTietChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý chi tiết chấm công";
            this.Load += new System.EventHandler(this.FrmChiTietChamCong_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.grpDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
