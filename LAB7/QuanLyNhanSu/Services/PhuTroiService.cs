using System;
using System.Data;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class PhuTroiService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(@"
                SELECT MaPhieuPhuTroi, SoPhieu, NgayPhuTroi,
                       SoGioPhuTroi, HinhThucPhuTroi,
                       NguoiLap, GhiChu
                FROM PhieuPhuTroi
                ORDER BY NgayPhuTroi DESC, MaPhieuPhuTroi");
        }

        public DataTable TimKiem(string tuKhoa)
        {
            return Db.Query(@"
                SELECT MaPhieuPhuTroi, SoPhieu, NgayPhuTroi,
                       SoGioPhuTroi, HinhThucPhuTroi,
                       NguoiLap, GhiChu
                FROM PhieuPhuTroi
                WHERE MaPhieuPhuTroi LIKE @TuKhoa
                   OR SoPhieu LIKE @TuKhoa
                   OR HinhThucPhuTroi LIKE @TuKhoa
                   OR NguoiLap LIKE @TuKhoa
                   OR GhiChu LIKE @TuKhoa
                ORDER BY NgayPhuTroi DESC, MaPhieuPhuTroi",
                Db.P("@TuKhoa", "%" + (tuKhoa ?? "").Trim() + "%"));
        }

        public bool KiemTraTonTai(string maPhieu)
        {
            if (string.IsNullOrWhiteSpace(maPhieu))
                return false;

            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM PhieuPhuTroi
                WHERE MaPhieuPhuTroi = @MaPhieu",
                Db.P("@MaPhieu", maPhieu.Trim()))) > 0;
        }

        public bool KiemTraTrungSoPhieu(
            string soPhieu, string maPhieu)
        {
            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM PhieuPhuTroi
                WHERE SoPhieu = @SoPhieu
                  AND MaPhieuPhuTroi <> @MaPhieu",
                Db.P("@SoPhieu", soPhieu.Trim()),
                Db.P("@MaPhieu", maPhieu.Trim()))) > 0;
        }

        public int Them(
            string maPhieu,
            string soPhieu,
            DateTime ngayPhuTroi,
            decimal soGioPhuTroi,
            string hinhThuc,
            string nguoiLap,
            string ghiChu)
        {
            KiemTraPhieu(
                maPhieu, soPhieu, soGioPhuTroi,
                hinhThuc, nguoiLap, ghiChu);

            if (KiemTraTonTai(maPhieu))
                throw new Exception("Mã phiếu phụ trội đã tồn tại.");

            if (KiemTraTrungSoPhieu(soPhieu, maPhieu))
                throw new Exception("Số phiếu đã tồn tại.");

            return Db.Execute(@"
                INSERT INTO PhieuPhuTroi
                (
                    MaPhieuPhuTroi, SoPhieu, NgayPhuTroi,
                    SoGioPhuTroi, HinhThucPhuTroi,
                    NguoiLap, GhiChu
                )
                VALUES
                (
                    @MaPhieu, @SoPhieu, @NgayPhuTroi,
                    @SoGioPhuTroi, @HinhThuc,
                    @NguoiLap, @GhiChu
                )",
                Db.P("@MaPhieu", maPhieu.Trim()),
                Db.P("@SoPhieu", soPhieu.Trim()),
                Db.P("@NgayPhuTroi", ngayPhuTroi.Date),
                Db.P("@SoGioPhuTroi", soGioPhuTroi),
                Db.P("@HinhThuc", hinhThuc),
                Db.P("@NguoiLap", nguoiLap.Trim()),
                Db.P("@GhiChu", ghiChu));
        }

        public int Sua(
            string maPhieu,
            string soPhieu,
            DateTime ngayPhuTroi,
            decimal soGioPhuTroi,
            string hinhThuc,
            string nguoiLap,
            string ghiChu)
        {
            KiemTraPhieu(
                maPhieu, soPhieu, soGioPhuTroi,
                hinhThuc, nguoiLap, ghiChu);

            if (KiemTraTrungSoPhieu(soPhieu, maPhieu))
                throw new Exception("Số phiếu đã tồn tại.");

            return Db.Execute(@"
                UPDATE PhieuPhuTroi
                SET SoPhieu = @SoPhieu,
                    NgayPhuTroi = @NgayPhuTroi,
                    SoGioPhuTroi = @SoGioPhuTroi,
                    HinhThucPhuTroi = @HinhThuc,
                    NguoiLap = @NguoiLap,
                    GhiChu = @GhiChu
                WHERE MaPhieuPhuTroi = @MaPhieu",
                Db.P("@MaPhieu", maPhieu.Trim()),
                Db.P("@SoPhieu", soPhieu.Trim()),
                Db.P("@NgayPhuTroi", ngayPhuTroi.Date),
                Db.P("@SoGioPhuTroi", soGioPhuTroi),
                Db.P("@HinhThuc", hinhThuc),
                Db.P("@NguoiLap", nguoiLap.Trim()),
                Db.P("@GhiChu", ghiChu));
        }

        public int Xoa(string maPhieu)
        {
            if (string.IsNullOrWhiteSpace(maPhieu))
                throw new Exception("Vui lòng chọn phiếu cần xóa.");

            return Db.Execute(@"
                DELETE FROM PhieuPhuTroi
                WHERE MaPhieuPhuTroi = @MaPhieu",
                Db.P("@MaPhieu", maPhieu.Trim()));
        }

        private void KiemTraPhieu(
            string maPhieu,
            string soPhieu,
            decimal soGio,
            string hinhThuc,
            string nguoiLap,
            string ghiChu)
        {
            if (string.IsNullOrWhiteSpace(maPhieu))
                throw new Exception("Vui lòng nhập mã phiếu phụ trội.");

            if (maPhieu.Trim().Length > 20)
                throw new Exception("Mã phiếu tối đa 20 ký tự.");

            if (string.IsNullOrWhiteSpace(soPhieu))
                throw new Exception("Vui lòng nhập số phiếu.");

            if (soPhieu.Trim().Length > 30)
                throw new Exception("Số phiếu tối đa 30 ký tự.");

            if (soGio <= 0 || soGio > 24)
                throw new Exception(
                    "Số giờ phụ trội phải lớn hơn 0 và không vượt quá 24.");

            if (decimal.Round(soGio, 2) != soGio)
                throw new Exception("Số giờ chỉ có tối đa 2 chữ số thập phân.");

            if (hinhThuc != "Tăng ca" &&
                hinhThuc != "Ngày lễ" &&
                hinhThuc != "Ngày nghỉ")
                throw new Exception("Hình thức phụ trội không hợp lệ.");

            if (string.IsNullOrWhiteSpace(nguoiLap))
                throw new Exception("Vui lòng nhập người lập.");

            if (nguoiLap.Trim().Length > 100)
                throw new Exception("Người lập tối đa 100 ký tự.");

            if (!string.IsNullOrEmpty(ghiChu) && ghiChu.Length > 500)
                throw new Exception("Ghi chú tối đa 500 ký tự.");
        }

        public DataTable LayDanhSachChiTiet()
        {
            return Db.Query(@"
                SELECT ct.MaChiTietPhuTroi,
                       ct.MaPhieuPhuTroi,
                       p.SoPhieu,
                       ct.MaNV,
                       nv.HoTen,
                       ct.SoGioThamGia,
                       ct.HeSoPhuTroi,
                       ct.ThanhTien
                FROM ChiTietPhuTroi ct
                INNER JOIN PhieuPhuTroi p
                    ON ct.MaPhieuPhuTroi = p.MaPhieuPhuTroi
                INNER JOIN NhanVien nv
                    ON ct.MaNV = nv.MaNV
                ORDER BY p.NgayPhuTroi DESC, ct.MaChiTietPhuTroi");
        }

        public DataTable LayPhieuPhuTroi()
        {
            return Db.Query(@"
                SELECT MaPhieuPhuTroi,
                       MaPhieuPhuTroi + N' - ' + SoPhieu
                       AS TenPhieu
                FROM PhieuPhuTroi
                ORDER BY NgayPhuTroi DESC, MaPhieuPhuTroi");
        }

        public DataTable LayNhanVien()
        {
            return Db.Query(@"
                SELECT MaNV,
                       MaNV + N' - ' + HoTen AS TenNhanVien
                FROM NhanVien
                ORDER BY MaNV");
        }

        public DataTable TimKiemChiTiet(string tuKhoa)
        {
            return Db.Query(@"
                SELECT ct.MaChiTietPhuTroi,
                       ct.MaPhieuPhuTroi,
                       p.SoPhieu,
                       ct.MaNV,
                       nv.HoTen,
                       ct.SoGioThamGia,
                       ct.HeSoPhuTroi,
                       ct.ThanhTien
                FROM ChiTietPhuTroi ct
                INNER JOIN PhieuPhuTroi p
                    ON ct.MaPhieuPhuTroi = p.MaPhieuPhuTroi
                INNER JOIN NhanVien nv
                    ON ct.MaNV = nv.MaNV
                WHERE ct.MaChiTietPhuTroi LIKE @TuKhoa
                   OR ct.MaPhieuPhuTroi LIKE @TuKhoa
                   OR p.SoPhieu LIKE @TuKhoa
                   OR ct.MaNV LIKE @TuKhoa
                   OR nv.HoTen LIKE @TuKhoa
                ORDER BY p.NgayPhuTroi DESC, ct.MaChiTietPhuTroi",
                Db.P("@TuKhoa", "%" + (tuKhoa ?? "").Trim() + "%"));
        }

        public bool KiemTraChiTietTonTai(string maChiTiet)
        {
            if (string.IsNullOrWhiteSpace(maChiTiet))
                return false;

            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM ChiTietPhuTroi
                WHERE MaChiTietPhuTroi = @Ma",
                Db.P("@Ma", maChiTiet.Trim()))) > 0;
        }

        public bool KiemTraTrungNhanVien(
            string maPhieu, string maNV, string maChiTiet)
        {
            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM ChiTietPhuTroi
                WHERE MaPhieuPhuTroi = @MaPhieu
                  AND MaNV = @MaNV
                  AND MaChiTietPhuTroi <> @MaChiTiet",
                Db.P("@MaPhieu", maPhieu),
                Db.P("@MaNV", maNV),
                Db.P("@MaChiTiet", maChiTiet.Trim()))) > 0;
        }

        public decimal LaySoGioPhieu(string maPhieu)
        {
            object ketQua = Db.Scalar(@"
                SELECT SoGioPhuTroi
                FROM PhieuPhuTroi
                WHERE MaPhieuPhuTroi = @MaPhieu",
                Db.P("@MaPhieu", maPhieu));

            if (ketQua == null || ketQua == DBNull.Value)
                throw new Exception("Không tìm thấy phiếu phụ trội.");

            return Convert.ToDecimal(ketQua);
        }

        public int ThemChiTiet(
            string maChiTiet,
            string maPhieu,
            string maNV,
            decimal soGioThamGia,
            decimal thanhTien)
        {
            KiemTraChiTiet(
                maChiTiet, maPhieu, maNV, soGioThamGia, thanhTien);

            if (KiemTraChiTietTonTai(maChiTiet))
                throw new Exception("Mã chi tiết phụ trội đã tồn tại.");

            if (KiemTraTrungNhanVien(maPhieu, maNV, maChiTiet))
                throw new Exception(
                    "Nhân viên đã có trong phiếu phụ trội này.");

            return Db.Execute(@"
                INSERT INTO ChiTietPhuTroi
                (
                    MaChiTietPhuTroi,
                    MaPhieuPhuTroi,
                    MaNV,
                    SoGioThamGia,
                    HeSoPhuTroi,
                    ThanhTien
                )
                VALUES
                (
                    @MaChiTiet,
                    @MaPhieu,
                    @MaNV,
                    @SoGio,
                    @HeSo,
                    @ThanhTien
                )",
                Db.P("@MaChiTiet", maChiTiet.Trim()),
                Db.P("@MaPhieu", maPhieu),
                Db.P("@MaNV", maNV),
                Db.P("@SoGio", soGioThamGia),
                Db.P("@HeSo", 1.50m),
                Db.P("@ThanhTien", thanhTien));
        }

        public int SuaChiTiet(
            string maChiTiet,
            string maPhieu,
            string maNV,
            decimal soGioThamGia,
            decimal thanhTien)
        {
            KiemTraChiTiet(
                maChiTiet, maPhieu, maNV, soGioThamGia, thanhTien);

            if (KiemTraTrungNhanVien(maPhieu, maNV, maChiTiet))
                throw new Exception(
                    "Nhân viên đã có trong phiếu phụ trội này.");

            return Db.Execute(@"
                UPDATE ChiTietPhuTroi
                SET MaPhieuPhuTroi = @MaPhieu,
                    MaNV = @MaNV,
                    SoGioThamGia = @SoGio,
                    HeSoPhuTroi = @HeSo,
                    ThanhTien = @ThanhTien
                WHERE MaChiTietPhuTroi = @MaChiTiet",
                Db.P("@MaChiTiet", maChiTiet.Trim()),
                Db.P("@MaPhieu", maPhieu),
                Db.P("@MaNV", maNV),
                Db.P("@SoGio", soGioThamGia),
                Db.P("@HeSo", 1.50m),
                Db.P("@ThanhTien", thanhTien));
        }

        public int XoaChiTiet(string maChiTiet)
        {
            if (string.IsNullOrWhiteSpace(maChiTiet))
                throw new Exception("Vui lòng chọn chi tiết cần xóa.");

            return Db.Execute(@"
                DELETE FROM ChiTietPhuTroi
                WHERE MaChiTietPhuTroi = @Ma",
                Db.P("@Ma", maChiTiet.Trim()));
        }

        private void KiemTraChiTiet(
            string maChiTiet,
            string maPhieu,
            string maNV,
            decimal soGioThamGia,
            decimal thanhTien)
        {
            if (string.IsNullOrWhiteSpace(maChiTiet))
                throw new Exception("Vui lòng nhập mã chi tiết phụ trội.");

            if (maChiTiet.Trim().Length > 20)
                throw new Exception("Mã chi tiết tối đa 20 ký tự.");

            if (string.IsNullOrWhiteSpace(maPhieu))
                throw new Exception("Vui lòng chọn phiếu phụ trội.");

            if (string.IsNullOrWhiteSpace(maNV))
                throw new Exception("Vui lòng chọn nhân viên.");

            if (soGioThamGia <= 0 || soGioThamGia > 24)
                throw new Exception(
                    "Số giờ tham gia phải lớn hơn 0 và không vượt quá 24.");

            if (decimal.Round(soGioThamGia, 2) != soGioThamGia)
                throw new Exception(
                    "Số giờ tham gia chỉ có tối đa 2 chữ số thập phân.");

            if (soGioThamGia > LaySoGioPhieu(maPhieu))
                throw new Exception(
                    "Số giờ tham gia không được vượt quá số giờ của phiếu.");

            if (thanhTien < 0)
                throw new Exception("Thành tiền không được âm.");

            if (decimal.Round(thanhTien, 2) != thanhTien)
                throw new Exception(
                    "Thành tiền chỉ có tối đa 2 chữ số thập phân.");
        }
    }
}