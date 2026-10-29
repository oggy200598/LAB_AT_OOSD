
namespace QuanLyBenhAn_GiaHuy.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Panel nav;

        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label summary;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.sidebar = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.content = new System.Windows.Forms.Panel();
            this.nav = new System.Windows.Forms.Panel();

            this.logo = new System.Windows.Forms.Label();
            this.subtitle = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.summary = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Menu bên trái
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Width = 238;

            // Danh sách chức năng
            this.nav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nav.AutoScroll = true;

            this.sidebar.Controls.Add(this.nav);

            // Thanh tiêu đề
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Height = 60;

            this.title.Text = "Quản lý hồ sơ bệnh án";
            this.title.Font = new System.Drawing.Font(
                "Segoe UI", 12F
            );
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(20, 18);

            this.header.Controls.Add(this.title);

            // Khu vực nội dung
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.AutoScroll = true;

            // Form chính
            this.ClientSize = new System.Drawing.Size(1200, 760);
            this.MinimumSize = new System.Drawing.Size(960, 650);

            this.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.Name = "FrmMain";
            this.Text = "Quản lý hồ sơ bệnh án - Nguyễn Gia Huy";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Controls.Add(this.content);
            this.Controls.Add(this.header);
            this.Controls.Add(this.sidebar);

            this.ResumeLayout(false);
        }
    }
}
