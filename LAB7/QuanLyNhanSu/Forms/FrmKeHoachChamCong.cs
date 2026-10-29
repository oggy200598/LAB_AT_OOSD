
using System;
using System.Windows.Forms;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmKeHoachChamCong : Form
    {
        public FrmKeHoachChamCong()
        {
            InitializeComponent();
        }

        private void MoForm(string tenForm)
        {
            Type loai = typeof(FrmKeHoachChamCong).Assembly.GetType(
                "QuanLyNhanSu.Forms." + tenForm);

            if (loai == null || !typeof(Form).IsAssignableFrom(loai))
            {
                MessageBox.Show("Chức năng chưa được tạo.");
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

        private void btnKeHoachTuan_Click(object sender, EventArgs e)
        {
            MoForm("FrmKeHoachTuan");
        }

        private void btnCaLamViec_Click(object sender, EventArgs e)
        {
            MoForm("FrmCaLamViec");
        }

        private void btnChiTietPhanCong_Click(object sender, EventArgs e)
        {
            MoForm("FrmChiTietPhanCong");
        }

        private void btnBangChamCong_Click(object sender, EventArgs e)
        {
            MoForm("FrmBangChamCong");
        }

        private void btnChiTietChamCong_Click(object sender, EventArgs e)
        {
            MoForm("FrmChiTietChamCong");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
