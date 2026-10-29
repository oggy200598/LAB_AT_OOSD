
using System;
using System.Data;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class PhanCongService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(@"
                SELECT pc.MaPhanCong, pc.MaKeHoach,
                       pc.MaNV, nv.HoTen,
                       pc.MaCa, ca.TenCa,
                       pc.NgayLamViec,
                       pc.NoiDungCongViec, pc.GhiChu
                FROM ChiTietPhanCong pc
                INNER JOIN NhanVien nv ON pc.MaNV = nv.MaNV
                INNER JOIN CaLamViec ca ON pc.MaCa = ca.MaCa
                ORDER BY pc.NgayLamViec DESC, pc.MaPhanCong");
        }

        public DataTable LayKeHoach()
        {
            return Db.Query(@"
                SELECT k.MaKeHoach,
                       k.MaKeHoach + N' - ' + p.TenPhongBan
                       AS TenKeHoach
                FROM KeHoachTuan k
                INNER JOIN PhongBan p
                    ON k.MaPhongBan = p.MaPhongBan
                ORDER BY k.NgayBatDau DESC");
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

        public DataTable TimKiem(string tuKhoa)
        {
            return Db.Query(@"
                SELECT pc.MaPhanCong, pc.MaKeHoach,
                       pc.MaNV, nv.HoTen,
                       pc.MaCa, ca.TenCa,
                       pc.NgayLamViec,
                       pc.NoiDungCongViec, pc.GhiChu
                FROM ChiTietPhanCong pc
                INNER JOIN NhanVien nv ON pc.MaNV = nv.MaNV
                INNER JOIN CaLamViec ca ON pc.MaCa = ca.MaCa
                WHERE pc.MaPhanCong LIKE @TuKhoa
                   OR pc.MaKeHoach LIKE @TuKhoa
                   OR pc.MaNV LIKE @TuKhoa
                   OR nv.HoTen LIKE @TuKhoa
                   OR ca.TenCa LIKE @TuKhoa
                   OR pc.NoiDungCongViec LIKE @TuKhoa
                ORDER BY pc.NgayLamViec DESC, pc.MaPhanCong",
                Db.P("@TuKhoa", "%" + (tuKhoa ?? "").Trim() + "%"));
        }

        public bool KiemTraTonTai(string maPhanCong)
        {
            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM ChiTietPhanCong
                WHERE MaPhanCong = @Ma",
                Db.P("@Ma", maPhanCong.Trim()))) > 0;
        }

        public bool KiemTraTrungCa(
            string maNV, string maCa,
            DateTime ngayLamViec, string maPhanCong)
        {
            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM ChiTietPhanCong
                WHERE MaNV = @MaNV
                  AND MaCa = @MaCa
                  AND NgayLamViec = @Ngay
                  AND MaPhanCong <> @MaPhanCong",
                Db.P("@MaNV", maNV),
                Db.P("@MaCa", maCa),
                Db.P("@Ngay", ngayLamViec.Date),
                Db.P("@MaPhanCong", maPhanCong.Trim()))) > 0;
        }

        public bool NgayThuocKeHoach(
            string maKeHoach, DateTime ngayLamViec)
        {
            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM KeHoachTuan
                WHERE MaKeHoach = @MaKeHoach
                  AND @Ngay BETWEEN NgayBatDau AND NgayKetThuc",
                Db.P("@MaKeHoach", maKeHoach),
                Db.P("@Ngay", ngayLamViec.Date))) > 0;
        }

        public int Them(
            string maPhanCong,
            string maKeHoach,
            string maNV,
            string maCa,
            DateTime ngayLamViec,
            string noiDungCongViec,
            string ghiChu)
        {
            KiemTraDuLieu(
                maPhanCong, maKeHoach, maNV, maCa,
                ngayLamViec, noiDungCongViec, ghiChu);

            if (KiemTraTonTai(maPhanCong))
                throw new Exception("Mã phân công đã tồn tại.");

            if (KiemTraTrungCa(
                maNV, maCa, ngayLamViec, maPhanCong))
                throw new Exception(
                    "Nhân viên đã được phân công vào ca này trong ngày.");

            return Db.Execute(@"
                INSERT INTO ChiTietPhanCong
                (
                    MaPhanCong, MaKeHoach, MaNV, MaCa,
                    NgayLamViec, NoiDungCongViec, GhiChu
                )
                VALUES
                (
                    @MaPhanCong, @MaKeHoach, @MaNV, @MaCa,
                    @NgayLamViec, @NoiDungCongViec, @GhiChu
                )",
                Db.P("@MaPhanCong", maPhanCong.Trim()),
                Db.P("@MaKeHoach", maKeHoach),
                Db.P("@MaNV", maNV),
                Db.P("@MaCa", maCa),
                Db.P("@NgayLamViec", ngayLamViec.Date),
                Db.P("@NoiDungCongViec", noiDungCongViec),
                Db.P("@GhiChu", ghiChu));
        }

        public int Sua(
            string maPhanCong,
            string maKeHoach,
            string maNV,
            string maCa,
            DateTime ngayLamViec,
            string noiDungCongViec,
            string ghiChu)
        {
            KiemTraDuLieu(
                maPhanCong, maKeHoach, maNV, maCa,
                ngayLamViec, noiDungCongViec, ghiChu);

            if (KiemTraTrungCa(
                maNV, maCa, ngayLamViec, maPhanCong))
                throw new Exception(
                    "Nhân viên đã được phân công vào ca này trong ngày.");

            return Db.Execute(@"
                UPDATE ChiTietPhanCong
                SET MaKeHoach = @MaKeHoach,
                    MaNV = @MaNV,
                    MaCa = @MaCa,
                    NgayLamViec = @NgayLamViec,
                    NoiDungCongViec = @NoiDungCongViec,
                    GhiChu = @GhiChu
                WHERE MaPhanCong = @MaPhanCong",
                Db.P("@MaPhanCong", maPhanCong.Trim()),
                Db.P("@MaKeHoach", maKeHoach),
                Db.P("@MaNV", maNV),
                Db.P("@MaCa", maCa),
                Db.P("@NgayLamViec", ngayLamViec.Date),
                Db.P("@NoiDungCongViec", noiDungCongViec),
                Db.P("@GhiChu", ghiChu));
        }

        public int Xoa(string maPhanCong)
        {
            if (string.IsNullOrWhiteSpace(maPhanCong))
                throw new Exception("Vui lòng chọn phân công cần xóa.");

            return Db.Execute(@"
                DELETE FROM ChiTietPhanCong
                WHERE MaPhanCong = @MaPhanCong",
                Db.P("@MaPhanCong", maPhanCong.Trim()));
        }

        private void KiemTraDuLieu(
            string maPhanCong,
            string maKeHoach,
            string maNV,
            string maCa,
            DateTime ngayLamViec,
            string noiDungCongViec,
            string ghiChu)
        {
            if (string.IsNullOrWhiteSpace(maPhanCong))
                throw new Exception("Vui lòng nhập mã phân công.");

            if (string.IsNullOrWhiteSpace(maKeHoach))
                throw new Exception("Vui lòng chọn kế hoạch tuần.");

            if (string.IsNullOrWhiteSpace(maNV))
                throw new Exception("Vui lòng chọn nhân viên.");

            if (string.IsNullOrWhiteSpace(maCa))
                throw new Exception("Vui lòng chọn ca làm việc.");

            if (maPhanCong.Trim().Length > 20)
                throw new Exception("Mã phân công tối đa 20 ký tự.");

            if (!string.IsNullOrEmpty(noiDungCongViec) &&
                noiDungCongViec.Length > 500)
                throw new Exception("Nội dung tối đa 500 ký tự.");

            if (!string.IsNullOrEmpty(ghiChu) &&
                ghiChu.Length > 500)
                throw new Exception("Ghi chú tối đa 500 ký tự.");

            if (!NgayThuocKeHoach(maKeHoach, ngayLamViec))
                throw new Exception(
                    "Ngày làm việc phải nằm trong thời gian kế hoạch tuần.");
        }
    }
}
