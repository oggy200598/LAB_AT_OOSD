
using System;
using System.Data;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class CaLamViecService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(@"
                SELECT MaCa, TenCa, GioBatDau, GioKetThuc, MoTa
                FROM CaLamViec
                ORDER BY MaCa");
        }

        public DataTable TimKiem(string tuKhoa)
        {
            return Db.Query(@"
                SELECT MaCa, TenCa, GioBatDau, GioKetThuc, MoTa
                FROM CaLamViec
                WHERE MaCa LIKE @TuKhoa
                   OR TenCa LIKE @TuKhoa
                   OR MoTa LIKE @TuKhoa
                ORDER BY MaCa",
                Db.P("@TuKhoa", "%" + (tuKhoa ?? "").Trim() + "%"));
        }

        public bool KiemTraTonTai(string maCa)
        {
            if (string.IsNullOrWhiteSpace(maCa))
                return false;

            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM CaLamViec
                WHERE MaCa = @MaCa",
                Db.P("@MaCa", maCa.Trim()))) > 0;
        }

        public int Them(
            string maCa,
            string tenCa,
            TimeSpan gioBatDau,
            TimeSpan gioKetThuc,
            string moTa)
        {
            KiemTraDuLieu(
                maCa, tenCa, gioBatDau, gioKetThuc, moTa);

            if (KiemTraTonTai(maCa))
                throw new Exception("Mã ca làm việc đã tồn tại.");

            return Db.Execute(@"
                INSERT INTO CaLamViec
                (MaCa, TenCa, GioBatDau, GioKetThuc, MoTa)
                VALUES
                (@MaCa, @TenCa, @GioBatDau, @GioKetThuc, @MoTa)",
                Db.P("@MaCa", maCa.Trim()),
                Db.P("@TenCa", tenCa.Trim()),
                Db.P("@GioBatDau", gioBatDau),
                Db.P("@GioKetThuc", gioKetThuc),
                Db.P("@MoTa", moTa));
        }

        public int Sua(
            string maCa,
            string tenCa,
            TimeSpan gioBatDau,
            TimeSpan gioKetThuc,
            string moTa)
        {
            KiemTraDuLieu(
                maCa, tenCa, gioBatDau, gioKetThuc, moTa);

            return Db.Execute(@"
                UPDATE CaLamViec
                SET TenCa = @TenCa,
                    GioBatDau = @GioBatDau,
                    GioKetThuc = @GioKetThuc,
                    MoTa = @MoTa
                WHERE MaCa = @MaCa",
                Db.P("@MaCa", maCa.Trim()),
                Db.P("@TenCa", tenCa.Trim()),
                Db.P("@GioBatDau", gioBatDau),
                Db.P("@GioKetThuc", gioKetThuc),
                Db.P("@MoTa", moTa));
        }

        public int Xoa(string maCa)
        {
            if (string.IsNullOrWhiteSpace(maCa))
                throw new Exception("Vui lòng chọn ca làm việc cần xóa.");

            return Db.Execute(@"
                DELETE FROM CaLamViec
                WHERE MaCa = @MaCa",
                Db.P("@MaCa", maCa.Trim()));
        }

        private void KiemTraDuLieu(
            string maCa,
            string tenCa,
            TimeSpan gioBatDau,
            TimeSpan gioKetThuc,
            string moTa)
        {
            if (string.IsNullOrWhiteSpace(maCa))
                throw new Exception("Vui lòng nhập mã ca.");

            if (string.IsNullOrWhiteSpace(tenCa))
                throw new Exception("Vui lòng nhập tên ca.");

            if (maCa.Trim().Length > 20)
                throw new Exception("Mã ca tối đa 20 ký tự.");

            if (tenCa.Trim().Length > 100)
                throw new Exception("Tên ca tối đa 100 ký tự.");

            if (!string.IsNullOrEmpty(moTa) && moTa.Length > 500)
                throw new Exception("Mô tả tối đa 500 ký tự.");

            if (gioBatDau < TimeSpan.Zero ||
                gioBatDau >= TimeSpan.FromDays(1) ||
                gioKetThuc < TimeSpan.Zero ||
                gioKetThuc >= TimeSpan.FromDays(1))
                throw new Exception("Thời gian làm việc không hợp lệ.");

            if (gioBatDau == gioKetThuc)
                throw new Exception(
                    "Giờ bắt đầu phải khác giờ kết thúc.");
        }
    }
}
