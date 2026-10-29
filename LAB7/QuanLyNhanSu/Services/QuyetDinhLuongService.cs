
using System;
using System.Data;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class QuyetDinhLuongService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(@"
                SELECT q.MaQDL, q.SoQuyetDinh, q.MaNV,
                       nv.HoTen, q.NgayQuyetDinh, q.NgayHieuLuc,
                       q.LuongCoBan, q.PhuCapLuong,
                       q.PhuCapDocHai, q.NoiDung
                FROM QuyetDinhLuong q
                INNER JOIN NhanVien nv ON q.MaNV = nv.MaNV
                ORDER BY q.NgayHieuLuc DESC, q.MaQDL");
        }

        public DataTable LayNhanVien()
        {
            return Db.Query(@"
                SELECT MaNV, MaNV + ' - ' + HoTen AS TenNhanVien
                FROM NhanVien
                ORDER BY MaNV");
        }

        public DataTable TimKiem(string tuKhoa)
        {
            return Db.Query(@"
                SELECT q.MaQDL, q.SoQuyetDinh, q.MaNV,
                       nv.HoTen, q.NgayQuyetDinh, q.NgayHieuLuc,
                       q.LuongCoBan, q.PhuCapLuong,
                       q.PhuCapDocHai, q.NoiDung
                FROM QuyetDinhLuong q
                INNER JOIN NhanVien nv ON q.MaNV = nv.MaNV
                WHERE q.MaQDL LIKE @TuKhoa
                   OR q.SoQuyetDinh LIKE @TuKhoa
                   OR q.MaNV LIKE @TuKhoa
                   OR nv.HoTen LIKE @TuKhoa
                ORDER BY q.NgayHieuLuc DESC, q.MaQDL",
                Db.P("@TuKhoa", "%" + (tuKhoa ?? "").Trim() + "%"));
        }

        public bool KiemTraTonTai(string maQDL)
        {
            if (string.IsNullOrWhiteSpace(maQDL))
                return false;

            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM QuyetDinhLuong
                WHERE MaQDL = @MaQDL",
                Db.P("@MaQDL", maQDL.Trim()))) > 0;
        }

        public int Them(
            string maQDL,
            string soQuyetDinh,
            string maNV,
            DateTime ngayQuyetDinh,
            DateTime ngayHieuLuc,
            decimal luongCoBan,
            decimal phuCapLuong,
            decimal phuCapDocHai,
            string noiDung)
        {
            KiemTraDuLieu(
                maQDL, soQuyetDinh, maNV,
                ngayQuyetDinh, ngayHieuLuc,
                luongCoBan, phuCapLuong, phuCapDocHai);

            if (KiemTraTonTai(maQDL))
                throw new Exception("Mã quyết định lương đã tồn tại.");

            return Db.Execute(@"
                INSERT INTO QuyetDinhLuong
                (
                    MaQDL, SoQuyetDinh, MaNV,
                    NgayQuyetDinh, NgayHieuLuc,
                    LuongCoBan, PhuCapLuong, PhuCapDocHai, NoiDung
                )
                VALUES
                (
                    @MaQDL, @SoQuyetDinh, @MaNV,
                    @NgayQuyetDinh, @NgayHieuLuc,
                    @LuongCoBan, @PhuCapLuong, @PhuCapDocHai, @NoiDung
                )",
                Db.P("@MaQDL", maQDL.Trim()),
                Db.P("@SoQuyetDinh", soQuyetDinh.Trim()),
                Db.P("@MaNV", maNV),
                Db.P("@NgayQuyetDinh", ngayQuyetDinh.Date),
                Db.P("@NgayHieuLuc", ngayHieuLuc.Date),
                Db.P("@LuongCoBan", luongCoBan),
                Db.P("@PhuCapLuong", phuCapLuong),
                Db.P("@PhuCapDocHai", phuCapDocHai),
                Db.P("@NoiDung", noiDung));
        }

        public int Sua(
            string maQDL,
            string soQuyetDinh,
            string maNV,
            DateTime ngayQuyetDinh,
            DateTime ngayHieuLuc,
            decimal luongCoBan,
            decimal phuCapLuong,
            decimal phuCapDocHai,
            string noiDung)
        {
            KiemTraDuLieu(
                maQDL, soQuyetDinh, maNV,
                ngayQuyetDinh, ngayHieuLuc,
                luongCoBan, phuCapLuong, phuCapDocHai);

            return Db.Execute(@"
                UPDATE QuyetDinhLuong
                SET SoQuyetDinh = @SoQuyetDinh,
                    MaNV = @MaNV,
                    NgayQuyetDinh = @NgayQuyetDinh,
                    NgayHieuLuc = @NgayHieuLuc,
                    LuongCoBan = @LuongCoBan,
                    PhuCapLuong = @PhuCapLuong,
                    PhuCapDocHai = @PhuCapDocHai,
                    NoiDung = @NoiDung
                WHERE MaQDL = @MaQDL",
                Db.P("@MaQDL", maQDL.Trim()),
                Db.P("@SoQuyetDinh", soQuyetDinh.Trim()),
                Db.P("@MaNV", maNV),
                Db.P("@NgayQuyetDinh", ngayQuyetDinh.Date),
                Db.P("@NgayHieuLuc", ngayHieuLuc.Date),
                Db.P("@LuongCoBan", luongCoBan),
                Db.P("@PhuCapLuong", phuCapLuong),
                Db.P("@PhuCapDocHai", phuCapDocHai),
                Db.P("@NoiDung", noiDung));
        }

        public int Xoa(string maQDL)
        {
            if (string.IsNullOrWhiteSpace(maQDL))
                throw new Exception("Vui lòng chọn quyết định cần xóa.");

            return Db.Execute(@"
                DELETE FROM QuyetDinhLuong
                WHERE MaQDL = @MaQDL",
                Db.P("@MaQDL", maQDL.Trim()));
        }

        private void KiemTraDuLieu(
            string maQDL,
            string soQuyetDinh,
            string maNV,
            DateTime ngayQuyetDinh,
            DateTime ngayHieuLuc,
            decimal luongCoBan,
            decimal phuCapLuong,
            decimal phuCapDocHai)
        {
            if (string.IsNullOrWhiteSpace(maQDL))
                throw new Exception("Vui lòng nhập mã quyết định.");

            if (string.IsNullOrWhiteSpace(soQuyetDinh))
                throw new Exception("Vui lòng nhập số quyết định.");

            if (string.IsNullOrWhiteSpace(maNV))
                throw new Exception("Vui lòng chọn nhân viên.");

            if (maQDL.Trim().Length > 20)
                throw new Exception("Mã quyết định tối đa 20 ký tự.");

            if (soQuyetDinh.Trim().Length > 30)
                throw new Exception("Số quyết định tối đa 30 ký tự.");

            if (luongCoBan < 0 || phuCapLuong < 0 || phuCapDocHai < 0)
                throw new Exception("Lương và phụ cấp không được âm.");
        }
    }
}
