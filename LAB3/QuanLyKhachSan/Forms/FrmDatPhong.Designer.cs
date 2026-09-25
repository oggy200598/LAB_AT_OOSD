using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    partial class FrmDatPhong
    {
        private System.ComponentModel.IContainer components = null;

        private TabControl tabControl;
        private TabPage tabKhachHang;
        private TabPage tabDatPhong;
        private TabPage tabNhanPhong;

        // Tab Khach Hang
        private Label lblMaKH, lblTenKH, lblCMND, lblQT, lblSDT;
        private TextBox txtMaKH, txtTenKH, txtCMND, txtQT, txtSDT;
        private Button btnThemKhach;
        private DataGridView dgvKhach;

        // Tab Dat Phong
        private Label lblSoPhieu, lblKhach, lblNV, lblKenh, lblLap, lblNhan, lblTra, lblCoc, lblSoNguoi;
        private TextBox txtSoPhieu;
        private ComboBox cboKhach, cboNV, cboKenh;
        private DateTimePicker dtLap, dtNhan, dtTra;
        private NumericUpDown numCoc, numSoNguoi;
        private Button btnThemPhong, btnBoPhong, btnLapPhieu;
        private DataGridView dgvPhong, dgvChon, dgvPhieu;

        // Tab Nhan Phong
        private Label lblPhieuChon, lblNguoiPhong, lblNguoiTen, lblNguoiCMND, lblNguoiQT;
        private TextBox txtPhieuChon, txtNguoiPhong, txtNguoiTen, txtNguoiCMND, txtNguoiQT;
        private Button btnThemNguoi, btnNhanPhong, btnNoShow;
        private DataGridView dgvCT, dgvNguoi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lblQT = new System.Windows.Forms.Label();
            this.txtQT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnThemKhach = new System.Windows.Forms.Button();
            this.dgvKhach = new System.Windows.Forms.DataGridView();
            this.tabDatPhong = new System.Windows.Forms.TabPage();
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.lblKhach = new System.Windows.Forms.Label();
            this.cboKhach = new System.Windows.Forms.ComboBox();
            this.lblNV = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.lblKenh = new System.Windows.Forms.Label();
            this.cboKenh = new System.Windows.Forms.ComboBox();
            this.lblCoc = new System.Windows.Forms.Label();
            this.numCoc = new System.Windows.Forms.NumericUpDown();
            this.lblLap = new System.Windows.Forms.Label();
            this.dtLap = new System.Windows.Forms.DateTimePicker();
            this.lblNhan = new System.Windows.Forms.Label();
            this.dtNhan = new System.Windows.Forms.DateTimePicker();
            this.lblTra = new System.Windows.Forms.Label();
            this.dtTra = new System.Windows.Forms.DateTimePicker();
            this.lblSoNguoi = new System.Windows.Forms.Label();
            this.numSoNguoi = new System.Windows.Forms.NumericUpDown();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.btnBoPhong = new System.Windows.Forms.Button();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.dgvChon = new System.Windows.Forms.DataGridView();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.dgvPhieu = new System.Windows.Forms.DataGridView();
            this.tabNhanPhong = new System.Windows.Forms.TabPage();
            this.lblPhieuChon = new System.Windows.Forms.Label();
            this.txtPhieuChon = new System.Windows.Forms.TextBox();
            this.lblNguoiPhong = new System.Windows.Forms.Label();
            this.txtNguoiPhong = new System.Windows.Forms.TextBox();
            this.lblNguoiTen = new System.Windows.Forms.Label();
            this.txtNguoiTen = new System.Windows.Forms.TextBox();
            this.lblNguoiCMND = new System.Windows.Forms.Label();
            this.txtNguoiCMND = new System.Windows.Forms.TextBox();
            this.lblNguoiQT = new System.Windows.Forms.Label();
            this.txtNguoiQT = new System.Windows.Forms.TextBox();
            this.btnThemNguoi = new System.Windows.Forms.Button();
            this.btnNhanPhong = new System.Windows.Forms.Button();
            this.btnNoShow = new System.Windows.Forms.Button();
            this.dgvCT = new System.Windows.Forms.DataGridView();
            this.dgvNguoi = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).BeginInit();
            this.tabDatPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).BeginInit();
            this.tabNhanPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabKhachHang);
            this.tabControl.Controls.Add(this.tabDatPhong);
            this.tabControl.Controls.Add(this.tabNhanPhong);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(880, 520);
            this.tabControl.TabIndex = 0;
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.Controls.Add(this.lblMaKH);
            this.tabKhachHang.Controls.Add(this.txtMaKH);
            this.tabKhachHang.Controls.Add(this.lblTenKH);
            this.tabKhachHang.Controls.Add(this.txtTenKH);
            this.tabKhachHang.Controls.Add(this.lblCMND);
            this.tabKhachHang.Controls.Add(this.txtCMND);
            this.tabKhachHang.Controls.Add(this.lblQT);
            this.tabKhachHang.Controls.Add(this.txtQT);
            this.tabKhachHang.Controls.Add(this.lblSDT);
            this.tabKhachHang.Controls.Add(this.txtSDT);
            this.tabKhachHang.Controls.Add(this.btnThemKhach);
            this.tabKhachHang.Controls.Add(this.dgvKhach);
            this.tabKhachHang.Location = new System.Drawing.Point(4, 29);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.Size = new System.Drawing.Size(872, 487);
            this.tabKhachHang.TabIndex = 0;
            this.tabKhachHang.Text = "Khách hàng";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(10, 15);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(57, 20);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Mã KH:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(65, 12);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(80, 27);
            this.txtMaKH.TabIndex = 1;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(155, 15);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(57, 20);
            this.lblTenKH.TabIndex = 2;
            this.lblTenKH.Text = "Họ tên:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(205, 12);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(130, 27);
            this.txtTenKH.TabIndex = 3;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(345, 15);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(100, 20);
            this.lblCMND.TabIndex = 4;
            this.lblCMND.Text = "CMND/CCCD:";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(430, 12);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(100, 27);
            this.txtCMND.TabIndex = 5;
            // 
            // lblQT
            // 
            this.lblQT.AutoSize = true;
            this.lblQT.Location = new System.Drawing.Point(540, 15);
            this.lblQT.Name = "lblQT";
            this.lblQT.Size = new System.Drawing.Size(75, 20);
            this.lblQT.TabIndex = 6;
            this.lblQT.Text = "Quốc tịch:";
            // 
            // txtQT
            // 
            this.txtQT.Location = new System.Drawing.Point(605, 12);
            this.txtQT.Name = "txtQT";
            this.txtQT.Size = new System.Drawing.Size(80, 27);
            this.txtQT.TabIndex = 7;
            this.txtQT.Text = "Việt Nam";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(695, 15);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(39, 20);
            this.lblSDT.TabIndex = 8;
            this.lblSDT.Text = "SĐT:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(735, 12);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(90, 27);
            this.txtSDT.TabIndex = 9;
            // 
            // btnThemKhach
            // 
            this.btnThemKhach.Location = new System.Drawing.Point(10, 42);
            this.btnThemKhach.Name = "btnThemKhach";
            this.btnThemKhach.Size = new System.Drawing.Size(135, 26);
            this.btnThemKhach.TabIndex = 10;
            this.btnThemKhach.Text = "Thêm khách hàng";
            this.btnThemKhach.Click += new System.EventHandler(this.btnThemKhach_Click);
            // 
            // dgvKhach
            // 
            this.dgvKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhach.ColumnHeadersHeight = 29;
            this.dgvKhach.Location = new System.Drawing.Point(10, 75);
            this.dgvKhach.Name = "dgvKhach";
            this.dgvKhach.RowHeadersWidth = 51;
            this.dgvKhach.Size = new System.Drawing.Size(850, 400);
            this.dgvKhach.TabIndex = 11;
            this.dgvKhach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhach_CellContentClick);
            // 
            // tabDatPhong
            // 
            this.tabDatPhong.Controls.Add(this.lblSoPhieu);
            this.tabDatPhong.Controls.Add(this.txtSoPhieu);
            this.tabDatPhong.Controls.Add(this.lblKhach);
            this.tabDatPhong.Controls.Add(this.cboKhach);
            this.tabDatPhong.Controls.Add(this.lblNV);
            this.tabDatPhong.Controls.Add(this.cboNV);
            this.tabDatPhong.Controls.Add(this.lblKenh);
            this.tabDatPhong.Controls.Add(this.cboKenh);
            this.tabDatPhong.Controls.Add(this.lblCoc);
            this.tabDatPhong.Controls.Add(this.numCoc);
            this.tabDatPhong.Controls.Add(this.lblLap);
            this.tabDatPhong.Controls.Add(this.dtLap);
            this.tabDatPhong.Controls.Add(this.lblNhan);
            this.tabDatPhong.Controls.Add(this.dtNhan);
            this.tabDatPhong.Controls.Add(this.lblTra);
            this.tabDatPhong.Controls.Add(this.dtTra);
            this.tabDatPhong.Controls.Add(this.lblSoNguoi);
            this.tabDatPhong.Controls.Add(this.numSoNguoi);
            this.tabDatPhong.Controls.Add(this.btnThemPhong);
            this.tabDatPhong.Controls.Add(this.btnBoPhong);
            this.tabDatPhong.Controls.Add(this.dgvPhong);
            this.tabDatPhong.Controls.Add(this.dgvChon);
            this.tabDatPhong.Controls.Add(this.btnLapPhieu);
            this.tabDatPhong.Controls.Add(this.dgvPhieu);
            this.tabDatPhong.Location = new System.Drawing.Point(4, 29);
            this.tabDatPhong.Name = "tabDatPhong";
            this.tabDatPhong.Size = new System.Drawing.Size(872, 487);
            this.tabDatPhong.TabIndex = 1;
            this.tabDatPhong.Text = "Đặt phòng";
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.AutoSize = true;
            this.lblSoPhieu.Location = new System.Drawing.Point(10, 12);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(70, 20);
            this.lblSoPhieu.TabIndex = 0;
            this.lblSoPhieu.Text = "Số phiếu:";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(70, 9);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(80, 27);
            this.txtSoPhieu.TabIndex = 1;
            // 
            // lblKhach
            // 
            this.lblKhach.AutoSize = true;
            this.lblKhach.Location = new System.Drawing.Point(160, 12);
            this.lblKhach.Name = "lblKhach";
            this.lblKhach.Size = new System.Drawing.Size(52, 20);
            this.lblKhach.TabIndex = 2;
            this.lblKhach.Text = "Khách:";
            // 
            // cboKhach
            // 
            this.cboKhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhach.Location = new System.Drawing.Point(205, 9);
            this.cboKhach.Name = "cboKhach";
            this.cboKhach.Size = new System.Drawing.Size(130, 28);
            this.cboKhach.TabIndex = 3;
            // 
            // lblNV
            // 
            this.lblNV.AutoSize = true;
            this.lblNV.Location = new System.Drawing.Point(345, 12);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(52, 20);
            this.lblNV.TabIndex = 4;
            this.lblNV.Text = "Lễ tân:";
            // 
            // cboNV
            // 
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.Location = new System.Drawing.Point(390, 9);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(120, 28);
            this.cboNV.TabIndex = 5;
            // 
            // lblKenh
            // 
            this.lblKenh.AutoSize = true;
            this.lblKenh.Location = new System.Drawing.Point(520, 12);
            this.lblKenh.Name = "lblKenh";
            this.lblKenh.Size = new System.Drawing.Size(45, 20);
            this.lblKenh.TabIndex = 6;
            this.lblKenh.Text = "Kênh:";
            // 
            // cboKenh
            // 
            this.cboKenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKenh.Location = new System.Drawing.Point(560, 9);
            this.cboKenh.Name = "cboKenh";
            this.cboKenh.Size = new System.Drawing.Size(90, 28);
            this.cboKenh.TabIndex = 7;
            // 
            // lblCoc
            // 
            this.lblCoc.AutoSize = true;
            this.lblCoc.Location = new System.Drawing.Point(660, 12);
            this.lblCoc.Name = "lblCoc";
            this.lblCoc.Size = new System.Drawing.Size(67, 20);
            this.lblCoc.TabIndex = 8;
            this.lblCoc.Text = "Tiền cọc:";
            // 
            // numCoc
            // 
            this.numCoc.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCoc.Location = new System.Drawing.Point(720, 9);
            this.numCoc.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numCoc.Name = "numCoc";
            this.numCoc.Size = new System.Drawing.Size(110, 27);
            this.numCoc.TabIndex = 9;
            // 
            // lblLap
            // 
            this.lblLap.AutoSize = true;
            this.lblLap.Location = new System.Drawing.Point(10, 42);
            this.lblLap.Name = "lblLap";
            this.lblLap.Size = new System.Drawing.Size(72, 20);
            this.lblLap.TabIndex = 10;
            this.lblLap.Text = "Ngày lập:";
            // 
            // dtLap
            // 
            this.dtLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtLap.Location = new System.Drawing.Point(70, 39);
            this.dtLap.Name = "dtLap";
            this.dtLap.Size = new System.Drawing.Size(110, 27);
            this.dtLap.TabIndex = 11;
            // 
            // lblNhan
            // 
            this.lblNhan.AutoSize = true;
            this.lblNhan.Location = new System.Drawing.Point(190, 42);
            this.lblNhan.Name = "lblNhan";
            this.lblNhan.Size = new System.Drawing.Size(83, 20);
            this.lblNhan.TabIndex = 12;
            this.lblNhan.Text = "Ngày nhận:";
            // 
            // dtNhan
            // 
            this.dtNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNhan.Location = new System.Drawing.Point(260, 39);
            this.dtNhan.Name = "dtNhan";
            this.dtNhan.Size = new System.Drawing.Size(110, 27);
            this.dtNhan.TabIndex = 13;
            // 
            // lblTra
            // 
            this.lblTra.AutoSize = true;
            this.lblTra.Location = new System.Drawing.Point(380, 42);
            this.lblTra.Name = "lblTra";
            this.lblTra.Size = new System.Drawing.Size(69, 20);
            this.lblTra.TabIndex = 14;
            this.lblTra.Text = "Ngày trả:";
            // 
            // dtTra
            // 
            this.dtTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTra.Location = new System.Drawing.Point(440, 39);
            this.dtTra.Name = "dtTra";
            this.dtTra.Size = new System.Drawing.Size(110, 27);
            this.dtTra.TabIndex = 15;
            // 
            // lblSoNguoi
            // 
            this.lblSoNguoi.AutoSize = true;
            this.lblSoNguoi.Location = new System.Drawing.Point(10, 75);
            this.lblSoNguoi.Name = "lblSoNguoi";
            this.lblSoNguoi.Size = new System.Drawing.Size(85, 20);
            this.lblSoNguoi.TabIndex = 16;
            this.lblSoNguoi.Text = "Số người ở:";
            // 
            // numSoNguoi
            // 
            this.numSoNguoi.Location = new System.Drawing.Point(80, 72);
            this.numSoNguoi.Name = "numSoNguoi";
            this.numSoNguoi.Size = new System.Drawing.Size(50, 27);
            this.numSoNguoi.TabIndex = 17;
            this.numSoNguoi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(140, 70);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(110, 26);
            this.btnThemPhong.TabIndex = 18;
            this.btnThemPhong.Text = "Thêm phòng >>";
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // btnBoPhong
            // 
            this.btnBoPhong.Location = new System.Drawing.Point(260, 70);
            this.btnBoPhong.Name = "btnBoPhong";
            this.btnBoPhong.Size = new System.Drawing.Size(110, 26);
            this.btnBoPhong.TabIndex = 19;
            this.btnBoPhong.Text = "Bỏ phòng chọn";
            this.btnBoPhong.Click += new System.EventHandler(this.btnBoPhong_Click);
            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeight = 29;
            this.dgvPhong.Location = new System.Drawing.Point(10, 102);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.Size = new System.Drawing.Size(420, 160);
            this.dgvPhong.TabIndex = 20;
            // 
            // dgvChon
            // 
            this.dgvChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChon.ColumnHeadersHeight = 29;
            this.dgvChon.Location = new System.Drawing.Point(440, 102);
            this.dgvChon.Name = "dgvChon";
            this.dgvChon.RowHeadersWidth = 51;
            this.dgvChon.Size = new System.Drawing.Size(420, 160);
            this.dgvChon.TabIndex = 21;
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Location = new System.Drawing.Point(660, 268);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(200, 32);
            this.btnLapPhieu.TabIndex = 22;
            this.btnLapPhieu.Text = "LẬP PHIẾU ĐẶT PHÒNG";
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // dgvPhieu
            // 
            this.dgvPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieu.ColumnHeadersHeight = 29;
            this.dgvPhieu.Location = new System.Drawing.Point(10, 305);
            this.dgvPhieu.Name = "dgvPhieu";
            this.dgvPhieu.RowHeadersWidth = 51;
            this.dgvPhieu.Size = new System.Drawing.Size(850, 170);
            this.dgvPhieu.TabIndex = 23;
            this.dgvPhieu.SelectionChanged += new System.EventHandler(this.dgvPhieu_SelectionChanged);
            // 
            // tabNhanPhong
            // 
            this.tabNhanPhong.Controls.Add(this.lblPhieuChon);
            this.tabNhanPhong.Controls.Add(this.txtPhieuChon);
            this.tabNhanPhong.Controls.Add(this.lblNguoiPhong);
            this.tabNhanPhong.Controls.Add(this.txtNguoiPhong);
            this.tabNhanPhong.Controls.Add(this.lblNguoiTen);
            this.tabNhanPhong.Controls.Add(this.txtNguoiTen);
            this.tabNhanPhong.Controls.Add(this.lblNguoiCMND);
            this.tabNhanPhong.Controls.Add(this.txtNguoiCMND);
            this.tabNhanPhong.Controls.Add(this.lblNguoiQT);
            this.tabNhanPhong.Controls.Add(this.txtNguoiQT);
            this.tabNhanPhong.Controls.Add(this.btnThemNguoi);
            this.tabNhanPhong.Controls.Add(this.btnNhanPhong);
            this.tabNhanPhong.Controls.Add(this.btnNoShow);
            this.tabNhanPhong.Controls.Add(this.dgvCT);
            this.tabNhanPhong.Controls.Add(this.dgvNguoi);
            this.tabNhanPhong.Location = new System.Drawing.Point(4, 29);
            this.tabNhanPhong.Name = "tabNhanPhong";
            this.tabNhanPhong.Size = new System.Drawing.Size(872, 487);
            this.tabNhanPhong.TabIndex = 2;
            this.tabNhanPhong.Text = "Nhận phòng / Người lưu trú";
            // 
            // lblPhieuChon
            // 
            this.lblPhieuChon.AutoSize = true;
            this.lblPhieuChon.Location = new System.Drawing.Point(10, 15);
            this.lblPhieuChon.Name = "lblPhieuChon";
            this.lblPhieuChon.Size = new System.Drawing.Size(84, 20);
            this.lblPhieuChon.TabIndex = 0;
            this.lblPhieuChon.Text = "Phiếu chọn:";
            // 
            // txtPhieuChon
            // 
            this.txtPhieuChon.Location = new System.Drawing.Point(80, 12);
            this.txtPhieuChon.Name = "txtPhieuChon";
            this.txtPhieuChon.ReadOnly = true;
            this.txtPhieuChon.Size = new System.Drawing.Size(90, 27);
            this.txtPhieuChon.TabIndex = 1;
            // 
            // lblNguoiPhong
            // 
            this.lblNguoiPhong.AutoSize = true;
            this.lblNguoiPhong.Location = new System.Drawing.Point(180, 15);
            this.lblNguoiPhong.Name = "lblNguoiPhong";
            this.lblNguoiPhong.Size = new System.Drawing.Size(54, 20);
            this.lblNguoiPhong.TabIndex = 2;
            this.lblNguoiPhong.Text = "Phòng:";
            // 
            // txtNguoiPhong
            // 
            this.txtNguoiPhong.Location = new System.Drawing.Point(230, 12);
            this.txtNguoiPhong.Name = "txtNguoiPhong";
            this.txtNguoiPhong.Size = new System.Drawing.Size(60, 27);
            this.txtNguoiPhong.TabIndex = 3;
            // 
            // lblNguoiTen
            // 
            this.lblNguoiTen.AutoSize = true;
            this.lblNguoiTen.Location = new System.Drawing.Point(300, 15);
            this.lblNguoiTen.Name = "lblNguoiTen";
            this.lblNguoiTen.Size = new System.Drawing.Size(57, 20);
            this.lblNguoiTen.TabIndex = 4;
            this.lblNguoiTen.Text = "Họ tên:";
            // 
            // txtNguoiTen
            // 
            this.txtNguoiTen.Location = new System.Drawing.Point(350, 12);
            this.txtNguoiTen.Name = "txtNguoiTen";
            this.txtNguoiTen.Size = new System.Drawing.Size(120, 27);
            this.txtNguoiTen.TabIndex = 5;
            // 
            // lblNguoiCMND
            // 
            this.lblNguoiCMND.AutoSize = true;
            this.lblNguoiCMND.Location = new System.Drawing.Point(480, 15);
            this.lblNguoiCMND.Name = "lblNguoiCMND";
            this.lblNguoiCMND.Size = new System.Drawing.Size(56, 20);
            this.lblNguoiCMND.TabIndex = 6;
            this.lblNguoiCMND.Text = "CMND:";
            // 
            // txtNguoiCMND
            // 
            this.txtNguoiCMND.Location = new System.Drawing.Point(530, 12);
            this.txtNguoiCMND.Name = "txtNguoiCMND";
            this.txtNguoiCMND.Size = new System.Drawing.Size(100, 27);
            this.txtNguoiCMND.TabIndex = 7;
            // 
            // lblNguoiQT
            // 
            this.lblNguoiQT.AutoSize = true;
            this.lblNguoiQT.Location = new System.Drawing.Point(640, 15);
            this.lblNguoiQT.Name = "lblNguoiQT";
            this.lblNguoiQT.Size = new System.Drawing.Size(75, 20);
            this.lblNguoiQT.TabIndex = 8;
            this.lblNguoiQT.Text = "Quốc tịch:";
            // 
            // txtNguoiQT
            // 
            this.txtNguoiQT.Location = new System.Drawing.Point(700, 12);
            this.txtNguoiQT.Name = "txtNguoiQT";
            this.txtNguoiQT.Size = new System.Drawing.Size(80, 27);
            this.txtNguoiQT.TabIndex = 9;
            this.txtNguoiQT.Text = "Việt Nam";
            // 
            // btnThemNguoi
            // 
            this.btnThemNguoi.Location = new System.Drawing.Point(10, 42);
            this.btnThemNguoi.Name = "btnThemNguoi";
            this.btnThemNguoi.Size = new System.Drawing.Size(140, 26);
            this.btnThemNguoi.TabIndex = 10;
            this.btnThemNguoi.Text = "Thêm người lưu trú";
            this.btnThemNguoi.Click += new System.EventHandler(this.btnThemNguoi_Click);
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.Location = new System.Drawing.Point(580, 42);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Size = new System.Drawing.Size(130, 26);
            this.btnNhanPhong.TabIndex = 11;
            this.btnNhanPhong.Text = "NHẬN PHÒNG";
            this.btnNhanPhong.Click += new System.EventHandler(this.btnNhanPhong_Click);
            // 
            // btnNoShow
            // 
            this.btnNoShow.Location = new System.Drawing.Point(720, 42);
            this.btnNoShow.Name = "btnNoShow";
            this.btnNoShow.Size = new System.Drawing.Size(140, 26);
            this.btnNoShow.TabIndex = 12;
            this.btnNoShow.Text = "ĐÁNH DẤU NO-SHOW";
            this.btnNoShow.Click += new System.EventHandler(this.btnNoShow_Click);
            // 
            // dgvCT
            // 
            this.dgvCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT.ColumnHeadersHeight = 29;
            this.dgvCT.Location = new System.Drawing.Point(10, 75);
            this.dgvCT.Name = "dgvCT";
            this.dgvCT.RowHeadersWidth = 51;
            this.dgvCT.Size = new System.Drawing.Size(420, 395);
            this.dgvCT.TabIndex = 13;
            // 
            // dgvNguoi
            // 
            this.dgvNguoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguoi.ColumnHeadersHeight = 29;
            this.dgvNguoi.Location = new System.Drawing.Point(440, 75);
            this.dgvNguoi.Name = "dgvNguoi";
            this.dgvNguoi.RowHeadersWidth = 51;
            this.dgvNguoi.Size = new System.Drawing.Size(420, 395);
            this.dgvNguoi.TabIndex = 14;
            // 
            // FrmDatPhong
            // 
            this.ClientSize = new System.Drawing.Size(880, 520);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng - Đặt phòng - Nhận phòng";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabKhachHang.ResumeLayout(false);
            this.tabKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).EndInit();
            this.tabDatPhong.ResumeLayout(false);
            this.tabDatPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).EndInit();
            this.tabNhanPhong.ResumeLayout(false);
            this.tabNhanPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoi)).EndInit();
            this.ResumeLayout(false);

        }
    }
}