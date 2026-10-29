using System;
using System.Data;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class PhieuThuNopPhatService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(@"
                SELECT p.MaPhieuThu, p.MaQDKL,
                       q.SoQuyetDinh, q.SoTienPhat,
                       p.NgayThu, p.SoTienThu,
                       p.NguoiLap, p.HinhThucThu, p.GhiChu
                FROM PhieuThuNopPhat p
                INNER JOIN QuyetDinhKyLuat q ON p.MaQDKL = q.MaQDKL
                ORDER BY p.NgayThu DESC, p.MaPhieuThu");
        }

        public DataTable LayQuyetDinh()
        {
            return Db.Query(@"
                SELECT MaQDKL,
                       MaQDKL + N' - ' + SoQuyetDinh AS TenQuyetDinh
                FROM QuyetDinhKyLuat
                ORDER BY NgayQuyetDinh DESC, MaQDKL");
        }

        public DataTable TimKiem(string tuKhoa)
        {
            return Db.Query(@"
                SELECT p.MaPhieuThu, p.MaQDKL,
                       q.SoQuyetDinh, q.SoTienPhat,
                       p.NgayThu, p.SoTienThu,
                       p.NguoiLap, p.HinhThucThu, p.GhiChu
                FROM PhieuThuNopPhat p
                INNER JOIN QuyetDinhKyLuat q ON p.MaQDKL = q.MaQDKL
                WHERE p.MaPhieuThu LIKE @TuKhoa
                   OR p.MaQDKL LIKE @TuKhoa
                   OR q.SoQuyetDinh LIKE @TuKhoa
                   OR p.NguoiLap LIKE @TuKhoa
                   OR p.HinhThucThu LIKE @TuKhoa
                   OR p.GhiChu LIKE @TuKhoa
                ORDER BY p.NgayThu DESC, p.MaPhieuThu",
                Db.P("@TuKhoa", "%" + (tuKhoa ?? "").Trim() + "%"));
        }

        public decimal LaySoTienPhat(string maQDKL)
        {
            if (string.IsNullOrWhiteSpace(maQDKL))
                throw new Exception("Vui lòng chọn quyết định kỷ luật.");

            object ketQua = Db.Scalar(@"
                SELECT SoTienPhat
                FROM QuyetDinhKyLuat
                WHERE MaQDKL = @MaQDKL",
                Db.P("@MaQDKL", maQDKL));

            if (ketQua == null || ketQua == DBNull.Value)
                throw new Exception("Không tìm thấy quyết định kỷ luật.");

            return Convert.ToDecimal(ketQua);
        }

        public bool KiemTraTonTai(string maPhieuThu)
        {
            if (string.IsNullOrWhiteSpace(maPhieuThu))
                return false;

            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM PhieuThuNopPhat
                WHERE MaPhieuThu = @MaPhieuThu",
                Db.P("@MaPhieuThu", maPhieuThu.Trim()))) > 0;
        }

        public bool KiemTraTrungQuyetDinh(
            string maQDKL, string maPhieuThu)
        {
            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM PhieuThuNopPhat
                WHERE MaQDKL = @MaQDKL
                  AND MaPhieuThu <> @MaPhieuThu",
                Db.P("@MaQDKL", maQDKL),
                Db.P("@MaPhieuThu", maPhieuThu.Trim()))) > 0;
        }

        public int Them(
            string maPhieuThu,
            string maQDKL,
            DateTime ngayThu,
            decimal soTienThu,
            string nguoiLap,
            string hinhThucThu,
            string ghiChu)
        {
            KiemTraDuLieu(
                maPhieuThu, maQDKL, soTienThu,
                nguoiLap, hinhThucThu, ghiChu);

            if (KiemTraTonTai(maPhieuThu))
                throw new Exception("Mã phiếu thu đã tồn tại.");

            if (KiemTraTrungQuyetDinh(maQDKL, maPhieuThu))
                throw new Exception("Quyết định này đã có phiếu thu.");

            return Db.Execute(@"
                INSERT INTO PhieuThuNopPhat
                (MaPhieuThu, MaQDKL, NgayThu, SoTienThu,
                 NguoiLap, HinhThucThu, GhiChu)
                VALUES
                (@MaPhieuThu, @MaQDKL, @NgayThu, @SoTienThu,
                 @NguoiLap, @HinhThucThu, @GhiChu)",
                Db.P("@MaPhieuThu", maPhieuThu.Trim()),
                Db.P("@MaQDKL", maQDKL),
                Db.P("@NgayThu", ngayThu.Date),
                Db.P("@SoTienThu", soTienThu),
                Db.P("@NguoiLap", nguoiLap.Trim()),
                Db.P("@HinhThucThu", hinhThucThu),
                Db.P("@GhiChu", string.IsNullOrWhiteSpace(ghiChu)
                    ? (object)DBNull.Value : ghiChu));
        }

        public int Sua(
            string maPhieuThu,
            string maQDKL,
            DateTime ngayThu,
            decimal soTienThu,
            string nguoiLap,
            string hinhThucThu,
            string ghiChu)
        {
            KiemTraDuLieu(
                maPhieuThu, maQDKL, soTienThu,
                nguoiLap, hinhThucThu, ghiChu);

            if (KiemTraTrungQuyetDinh(maQDKL, maPhieuThu))
                throw new Exception("Quyết định này đã có phiếu thu khác.");

            return Db.Execute(@"
                UPDATE PhieuThuNopPhat
                SET MaQDKL = @MaQDKL,
                    NgayThu = @NgayThu,
                    SoTienThu = @SoTienThu,
                    NguoiLap = @NguoiLap,
                    HinhThucThu = @HinhThucThu,
                    GhiChu = @GhiChu
                WHERE MaPhieuThu = @MaPhieuThu",
                Db.P("@MaPhieuThu", maPhieuThu.Trim()),
                Db.P("@MaQDKL", maQDKL),
                Db.P("@NgayThu", ngayThu.Date),
                Db.P("@SoTienThu", soTienThu),
                Db.P("@NguoiLap", nguoiLap.Trim()),
                Db.P("@HinhThucThu", hinhThucThu),
                Db.P("@GhiChu", string.IsNullOrWhiteSpace(ghiChu)
                    ? (object)DBNull.Value : ghiChu));
        }

        public int Xoa(string maPhieuThu)
        {
            if (string.IsNullOrWhiteSpace(maPhieuThu))
                throw new Exception("Vui lòng chọn phiếu thu cần xóa.");

            return Db.Execute(@"
                DELETE FROM PhieuThuNopPhat
                WHERE MaPhieuThu = @MaPhieuThu",
                Db.P("@MaPhieuThu", maPhieuThu.Trim()));
        }

        private void KiemTraDuLieu(
            string maPhieuThu,
            string maQDKL,
            decimal soTienThu,
            string nguoiLap,
            string hinhThucThu,
            string ghiChu)
        {
            if (string.IsNullOrWhiteSpace(maPhieuThu))
                throw new Exception("Vui lòng nhập mã phiếu thu.");

            if (maPhieuThu.Trim().Length > 20)
                throw new Exception("Mã phiếu thu tối đa 20 ký tự.");

            if (string.IsNullOrWhiteSpace(maQDKL))
                throw new Exception("Vui lòng chọn quyết định kỷ luật.");

            if (soTienThu < 0)
                throw new Exception("Số tiền thu không được âm.");

            if (decimal.Round(soTienThu, 2) != soTienThu)
                throw new Exception("Số tiền thu tối đa 2 chữ số thập phân.");

            if (string.IsNullOrWhiteSpace(nguoiLap))
                throw new Exception("Vui lòng nhập người lập.");

            if (nguoiLap.Trim().Length > 100)
                throw new Exception("Người lập tối đa 100 ký tự.");

            if (hinhThucThu != "Tiền mặt" &&
                hinhThucThu != "Chuyển khoản" &&
                hinhThucThu != "Trừ lương")
                throw new Exception("Hình thức thu không hợp lệ.");

            if (!string.IsNullOrEmpty(ghiChu) && ghiChu.Length > 500)
                throw new Exception("Ghi chú tối đa 500 ký tự.");

            if (soTienThu > LaySoTienPhat(maQDKL))
                throw new Exception(
                    "Số tiền thu không được vượt số tiền phạt trong quyết định.");
        }
    }
}