
using System;
using System.Windows.Forms;
using QuanLyNhanSu.Data;
using QuanLyNhanSu.Forms;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (!Db.TestConnection())
            {
                MessageBox.Show(
                    "Không thể kết nối đến cơ sở dữ liệu QuanLyNhanSu!",
                    "Lỗi kết nối",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void MoForm(string tenForm)
        {
            string tenDayDu = "QuanLyNhanSu.Forms." + tenForm;

            Type formType = typeof(FrmMain).Assembly.GetType(tenDayDu);

            if (formType == null || !typeof(Form).IsAssignableFrom(formType))
            {
                MessageBox.Show(
                    "Chức năng " + tenForm + " chưa được tạo.",
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
                    "Không thể mở Form: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            MoForm("FrmDanhMuc");
        }

        private void btnTuyenDung_Click(object sender, EventArgs e)
        {
            MoForm("FrmTuyenDung");
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            MoForm("FrmHopDongBaoHiem");
        }

        private void btnLuongChucVu_Click(object sender, EventArgs e)
        {
            MoForm("FrmLuongChucVu");
        }

        private void btnKeHoachChamCong_Click(object sender, EventArgs e)
        {
            MoForm("FrmKeHoachChamCong");
        }

        private void btnPhuTroi_Click(object sender, EventArgs e)
        {
            MoForm("FrmQuanLyPhuTroi");
        }

        private void btnKhenThuongKyLuat_Click(object sender, EventArgs e)
        {
            MoForm("FrmKhenThuongKyLuat");
        }

        private void btnBangLuong_Click(object sender, EventArgs e)
        {
            MoForm("FrmBangLuongThongKe");
        }

        private void btnThongKeBaoCao_Click(object sender, EventArgs e)
        {
            using (FrmThongKeBaoCao form = new FrmThongKeBaoCao())
            {
                form.ShowDialog(this);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
