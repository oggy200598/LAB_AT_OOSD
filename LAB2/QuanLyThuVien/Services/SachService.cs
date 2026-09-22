using System.Data;
using System.Data.SqlClient;
using QuanLyThuVien.Data;

namespace QuanLyThuVien.Services
{
    public class SachService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(@"
                SELECT
                    MaDauSach,
                    TenSach,
                    NamXuatBan,
                    SoLuongHienCo,
                    MaTheLoai,
                    MaNhaXuatBan
                FROM DAUSACH
                ORDER BY MaDauSach");
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

        public int ThemSach(
            string maDauSach,
            string tenSach,
            int namXuatBan,
            int soLuongHienCo,
            string maTheLoai,
            string maNhaXuatBan)
        {
            return Db.Execute(@"
                INSERT INTO DAUSACH
                (
                    MaDauSach,
                    TenSach,
                    NamXuatBan,
                    SoLuongHienCo,
                    MaTheLoai,
                    MaNhaXuatBan
                )
                VALUES
                (
                    @MaDauSach,
                    @TenSach,
                    @NamXuatBan,
                    @SoLuongHienCo,
                    @MaTheLoai,
                    @MaNhaXuatBan
                )",
                new SqlParameter("@MaDauSach", maDauSach),
                new SqlParameter("@TenSach", tenSach),
                new SqlParameter("@NamXuatBan", namXuatBan),
                new SqlParameter("@SoLuongHienCo", soLuongHienCo),
                new SqlParameter("@MaTheLoai", maTheLoai),
                new SqlParameter("@MaNhaXuatBan", maNhaXuatBan));
        }

        public int CapNhatSach(
            string maDauSach,
            string tenSach,
            int namXuatBan,
            int soLuongHienCo,
            string maTheLoai,
            string maNhaXuatBan)
        {
            return Db.Execute(@"
                UPDATE DAUSACH
                SET
                    TenSach = @TenSach,
                    NamXuatBan = @NamXuatBan,
                    SoLuongHienCo = @SoLuongHienCo,
                    MaTheLoai = @MaTheLoai,
                    MaNhaXuatBan = @MaNhaXuatBan
                WHERE MaDauSach = @MaDauSach",
                new SqlParameter("@MaDauSach", maDauSach),
                new SqlParameter("@TenSach", tenSach),
                new SqlParameter("@NamXuatBan", namXuatBan),
                new SqlParameter("@SoLuongHienCo", soLuongHienCo),
                new SqlParameter("@MaTheLoai", maTheLoai),
                new SqlParameter("@MaNhaXuatBan", maNhaXuatBan));
        }

        public int XoaSach(string maDauSach)
        {
            return Db.Execute(
                "DELETE FROM DAUSACH WHERE MaDauSach = @MaDauSach",
                new SqlParameter("@MaDauSach", maDauSach));
        }
    }
}