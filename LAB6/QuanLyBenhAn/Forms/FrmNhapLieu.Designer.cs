
namespace QuanLyBenhAn_GiaHuy.Forms
{
    partial class FrmNhapLieu
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pane;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.TableLayoutPanel fieldsPanel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label heading;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pane = new System.Windows.Forms.Panel();
            this.footer = new System.Windows.Forms.Panel();
            this.top = new System.Windows.Forms.Panel();
            this.fieldsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.heading = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Form
            this.ClientSize = new System.Drawing.Size(650, 650);
            this.MinimumSize = new System.Drawing.Size(560, 470);
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;

            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Text = "Nhập liệu";

            // Panel tiêu đề
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Height = 72;

            // Tiêu đề
            this.heading.SetBounds(20, 17, 590, 40);
            this.heading.Font = new System.Drawing.Font(
                "Segoe UI", 12F
            );

            this.top.Controls.Add(this.heading);

            // Panel chứa nút
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Height = 74;

            // Nút lưu
            this.btnSave.Text = "Lưu dữ liệu";
            this.btnSave.SetBounds(360, 19, 130, 38);
            this.btnSave.Anchor =
                System.Windows.Forms.AnchorStyles.Right |
                System.Windows.Forms.AnchorStyles.Top;

            // Nút hủy
            this.btnCancel.Text = "Hủy";
            this.btnCancel.SetBounds(502, 19, 110, 38);
            this.btnCancel.Anchor =
                System.Windows.Forms.AnchorStyles.Right |
                System.Windows.Forms.AnchorStyles.Top;

            this.btnCancel.DialogResult =
                System.Windows.Forms.DialogResult.Cancel;

            this.footer.Controls.Add(this.btnSave);
            this.footer.Controls.Add(this.btnCancel);

            // Panel nhập liệu
            this.pane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pane.AutoScroll = true;
            this.pane.Padding =
                new System.Windows.Forms.Padding(24, 20, 24, 20);

            // Bảng chứa các trường nhập liệu
            this.fieldsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.fieldsPanel.AutoSize = true;
            this.fieldsPanel.AutoSizeMode =
                System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            this.fieldsPanel.ColumnCount = 2;

            this.fieldsPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Absolute, 180
                )
            );

            this.fieldsPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent, 100
                )
            );

            this.fieldsPanel.Padding =
                new System.Windows.Forms.Padding(2);

            this.pane.Controls.Add(this.fieldsPanel);

            // Thêm các thành phần vào Form
            this.Controls.Add(this.pane);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.top);

            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;

            this.ResumeLayout(false);
        }
    }
}
