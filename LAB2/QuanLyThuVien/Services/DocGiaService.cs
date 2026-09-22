using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyThuVien.Data;

namespace QuanLyThuVien.Services
{
    public class DocGiaService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(@"
                SELECT
                    T.MaThe,
                    DG.MaDocGia,
                    DG.Ho,
                    DG.Ten,
                    DG.NgaySinh,
                    DG.Phai,
                    DG.SoDienThoai,
                    DG.DiaChi,
                    DG.Email,
                    DG.Anh3x4,
                    T.NgayCap,
                    T.HanSuDung,
                    T.DaDongLePhi,
                    T.TrangThai
                FROM DOCGIA DG
                LEFT JOIN THEDOCGIA T
                    ON DG.MaDocGia = T.MaDocGia
                ORDER BY DG.MaDocGia");
        }

        public DataTable LayTheDocGia()
        {
            return Db.Query(@"
                SELECT
                    T.MaThe,
                    T.MaDocGia,
                    DG.Ho,
                    DG.Ten,
                    T.NgayCap,
                    T.HanSuDung,
                    T.DaDongLePhi,
                    T.TrangThai
                FROM THEDOCGIA T
                INNER JOIN DOCGIA DG
                    ON T.MaDocGia = DG.MaDocGia
                ORDER BY T.MaThe");
        }

        public int ThemDocGia(
            string maDocGia,
            string ho,
            string ten,
            DateTime ngaySinh,
            string phai,
            string soDienThoai,
            string diaChi,
            string email,
            string anh3x4)
        {
            return Db.Execute(@"
                INSERT INTO DOCGIA
                (
                    MaDocGia,
                    Ho,
                    Ten,
                    NgaySinh,
                    Phai,
                    SoDienThoai,
                    DiaChi,
                    Email,
                    Anh3x4
                )
                VALUES
                (
                    @MaDocGia,
                    @Ho,
                    @Ten,
                    @NgaySinh,
                    @Phai,
                    @SoDienThoai,
                    @DiaChi,
                    @Email,
                    @Anh3x4
                )",
                new SqlParameter("@MaDocGia", maDocGia),
                new SqlParameter("@Ho", ho),
                new SqlParameter("@Ten", ten),
                new SqlParameter("@NgaySinh", ngaySinh),
                new SqlParameter("@Phai", phai),
                new SqlParameter("@SoDienThoai", soDienThoai),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@Email", email),
                new SqlParameter("@Anh3x4", anh3x4));
        }

        public int CapNhatDocGia(
            string maDocGia,
            string ho,
            string ten,
            DateTime ngaySinh,
            string phai,
            string soDienThoai,
            string diaChi,
            string email,
            string anh3x4)
        {
            return Db.Execute(@"
                UPDATE DOCGIA
                SET
                    Ho = @Ho,
                    Ten = @Ten,
                    NgaySinh = @NgaySinh,
                    Phai = @Phai,
                    SoDienThoai = @SoDienThoai,
                    DiaChi = @DiaChi,
                    Email = @Email,
                    Anh3x4 = @Anh3x4
                WHERE MaDocGia = @MaDocGia",
                new SqlParameter("@MaDocGia", maDocGia),
                new SqlParameter("@Ho", ho),
                new SqlParameter("@Ten", ten),
                new SqlParameter("@NgaySinh", ngaySinh),
                new SqlParameter("@Phai", phai),
                new SqlParameter("@SoDienThoai", soDienThoai),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@Email", email),
                new SqlParameter("@Anh3x4", anh3x4));
        }

        public int CapThe(
            string maThe,
            string maDocGia,
            DateTime ngayCap,
            DateTime hanSuDung,
            bool daDongLePhi,
            string trangThai)
        {
            return Db.Execute(@"
                INSERT INTO THEDOCGIA
                (
                    MaThe,
                    MaDocGia,
                    NgayCap,
                    HanSuDung,
                    DaDongLePhi,
                    TrangThai
                )
                VALUES
                (
                    @MaThe,
                    @MaDocGia,
                    @NgayCap,
                    @HanSuDung,
                    @DaDongLePhi,
                    @TrangThai
                )",
                new SqlParameter("@MaThe", maThe),
                new SqlParameter("@MaDocGia", maDocGia),
                new SqlParameter("@NgayCap", ngayCap),
                new SqlParameter("@HanSuDung", hanSuDung),
                new SqlParameter("@DaDongLePhi", daDongLePhi),
                new SqlParameter("@TrangThai", trangThai));
        }

        public int GiaHanThe(
            string maDocGia,
            DateTime hanSuDung,
            bool daDongLePhi,
            string trangThai)
        {
            return Db.Execute(@"
                UPDATE THEDOCGIA
                SET
                    HanSuDung = @HanSuDung,
                    DaDongLePhi = @DaDongLePhi,
                    TrangThai = @TrangThai
                WHERE MaDocGia = @MaDocGia",
                new SqlParameter("@MaDocGia", maDocGia),
                new SqlParameter("@HanSuDung", hanSuDung),
                new SqlParameter("@DaDongLePhi", daDongLePhi),
                new SqlParameter("@TrangThai", trangThai));
        }

        public DataTable LayTheTheoDocGia(
            string maDocGia)
        {
            return Db.Query(@"
                SELECT
                    MaThe,
                    MaDocGia,
                    NgayCap,
                    HanSuDung,
                    DaDongLePhi,
                    TrangThai
                FROM THEDOCGIA
                WHERE MaDocGia = @MaDocGia",
                new SqlParameter("@MaDocGia", maDocGia));
        }
    }
}