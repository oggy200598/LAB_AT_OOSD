using System;
using System.Collections.Generic;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Forms
{
    public class FrmTang : FrmCRUD
    {
        public FrmTang() : base("Quản lý tầng", "Tang", "MaTang",
            new FieldDef("MaTang", "Mã tầng", FieldKind.Text, true),
            new FieldDef("SoTang", "Số tầng", FieldKind.Number, true),
            new FieldDef("MoTa", "Mô tả")) { }
    }

    public class FrmPhong : FrmCRUD
    {
        public FrmPhong() : base("Quản lý phòng", "Phong", "MaPhong",
            new FieldDef("MaPhong", "Mã phòng", FieldKind.Text, true),
            new FieldDef("MaTang", "Tầng", FieldKind.Lookup, true, "SELECT MaTang AS Ma, MaTang + N' - tầng ' + CAST(SoTang AS NVARCHAR(10)) AS Ten FROM dbo.Tang ORDER BY SoTang"),
            new FieldDef("DienTich", "Diện tích m2", FieldKind.Money, true),
            new FieldDef("HuongPhong", "Hướng phòng"),
            new FieldDef("GiaThue", "Giá thuê/tháng", FieldKind.Money, true),
            new FieldDef("TrangThai", "Trạng thái", FieldKind.Options, true, "SanSang|BaoTri|NgungSuDung"),
            new FieldDef("TinhTrang", "Tình trạng")) { }
    }

    public class FrmKhachHang : FrmCRUD
    {
        public FrmKhachHang() : base("Quản lý khách hàng / công ty", "KhachHang", "MaKH",
            new FieldDef("MaKH", "Mã khách hàng", FieldKind.Text, true),
            new FieldDef("TenKH", "Tên khách hàng", FieldKind.Text, true),
            new FieldDef("DiaChi", "Địa chỉ"),
            new FieldDef("DienThoai", "Điện thoại"),
            new FieldDef("Email", "Email"),
            new FieldDef("MaSoThue", "Mã số thuế"),
            new FieldDef("NguoiDaiDien", "Người đại diện")) { }
    }

    public class FrmDichVu : FrmCRUD
    {
        public FrmDichVu() : base("Danh mục dịch vụ", "DichVu", "MaDV",
            new FieldDef("MaDV", "Mã dịch vụ", FieldKind.Text, true),
            new FieldDef("TenDV", "Tên dịch vụ", FieldKind.Text, true),
            new FieldDef("DonGia", "Đơn giá", FieldKind.Money, true),
            new FieldDef("DonViTinh", "Đơn vị tính"),
            new FieldDef("MoTa", "Mô tả")) { }
    }

    public class FrmNhanVienQuanLy : FrmCRUD
    {
        public FrmNhanVienQuanLy() : base("Nhân viên quản lý cao ốc", "NhanVienQuanLy", "MaNVQL",
            new FieldDef("MaNVQL", "Mã quản lý", FieldKind.Text, true),
            new FieldDef("HoTen", "Họ tên", FieldKind.Text, true),
            new FieldDef("ChucVu", "Chức vụ"),
            new FieldDef("DienThoai", "Điện thoại"),
            new FieldDef("Email", "Email")) { }
    }

    public class FrmNhanVien : FrmCRUD
    {
        public FrmNhanVien() : base("Nhân viên làm việc tại văn phòng", "NhanVien", "MaNV",
            new FieldDef("MaNV", "Mã nhân viên", FieldKind.Text, true),
            new FieldDef("MaKH", "Công ty", FieldKind.Lookup, true, "SELECT MaKH AS Ma,MaKH+N' - '+TenKH AS Ten FROM dbo.KhachHang ORDER BY TenKH"),
            new FieldDef("MaPhong", "Phòng làm việc", FieldKind.Lookup, true, "SELECT MaPhong AS Ma,MaPhong AS Ten FROM dbo.Phong ORDER BY MaPhong"),
            new FieldDef("HoTen", "Họ tên", FieldKind.Text, true),
            new FieldDef("HinhAnh", "Đường dẫn ảnh"),
            new FieldDef("ChucVu", "Chức vụ"),
            new FieldDef("DienThoai", "Điện thoại"),
            new FieldDef("TrangThai", "Trạng thái", FieldKind.Options, true, "DangLamViec|DaNghi")) { }

        protected override void ValidateRecord(Dictionary<string, object> values, bool edit)
        {
            var count = Convert.ToInt32(Database.Scalar(@"SELECT COUNT(*) FROM dbo.ChiTietHopDong c
JOIN dbo.HopDong h ON h.MaHD=c.MaHD
WHERE h.MaKH=@kh AND c.MaPhong=@p AND h.TrangThai=N'HieuLuc'
AND c.NgayBatDau<=CAST(GETDATE() AS DATE) AND c.NgayKetThuc>=CAST(GETDATE() AS DATE)",
                Database.P("@kh", values["MaKH"]), Database.P("@p", values["MaPhong"])));
            if (count == 0) throw new InvalidOperationException("Công ty chưa có hợp đồng thuê đang hiệu lực tại phòng này.");
        }
    }

    public class FrmTheGiuXe : FrmCRUD
    {
        public FrmTheGiuXe() : base("Quản lý thẻ giữ xe", "TheGiuXe", "MaThe",
            new FieldDef("MaThe", "Mã thẻ", FieldKind.Text, true),
            new FieldDef("MaNV", "Nhân viên", FieldKind.Lookup, true, "SELECT MaNV AS Ma,MaNV+N' - '+HoTen AS Ten FROM dbo.NhanVien ORDER BY HoTen"),
            new FieldDef("BienSoXe", "Biển số xe", FieldKind.Text, true),
            new FieldDef("LoaiXe", "Loại xe"),
            new FieldDef("NgayCap", "Ngày cấp", FieldKind.Date, true),
            new FieldDef("TrangThai", "Trạng thái", FieldKind.Options, true, "HoatDong|Khoa|Huy")) { }
    }

    public class FrmPhieuKiemTra : FrmCRUD
    {
        public FrmPhieuKiemTra() : base("Kiểm tra phòng định kỳ", "PhieuKiemTra", "MaPKT",
            new FieldDef("MaPKT", "Mã phiếu", FieldKind.Text, true),
            new FieldDef("MaPhong", "Phòng", FieldKind.Lookup, true, "SELECT MaPhong AS Ma,MaPhong AS Ten FROM dbo.Phong ORDER BY MaPhong"),
            new FieldDef("MaNVQL", "Người kiểm tra", FieldKind.Lookup, true, "SELECT MaNVQL AS Ma,HoTen AS Ten FROM dbo.NhanVienQuanLy ORDER BY HoTen"),
            new FieldDef("NgayKiemTra", "Ngày kiểm tra", FieldKind.Date, true),
            new FieldDef("TinhTrangPhong", "Tình trạng phòng", FieldKind.Text, true),
            new FieldDef("NoiDung", "Nội dung"),
            new FieldDef("KetQua", "Kết quả")) { }
    }

    public class FrmPhieuViPham : FrmCRUD
    {
        public FrmPhieuViPham() : base("Xử lý vi phạm kết cấu", "PhieuViPham", "MaPVP",
            new FieldDef("MaPVP", "Mã phiếu", FieldKind.Text, true),
            new FieldDef("MaCTHD", "Phòng thuê", FieldKind.Lookup, true,
                "SELECT c.MaCTHD AS Ma,c.MaPhong+N' / '+c.MaHD AS Ten FROM dbo.ChiTietHopDong c ORDER BY c.MaPhong"),
            new FieldDef("MaPKT", "Phiếu kiểm tra", FieldKind.Lookup, true,
                "SELECT MaPKT AS Ma,MaPKT+N' / '+MaPhong AS Ten FROM dbo.PhieuKiemTra ORDER BY NgayKiemTra DESC"),
            new FieldDef("NgayLap", "Ngày lập", FieldKind.Date, true),
            new FieldDef("NoiDungViPham", "Nội dung vi phạm", FieldKind.Text, true),
            new FieldDef("SoTienPhat", "Số tiền phạt", FieldKind.Money, true),
            new FieldDef("TrangThai", "Trạng thái", FieldKind.Options, true, "ChuaXuLy|DaXuLy")) { }

        protected override void ValidateRecord(Dictionary<string, object> values, bool edit)
        {
            int match = Convert.ToInt32(Database.Scalar(@"SELECT COUNT(*) FROM dbo.PhieuKiemTra p
JOIN dbo.ChiTietHopDong c ON c.MaPhong=p.MaPhong WHERE p.MaPKT=@p AND c.MaCTHD=@ct",
                Database.P("@p", values["MaPKT"]), Database.P("@ct", values["MaCTHD"])));
            if (match != 1) throw new InvalidOperationException("Phiếu kiểm tra và chi tiết hợp đồng phải thuộc cùng một phòng.");
        }
    }
}
