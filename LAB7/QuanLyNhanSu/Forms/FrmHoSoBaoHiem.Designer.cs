
namespace QuanLyNhanSu.Forms
{
    partial class FrmHoSoBaoHiem
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaBaoHiem;
        private System.Windows.Forms.Label lblHopDong;
        private System.Windows.Forms.Label lblSoBHXH;
        private System.Windows.Forms.Label lblSoBHYT;
        private System.Windows.Forms.Label lblNgayThamGia;
        private System.Windows.Forms.Label lblMucDongBHXH;
        private System.Windows.Forms.Label lblMucDongBHYT;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblTimKiem;

        private System.Windows.Forms.TextBox txtMaBaoHiem;
        private System.Windows.Forms.TextBox txtSoBHXH;
        private System.Windows.Forms.TextBox txtSoBHYT;
        private System.Windows.Forms.TextBox txtMucDongBHXH;
        private System.Windows.Forms.TextBox txtMucDongBHYT;
        private System.Windows.Forms.TextBox txtTimKiem;

        private System.Windows.Forms.ComboBox cboHopDong;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.DateTimePicker dtpNgayThamGia;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvBaoHiem;

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
            this.lblMaBaoHiem = new System.Windows.Forms.Label();
            this.lblHopDong = new System.Windows.Forms.Label();
            this.lblSoBHXH = new System.Windows.Forms.Label();
            this.lblSoBHYT = new System.Windows.Forms.Label();
            this.lblNgayThamGia = new System.Windows.Forms.Label();
            this.lblMucDongBHXH = new System.Windows.Forms.Label();
            this.lblMucDongBHYT = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtMaBaoHiem = new System.Windows.Forms.TextBox();
            this.txtSoBHXH = new System.Windows.Forms.TextBox();
            this.txtSoBHYT = new System.Windows.Forms.TextBox();
            this.txtMucDongBHXH = new System.Windows.Forms.TextBox();
            this.txtMucDongBHYT = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cboHopDong = new System.Windows.Forms.ComboBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.dtpNgayThamGia = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvBaoHiem = new System.Windows.Forms.DataGridView();
            this.grpThongTin.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoHiem)).BeginInit();
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
            this.lblTieuDe.Text = "QUẢN LÝ HỒ SƠ BẢO HIỂM";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaBaoHiem
            // 
            this.lblMaBaoHiem.AutoSize = true;
            this.lblMaBaoHiem.Location = new System.Drawing.Point(20, 40);
            this.lblMaBaoHiem.Name = "lblMaBaoHiem";
            this.lblMaBaoHiem.Size = new System.Drawing.Size(161, 32);
            this.lblMaBaoHiem.TabIndex = 0;
            this.lblMaBaoHiem.Text = "Mã bảo hiểm:";
            // 
            // lblHopDong
            // 
            this.lblHopDong.AutoSize = true;
            this.lblHopDong.Location = new System.Drawing.Point(540, 40);
            this.lblHopDong.Name = "lblHopDong";
            this.lblHopDong.Size = new System.Drawing.Size(127, 32);
            this.lblHopDong.TabIndex = 1;
            this.lblHopDong.Text = "Hợp đồng:";
            // 
            // lblSoBHXH
            // 
            this.lblSoBHXH.AutoSize = true;
            this.lblSoBHXH.Location = new System.Drawing.Point(20, 84);
            this.lblSoBHXH.Name = "lblSoBHXH";
            this.lblSoBHXH.Size = new System.Drawing.Size(115, 32);
            this.lblSoBHXH.TabIndex = 2;
            this.lblSoBHXH.Text = "Số BHXH:";
            // 
            // lblSoBHYT
            // 
            this.lblSoBHYT.AutoSize = true;
            this.lblSoBHYT.Location = new System.Drawing.Point(540, 84);
            this.lblSoBHYT.Name = "lblSoBHYT";
            this.lblSoBHYT.Size = new System.Drawing.Size(110, 32);
            this.lblSoBHYT.TabIndex = 3;
            this.lblSoBHYT.Text = "Số BHYT:";
            // 
            // lblNgayThamGia
            // 
            this.lblNgayThamGia.AutoSize = true;
            this.lblNgayThamGia.Location = new System.Drawing.Point(20, 128);
            this.lblNgayThamGia.Name = "lblNgayThamGia";
            this.lblNgayThamGia.Size = new System.Drawing.Size(176, 32);
            this.lblNgayThamGia.TabIndex = 4;
            this.lblNgayThamGia.Text = "Ngày tham gia:";
            // 
            // lblMucDongBHXH
            // 
            this.lblMucDongBHXH.AutoSize = true;
            this.lblMucDongBHXH.Location = new System.Drawing.Point(20, 172);
            this.lblMucDongBHXH.Name = "lblMucDongBHXH";
            this.lblMucDongBHXH.Size = new System.Drawing.Size(198, 32);
            this.lblMucDongBHXH.TabIndex = 5;
            this.lblMucDongBHXH.Text = "Mức đóng BHXH:";
            // 
            // lblMucDongBHYT
            // 
            this.lblMucDongBHYT.AutoSize = true;
            this.lblMucDongBHYT.Location = new System.Drawing.Point(540, 172);
            this.lblMucDongBHYT.Name = "lblMucDongBHYT";
            this.lblMucDongBHYT.Size = new System.Drawing.Size(193, 32);
            this.lblMucDongBHYT.TabIndex = 6;
            this.lblMucDongBHYT.Text = "Mức đóng BHYT:";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(540, 128);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(125, 32);
            this.lblTrangThai.TabIndex = 7;
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
            // txtMaBaoHiem
            // 
            this.txtMaBaoHiem.Location = new System.Drawing.Point(175, 36);
            this.txtMaBaoHiem.MaxLength = 20;
            this.txtMaBaoHiem.Name = "txtMaBaoHiem";
            this.txtMaBaoHiem.Size = new System.Drawing.Size(300, 39);
            this.txtMaBaoHiem.TabIndex = 0;
            // 
            // txtSoBHXH
            // 
            this.txtSoBHXH.Location = new System.Drawing.Point(175, 80);
            this.txtSoBHXH.MaxLength = 30;
            this.txtSoBHXH.Name = "txtSoBHXH";
            this.txtSoBHXH.Size = new System.Drawing.Size(300, 39);
            this.txtSoBHXH.TabIndex = 2;
            // 
            // txtSoBHYT
            // 
            this.txtSoBHYT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoBHYT.Location = new System.Drawing.Point(695, 80);
            this.txtSoBHYT.MaxLength = 30;
            this.txtSoBHYT.Name = "txtSoBHYT";
            this.txtSoBHYT.Size = new System.Drawing.Size(330, 39);
            this.txtSoBHYT.TabIndex = 3;
            // 
            // txtMucDongBHXH
            // 
            this.txtMucDongBHXH.Location = new System.Drawing.Point(224, 170);
            this.txtMucDongBHXH.Name = "txtMucDongBHXH";
            this.txtMucDongBHXH.Size = new System.Drawing.Size(238, 39);
            this.txtMucDongBHXH.TabIndex = 6;
            this.txtMucDongBHXH.Text = "0";
            this.txtMucDongBHXH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMucDongBHYT
            // 
            this.txtMucDongBHYT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMucDongBHYT.Location = new System.Drawing.Point(695, 168);
            this.txtMucDongBHYT.Name = "txtMucDongBHYT";
            this.txtMucDongBHYT.Size = new System.Drawing.Size(330, 39);
            this.txtMucDongBHYT.TabIndex = 7;
            this.txtMucDongBHYT.Text = "0";
            this.txtMucDongBHYT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // cboHopDong
            // 
            this.cboHopDong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboHopDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHopDong.FormattingEnabled = true;
            this.cboHopDong.Location = new System.Drawing.Point(695, 36);
            this.cboHopDong.Name = "cboHopDong";
            this.cboHopDong.Size = new System.Drawing.Size(330, 39);
            this.cboHopDong.TabIndex = 1;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Đang tham gia",
            "Ngừng tham gia"});
            this.cboTrangThai.Location = new System.Drawing.Point(695, 124);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(330, 39);
            this.cboTrangThai.TabIndex = 5;
            // 
            // dtpNgayThamGia
            // 
            this.dtpNgayThamGia.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayThamGia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThamGia.Location = new System.Drawing.Point(193, 125);
            this.dtpNgayThamGia.Name = "dtpNgayThamGia";
            this.dtpNgayThamGia.Size = new System.Drawing.Size(300, 39);
            this.dtpNgayThamGia.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SeaGreen;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(25, 320);
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
            this.btnSua.Location = new System.Drawing.Point(145, 320);
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
            this.btnXoa.Location = new System.Drawing.Point(265, 320);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 40);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(385, 320);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(115, 40);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(905, 28);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(139, 41);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Location = new System.Drawing.Point(965, 320);
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
            this.grpThongTin.Controls.Add(this.lblMaBaoHiem);
            this.grpThongTin.Controls.Add(this.lblHopDong);
            this.grpThongTin.Controls.Add(this.lblSoBHXH);
            this.grpThongTin.Controls.Add(this.lblSoBHYT);
            this.grpThongTin.Controls.Add(this.lblNgayThamGia);
            this.grpThongTin.Controls.Add(this.lblMucDongBHXH);
            this.grpThongTin.Controls.Add(this.lblMucDongBHYT);
            this.grpThongTin.Controls.Add(this.lblTrangThai);
            this.grpThongTin.Controls.Add(this.txtMaBaoHiem);
            this.grpThongTin.Controls.Add(this.cboHopDong);
            this.grpThongTin.Controls.Add(this.txtSoBHXH);
            this.grpThongTin.Controls.Add(this.txtSoBHYT);
            this.grpThongTin.Controls.Add(this.dtpNgayThamGia);
            this.grpThongTin.Controls.Add(this.txtMucDongBHXH);
            this.grpThongTin.Controls.Add(this.txtMucDongBHYT);
            this.grpThongTin.Controls.Add(this.cboTrangThai);
            this.grpThongTin.Location = new System.Drawing.Point(25, 75);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1050, 230);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin hồ sơ bảo hiểm";
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDanhSach.Controls.Add(this.lblTimKiem);
            this.grpDanhSach.Controls.Add(this.txtTimKiem);
            this.grpDanhSach.Controls.Add(this.btnTimKiem);
            this.grpDanhSach.Controls.Add(this.dgvBaoHiem);
            this.grpDanhSach.Location = new System.Drawing.Point(25, 375);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(1050, 365);
            this.grpDanhSach.TabIndex = 7;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách hồ sơ bảo hiểm";
            // 
            // dgvBaoHiem
            // 
            this.dgvBaoHiem.AllowUserToAddRows = false;
            this.dgvBaoHiem.AllowUserToDeleteRows = false;
            this.dgvBaoHiem.AllowUserToResizeRows = false;
            this.dgvBaoHiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBaoHiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBaoHiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvBaoHiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoHiem.Location = new System.Drawing.Point(20, 75);
            this.dgvBaoHiem.MultiSelect = false;
            this.dgvBaoHiem.Name = "dgvBaoHiem";
            this.dgvBaoHiem.ReadOnly = true;
            this.dgvBaoHiem.RowHeadersVisible = false;
            this.dgvBaoHiem.RowHeadersWidth = 72;
            this.dgvBaoHiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoHiem.Size = new System.Drawing.Size(1005, 270);
            this.dgvBaoHiem.TabIndex = 2;
            this.dgvBaoHiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaoHiem_CellClick);
            // 
            // FrmHoSoBaoHiem
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
            this.Name = "FrmHoSoBaoHiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý hồ sơ bảo hiểm";
            this.Load += new System.EventHandler(this.FrmHoSoBaoHiem_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.grpDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoHiem)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
