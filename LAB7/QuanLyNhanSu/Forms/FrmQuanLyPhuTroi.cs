using System;
using System.Windows.Forms;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmQuanLyPhuTroi : Form
    {
        public FrmQuanLyPhuTroi()
        {
            InitializeComponent();
        }

        private void MoForm(string tenForm)
        {
            Type loai = typeof(FrmQuanLyPhuTroi).Assembly.GetType(
                "QuanLyNhanSu.Forms." + tenForm);

            if (loai == null || !typeof(Form).IsAssignableFrom(loai))
            {
                MessageBox.Show("Không tìm thấy Form: " + tenForm);
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

        private void btnPhieuPhuTroi_Click(object sender, EventArgs e)
        {
            MoForm("FrmPhieuPhuTroi");
        }

        private void btnChiTietPhuTroi_Click(object sender, EventArgs e)
        {
            MoForm("FrmChiTietPhuTroi");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}