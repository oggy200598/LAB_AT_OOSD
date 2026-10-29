
namespace QuanLyNhanSu.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel panelChinh;
        private System.Windows.Forms.TableLayoutPanel tableChucNang;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnTuyenDung;
        private System.Windows.Forms.Button btnHopDong;
        private System.Windows.Forms.Button btnLuongChucVu;
        private System.Windows.Forms.Button btnKeHoachChamCong;
        private System.Windows.Forms.Button btnPhuTroi;
        private System.Windows.Forms.Button btnKhenThuongKyLuat;
        private System.Windows.Forms.Button btnBangLuong;
        private System.Windows.Forms.Button btnThoat;

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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.panelChinh = new System.Windows.Forms.Panel();
            this.tableChucNang = new System.Windows.Forms.TableLayoutPanel();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnTuyenDung = new System.Windows.Forms.Button();
            this.btnHopDong = new System.Windows.Forms.Button();
            this.btnLuongChucVu = new System.Windows.Forms.Button();
            this.btnKeHoachChamCong = new System.Windows.Forms.Button();
            this.btnPhuTroi = new System.Windows.Forms.Button();
            this.btnKhenThuongKyLuat = new System.Windows.Forms.Button();
            this.btnBangLuong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();

            this.panelChinh.SuspendLayout();
            this.tableChucNang.SuspendLayout();
            this.SuspendLayout();

            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font(
                "Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(35, 60, 90);
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(900, 100);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ NHÂN SỰ";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.panelChinh.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.panelChinh.Controls.Add(this.tableChucNang);
            this.panelChinh.Location = new System.Drawing.Point(75, 115);
            this.panelChinh.Name = "panelChinh";
            this.panelChinh.Size = new System.Drawing.Size(750, 405);
            this.panelChinh.TabIndex = 1;

            this.tableChucNang.ColumnCount = 2;
            this.tableChucNang.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent, 50F));
            this.tableChucNang.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent, 50F));

            this.tableChucNang.RowCount = 4;
            this.tableChucNang.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Percent, 25F));
            this.tableChucNang.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Percent, 25F));
            this.tableChucNang.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Percent, 25F));
            this.tableChucNang.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Percent, 25F));

            this.tableChucNang.Controls.Add(this.btnDanhMuc, 0, 0);
            this.tableChucNang.Controls.Add(this.btnTuyenDung, 1, 0);
            this.tableChucNang.Controls.Add(this.btnHopDong, 0, 1);
            this.tableChucNang.Controls.Add(this.btnLuongChucVu, 1, 1);
            this.tableChucNang.Controls.Add(this.btnKeHoachChamCong, 0, 2);
            this.tableChucNang.Controls.Add(this.btnPhuTroi, 1, 2);
            this.tableChucNang.Controls.Add(this.btnKhenThuongKyLuat, 0, 3);
            this.tableChucNang.Controls.Add(this.btnBangLuong, 1, 3);

            this.tableChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableChucNang.Location = new System.Drawing.Point(0, 0);
            this.tableChucNang.Name = "tableChucNang";
            this.tableChucNang.Padding = new System.Windows.Forms.Padding(5);
            this.tableChucNang.Size = new System.Drawing.Size(750, 405);
            this.tableChucNang.TabIndex = 0;

            this.btnDanhMuc.BackColor = System.Drawing.Color.White;
            this.btnDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.FlatAppearance.BorderColor =
                System.Drawing.Color.LightSteelBlue;
            this.btnDanhMuc.Font = new System.Drawing.Font(
                "Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDanhMuc.ForeColor = System.Drawing.Color.FromArgb(40, 60, 80);
            this.btnDanhMuc.Margin = new System.Windows.Forms.Padding(10);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.TabIndex = 0;
            this.btnDanhMuc.Text = "Danh mục";
            this.btnDanhMuc.UseVisualStyleBackColor = false;
            this.btnDanhMuc.Click +=
                new System.EventHandler(this.btnDanhMuc_Click);

            this.btnTuyenDung.BackColor = System.Drawing.Color.White;
            this.btnTuyenDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTuyenDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuyenDung.FlatAppearance.BorderColor =
                System.Drawing.Color.LightSteelBlue;
            this.btnTuyenDung.Font = new System.Drawing.Font(
                "Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTuyenDung.ForeColor = System.Drawing.Color.FromArgb(40, 60, 80);
            this.btnTuyenDung.Margin = new System.Windows.Forms.Padding(10);
            this.btnTuyenDung.Name = "btnTuyenDung";
            this.btnTuyenDung.TabIndex = 1;
            this.btnTuyenDung.Text = "Tuyển dụng - thử việc";
            this.btnTuyenDung.UseVisualStyleBackColor = false;
            this.btnTuyenDung.Click +=
                new System.EventHandler(this.btnTuyenDung_Click);

            this.btnHopDong.BackColor = System.Drawing.Color.White;
            this.btnHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHopDong.FlatAppearance.BorderColor =
                System.Drawing.Color.LightSteelBlue;
            this.btnHopDong.Font = new System.Drawing.Font(
                "Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnHopDong.ForeColor = System.Drawing.Color.FromArgb(40, 60, 80);
            this.btnHopDong.Margin = new System.Windows.Forms.Padding(10);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.TabIndex = 2;
            this.btnHopDong.Text = "Hợp đồng - bảo hiểm";
            this.btnHopDong.UseVisualStyleBackColor = false;
            this.btnHopDong.Click +=
                new System.EventHandler(this.btnHopDong_Click);

            this.btnLuongChucVu.BackColor = System.Drawing.Color.White;
            this.btnLuongChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuongChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuongChucVu.FlatAppearance.BorderColor =
                System.Drawing.Color.LightSteelBlue;
            this.btnLuongChucVu.Font = new System.Drawing.Font(
                "Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuongChucVu.ForeColor = System.Drawing.Color.FromArgb(40, 60, 80);
            this.btnLuongChucVu.Margin = new System.Windows.Forms.Padding(10);
            this.btnLuongChucVu.Name = "btnLuongChucVu";
            this.btnLuongChucVu.TabIndex = 3;
            this.btnLuongChucVu.Text = "Quyết định lương - chức vụ";
            this.btnLuongChucVu.UseVisualStyleBackColor = false;
            this.btnLuongChucVu.Click +=
                new System.EventHandler(this.btnLuongChucVu_Click);

            this.btnKeHoachChamCong.BackColor = System.Drawing.Color.White;
            this.btnKeHoachChamCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKeHoachChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeHoachChamCong.FlatAppearance.BorderColor =
                System.Drawing.Color.LightSteelBlue;
            this.btnKeHoachChamCong.Font = new System.Drawing.Font(
                "Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnKeHoachChamCong.ForeColor = System.Drawing.Color.FromArgb(40, 60, 80);
            this.btnKeHoachChamCong.Margin = new System.Windows.Forms.Padding(10);
            this.btnKeHoachChamCong.Name = "btnKeHoachChamCong";
            this.btnKeHoachChamCong.TabIndex = 4;
            this.btnKeHoachChamCong.Text = "Kế hoạch - chấm công";
            this.btnKeHoachChamCong.UseVisualStyleBackColor = false;
            this.btnKeHoachChamCong.Click +=
                new System.EventHandler(this.btnKeHoachChamCong_Click);

            this.btnPhuTroi.BackColor = System.Drawing.Color.White;
            this.btnPhuTroi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPhuTroi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhuTroi.FlatAppearance.BorderColor =
                System.Drawing.Color.LightSteelBlue;
            this.btnPhuTroi.Font = new System.Drawing.Font(
                "Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPhuTroi.ForeColor = System.Drawing.Color.FromArgb(40, 60, 80);
            this.btnPhuTroi.Margin = new System.Windows.Forms.Padding(10);
            this.btnPhuTroi.Name = "btnPhuTroi";
            this.btnPhuTroi.TabIndex = 5;
            this.btnPhuTroi.Text = "Phiếu phụ trội";
            this.btnPhuTroi.UseVisualStyleBackColor = false;
            this.btnPhuTroi.Click +=
                new System.EventHandler(this.btnPhuTroi_Click);

            this.btnKhenThuongKyLuat.BackColor = System.Drawing.Color.White;
            this.btnKhenThuongKyLuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKhenThuongKyLuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhenThuongKyLuat.FlatAppearance.BorderColor =
                System.Drawing.Color.LightSteelBlue;
            this.btnKhenThuongKyLuat.Font = new System.Drawing.Font(
                "Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnKhenThuongKyLuat.ForeColor = System.Drawing.Color.FromArgb(40, 60, 80);
            this.btnKhenThuongKyLuat.Margin = new System.Windows.Forms.Padding(10);
            this.btnKhenThuongKyLuat.Name = "btnKhenThuongKyLuat";
            this.btnKhenThuongKyLuat.TabIndex = 6;
            this.btnKhenThuongKyLuat.Text = "Khen thưởng - kỷ luật";
            this.btnKhenThuongKyLuat.UseVisualStyleBackColor = false;
            this.btnKhenThuongKyLuat.Click +=
                new System.EventHandler(this.btnKhenThuongKyLuat_Click);

            this.btnBangLuong.BackColor = System.Drawing.Color.White;
            this.btnBangLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBangLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBangLuong.FlatAppearance.BorderColor =
                System.Drawing.Color.LightSteelBlue;
            this.btnBangLuong.Font = new System.Drawing.Font(
                "Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBangLuong.ForeColor = System.Drawing.Color.FromArgb(40, 60, 80);
            this.btnBangLuong.Margin = new System.Windows.Forms.Padding(10);
            this.btnBangLuong.Name = "btnBangLuong";
            this.btnBangLuong.TabIndex = 7;
            this.btnBangLuong.Text = "Bảng lương - thống kê";
            this.btnBangLuong.UseVisualStyleBackColor = false;
            this.btnBangLuong.Click +=
                new System.EventHandler(this.btnBangLuong_Click);

            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThoat.BackColor = System.Drawing.Color.Firebrick;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Font = new System.Drawing.Font(
                "Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(360, 545);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(180, 45);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click +=
                new System.EventHandler(this.btnThoat_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panelChinh);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ NHÂN SỰ";
            this.Load += new System.EventHandler(this.FrmMain_Load);

            this.tableChucNang.ResumeLayout(false);
            this.panelChinh.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
