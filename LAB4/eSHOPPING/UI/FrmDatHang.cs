using System;
using System.Linq;
using System.Windows.Forms;
using eSHOPPING.Models;
using eSHOPPING.Services;

namespace eSHOPPING.UI
{
    public partial class FrmDatHang : Form
    {
        private decimal shippingFee;

        public FrmDatHang()
        {
            InitializeComponent();
            LoadCustomer();
            Calculate();
        }

        private void LoadCustomer()
        {
            if (SessionService.CurrentCustomer == null) return;
            txtHoTen.Text = SessionService.CurrentCustomer.HoTen;
            txtDiaChi.Text = SessionService.CurrentCustomer.DiaChi;
            txtDienThoai.Text = SessionService.CurrentCustomer.DienThoai;
        }

        private void Calculate()
        {
            decimal goods = SessionService.CartTotal();
            string type = cboGiaoHang == null || cboGiaoHang.SelectedItem == null ? "Thường" : cboGiaoHang.SelectedItem.ToString();
            string region = cboKhuVuc == null || cboKhuVuc.SelectedItem == null ? "TP.HCM" : cboKhuVuc.SelectedItem.ToString();
            shippingFee = GetBaseFee(type, region);
            string note = "";
            if (goods >= 5000000m && type == "Chuyển phát nhanh trong ngày") { shippingFee = 0; note = "Đơn từ 5.000.000đ: miễn phí giao nhanh trong ngày."; }
            else if (goods >= 1000000m && type == "Chuyển phát nhanh") { shippingFee = 0; note = "Đơn từ 1.000.000đ: miễn phí chuyển phát nhanh."; }
            lblTienHang.Text = "Tiền hàng: " + goods.ToString("N0") + " đ";
            lblPhi.Text = "Phí giao hàng: " + shippingFee.ToString("N0") + " đ";
            lblTong.Text = "Tổng thanh toán: " + (goods + shippingFee).ToString("N0") + " đ";
            lblFree.Text = note;
        }

        private decimal GetBaseFee(string type, string region)
        {
            decimal regionFee = region == "TP.HCM" ? 20000m : region == "Long An" ? 30000m : region == "Đồng Nai" ? 35000m : region == "Bình Dương" ? 35000m : 50000m;
            if (type == "Thường") return regionFee;
            if (type == "Chuyển phát nhanh") return regionFee + 30000m;
            return regionFee + 70000m;
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text) || string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin người nhận.");
                return;
            }
            var order = new DonHang
            {
                MaKH = SessionService.CurrentCustomer.MaKH,
                HoTenNguoiNhan = txtHoTen.Text.Trim(),
                DiaChiNguoiNhan = txtDiaChi.Text.Trim(),
                DienThoaiNguoiNhan = txtDienThoai.Text.Trim(),
                KhuVuc = cboKhuVuc.SelectedItem.ToString(),
                LoaiGiaoHang = cboGiaoHang.SelectedItem.ToString(),
                PhiGiaoHang = shippingFee,
                TongTienHang = SessionService.CartTotal(),
                TongThanhToan = SessionService.CartTotal() + shippingFee,
                TrangThai = "Chờ thanh toán",
                ThoiGianDat = DateTime.Now,
                ChiTiet = SessionService.Cart.ToList()
            };
            using (var f = new FrmThanhToan(order))
            {
                if (f.ShowDialog(this) == DialogResult.OK) Close();
            }
        }

        private void ShippingChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
