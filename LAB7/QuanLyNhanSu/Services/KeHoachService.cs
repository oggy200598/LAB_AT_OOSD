
using System;
using System.Data;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class KeHoachService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(@"
                SELECT k.MaKeHoach, k.MaPhongBan, p.TenPhongBan,
                       k.NgayBatDau, k.NgayKetThuc,
                       k.NguoiLap, k.NgayLap, k.NoiDung, k.TrangThai
                FROM KeHoachTuan k
                INNER JOIN PhongBan p ON k.MaPhongBan = p.MaPhongBan
                ORDER BY k.NgayBatDau DESC, k.MaKeHoach");
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
                SELECT k.MaKeHoach, k.MaPhongBan, p.TenPhongBan,
                       k.NgayBatDau, k.NgayKetThuc,
                       k.NguoiLap, k.NgayLap, k.NoiDung, k.TrangThai
                FROM KeHoachTuan k
                INNER JOIN PhongBan p ON k.MaPhongBan = p.MaPhongBan
                WHERE k.MaKeHoach LIKE @TuKhoa
                   OR p.TenPhongBan LIKE @TuKhoa
                   OR k.NguoiLap LIKE @TuKhoa
                   OR k.NoiDung LIKE @TuKhoa
                   OR k.TrangThai LIKE @TuKhoa
                ORDER BY k.NgayBatDau DESC, k.MaKeHoach",
                Db.P("@TuKhoa", "%" + (tuKhoa ?? "").Trim() + "%"));
        }

        public bool KiemTraTonTai(string maKeHoach)
        {
            if (string.IsNullOrWhiteSpace(maKeHoach))
                return false;

            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM KeHoachTuan
                WHERE MaKeHoach = @MaKeHoach",
                Db.P("@MaKeHoach", maKeHoach.Trim()))) > 0;
        }

        public bool KiemTraTrungTuan(
            string maPhongBan, DateTime ngayBatDau, string maKeHoach)
        {
            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM KeHoachTuan
                WHERE MaPhongBan = @MaPhongBan
                  AND NgayBatDau = @NgayBatDau
                  AND MaKeHoach <> @MaKeHoach",
                Db.P("@MaPhongBan", maPhongBan),
                Db.P("@NgayBatDau", ngayBatDau.Date),
                Db.P("@MaKeHoach", maKeHoach.Trim()))) > 0;
        }

        public int Them(
            string maKeHoach,
            string maPhongBan,
            DateTime ngayBatDau,
            string nguoiLap,
            DateTime ngayLap,
            string noiDung,
            string trangThai)
        {
            KiemTraDuLieu(
                maKeHoach, maPhongBan, ngayBatDau,
                nguoiLap, trangThai);

            if (KiemTraTonTai(maKeHoach))
                throw new Exception("Mã kế hoạch đã tồn tại.");

            if (KiemTraTrungTuan(
                maPhongBan, ngayBatDau, maKeHoach))
                throw new Exception(
                    "Phòng ban đã có kế hoạch cho ngày bắt đầu này.");

            return Db.Execute(@"
                INSERT INTO KeHoachTuan
                (
                    MaKeHoach, MaPhongBan, NgayBatDau,
                    NgayKetThuc, NguoiLap, NgayLap,
                    NoiDung, TrangThai
                )
                VALUES
                (
                    @MaKeHoach, @MaPhongBan, @NgayBatDau,
                    @NgayKetThuc, @NguoiLap, @NgayLap,
                    @NoiDung, @TrangThai
                )",
                Db.P("@MaKeHoach", maKeHoach.Trim()),
                Db.P("@MaPhongBan", maPhongBan),
                Db.P("@NgayBatDau", ngayBatDau.Date),
                Db.P("@NgayKetThuc", ngayBatDau.Date.AddDays(6)),
                Db.P("@NguoiLap", nguoiLap.Trim()),
                Db.P("@NgayLap", ngayLap.Date),
                Db.P("@NoiDung", noiDung),
                Db.P("@TrangThai", trangThai));
        }

        public int Sua(
            string maKeHoach,
            string maPhongBan,
            DateTime ngayBatDau,
            string nguoiLap,
            DateTime ngayLap,
            string noiDung,
            string trangThai)
        {
            KiemTraDuLieu(
                maKeHoach, maPhongBan, ngayBatDau,
                nguoiLap, trangThai);

            if (KiemTraTrungTuan(
                maPhongBan, ngayBatDau, maKeHoach))
                throw new Exception(
                    "Phòng ban đã có kế hoạch cho ngày bắt đầu này.");

            return Db.Execute(@"
                UPDATE KeHoachTuan
                SET MaPhongBan = @MaPhongBan,
                    NgayBatDau = @NgayBatDau,
                    NgayKetThuc = @NgayKetThuc,
                    NguoiLap = @NguoiLap,
                    NgayLap = @NgayLap,
                    NoiDung = @NoiDung,
                    TrangThai = @TrangThai
                WHERE MaKeHoach = @MaKeHoach",
                Db.P("@MaKeHoach", maKeHoach.Trim()),
                Db.P("@MaPhongBan", maPhongBan),
                Db.P("@NgayBatDau", ngayBatDau.Date),
                Db.P("@NgayKetThuc", ngayBatDau.Date.AddDays(6)),
                Db.P("@NguoiLap", nguoiLap.Trim()),
                Db.P("@NgayLap", ngayLap.Date),
                Db.P("@NoiDung", noiDung),
                Db.P("@TrangThai", trangThai));
        }

        public int Xoa(string maKeHoach)
        {
            if (string.IsNullOrWhiteSpace(maKeHoach))
                throw new Exception("Vui lòng chọn kế hoạch cần xóa.");

            return Db.Execute(@"
                DELETE FROM KeHoachTuan
                WHERE MaKeHoach = @MaKeHoach",
                Db.P("@MaKeHoach", maKeHoach.Trim()));
        }

        private void KiemTraDuLieu(
            string maKeHoach,
            string maPhongBan,
            DateTime ngayBatDau,
            string nguoiLap,
            string trangThai)
        {
            if (string.IsNullOrWhiteSpace(maKeHoach))
                throw new Exception("Vui lòng nhập mã kế hoạch.");

            if (string.IsNullOrWhiteSpace(maPhongBan))
                throw new Exception("Vui lòng chọn phòng ban.");

            if (string.IsNullOrWhiteSpace(nguoiLap))
                throw new Exception("Vui lòng nhập người lập.");

            if (maKeHoach.Trim().Length > 20)
                throw new Exception("Mã kế hoạch tối đa 20 ký tự.");

            if (nguoiLap.Trim().Length > 100)
                throw new Exception("Tên người lập tối đa 100 ký tự.");

            if (ngayBatDau.Date > DateTime.MaxValue.AddDays(-6).Date)
                throw new Exception("Ngày bắt đầu không hợp lệ.");

            if (trangThai != "Đã lập" &&
                trangThai != "Đang thực hiện" &&
                trangThai != "Hoàn thành" &&
                trangThai != "Hủy")
                throw new Exception("Trạng thái kế hoạch không hợp lệ.");
        }
    }
}
