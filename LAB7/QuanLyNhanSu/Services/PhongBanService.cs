
using System;
using System.Data;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class PhongBanService
    {
        public DataTable LayDanhSach()
        {
            string sql = @"SELECT MaPhongBan, TenPhongBan, DiaDiem,
                           SoDienThoai, MoTa
                           FROM PhongBan
                           ORDER BY MaPhongBan";

            return Db.Query(sql);
        }

        public DataTable TimKiem(string tuKhoa)
        {
            string sql = @"SELECT MaPhongBan, TenPhongBan, DiaDiem,
                           SoDienThoai, MoTa
                           FROM PhongBan
                           WHERE MaPhongBan LIKE @TuKhoa
                              OR TenPhongBan LIKE @TuKhoa
                              OR DiaDiem LIKE @TuKhoa
                           ORDER BY MaPhongBan";

            return Db.Query(sql, Db.P("@TuKhoa", "%" + tuKhoa + "%"));
        }

        public bool KiemTraTonTai(string maPhongBan)
        {
            string sql = @"SELECT COUNT(*)
                           FROM PhongBan
                           WHERE MaPhongBan = @MaPhongBan";

            int soLuong = Convert.ToInt32(
                Db.Scalar(sql, Db.P("@MaPhongBan", maPhongBan)));

            return soLuong > 0;
        }

        public int Them(string maPhongBan, string tenPhongBan,
            string diaDiem, string soDienThoai, string moTa)
        {
            if (string.IsNullOrWhiteSpace(maPhongBan))
                throw new Exception("Vui lòng nhập mã phòng ban.");

            if (string.IsNullOrWhiteSpace(tenPhongBan))
                throw new Exception("Vui lòng nhập tên phòng ban.");

            if (KiemTraTonTai(maPhongBan))
                throw new Exception("Mã phòng ban đã tồn tại.");

            string sql = @"INSERT INTO PhongBan
                           (MaPhongBan, TenPhongBan, DiaDiem,
                            SoDienThoai, MoTa)
                           VALUES
                           (@MaPhongBan, @TenPhongBan, @DiaDiem,
                            @SoDienThoai, @MoTa)";

            return Db.Execute(
                sql,
                Db.P("@MaPhongBan", maPhongBan.Trim()),
                Db.P("@TenPhongBan", tenPhongBan.Trim()),
                Db.P("@DiaDiem", diaDiem),
                Db.P("@SoDienThoai", soDienThoai),
                Db.P("@MoTa", moTa)
            );
        }

        public int Sua(string maPhongBan, string tenPhongBan,
            string diaDiem, string soDienThoai, string moTa)
        {
            if (string.IsNullOrWhiteSpace(maPhongBan))
                throw new Exception("Vui lòng chọn phòng ban cần sửa.");

            if (string.IsNullOrWhiteSpace(tenPhongBan))
                throw new Exception("Vui lòng nhập tên phòng ban.");

            string sql = @"UPDATE PhongBan
                           SET TenPhongBan = @TenPhongBan,
                               DiaDiem = @DiaDiem,
                               SoDienThoai = @SoDienThoai,
                               MoTa = @MoTa
                           WHERE MaPhongBan = @MaPhongBan";

            return Db.Execute(
                sql,
                Db.P("@MaPhongBan", maPhongBan.Trim()),
                Db.P("@TenPhongBan", tenPhongBan.Trim()),
                Db.P("@DiaDiem", diaDiem),
                Db.P("@SoDienThoai", soDienThoai),
                Db.P("@MoTa", moTa)
            );
        }

        public int Xoa(string maPhongBan)
        {
            if (string.IsNullOrWhiteSpace(maPhongBan))
                throw new Exception("Vui lòng chọn phòng ban cần xóa.");

            string sql = @"DELETE FROM PhongBan
                           WHERE MaPhongBan = @MaPhongBan";

            return Db.Execute(
                sql,
                Db.P("@MaPhongBan", maPhongBan)
            );
        }
    }
}
