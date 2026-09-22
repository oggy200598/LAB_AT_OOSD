using System;

namespace QuanLyThuVien
{
    public class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string Phai { get; set; }
        public DateTime NgaySinh { get; set; }
        public string ChucVu { get; set; }
        public string SoDienThoai { get; set; }
    }

    public class DocGia
    {
        public string MaDocGia { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Phai { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string Anh3x4 { get; set; }
    }

    public class TheDocGia
    {
        public string MaThe { get; set; }
        public string MaDocGia { get; set; }
        public DateTime NgayCap { get; set; }
        public DateTime HanSuDung { get; set; }
        public bool DaDongLePhi { get; set; }
        public string TrangThai { get; set; }
    }

    public class NhaXuatBan
    {
        public string MaNhaXuatBan { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
    }

    public class TheLoai
    {
        public string MaTheLoai { get; set; }
        public string TenTheLoai { get; set; }
    }

    public class DauSach
    {
        public string MaDauSach { get; set; }
        public string TenSach { get; set; }
        public int NamXuatBan { get; set; }
        public int SoLuongHienCo { get; set; }
        public string MaTheLoai { get; set; }
        public string MaNhaXuatBan { get; set; }
    }

    public class PhieuMuon
    {
        public string MaPhieuMuon { get; set; }
        public string MaDocGia { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayHenTra { get; set; }
    }

    public class ChiTietPhieuMuon
    {
        public string MaChiTiet { get; set; }
        public string MaPhieuMuon { get; set; }
        public string MaDauSach { get; set; }
        public DateTime? NgayTraThucTe { get; set; }
        public string TinhTrangTra { get; set; }
    }

    public class PhieuPhat
    {
        public string MaPhieuPhat { get; set; }
        public string MaChiTiet { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime NgayPhat { get; set; }
        public string LyDo { get; set; }
        public decimal PhiPhat { get; set; }
    }

    public class KetQuaXuLy
    {
        public bool ThanhCong { get; set; }
        public string ThongBao { get; set; }

        public static KetQuaXuLy Ok(string thongBao)
        {
            return new KetQuaXuLy
            {
                ThanhCong = true,
                ThongBao = thongBao
            };
        }

        public static KetQuaXuLy Loi(string thongBao)
        {
            return new KetQuaXuLy
            {
                ThanhCong = false,
                ThongBao = thongBao
            };
        }
    }

    public class ThongKeTongHop
    {
        public int LuotSachMuon { get; set; }
        public int SachQuaHan { get; set; }
        public int SachMat { get; set; }
        public int SachHuHong { get; set; }
        public decimal TongPhiPhat { get; set; }
    }
}