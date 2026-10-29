
namespace QuanLyNhanSu.Forms
{
    partial class FrmTuyenDung
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Button btnQuyetDinhTuyenDung;
        private System.Windows.Forms.Button btnThoat;

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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.btnQuyetDinhTuyenDung = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblTieuDe.Location = new System.Drawing.Point(30, 35);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(740, 65);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "TUYỂN DỤNG - THỬ VIỆC";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMoTa
            // 
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMoTa.ForeColor = System.Drawing.Color.DimGray;
            this.lblMoTa.Location = new System.Drawing.Point(80, 115);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(640, 50);
            this.lblMoTa.TabIndex = 1;
            this.lblMoTa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuyetDinhTuyenDung
            // 
            this.btnQuyetDinhTuyenDung.BackColor = System.Drawing.Color.White;
            this.btnQuyetDinhTuyenDung.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnQuyetDinhTuyenDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuyetDinhTuyenDung.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnQuyetDinhTuyenDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnQuyetDinhTuyenDung.Location = new System.Drawing.Point(148, 168);
            this.btnQuyetDinhTuyenDung.Name = "btnQuyetDinhTuyenDung";
            this.btnQuyetDinhTuyenDung.Size = new System.Drawing.Size(517, 75);
            this.btnQuyetDinhTuyenDung.TabIndex = 2;
            this.btnQuyetDinhTuyenDung.Text = "Quản lý quyết định tuyển dụng";
            this.btnQuyetDinhTuyenDung.UseVisualStyleBackColor = false;
            this.btnQuyetDinhTuyenDung.Click += new System.EventHandler(this.btnQuyetDinhTuyenDung_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Firebrick;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(310, 320);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(180, 45);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Quay lại";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmTuyenDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.btnQuyetDinhTuyenDung);
            this.Controls.Add(this.btnThoat);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmTuyenDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tuyển dụng - Thử việc";
            this.ResumeLayout(false);

        }
    }
}
