using System.Collections.Generic;
using eSHOPPING.Models;

namespace eSHOPPING.Services
{
    public static class SessionService
    {
        public static KhachHang CurrentCustomer { get; set; }
        public static List<GioHangItem> Cart { get; private set; }

        static SessionService()
        {
            Cart = new List<GioHangItem>();
        }

        public static void ClearCart()
        {
            Cart.Clear();
        }

        public static decimal CartTotal()
        {
            decimal total = 0;
            foreach (var item in Cart)
                total += item.ThanhTien;
            return total;
        }
    }
}
