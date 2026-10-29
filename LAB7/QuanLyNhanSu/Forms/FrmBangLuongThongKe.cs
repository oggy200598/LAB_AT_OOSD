using System;
using System.Windows.Forms;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmBangLuongThongKe : Form
    {
        public FrmBangLuongThongKe()
        {
            InitializeComponent();
        }

        private void MoForm(string tenForm)
        {
            Type loai = typeof(FrmBangLuongThongKe).Assembly.GetType(
                "QuanLyNhanSu.Forms." + tenForm);

            if (loai == null || !typeof(Form).IsAssignableFrom(loai))
            {
                MessageBox.Show(
                    "Không tìm thấy Form: " + tenForm,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
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
                MessageBox.Show(
                    ex.Message,
                    "Lỗi mở Form",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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

        private void btnThongKeBaoCao_Click(object sender, EventArgs e)
        {
            MoForm("FrmThongKeBaoCao");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}