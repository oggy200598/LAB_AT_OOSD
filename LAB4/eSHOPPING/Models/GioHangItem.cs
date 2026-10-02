namespace eSHOPPING.Models
{
    public class GioHangItem
    {
        public SanPham SanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal ThanhTien { get { return SoLuong * SanPham.GiaBan; } }
    }
}
