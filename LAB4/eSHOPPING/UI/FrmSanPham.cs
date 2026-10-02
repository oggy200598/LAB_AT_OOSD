using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using eSHOPPING.Adapters;
using eSHOPPING.Models;
using eSHOPPING.Services;

namespace eSHOPPING.UI
{
    public partial class FrmSanPham : Form
    {
        private readonly ProductAdapter _adapter = new ProductAdapter();
        private readonly CartService _cart = new CartService();
        private List<SanPham> _products = new List<SanPham>();

        public FrmSanPham()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime) LoadData();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            using (var f = new FrmDangNhap())
            if (f.ShowDialog(this) == DialogResult.OK) UpdateStatus();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            new FrmDangKy().ShowDialog(this);
        }

        private void LoadData()
        {
            try
            {
                if (cboGroup.Items.Count == 0)
                {
                    var all = new NhomSanPham { MaNhom = 0, TenNhom = "Tất cả" };
                    var service = new ProductService();
                    var list = new List<NhomSanPham> { all };
                    list.AddRange(service.GetGroups());
                    cboGroup.DisplayMember = "TenNhom";
                    cboGroup.ValueMember = "MaNhom";
                    cboGroup.DataSource = list;
                    return;
                }
                int group = cboGroup.SelectedValue is int ? (int)cboGroup.SelectedValue : 0;
                _products = _adapter.GetProducts(group, txtSearch.Text.Trim());
                grid.DataSource = null;
                grid.DataSource = _products;
            }
            catch (Exception ex)
            {
                if (IsHandleCreated) MessageBox.Show("Không thể tải sản phẩm: " + ex.Message);
            }
        }

        private SanPham GetSelected()
        {
            if (grid.CurrentRow == null) return null;
            return grid.CurrentRow.DataBoundItem as SanPham;
        }

        private void OpenDetail()
        {
            var p = GetSelected();
            if (p == null) return;
            new FrmChiTietSanPham(p).ShowDialog(this);
            UpdateStatus();
        }

        private void AddToCart()
        {
            var p = GetSelected();
            if (p == null) return;
            if (p.TonKho <= 0) { MessageBox.Show("Sản phẩm đã hết hàng."); return; }
            _cart.Add(p, 1);
            UpdateStatus();
            MessageBox.Show("Đã thêm sản phẩm vào giỏ hàng.");
        }

        private void UpdateStatus()
        {
            lblUser.Text = SessionService.CurrentCustomer == null ? "Khách chưa đăng nhập" : "Xin chào, " + SessionService.CurrentCustomer.HoTen;
            lblCart.Text = SessionService.Cart.Sum(x => x.SoLuong) + " sản phẩm";
        }

        private void GroupOrSearchChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Detail_Click(object sender, EventArgs e)
        {
            OpenDetail();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddToCart();
        }

        private void Cart_Click(object sender, EventArgs e)
        {
            new FrmGioHang().ShowDialog(this);
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            OpenDetail();
        }
    }
}
