
using System;
using System.Data;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class NhanVienService
    {
        public DataTable LayDanhSach()
        {
            string sql = @"
                SELECT nv.MaNV, nv.HoTen, nv.NgaySinh,
                       nv.GioiTinh, nv.DiaChi, nv.SoDienThoai,
                       nv.Email, nv.NgayVaoLam, nv.TrangThai,
                       nv.MaPhongBan, pb.TenPhongBan
                FROM NhanVien nv
                INNER JOIN PhongBan pb
                    ON nv.MaPhongBan = pb.MaPhongBan
                ORDER BY nv.MaNV";

            return Db.Query(sql);
        }

        public DataTable LayDanhSachPhongBan()
        {
            string sql = @"
                SELECT MaPhongBan, TenPhongBan
                FROM PhongBan
                ORDER BY TenPhongBan";

            return Db.Query(sql);
        }

        public DataTable TimKiem(string tuKhoa)
        {
            string sql = @"
                SELECT nv.MaNV, nv.HoTen, nv.NgaySinh,
                       nv.GioiTinh, nv.DiaChi, nv.SoDienThoai,
                       nv.Email, nv.NgayVaoLam, nv.TrangThai,
                       nv.MaPhongBan, pb.TenPhongBan
                FROM NhanVien nv
                INNER JOIN PhongBan pb
                    ON nv.MaPhongBan = pb.MaPhongBan
                WHERE nv.MaNV LIKE @TuKhoa
                   OR nv.HoTen LIKE @TuKhoa
                   OR nv.SoDienThoai LIKE @TuKhoa
                   OR nv.Email LIKE @TuKhoa
                   OR pb.TenPhongBan LIKE @TuKhoa
                ORDER BY nv.MaNV";

            return Db.Query(
                sql,
                Db.P("@TuKhoa", "%" + tuKhoa.Trim() + "%"));
        }

        public bool KiemTraTonTai(string maNV)
        {
            string sql = @"
                SELECT COUNT(*)
                FROM NhanVien
                WHERE MaNV = @MaNV";

            return Convert.ToInt32(
                Db.Scalar(sql, Db.P("@MaNV", maNV))) > 0;
        }

        public int Them(
            string maNV,
            string hoTen,
            DateTime ngaySinh,
            string gioiTinh,
            string diaChi,
            string soDienThoai,
            string email,
            DateTime? ngayVaoLam,
            string trangThai,
            string maPhongBan)
        {
            KiemTraDuLieu(
                maNV, hoTen, ngaySinh, soDienThoai,
                email, trangThai, maPhongBan);

            if (KiemTraTonTai(maNV.Trim()))
                throw new Exception("Mã nhân viên đã tồn tại.");

            string sql = @"
                INSERT INTO NhanVien
                (
                    MaNV, HoTen, NgaySinh, GioiTinh,
                    DiaChi, SoDienThoai, Email,
                    NgayVaoLam, TrangThai, MaPhongBan
                )
                VALUES
                (
                    @MaNV, @HoTen, @NgaySinh, @GioiTinh,
                    @DiaChi, @SoDienThoai, @Email,
                    @NgayVaoLam, @TrangThai, @MaPhongBan
                )";

            return Db.Execute(
                sql,
                Db.P("@MaNV", maNV.Trim()),
                Db.P("@HoTen", hoTen.Trim()),
                Db.P("@NgaySinh", ngaySinh.Date),
                Db.P("@GioiTinh", gioiTinh),
                Db.P("@DiaChi", diaChi),
                Db.P("@SoDienThoai", soDienThoai),
                Db.P("@Email", email),
                Db.P("@NgayVaoLam", ngayVaoLam.HasValue
                    ? (object)ngayVaoLam.Value.Date
                    : DBNull.Value),
                Db.P("@TrangThai", trangThai),
                Db.P("@MaPhongBan", maPhongBan));
        }

        public int Sua(
            string maNV,
            string hoTen,
            DateTime ngaySinh,
            string gioiTinh,
            string diaChi,
            string soDienThoai,
            string email,
            DateTime? ngayVaoLam,
            string trangThai,
            string maPhongBan)
        {
            KiemTraDuLieu(
                maNV, hoTen, ngaySinh, soDienThoai,
                email, trangThai, maPhongBan);

            string sql = @"
                UPDATE NhanVien
                SET HoTen = @HoTen,
                    NgaySinh = @NgaySinh,
                    GioiTinh = @GioiTinh,
                    DiaChi = @DiaChi,
                    SoDienThoai = @SoDienThoai,
                    Email = @Email,
                    NgayVaoLam = @NgayVaoLam,
                    TrangThai = @TrangThai,
                    MaPhongBan = @MaPhongBan
                WHERE MaNV = @MaNV";

            return Db.Execute(
                sql,
                Db.P("@MaNV", maNV.Trim()),
                Db.P("@HoTen", hoTen.Trim()),
                Db.P("@NgaySinh", ngaySinh.Date),
                Db.P("@GioiTinh", gioiTinh),
                Db.P("@DiaChi", diaChi),
                Db.P("@SoDienThoai", soDienThoai),
                Db.P("@Email", email),
                Db.P("@NgayVaoLam", ngayVaoLam.HasValue
                    ? (object)ngayVaoLam.Value.Date
                    : DBNull.Value),
                Db.P("@TrangThai", trangThai),
                Db.P("@MaPhongBan", maPhongBan));
        }

        public int Xoa(string maNV)
        {
            if (string.IsNullOrWhiteSpace(maNV))
                throw new Exception("Vui lòng chọn nhân viên cần xóa.");

            string sql = @"
                DELETE FROM NhanVien
                WHERE MaNV = @MaNV";

            return Db.Execute(
                sql,
                Db.P("@MaNV", maNV.Trim()));
        }

        private void KiemTraDuLieu(
            string maNV,
            string hoTen,
            DateTime ngaySinh,
            string soDienThoai,
            string email,
            string trangThai,
            string maPhongBan)
        {
            if (string.IsNullOrWhiteSpace(maNV))
                throw new Exception("Vui lòng nhập mã nhân viên.");

            if (string.IsNullOrWhiteSpace(hoTen))
                throw new Exception("Vui lòng nhập họ tên nhân viên.");

            if (string.IsNullOrWhiteSpace(maPhongBan))
                throw new Exception("Vui lòng chọn phòng ban.");

            if (string.IsNullOrWhiteSpace(trangThai))
                throw new Exception("Vui lòng chọn trạng thái.");

            if (ngaySinh.Date > DateTime.Today)
                throw new Exception("Ngày sinh không được lớn hơn ngày hiện tại.");

            if (maNV.Trim().Length > 20)
                throw new Exception("Mã nhân viên tối đa 20 ký tự.");

            if (hoTen.Trim().Length > 100)
                throw new Exception("Họ tên tối đa 100 ký tự.");

            if (!string.IsNullOrWhiteSpace(soDienThoai) &&
                soDienThoai.Trim().Length > 15)
                throw new Exception("Số điện thoại tối đa 15 ký tự.");

            if (!string.IsNullOrWhiteSpace(email) &&
                (email.Trim().Length > 100 ||
                 !email.Contains("@")))
                throw new Exception("Email không hợp lệ.");
        }
    }
}
