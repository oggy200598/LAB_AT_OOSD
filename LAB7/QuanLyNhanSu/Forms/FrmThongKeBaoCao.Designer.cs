namespace QuanLyNhanSu.Forms
{
    partial class FrmThongKeBaoCao
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblNhom;
        private System.Windows.Forms.Label lblPhanLoai;
        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.Label lblKetQua;

        private System.Windows.Forms.ComboBox cboNhom;
        private System.Windows.Forms.ComboBox cboPhanLoai;
        private System.Windows.Forms.ComboBox cboPhongBan;

        private System.Windows.Forms.NumericUpDown nudThang;
        private System.Windows.Forms.NumericUpDown nudNam;

        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXuatCSV;
        private System.Windows.Forms.Button btnThoat;

        private System.Windows.Forms.GroupBox grpBoLoc;
        private System.Windows.Forms.GroupBox grpKetQua;
        private System.Windows.Forms.DataGridView dgvThongKe;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblNhom = new System.Windows.Forms.Label();
            this.lblPhanLoai = new System.Windows.Forms.Label();
            this.lblPhongBan = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            this.lblNam = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();

            this.cboNhom = new System.Windows.Forms.ComboBox();
            this.cboPhanLoai = new System.Windows.Forms.ComboBox();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();

            this.nudThang = new System.Windows.Forms.NumericUpDown();
            this.nudNam = new System.Windows.Forms.NumericUpDown();

            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXuatCSV = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();

            this.grpBoLoc = new System.Windows.Forms.GroupBox();
            this.grpKetQua = new System.Windows.Forms.GroupBox();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();

            this.grpBoLoc.SuspendLayout();
            this.grpKetQua.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.nudThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)
                (this.nudNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)
                (this.dgvThongKe)).BeginInit();

            this.SuspendLayout();

            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font(
                "Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor =
                System.Drawing.Color.FromArgb(35, 60, 90);
            this.lblTieuDe.Location =
                new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size =
                new System.Drawing.Size(1120, 70);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "THỐNG KÊ - BÁO CÁO NHÂN SỰ";
            this.lblTieuDe.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            this.grpBoLoc.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.grpBoLoc.Location =
                new System.Drawing.Point(25, 80);
            this.grpBoLoc.Name = "grpBoLoc";
            this.grpBoLoc.Size =
                new System.Drawing.Size(1070, 205);
            this.grpBoLoc.TabIndex = 1;
            this.grpBoLoc.TabStop = false;
            this.grpBoLoc.Text = "Bộ lọc thống kê";

            this.lblNhom.AutoSize = true;
            this.lblNhom.Location =
                new System.Drawing.Point(20, 40);
            this.lblNhom.Name = "lblNhom";
            this.lblNhom.Text = "Nhóm thống kê:";

            this.cboNhom.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhom.Items.AddRange(new object[] {
                "Nhân viên",
                "Tuyển dụng",
                "Chấm công",
                "Khen thưởng - Kỷ luật",
                "Lương"
            });
            this.cboNhom.Location =
                new System.Drawing.Point(190, 36);
            this.cboNhom.Name = "cboNhom";
            this.cboNhom.Size =
                new System.Drawing.Size(320, 28);
            this.cboNhom.TabIndex = 0;
            this.cboNhom.SelectedIndexChanged +=
                new System.EventHandler(
                    this.cboNhom_SelectedIndexChanged);

            this.lblPhanLoai.AutoSize = true;
            this.lblPhanLoai.Location =
                new System.Drawing.Point(550, 40);
            this.lblPhanLoai.Name = "lblPhanLoai";
            this.lblPhanLoai.Text = "Phân loại:";

            this.cboPhanLoai.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhanLoai.Location =
                new System.Drawing.Point(705, 36);
            this.cboPhanLoai.Name = "cboPhanLoai";
            this.cboPhanLoai.Size =
                new System.Drawing.Size(340, 28);
            this.cboPhanLoai.TabIndex = 1;
            this.cboPhanLoai.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.lblPhongBan.AutoSize = true;
            this.lblPhongBan.Location =
                new System.Drawing.Point(20, 90);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Text = "Phòng ban:";

            this.cboPhongBan.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongBan.Location =
                new System.Drawing.Point(190, 86);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size =
                new System.Drawing.Size(320, 28);
            this.cboPhongBan.TabIndex = 2;

            this.lblThang.AutoSize = true;
            this.lblThang.Location =
                new System.Drawing.Point(550, 90);
            this.lblThang.Name = "lblThang";
            this.lblThang.Text = "Tháng:";

            this.nudThang.Location =
                new System.Drawing.Point(705, 86);
            this.nudThang.Minimum = 1m;
            this.nudThang.Maximum = 12m;
            this.nudThang.Value = 1m;
            this.nudThang.Name = "nudThang";
            this.nudThang.Size =
                new System.Drawing.Size(130, 27);
            this.nudThang.TabIndex = 3;

            this.lblNam.AutoSize = true;
            this.lblNam.Location =
                new System.Drawing.Point(855, 90);
            this.lblNam.Name = "lblNam";
            this.lblNam.Text = "Năm:";

            this.nudNam.Location =
                new System.Drawing.Point(910, 86);
            this.nudNam.Minimum = 2000m;
            this.nudNam.Maximum = 2100m;
            this.nudNam.Value = 2026m;
            this.nudNam.Name = "nudNam";
            this.nudNam.Size =
                new System.Drawing.Size(135, 27);
            this.nudNam.TabIndex = 4;
            this.nudNam.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;

            this.btnThongKe.BackColor =
                System.Drawing.Color.SteelBlue;
            this.btnThongKe.ForeColor =
                System.Drawing.Color.White;
            this.btnThongKe.Location =
                new System.Drawing.Point(190, 140);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size =
                new System.Drawing.Size(160, 45);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click +=
                new System.EventHandler(this.btnThongKe_Click);

            this.btnLamMoi.Location =
                new System.Drawing.Point(365, 140);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size =
                new System.Drawing.Size(160, 45);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click +=
                new System.EventHandler(this.btnLamMoi_Click);

            this.btnXuatCSV.BackColor =
                System.Drawing.Color.SeaGreen;
            this.btnXuatCSV.ForeColor =
                System.Drawing.Color.White;
            this.btnXuatCSV.Location =
                new System.Drawing.Point(540, 140);
            this.btnXuatCSV.Name = "btnXuatCSV";
            this.btnXuatCSV.Size =
                new System.Drawing.Size(160, 45);
            this.btnXuatCSV.TabIndex = 7;
            this.btnXuatCSV.Text = "Xuất báo cáo";
            this.btnXuatCSV.UseVisualStyleBackColor = false;
            this.btnXuatCSV.Click +=
                new System.EventHandler(this.btnXuatCSV_Click);

            this.btnThoat.BackColor =
                System.Drawing.Color.Firebrick;
            this.btnThoat.ForeColor =
                System.Drawing.Color.White;
            this.btnThoat.Location =
                new System.Drawing.Point(715, 140);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size =
                new System.Drawing.Size(160, 45);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click +=
                new System.EventHandler(this.btnThoat_Click);

            this.grpBoLoc.Controls.Add(this.lblNhom);
            this.grpBoLoc.Controls.Add(this.cboNhom);
            this.grpBoLoc.Controls.Add(this.lblPhanLoai);
            this.grpBoLoc.Controls.Add(this.cboPhanLoai);
            this.grpBoLoc.Controls.Add(this.lblPhongBan);
            this.grpBoLoc.Controls.Add(this.cboPhongBan);
            this.grpBoLoc.Controls.Add(this.lblThang);
            this.grpBoLoc.Controls.Add(this.nudThang);
            this.grpBoLoc.Controls.Add(this.lblNam);
            this.grpBoLoc.Controls.Add(this.nudNam);
            this.grpBoLoc.Controls.Add(this.btnThongKe);
            this.grpBoLoc.Controls.Add(this.btnLamMoi);
            this.grpBoLoc.Controls.Add(this.btnXuatCSV);
            this.grpBoLoc.Controls.Add(this.btnThoat);

            this.grpKetQua.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.grpKetQua.Location =
                new System.Drawing.Point(25, 300);
            this.grpKetQua.Name = "grpKetQua";
            this.grpKetQua.Size =
                new System.Drawing.Size(1070, 410);
            this.grpKetQua.TabIndex = 2;
            this.grpKetQua.TabStop = false;
            this.grpKetQua.Text = "Kết quả thống kê";

            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblKetQua.ForeColor =
                System.Drawing.Color.FromArgb(35, 60, 90);
            this.lblKetQua.Location =
                new System.Drawing.Point(20, 35);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Text = "Chưa có dữ liệu thống kê.";

            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AllowUserToDeleteRows = false;
            this.dgvThongKe.AllowUserToResizeRows = false;
            this.dgvThongKe.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.dgvThongKe.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.BackgroundColor =
                System.Drawing.Color.White;
            this.dgvThongKe.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location =
                new System.Drawing.Point(20, 75);
            this.dgvThongKe.MultiSelect = false;
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.RowHeadersVisible = false;
            this.dgvThongKe.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKe.Size =
                new System.Drawing.Size(1025, 310);
            this.dgvThongKe.TabIndex = 0;

            this.grpKetQua.Controls.Add(this.lblKetQua);
            this.grpKetQua.Controls.Add(this.dgvThongKe);

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1120, 735);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grpBoLoc);
            this.Controls.Add(this.grpKetQua);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(1120, 770);
            this.Name = "FrmThongKeBaoCao";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống kê - Báo cáo";
            this.Load +=
                new System.EventHandler(this.FrmThongKeBaoCao_Load);

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)
                (this.nudNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)
                (this.nudThang)).EndInit();

            this.grpKetQua.ResumeLayout(false);
            this.grpKetQua.PerformLayout();
            this.grpBoLoc.ResumeLayout(false);
            this.grpBoLoc.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}