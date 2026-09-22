namespace QuanLyThuVien.Forms
{
    partial class FrmDanhMuc
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabNV;
        private System.Windows.Forms.TabPage tabTL;
        private System.Windows.Forms.TabPage tabNXB;

        private System.Windows.Forms.Label lblNVMa;
        private System.Windows.Forms.Label lblNVHo;
        private System.Windows.Forms.Label lblNVTen;
        private System.Windows.Forms.Label lblNVPhai;
        private System.Windows.Forms.Label lblNVNgaySinh;
        private System.Windows.Forms.Label lblNVChucVu;
        private System.Windows.Forms.Label lblNVSDT;

        private System.Windows.Forms.TextBox txtNVMa;
        private System.Windows.Forms.TextBox txtNVHo;
        private System.Windows.Forms.TextBox txtNVTen;
        private System.Windows.Forms.ComboBox cboNVPhai;
        private System.Windows.Forms.DateTimePicker dtNVNgaySinh;
        private System.Windows.Forms.TextBox txtNVChucVu;
        private System.Windows.Forms.TextBox txtNVSDT;

        private System.Windows.Forms.Button btnNVThem;
        private System.Windows.Forms.Button btnNVCapNhat;
        private System.Windows.Forms.Button btnNVXoa;
        private System.Windows.Forms.Button btnNVMoi;

        private System.Windows.Forms.DataGridView dgvNV;

        private System.Windows.Forms.Label lblTLMa;
        private System.Windows.Forms.Label lblTLTen;

        private System.Windows.Forms.TextBox txtTLMa;
        private System.Windows.Forms.TextBox txtTLTen;

        private System.Windows.Forms.Button btnTLThem;
        private System.Windows.Forms.Button btnTLCapNhat;
        private System.Windows.Forms.Button btnTLXoa;
        private System.Windows.Forms.Button btnTLMoi;

        private System.Windows.Forms.DataGridView dgvTL;

        private System.Windows.Forms.Label lblNXBMa;
        private System.Windows.Forms.Label lblNXBDiaChi;
        private System.Windows.Forms.Label lblNXBSDT;

        private System.Windows.Forms.TextBox txtNXBMa;
        private System.Windows.Forms.TextBox txtNXBDiaChi;
        private System.Windows.Forms.TextBox txtNXBSDT;

        private System.Windows.Forms.Button btnNXBThem;
        private System.Windows.Forms.Button btnNXBCapNhat;
        private System.Windows.Forms.Button btnNXBXoa;
        private System.Windows.Forms.Button btnNXBMoi;

        private System.Windows.Forms.DataGridView dgvNXB;

        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabNV = new System.Windows.Forms.TabPage();
            this.lblNVMa = new System.Windows.Forms.Label();
            this.txtNVMa = new System.Windows.Forms.TextBox();
            this.lblNVHo = new System.Windows.Forms.Label();
            this.txtNVHo = new System.Windows.Forms.TextBox();
            this.lblNVTen = new System.Windows.Forms.Label();
            this.txtNVTen = new System.Windows.Forms.TextBox();
            this.lblNVPhai = new System.Windows.Forms.Label();
            this.cboNVPhai = new System.Windows.Forms.ComboBox();
            this.lblNVNgaySinh = new System.Windows.Forms.Label();
            this.dtNVNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNVChucVu = new System.Windows.Forms.Label();
            this.txtNVChucVu = new System.Windows.Forms.TextBox();
            this.lblNVSDT = new System.Windows.Forms.Label();
            this.txtNVSDT = new System.Windows.Forms.TextBox();
            this.btnNVThem = new System.Windows.Forms.Button();
            this.btnNVCapNhat = new System.Windows.Forms.Button();
            this.btnNVXoa = new System.Windows.Forms.Button();
            this.btnNVMoi = new System.Windows.Forms.Button();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabTL = new System.Windows.Forms.TabPage();
            this.lblTLMa = new System.Windows.Forms.Label();
            this.txtTLMa = new System.Windows.Forms.TextBox();
            this.lblTLTen = new System.Windows.Forms.Label();
            this.txtTLTen = new System.Windows.Forms.TextBox();
            this.btnTLThem = new System.Windows.Forms.Button();
            this.btnTLCapNhat = new System.Windows.Forms.Button();
            this.btnTLXoa = new System.Windows.Forms.Button();
            this.btnTLMoi = new System.Windows.Forms.Button();
            this.dgvTL = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabNXB = new System.Windows.Forms.TabPage();
            this.lblNXBMa = new System.Windows.Forms.Label();
            this.txtNXBMa = new System.Windows.Forms.TextBox();
            this.lblNXBDiaChi = new System.Windows.Forms.Label();
            this.txtNXBDiaChi = new System.Windows.Forms.TextBox();
            this.lblNXBSDT = new System.Windows.Forms.Label();
            this.txtNXBSDT = new System.Windows.Forms.TextBox();
            this.btnNXBThem = new System.Windows.Forms.Button();
            this.btnNXBCapNhat = new System.Windows.Forms.Button();
            this.btnNXBXoa = new System.Windows.Forms.Button();
            this.btnNXBMoi = new System.Windows.Forms.Button();
            this.dgvNXB = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.tabNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.tabTL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTL)).BeginInit();
            this.tabNXB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabNV);
            this.tabs.Controls.Add(this.tabTL);
            this.tabs.Controls.Add(this.tabNXB);
            this.tabs.Location = new System.Drawing.Point(25, 20);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1010, 615);
            this.tabs.TabIndex = 0;
            // 
            // tabNV
            // 
            this.tabNV.Controls.Add(this.lblNVMa);
            this.tabNV.Controls.Add(this.txtNVMa);
            this.tabNV.Controls.Add(this.lblNVHo);
            this.tabNV.Controls.Add(this.txtNVHo);
            this.tabNV.Controls.Add(this.lblNVTen);
            this.tabNV.Controls.Add(this.txtNVTen);
            this.tabNV.Controls.Add(this.lblNVPhai);
            this.tabNV.Controls.Add(this.cboNVPhai);
            this.tabNV.Controls.Add(this.lblNVNgaySinh);
            this.tabNV.Controls.Add(this.dtNVNgaySinh);
            this.tabNV.Controls.Add(this.lblNVChucVu);
            this.tabNV.Controls.Add(this.txtNVChucVu);
            this.tabNV.Controls.Add(this.lblNVSDT);
            this.tabNV.Controls.Add(this.txtNVSDT);
            this.tabNV.Controls.Add(this.btnNVThem);
            this.tabNV.Controls.Add(this.btnNVCapNhat);
            this.tabNV.Controls.Add(this.btnNVXoa);
            this.tabNV.Controls.Add(this.btnNVMoi);
            this.tabNV.Controls.Add(this.dgvNV);
            this.tabNV.Location = new System.Drawing.Point(4, 39);
            this.tabNV.Name = "tabNV";
            this.tabNV.Size = new System.Drawing.Size(1002, 572);
            this.tabNV.TabIndex = 0;
            this.tabNV.Text = "Nhân viên";
            this.tabNV.UseVisualStyleBackColor = true;
            // 
            // lblNVMa
            // 
            this.lblNVMa.AutoSize = true;
            this.lblNVMa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNVMa.Location = new System.Drawing.Point(45, 65);
            this.lblNVMa.Name = "lblNVMa";
            this.lblNVMa.Size = new System.Drawing.Size(166, 32);
            this.lblNVMa.TabIndex = 0;
            this.lblNVMa.Text = "Mã nhân viên:";
            // 
            // txtNVMa
            // 
            this.txtNVMa.Location = new System.Drawing.Point(206, 65);
            this.txtNVMa.Name = "txtNVMa";
            this.txtNVMa.Size = new System.Drawing.Size(200, 37);
            this.txtNVMa.TabIndex = 1;
            // 
            // lblNVHo
            // 
            this.lblNVHo.AutoSize = true;
            this.lblNVHo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNVHo.Location = new System.Drawing.Point(45, 110);
            this.lblNVHo.Name = "lblNVHo";
            this.lblNVHo.Size = new System.Drawing.Size(50, 32);
            this.lblNVHo.TabIndex = 2;
            this.lblNVHo.Text = "Họ:";
            // 
            // txtNVHo
            // 
            this.txtNVHo.Location = new System.Drawing.Point(175, 106);
            this.txtNVHo.Name = "txtNVHo";
            this.txtNVHo.Size = new System.Drawing.Size(200, 37);
            this.txtNVHo.TabIndex = 3;
            // 
            // lblNVTen
            // 
            this.lblNVTen.AutoSize = true;
            this.lblNVTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNVTen.Location = new System.Drawing.Point(45, 155);
            this.lblNVTen.Name = "lblNVTen";
            this.lblNVTen.Size = new System.Drawing.Size(57, 32);
            this.lblNVTen.TabIndex = 4;
            this.lblNVTen.Text = "Tên:";
            // 
            // txtNVTen
            // 
            this.txtNVTen.Location = new System.Drawing.Point(175, 151);
            this.txtNVTen.Name = "txtNVTen";
            this.txtNVTen.Size = new System.Drawing.Size(200, 37);
            this.txtNVTen.TabIndex = 5;
            // 
            // lblNVPhai
            // 
            this.lblNVPhai.AutoSize = true;
            this.lblNVPhai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNVPhai.Location = new System.Drawing.Point(425, 65);
            this.lblNVPhai.Name = "lblNVPhai";
            this.lblNVPhai.Size = new System.Drawing.Size(64, 32);
            this.lblNVPhai.TabIndex = 6;
            this.lblNVPhai.Text = "Phái:";
            // 
            // cboNVPhai
            // 
            this.cboNVPhai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNVPhai.FormattingEnabled = true;
            this.cboNVPhai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboNVPhai.Location = new System.Drawing.Point(535, 61);
            this.cboNVPhai.Name = "cboNVPhai";
            this.cboNVPhai.Size = new System.Drawing.Size(170, 38);
            this.cboNVPhai.TabIndex = 7;
            // 
            // lblNVNgaySinh
            // 
            this.lblNVNgaySinh.AutoSize = true;
            this.lblNVNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNVNgaySinh.Location = new System.Drawing.Point(425, 110);
            this.lblNVNgaySinh.Name = "lblNVNgaySinh";
            this.lblNVNgaySinh.Size = new System.Drawing.Size(126, 32);
            this.lblNVNgaySinh.TabIndex = 8;
            this.lblNVNgaySinh.Text = "Ngày sinh:";
            // 
            // dtNVNgaySinh
            // 
            this.dtNVNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNVNgaySinh.Location = new System.Drawing.Point(557, 104);
            this.dtNVNgaySinh.Name = "dtNVNgaySinh";
            this.dtNVNgaySinh.Size = new System.Drawing.Size(170, 37);
            this.dtNVNgaySinh.TabIndex = 9;
            this.dtNVNgaySinh.ValueChanged += new System.EventHandler(this.dtNVNgaySinh_ValueChanged);
            // 
            // lblNVChucVu
            // 
            this.lblNVChucVu.AutoSize = true;
            this.lblNVChucVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNVChucVu.Location = new System.Drawing.Point(425, 155);
            this.lblNVChucVu.Name = "lblNVChucVu";
            this.lblNVChucVu.Size = new System.Drawing.Size(106, 32);
            this.lblNVChucVu.TabIndex = 10;
            this.lblNVChucVu.Text = "Chức vụ:";
            // 
            // txtNVChucVu
            // 
            this.txtNVChucVu.Location = new System.Drawing.Point(535, 151);
            this.txtNVChucVu.Name = "txtNVChucVu";
            this.txtNVChucVu.Size = new System.Drawing.Size(200, 37);
            this.txtNVChucVu.TabIndex = 11;
            // 
            // lblNVSDT
            // 
            this.lblNVSDT.AutoSize = true;
            this.lblNVSDT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNVSDT.Location = new System.Drawing.Point(425, 200);
            this.lblNVSDT.Name = "lblNVSDT";
            this.lblNVSDT.Size = new System.Drawing.Size(130, 32);
            this.lblNVSDT.TabIndex = 12;
            this.lblNVSDT.Text = "Điện thoại:";
            // 
            // txtNVSDT
            // 
            this.txtNVSDT.Location = new System.Drawing.Point(557, 198);
            this.txtNVSDT.Name = "txtNVSDT";
            this.txtNVSDT.Size = new System.Drawing.Size(200, 37);
            this.txtNVSDT.TabIndex = 13;
            // 
            // btnNVThem
            // 
            this.btnNVThem.Location = new System.Drawing.Point(760, 61);
            this.btnNVThem.Name = "btnNVThem";
            this.btnNVThem.Size = new System.Drawing.Size(105, 35);
            this.btnNVThem.TabIndex = 14;
            this.btnNVThem.Text = "Thêm";
            this.btnNVThem.UseVisualStyleBackColor = true;
            this.btnNVThem.Click += new System.EventHandler(this.btnNVThem_Click);
            // 
            // btnNVCapNhat
            // 
            this.btnNVCapNhat.Location = new System.Drawing.Point(875, 61);
            this.btnNVCapNhat.Name = "btnNVCapNhat";
            this.btnNVCapNhat.Size = new System.Drawing.Size(124, 35);
            this.btnNVCapNhat.TabIndex = 15;
            this.btnNVCapNhat.Text = "Cập nhật";
            this.btnNVCapNhat.UseVisualStyleBackColor = true;
            this.btnNVCapNhat.Click += new System.EventHandler(this.btnNVCapNhat_Click);
            // 
            // btnNVXoa
            // 
            this.btnNVXoa.Location = new System.Drawing.Point(760, 106);
            this.btnNVXoa.Name = "btnNVXoa";
            this.btnNVXoa.Size = new System.Drawing.Size(105, 35);
            this.btnNVXoa.TabIndex = 16;
            this.btnNVXoa.Text = "Xóa";
            this.btnNVXoa.UseVisualStyleBackColor = true;
            this.btnNVXoa.Click += new System.EventHandler(this.btnNVXoa_Click);
            // 
            // btnNVMoi
            // 
            this.btnNVMoi.Location = new System.Drawing.Point(875, 106);
            this.btnNVMoi.Name = "btnNVMoi";
            this.btnNVMoi.Size = new System.Drawing.Size(124, 35);
            this.btnNVMoi.TabIndex = 17;
            this.btnNVMoi.Text = "Làm mới";
            this.btnNVMoi.UseVisualStyleBackColor = true;
            this.btnNVMoi.Click += new System.EventHandler(this.btnNVMoi_Click);
            // 
            // dgvNV
            // 
            this.dgvNV.AllowUserToAddRows = false;
            this.dgvNV.AllowUserToDeleteRows = false;
            this.dgvNV.AllowUserToResizeRows = false;
            this.dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvNV.ColumnHeadersHeight = 32;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNV.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvNV.EnableHeadersVisualStyles = false;
            this.dgvNV.GridColor = System.Drawing.Color.LightGray;
            this.dgvNV.Location = new System.Drawing.Point(45, 260);
            this.dgvNV.MultiSelect = false;
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.ReadOnly = true;
            this.dgvNV.RowHeadersVisible = false;
            this.dgvNV.RowHeadersWidth = 72;
            this.dgvNV.RowTemplate.Height = 45;
            this.dgvNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNV.Size = new System.Drawing.Size(915, 275);
            this.dgvNV.TabIndex = 18;
            this.dgvNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNV_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã NV";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Phái";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Ngày sinh";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Chức vụ";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Điện thoại";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // tabTL
            // 
            this.tabTL.Controls.Add(this.lblTLMa);
            this.tabTL.Controls.Add(this.txtTLMa);
            this.tabTL.Controls.Add(this.lblTLTen);
            this.tabTL.Controls.Add(this.txtTLTen);
            this.tabTL.Controls.Add(this.btnTLThem);
            this.tabTL.Controls.Add(this.btnTLCapNhat);
            this.tabTL.Controls.Add(this.btnTLXoa);
            this.tabTL.Controls.Add(this.btnTLMoi);
            this.tabTL.Controls.Add(this.dgvTL);
            this.tabTL.Location = new System.Drawing.Point(4, 39);
            this.tabTL.Name = "tabTL";
            this.tabTL.Size = new System.Drawing.Size(1002, 572);
            this.tabTL.TabIndex = 1;
            this.tabTL.Text = "Thể loại";
            this.tabTL.UseVisualStyleBackColor = true;
            // 
            // lblTLMa
            // 
            this.lblTLMa.AutoSize = true;
            this.lblTLMa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTLMa.Location = new System.Drawing.Point(60, 70);
            this.lblTLMa.Name = "lblTLMa";
            this.lblTLMa.Size = new System.Drawing.Size(140, 32);
            this.lblTLMa.TabIndex = 0;
            this.lblTLMa.Text = "Mã thể loại:";
            // 
            // txtTLMa
            // 
            this.txtTLMa.Location = new System.Drawing.Point(230, 70);
            this.txtTLMa.Name = "txtTLMa";
            this.txtTLMa.Size = new System.Drawing.Size(230, 37);
            this.txtTLMa.TabIndex = 1;
            // 
            // lblTLTen
            // 
            this.lblTLTen.AutoSize = true;
            this.lblTLTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTLTen.Location = new System.Drawing.Point(60, 115);
            this.lblTLTen.Name = "lblTLTen";
            this.lblTLTen.Size = new System.Drawing.Size(144, 32);
            this.lblTLTen.TabIndex = 2;
            this.lblTLTen.Text = "Tên thể loại:";
            // 
            // txtTLTen
            // 
            this.txtTLTen.Location = new System.Drawing.Point(210, 115);
            this.txtTLTen.Name = "txtTLTen";
            this.txtTLTen.Size = new System.Drawing.Size(300, 37);
            this.txtTLTen.TabIndex = 3;
            // 
            // btnTLThem
            // 
            this.btnTLThem.Location = new System.Drawing.Point(530, 66);
            this.btnTLThem.Name = "btnTLThem";
            this.btnTLThem.Size = new System.Drawing.Size(105, 35);
            this.btnTLThem.TabIndex = 4;
            this.btnTLThem.Text = "Thêm";
            this.btnTLThem.Click += new System.EventHandler(this.btnTLThem_Click);
            // 
            // btnTLCapNhat
            // 
            this.btnTLCapNhat.Location = new System.Drawing.Point(645, 66);
            this.btnTLCapNhat.Name = "btnTLCapNhat";
            this.btnTLCapNhat.Size = new System.Drawing.Size(132, 35);
            this.btnTLCapNhat.TabIndex = 5;
            this.btnTLCapNhat.Text = "Cập nhật";
            this.btnTLCapNhat.Click += new System.EventHandler(this.btnTLCapNhat_Click);
            // 
            // btnTLXoa
            // 
            this.btnTLXoa.Location = new System.Drawing.Point(530, 111);
            this.btnTLXoa.Name = "btnTLXoa";
            this.btnTLXoa.Size = new System.Drawing.Size(105, 35);
            this.btnTLXoa.TabIndex = 6;
            this.btnTLXoa.Text = "Xóa";
            this.btnTLXoa.Click += new System.EventHandler(this.btnTLXoa_Click);
            // 
            // btnTLMoi
            // 
            this.btnTLMoi.Location = new System.Drawing.Point(645, 111);
            this.btnTLMoi.Name = "btnTLMoi";
            this.btnTLMoi.Size = new System.Drawing.Size(132, 35);
            this.btnTLMoi.TabIndex = 7;
            this.btnTLMoi.Text = "Làm mới";
            this.btnTLMoi.Click += new System.EventHandler(this.btnTLMoi_Click);
            // 
            // dgvTL
            // 
            this.dgvTL.AllowUserToAddRows = false;
            this.dgvTL.AllowUserToDeleteRows = false;
            this.dgvTL.AllowUserToResizeRows = false;
            this.dgvTL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTL.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTL.ColumnHeadersHeight = 32;
            this.dgvTL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTL.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTL.EnableHeadersVisualStyles = false;
            this.dgvTL.GridColor = System.Drawing.Color.LightGray;
            this.dgvTL.Location = new System.Drawing.Point(45, 200);
            this.dgvTL.MultiSelect = false;
            this.dgvTL.Name = "dgvTL";
            this.dgvTL.ReadOnly = true;
            this.dgvTL.RowHeadersVisible = false;
            this.dgvTL.RowHeadersWidth = 72;
            this.dgvTL.RowTemplate.Height = 45;
            this.dgvTL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTL.Size = new System.Drawing.Size(915, 330);
            this.dgvTL.TabIndex = 8;
            this.dgvTL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTL_CellClick);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Mã thể loại";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Tên thể loại";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // tabNXB
            // 
            this.tabNXB.Controls.Add(this.lblNXBMa);
            this.tabNXB.Controls.Add(this.txtNXBMa);
            this.tabNXB.Controls.Add(this.lblNXBDiaChi);
            this.tabNXB.Controls.Add(this.txtNXBDiaChi);
            this.tabNXB.Controls.Add(this.lblNXBSDT);
            this.tabNXB.Controls.Add(this.txtNXBSDT);
            this.tabNXB.Controls.Add(this.btnNXBThem);
            this.tabNXB.Controls.Add(this.btnNXBCapNhat);
            this.tabNXB.Controls.Add(this.btnNXBXoa);
            this.tabNXB.Controls.Add(this.btnNXBMoi);
            this.tabNXB.Controls.Add(this.dgvNXB);
            this.tabNXB.Location = new System.Drawing.Point(4, 39);
            this.tabNXB.Name = "tabNXB";
            this.tabNXB.Size = new System.Drawing.Size(1002, 572);
            this.tabNXB.TabIndex = 2;
            this.tabNXB.Text = "Nhà xuất bản";
            this.tabNXB.UseVisualStyleBackColor = true;
            // 
            // lblNXBMa
            // 
            this.lblNXBMa.AutoSize = true;
            this.lblNXBMa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNXBMa.Location = new System.Drawing.Point(50, 60);
            this.lblNXBMa.Name = "lblNXBMa";
            this.lblNXBMa.Size = new System.Drawing.Size(199, 32);
            this.lblNXBMa.TabIndex = 0;
            this.lblNXBMa.Text = "Mã nhà xuất bản:";
            // 
            // txtNXBMa
            // 
            this.txtNXBMa.Location = new System.Drawing.Point(255, 60);
            this.txtNXBMa.Name = "txtNXBMa";
            this.txtNXBMa.Size = new System.Drawing.Size(230, 37);
            this.txtNXBMa.TabIndex = 1;
            // 
            // lblNXBDiaChi
            // 
            this.lblNXBDiaChi.AutoSize = true;
            this.lblNXBDiaChi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNXBDiaChi.Location = new System.Drawing.Point(50, 105);
            this.lblNXBDiaChi.Name = "lblNXBDiaChi";
            this.lblNXBDiaChi.Size = new System.Drawing.Size(92, 32);
            this.lblNXBDiaChi.TabIndex = 2;
            this.lblNXBDiaChi.Text = "Địa chỉ:";
            // 
            // txtNXBDiaChi
            // 
            this.txtNXBDiaChi.Location = new System.Drawing.Point(190, 101);
            this.txtNXBDiaChi.Name = "txtNXBDiaChi";
            this.txtNXBDiaChi.Size = new System.Drawing.Size(400, 37);
            this.txtNXBDiaChi.TabIndex = 3;
            // 
            // lblNXBSDT
            // 
            this.lblNXBSDT.AutoSize = true;
            this.lblNXBSDT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNXBSDT.Location = new System.Drawing.Point(50, 150);
            this.lblNXBSDT.Name = "lblNXBSDT";
            this.lblNXBSDT.Size = new System.Drawing.Size(130, 32);
            this.lblNXBSDT.TabIndex = 4;
            this.lblNXBSDT.Text = "Điện thoại:";
            // 
            // txtNXBSDT
            // 
            this.txtNXBSDT.Location = new System.Drawing.Point(190, 146);
            this.txtNXBSDT.Name = "txtNXBSDT";
            this.txtNXBSDT.Size = new System.Drawing.Size(230, 37);
            this.txtNXBSDT.TabIndex = 5;
            // 
            // btnNXBThem
            // 
            this.btnNXBThem.Location = new System.Drawing.Point(650, 56);
            this.btnNXBThem.Name = "btnNXBThem";
            this.btnNXBThem.Size = new System.Drawing.Size(105, 35);
            this.btnNXBThem.TabIndex = 6;
            this.btnNXBThem.Text = "Thêm";
            this.btnNXBThem.Click += new System.EventHandler(this.btnNXBThem_Click);
            // 
            // btnNXBCapNhat
            // 
            this.btnNXBCapNhat.Location = new System.Drawing.Point(765, 56);
            this.btnNXBCapNhat.Name = "btnNXBCapNhat";
            this.btnNXBCapNhat.Size = new System.Drawing.Size(116, 35);
            this.btnNXBCapNhat.TabIndex = 7;
            this.btnNXBCapNhat.Text = "Cập nhật";
            this.btnNXBCapNhat.Click += new System.EventHandler(this.btnNXBCapNhat_Click);
            // 
            // btnNXBXoa
            // 
            this.btnNXBXoa.Location = new System.Drawing.Point(650, 101);
            this.btnNXBXoa.Name = "btnNXBXoa";
            this.btnNXBXoa.Size = new System.Drawing.Size(105, 35);
            this.btnNXBXoa.TabIndex = 8;
            this.btnNXBXoa.Text = "Xóa";
            this.btnNXBXoa.Click += new System.EventHandler(this.btnNXBXoa_Click);
            // 
            // btnNXBMoi
            // 
            this.btnNXBMoi.Location = new System.Drawing.Point(765, 101);
            this.btnNXBMoi.Name = "btnNXBMoi";
            this.btnNXBMoi.Size = new System.Drawing.Size(116, 35);
            this.btnNXBMoi.TabIndex = 9;
            this.btnNXBMoi.Text = "Làm mới";
            this.btnNXBMoi.Click += new System.EventHandler(this.btnNXBMoi_Click);
            // 
            // dgvNXB
            // 
            this.dgvNXB.AllowUserToAddRows = false;
            this.dgvNXB.AllowUserToDeleteRows = false;
            this.dgvNXB.AllowUserToResizeRows = false;
            this.dgvNXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNXB.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNXB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvNXB.ColumnHeadersHeight = 32;
            this.dgvNXB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNXB.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvNXB.EnableHeadersVisualStyles = false;
            this.dgvNXB.GridColor = System.Drawing.Color.LightGray;
            this.dgvNXB.Location = new System.Drawing.Point(45, 200);
            this.dgvNXB.MultiSelect = false;
            this.dgvNXB.Name = "dgvNXB";
            this.dgvNXB.ReadOnly = true;
            this.dgvNXB.RowHeadersVisible = false;
            this.dgvNXB.RowHeadersWidth = 72;
            this.dgvNXB.RowTemplate.Height = 45;
            this.dgvNXB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNXB.Size = new System.Drawing.Size(915, 330);
            this.dgvNXB.TabIndex = 10;
            this.dgvNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNXB_CellClick);
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Mã nhà xuất bản";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Điện thoại";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(930, 655);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 35);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 720);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.btnDong);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh mục và nhân viên";
            this.tabs.ResumeLayout(false);
            this.tabNV.ResumeLayout(false);
            this.tabNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.tabTL.ResumeLayout(false);
            this.tabTL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTL)).EndInit();
            this.tabNXB.ResumeLayout(false);
            this.tabNXB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}