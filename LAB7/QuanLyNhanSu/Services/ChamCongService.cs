
using System;
using System.Data;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class ChamCongService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(@"
                SELECT b.MaBangChamCong, b.MaPhongBan,
                       p.TenPhongBan, b.Thang, b.Nam,
                       b.NgayLap, b.NguoiLap, b.TrangThai
                FROM BangChamCong b
                INNER JOIN PhongBan p ON b.MaPhongBan = p.MaPhongBan
                ORDER BY b.Nam DESC, b.Thang DESC, b.MaBangChamCong");
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
                SELECT b.MaBangChamCong, b.MaPhongBan,
                       p.TenPhongBan, b.Thang, b.Nam,
                       b.NgayLap, b.NguoiLap, b.TrangThai
                FROM BangChamCong b
                INNER JOIN PhongBan p ON b.MaPhongBan = p.MaPhongBan
                WHERE b.MaBangChamCong LIKE @TuKhoa
                   OR p.TenPhongBan LIKE @TuKhoa
                   OR b.NguoiLap LIKE @TuKhoa
                   OR b.TrangThai LIKE @TuKhoa
                   OR CONVERT(VARCHAR(4), b.Nam) LIKE @TuKhoa
                   OR CONVERT(VARCHAR(2), b.Thang) LIKE @TuKhoa
                ORDER BY b.Nam DESC, b.Thang DESC",
                Db.P("@TuKhoa", "%" + (tuKhoa ?? "").Trim() + "%"));
        }

        public bool KiemTraTonTai(string maBangChamCong)
        {
            if (string.IsNullOrWhiteSpace(maBangChamCong))
                return false;

            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM BangChamCong
                WHERE MaBangChamCong = @Ma",
                Db.P("@Ma", maBangChamCong.Trim()))) > 0;
        }

        public bool KiemTraTrungBang(
            string maPhongBan, int thang, int nam, string maBangChamCong)
        {
            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM BangChamCong
                WHERE MaPhongBan = @MaPhongBan
                  AND Thang = @Thang
                  AND Nam = @Nam
                  AND MaBangChamCong <> @Ma",
                Db.P("@MaPhongBan", maPhongBan),
                Db.P("@Thang", thang),
                Db.P("@Nam", nam),
                Db.P("@Ma", maBangChamCong.Trim()))) > 0;
        }

        public int Them(
            string maBangChamCong, string maPhongBan,
            int thang, int nam, DateTime ngayLap,
            string nguoiLap, string trangThai)
        {
            KiemTraBang(
                maBangChamCong, maPhongBan, thang,
                nam, nguoiLap, trangThai);

            if (KiemTraTonTai(maBangChamCong))
                throw new Exception("Mã bảng chấm công đã tồn tại.");

            if (KiemTraTrungBang(maPhongBan, thang, nam, maBangChamCong))
                throw new Exception(
                    "Phòng ban đã có bảng chấm công cho tháng/năm này.");

            return Db.Execute(@"
                INSERT INTO BangChamCong
                (MaBangChamCong, MaPhongBan, Thang, Nam,
                 NgayLap, NguoiLap, TrangThai)
                VALUES
                (@Ma, @MaPhongBan, @Thang, @Nam,
                 @NgayLap, @NguoiLap, @TrangThai)",
                Db.P("@Ma", maBangChamCong.Trim()),
                Db.P("@MaPhongBan", maPhongBan),
                Db.P("@Thang", thang),
                Db.P("@Nam", nam),
                Db.P("@NgayLap", ngayLap.Date),
                Db.P("@NguoiLap", nguoiLap.Trim()),
                Db.P("@TrangThai", trangThai));
        }

        public int Sua(
            string maBangChamCong, string maPhongBan,
            int thang, int nam, DateTime ngayLap,
            string nguoiLap, string trangThai)
        {
            KiemTraBang(
                maBangChamCong, maPhongBan, thang,
                nam, nguoiLap, trangThai);

            if (KiemTraTrungBang(maPhongBan, thang, nam, maBangChamCong))
                throw new Exception(
                    "Phòng ban đã có bảng chấm công cho tháng/năm này.");

            return Db.Execute(@"
                UPDATE BangChamCong
                SET MaPhongBan = @MaPhongBan,
                    Thang = @Thang,
                    Nam = @Nam,
                    NgayLap = @NgayLap,
                    NguoiLap = @NguoiLap,
                    TrangThai = @TrangThai
                WHERE MaBangChamCong = @Ma",
                Db.P("@Ma", maBangChamCong.Trim()),
                Db.P("@MaPhongBan", maPhongBan),
                Db.P("@Thang", thang),
                Db.P("@Nam", nam),
                Db.P("@NgayLap", ngayLap.Date),
                Db.P("@NguoiLap", nguoiLap.Trim()),
                Db.P("@TrangThai", trangThai));
        }

        public int Xoa(string maBangChamCong)
        {
            if (string.IsNullOrWhiteSpace(maBangChamCong))
                throw new Exception("Vui lòng chọn bảng chấm công cần xóa.");

            return Db.Execute(
                "DELETE FROM BangChamCong WHERE MaBangChamCong = @Ma",
                Db.P("@Ma", maBangChamCong.Trim()));
        }

        private void KiemTraBang(
            string ma, string maPhongBan, int thang,
            int nam, string nguoiLap, string trangThai)
        {
            if (string.IsNullOrWhiteSpace(ma))
                throw new Exception("Vui lòng nhập mã bảng chấm công.");

            if (ma.Trim().Length > 20)
                throw new Exception("Mã bảng tối đa 20 ký tự.");

            if (string.IsNullOrWhiteSpace(maPhongBan))
                throw new Exception("Vui lòng chọn phòng ban.");

            if (thang < 1 || thang > 12)
                throw new Exception("Tháng phải từ 1 đến 12.");

            if (nam < 2000 || nam > 2100)
                throw new Exception("Năm phải từ 2000 đến 2100.");

            if (string.IsNullOrWhiteSpace(nguoiLap))
                throw new Exception("Vui lòng nhập người lập.");

            if (nguoiLap.Trim().Length > 100)
                throw new Exception("Người lập tối đa 100 ký tự.");

            if (trangThai != "Đã lập" &&
                trangThai != "Đang chấm công" &&
                trangThai != "Đã tổng hợp")
                throw new Exception("Trạng thái bảng không hợp lệ.");
        }

        public DataTable LayChiTietChamCong()
        {
            return Db.Query(@"
                SELECT ct.MaChiTietChamCong, ct.MaBangChamCong,
                       ct.MaNV, nv.HoTen, ct.NgayChamCong,
                       ct.MaCa, ca.TenCa, ct.GioVao, ct.GioRa,
                       ct.SoGioLam, ct.TrangThai
                FROM ChiTietChamCong ct
                INNER JOIN NhanVien nv ON ct.MaNV = nv.MaNV
                INNER JOIN CaLamViec ca ON ct.MaCa = ca.MaCa
                ORDER BY ct.NgayChamCong DESC, ct.MaChiTietChamCong");
        }

        public DataTable LayBangChamCong()
        {
            return Db.Query(@"
                SELECT b.MaBangChamCong,
                       b.MaBangChamCong + N' - ' + p.TenPhongBan +
                       N' - ' + CAST(b.Thang AS NVARCHAR(2)) +
                       N'/' + CAST(b.Nam AS NVARCHAR(4)) AS TenBang
                FROM BangChamCong b
                INNER JOIN PhongBan p ON b.MaPhongBan = p.MaPhongBan
                ORDER BY b.Nam DESC, b.Thang DESC");
        }

        public DataTable LayNhanVien()
        {
            return Db.Query(@"
                SELECT MaNV, MaNV + N' - ' + HoTen AS TenNhanVien
                FROM NhanVien
                ORDER BY MaNV");
        }

        public DataTable LayCaLamViec()
        {
            return Db.Query(@"
                SELECT MaCa, TenCa
                FROM CaLamViec
                ORDER BY MaCa");
        }

        public DataTable TimKiemChiTiet(string tuKhoa)
        {
            return Db.Query(@"
                SELECT ct.MaChiTietChamCong, ct.MaBangChamCong,
                       ct.MaNV, nv.HoTen, ct.NgayChamCong,
                       ct.MaCa, ca.TenCa, ct.GioVao, ct.GioRa,
                       ct.SoGioLam, ct.TrangThai
                FROM ChiTietChamCong ct
                INNER JOIN NhanVien nv ON ct.MaNV = nv.MaNV
                INNER JOIN CaLamViec ca ON ct.MaCa = ca.MaCa
                WHERE ct.MaChiTietChamCong LIKE @TuKhoa
                   OR ct.MaBangChamCong LIKE @TuKhoa
                   OR ct.MaNV LIKE @TuKhoa
                   OR nv.HoTen LIKE @TuKhoa
                   OR ca.TenCa LIKE @TuKhoa
                   OR ct.TrangThai LIKE @TuKhoa
                ORDER BY ct.NgayChamCong DESC",
                Db.P("@TuKhoa", "%" + (tuKhoa ?? "").Trim() + "%"));
        }

        public bool KiemTraChiTietTonTai(string maChiTiet)
        {
            if (string.IsNullOrWhiteSpace(maChiTiet))
                return false;

            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM ChiTietChamCong
                WHERE MaChiTietChamCong = @Ma",
                Db.P("@Ma", maChiTiet.Trim()))) > 0;
        }

        public bool KiemTraTrungChiTiet(
            string maNV, DateTime ngayChamCong,
            string maCa, string maChiTiet)
        {
            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM ChiTietChamCong
                WHERE MaNV = @MaNV
                  AND NgayChamCong = @Ngay
                  AND MaCa = @MaCa
                  AND MaChiTietChamCong <> @Ma",
                Db.P("@MaNV", maNV),
                Db.P("@Ngay", ngayChamCong.Date),
                Db.P("@MaCa", maCa),
                Db.P("@Ma", maChiTiet.Trim()))) > 0;
        }

        public int ThemChiTiet(
            string maChiTiet, string maBang, string maNV,
            DateTime ngayChamCong, string maCa,
            DateTime? gioVao, DateTime? gioRa,
            decimal soGioLam, string trangThai)
        {
            KiemTraChiTiet(
                maChiTiet, maBang, maNV, ngayChamCong, maCa,
                gioVao, gioRa, soGioLam, trangThai);

            if (KiemTraChiTietTonTai(maChiTiet))
                throw new Exception("Mã chi tiết chấm công đã tồn tại.");

            if (KiemTraTrungChiTiet(maNV, ngayChamCong, maCa, maChiTiet))
                throw new Exception(
                    "Nhân viên đã được chấm công cho ngày và ca này.");

            return Db.Execute(@"
                INSERT INTO ChiTietChamCong
                (MaChiTietChamCong, MaBangChamCong, MaNV,
                 NgayChamCong, MaCa, GioVao, GioRa,
                 SoGioLam, TrangThai)
                VALUES
                (@Ma, @MaBang, @MaNV, @Ngay, @MaCa,
                 @GioVao, @GioRa, @SoGioLam, @TrangThai)",
                Db.P("@Ma", maChiTiet.Trim()),
                Db.P("@MaBang", maBang),
                Db.P("@MaNV", maNV),
                Db.P("@Ngay", ngayChamCong.Date),
                Db.P("@MaCa", maCa),
                Db.P("@GioVao", gioVao.HasValue
                    ? (object)gioVao.Value : DBNull.Value),
                Db.P("@GioRa", gioRa.HasValue
                    ? (object)gioRa.Value : DBNull.Value),
                Db.P("@SoGioLam", soGioLam),
                Db.P("@TrangThai", trangThai));
        }

        public int SuaChiTiet(
            string maChiTiet, string maBang, string maNV,
            DateTime ngayChamCong, string maCa,
            DateTime? gioVao, DateTime? gioRa,
            decimal soGioLam, string trangThai)
        {
            KiemTraChiTiet(
                maChiTiet, maBang, maNV, ngayChamCong, maCa,
                gioVao, gioRa, soGioLam, trangThai);

            if (KiemTraTrungChiTiet(maNV, ngayChamCong, maCa, maChiTiet))
                throw new Exception(
                    "Nhân viên đã được chấm công cho ngày và ca này.");

            return Db.Execute(@"
                UPDATE ChiTietChamCong
                SET MaBangChamCong = @MaBang,
                    MaNV = @MaNV,
                    NgayChamCong = @Ngay,
                    MaCa = @MaCa,
                    GioVao = @GioVao,
                    GioRa = @GioRa,
                    SoGioLam = @SoGioLam,
                    TrangThai = @TrangThai
                WHERE MaChiTietChamCong = @Ma",
                Db.P("@Ma", maChiTiet.Trim()),
                Db.P("@MaBang", maBang),
                Db.P("@MaNV", maNV),
                Db.P("@Ngay", ngayChamCong.Date),
                Db.P("@MaCa", maCa),
                Db.P("@GioVao", gioVao.HasValue
                    ? (object)gioVao.Value : DBNull.Value),
                Db.P("@GioRa", gioRa.HasValue
                    ? (object)gioRa.Value : DBNull.Value),
                Db.P("@SoGioLam", soGioLam),
                Db.P("@TrangThai", trangThai));
        }

        public int XoaChiTiet(string maChiTiet)
        {
            if (string.IsNullOrWhiteSpace(maChiTiet))
                throw new Exception("Vui lòng chọn chi tiết cần xóa.");

            return Db.Execute(@"
                DELETE FROM ChiTietChamCong
                WHERE MaChiTietChamCong = @Ma",
                Db.P("@Ma", maChiTiet.Trim()));
        }

        private void KiemTraChiTiet(
            string maChiTiet, string maBang, string maNV,
            DateTime ngayChamCong, string maCa,
            DateTime? gioVao, DateTime? gioRa,
            decimal soGioLam, string trangThai)
        {
            if (string.IsNullOrWhiteSpace(maChiTiet))
                throw new Exception("Vui lòng nhập mã chi tiết.");

            if (maChiTiet.Trim().Length > 20)
                throw new Exception("Mã chi tiết tối đa 20 ký tự.");

            if (string.IsNullOrWhiteSpace(maBang))
                throw new Exception("Vui lòng chọn bảng chấm công.");

            if (string.IsNullOrWhiteSpace(maNV))
                throw new Exception("Vui lòng chọn nhân viên.");

            if (string.IsNullOrWhiteSpace(maCa))
                throw new Exception("Vui lòng chọn ca làm việc.");

            if (soGioLam < 0 || soGioLam > 24)
                throw new Exception("Số giờ làm phải từ 0 đến 24.");

            if (trangThai != "Có mặt" &&
                trangThai != "Vắng mặt" &&
                trangThai != "Nghỉ phép" &&
                trangThai != "Nghỉ lễ")
                throw new Exception("Trạng thái chấm công không hợp lệ.");

            if (gioVao.HasValue && gioRa.HasValue &&
                gioRa.Value < gioVao.Value)
                throw new Exception("Giờ ra phải sau giờ vào.");

            if (trangThai != "Có mặt" &&
                (gioVao.HasValue || gioRa.HasValue || soGioLam != 0))
                throw new Exception(
                    "Ngày nghỉ phải để trống giờ vào, giờ ra và số giờ làm bằng 0.");

            if (gioVao.HasValue &&
                gioVao.Value.Date != ngayChamCong.Date)
                throw new Exception(
                    "Ngày của giờ vào phải trùng ngày chấm công.");

            if (gioRa.HasValue &&
                (gioRa.Value.Date < ngayChamCong.Date ||
                 gioRa.Value.Date > ngayChamCong.Date.AddDays(1)))
                throw new Exception(
                    "Giờ ra chỉ được trong ngày chấm công hoặc ngày tiếp theo.");

            object soBang = Db.Scalar(@"
                SELECT COUNT(*)
                FROM BangChamCong
                WHERE MaBangChamCong = @MaBang
                  AND Thang = @Thang
                  AND Nam = @Nam",
                Db.P("@MaBang", maBang),
                Db.P("@Thang", ngayChamCong.Month),
                Db.P("@Nam", ngayChamCong.Year));

            if (Convert.ToInt32(soBang) == 0)
                throw new Exception(
                    "Ngày chấm công không thuộc tháng/năm của bảng chấm công.");

            object soNhanVien = Db.Scalar(@"
                SELECT COUNT(*)
                FROM BangChamCong b
                INNER JOIN NhanVien nv
                    ON b.MaPhongBan = nv.MaPhongBan
                WHERE b.MaBangChamCong = @MaBang
                  AND nv.MaNV = @MaNV",
                Db.P("@MaBang", maBang),
                Db.P("@MaNV", maNV));

            if (Convert.ToInt32(soNhanVien) == 0)
                throw new Exception(
                    "Nhân viên không thuộc phòng ban của bảng chấm công.");
        }
    }
}
