
using System;
using System.Windows.Forms;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmLuongChucVu : Form
    {
        public FrmLuongChucVu()
        {
            InitializeComponent();
        }

        private void MoForm(string tenForm)
        {
            Type loai = typeof(FrmLuongChucVu).Assembly.GetType(
                "QuanLyNhanSu.Forms." + tenForm);

            if (loai == null || !typeof(Form).IsAssignableFrom(loai))
            {
                MessageBox.Show(
                    "Chức năng " + tenForm + " chưa được hoàn thiện.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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

        private void btnQuyetDinhLuong_Click(object sender, EventArgs e)
        {
            MoForm("FrmQuyetDinhLuong");
        }

        private void btnQuyetDinhChucVu_Click(object sender, EventArgs e)
        {
            MoForm("FrmQuyetDinhChucVu");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
