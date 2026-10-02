using System;
using System.Windows.Forms;
using eSHOPPING.Models;
using eSHOPPING.Services;

namespace eSHOPPING.UI
{
    public partial class FrmChiTietSanPham : Form
    {
        private readonly SanPham _product;
        private readonly CartService _cart = new CartService();

        public FrmChiTietSanPham() : this(new SanPham { MaSP = 1, TenSP = "Tên sản phẩm", NhaSanXuat = "Nhà sản xuất", TenNhom = "Nhóm sản phẩm", GiaBan = 100000, TonKho = 10, MoTa = "Mô tả sản phẩm", ThongSoKyThuat = "Thông số kỹ thuật" })
        {
        }

        public FrmChiTietSanPham(SanPham product)
        {
            _product = product;
            InitializeComponent();
            ApplyProductInfo();
        }

        private void ApplyProductInfo()
        {
            lblTitle.Text = _product.TenSP;
            txtMaSP.Text = _product.MaSP.ToString();
            txtNhaSanXuat.Text = _product.NhaSanXuat;
            txtNhom.Text = _product.TenNhom;
            txtGiaBan.Text = _product.GiaBan.ToString("N0") + " đ";
            txtTonKho.Text = _product.TonKho.ToString();
            txtMoTa.Text = _product.MoTa;
            txtThongSo.Text = _product.ThongSoKyThuat;
            numQuantity.Maximum = Math.Max(1, _product.TonKho);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (_product.TonKho <= 0) { MessageBox.Show("Sản phẩm đã hết hàng."); return; }
            _cart.Add(_product, (int)numQuantity.Value);
            MessageBox.Show("Đã thêm vào giỏ hàng.");
        }

        private void Cart_Click(object sender, EventArgs e)
        {
            new FrmGioHang().ShowDialog(this);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
