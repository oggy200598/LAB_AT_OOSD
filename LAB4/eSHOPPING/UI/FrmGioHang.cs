using System;
using System.Linq;
using System.Windows.Forms;
using eSHOPPING.Models;
using eSHOPPING.Services;

namespace eSHOPPING.UI
{
    public partial class FrmGioHang : Form
    {
        private readonly CartService _cart = new CartService();

        public FrmGioHang()
        {
            InitializeComponent();
            LoadCart();
        }

        private void LoadCart()
        {
            var list = SessionService.Cart.Select(x => new
            {
                MaSP = x.SanPham.MaSP,
                TenSP = x.SanPham.TenSP,
                GiaBan = x.SanPham.GiaBan,
                SoLuong = x.SoLuong,
                ThanhTien = x.ThanhTien
            }).ToList();
            grid.DataSource = null;
            grid.DataSource = list;
            lblTotal.Text = "Tổng: " + SessionService.CartTotal().ToString("N0") + " đ";
        }

        private GioHangItem GetSelected()
        {
            if (grid.CurrentRow == null) return null;
            int id = Convert.ToInt32(grid.CurrentRow.Cells[0].Value);
            return SessionService.Cart.FirstOrDefault(x => x.SanPham.MaSP == id);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            var item = GetSelected();
            if (item == null) return;
            using (var f = new FrmNhapSoLuong(item.SoLuong, item.SanPham.TonKho))
            {
                if (f.ShowDialog(this) == DialogResult.OK)
                {
                    _cart.Update(item.SanPham.MaSP, f.Quantity);
                    LoadCart();
                }
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            var item = GetSelected();
            if (item == null) return;
            _cart.Remove(item.SanPham.MaSP);
            LoadCart();
        }

        private void Checkout_Click(object sender, EventArgs e)
        {
            if (!SessionService.Cart.Any()) { MessageBox.Show("Giỏ hàng đang trống."); return; }
            if (SessionService.CurrentCustomer == null)
            {
                using (var login = new FrmDangNhap())
                {
                    if (login.ShowDialog(this) != DialogResult.OK) return;
                }
            }
            using (var f = new FrmDatHang())
            {
                if (f.ShowDialog(this) == DialogResult.OK) LoadCart();
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
