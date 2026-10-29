namespace QuanLyNhanSu.Forms
{
    partial class FrmHopDongBaoHiem
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnHopDongLaoDong;
        private System.Windows.Forms.Button btnHoSoBaoHiem;
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
            this.btnHopDongLaoDong = new System.Windows.Forms.Button();
            this.btnHoSoBaoHiem = new System.Windows.Forms.Button();
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
            this.lblTieuDe.Text = "QUẢN LÝ HỢP ĐỒNG - BẢO HIỂM";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.btnHopDongLaoDong);
            this.grpChucNang.Controls.Add(this.btnHoSoBaoHiem);
            this.grpChucNang.Location = new System.Drawing.Point(100, 135);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(650, 225);
            this.grpChucNang.TabIndex = 2;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Danh sách chức năng";
            // 
            // btnHopDongLaoDong
            // 
            this.btnHopDongLaoDong.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHopDongLaoDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHopDongLaoDong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnHopDongLaoDong.ForeColor = System.Drawing.Color.White;
            this.btnHopDongLaoDong.Location = new System.Drawing.Point(75, 45);
            this.btnHopDongLaoDong.Name = "btnHopDongLaoDong";
            this.btnHopDongLaoDong.Size = new System.Drawing.Size(500, 65);
            this.btnHopDongLaoDong.TabIndex = 0;
            this.btnHopDongLaoDong.Text = "QUẢN LÝ HỢP ĐỒNG LAO ĐỘNG";
            this.btnHopDongLaoDong.UseVisualStyleBackColor = false;
            this.btnHopDongLaoDong.Click += new System.EventHandler(this.btnHopDongLaoDong_Click);
            // 
            // btnHoSoBaoHiem
            // 
            this.btnHoSoBaoHiem.BackColor = System.Drawing.Color.SeaGreen;
            this.btnHoSoBaoHiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoSoBaoHiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnHoSoBaoHiem.ForeColor = System.Drawing.Color.White;
            this.btnHoSoBaoHiem.Location = new System.Drawing.Point(75, 130);
            this.btnHoSoBaoHiem.Name = "btnHoSoBaoHiem";
            this.btnHoSoBaoHiem.Size = new System.Drawing.Size(500, 65);
            this.btnHoSoBaoHiem.TabIndex = 1;
            this.btnHoSoBaoHiem.Text = "QUẢN LÝ HỒ SƠ BẢO HIỂM";
            this.btnHoSoBaoHiem.UseVisualStyleBackColor = false;
            this.btnHoSoBaoHiem.Click += new System.EventHandler(this.btnHoSoBaoHiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Firebrick;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(335, 385);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(180, 45);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "QUAY LẠI";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmHopDongBaoHiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(850, 460);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.btnThoat);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmHopDongBaoHiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý hợp đồng - Bảo hiểm";
            this.grpChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}