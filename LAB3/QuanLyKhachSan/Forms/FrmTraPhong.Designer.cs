using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmTraPhong
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblDat, lblSoDB, lblMucDo, lblDenBu, lblSoHD, lblSoNgay, lblHT, lblTienTT;
        private ComboBox cboDat, cboNV, cboNV2, cboHT;
        private TextBox txtMucDo, txtSoDB, txtSoHD, txtHDChon;
        private NumericUpDown numDenBu, numSoNgay, numTienTT;
        private Button btnThemDB, btnLapDB, btnLapHD, btnThanhToan, btnTraPhong;
        private DataGridView dgvPhong, dgvTN, dgvDBChon, dgvHD;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblDat = new Label();
            this.cboDat = new ComboBox();
            this.dgvPhong = new DataGridView();
            this.dgvTN = new DataGridView();
            this.dgvDBChon = new DataGridView();

            this.lblSoDB = new Label();
            this.txtSoDB = new TextBox();
            this.lblMucDo = new Label();
            this.txtMucDo = new TextBox();
            this.lblDenBu = new Label();
            this.numDenBu = new NumericUpDown();
            this.btnThemDB = new Button();
            this.btnLapDB = new Button();

            this.lblSoHD = new Label();
            this.txtSoHD = new TextBox();
            this.lblSoNgay = new Label();
            this.numSoNgay = new NumericUpDown();
            this.btnLapHD = new Button();
            this.dgvHD = new DataGridView();

            this.lblHT = new Label();
            this.cboHT = new ComboBox();
            this.lblTienTT = new Label();
            this.numTienTT = new NumericUpDown();
            this.txtHDChon = new TextBox();
            this.btnThanhToan = new Button();
            this.btnTraPhong = new Button();

            this.cboNV = new ComboBox();
            this.cboNV2 = new ComboBox();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenBu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienTT)).BeginInit();
            this.SuspendLayout();

            // Phiếu đang ở
            this.lblDat.AutoSize = true;
            this.lblDat.Location = new Point(15, 15);
            this.lblDat.Text = "Phiếu đang ở:";

            this.cboDat.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboDat.Location = new Point(105, 12);
            this.cboDat.Size = new Size(130, 23);
            this.cboDat.SelectedIndexChanged += new System.EventHandler(this.cboDat_SelectedIndexChanged);

            // Row DataGridViews (Phong, TN, DBChon)
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.Location = new Point(15, 45);
            this.dgvPhong.Size = new Size(220, 150);
            this.dgvPhong.SelectionChanged += new System.EventHandler(this.dgvPhong_SelectionChanged);

            this.dgvTN.AllowUserToAddRows = false;
            this.dgvTN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTN.Location = new Point(245, 45);
            this.dgvTN.Size = new Size(270, 150);

            this.dgvDBChon.AllowUserToAddRows = false;
            this.dgvDBChon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDBChon.Location = new Point(525, 45);
            this.dgvDBChon.Size = new Size(280, 150);

            // Hàng Phiếu đền bù
            this.lblSoDB.AutoSize = true;
            this.lblSoDB.Location = new Point(15, 208);
            this.lblSoDB.Text = "Số phiếu đền bù:";

            this.txtSoDB.Location = new Point(115, 205);
            this.txtSoDB.Size = new Size(110, 23);
            this.txtSoDB.Text = "DB001";

            this.lblMucDo.AutoSize = true;
            this.lblMucDo.Location = new Point(235, 208);
            this.lblMucDo.Text = "Mức độ:";

            this.txtMucDo.Location = new Point(290, 205);
            this.txtMucDo.Size = new Size(110, 23);
            this.txtMucDo.Text = "Hư hỏng nhẹ";

            this.lblDenBu.AutoSize = true;
            this.lblDenBu.Location = new Point(410, 208);
            this.lblDenBu.Text = "Số tiền:";

            this.numDenBu.Location = new Point(460, 205);
            this.numDenBu.Maximum = 100000000;
            this.numDenBu.Size = new Size(100, 23);
            this.numDenBu.Value = 500000;

            this.btnThemDB.Location = new Point(570, 203);
            this.btnThemDB.Size = new Size(100, 26);
            this.btnThemDB.Text = "Thêm đền bù";
            this.btnThemDB.Click += new System.EventHandler(this.btnThemDB_Click);

            this.btnLapDB.Location = new Point(680, 203);
            this.btnLapDB.Size = new Size(125, 26);
            this.btnLapDB.Text = "Lập phiếu đền bù";
            this.btnLapDB.Click += new System.EventHandler(this.btnLapDB_Click);

            // Hàng Hóa đơn
            this.lblSoHD.AutoSize = true;
            this.lblSoHD.Location = new Point(15, 248);
            this.lblSoHD.Text = "Số hóa đơn:";

            this.txtSoHD.Location = new Point(115, 245);
            this.txtSoHD.Size = new Size(110, 23);
            this.txtSoHD.Text = "HD001";

            this.lblSoNgay.AutoSize = true;
            this.lblSoNgay.Location = new Point(235, 248);
            this.lblSoNgay.Text = "Số ngày tính tiền:";

            this.numSoNgay.Location = new Point(340, 245);
            this.numSoNgay.Minimum = 1;
            this.numSoNgay.Value = 2;
            this.numSoNgay.Size = new Size(60, 23);

            this.btnLapHD.Location = new Point(420, 243);
            this.btnLapHD.Size = new Size(120, 26);
            this.btnLapHD.Text = "Lập hóa đơn";
            this.btnLapHD.Click += new System.EventHandler(this.btnLapHD_Click);

            // DataGridView Hóa Đơn
            this.dgvHD.AllowUserToAddRows = false;
            this.dgvHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHD.Location = new Point(15, 280);
            this.dgvHD.Size = new Size(790, 160);
            this.dgvHD.SelectionChanged += new System.EventHandler(this.dgvHD_SelectionChanged);

            // Hàng Thanh Toán & Trả Phòng
            this.lblHT.AutoSize = true;
            this.lblHT.Location = new Point(15, 455);
            this.lblHT.Text = "Hình thức:";

            this.cboHT.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboHT.Location = new Point(80, 452);
            this.cboHT.Size = new Size(110, 23);

            this.lblTienTT.AutoSize = true;
            this.lblTienTT.Location = new Point(200, 455);
            this.lblTienTT.Text = "Số tiền:";

            this.numTienTT.Location = new Point(250, 452);
            this.numTienTT.Maximum = 100000000;
            this.numTienTT.Size = new Size(110, 23);
            this.numTienTT.Value = 1200000;

            this.txtHDChon.Visible = false;

            this.btnThanhToan.Location = new Point(380, 450);
            this.btnThanhToan.Size = new Size(110, 28);
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);

            this.btnTraPhong.Location = new Point(500, 450);
            this.btnTraPhong.Size = new Size(150, 28);
            this.btnTraPhong.Text = "Hoàn tất trả phòng";
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);

            // Control NV Ẩn
            this.cboNV.Visible = false;
            this.cboNV2.Visible = false;

            // FrmTraPhong
            this.ClientSize = new Size(820, 495);
            this.Controls.Add(this.lblDat);
            this.Controls.Add(this.cboDat);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.dgvTN);
            this.Controls.Add(this.dgvDBChon);
            this.Controls.Add(this.lblSoDB);
            this.Controls.Add(this.txtSoDB);
            this.Controls.Add(this.lblMucDo);
            this.Controls.Add(this.txtMucDo);
            this.Controls.Add(this.lblDenBu);
            this.Controls.Add(this.numDenBu);
            this.Controls.Add(this.btnThemDB);
            this.Controls.Add(this.btnLapDB);
            this.Controls.Add(this.lblSoHD);
            this.Controls.Add(this.txtSoHD);
            this.Controls.Add(this.lblSoNgay);
            this.Controls.Add(this.numSoNgay);
            this.Controls.Add(this.btnLapHD);
            this.Controls.Add(this.dgvHD);
            this.Controls.Add(this.lblHT);
            this.Controls.Add(this.cboHT);
            this.Controls.Add(this.lblTienTT);
            this.Controls.Add(this.numTienTT);
            this.Controls.Add(this.txtHDChon);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnTraPhong);
            this.Controls.Add(this.cboNV);
            this.Controls.Add(this.cboNV2);
            this.Font = new Font("Segoe UI", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmTraPhong";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Trả phòng - Đền bù - Hóa đơn - Thanh toán";
            this.Load += new System.EventHandler(this.Frm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenBu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}