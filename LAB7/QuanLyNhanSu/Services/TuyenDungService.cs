
using System;
using System.Data;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class TuyenDungService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(@"
                SELECT q.MaQDTD, q.SoQuyetDinh, q.NgayQuyetDinh,
                       q.MaNV, nv.HoTen, q.MaPhongBan,
                       pb.TenPhongBan, q.NgayBatDauThuViec,
                       q.NgayKetThucThuViec, q.LuongThuViec,
                       q.NoiDung, q.DieuKhoan
                FROM QuyetDinhTuyenDung q
                INNER JOIN NhanVien nv ON q.MaNV = nv.MaNV
                INNER JOIN PhongBan pb ON q.MaPhongBan = pb.MaPhongBan
                ORDER BY q.NgayQuyetDinh DESC, q.MaQDTD");
        }

        public DataTable LayNhanVien()
        {
            return Db.Query(@"
                SELECT MaNV, HoTen
                FROM NhanVien
                ORDER BY HoTen");
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
                SELECT q.MaQDTD, q.SoQuyetDinh, q.NgayQuyetDinh,
                       q.MaNV, nv.HoTen, q.MaPhongBan,
                       pb.TenPhongBan, q.NgayBatDauThuViec,
                       q.NgayKetThucThuViec, q.LuongThuViec,
                       q.NoiDung, q.DieuKhoan
                FROM QuyetDinhTuyenDung q
                INNER JOIN NhanVien nv ON q.MaNV = nv.MaNV
                INNER JOIN PhongBan pb ON q.MaPhongBan = pb.MaPhongBan
                WHERE q.MaQDTD LIKE @TuKhoa
                   OR q.SoQuyetDinh LIKE @TuKhoa
                   OR q.MaNV LIKE @TuKhoa
                   OR nv.HoTen LIKE @TuKhoa
                   OR pb.TenPhongBan LIKE @TuKhoa
                ORDER BY q.NgayQuyetDinh DESC, q.MaQDTD",
                Db.P("@TuKhoa", "%" + (tuKhoa ?? "").Trim() + "%"));
        }

        public int Them(
            string maQDTD,
            string soQuyetDinh,
            DateTime ngayQuyetDinh,
            string maNV,
            string maPhongBan,
            DateTime ngayBatDau,
            DateTime ngayKetThuc,
            decimal luongThuViec,
            string noiDung,
            string dieuKhoan)
        {
            KiemTra(maQDTD, soQuyetDinh, maNV, maPhongBan,
                ngayBatDau, ngayKetThuc, luongThuViec);

            string sql = @"
                INSERT INTO QuyetDinhTuyenDung
                (MaQDTD, SoQuyetDinh, NgayQuyetDinh, MaNV,
                 MaPhongBan, NgayBatDauThuViec, NgayKetThucThuViec,
                 LuongThuViec, NoiDung, DieuKhoan)
                VALUES
                (@MaQDTD, @SoQuyetDinh, @NgayQuyetDinh, @MaNV,
                 @MaPhongBan, @NgayBatDau, @NgayKetThuc,
                 @LuongThuViec, @NoiDung, @DieuKhoan)";

            return Db.Execute(sql,
                Db.P("@MaQDTD", maQDTD.Trim()),
                Db.P("@SoQuyetDinh", soQuyetDinh.Trim()),
                Db.P("@NgayQuyetDinh", ngayQuyetDinh.Date),
                Db.P("@MaNV", maNV),
                Db.P("@MaPhongBan", maPhongBan),
                Db.P("@NgayBatDau", ngayBatDau.Date),
                Db.P("@NgayKetThuc", ngayKetThuc.Date),
                Db.P("@LuongThuViec", luongThuViec),
                Db.P("@NoiDung", noiDung),
                Db.P("@DieuKhoan", dieuKhoan));
        }

        public int Sua(
            string maQDTD,
            string soQuyetDinh,
            DateTime ngayQuyetDinh,
            string maNV,
            string maPhongBan,
            DateTime ngayBatDau,
            DateTime ngayKetThuc,
            decimal luongThuViec,
            string noiDung,
            string dieuKhoan)
        {
            KiemTra(maQDTD, soQuyetDinh, maNV, maPhongBan,
                ngayBatDau, ngayKetThuc, luongThuViec);

            string sql = @"
                UPDATE QuyetDinhTuyenDung
                SET SoQuyetDinh = @SoQuyetDinh,
                    NgayQuyetDinh = @NgayQuyetDinh,
                    MaNV = @MaNV,
                    MaPhongBan = @MaPhongBan,
                    NgayBatDauThuViec = @NgayBatDau,
                    NgayKetThucThuViec = @NgayKetThuc,
                    LuongThuViec = @LuongThuViec,
                    NoiDung = @NoiDung,
                    DieuKhoan = @DieuKhoan
                WHERE MaQDTD = @MaQDTD";

            return Db.Execute(sql,
                Db.P("@MaQDTD", maQDTD.Trim()),
                Db.P("@SoQuyetDinh", soQuyetDinh.Trim()),
                Db.P("@NgayQuyetDinh", ngayQuyetDinh.Date),
                Db.P("@MaNV", maNV),
                Db.P("@MaPhongBan", maPhongBan),
                Db.P("@NgayBatDau", ngayBatDau.Date),
                Db.P("@NgayKetThuc", ngayKetThuc.Date),
                Db.P("@LuongThuViec", luongThuViec),
                Db.P("@NoiDung", noiDung),
                Db.P("@DieuKhoan", dieuKhoan));
        }

        public int Xoa(string maQDTD)
        {
            if (string.IsNullOrWhiteSpace(maQDTD))
                throw new Exception("Vui lòng chọn quyết định cần xóa.");

            return Db.Execute(
                "DELETE FROM QuyetDinhTuyenDung WHERE MaQDTD = @MaQDTD",
                Db.P("@MaQDTD", maQDTD.Trim()));
        }

        private void KiemTra(
            string maQDTD,
            string soQuyetDinh,
            string maNV,
            string maPhongBan,
            DateTime ngayBatDau,
            DateTime ngayKetThuc,
            decimal luongThuViec)
        {
            if (string.IsNullOrWhiteSpace(maQDTD))
                throw new Exception("Vui lòng nhập mã quyết định.");

            if (string.IsNullOrWhiteSpace(soQuyetDinh))
                throw new Exception("Vui lòng nhập số quyết định.");

            if (string.IsNullOrWhiteSpace(maNV))
                throw new Exception("Vui lòng chọn nhân viên.");

            if (string.IsNullOrWhiteSpace(maPhongBan))
                throw new Exception("Vui lòng chọn phòng ban.");

            if (maQDTD.Trim().Length > 20)
                throw new Exception("Mã quyết định tối đa 20 ký tự.");

            if (soQuyetDinh.Trim().Length > 30)
                throw new Exception("Số quyết định tối đa 30 ký tự.");

            if (ngayKetThuc.Date < ngayBatDau.Date)
                throw new Exception(
                    "Ngày kết thúc thử việc phải từ ngày bắt đầu trở đi.");

            if (luongThuViec < 0)
                throw new Exception("Lương thử việc không được âm.");
        }
    }
}
