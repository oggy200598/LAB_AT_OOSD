using System;
using System.Windows.Forms;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmHopDongBaoHiem : Form
    {
        public FrmHopDongBaoHiem()
        {
            InitializeComponent();
        }

        private void MoForm(string tenForm)
        {
            Type loai = typeof(FrmHopDongBaoHiem).Assembly.GetType(
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

        private void btnHopDongLaoDong_Click(object sender, EventArgs e)
        {
            MoForm("FrmHopDongLaoDong");
        }

        private void btnHoSoBaoHiem_Click(object sender, EventArgs e)
        {
            MoForm("FrmHoSoBaoHiem");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}