using System;
using System.Data;
using System.Windows.Forms;
using QuanLyThuVien.Services;

namespace QuanLyThuVien.Forms
{
    public partial class FrmThongKe : Form
    {
        private readonly ThongKeService service =
            new ThongKeService();

        public FrmThongKe()
        {
            InitializeComponent();

            Load += FrmThongKe_Load;
        }

        private void FrmThongKe_Load(
            object sender,
            EventArgs e)
        {
            dtTuNgay.Value =
                new DateTime(
                    DateTime.Today.Year,
                    DateTime.Today.Month,
                    1);

            dtDenNgay.Value =
                DateTime.Today;

            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            try
            {
                ThongKeTongHop kq =
                    service.LayTongHop(
                        dtTuNgay.Value,
                        dtDenNgay.Value);

                lblLuotSachMuon.Text =
                    "Lượt sách mượn: " +
                    kq.LuotSachMuon;

                lblSachQuaHan.Text =
                    "Sách quá hạn: " +
                    kq.SachQuaHan;

                lblSachMat.Text =
                    "Sách mất: " +
                    kq.SachMat;

                lblSachHuHong.Text =
                    "Sách hư hỏng: " +
                    kq.SachHuHong;

                lblTongPhiPhat.Text =
                    "Tổng phí phạt: " +
                    kq.TongPhiPhat.ToString("N0") +
                    " đ";

                DataTable data =
                    service.LayChiTietPhat(
                        dtTuNgay.Value,
                        dtDenNgay.Value);

                dgvPhieuPhat.AutoGenerateColumns =
                    false;

                if (dgvPhieuPhat.Columns.Count >= 6)
                {
                    dgvPhieuPhat.Columns[0]
                        .DataPropertyName =
                        "MaPhieuPhat";

                    dgvPhieuPhat.Columns[1]
                        .DataPropertyName =
                        "NgayPhat";

                    dgvPhieuPhat.Columns[2]
                        .DataPropertyName =
                        "MaDocGia";

                    dgvPhieuPhat.Columns[3]
                        .DataPropertyName =
                        "MaDauSach";

                    dgvPhieuPhat.Columns[4]
                        .DataPropertyName =
                        "LyDo";

                    dgvPhieuPhat.Columns[5]
                        .DataPropertyName =
                        "PhiPhat";

                    dgvPhieuPhat.Columns[1]
                        .DefaultCellStyle.Format =
                        "dd/MM/yyyy";

                    dgvPhieuPhat.Columns[5]
                        .DefaultCellStyle.Format =
                        "N0";
                }

                dgvPhieuPhat.DataSource =
                    data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể thống kê.\n\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnThongKe_Click(
            object sender,
            EventArgs e)
        {
            TaiDuLieu();
        }
    }
}