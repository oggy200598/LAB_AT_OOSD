
using System;
using System.Windows.Forms;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmTuyenDung : Form
    {
        public FrmTuyenDung()
        {
            InitializeComponent();
        }

        private void btnQuyetDinhTuyenDung_Click(object sender, EventArgs e)
        {
            string tenForm = "QuanLyNhanSu.Forms.FrmQuyetDinhTuyenDung";
            Type formType = typeof(FrmTuyenDung).Assembly.GetType(tenForm);

            if (formType == null)
            {
                MessageBox.Show(
                    "Chức năng quyết định tuyển dụng chưa được hoàn thiện.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (Form form = (Form)Activator.CreateInstance(formType))
                {
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi mở Form",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
