using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    partial class FrmThongKe
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTu, lblDen, lblDichVuTitle;
        private Label lblPhieuDat, lblDangO, lblHoaDon, lblDoanhThu, lblDenBu;
        private DateTimePicker dtTu, dtDen;
        private Button btnTK;
        private DataGridView dgvDV;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTu = new Label();
            this.dtTu = new DateTimePicker();
            this.lblDen = new Label();
            this.dtDen = new DateTimePicker();
            this.btnTK = new Button();

            this.lblPhieuDat = new Label();
            this.lblDangO = new Label();
            this.lblHoaDon = new Label();
            this.lblDoanhThu = new Label();
            this.lblDenBu = new Label();

            this.lblDichVuTitle = new Label();
            this.dgvDV = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.SuspendLayout();

            // 
            // Vùng Tìm kiếm theo Ngày
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Font = new Font("Segoe UI", 9.5F);
            this.lblTu.Location = new Point(30, 25);
            this.lblTu.Text = "Từ ngày:";

            this.dtTu.CustomFormat = "dd/MM/yyyy";
            this.dtTu.Format = DateTimePickerFormat.Custom;
            this.dtTu.Font = new Font("Segoe UI", 9.5F);
            this.dtTu.Location = new Point(95, 22);
            this.dtTu.Size = new Size(120, 25);

            this.lblDen.AutoSize = true;
            this.lblDen.Font = new Font("Segoe UI", 9.5F);
            this.lblDen.Location = new Point(245, 25);
            this.lblDen.Text = "Đến ngày:";

            this.dtDen.CustomFormat = "dd/MM/yyyy";
            this.dtDen.Format = DateTimePickerFormat.Custom;
            this.dtDen.Font = new Font("Segoe UI", 9.5F);
            this.dtDen.Location = new Point(320, 22);
            this.dtDen.Size = new Size(120, 25);

            this.btnTK.Font = new Font("Segoe UI", 9.5F);
            this.btnTK.Location = new Point(470, 20);
            this.btnTK.Size = new Size(100, 30);
            this.btnTK.Text = "Thống kê";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);

            // 
            // Vùng Nhãn Thống kê Tổng hợp (Labels)
            // 
            this.lblPhieuDat.AutoSize = true;
            this.lblPhieuDat.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblPhieuDat.ForeColor = Color.FromArgb(20, 50, 110);
            this.lblPhieuDat.Location = new Point(30, 75);
            this.lblPhieuDat.Text = "Phiếu đặt: 0";

            this.lblDangO.AutoSize = true;
            this.lblDangO.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblDangO.ForeColor = Color.FromArgb(20, 50, 110);
            this.lblDangO.Location = new Point(330, 75);
            this.lblDangO.Text = "Đang ở: 0";

            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblHoaDon.ForeColor = Color.FromArgb(20, 50, 110);
            this.lblHoaDon.Location = new Point(30, 120);
            this.lblHoaDon.Text = "Hóa đơn: 0";

            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblDoanhThu.ForeColor = Color.FromArgb(20, 50, 110);
            this.lblDoanhThu.Location = new Point(330, 120);
            this.lblDoanhThu.Text = "Doanh thu HĐ: 0 đ";

            this.lblDenBu.AutoSize = true;
            this.lblDenBu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblDenBu.ForeColor = Color.FromArgb(20, 50, 110);
            this.lblDenBu.Location = new Point(30, 165);
            this.lblDenBu.Text = "Tổng đền bù: 0 đ";

            // 
            // Bảng Dịch Vụ
            // 
            this.lblDichVuTitle.AutoSize = true;
            this.lblDichVuTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblDichVuTitle.Location = new Point(30, 215);
            this.lblDichVuTitle.Text = "Dịch vụ sử dụng:";

            this.dgvDV.AllowUserToAddRows = false;
            this.dgvDV.AllowUserToDeleteRows = false;
            this.dgvDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDV.BackgroundColor = Color.White;
            this.dgvDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Location = new Point(30, 240);
            this.dgvDV.ReadOnly = true;
            this.dgvDV.RowHeadersVisible = false;
            this.dgvDV.Size = new Size(620, 200);

            // 
            // FrmThongKe
            // 
            this.ClientSize = new Size(680, 465);
            this.Controls.Add(this.lblTu);
            this.Controls.Add(this.dtTu);
            this.Controls.Add(this.lblDen);
            this.Controls.Add(this.dtDen);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.lblPhieuDat);
            this.Controls.Add(this.lblDangO);
            this.Controls.Add(this.lblHoaDon);
            this.Controls.Add(this.lblDoanhThu);
            this.Controls.Add(this.lblDenBu);
            this.Controls.Add(this.lblDichVuTitle);
            this.Controls.Add(this.dgvDV);
            this.Font = new Font("Segoe UI", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmThongKe";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Thống kê khách sạn";

            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}