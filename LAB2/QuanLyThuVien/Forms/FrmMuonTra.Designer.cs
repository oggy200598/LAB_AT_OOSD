namespace QuanLyThuVien.Forms
{
    partial class FrmMuonTra
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TabControl tabMuonTra;
        private System.Windows.Forms.TabPage tabMuonSach;
        private System.Windows.Forms.TabPage tabTraSach;

        private System.Windows.Forms.Label lblDocGia;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.Label lblHenTra;
        private System.Windows.Forms.Label lblDieuKien;
        private System.Windows.Forms.Label lblSachKho;
        private System.Windows.Forms.Label lblSachChon;

        private System.Windows.Forms.TextBox txtDocGia;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.DateTimePicker dtNgayMuon;
        private System.Windows.Forms.DateTimePicker dtHenTra;

        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnBo;
        private System.Windows.Forms.Button btnLapPhieu;

        private System.Windows.Forms.DataGridView dgvSachKho;
        private System.Windows.Forms.DataGridView dgvSachChon;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabMuonTra = new System.Windows.Forms.TabControl();
            this.tabMuonSach = new System.Windows.Forms.TabPage();
            this.lblDocGia = new System.Windows.Forms.Label();
            this.txtDocGia = new System.Windows.Forms.TextBox();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.lblDieuKien = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.lblHenTra = new System.Windows.Forms.Label();
            this.dtHenTra = new System.Windows.Forms.DateTimePicker();
            this.lblSachKho = new System.Windows.Forms.Label();
            this.dgvSachKho = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSachChon = new System.Windows.Forms.Label();
            this.dgvSachChon = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnBo = new System.Windows.Forms.Button();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.tabTraSach = new System.Windows.Forms.TabPage();
            this.tabMuonTra.SuspendLayout();
            this.tabMuonSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachChon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMuonTra
            // 
            this.tabMuonTra.Controls.Add(this.tabMuonSach);
            this.tabMuonTra.Controls.Add(this.tabTraSach);
            this.tabMuonTra.Location = new System.Drawing.Point(20, 39);
            this.tabMuonTra.Name = "tabMuonTra";
            this.tabMuonTra.SelectedIndex = 0;
            this.tabMuonTra.Size = new System.Drawing.Size(1212, 591);
            this.tabMuonTra.TabIndex = 0;
            this.tabMuonTra.SelectedIndexChanged += new System.EventHandler(this.tabMuonTra_SelectedIndexChanged);
            // 
            // tabMuonSach
            // 
            this.tabMuonSach.Controls.Add(this.lblDocGia);
            this.tabMuonSach.Controls.Add(this.txtDocGia);
            this.tabMuonSach.Controls.Add(this.btnKiemTra);
            this.tabMuonSach.Controls.Add(this.lblDieuKien);
            this.tabMuonSach.Controls.Add(this.lblNhanVien);
            this.tabMuonSach.Controls.Add(this.txtNhanVien);
            this.tabMuonSach.Controls.Add(this.lblNgayMuon);
            this.tabMuonSach.Controls.Add(this.dtNgayMuon);
            this.tabMuonSach.Controls.Add(this.lblHenTra);
            this.tabMuonSach.Controls.Add(this.dtHenTra);
            this.tabMuonSach.Controls.Add(this.lblSachKho);
            this.tabMuonSach.Controls.Add(this.dgvSachKho);
            this.tabMuonSach.Controls.Add(this.lblSachChon);
            this.tabMuonSach.Controls.Add(this.dgvSachChon);
            this.tabMuonSach.Controls.Add(this.btnThem);
            this.tabMuonSach.Controls.Add(this.btnBo);
            this.tabMuonSach.Controls.Add(this.btnLapPhieu);
            this.tabMuonSach.Location = new System.Drawing.Point(4, 39);
            this.tabMuonSach.Name = "tabMuonSach";
            this.tabMuonSach.Padding = new System.Windows.Forms.Padding(3);
            this.tabMuonSach.Size = new System.Drawing.Size(1204, 548);
            this.tabMuonSach.TabIndex = 0;
            this.tabMuonSach.Text = "Mượn sách";
            this.tabMuonSach.UseVisualStyleBackColor = true;
            // 
            // lblDocGia
            // 
            this.lblDocGia.AutoSize = true;
            this.lblDocGia.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDocGia.Location = new System.Drawing.Point(20, 28);
            this.lblDocGia.Name = "lblDocGia";
            this.lblDocGia.Size = new System.Drawing.Size(97, 31);
            this.lblDocGia.TabIndex = 0;
            this.lblDocGia.Text = "Độc giả:";
            // 
            // txtDocGia
            // 
            this.txtDocGia.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDocGia.Location = new System.Drawing.Point(125, 24);
            this.txtDocGia.Name = "txtDocGia";
            this.txtDocGia.Size = new System.Drawing.Size(187, 37);
            this.txtDocGia.TabIndex = 1;
            this.txtDocGia.Text = "DG001 - Lê Minh";
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnKiemTra.Location = new System.Drawing.Point(336, 24);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(235, 36);
            this.btnKiemTra.TabIndex = 2;
            this.btnKiemTra.Text = "Kiểm tra điều kiện";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // lblDieuKien
            // 
            this.lblDieuKien.AutoSize = true;
            this.lblDieuKien.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDieuKien.Location = new System.Drawing.Point(577, 27);
            this.lblDieuKien.Name = "lblDieuKien";
            this.lblDieuKien.Size = new System.Drawing.Size(261, 31);
            this.lblDieuKien.TabIndex = 3;
            this.lblDieuKien.Text = "Đủ điều kiện mượn sách";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNhanVien.Location = new System.Drawing.Point(20, 68);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(224, 31);
            this.lblNhanVien.TabIndex = 4;
            this.lblNhanVien.Text = "Nhân viên lập phiếu:";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNhanVien.Location = new System.Drawing.Point(240, 70);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(110, 37);
            this.txtNhanVien.TabIndex = 5;
            this.txtNhanVien.Text = "NV001";
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNgayMuon.Location = new System.Drawing.Point(356, 73);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Size = new System.Drawing.Size(140, 31);
            this.lblNgayMuon.TabIndex = 6;
            this.lblNgayMuon.Text = "Ngày mượn:";
            // 
            // dtNgayMuon
            // 
            this.dtNgayMuon.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayMuon.Location = new System.Drawing.Point(502, 73);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Size = new System.Drawing.Size(152, 37);
            this.dtNgayMuon.TabIndex = 7;
            this.dtNgayMuon.Value = new System.DateTime(2026, 9, 12, 0, 0, 0, 0);
            // 
            // lblHenTra
            // 
            this.lblHenTra.AutoSize = true;
            this.lblHenTra.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHenTra.Location = new System.Drawing.Point(668, 76);
            this.lblHenTra.Name = "lblHenTra";
            this.lblHenTra.Size = new System.Drawing.Size(94, 31);
            this.lblHenTra.TabIndex = 8;
            this.lblHenTra.Text = "Hẹn trả:";
            // 
            // dtHenTra
            // 
            this.dtHenTra.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtHenTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHenTra.Location = new System.Drawing.Point(768, 73);
            this.dtHenTra.Name = "dtHenTra";
            this.dtHenTra.Size = new System.Drawing.Size(151, 37);
            this.dtHenTra.TabIndex = 9;
            this.dtHenTra.Value = new System.DateTime(2026, 9, 19, 0, 0, 0, 0);
            // 
            // lblSachKho
            // 
            this.lblSachKho.AutoSize = true;
            this.lblSachKho.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSachKho.Location = new System.Drawing.Point(20, 110);
            this.lblSachKho.Name = "lblSachKho";
            this.lblSachKho.Size = new System.Drawing.Size(215, 31);
            this.lblSachKho.TabIndex = 10;
            this.lblSachKho.Text = "Sách còn trong kho:";
            // 
            // dgvSachKho
            // 
            this.dgvSachKho.AllowUserToAddRows = false;
            this.dgvSachKho.AllowUserToDeleteRows = false;
            this.dgvSachKho.AllowUserToResizeRows = false;
            this.dgvSachKho.BackgroundColor = System.Drawing.Color.White;
            this.dgvSachKho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSachKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSachKho.ColumnHeadersHeight = 40;
            this.dgvSachKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSachKho.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSachKho.EnableHeadersVisualStyles = false;
            this.dgvSachKho.GridColor = System.Drawing.Color.LightGray;
            this.dgvSachKho.Location = new System.Drawing.Point(26, 153);
            this.dgvSachKho.MultiSelect = false;
            this.dgvSachKho.Name = "dgvSachKho";
            this.dgvSachKho.ReadOnly = true;
            this.dgvSachKho.RowHeadersVisible = false;
            this.dgvSachKho.RowHeadersWidth = 72;
            this.dgvSachKho.RowTemplate.Height = 48;
            this.dgvSachKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSachKho.Size = new System.Drawing.Size(665, 270);
            this.dgvSachKho.TabIndex = 11;
            this.dgvSachKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSachKho_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 175;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên sách";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 175;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Năm XB";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 175;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Còn";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 175;
            // 
            // lblSachChon
            // 
            this.lblSachChon.AutoSize = true;
            this.lblSachChon.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSachChon.Location = new System.Drawing.Point(817, 110);
            this.lblSachChon.Name = "lblSachChon";
            this.lblSachChon.Size = new System.Drawing.Size(252, 31);
            this.lblSachChon.TabIndex = 12;
            this.lblSachChon.Text = "Sách đã chọn (tối đa 3):";
            // 
            // dgvSachChon
            // 
            this.dgvSachChon.AllowUserToAddRows = false;
            this.dgvSachChon.AllowUserToDeleteRows = false;
            this.dgvSachChon.AllowUserToResizeRows = false;
            this.dgvSachChon.BackgroundColor = System.Drawing.Color.White;
            this.dgvSachChon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSachChon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSachChon.ColumnHeadersHeight = 40;
            this.dgvSachChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSachChon.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSachChon.EnableHeadersVisualStyles = false;
            this.dgvSachChon.GridColor = System.Drawing.Color.LightGray;
            this.dgvSachChon.Location = new System.Drawing.Point(823, 153);
            this.dgvSachChon.MultiSelect = false;
            this.dgvSachChon.Name = "dgvSachChon";
            this.dgvSachChon.ReadOnly = true;
            this.dgvSachChon.RowHeadersVisible = false;
            this.dgvSachChon.RowHeadersWidth = 72;
            this.dgvSachChon.RowTemplate.Height = 48;
            this.dgvSachChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSachChon.Size = new System.Drawing.Size(350, 200);
            this.dgvSachChon.TabIndex = 13;
            this.dgvSachChon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSachChon_CellClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Mã";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 175;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Tên sách";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 175;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnThem.Location = new System.Drawing.Point(696, 216);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 39);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm>>";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnBo
            // 
            this.btnBo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnBo.Location = new System.Drawing.Point(707, 287);
            this.btnBo.Name = "btnBo";
            this.btnBo.Size = new System.Drawing.Size(92, 38);
            this.btnBo.TabIndex = 15;
            this.btnBo.Text = "<< Bỏ";
            this.btnBo.UseVisualStyleBackColor = true;
            this.btnBo.Click += new System.EventHandler(this.btnBo_Click);
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnLapPhieu.Location = new System.Drawing.Point(885, 384);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(202, 39);
            this.btnLapPhieu.TabIndex = 16;
            this.btnLapPhieu.Text = "Lập phiếu mượn";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // tabTraSach
            // 
            this.tabTraSach.Location = new System.Drawing.Point(4, 39);
            this.tabTraSach.Name = "tabTraSach";
            this.tabTraSach.Padding = new System.Windows.Forms.Padding(3);
            this.tabTraSach.Size = new System.Drawing.Size(1204, 548);
            this.tabTraSach.TabIndex = 1;
            this.tabTraSach.Text = "Trả sách";
            this.tabTraSach.UseVisualStyleBackColor = true;
            // 
            // FrmMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1241, 660);
            this.Controls.Add(this.tabMuonTra);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMuonTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mượn - Trả sách";
            this.tabMuonTra.ResumeLayout(false);
            this.tabMuonSach.ResumeLayout(false);
            this.tabMuonSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachChon)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}