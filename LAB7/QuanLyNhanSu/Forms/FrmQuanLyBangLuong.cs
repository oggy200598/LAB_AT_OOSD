using System;
using System.Windows.Forms;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmQuanLyBangLuong : Form
    {
        public FrmQuanLyBangLuong()
        {
            InitializeComponent();
        }

        private void MoForm(string tenForm)
        {
            Type loai = GetType().Assembly.GetType(
                "QuanLyNhanSu.Forms." + tenForm);

            if (loai == null || !typeof(Form).IsAssignableFrom(loai))
            {
                MessageBox.Show("Chưa tìm thấy Form: " + tenForm);
                return;
            }

            try
            {
                using (Form form = (Form)Activator.CreateInstance(loai))
                {
                    form.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBangLuong_Click(object sender, EventArgs e)
        {
            MoForm("FrmBangLuong");
        }

        private void btnChiTietBangLuong_Click(object sender, EventArgs e)
        {
            MoForm("FrmChiTietBangLuong");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}