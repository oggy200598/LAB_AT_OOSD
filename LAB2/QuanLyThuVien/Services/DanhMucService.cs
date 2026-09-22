using System.Data;
using System.Data.SqlClient;
using QuanLyThuVien.Data;

namespace QuanLyThuVien.Services
{
    public class DanhMucService
    {
        public DataTable LayNhanVien()
        {
            return Db.Query(@"
                SELECT
                    MaNhanVien,
                    Ho,
                    Ten,
                    Phai,
                    NgaySinh,
                    ChucVu,
                    SoDienThoai
                FROM NHANVIEN
                ORDER BY MaNhanVien");
        }

        public DataTable LayTheLoai()
        {
            return Db.Query(@"
                SELECT
                    MaTheLoai,
                    TenTheLoai
                FROM THELOAI
                ORDER BY MaTheLoai");
        }

        public DataTable LayNhaXuatBan()
        {
            return Db.Query(@"
                SELECT
                    MaNhaXuatBan,
                    DiaChi,
                    SoDienThoai
                FROM NHAXUATBAN
                ORDER BY MaNhaXuatBan");
        }

        public int ThemNhanVien(
            string ma,
            string ho,
            string ten,
            string phai,
            System.DateTime ngaySinh,
            string chucVu,
            string soDienThoai)
        {
            return Db.Execute(@"
                INSERT INTO NHANVIEN
                (
                    MaNhanVien,
                    Ho,
                    Ten,
                    Phai,
                    NgaySinh,
                    ChucVu,
                    SoDienThoai
                )
                VALUES
                (
                    @Ma,
                    @Ho,
                    @Ten,
                    @Phai,
                    @NgaySinh,
                    @ChucVu,
                    @SoDienThoai
                )",
                new SqlParameter("@Ma", ma),
                new SqlParameter("@Ho", ho),
                new SqlParameter("@Ten", ten),
                new SqlParameter("@Phai", phai),
                new SqlParameter("@NgaySinh", ngaySinh),
                new SqlParameter("@ChucVu", chucVu),
                new SqlParameter("@SoDienThoai", soDienThoai));
        }

        public int CapNhatNhanVien(
            string ma,
            string ho,
            string ten,
            string phai,
            System.DateTime ngaySinh,
            string chucVu,
            string soDienThoai)
        {
            return Db.Execute(@"
                UPDATE NHANVIEN
                SET
                    Ho = @Ho,
                    Ten = @Ten,
                    Phai = @Phai,
                    NgaySinh = @NgaySinh,
                    ChucVu = @ChucVu,
                    SoDienThoai = @SoDienThoai
                WHERE MaNhanVien = @Ma",
                new SqlParameter("@Ma", ma),
                new SqlParameter("@Ho", ho),
                new SqlParameter("@Ten", ten),
                new SqlParameter("@Phai", phai),
                new SqlParameter("@NgaySinh", ngaySinh),
                new SqlParameter("@ChucVu", chucVu),
                new SqlParameter("@SoDienThoai", soDienThoai));
        }

        public int XoaNhanVien(string ma)
        {
            return Db.Execute(
                "DELETE FROM NHANVIEN WHERE MaNhanVien = @Ma",
                new SqlParameter("@Ma", ma));
        }

        public int ThemTheLoai(string ma, string ten)
        {
            return Db.Execute(@"
                INSERT INTO THELOAI
                (
                    MaTheLoai,
                    TenTheLoai
                )
                VALUES
                (
                    @Ma,
                    @Ten
                )",
                new SqlParameter("@Ma", ma),
                new SqlParameter("@Ten", ten));
        }

        public int CapNhatTheLoai(string ma, string ten)
        {
            return Db.Execute(@"
                UPDATE THELOAI
                SET TenTheLoai = @Ten
                WHERE MaTheLoai = @Ma",
                new SqlParameter("@Ma", ma),
                new SqlParameter("@Ten", ten));
        }

        public int XoaTheLoai(string ma)
        {
            return Db.Execute(
                "DELETE FROM THELOAI WHERE MaTheLoai = @Ma",
                new SqlParameter("@Ma", ma));
        }

        public int ThemNhaXuatBan(
            string ma,
            string diaChi,
            string soDienThoai)
        {
            return Db.Execute(@"
                INSERT INTO NHAXUATBAN
                (
                    MaNhaXuatBan,
                    DiaChi,
                    SoDienThoai
                )
                VALUES
                (
                    @Ma,
                    @DiaChi,
                    @SoDienThoai
                )",
                new SqlParameter("@Ma", ma),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@SoDienThoai", soDienThoai));
        }

        public int CapNhatNhaXuatBan(
            string ma,
            string diaChi,
            string soDienThoai)
        {
            return Db.Execute(@"
                UPDATE NHAXUATBAN
                SET
                    DiaChi = @DiaChi,
                    SoDienThoai = @SoDienThoai
                WHERE MaNhaXuatBan = @Ma",
                new SqlParameter("@Ma", ma),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@SoDienThoai", soDienThoai));
        }

        public int XoaNhaXuatBan(string ma)
        {
            return Db.Execute(
                "DELETE FROM NHAXUATBAN WHERE MaNhaXuatBan = @Ma",
                new SqlParameter("@Ma", ma));
        }
    }
}