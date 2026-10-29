
using System;
using System.Windows.Forms;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmDanhMuc : Form
    {
        public FrmDanhMuc()
        {
            InitializeComponent();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            using (FrmNhanVien form = new FrmNhanVien())
            {
                form.ShowDialog(this);
            }
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            using (FrmPhongBan form = new FrmPhongBan())
            {
                form.ShowDialog(this);
            }
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            using (FrmChucVu form = new FrmChucVu())
            {
                form.ShowDialog(this);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
