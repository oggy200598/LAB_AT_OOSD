using System;
using System.Windows.Forms;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmKhenThuongKyLuat : Form
    {
        public FrmKhenThuongKyLuat()
        {
            InitializeComponent();
        }

        private void MoForm(string tenForm)
        {
            Type loai = typeof(FrmKhenThuongKyLuat).Assembly.GetType(
                "QuanLyNhanSu.Forms." + tenForm);

            if (loai == null || !typeof(Form).IsAssignableFrom(loai))
            {
                MessageBox.Show("Chức năng chưa được tạo: " + tenForm);
                return;
            }

            try
            {
                using (Form form = (Form)Activator.CreateInstance(loai))
                {
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi mở Form",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuyetDinhKhenThuong_Click(object sender, EventArgs e)
        {
            MoForm("FrmQuyetDinhKhenThuong");
        }

        private void btnPhieuChiKhenThuong_Click(object sender, EventArgs e)
        {
            MoForm("FrmPhieuChiKhenThuong");
        }

        private void btnQuyetDinhKyLuat_Click(object sender, EventArgs e)
        {
            MoForm("FrmQuyetDinhKyLuat");
        }

        private void btnPhieuThuNopPhat_Click(object sender, EventArgs e)
        {
            MoForm("FrmPhieuThuNopPhat");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}