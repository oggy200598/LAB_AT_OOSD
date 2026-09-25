using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    partial class FrmDichVu
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblLuot, lblPhong, lblDV, lblNgay, lblNV, lblSL;
        private ComboBox cboLuot, cboDV, cboNV;
        private TextBox txtPhong;
        private DateTimePicker dtNgay;
        private NumericUpDown numSL;
        private Button btnGhi;
        private DataGridView dgvLichSu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblLuot = new Label();
            this.cboLuot = new ComboBox();
            this.lblPhong = new Label();
            this.txtPhong = new TextBox();
            this.lblDV = new Label();
            this.cboDV = new ComboBox();
            this.lblNgay = new Label();
            this.dtNgay = new DateTimePicker();
            this.lblSL = new Label();
            this.numSL = new NumericUpDown();
            this.lblNV = new Label();
            this.cboNV = new ComboBox();
            this.btnGhi = new Button();
            this.dgvLichSu = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.SuspendLayout();

            // lblLuot & cboLuot
            this.lblLuot.AutoSize = true;
            this.lblLuot.Location = new Point(20, 20);
            this.lblLuot.Text = "Phiếu lưu trú:";

            this.cboLuot.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboLuot.Location = new Point(110, 17);
            this.cboLuot.Size = new Size(130, 23);
            this.cboLuot.SelectedIndexChanged += new System.EventHandler(this.cboLuot_SelectedIndexChanged);

            // lblPhong & txtPhong
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new Point(260, 20);
            this.lblPhong.Text = "Phòng:";

            this.txtPhong.Location = new Point(310, 17);
            this.txtPhong.ReadOnly = true;
            this.txtPhong.Size = new Size(100, 23);

            // lblDV & cboDV
            this.lblDV.AutoSize = true;
            this.lblDV.Location = new Point(430, 20);
            this.lblDV.Text = "Dịch vụ:";

            this.cboDV.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboDV.Location = new Point(490, 17);
            this.cboDV.Size = new Size(160, 23);

            // lblNgay & dtNgay
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new Point(20, 55);
            this.lblNgay.Text = "Ngày sử dụng:";

            this.dtNgay.Format = DateTimePickerFormat.Short;
            this.dtNgay.Location = new Point(110, 52);
            this.dtNgay.Size = new Size(130, 23);

            // lblSL & numSL
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new Point(260, 55);
            this.lblSL.Text = "Số lượng:";

            this.numSL.Location = new Point(310, 52);
            this.numSL.Minimum = 1;
            this.numSL.Value = 1;
            this.numSL.Size = new Size(100, 23);

            // lblNV & cboNV (Ẩn nhẹ/Dùng chọn nhân viên phục vụ)
            this.lblNV.AutoSize = true;
            this.lblNV.Location = new Point(430, 55);
            this.lblNV.Text = "Nhân viên:";
            this.lblNV.Visible = false;

            this.cboNV.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboNV.Location = new Point(490, 52);
            this.cboNV.Size = new Size(160, 23);
            this.cboNV.Visible = false;

            // btnGhi
            this.btnGhi.Location = new Point(490, 50);
            this.btnGhi.Size = new Size(160, 28);
            this.btnGhi.Text = "Ghi nhận";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);

            // dgvLichSu
            this.dgvLichSu.AllowUserToAddRows = false;
            this.dgvLichSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.Location = new Point(20, 95);
            this.dgvLichSu.Size = new Size(630, 260);

            // FrmDichVu
            this.ClientSize = new Size(670, 375);
            this.Controls.Add(this.lblLuot);
            this.Controls.Add(this.cboLuot);
            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.lblDV);
            this.Controls.Add(this.cboDV);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.dtNgay);
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.numSL);
            this.Controls.Add(this.lblNV);
            this.Controls.Add(this.cboNV);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.dgvLichSu);
            this.Font = new Font("Segoe UI", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDichVu";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Sử dụng dịch vụ";
            this.Load += new System.EventHandler(this.Frm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}