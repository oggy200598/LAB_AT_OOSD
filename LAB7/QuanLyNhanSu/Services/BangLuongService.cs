using System;
using System.Data;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class BangLuongService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(@"
                SELECT MaBangLuong, Thang, Nam, NgayLap,
                       NguoiLap, TongTienLuong, TrangThai
                FROM BangLuong
                ORDER BY Nam DESC, Thang DESC, MaBangLuong");
        }

        public DataTable TimKiem(string tuKhoa)
        {
            return Db.Query(@"
                SELECT MaBangLuong, Thang, Nam, NgayLap,
                       NguoiLap, TongTienLuong, TrangThai
                FROM BangLuong
                WHERE MaBangLuong LIKE @TuKhoa
                   OR NguoiLap LIKE @TuKhoa
                   OR TrangThai LIKE @TuKhoa
                   OR CONVERT(VARCHAR(2), Thang) LIKE @TuKhoa
                   OR CONVERT(VARCHAR(4), Nam) LIKE @TuKhoa
                ORDER BY Nam DESC, Thang DESC",
                Db.P("@TuKhoa", "%" + (tuKhoa ?? "").Trim() + "%"));
        }

        public bool KiemTraTonTai(string maBangLuong)
        {
            if (string.IsNullOrWhiteSpace(maBangLuong))
                return false;

            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM BangLuong
                WHERE MaBangLuong = @Ma",
                Db.P("@Ma", maBangLuong.Trim()))) > 0;
        }

        public bool KiemTraTrungThang(
            int thang, int nam, string maBangLuong)
        {
            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM BangLuong
                WHERE Thang = @Thang
                  AND Nam = @Nam
                  AND MaBangLuong <> @Ma",
                Db.P("@Thang", thang),
                Db.P("@Nam", nam),
                Db.P("@Ma", maBangLuong.Trim()))) > 0;
        }

        public int Them(
            string maBangLuong, int thang, int nam,
            DateTime ngayLap, string nguoiLap,
            decimal tongTienLuong, string trangThai)
        {
            KiemTraBang(
                maBangLuong, thang, nam,
                nguoiLap, tongTienLuong, trangThai);

            if (KiemTraTonTai(maBangLuong))
                throw new Exception("Mã bảng lương đã tồn tại.");

            if (KiemTraTrungThang(thang, nam, maBangLuong))
                throw new Exception("Đã có bảng lương cho tháng/năm này.");

            return Db.Execute(@"
                INSERT INTO BangLuong
                (MaBangLuong, Thang, Nam, NgayLap,
                 NguoiLap, TongTienLuong, TrangThai)
                VALUES
                (@Ma, @Thang, @Nam, @NgayLap,
                 @NguoiLap, @TongTien, @TrangThai)",
                Db.P("@Ma", maBangLuong.Trim()),
                Db.P("@Thang", thang),
                Db.P("@Nam", nam),
                Db.P("@NgayLap", ngayLap.Date),
                Db.P("@NguoiLap", nguoiLap.Trim()),
                Db.P("@TongTien", tongTienLuong),
                Db.P("@TrangThai", trangThai));
        }

        public int Sua(
            string maBangLuong, int thang, int nam,
            DateTime ngayLap, string nguoiLap,
            decimal tongTienLuong, string trangThai)
        {
            KiemTraBang(
                maBangLuong, thang, nam,
                nguoiLap, tongTienLuong, trangThai);

            if (KiemTraTrungThang(thang, nam, maBangLuong))
                throw new Exception(
                    "Đã có bảng lương khác cho tháng/năm này.");

            return Db.Execute(@"
                UPDATE BangLuong
                SET Thang = @Thang,
                    Nam = @Nam,
                    NgayLap = @NgayLap,
                    NguoiLap = @NguoiLap,
                    TongTienLuong = @TongTien,
                    TrangThai = @TrangThai
                WHERE MaBangLuong = @Ma",
                Db.P("@Ma", maBangLuong.Trim()),
                Db.P("@Thang", thang),
                Db.P("@Nam", nam),
                Db.P("@NgayLap", ngayLap.Date),
                Db.P("@NguoiLap", nguoiLap.Trim()),
                Db.P("@TongTien", tongTienLuong),
                Db.P("@TrangThai", trangThai));
        }

        public int Xoa(string maBangLuong)
        {
            if (string.IsNullOrWhiteSpace(maBangLuong))
                throw new Exception("Vui lòng chọn bảng lương cần xóa.");

            return Db.Execute(@"
                DELETE FROM BangLuong
                WHERE MaBangLuong = @Ma",
                Db.P("@Ma", maBangLuong.Trim()));
        }

        private void KiemTraBang(
            string maBangLuong, int thang, int nam,
            string nguoiLap, decimal tongTienLuong, string trangThai)
        {
            if (string.IsNullOrWhiteSpace(maBangLuong))
                throw new Exception("Vui lòng nhập mã bảng lương.");

            if (maBangLuong.Trim().Length > 20)
                throw new Exception("Mã bảng lương tối đa 20 ký tự.");

            if (thang < 1 || thang > 12)
                throw new Exception("Tháng phải từ 1 đến 12.");

            if (nam < 2000 || nam > 2100)
                throw new Exception("Năm phải từ 2000 đến 2100.");

            if (string.IsNullOrWhiteSpace(nguoiLap))
                throw new Exception("Vui lòng nhập người lập.");

            if (nguoiLap.Trim().Length > 100)
                throw new Exception("Người lập tối đa 100 ký tự.");

            if (tongTienLuong < 0)
                throw new Exception("Tổng tiền lương không được âm.");

            if (decimal.Round(tongTienLuong, 2) != tongTienLuong)
                throw new Exception("Tổng tiền lương tối đa 2 số thập phân.");

            if (trangThai != "Đã lập" &&
                trangThai != "Đã tính" &&
                trangThai != "Đã thanh toán")
                throw new Exception("Trạng thái bảng lương không hợp lệ.");
        }

        public DataTable LayDanhSachChiTiet()
        {
            return Db.Query(@"
                SELECT ct.MaChiTietLuong, ct.MaBangLuong,
                       ct.MaNV, nv.HoTen, ct.LuongCoBan,
                       ct.SoNgayCong, ct.PhuCapLuong,
                       ct.PhuCapChucVu, ct.PhuCapDocHai,
                       ct.TienPhuTroi, ct.TienThuong,
                       ct.TienPhat, ct.TienBHXH,
                       ct.TienBHYT, ct.ThucLanh
                FROM ChiTietBangLuong ct
                INNER JOIN NhanVien nv ON ct.MaNV = nv.MaNV
                ORDER BY ct.MaBangLuong DESC, ct.MaNV");
        }

        public DataTable LayBangLuong()
        {
            return Db.Query(@"
                SELECT MaBangLuong,
                       MaBangLuong + N' - Tháng ' +
                       CONVERT(NVARCHAR(2), Thang) + N'/' +
                       CONVERT(NVARCHAR(4), Nam) AS TenBang
                FROM BangLuong
                ORDER BY Nam DESC, Thang DESC");
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
                SELECT ct.MaChiTietLuong, ct.MaBangLuong,
                       ct.MaNV, nv.HoTen, ct.LuongCoBan,
                       ct.SoNgayCong, ct.PhuCapLuong,
                       ct.PhuCapChucVu, ct.PhuCapDocHai,
                       ct.TienPhuTroi, ct.TienThuong,
                       ct.TienPhat, ct.TienBHXH,
                       ct.TienBHYT, ct.ThucLanh
                FROM ChiTietBangLuong ct
                INNER JOIN NhanVien nv ON ct.MaNV = nv.MaNV
                WHERE ct.MaChiTietLuong LIKE @TuKhoa
                   OR ct.MaBangLuong LIKE @TuKhoa
                   OR ct.MaNV LIKE @TuKhoa
                   OR nv.HoTen LIKE @TuKhoa
                ORDER BY ct.MaBangLuong DESC, ct.MaNV",
                Db.P("@TuKhoa", "%" + (tuKhoa ?? "").Trim() + "%"));
        }

        public bool KiemTraChiTietTonTai(string maChiTiet)
        {
            if (string.IsNullOrWhiteSpace(maChiTiet))
                return false;

            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM ChiTietBangLuong
                WHERE MaChiTietLuong = @Ma",
                Db.P("@Ma", maChiTiet.Trim()))) > 0;
        }

        public bool KiemTraTrungNhanVien(
            string maBangLuong, string maNV, string maChiTiet)
        {
            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM ChiTietBangLuong
                WHERE MaBangLuong = @MaBang
                  AND MaNV = @MaNV
                  AND MaChiTietLuong <> @Ma",
                Db.P("@MaBang", maBangLuong),
                Db.P("@MaNV", maNV),
                Db.P("@Ma", maChiTiet.Trim()))) > 0;
        }

        private void KiemTraChiTiet(
            string maChiTiet, string maBangLuong, string maNV,
            decimal luongCoBan, decimal soNgayCong,
            decimal phuCapLuong, decimal phuCapChucVu,
            decimal phuCapDocHai, decimal tienPhuTroi,
            decimal tienThuong, decimal tienPhat,
            decimal tienBHXH, decimal tienBHYT, decimal thucLanh)
        {
            if (string.IsNullOrWhiteSpace(maChiTiet))
                throw new Exception("Vui lòng nhập mã chi tiết lương.");

            if (maChiTiet.Trim().Length > 20)
                throw new Exception("Mã chi tiết tối đa 20 ký tự.");

            if (string.IsNullOrWhiteSpace(maBangLuong))
                throw new Exception("Vui lòng chọn bảng lương.");

            if (string.IsNullOrWhiteSpace(maNV))
                throw new Exception("Vui lòng chọn nhân viên.");

            if (soNgayCong < 0 || soNgayCong > 31)
                throw new Exception("Số ngày công phải từ 0 đến 31.");

            decimal[] cacKhoan = {
                luongCoBan, phuCapLuong, phuCapChucVu,
                phuCapDocHai, tienPhuTroi, tienThuong,
                tienPhat, tienBHXH, tienBHYT, thucLanh
            };

            foreach (decimal soTien in cacKhoan)
            {
                if (soTien < 0)
                    throw new Exception("Các khoản tiền không được âm.");

                if (decimal.Round(soTien, 2) != soTien)
                    throw new Exception(
                        "Các khoản tiền tối đa 2 chữ số thập phân.");
            }

            if (decimal.Round(soNgayCong, 2) != soNgayCong)
                throw new Exception(
                    "Số ngày công tối đa 2 chữ số thập phân.");
        }

        public int ThemChiTiet(
            string maChiTiet, string maBangLuong, string maNV,
            decimal luongCoBan, decimal soNgayCong,
            decimal phuCapLuong, decimal phuCapChucVu,
            decimal phuCapDocHai, decimal tienPhuTroi,
            decimal tienThuong, decimal tienPhat,
            decimal tienBHXH, decimal tienBHYT, decimal thucLanh)
        {
            KiemTraChiTiet(
                maChiTiet, maBangLuong, maNV,
                luongCoBan, soNgayCong, phuCapLuong,
                phuCapChucVu, phuCapDocHai, tienPhuTroi,
                tienThuong, tienPhat, tienBHXH,
                tienBHYT, thucLanh);

            if (KiemTraChiTietTonTai(maChiTiet))
                throw new Exception("Mã chi tiết lương đã tồn tại.");

            if (KiemTraTrungNhanVien(maBangLuong, maNV, maChiTiet))
                throw new Exception(
                    "Nhân viên đã có trong bảng lương này.");

            return Db.Execute(@"
                SET XACT_ABORT ON;
                BEGIN TRANSACTION;

                INSERT INTO ChiTietBangLuong
                (
                    MaChiTietLuong, MaBangLuong, MaNV,
                    LuongCoBan, SoNgayCong, PhuCapLuong,
                    PhuCapChucVu, PhuCapDocHai, TienPhuTroi,
                    TienThuong, TienPhat, TienBHXH,
                    TienBHYT, ThucLanh
                )
                VALUES
                (
                    @Ma, @MaBang, @MaNV,
                    @LuongCoBan, @SoNgayCong, @PhuCapLuong,
                    @PhuCapChucVu, @PhuCapDocHai, @TienPhuTroi,
                    @TienThuong, @TienPhat, @TienBHXH,
                    @TienBHYT, @ThucLanh
                );

                UPDATE BangLuong
                SET TongTienLuong = (
                    SELECT ISNULL(SUM(ThucLanh), 0)
                    FROM ChiTietBangLuong
                    WHERE MaBangLuong = @MaBang
                )
                WHERE MaBangLuong = @MaBang;

                COMMIT TRANSACTION;",
                Db.P("@Ma", maChiTiet.Trim()),
                Db.P("@MaBang", maBangLuong),
                Db.P("@MaNV", maNV),
                Db.P("@LuongCoBan", luongCoBan),
                Db.P("@SoNgayCong", soNgayCong),
                Db.P("@PhuCapLuong", phuCapLuong),
                Db.P("@PhuCapChucVu", phuCapChucVu),
                Db.P("@PhuCapDocHai", phuCapDocHai),
                Db.P("@TienPhuTroi", tienPhuTroi),
                Db.P("@TienThuong", tienThuong),
                Db.P("@TienPhat", tienPhat),
                Db.P("@TienBHXH", tienBHXH),
                Db.P("@TienBHYT", tienBHYT),
                Db.P("@ThucLanh", thucLanh));
        }

        public int SuaChiTiet(
            string maChiTiet, string maBangLuong, string maNV,
            decimal luongCoBan, decimal soNgayCong,
            decimal phuCapLuong, decimal phuCapChucVu,
            decimal phuCapDocHai, decimal tienPhuTroi,
            decimal tienThuong, decimal tienPhat,
            decimal tienBHXH, decimal tienBHYT, decimal thucLanh)
        {
            KiemTraChiTiet(
                maChiTiet, maBangLuong, maNV,
                luongCoBan, soNgayCong, phuCapLuong,
                phuCapChucVu, phuCapDocHai, tienPhuTroi,
                tienThuong, tienPhat, tienBHXH,
                tienBHYT, thucLanh);

            if (KiemTraTrungNhanVien(maBangLuong, maNV, maChiTiet))
                throw new Exception(
                    "Nhân viên đã có trong bảng lương này.");

            return Db.Execute(@"
                SET XACT_ABORT ON;
                BEGIN TRANSACTION;

                DECLARE @MaBangCu VARCHAR(20);

                SELECT @MaBangCu = MaBangLuong
                FROM ChiTietBangLuong
                WHERE MaChiTietLuong = @Ma;

                IF @MaBangCu IS NULL
                BEGIN
                    ROLLBACK TRANSACTION;
                    RETURN;
                END;

                UPDATE ChiTietBangLuong
                SET MaBangLuong = @MaBang,
                    MaNV = @MaNV,
                    LuongCoBan = @LuongCoBan,
                    SoNgayCong = @SoNgayCong,
                    PhuCapLuong = @PhuCapLuong,
                    PhuCapChucVu = @PhuCapChucVu,
                    PhuCapDocHai = @PhuCapDocHai,
                    TienPhuTroi = @TienPhuTroi,
                    TienThuong = @TienThuong,
                    TienPhat = @TienPhat,
                    TienBHXH = @TienBHXH,
                    TienBHYT = @TienBHYT,
                    ThucLanh = @ThucLanh
                WHERE MaChiTietLuong = @Ma;

                UPDATE b
                SET TongTienLuong = (
                    SELECT ISNULL(SUM(ct.ThucLanh), 0)
                    FROM ChiTietBangLuong ct
                    WHERE ct.MaBangLuong = b.MaBangLuong
                )
                FROM BangLuong b
                WHERE b.MaBangLuong IN (@MaBangCu, @MaBang);

                COMMIT TRANSACTION;",
                Db.P("@Ma", maChiTiet.Trim()),
                Db.P("@MaBang", maBangLuong),
                Db.P("@MaNV", maNV),
                Db.P("@LuongCoBan", luongCoBan),
                Db.P("@SoNgayCong", soNgayCong),
                Db.P("@PhuCapLuong", phuCapLuong),
                Db.P("@PhuCapChucVu", phuCapChucVu),
                Db.P("@PhuCapDocHai", phuCapDocHai),
                Db.P("@TienPhuTroi", tienPhuTroi),
                Db.P("@TienThuong", tienThuong),
                Db.P("@TienPhat", tienPhat),
                Db.P("@TienBHXH", tienBHXH),
                Db.P("@TienBHYT", tienBHYT),
                Db.P("@ThucLanh", thucLanh));
        }

        public int XoaChiTiet(string maChiTiet)
        {
            if (string.IsNullOrWhiteSpace(maChiTiet))
                throw new Exception("Vui lòng chọn chi tiết lương cần xóa.");

            return Db.Execute(@"
                SET XACT_ABORT ON;
                BEGIN TRANSACTION;

                DECLARE @MaBang VARCHAR(20);

                SELECT @MaBang = MaBangLuong
                FROM ChiTietBangLuong
                WHERE MaChiTietLuong = @Ma;

                IF @MaBang IS NULL
                BEGIN
                    ROLLBACK TRANSACTION;
                    RETURN;
                END;

                DELETE FROM ChiTietBangLuong
                WHERE MaChiTietLuong = @Ma;

                UPDATE BangLuong
                SET TongTienLuong = (
                    SELECT ISNULL(SUM(ThucLanh), 0)
                    FROM ChiTietBangLuong
                    WHERE MaBangLuong = @MaBang
                )
                WHERE MaBangLuong = @MaBang;

                COMMIT TRANSACTION;",
                Db.P("@Ma", maChiTiet.Trim()));
        }
    }
}