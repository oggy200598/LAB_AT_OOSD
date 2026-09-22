namespace QuanLyThuVien.Forms
{
    partial class FrmThongKe
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Label lblTieuDe;

        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label lblDenNgay;

        private System.Windows.Forms.DateTimePicker dtTuNgay;
        private System.Windows.Forms.DateTimePicker dtDenNgay;

        private System.Windows.Forms.Button btnThongKe;

        private System.Windows.Forms.Label lblLuotSachMuon;
        private System.Windows.Forms.Label lblSachQuaHan;
        private System.Windows.Forms.Label lblSachMat;
        private System.Windows.Forms.Label lblSachHuHong;
        private System.Windows.Forms.Label lblTongPhiPhat;

        private System.Windows.Forms.Label lblChiTiet;

        private System.Windows.Forms.DataGridView dgvPhieuPhat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lblLuotSachMuon = new System.Windows.Forms.Label();
            this.lblSachQuaHan = new System.Windows.Forms.Label();
            this.lblSachMat = new System.Windows.Forms.Label();
            this.lblSachHuHong = new System.Windows.Forms.Label();
            this.lblTongPhiPhat = new System.Windows.Forms.Label();
            this.lblChiTiet = new System.Windows.Forms.Label();
            this.dgvPhieuPhat = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuPhat)).BeginInit();
            this.SuspendLayout();
            
            this.pnlTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.pnlTieuDe.Controls.Add(this.lblTieuDe);
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(1075, 42);
            this.pnlTieuDe.TabIndex = 0;
           
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTieuDe.Location = new System.Drawing.Point(14, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(223, 36);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Thống kê thư viện";
            
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTuNgay.Location = new System.Drawing.Point(38, 72);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(105, 32);
            this.lblTuNgay.TabIndex = 1;
            this.lblTuNgay.Text = "Từ ngày:";
            
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDenNgay.Location = new System.Drawing.Point(325, 72);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(122, 32);
            this.lblDenNgay.TabIndex = 3;
            this.lblDenNgay.Text = "Đến ngày:";
            
            this.dtTuNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTuNgay.Location = new System.Drawing.Point(149, 72);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(162, 39);
            this.dtTuNgay.TabIndex = 2;
            this.dtTuNgay.Value = new System.DateTime(2026, 9, 1, 0, 0, 0, 0);
            
            this.dtDenNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDenNgay.Location = new System.Drawing.Point(453, 72);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(150, 39);
            this.dtDenNgay.TabIndex = 4;
            this.dtDenNgay.Value = new System.DateTime(2026, 9, 30, 0, 0, 0, 0);
            
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThongKe.Location = new System.Drawing.Point(644, 72);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(125, 37);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            
            this.lblLuotSachMuon.AutoSize = true;
            this.lblLuotSachMuon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblLuotSachMuon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.lblLuotSachMuon.Location = new System.Drawing.Point(55, 135);
            this.lblLuotSachMuon.Name = "lblLuotSachMuon";
            this.lblLuotSachMuon.Size = new System.Drawing.Size(241, 36);
            this.lblLuotSachMuon.TabIndex = 6;
            this.lblLuotSachMuon.Text = "Lượt sách mượn: 12";
            
            this.lblSachQuaHan.AutoSize = true;
            this.lblSachQuaHan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSachQuaHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.lblSachQuaHan.Location = new System.Drawing.Point(475, 135);
            this.lblSachQuaHan.Name = "lblSachQuaHan";
            this.lblSachQuaHan.Size = new System.Drawing.Size(196, 36);
            this.lblSachQuaHan.TabIndex = 7;
            this.lblSachQuaHan.Text = "Sách quá hạn: 2";
            
            this.lblSachMat.AutoSize = true;
            this.lblSachMat.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSachMat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.lblSachMat.Location = new System.Drawing.Point(55, 180);
            this.lblSachMat.Name = "lblSachMat";
            this.lblSachMat.Size = new System.Drawing.Size(147, 36);
            this.lblSachMat.TabIndex = 8;
            this.lblSachMat.Text = "Sách mất: 1";
           
            this.lblSachHuHong.AutoSize = true;
            this.lblSachHuHong.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSachHuHong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.lblSachHuHong.Location = new System.Drawing.Point(475, 180);
            this.lblSachHuHong.Name = "lblSachHuHong";
            this.lblSachHuHong.Size = new System.Drawing.Size(200, 36);
            this.lblSachHuHong.TabIndex = 9;
            this.lblSachHuHong.Text = "Sách hư hỏng: 1";
            
            this.lblTongPhiPhat.AutoSize = true;
            this.lblTongPhiPhat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTongPhiPhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.lblTongPhiPhat.Location = new System.Drawing.Point(55, 225);
            this.lblTongPhiPhat.Name = "lblTongPhiPhat";
            this.lblTongPhiPhat.Size = new System.Drawing.Size(408, 45);
            this.lblTongPhiPhat.TabIndex = 10;
            this.lblTongPhiPhat.Text = "Tổng phí phạt: 150.000 đ";
           
            this.lblChiTiet.AutoSize = true;
            this.lblChiTiet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblChiTiet.Location = new System.Drawing.Point(45, 285);
            this.lblChiTiet.Name = "lblChiTiet";
            this.lblChiTiet.Size = new System.Drawing.Size(231, 32);
            this.lblChiTiet.TabIndex = 11;
            this.lblChiTiet.Text = "Chi tiết phiếu phạt:";
            
            this.dgvPhieuPhat.AllowUserToAddRows = false;
            this.dgvPhieuPhat.AllowUserToDeleteRows = false;
            this.dgvPhieuPhat.AllowUserToResizeRows = false;
            this.dgvPhieuPhat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuPhat.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuPhat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuPhat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhieuPhat.ColumnHeadersHeight = 35;
            this.dgvPhieuPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPhieuPhat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhieuPhat.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhieuPhat.EnableHeadersVisualStyles = false;
            this.dgvPhieuPhat.GridColor = System.Drawing.Color.LightGray;
            this.dgvPhieuPhat.Location = new System.Drawing.Point(51, 330);
            this.dgvPhieuPhat.MultiSelect = false;
            this.dgvPhieuPhat.Name = "dgvPhieuPhat";
            this.dgvPhieuPhat.ReadOnly = true;
            this.dgvPhieuPhat.RowHeadersVisible = false;
            this.dgvPhieuPhat.RowHeadersWidth = 72;
            this.dgvPhieuPhat.RowTemplate.Height = 55;
            this.dgvPhieuPhat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuPhat.Size = new System.Drawing.Size(985, 285);
            this.dgvPhieuPhat.TabIndex = 12;
            
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã phiếu";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            
            this.dataGridViewTextBoxColumn2.HeaderText = "Ngày";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            
            this.dataGridViewTextBoxColumn3.HeaderText = "Độc giả";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            
            this.dataGridViewTextBoxColumn4.HeaderText = "Mã sách";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            
            this.dataGridViewTextBoxColumn5.HeaderText = "Lý do";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            
            this.dataGridViewTextBoxColumn6.HeaderText = "Phí phạt";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1075, 670);
            this.Controls.Add(this.pnlTieuDe);
            this.Controls.Add(this.lblTuNgay);
            this.Controls.Add(this.dtTuNgay);
            this.Controls.Add(this.lblDenNgay);
            this.Controls.Add(this.dtDenNgay);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.lblLuotSachMuon);
            this.Controls.Add(this.lblSachQuaHan);
            this.Controls.Add(this.lblSachMat);
            this.Controls.Add(this.lblSachHuHong);
            this.Controls.Add(this.lblTongPhiPhat);
            this.Controls.Add(this.lblChiTiet);
            this.Controls.Add(this.dgvPhieuPhat);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống kê thư viện";
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuPhat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}