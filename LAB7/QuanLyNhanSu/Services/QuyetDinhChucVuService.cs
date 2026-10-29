
using System;
using System.Data;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class QuyetDinhChucVuService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(@"
                SELECT q.MaQDCV, q.SoQuyetDinh, q.MaNV,
                       nv.HoTen, q.MaChucVu, cv.TenChucVu,
                       q.NgayQuyetDinh, q.NgayHieuLuc,
                       q.PhuCapChucVu, q.NoiDung
                FROM QuyetDinhChucVu q
                INNER JOIN NhanVien nv ON q.MaNV = nv.MaNV
                INNER JOIN ChucVu cv ON q.MaChucVu = cv.MaChucVu
                ORDER BY q.NgayHieuLuc DESC, q.MaQDCV");
        }

        public DataTable LayNhanVien()
        {
            return Db.Query(@"
                SELECT MaNV,
                       MaNV + N' - ' + HoTen AS TenNhanVien
                FROM NhanVien
                ORDER BY MaNV");
        }

        public DataTable LayChucVu()
        {
            return Db.Query(@"
                SELECT MaChucVu, TenChucVu, PhuCapChucVu
                FROM ChucVu
                ORDER BY TenChucVu");
        }

        public DataTable TimKiem(string tuKhoa)
        {
            return Db.Query(@"
                SELECT q.MaQDCV, q.SoQuyetDinh, q.MaNV,
                       nv.HoTen, q.MaChucVu, cv.TenChucVu,
                       q.NgayQuyetDinh, q.NgayHieuLuc,
                       q.PhuCapChucVu, q.NoiDung
                FROM QuyetDinhChucVu q
                INNER JOIN NhanVien nv ON q.MaNV = nv.MaNV
                INNER JOIN ChucVu cv ON q.MaChucVu = cv.MaChucVu
                WHERE q.MaQDCV LIKE @TuKhoa
                   OR q.SoQuyetDinh LIKE @TuKhoa
                   OR q.MaNV LIKE @TuKhoa
                   OR nv.HoTen LIKE @TuKhoa
                   OR q.MaChucVu LIKE @TuKhoa
                   OR cv.TenChucVu LIKE @TuKhoa
                ORDER BY q.NgayHieuLuc DESC, q.MaQDCV",
                Db.P("@TuKhoa", "%" + (tuKhoa ?? "").Trim() + "%"));
        }

        public bool KiemTraTonTai(string maQDCV)
        {
            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM QuyetDinhChucVu
                WHERE MaQDCV = @MaQDCV",
                Db.P("@MaQDCV", maQDCV.Trim()))) > 0;
        }

        public int Them(
            string maQDCV,
            string soQuyetDinh,
            string maNV,
            string maChucVu,
            DateTime ngayQuyetDinh,
            DateTime ngayHieuLuc,
            decimal phuCapChucVu,
            string noiDung)
        {
            KiemTraDuLieu(
                maQDCV, soQuyetDinh, maNV,
                maChucVu, phuCapChucVu);

            if (KiemTraTonTai(maQDCV))
                throw new Exception("Mã quyết định đã tồn tại.");

            return Db.Execute(@"
                INSERT INTO QuyetDinhChucVu
                (
                    MaQDCV, SoQuyetDinh, MaNV, MaChucVu,
                    NgayQuyetDinh, NgayHieuLuc,
                    PhuCapChucVu, NoiDung
                )
                VALUES
                (
                    @MaQDCV, @SoQuyetDinh, @MaNV, @MaChucVu,
                    @NgayQuyetDinh, @NgayHieuLuc,
                    @PhuCapChucVu, @NoiDung
                )",
                Db.P("@MaQDCV", maQDCV.Trim()),
                Db.P("@SoQuyetDinh", soQuyetDinh.Trim()),
                Db.P("@MaNV", maNV),
                Db.P("@MaChucVu", maChucVu),
                Db.P("@NgayQuyetDinh", ngayQuyetDinh.Date),
                Db.P("@NgayHieuLuc", ngayHieuLuc.Date),
                Db.P("@PhuCapChucVu", phuCapChucVu),
                Db.P("@NoiDung", noiDung));
        }

        public int Sua(
            string maQDCV,
            string soQuyetDinh,
            string maNV,
            string maChucVu,
            DateTime ngayQuyetDinh,
            DateTime ngayHieuLuc,
            decimal phuCapChucVu,
            string noiDung)
        {
            KiemTraDuLieu(
                maQDCV, soQuyetDinh, maNV,
                maChucVu, phuCapChucVu);

            return Db.Execute(@"
                UPDATE QuyetDinhChucVu
                SET SoQuyetDinh = @SoQuyetDinh,
                    MaNV = @MaNV,
                    MaChucVu = @MaChucVu,
                    NgayQuyetDinh = @NgayQuyetDinh,
                    NgayHieuLuc = @NgayHieuLuc,
                    PhuCapChucVu = @PhuCapChucVu,
                    NoiDung = @NoiDung
                WHERE MaQDCV = @MaQDCV",
                Db.P("@MaQDCV", maQDCV.Trim()),
                Db.P("@SoQuyetDinh", soQuyetDinh.Trim()),
                Db.P("@MaNV", maNV),
                Db.P("@MaChucVu", maChucVu),
                Db.P("@NgayQuyetDinh", ngayQuyetDinh.Date),
                Db.P("@NgayHieuLuc", ngayHieuLuc.Date),
                Db.P("@PhuCapChucVu", phuCapChucVu),
                Db.P("@NoiDung", noiDung));
        }

        public int Xoa(string maQDCV)
        {
            if (string.IsNullOrWhiteSpace(maQDCV))
                throw new Exception("Vui lòng chọn quyết định cần xóa.");

            return Db.Execute(@"
                DELETE FROM QuyetDinhChucVu
                WHERE MaQDCV = @MaQDCV",
                Db.P("@MaQDCV", maQDCV.Trim()));
        }

        private void KiemTraDuLieu(
            string maQDCV,
            string soQuyetDinh,
            string maNV,
            string maChucVu,
            decimal phuCapChucVu)
        {
            if (string.IsNullOrWhiteSpace(maQDCV))
                throw new Exception("Vui lòng nhập mã quyết định.");

            if (string.IsNullOrWhiteSpace(soQuyetDinh))
                throw new Exception("Vui lòng nhập số quyết định.");

            if (string.IsNullOrWhiteSpace(maNV))
                throw new Exception("Vui lòng chọn nhân viên.");

            if (string.IsNullOrWhiteSpace(maChucVu))
                throw new Exception("Vui lòng chọn chức vụ.");

            if (maQDCV.Trim().Length > 20)
                throw new Exception("Mã quyết định tối đa 20 ký tự.");

            if (soQuyetDinh.Trim().Length > 30)
                throw new Exception("Số quyết định tối đa 30 ký tự.");

            if (phuCapChucVu < 0)
                throw new Exception("Phụ cấp chức vụ không được âm.");
        }
    }
}
