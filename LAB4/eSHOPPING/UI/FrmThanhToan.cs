using System;
using System.Windows.Forms;
using eSHOPPING.Adapters;
using eSHOPPING.Models;
using eSHOPPING.Services;

namespace eSHOPPING.UI
{
    public partial class FrmThanhToan : Form
    {
        private readonly DonHang _order;
        private readonly PaymentAdapter _payment = new PaymentAdapter();
        private readonly OrderService _orderService = new OrderService();

        public FrmThanhToan() : this(new DonHang { TongThanhToan = 0 })
        {
        }

        public FrmThanhToan(DonHang order)
        {
            _order = order;
            InitializeComponent();
            lblAmount.Text = "Số tiền: " + _order.TongThanhToan.ToString("N0") + " đ";
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            try
            {
                var result = _payment.Authorize(cboType.SelectedItem.ToString(), txtNumber.Text.Trim(), txtExpiry.Text.Trim(), txtName.Text.Trim(), txtCsv.Text.Trim(), _order.TongThanhToan);
                if (!result.ThanhCong)
                {
                    MessageBox.Show(result.ThongBao);
                    return;
                }
                _order.MaDonHang = _orderService.CreateOrder(_order, result);
                SessionService.ClearCart();
                using (var f = new FrmXacNhanDon(_order, result)) f.ShowDialog(this);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thanh toán thất bại: " + ex.Message);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
