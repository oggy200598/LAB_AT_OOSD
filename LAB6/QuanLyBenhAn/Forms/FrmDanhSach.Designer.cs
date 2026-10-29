
namespace QuanLyBenhAn_GiaHuy.Forms
{
    partial class FrmDanhSach
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridView grid;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.top = new System.Windows.Forms.Panel();
            this.heading = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();

            this.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.grid)).BeginInit();

            // Panel trên
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Height = 130;

            // Tiêu đề
            this.heading.SetBounds(24, 12, 700, 34);
            this.heading.Font = new System.Drawing.Font(
                "Segoe UI", 12F
            );

            // Ô tìm kiếm
            this.txtSearch.SetBounds(24, 71, 230, 29);
            this.txtSearch.Font = new System.Drawing.Font(
                "Segoe UI", 10F
            );

            // Nút chức năng
            this.btnAdd.Text = "Thêm";
            this.btnEdit.Text = "Sửa";
            this.btnDelete.Text = "Xóa";
            this.btnReload.Text = "Làm mới";

            System.Windows.Forms.Button[] btns =
            {
                this.btnAdd,
                this.btnEdit,
                this.btnDelete,
                this.btnReload
            };

            for (int i = 0; i < btns.Length; i++)
            {
                btns[i].SetBounds(
                    270 + 110 * i,
                    68,
                    98,
                    36
                );
            }

            this.top.Controls.AddRange(
                new System.Windows.Forms.Control[]
                {
                    this.heading,
                    this.txtSearch,
                    this.btnAdd,
                    this.btnEdit,
                    this.btnDelete,
                    this.btnReload
                }
            );

            // Bảng dữ liệu
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;

            this.grid.ReadOnly = true;
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.MultiSelect = false;

            this.grid.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.grid.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Form
            this.Controls.Add(this.grid);
            this.Controls.Add(this.top);

            this.Text = "Danh sách";
            this.ClientSize = new System.Drawing.Size(930, 600);

            ((System.ComponentModel.ISupportInitialize)
                (this.grid)).EndInit();

            this.ResumeLayout(false);
        }
    }
}
