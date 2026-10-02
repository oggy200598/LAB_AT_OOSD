using System;
using System.Collections.Generic;

namespace eSHOPPING.Models
{
    public class DonHang
    {
        public int MaDonHang { get; set; }
        public int MaKH { get; set; }
        public string HoTenNguoiNhan { get; set; }
        public string DiaChiNguoiNhan { get; set; }
        public string DienThoaiNguoiNhan { get; set; }
        public string LoaiGiaoHang { get; set; }
        public string KhuVuc { get; set; }
        public decimal PhiGiaoHang { get; set; }
        public decimal TongTienHang { get; set; }
        public decimal TongThanhToan { get; set; }
        public string TrangThai { get; set; }
        public DateTime ThoiGianDat { get; set; }
        public List<GioHangItem> ChiTiet { get; set; }
    }
}
