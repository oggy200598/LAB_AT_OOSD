using System;
using System.Data;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class KhenThuongService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(@"
                SELECT q.MaQDKT, q.SoQuyetDinh, q.NgayQuyetDinh,
                       q.LoaiDoiTuong, q.MaNV, nv.HoTen,
                       q.MaPhongBan, p.TenPhongBan,
                       q.LyDoKhenThuong, q.SoTienThuong, q.NguoiKy
                FROM QuyetDinhKhenThuong q
                LEFT JOIN NhanVien nv ON q.MaNV = nv.MaNV
                LEFT JOIN PhongBan p ON q.MaPhongBan = p.MaPhongBan
                ORDER BY q.NgayQuyetDinh DESC, q.MaQDKT");
        }

        public DataTable LayNhanVien()
        {
            return Db.Query(@"
                SELECT MaNV, MaNV + N' - ' + HoTen AS TenNhanVien
                FROM NhanVien
                ORDER BY MaNV");
        }

        public DataTable LayPhongBan()
        {
            return Db.Query(@"
                SELECT MaPhongBan, TenPhongBan
                FROM PhongBan
                ORDER BY TenPhongBan");
        }

        public DataTable TimKiem(string tuKhoa)
        {
            return Db.Query(@"
                SELECT q.MaQDKT, q.SoQuyetDinh, q.NgayQuyetDinh,
                       q.LoaiDoiTuong, q.MaNV, nv.HoTen,
                       q.MaPhongBan, p.TenPhongBan,
                       q.LyDoKhenThuong, q.SoTienThuong, q.NguoiKy
                FROM QuyetDinhKhenThuong q
                LEFT JOIN NhanVien nv ON q.MaNV = nv.MaNV
                LEFT JOIN PhongBan p ON q.MaPhongBan = p.MaPhongBan
                WHERE q.MaQDKT LIKE @TuKhoa
                   OR q.SoQuyetDinh LIKE @TuKhoa
                   OR q.LoaiDoiTuong LIKE @TuKhoa
                   OR q.MaNV LIKE @TuKhoa
                   OR nv.HoTen LIKE @TuKhoa
                   OR q.MaPhongBan LIKE @TuKhoa
                   OR p.TenPhongBan LIKE @TuKhoa
                   OR q.LyDoKhenThuong LIKE @TuKhoa
                   OR q.NguoiKy LIKE @TuKhoa
                ORDER BY q.NgayQuyetDinh DESC, q.MaQDKT",
                Db.P("@TuKhoa", "%" + (tuKhoa ?? "").Trim() + "%"));
        }

        public bool KiemTraTonTai(string maQDKT)
        {
            if (string.IsNullOrWhiteSpace(maQDKT))
                return false;

            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM QuyetDinhKhenThuong
                WHERE MaQDKT = @Ma",
                Db.P("@Ma", maQDKT.Trim()))) > 0;
        }

        public bool KiemTraTrungSoQuyetDinh(
            string soQuyetDinh, string maQDKT)
        {
            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM QuyetDinhKhenThuong
                WHERE SoQuyetDinh = @SoQuyetDinh
                  AND MaQDKT <> @Ma",
                Db.P("@SoQuyetDinh", soQuyetDinh.Trim()),
                Db.P("@Ma", maQDKT.Trim()))) > 0;
        }

        public int Them(
            string maQDKT,
            string soQuyetDinh,
            DateTime ngayQuyetDinh,
            string loaiDoiTuong,
            string maNV,
            string maPhongBan,
            string lyDo,
            decimal soTienThuong,
            string nguoiKy)
        {
            KiemTraQuyetDinh(
                maQDKT, soQuyetDinh, loaiDoiTuong,
                maNV, maPhongBan, lyDo, soTienThuong, nguoiKy);

            if (KiemTraTonTai(maQDKT))
                throw new Exception("Mã quyết định đã tồn tại.");

            if (KiemTraTrungSoQuyetDinh(soQuyetDinh, maQDKT))
                throw new Exception("Số quyết định đã tồn tại.");

            return Db.Execute(@"
                INSERT INTO QuyetDinhKhenThuong
                (
                    MaQDKT, SoQuyetDinh, NgayQuyetDinh,
                    LoaiDoiTuong, MaNV, MaPhongBan,
                    LyDoKhenThuong, SoTienThuong, NguoiKy
                )
                VALUES
                (
                    @MaQDKT, @SoQuyetDinh, @NgayQuyetDinh,
                    @LoaiDoiTuong, @MaNV, @MaPhongBan,
                    @LyDo, @SoTienThuong, @NguoiKy
                )",
                Db.P("@MaQDKT", maQDKT.Trim()),
                Db.P("@SoQuyetDinh", soQuyetDinh.Trim()),
                Db.P("@NgayQuyetDinh", ngayQuyetDinh.Date),
                Db.P("@LoaiDoiTuong", loaiDoiTuong),
                Db.P("@MaNV", string.IsNullOrWhiteSpace(maNV)
                    ? (object)DBNull.Value : maNV),
                Db.P("@MaPhongBan", string.IsNullOrWhiteSpace(maPhongBan)
                    ? (object)DBNull.Value : maPhongBan),
                Db.P("@LyDo", lyDo.Trim()),
                Db.P("@SoTienThuong", soTienThuong),
                Db.P("@NguoiKy", nguoiKy.Trim()));
        }

        public int Sua(
            string maQDKT,
            string soQuyetDinh,
            DateTime ngayQuyetDinh,
            string loaiDoiTuong,
            string maNV,
            string maPhongBan,
            string lyDo,
            decimal soTienThuong,
            string nguoiKy)
        {
            KiemTraQuyetDinh(
                maQDKT, soQuyetDinh, loaiDoiTuong,
                maNV, maPhongBan, lyDo, soTienThuong, nguoiKy);

            if (KiemTraTrungSoQuyetDinh(soQuyetDinh, maQDKT))
                throw new Exception("Số quyết định đã tồn tại.");

            return Db.Execute(@"
                UPDATE QuyetDinhKhenThuong
                SET SoQuyetDinh = @SoQuyetDinh,
                    NgayQuyetDinh = @NgayQuyetDinh,
                    LoaiDoiTuong = @LoaiDoiTuong,
                    MaNV = @MaNV,
                    MaPhongBan = @MaPhongBan,
                    LyDoKhenThuong = @LyDo,
                    SoTienThuong = @SoTienThuong,
                    NguoiKy = @NguoiKy
                WHERE MaQDKT = @MaQDKT",
                Db.P("@MaQDKT", maQDKT.Trim()),
                Db.P("@SoQuyetDinh", soQuyetDinh.Trim()),
                Db.P("@NgayQuyetDinh", ngayQuyetDinh.Date),
                Db.P("@LoaiDoiTuong", loaiDoiTuong),
                Db.P("@MaNV", string.IsNullOrWhiteSpace(maNV)
                    ? (object)DBNull.Value : maNV),
                Db.P("@MaPhongBan", string.IsNullOrWhiteSpace(maPhongBan)
                    ? (object)DBNull.Value : maPhongBan),
                Db.P("@LyDo", lyDo.Trim()),
                Db.P("@SoTienThuong", soTienThuong),
                Db.P("@NguoiKy", nguoiKy.Trim()));
        }

        public int Xoa(string maQDKT)
        {
            if (string.IsNullOrWhiteSpace(maQDKT))
                throw new Exception("Vui lòng chọn quyết định cần xóa.");

            return Db.Execute(@"
                DELETE FROM QuyetDinhKhenThuong
                WHERE MaQDKT = @MaQDKT",
                Db.P("@MaQDKT", maQDKT.Trim()));
        }

        private void KiemTraQuyetDinh(
            string maQDKT,
            string soQuyetDinh,
            string loaiDoiTuong,
            string maNV,
            string maPhongBan,
            string lyDo,
            decimal soTienThuong,
            string nguoiKy)
        {
            if (string.IsNullOrWhiteSpace(maQDKT))
                throw new Exception("Vui lòng nhập mã quyết định.");

            if (maQDKT.Trim().Length > 20)
                throw new Exception("Mã quyết định tối đa 20 ký tự.");

            if (string.IsNullOrWhiteSpace(soQuyetDinh))
                throw new Exception("Vui lòng nhập số quyết định.");

            if (soQuyetDinh.Trim().Length > 30)
                throw new Exception("Số quyết định tối đa 30 ký tự.");

            if (loaiDoiTuong == "Cá nhân")
            {
                if (string.IsNullOrWhiteSpace(maNV))
                    throw new Exception("Vui lòng chọn nhân viên.");

                if (!string.IsNullOrWhiteSpace(maPhongBan))
                    throw new Exception(
                        "Khen thưởng cá nhân không chọn phòng ban.");
            }
            else if (loaiDoiTuong == "Tập thể")
            {
                if (string.IsNullOrWhiteSpace(maPhongBan))
                    throw new Exception("Vui lòng chọn phòng ban.");

                if (!string.IsNullOrWhiteSpace(maNV))
                    throw new Exception(
                        "Khen thưởng tập thể không chọn nhân viên.");
            }
            else
            {
                throw new Exception("Loại đối tượng không hợp lệ.");
            }

            if (string.IsNullOrWhiteSpace(lyDo))
                throw new Exception("Vui lòng nhập lý do khen thưởng.");

            if (lyDo.Trim().Length > 500)
                throw new Exception("Lý do tối đa 500 ký tự.");

            if (soTienThuong < 0)
                throw new Exception("Số tiền thưởng không được âm.");

            if (decimal.Round(soTienThuong, 2) != soTienThuong)
                throw new Exception(
                    "Số tiền thưởng có tối đa 2 chữ số thập phân.");

            if (string.IsNullOrWhiteSpace(nguoiKy))
                throw new Exception("Vui lòng nhập người ký.");

            if (nguoiKy.Trim().Length > 100)
                throw new Exception("Người ký tối đa 100 ký tự.");
        }

        public DataTable LayDanhSachPhieuChi()
        {
            return Db.Query(@"
                SELECT pc.MaPhieuChi, pc.MaQDKT,
                       q.SoQuyetDinh, q.SoTienThuong,
                       pc.NgayChi, pc.SoTienChi,
                       pc.NguoiLap, pc.HinhThucChi, pc.GhiChu
                FROM PhieuChiKhenThuong pc
                INNER JOIN QuyetDinhKhenThuong q
                    ON pc.MaQDKT = q.MaQDKT
                ORDER BY pc.NgayChi DESC, pc.MaPhieuChi");
        }

        public DataTable LayQuyetDinhKhenThuong()
        {
            return Db.Query(@"
                SELECT MaQDKT,
                       MaQDKT + N' - ' + SoQuyetDinh AS TenQuyetDinh,
                       SoTienThuong
                FROM QuyetDinhKhenThuong
                ORDER BY NgayQuyetDinh DESC, MaQDKT");
        }

        public DataTable TimKiemPhieuChi(string tuKhoa)
        {
            return Db.Query(@"
                SELECT pc.MaPhieuChi, pc.MaQDKT,
                       q.SoQuyetDinh, q.SoTienThuong,
                       pc.NgayChi, pc.SoTienChi,
                       pc.NguoiLap, pc.HinhThucChi, pc.GhiChu
                FROM PhieuChiKhenThuong pc
                INNER JOIN QuyetDinhKhenThuong q
                    ON pc.MaQDKT = q.MaQDKT
                WHERE pc.MaPhieuChi LIKE @TuKhoa
                   OR pc.MaQDKT LIKE @TuKhoa
                   OR q.SoQuyetDinh LIKE @TuKhoa
                   OR pc.NguoiLap LIKE @TuKhoa
                   OR pc.HinhThucChi LIKE @TuKhoa
                   OR pc.GhiChu LIKE @TuKhoa
                ORDER BY pc.NgayChi DESC, pc.MaPhieuChi",
                Db.P("@TuKhoa", "%" + (tuKhoa ?? "").Trim() + "%"));
        }

        public bool KiemTraPhieuChiTonTai(string maPhieuChi)
        {
            if (string.IsNullOrWhiteSpace(maPhieuChi))
                return false;

            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM PhieuChiKhenThuong
                WHERE MaPhieuChi = @MaPhieuChi",
                Db.P("@MaPhieuChi", maPhieuChi.Trim()))) > 0;
        }

        public bool KiemTraQuyetDinhDaChi(
            string maQDKT, string maPhieuChi)
        {
            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM PhieuChiKhenThuong
                WHERE MaQDKT = @MaQDKT
                  AND MaPhieuChi <> @MaPhieuChi",
                Db.P("@MaQDKT", maQDKT),
                Db.P("@MaPhieuChi", maPhieuChi.Trim()))) > 0;
        }

        public decimal LaySoTienThuong(string maQDKT)
        {
            if (string.IsNullOrWhiteSpace(maQDKT))
                throw new Exception("Vui lòng chọn quyết định khen thưởng.");

            object ketQua = Db.Scalar(@"
                SELECT SoTienThuong
                FROM QuyetDinhKhenThuong
                WHERE MaQDKT = @MaQDKT",
                Db.P("@MaQDKT", maQDKT));

            if (ketQua == null || ketQua == DBNull.Value)
                throw new Exception("Không tìm thấy quyết định khen thưởng.");

            return Convert.ToDecimal(ketQua);
        }

        public int ThemPhieuChi(
            string maPhieuChi,
            string maQDKT,
            DateTime ngayChi,
            decimal soTienChi,
            string nguoiLap,
            string hinhThucChi,
            string ghiChu)
        {
            KiemTraPhieuChi(
                maPhieuChi, maQDKT, soTienChi,
                nguoiLap, hinhThucChi, ghiChu);

            if (KiemTraPhieuChiTonTai(maPhieuChi))
                throw new Exception("Mã phiếu chi đã tồn tại.");

            if (KiemTraQuyetDinhDaChi(maQDKT, maPhieuChi))
                throw new Exception(
                    "Quyết định khen thưởng này đã có phiếu chi.");

            return Db.Execute(@"
                INSERT INTO PhieuChiKhenThuong
                (
                    MaPhieuChi, MaQDKT, NgayChi,
                    SoTienChi, NguoiLap, HinhThucChi, GhiChu
                )
                VALUES
                (
                    @MaPhieuChi, @MaQDKT, @NgayChi,
                    @SoTienChi, @NguoiLap, @HinhThucChi, @GhiChu
                )",
                Db.P("@MaPhieuChi", maPhieuChi.Trim()),
                Db.P("@MaQDKT", maQDKT),
                Db.P("@NgayChi", ngayChi.Date),
                Db.P("@SoTienChi", soTienChi),
                Db.P("@NguoiLap", nguoiLap.Trim()),
                Db.P("@HinhThucChi", hinhThucChi),
                Db.P("@GhiChu", string.IsNullOrWhiteSpace(ghiChu)
                    ? (object)DBNull.Value : ghiChu));
        }

        public int SuaPhieuChi(
            string maPhieuChi,
            string maQDKT,
            DateTime ngayChi,
            decimal soTienChi,
            string nguoiLap,
            string hinhThucChi,
            string ghiChu)
        {
            KiemTraPhieuChi(
                maPhieuChi, maQDKT, soTienChi,
                nguoiLap, hinhThucChi, ghiChu);

            if (KiemTraQuyetDinhDaChi(maQDKT, maPhieuChi))
                throw new Exception(
                    "Quyết định khen thưởng này đã có phiếu chi khác.");

            return Db.Execute(@"
                UPDATE PhieuChiKhenThuong
                SET MaQDKT = @MaQDKT,
                    NgayChi = @NgayChi,
                    SoTienChi = @SoTienChi,
                    NguoiLap = @NguoiLap,
                    HinhThucChi = @HinhThucChi,
                    GhiChu = @GhiChu
                WHERE MaPhieuChi = @MaPhieuChi",
                Db.P("@MaPhieuChi", maPhieuChi.Trim()),
                Db.P("@MaQDKT", maQDKT),
                Db.P("@NgayChi", ngayChi.Date),
                Db.P("@SoTienChi", soTienChi),
                Db.P("@NguoiLap", nguoiLap.Trim()),
                Db.P("@HinhThucChi", hinhThucChi),
                Db.P("@GhiChu", string.IsNullOrWhiteSpace(ghiChu)
                    ? (object)DBNull.Value : ghiChu));
        }

        public int XoaPhieuChi(string maPhieuChi)
        {
            if (string.IsNullOrWhiteSpace(maPhieuChi))
                throw new Exception("Vui lòng chọn phiếu chi cần xóa.");

            return Db.Execute(@"
                DELETE FROM PhieuChiKhenThuong
                WHERE MaPhieuChi = @MaPhieuChi",
                Db.P("@MaPhieuChi", maPhieuChi.Trim()));
        }

        private void KiemTraPhieuChi(
            string maPhieuChi,
            string maQDKT,
            decimal soTienChi,
            string nguoiLap,
            string hinhThucChi,
            string ghiChu)
        {
            if (string.IsNullOrWhiteSpace(maPhieuChi))
                throw new Exception("Vui lòng nhập mã phiếu chi.");

            if (maPhieuChi.Trim().Length > 20)
                throw new Exception("Mã phiếu chi tối đa 20 ký tự.");

            if (string.IsNullOrWhiteSpace(maQDKT))
                throw new Exception("Vui lòng chọn quyết định khen thưởng.");

            if (string.IsNullOrWhiteSpace(nguoiLap))
                throw new Exception("Vui lòng nhập người lập.");

            if (nguoiLap.Trim().Length > 100)
                throw new Exception("Người lập tối đa 100 ký tự.");

            if (soTienChi < 0)
                throw new Exception("Số tiền chi không được âm.");

            if (decimal.Round(soTienChi, 2) != soTienChi)
                throw new Exception(
                    "Số tiền chi có tối đa 2 chữ số thập phân.");

            if (hinhThucChi != "Tiền mặt" &&
                hinhThucChi != "Chuyển khoản" &&
                hinhThucChi != "Qua lương")
                throw new Exception("Hình thức chi không hợp lệ.");

            if (!string.IsNullOrEmpty(ghiChu) && ghiChu.Length > 500)
                throw new Exception("Ghi chú tối đa 500 ký tự.");

            decimal soTienThuong = LaySoTienThuong(maQDKT);

            if (soTienChi > soTienThuong)
                throw new Exception(
                    "Số tiền chi không được vượt số tiền thưởng trong quyết định.");
        }
    }
}