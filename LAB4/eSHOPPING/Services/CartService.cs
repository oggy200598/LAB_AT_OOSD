using System.Linq;
using eSHOPPING.Models;

namespace eSHOPPING.Services
{
    public class CartService
    {
        public void Add(SanPham product, int quantity)
        {
            if (product == null || quantity <= 0) return;
            var item = SessionService.Cart.FirstOrDefault(x => x.SanPham.MaSP == product.MaSP);
            if (item == null)
                SessionService.Cart.Add(new GioHangItem { SanPham = product, SoLuong = quantity });
            else
                item.SoLuong += quantity;
            if (item != null && item.SoLuong > product.TonKho) item.SoLuong = product.TonKho;
        }

        public void Update(int maSP, int quantity)
        {
            var item = SessionService.Cart.FirstOrDefault(x => x.SanPham.MaSP == maSP);
            if (item == null) return;
            if (quantity <= 0)
                SessionService.Cart.Remove(item);
            else
                item.SoLuong = quantity > item.SanPham.TonKho ? item.SanPham.TonKho : quantity;
        }

        public void Remove(int maSP)
        {
            var item = SessionService.Cart.FirstOrDefault(x => x.SanPham.MaSP == maSP);
            if (item != null) SessionService.Cart.Remove(item);
        }
    }
}
