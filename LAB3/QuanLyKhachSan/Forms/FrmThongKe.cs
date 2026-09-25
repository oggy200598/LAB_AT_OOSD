using System;
using System.Data;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmThongKe : Form
    {
        readonly ThongKeService s = new ThongKeService();

        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (dtDen.Value.Date < dtTu.Value.Date)
            {
                MessageBox.Show("Đến ngày không được trước từ ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu tổng hợp
            DataTable dtTongHop = s.TongHop(dtTu.Value, dtDen.Value);
            if (dtTongHop != null && dtTongHop.Rows.Count > 0)
            {
                DataRow r = dtTongHop.Rows[0];
                lblPhieuDat.Text = "Phiếu đặt: " + Convert.ToInt32(r["SoPhieuDat"]).ToString("N0");
                lblDangO.Text = "Đang ở: " + Convert.ToInt32(r["DangO"]).ToString("N0");
                lblHoaDon.Text = "Hóa đơn: " + Convert.ToInt32(r["SoHoaDon"]).ToString("N0");
                lblDoanhThu.Text = "Doanh thu HĐ: " + Convert.ToDecimal(r["DoanhThuHoaDon"]).ToString("N0") + " đ";
                lblDenBu.Text = "Tổng đền bù: " + Convert.ToDecimal(r["TongDenBu"]).ToString("N0") + " đ";
            }

            // Gán dữ liệu cho DataGridView dịch vụ
            dgvDV.DataSource = s.DichVu(dtTu.Value, dtDen.Value);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}