using System.Windows.Forms;
using eSHOPPING.Models;

namespace eSHOPPING.UI
{
    public partial class FrmXacNhanDon : Form
    {
        public FrmXacNhanDon() : this(new DonHang(), new PaymentResult())
        {
        }

        public FrmXacNhanDon(DonHang order, PaymentResult payment)
        {
            InitializeComponent();
            UpdateInfo(order, payment);
        }

        private void UpdateInfo(DonHang order, PaymentResult payment)
        {
            info.Text = "Mã đơn hàng: " + order.MaDonHang + "" +
                        "Người nhận: " + order.HoTenNguoiNhan + "" +
                        "Địa chỉ: " + order.DiaChiNguoiNhan + "" +
                        "Loại giao hàng: " + order.LoaiGiaoHang + "" +
                        "Phí giao hàng: " + order.PhiGiaoHang.ToString("N0") + " đ" +
                        "Tổng thanh toán: " + order.TongThanhToan.ToString("N0") + " đ" +
                        "Mã giao dịch: " + payment.MaGiaoDich + "" +
                        "Trạng thái: Đã thanh toán";
        }

        private void Close_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
