using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    partial class FrmDanhMuc
    {
        private System.ComponentModel.IContainer components = null;

        private TabControl tabControl;
        private TabPage tabKhuVuc;
        private TabPage tabNhanVien;
        private TabPage tabLoaiTN;
        private TabPage tabDichVu;
        private TabPage tabQuyDinh;

        // Controls Tab Khu Vuc
        private Label lblKhuMa, lblKhuTen;
        private TextBox txtKhuMa, txtKhuTen;
        private Button btnThemKhu;
        private DataGridView dgvKhu;

        // Controls Tab Nhan Vien
        private Label lblNVMa, lblNVTen, lblNVVaiTro, lblNVSDT;
        private TextBox txtNVMa, txtNVTen, txtNVVaiTro, txtNVSDT;
        private Button btnThemNV;
        private DataGridView dgvNV;

        // Controls Tab Loai TN
        private Label lblLoaiMa, lblLoaiTen;
        private TextBox txtLoaiMa, txtLoaiTen;
        private Button btnThemLoaiTN;
        private DataGridView dgvLoaiTN;

        // Controls Tab Dich Vu
        private Label lblDVMa, lblDVTen, lblDVDVT, lblDVGia;
        private TextBox txtDVMa, txtDVTen, txtDVDVT;
        private NumericUpDown numDVGia;
        private Button btnThemDV;
        private DataGridView dgvDV;

        // Controls Tab Quy Dinh
        private Label lblQDMa, lblQDLoai, lblQDMucDo, lblQDTien;
        private TextBox txtQDMa, txtQDMucDo;
        private ComboBox cboQDLoai;
        private NumericUpDown numQDTien;
        private Button btnThemQD;
        private DataGridView dgvQD;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabKhuVuc = new System.Windows.Forms.TabPage();
            this.lblKhuMa = new System.Windows.Forms.Label();
            this.txtKhuMa = new System.Windows.Forms.TextBox();
            this.lblKhuTen = new System.Windows.Forms.Label();
            this.txtKhuTen = new System.Windows.Forms.TextBox();
            this.btnThemKhu = new System.Windows.Forms.Button();
            this.dgvKhu = new System.Windows.Forms.DataGridView();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.lblNVMa = new System.Windows.Forms.Label();
            this.txtNVMa = new System.Windows.Forms.TextBox();
            this.lblNVTen = new System.Windows.Forms.Label();
            this.txtNVTen = new System.Windows.Forms.TextBox();
            this.lblNVVaiTro = new System.Windows.Forms.Label();
            this.txtNVVaiTro = new System.Windows.Forms.TextBox();
            this.lblNVSDT = new System.Windows.Forms.Label();
            this.txtNVSDT = new System.Windows.Forms.TextBox();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.tabLoaiTN = new System.Windows.Forms.TabPage();
            this.lblLoaiMa = new System.Windows.Forms.Label();
            this.txtLoaiMa = new System.Windows.Forms.TextBox();
            this.lblLoaiTen = new System.Windows.Forms.Label();
            this.txtLoaiTen = new System.Windows.Forms.TextBox();
            this.btnThemLoaiTN = new System.Windows.Forms.Button();
            this.dgvLoaiTN = new System.Windows.Forms.DataGridView();
            this.tabDichVu = new System.Windows.Forms.TabPage();
            this.lblDVMa = new System.Windows.Forms.Label();
            this.txtDVMa = new System.Windows.Forms.TextBox();
            this.lblDVTen = new System.Windows.Forms.Label();
            this.txtDVTen = new System.Windows.Forms.TextBox();
            this.lblDVDVT = new System.Windows.Forms.Label();
            this.txtDVDVT = new System.Windows.Forms.TextBox();
            this.lblDVGia = new System.Windows.Forms.Label();
            this.numDVGia = new System.Windows.Forms.NumericUpDown();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.tabQuyDinh = new System.Windows.Forms.TabPage();
            this.lblQDMa = new System.Windows.Forms.Label();
            this.txtQDMa = new System.Windows.Forms.TextBox();
            this.lblQDLoai = new System.Windows.Forms.Label();
            this.cboQDLoai = new System.Windows.Forms.ComboBox();
            this.lblQDMucDo = new System.Windows.Forms.Label();
            this.txtQDMucDo = new System.Windows.Forms.TextBox();
            this.lblQDTien = new System.Windows.Forms.Label();
            this.numQDTien = new System.Windows.Forms.NumericUpDown();
            this.btnThemQD = new System.Windows.Forms.Button();
            this.dgvQD = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabKhuVuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).BeginInit();
            this.tabNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.tabLoaiTN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTN)).BeginInit();
            this.tabDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDVGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.tabQuyDinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQDTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabKhuVuc);
            this.tabControl.Controls.Add(this.tabNhanVien);
            this.tabControl.Controls.Add(this.tabLoaiTN);
            this.tabControl.Controls.Add(this.tabDichVu);
            this.tabControl.Controls.Add(this.tabQuyDinh);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 441);
            this.tabControl.TabIndex = 0;
            // 
            // tabKhuVuc
            // 
            this.tabKhuVuc.Controls.Add(this.lblKhuMa);
            this.tabKhuVuc.Controls.Add(this.txtKhuMa);
            this.tabKhuVuc.Controls.Add(this.lblKhuTen);
            this.tabKhuVuc.Controls.Add(this.txtKhuTen);
            this.tabKhuVuc.Controls.Add(this.btnThemKhu);
            this.tabKhuVuc.Controls.Add(this.dgvKhu);
            this.tabKhuVuc.Location = new System.Drawing.Point(4, 30);
            this.tabKhuVuc.Name = "tabKhuVuc";
            this.tabKhuVuc.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhuVuc.Size = new System.Drawing.Size(776, 407);
            this.tabKhuVuc.TabIndex = 0;
            this.tabKhuVuc.Text = "Khu vực";
            this.tabKhuVuc.UseVisualStyleBackColor = true;
            // 
            // lblKhuMa
            // 
            this.lblKhuMa.AutoSize = true;
            this.lblKhuMa.Location = new System.Drawing.Point(15, 18);
            this.lblKhuMa.Name = "lblKhuMa";
            this.lblKhuMa.Size = new System.Drawing.Size(35, 21);
            this.lblKhuMa.TabIndex = 0;
            this.lblKhuMa.Text = "Mã:";
            // 
            // txtKhuMa
            // 
            this.txtKhuMa.Location = new System.Drawing.Point(50, 15);
            this.txtKhuMa.Name = "txtKhuMa";
            this.txtKhuMa.Size = new System.Drawing.Size(120, 29);
            this.txtKhuMa.TabIndex = 1;
            // 
            // lblKhuTen
            // 
            this.lblKhuTen.AutoSize = true;
            this.lblKhuTen.Location = new System.Drawing.Point(190, 18);
            this.lblKhuTen.Name = "lblKhuTen";
            this.lblKhuTen.Size = new System.Drawing.Size(36, 21);
            this.lblKhuTen.TabIndex = 2;
            this.lblKhuTen.Text = "Tên:";
            // 
            // txtKhuTen
            // 
            this.txtKhuTen.Location = new System.Drawing.Point(230, 15);
            this.txtKhuTen.Name = "txtKhuTen";
            this.txtKhuTen.Size = new System.Drawing.Size(200, 29);
            this.txtKhuTen.TabIndex = 3;
            // 
            // btnThemKhu
            // 
            this.btnThemKhu.Location = new System.Drawing.Point(450, 13);
            this.btnThemKhu.Name = "btnThemKhu";
            this.btnThemKhu.Size = new System.Drawing.Size(90, 28);
            this.btnThemKhu.TabIndex = 4;
            this.btnThemKhu.Text = "Thêm";
            this.btnThemKhu.Click += new System.EventHandler(this.btnThemKhu_Click);
            // 
            // dgvKhu
            // 
            this.dgvKhu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhu.ColumnHeadersHeight = 29;
            this.dgvKhu.Location = new System.Drawing.Point(10, 55);
            this.dgvKhu.Name = "dgvKhu";
            this.dgvKhu.RowHeadersWidth = 51;
            this.dgvKhu.Size = new System.Drawing.Size(755, 345);
            this.dgvKhu.TabIndex = 5;
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Controls.Add(this.lblNVMa);
            this.tabNhanVien.Controls.Add(this.txtNVMa);
            this.tabNhanVien.Controls.Add(this.lblNVTen);
            this.tabNhanVien.Controls.Add(this.txtNVTen);
            this.tabNhanVien.Controls.Add(this.lblNVVaiTro);
            this.tabNhanVien.Controls.Add(this.txtNVVaiTro);
            this.tabNhanVien.Controls.Add(this.lblNVSDT);
            this.tabNhanVien.Controls.Add(this.txtNVSDT);
            this.tabNhanVien.Controls.Add(this.btnThemNV);
            this.tabNhanVien.Controls.Add(this.dgvNV);
            this.tabNhanVien.Location = new System.Drawing.Point(4, 30);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Size = new System.Drawing.Size(776, 407);
            this.tabNhanVien.TabIndex = 1;
            this.tabNhanVien.Text = "Nhân viên";
            this.tabNhanVien.UseVisualStyleBackColor = true;
            // 
            // lblNVMa
            // 
            this.lblNVMa.AutoSize = true;
            this.lblNVMa.Location = new System.Drawing.Point(10, 18);
            this.lblNVMa.Name = "lblNVMa";
            this.lblNVMa.Size = new System.Drawing.Size(35, 21);
            this.lblNVMa.TabIndex = 0;
            this.lblNVMa.Text = "Mã:";
            // 
            // txtNVMa
            // 
            this.txtNVMa.Location = new System.Drawing.Point(45, 15);
            this.txtNVMa.Name = "txtNVMa";
            this.txtNVMa.Size = new System.Drawing.Size(80, 29);
            this.txtNVMa.TabIndex = 1;
            // 
            // lblNVTen
            // 
            this.lblNVTen.AutoSize = true;
            this.lblNVTen.Location = new System.Drawing.Point(140, 18);
            this.lblNVTen.Name = "lblNVTen";
            this.lblNVTen.Size = new System.Drawing.Size(36, 21);
            this.lblNVTen.TabIndex = 2;
            this.lblNVTen.Text = "Tên:";
            // 
            // txtNVTen
            // 
            this.txtNVTen.Location = new System.Drawing.Point(175, 15);
            this.txtNVTen.Name = "txtNVTen";
            this.txtNVTen.Size = new System.Drawing.Size(130, 29);
            this.txtNVTen.TabIndex = 3;
            // 
            // lblNVVaiTro
            // 
            this.lblNVVaiTro.AutoSize = true;
            this.lblNVVaiTro.Location = new System.Drawing.Point(315, 18);
            this.lblNVVaiTro.Name = "lblNVVaiTro";
            this.lblNVVaiTro.Size = new System.Drawing.Size(58, 21);
            this.lblNVVaiTro.TabIndex = 4;
            this.lblNVVaiTro.Text = "Vai trò:";
            // 
            // txtNVVaiTro
            // 
            this.txtNVVaiTro.Location = new System.Drawing.Point(365, 15);
            this.txtNVVaiTro.Name = "txtNVVaiTro";
            this.txtNVVaiTro.Size = new System.Drawing.Size(110, 29);
            this.txtNVVaiTro.TabIndex = 5;
            // 
            // lblNVSDT
            // 
            this.lblNVSDT.AutoSize = true;
            this.lblNVSDT.Location = new System.Drawing.Point(485, 18);
            this.lblNVSDT.Name = "lblNVSDT";
            this.lblNVSDT.Size = new System.Drawing.Size(41, 21);
            this.lblNVSDT.TabIndex = 6;
            this.lblNVSDT.Text = "SĐT:";
            // 
            // txtNVSDT
            // 
            this.txtNVSDT.Location = new System.Drawing.Point(525, 15);
            this.txtNVSDT.Name = "txtNVSDT";
            this.txtNVSDT.Size = new System.Drawing.Size(110, 29);
            this.txtNVSDT.TabIndex = 7;
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(650, 13);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(90, 28);
            this.btnThemNV.TabIndex = 8;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // dgvNV
            // 
            this.dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNV.ColumnHeadersHeight = 29;
            this.dgvNV.Location = new System.Drawing.Point(10, 55);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowHeadersWidth = 51;
            this.dgvNV.Size = new System.Drawing.Size(755, 345);
            this.dgvNV.TabIndex = 9;
            // 
            // tabLoaiTN
            // 
            this.tabLoaiTN.Controls.Add(this.lblLoaiMa);
            this.tabLoaiTN.Controls.Add(this.txtLoaiMa);
            this.tabLoaiTN.Controls.Add(this.lblLoaiTen);
            this.tabLoaiTN.Controls.Add(this.txtLoaiTen);
            this.tabLoaiTN.Controls.Add(this.btnThemLoaiTN);
            this.tabLoaiTN.Controls.Add(this.dgvLoaiTN);
            this.tabLoaiTN.Location = new System.Drawing.Point(4, 30);
            this.tabLoaiTN.Name = "tabLoaiTN";
            this.tabLoaiTN.Size = new System.Drawing.Size(776, 407);
            this.tabLoaiTN.TabIndex = 2;
            this.tabLoaiTN.Text = "Loại tiện nghi";
            this.tabLoaiTN.UseVisualStyleBackColor = true;
            // 
            // lblLoaiMa
            // 
            this.lblLoaiMa.AutoSize = true;
            this.lblLoaiMa.Location = new System.Drawing.Point(15, 18);
            this.lblLoaiMa.Name = "lblLoaiMa";
            this.lblLoaiMa.Size = new System.Drawing.Size(35, 21);
            this.lblLoaiMa.TabIndex = 0;
            this.lblLoaiMa.Text = "Mã:";
            // 
            // txtLoaiMa
            // 
            this.txtLoaiMa.Location = new System.Drawing.Point(50, 15);
            this.txtLoaiMa.Name = "txtLoaiMa";
            this.txtLoaiMa.Size = new System.Drawing.Size(120, 29);
            this.txtLoaiMa.TabIndex = 1;
            // 
            // lblLoaiTen
            // 
            this.lblLoaiTen.AutoSize = true;
            this.lblLoaiTen.Location = new System.Drawing.Point(190, 18);
            this.lblLoaiTen.Name = "lblLoaiTen";
            this.lblLoaiTen.Size = new System.Drawing.Size(36, 21);
            this.lblLoaiTen.TabIndex = 2;
            this.lblLoaiTen.Text = "Tên:";
            // 
            // txtLoaiTen
            // 
            this.txtLoaiTen.Location = new System.Drawing.Point(230, 15);
            this.txtLoaiTen.Name = "txtLoaiTen";
            this.txtLoaiTen.Size = new System.Drawing.Size(200, 29);
            this.txtLoaiTen.TabIndex = 3;
            // 
            // btnThemLoaiTN
            // 
            this.btnThemLoaiTN.Location = new System.Drawing.Point(450, 13);
            this.btnThemLoaiTN.Name = "btnThemLoaiTN";
            this.btnThemLoaiTN.Size = new System.Drawing.Size(90, 28);
            this.btnThemLoaiTN.TabIndex = 4;
            this.btnThemLoaiTN.Text = "Thêm";
            this.btnThemLoaiTN.Click += new System.EventHandler(this.btnThemLoaiTN_Click);
            // 
            // dgvLoaiTN
            // 
            this.dgvLoaiTN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiTN.ColumnHeadersHeight = 29;
            this.dgvLoaiTN.Location = new System.Drawing.Point(10, 55);
            this.dgvLoaiTN.Name = "dgvLoaiTN";
            this.dgvLoaiTN.RowHeadersWidth = 51;
            this.dgvLoaiTN.Size = new System.Drawing.Size(755, 345);
            this.dgvLoaiTN.TabIndex = 5;
            // 
            // tabDichVu
            // 
            this.tabDichVu.Controls.Add(this.lblDVMa);
            this.tabDichVu.Controls.Add(this.txtDVMa);
            this.tabDichVu.Controls.Add(this.lblDVTen);
            this.tabDichVu.Controls.Add(this.txtDVTen);
            this.tabDichVu.Controls.Add(this.lblDVDVT);
            this.tabDichVu.Controls.Add(this.txtDVDVT);
            this.tabDichVu.Controls.Add(this.lblDVGia);
            this.tabDichVu.Controls.Add(this.numDVGia);
            this.tabDichVu.Controls.Add(this.btnThemDV);
            this.tabDichVu.Controls.Add(this.dgvDV);
            this.tabDichVu.Location = new System.Drawing.Point(4, 30);
            this.tabDichVu.Name = "tabDichVu";
            this.tabDichVu.Size = new System.Drawing.Size(776, 407);
            this.tabDichVu.TabIndex = 3;
            this.tabDichVu.Text = "Dịch vụ";
            this.tabDichVu.UseVisualStyleBackColor = true;
            // 
            // lblDVMa
            // 
            this.lblDVMa.AutoSize = true;
            this.lblDVMa.Location = new System.Drawing.Point(10, 18);
            this.lblDVMa.Name = "lblDVMa";
            this.lblDVMa.Size = new System.Drawing.Size(35, 21);
            this.lblDVMa.TabIndex = 0;
            this.lblDVMa.Text = "Mã:";
            // 
            // txtDVMa
            // 
            this.txtDVMa.Location = new System.Drawing.Point(45, 15);
            this.txtDVMa.Name = "txtDVMa";
            this.txtDVMa.Size = new System.Drawing.Size(80, 29);
            this.txtDVMa.TabIndex = 1;
            // 
            // lblDVTen
            // 
            this.lblDVTen.AutoSize = true;
            this.lblDVTen.Location = new System.Drawing.Point(135, 18);
            this.lblDVTen.Name = "lblDVTen";
            this.lblDVTen.Size = new System.Drawing.Size(36, 21);
            this.lblDVTen.TabIndex = 2;
            this.lblDVTen.Text = "Tên:";
            // 
            // txtDVTen
            // 
            this.txtDVTen.Location = new System.Drawing.Point(170, 15);
            this.txtDVTen.Name = "txtDVTen";
            this.txtDVTen.Size = new System.Drawing.Size(130, 29);
            this.txtDVTen.TabIndex = 3;
            // 
            // lblDVDVT
            // 
            this.lblDVDVT.AutoSize = true;
            this.lblDVDVT.Location = new System.Drawing.Point(310, 18);
            this.lblDVDVT.Name = "lblDVDVT";
            this.lblDVDVT.Size = new System.Drawing.Size(42, 21);
            this.lblDVDVT.TabIndex = 4;
            this.lblDVDVT.Text = "ĐVT:";
            // 
            // txtDVDVT
            // 
            this.txtDVDVT.Location = new System.Drawing.Point(350, 15);
            this.txtDVDVT.Name = "txtDVDVT";
            this.txtDVDVT.Size = new System.Drawing.Size(90, 29);
            this.txtDVDVT.TabIndex = 5;
            // 
            // lblDVGia
            // 
            this.lblDVGia.AutoSize = true;
            this.lblDVGia.Location = new System.Drawing.Point(450, 18);
            this.lblDVGia.Name = "lblDVGia";
            this.lblDVGia.Size = new System.Drawing.Size(36, 21);
            this.lblDVGia.TabIndex = 6;
            this.lblDVGia.Text = "Giá:";
            // 
            // numDVGia
            // 
            this.numDVGia.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numDVGia.Location = new System.Drawing.Point(490, 15);
            this.numDVGia.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numDVGia.Name = "numDVGia";
            this.numDVGia.Size = new System.Drawing.Size(100, 29);
            this.numDVGia.TabIndex = 7;
            // 
            // btnThemDV
            // 
            this.btnThemDV.Location = new System.Drawing.Point(610, 13);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(90, 28);
            this.btnThemDV.TabIndex = 8;
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // dgvDV
            // 
            this.dgvDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDV.ColumnHeadersHeight = 29;
            this.dgvDV.Location = new System.Drawing.Point(10, 55);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.RowHeadersWidth = 51;
            this.dgvDV.Size = new System.Drawing.Size(755, 345);
            this.dgvDV.TabIndex = 9;
            // 
            // tabQuyDinh
            // 
            this.tabQuyDinh.Controls.Add(this.lblQDMa);
            this.tabQuyDinh.Controls.Add(this.txtQDMa);
            this.tabQuyDinh.Controls.Add(this.lblQDLoai);
            this.tabQuyDinh.Controls.Add(this.cboQDLoai);
            this.tabQuyDinh.Controls.Add(this.lblQDMucDo);
            this.tabQuyDinh.Controls.Add(this.txtQDMucDo);
            this.tabQuyDinh.Controls.Add(this.lblQDTien);
            this.tabQuyDinh.Controls.Add(this.numQDTien);
            this.tabQuyDinh.Controls.Add(this.btnThemQD);
            this.tabQuyDinh.Controls.Add(this.dgvQD);
            this.tabQuyDinh.Location = new System.Drawing.Point(4, 30);
            this.tabQuyDinh.Name = "tabQuyDinh";
            this.tabQuyDinh.Size = new System.Drawing.Size(776, 407);
            this.tabQuyDinh.TabIndex = 4;
            this.tabQuyDinh.Text = "Quy định đền bù";
            this.tabQuyDinh.UseVisualStyleBackColor = true;
            // 
            // lblQDMa
            // 
            this.lblQDMa.AutoSize = true;
            this.lblQDMa.Location = new System.Drawing.Point(10, 18);
            this.lblQDMa.Name = "lblQDMa";
            this.lblQDMa.Size = new System.Drawing.Size(35, 21);
            this.lblQDMa.TabIndex = 0;
            this.lblQDMa.Text = "Mã:";
            // 
            // txtQDMa
            // 
            this.txtQDMa.Location = new System.Drawing.Point(45, 15);
            this.txtQDMa.Name = "txtQDMa";
            this.txtQDMa.Size = new System.Drawing.Size(70, 29);
            this.txtQDMa.TabIndex = 1;
            this.txtQDMa.TextChanged += new System.EventHandler(this.txtQDMa_TextChanged);
            // 
            // lblQDLoai
            // 
            this.lblQDLoai.AutoSize = true;
            this.lblQDLoai.Location = new System.Drawing.Point(125, 18);
            this.lblQDLoai.Name = "lblQDLoai";
            this.lblQDLoai.Size = new System.Drawing.Size(42, 21);
            this.lblQDLoai.TabIndex = 2;
            this.lblQDLoai.Text = "Loại:";
            // 
            // cboQDLoai
            // 
            this.cboQDLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQDLoai.Location = new System.Drawing.Point(165, 15);
            this.cboQDLoai.Name = "cboQDLoai";
            this.cboQDLoai.Size = new System.Drawing.Size(120, 29);
            this.cboQDLoai.TabIndex = 3;
            // 
            // lblQDMucDo
            // 
            this.lblQDMucDo.AutoSize = true;
            this.lblQDMucDo.Location = new System.Drawing.Point(300, 18);
            this.lblQDMucDo.Name = "lblQDMucDo";
            this.lblQDMucDo.Size = new System.Drawing.Size(43, 21);
            this.lblQDMucDo.TabIndex = 4;
            this.lblQDMucDo.Text = "Mức:";
            // 
            // txtQDMucDo
            // 
            this.txtQDMucDo.Location = new System.Drawing.Point(345, 15);
            this.txtQDMucDo.Name = "txtQDMucDo";
            this.txtQDMucDo.Size = new System.Drawing.Size(100, 29);
            this.txtQDMucDo.TabIndex = 5;
            // 
            // lblQDTien
            // 
            this.lblQDTien.AutoSize = true;
            this.lblQDTien.Location = new System.Drawing.Point(460, 18);
            this.lblQDTien.Name = "lblQDTien";
            this.lblQDTien.Size = new System.Drawing.Size(42, 21);
            this.lblQDTien.TabIndex = 6;
            this.lblQDTien.Text = "Tiền:";
            // 
            // numQDTien
            // 
            this.numQDTien.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numQDTien.Location = new System.Drawing.Point(500, 15);
            this.numQDTien.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numQDTien.Name = "numQDTien";
            this.numQDTien.Size = new System.Drawing.Size(100, 29);
            this.numQDTien.TabIndex = 7;
            // 
            // btnThemQD
            // 
            this.btnThemQD.Location = new System.Drawing.Point(615, 13);
            this.btnThemQD.Name = "btnThemQD";
            this.btnThemQD.Size = new System.Drawing.Size(90, 28);
            this.btnThemQD.TabIndex = 8;
            this.btnThemQD.Text = "Thêm";
            this.btnThemQD.Click += new System.EventHandler(this.btnThemQD_Click);
            // 
            // dgvQD
            // 
            this.dgvQD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQD.ColumnHeadersHeight = 29;
            this.dgvQD.Location = new System.Drawing.Point(10, 55);
            this.dgvQD.Name = "dgvQD";
            this.dgvQD.RowHeadersWidth = 51;
            this.dgvQD.Size = new System.Drawing.Size(755, 345);
            this.dgvQD.TabIndex = 9;
            // 
            // FrmDanhMuc
            // 
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục khách sạn";
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);
            this.tabControl.ResumeLayout(false);
            this.tabKhuVuc.ResumeLayout(false);
            this.tabKhuVuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).EndInit();
            this.tabNhanVien.ResumeLayout(false);
            this.tabNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.tabLoaiTN.ResumeLayout(false);
            this.tabLoaiTN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTN)).EndInit();
            this.tabDichVu.ResumeLayout(false);
            this.tabDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDVGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.tabQuyDinh.ResumeLayout(false);
            this.tabQuyDinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQDTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQD)).EndInit();

            this.BackColor = Color.White;
            this.Font = new Font("Segoe UI", 10F);
            this.tabControl.Font = new Font("Segoe UI", 10F);
            this.tabControl.Padding = new Point(14, 6);

            foreach (TabPage tab in this.tabControl.TabPages)
            {
                tab.BackColor = Color.White;
                tab.Padding = new Padding(12);
            }

            foreach (Control control in new Control[]
            {
                this.lblKhuMa, this.lblKhuTen, this.lblNVMa, this.lblNVTen,
                this.lblNVVaiTro, this.lblNVSDT, this.lblLoaiMa, this.lblLoaiTen,
                this.lblDVMa, this.lblDVTen, this.lblDVDVT, this.lblDVGia,
                this.lblQDMa, this.lblQDLoai, this.lblQDMucDo, this.lblQDTien
            })
            {
                control.Font = new Font("Segoe UI Semibold", 10F);
                control.ForeColor = Color.FromArgb(45, 55, 72);
            }

            foreach (Control control in new Control[]
            {
                this.txtKhuMa, this.txtKhuTen, this.txtNVMa, this.txtNVTen,
                this.txtNVVaiTro, this.txtNVSDT, this.txtLoaiMa, this.txtLoaiTen,
                this.txtDVMa, this.txtDVTen, this.txtDVDVT, this.txtQDMa,
                this.txtQDMucDo
            })
            {
                control.Font = new Font("Segoe UI", 10F);
                control.BackColor = Color.White;
                control.ForeColor = Color.FromArgb(35, 45, 55);
                control.BorderStyle = BorderStyle.FixedSingle;
            }

            foreach (ComboBox control in new ComboBox[]
            {
                this.cboQDLoai
            })
            {
                control.Font = new Font("Segoe UI", 10F);
                control.BackColor = Color.White;
                control.ForeColor = Color.FromArgb(35, 45, 55);
                control.FlatStyle = FlatStyle.Flat;
            }

            foreach (NumericUpDown control in new NumericUpDown[]
            {
                this.numDVGia, this.numQDTien
            })
            {
                control.Font = new Font("Segoe UI", 10F);
                control.BackColor = Color.White;
                control.ForeColor = Color.FromArgb(35, 45, 55);
            }

            foreach (Button control in new Button[]
            {
                this.btnThemKhu, this.btnThemNV, this.btnThemLoaiTN,
                this.btnThemDV, this.btnThemQD
            })
            {
                control.Font = new Font("Segoe UI Semibold", 10F);
                control.BackColor = Color.FromArgb(37, 99, 235);
                control.ForeColor = Color.White;
                control.FlatStyle = FlatStyle.Flat;
                control.FlatAppearance.BorderSize = 0;
                control.Cursor = Cursors.Hand;
                control.Height = 34;
            }

            foreach (DataGridView grid in new DataGridView[]
            {
                this.dgvKhu, this.dgvNV, this.dgvLoaiTN, this.dgvDV, this.dgvQD
            })
            {
                grid.BackgroundColor = Color.White;
                grid.BorderStyle = BorderStyle.None;
                grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                grid.GridColor = Color.FromArgb(226, 232, 240);
                grid.EnableHeadersVisualStyles = false;
                grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 99, 235);
                grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F);
                grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grid.ColumnHeadersHeight = 38;
                grid.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
                grid.DefaultCellStyle.ForeColor = Color.FromArgb(35, 45, 55);
                grid.DefaultCellStyle.BackColor = Color.White;
                grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
                grid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 64, 175);
                grid.RowTemplate.Height = 32;
                grid.RowHeadersVisible = false;
                grid.AllowUserToAddRows = false;
                grid.AllowUserToResizeRows = false;
                grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grid.MultiSelect = false;
            }

            this.Text = "QUẢN LÝ DANH MỤC KHÁCH SẠN";
            this.ClientSize = new Size(1000, 620);

            this.ResumeLayout(false);

        }
    }
}