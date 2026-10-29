namespace QuanLyNhanSu.Forms
{
    partial class FrmChiTietPhuTroi
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaChiTiet;
        private System.Windows.Forms.Label lblPhieuPhuTroi;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblSoGioThamGia;
        private System.Windows.Forms.Label lblHeSoPhuTroi;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblTimKiem;

        private System.Windows.Forms.TextBox txtMaChiTiet;
        private System.Windows.Forms.TextBox txtHeSoPhuTroi;
        private System.Windows.Forms.TextBox txtTimKiem;

        private System.Windows.Forms.ComboBox cboPhieuPhuTroi;
        private System.Windows.Forms.ComboBox cboNhanVien;

        private System.Windows.Forms.NumericUpDown nudSoGioThamGia;
        private System.Windows.Forms.NumericUpDown nudThanhTien;

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
            this.lblPhieuPhuTroi = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblSoGioThamGia = new System.Windows.Forms.Label();
            this.lblHeSoPhuTroi = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtMaChiTiet = new System.Windows.Forms.TextBox();
            this.txtHeSoPhuTroi = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cboPhieuPhuTroi = new System.Windows.Forms.ComboBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.nudSoGioThamGia = new System.Windows.Forms.NumericUpDown();
            this.nudThanhTien = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoGioThamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThanhTien)).BeginInit();
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
            this.lblTieuDe.Size = new System.Drawing.Size(1050, 65);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ CHI TIẾT PHỤ TRỘI";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaChiTiet
            // 
            this.lblMaChiTiet.AutoSize = true;
            this.lblMaChiTiet.Location = new System.Drawing.Point(20, 40);
            this.lblMaChiTiet.Name = "lblMaChiTiet";
            this.lblMaChiTiet.Size = new System.Drawing.Size(133, 32);
            this.lblMaChiTiet.TabIndex = 0;
            this.lblMaChiTiet.Text = "Mã chi tiết:";
            // 
            // lblPhieuPhuTroi
            // 
            this.lblPhieuPhuTroi.AutoSize = true;
            this.lblPhieuPhuTroi.Location = new System.Drawing.Point(525, 40);
            this.lblPhieuPhuTroi.Name = "lblPhieuPhuTroi";
            this.lblPhieuPhuTroi.Size = new System.Drawing.Size(171, 32);
            this.lblPhieuPhuTroi.TabIndex = 1;
            this.lblPhieuPhuTroi.Text = "Phiếu phụ trội:";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(20, 85);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(129, 32);
            this.lblNhanVien.TabIndex = 2;
            this.lblNhanVien.Text = "Nhân viên:";
            // 
            // lblSoGioThamGia
            // 
            this.lblSoGioThamGia.AutoSize = true;
            this.lblSoGioThamGia.Location = new System.Drawing.Point(525, 85);
            this.lblSoGioThamGia.Name = "lblSoGioThamGia";
            this.lblSoGioThamGia.Size = new System.Drawing.Size(188, 32);
            this.lblSoGioThamGia.TabIndex = 3;
            this.lblSoGioThamGia.Text = "Số giờ tham gia:";
            // 
            // lblHeSoPhuTroi
            // 
            this.lblHeSoPhuTroi.AutoSize = true;
            this.lblHeSoPhuTroi.Location = new System.Drawing.Point(20, 130);
            this.lblHeSoPhuTroi.Name = "lblHeSoPhuTroi";
            this.lblHeSoPhuTroi.Size = new System.Drawing.Size(172, 32);
            this.lblHeSoPhuTroi.TabIndex = 4;
            this.lblHeSoPhuTroi.Text = "Hệ số phụ trội:";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(525, 130);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(134, 32);
            this.lblThanhTien.TabIndex = 5;
            this.lblThanhTien.Text = "Thành tiền:";
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
            this.txtMaChiTiet.Location = new System.Drawing.Point(185, 36);
            this.txtMaChiTiet.MaxLength = 20;
            this.txtMaChiTiet.Name = "txtMaChiTiet";
            this.txtMaChiTiet.Size = new System.Drawing.Size(275, 39);
            this.txtMaChiTiet.TabIndex = 0;
            // 
            // txtHeSoPhuTroi
            // 
            this.txtHeSoPhuTroi.Location = new System.Drawing.Point(185, 126);
            this.txtHeSoPhuTroi.Name = "txtHeSoPhuTroi";
            this.txtHeSoPhuTroi.ReadOnly = true;
            this.txtHeSoPhuTroi.Size = new System.Drawing.Size(275, 39);
            this.txtHeSoPhuTroi.TabIndex = 4;
            this.txtHeSoPhuTroi.Text = "1,50";
            this.txtHeSoPhuTroi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // cboPhieuPhuTroi
            // 
            this.cboPhieuPhuTroi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPhieuPhuTroi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhieuPhuTroi.FormattingEnabled = true;
            this.cboPhieuPhuTroi.Location = new System.Drawing.Point(675, 36);
            this.cboPhieuPhuTroi.Name = "cboPhieuPhuTroi";
            this.cboPhieuPhuTroi.Size = new System.Drawing.Size(300, 39);
            this.cboPhieuPhuTroi.TabIndex = 1;
            this.cboPhieuPhuTroi.SelectedIndexChanged += new System.EventHandler(this.cboPhieuPhuTroi_SelectedIndexChanged);
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(185, 81);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(275, 39);
            this.cboNhanVien.TabIndex = 2;
            // 
            // nudSoGioThamGia
            // 
            this.nudSoGioThamGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSoGioThamGia.DecimalPlaces = 2;
            this.nudSoGioThamGia.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudSoGioThamGia.Location = new System.Drawing.Point(713, 85);
            this.nudSoGioThamGia.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudSoGioThamGia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudSoGioThamGia.Name = "nudSoGioThamGia";
            this.nudSoGioThamGia.Size = new System.Drawing.Size(262, 39);
            this.nudSoGioThamGia.TabIndex = 3;
            this.nudSoGioThamGia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudThanhTien
            // 
            this.nudThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudThanhTien.DecimalPlaces = 2;
            this.nudThanhTien.Location = new System.Drawing.Point(675, 126);
            this.nudThanhTien.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudThanhTien.Name = "nudThanhTien";
            this.nudThanhTien.Size = new System.Drawing.Size(300, 39);
            this.nudThanhTien.TabIndex = 5;
            this.nudThanhTien.ThousandsSeparator = true;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SeaGreen;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(25, 330);
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
            this.btnSua.Location = new System.Drawing.Point(145, 330);
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
            this.btnXoa.Location = new System.Drawing.Point(265, 330);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 40);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(385, 330);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(118, 40);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(855, 28);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(139, 39);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Location = new System.Drawing.Point(915, 330);
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
            this.grpThongTin.Controls.Add(this.lblPhieuPhuTroi);
            this.grpThongTin.Controls.Add(this.lblNhanVien);
            this.grpThongTin.Controls.Add(this.lblSoGioThamGia);
            this.grpThongTin.Controls.Add(this.lblHeSoPhuTroi);
            this.grpThongTin.Controls.Add(this.lblThanhTien);
            this.grpThongTin.Controls.Add(this.txtMaChiTiet);
            this.grpThongTin.Controls.Add(this.cboPhieuPhuTroi);
            this.grpThongTin.Controls.Add(this.cboNhanVien);
            this.grpThongTin.Controls.Add(this.nudSoGioThamGia);
            this.grpThongTin.Controls.Add(this.txtHeSoPhuTroi);
            this.grpThongTin.Controls.Add(this.nudThanhTien);
            this.grpThongTin.Location = new System.Drawing.Point(25, 75);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1000, 240);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin chi tiết phụ trội";
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
            this.grpDanhSach.Location = new System.Drawing.Point(25, 385);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(1000, 340);
            this.grpDanhSach.TabIndex = 7;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách chi tiết phụ trội";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AllowUserToDeleteRows = false;
            this.dgvChiTiet.AllowUserToResizeRows = false;
            this.dgvChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Location = new System.Drawing.Point(20, 75);
            this.dgvChiTiet.MultiSelect = false;
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.RowHeadersVisible = false;
            this.dgvChiTiet.RowHeadersWidth = 72;
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(955, 245);
            this.dgvChiTiet.TabIndex = 2;
            this.dgvChiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTiet_CellClick);
            // 
            // FrmChiTietPhuTroi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1050, 750);
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
            this.Name = "FrmChiTietPhuTroi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý chi tiết phụ trội";
            this.Load += new System.EventHandler(this.FrmChiTietPhuTroi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoGioThamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThanhTien)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.grpDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);

        }
    }
}