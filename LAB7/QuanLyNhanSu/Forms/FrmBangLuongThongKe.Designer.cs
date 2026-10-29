namespace QuanLyNhanSu.Forms
{
    partial class FrmBangLuongThongKe
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnBangLuong;
        private System.Windows.Forms.Button btnChiTietBangLuong;
        private System.Windows.Forms.Button btnThongKeBaoCao;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnBangLuong = new System.Windows.Forms.Button();
            this.btnChiTietBangLuong = new System.Windows.Forms.Button();
            this.btnThongKeBaoCao = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(850, 75);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ BẢNG LƯƠNG - THỐNG KÊ";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.btnBangLuong);
            this.grpChucNang.Controls.Add(this.btnChiTietBangLuong);
            this.grpChucNang.Controls.Add(this.btnThongKeBaoCao);
            this.grpChucNang.Location = new System.Drawing.Point(100, 130);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(650, 285);
            this.grpChucNang.TabIndex = 2;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Danh sách chức năng";
            // 
            // btnBangLuong
            // 
            this.btnBangLuong.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBangLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBangLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBangLuong.ForeColor = System.Drawing.Color.White;
            this.btnBangLuong.Location = new System.Drawing.Point(75, 42);
            this.btnBangLuong.Name = "btnBangLuong";
            this.btnBangLuong.Size = new System.Drawing.Size(500, 60);
            this.btnBangLuong.TabIndex = 0;
            this.btnBangLuong.Text = "QUẢN LÝ BẢNG LƯƠNG";
            this.btnBangLuong.UseVisualStyleBackColor = false;
            this.btnBangLuong.Click += new System.EventHandler(this.btnBangLuong_Click);
            // 
            // btnChiTietBangLuong
            // 
            this.btnChiTietBangLuong.BackColor = System.Drawing.Color.SteelBlue;
            this.btnChiTietBangLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTietBangLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnChiTietBangLuong.ForeColor = System.Drawing.Color.White;
            this.btnChiTietBangLuong.Location = new System.Drawing.Point(75, 118);
            this.btnChiTietBangLuong.Name = "btnChiTietBangLuong";
            this.btnChiTietBangLuong.Size = new System.Drawing.Size(500, 60);
            this.btnChiTietBangLuong.TabIndex = 1;
            this.btnChiTietBangLuong.Text = "QUẢN LÝ CHI TIẾT BẢNG LƯƠNG";
            this.btnChiTietBangLuong.UseVisualStyleBackColor = false;
            this.btnChiTietBangLuong.Click += new System.EventHandler(this.btnChiTietBangLuong_Click);
            // 
            // btnThongKeBaoCao
            // 
            this.btnThongKeBaoCao.BackColor = System.Drawing.Color.SeaGreen;
            this.btnThongKeBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeBaoCao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThongKeBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnThongKeBaoCao.Location = new System.Drawing.Point(75, 194);
            this.btnThongKeBaoCao.Name = "btnThongKeBaoCao";
            this.btnThongKeBaoCao.Size = new System.Drawing.Size(500, 60);
            this.btnThongKeBaoCao.TabIndex = 2;
            this.btnThongKeBaoCao.Text = "THỐNG KÊ - BÁO CÁO";
            this.btnThongKeBaoCao.UseVisualStyleBackColor = false;
            this.btnThongKeBaoCao.Click += new System.EventHandler(this.btnThongKeBaoCao_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Firebrick;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(335, 435);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(180, 45);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "QUAY LẠI";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmBangLuongThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(850, 510);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.btnThoat);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmBangLuongThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý bảng lương - Thống kê";
            this.grpChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}