using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    partial class FrmPhongTienNghi
    {
        private System.ComponentModel.IContainer components = null;

        private TabControl tabControl;
        private TabPage tabPhong;
        private TabPage tabTienNghi;
        private TabPage tabLapDat;

        // Tab Phong
        private Label lblPhong, lblKhu, lblMax, lblGia;
        private TextBox txtPhong;
        private ComboBox cboKhu;
        private NumericUpDown numMax, numGia;
        private Button btnThemPhong;
        private DataGridView dgvPhong;

        // Tab Tien Nghi
        private Label lblMaTN, lblLoai, lblSTT, lblTinhTrang;
        private TextBox txtMaTN, txtTinhTrang;
        private ComboBox cboLoai;
        private NumericUpDown numSTT;
        private Button btnThemTN;
        private DataGridView dgvTN;

        // Tab Lap Dat
        private Label lblSoLD, lblTN, lblPhongLD, lblNgay, lblTTLD, lblNV, lblGhiChu;
        private TextBox txtSoLD, txtTTLD, txtGhiChu;
        private ComboBox cboTN, cboPhong, cboNV;
        private DateTimePicker dtNgay;
        private Button btnLapDat;
        private DataGridView dgvLD;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPhong = new System.Windows.Forms.TabPage();
            this.lblPhong = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.lblKhu = new System.Windows.Forms.Label();
            this.cboKhu = new System.Windows.Forms.ComboBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.lblGia = new System.Windows.Forms.Label();
            this.numGia = new System.Windows.Forms.NumericUpDown();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.tabTienNghi = new System.Windows.Forms.TabPage();
            this.lblMaTN = new System.Windows.Forms.Label();
            this.txtMaTN = new System.Windows.Forms.TextBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.lblSTT = new System.Windows.Forms.Label();
            this.numSTT = new System.Windows.Forms.NumericUpDown();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.btnThemTN = new System.Windows.Forms.Button();
            this.dgvTN = new System.Windows.Forms.DataGridView();
            this.tabLapDat = new System.Windows.Forms.TabPage();
            this.lblSoLD = new System.Windows.Forms.Label();
            this.txtSoLD = new System.Windows.Forms.TextBox();
            this.lblTN = new System.Windows.Forms.Label();
            this.cboTN = new System.Windows.Forms.ComboBox();
            this.lblPhongLD = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.lblNgay = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTTLD = new System.Windows.Forms.Label();
            this.txtTTLD = new System.Windows.Forms.TextBox();
            this.lblNV = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnLapDat = new System.Windows.Forms.Button();
            this.dgvLD = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.tabTienNghi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).BeginInit();
            this.tabLapDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPhong);
            this.tabControl.Controls.Add(this.tabTienNghi);
            this.tabControl.Controls.Add(this.tabLapDat);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 480);
            this.tabControl.TabIndex = 0;
            // 
            // tabPhong
            // 
            this.tabPhong.Controls.Add(this.lblPhong);
            this.tabPhong.Controls.Add(this.txtPhong);
            this.tabPhong.Controls.Add(this.lblKhu);
            this.tabPhong.Controls.Add(this.cboKhu);
            this.tabPhong.Controls.Add(this.lblMax);
            this.tabPhong.Controls.Add(this.numMax);
            this.tabPhong.Controls.Add(this.lblGia);
            this.tabPhong.Controls.Add(this.numGia);
            this.tabPhong.Controls.Add(this.btnThemPhong);
            this.tabPhong.Controls.Add(this.dgvPhong);
            this.tabPhong.Location = new System.Drawing.Point(4, 29);
            this.tabPhong.Name = "tabPhong";
            this.tabPhong.Size = new System.Drawing.Size(792, 447);
            this.tabPhong.TabIndex = 0;
            this.tabPhong.Text = "Phòng";
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(10, 15);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(76, 20);
            this.lblPhong.TabIndex = 0;
            this.lblPhong.Text = "Số phòng:";
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(75, 12);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(80, 27);
            this.txtPhong.TabIndex = 1;
            this.txtPhong.TextChanged += new System.EventHandler(this.txtPhong_TextChanged);
            // 
            // lblKhu
            // 
            this.lblKhu.AutoSize = true;
            this.lblKhu.Location = new System.Drawing.Point(165, 15);
            this.lblKhu.Name = "lblKhu";
            this.lblKhu.Size = new System.Drawing.Size(64, 20);
            this.lblKhu.TabIndex = 2;
            this.lblKhu.Text = "Khu vực:";
            // 
            // cboKhu
            // 
            this.cboKhu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhu.Location = new System.Drawing.Point(220, 12);
            this.cboKhu.Name = "cboKhu";
            this.cboKhu.Size = new System.Drawing.Size(110, 28);
            this.cboKhu.TabIndex = 3;
            this.cboKhu.SelectedIndexChanged += new System.EventHandler(this.cboKhu_SelectedIndexChanged);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(340, 15);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(72, 20);
            this.lblMax.TabIndex = 4;
            this.lblMax.Text = "Sức chứa:";
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(400, 12);
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(50, 27);
            this.numMax.TabIndex = 5;
            this.numMax.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(460, 15);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(103, 20);
            this.lblGia.TabIndex = 6;
            this.lblGia.Text = "Đơn giá/ngày:";
            // 
            // numGia
            // 
            this.numGia.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numGia.Location = new System.Drawing.Point(540, 12);
            this.numGia.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numGia.Name = "numGia";
            this.numGia.Size = new System.Drawing.Size(100, 27);
            this.numGia.TabIndex = 7;
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(650, 10);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(100, 26);
            this.btnThemPhong.TabIndex = 8;
            this.btnThemPhong.Text = "Thêm phòng";
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeight = 29;
            this.dgvPhong.Location = new System.Drawing.Point(10, 45);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.Size = new System.Drawing.Size(765, 390);
            this.dgvPhong.TabIndex = 9;
            // 
            // tabTienNghi
            // 
            this.tabTienNghi.Controls.Add(this.lblMaTN);
            this.tabTienNghi.Controls.Add(this.txtMaTN);
            this.tabTienNghi.Controls.Add(this.lblLoai);
            this.tabTienNghi.Controls.Add(this.cboLoai);
            this.tabTienNghi.Controls.Add(this.lblSTT);
            this.tabTienNghi.Controls.Add(this.numSTT);
            this.tabTienNghi.Controls.Add(this.lblTinhTrang);
            this.tabTienNghi.Controls.Add(this.txtTinhTrang);
            this.tabTienNghi.Controls.Add(this.btnThemTN);
            this.tabTienNghi.Controls.Add(this.dgvTN);
            this.tabTienNghi.Location = new System.Drawing.Point(4, 29);
            this.tabTienNghi.Name = "tabTienNghi";
            this.tabTienNghi.Size = new System.Drawing.Size(792, 447);
            this.tabTienNghi.TabIndex = 1;
            this.tabTienNghi.Text = "Tiện nghi";
            // 
            // lblMaTN
            // 
            this.lblMaTN.AutoSize = true;
            this.lblMaTN.Location = new System.Drawing.Point(10, 15);
            this.lblMaTN.Name = "lblMaTN";
            this.lblMaTN.Size = new System.Drawing.Size(56, 20);
            this.lblMaTN.TabIndex = 0;
            this.lblMaTN.Text = "Mã TN:";
            // 
            // txtMaTN
            // 
            this.txtMaTN.Location = new System.Drawing.Point(60, 12);
            this.txtMaTN.Name = "txtMaTN";
            this.txtMaTN.Size = new System.Drawing.Size(80, 27);
            this.txtMaTN.TabIndex = 1;
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(150, 15);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(63, 20);
            this.lblLoai.TabIndex = 2;
            this.lblLoai.Text = "Loại TN:";
            // 
            // cboLoai
            // 
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.Location = new System.Drawing.Point(205, 12);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(120, 28);
            this.cboLoai.TabIndex = 3;
            // 
            // lblSTT
            // 
            this.lblSTT.AutoSize = true;
            this.lblSTT.Location = new System.Drawing.Point(335, 15);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(36, 20);
            this.lblSTT.TabIndex = 4;
            this.lblSTT.Text = "STT:";
            // 
            // numSTT
            // 
            this.numSTT.Location = new System.Drawing.Point(370, 12);
            this.numSTT.Name = "numSTT";
            this.numSTT.Size = new System.Drawing.Size(50, 27);
            this.numSTT.TabIndex = 5;
            this.numSTT.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(430, 15);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(79, 20);
            this.lblTinhTrang.TabIndex = 6;
            this.lblTinhTrang.Text = "Tình trạng:";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(495, 12);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(110, 27);
            this.txtTinhTrang.TabIndex = 7;
            // 
            // btnThemTN
            // 
            this.btnThemTN.Location = new System.Drawing.Point(620, 10);
            this.btnThemTN.Name = "btnThemTN";
            this.btnThemTN.Size = new System.Drawing.Size(110, 26);
            this.btnThemTN.TabIndex = 8;
            this.btnThemTN.Text = "Thêm tiện nghi";
            this.btnThemTN.Click += new System.EventHandler(this.btnThemTN_Click);
            // 
            // dgvTN
            // 
            this.dgvTN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTN.ColumnHeadersHeight = 29;
            this.dgvTN.Location = new System.Drawing.Point(10, 45);
            this.dgvTN.Name = "dgvTN";
            this.dgvTN.RowHeadersWidth = 51;
            this.dgvTN.Size = new System.Drawing.Size(765, 390);
            this.dgvTN.TabIndex = 9;
            // 
            // tabLapDat
            // 
            this.tabLapDat.Controls.Add(this.lblSoLD);
            this.tabLapDat.Controls.Add(this.txtSoLD);
            this.tabLapDat.Controls.Add(this.lblTN);
            this.tabLapDat.Controls.Add(this.cboTN);
            this.tabLapDat.Controls.Add(this.lblPhongLD);
            this.tabLapDat.Controls.Add(this.cboPhong);
            this.tabLapDat.Controls.Add(this.lblNgay);
            this.tabLapDat.Controls.Add(this.dtNgay);
            this.tabLapDat.Controls.Add(this.lblTTLD);
            this.tabLapDat.Controls.Add(this.txtTTLD);
            this.tabLapDat.Controls.Add(this.lblNV);
            this.tabLapDat.Controls.Add(this.cboNV);
            this.tabLapDat.Controls.Add(this.lblGhiChu);
            this.tabLapDat.Controls.Add(this.txtGhiChu);
            this.tabLapDat.Controls.Add(this.btnLapDat);
            this.tabLapDat.Controls.Add(this.dgvLD);
            this.tabLapDat.Location = new System.Drawing.Point(4, 29);
            this.tabLapDat.Name = "tabLapDat";
            this.tabLapDat.Size = new System.Drawing.Size(792, 447);
            this.tabLapDat.TabIndex = 2;
            this.tabLapDat.Text = "Lắp đặt / luân chuyển";
            // 
            // lblSoLD
            // 
            this.lblSoLD.AutoSize = true;
            this.lblSoLD.Location = new System.Drawing.Point(10, 12);
            this.lblSoLD.Name = "lblSoLD";
            this.lblSoLD.Size = new System.Drawing.Size(70, 20);
            this.lblSoLD.TabIndex = 0;
            this.lblSoLD.Text = "Số phiếu:";
            // 
            // txtSoLD
            // 
            this.txtSoLD.Location = new System.Drawing.Point(65, 9);
            this.txtSoLD.Name = "txtSoLD";
            this.txtSoLD.Size = new System.Drawing.Size(75, 27);
            this.txtSoLD.TabIndex = 1;
            // 
            // lblTN
            // 
            this.lblTN.AutoSize = true;
            this.lblTN.Location = new System.Drawing.Point(150, 12);
            this.lblTN.Name = "lblTN";
            this.lblTN.Size = new System.Drawing.Size(73, 20);
            this.lblTN.TabIndex = 2;
            this.lblTN.Text = "Tiện nghi:";
            // 
            // cboTN
            // 
            this.cboTN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTN.Location = new System.Drawing.Point(210, 9);
            this.cboTN.Name = "cboTN";
            this.cboTN.Size = new System.Drawing.Size(85, 28);
            this.cboTN.TabIndex = 3;
            // 
            // lblPhongLD
            // 
            this.lblPhongLD.AutoSize = true;
            this.lblPhongLD.Location = new System.Drawing.Point(305, 12);
            this.lblPhongLD.Name = "lblPhongLD";
            this.lblPhongLD.Size = new System.Drawing.Size(54, 20);
            this.lblPhongLD.TabIndex = 4;
            this.lblPhongLD.Text = "Phòng:";
            // 
            // cboPhong
            // 
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.Location = new System.Drawing.Point(350, 9);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(75, 28);
            this.cboPhong.TabIndex = 5;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(435, 12);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(47, 20);
            this.lblNgay.TabIndex = 6;
            this.lblNgay.Text = "Ngày:";
            // 
            // dtNgay
            // 
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(475, 9);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(120, 27);
            this.dtNgay.TabIndex = 7;
            // 
            // lblTTLD
            // 
            this.lblTTLD.AutoSize = true;
            this.lblTTLD.Location = new System.Drawing.Point(605, 12);
            this.lblTTLD.Name = "lblTTLD";
            this.lblTTLD.Size = new System.Drawing.Size(79, 20);
            this.lblTTLD.TabIndex = 8;
            this.lblTTLD.Text = "Tình trạng:";
            // 
            // txtTTLD
            // 
            this.txtTTLD.Location = new System.Drawing.Point(670, 9);
            this.txtTTLD.Name = "txtTTLD";
            this.txtTTLD.Size = new System.Drawing.Size(100, 27);
            this.txtTTLD.TabIndex = 9;
            // 
            // lblNV
            // 
            this.lblNV.AutoSize = true;
            this.lblNV.Location = new System.Drawing.Point(10, 42);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(78, 20);
            this.lblNV.TabIndex = 10;
            this.lblNV.Text = "Nhân viên:";
            // 
            // cboNV
            // 
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.Location = new System.Drawing.Point(75, 39);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(130, 28);
            this.cboNV.TabIndex = 11;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(215, 42);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(61, 20);
            this.lblGhiChu.TabIndex = 12;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(265, 39);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(330, 27);
            this.txtGhiChu.TabIndex = 13;
            // 
            // btnLapDat
            // 
            this.btnLapDat.Location = new System.Drawing.Point(670, 37);
            this.btnLapDat.Name = "btnLapDat";
            this.btnLapDat.Size = new System.Drawing.Size(100, 26);
            this.btnLapDat.TabIndex = 14;
            this.btnLapDat.Text = "Lập phiếu";
            this.btnLapDat.Click += new System.EventHandler(this.btnLapDat_Click);
            // 
            // dgvLD
            // 
            this.dgvLD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLD.ColumnHeadersHeight = 29;
            this.dgvLD.Location = new System.Drawing.Point(10, 72);
            this.dgvLD.Name = "dgvLD";
            this.dgvLD.RowHeadersWidth = 51;
            this.dgvLD.Size = new System.Drawing.Size(765, 360);
            this.dgvLD.TabIndex = 15;
            // 
            // FrmPhongTienNghi
            // 
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPhongTienNghi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng - Tiện nghi - Phiếu lắp đặt";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPhong.ResumeLayout(false);
            this.tabPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.tabTienNghi.ResumeLayout(false);
            this.tabTienNghi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).EndInit();
            this.tabLapDat.ResumeLayout(false);
            this.tabLapDat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).EndInit();
            this.ResumeLayout(false);

        }
    }
}