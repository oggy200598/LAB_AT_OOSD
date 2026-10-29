
using System;
using System.Data;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class ChucVuService
    {
        public DataTable LayDanhSach()
        {
            string sql = @"SELECT MaChucVu, TenChucVu, MoTa,
                           PhuCapChucVu
                           FROM ChucVu
                           ORDER BY MaChucVu";

            return Db.Query(sql);
        }

        public DataTable TimKiem(string tuKhoa)
        {
            string sql = @"SELECT MaChucVu, TenChucVu, MoTa,
                           PhuCapChucVu
                           FROM ChucVu
                           WHERE MaChucVu LIKE @TuKhoa
                              OR TenChucVu LIKE @TuKhoa
                              OR MoTa LIKE @TuKhoa
                           ORDER BY MaChucVu";

            return Db.Query(
                sql,
                Db.P("@TuKhoa", "%" + tuKhoa.Trim() + "%"));
        }

        public bool KiemTraTonTai(string maChucVu)
        {
            string sql = @"SELECT COUNT(*)
                           FROM ChucVu
                           WHERE MaChucVu = @MaChucVu";

            return Convert.ToInt32(
                Db.Scalar(sql, Db.P("@MaChucVu", maChucVu))) > 0;
        }

        public int Them(string maChucVu, string tenChucVu,
            string moTa, decimal phuCapChucVu)
        {
            KiemTraDuLieu(maChucVu, tenChucVu, phuCapChucVu);

            if (KiemTraTonTai(maChucVu.Trim()))
                throw new Exception("Mã chức vụ đã tồn tại.");

            string sql = @"INSERT INTO ChucVu
                           (MaChucVu, TenChucVu, MoTa, PhuCapChucVu)
                           VALUES
                           (@MaChucVu, @TenChucVu, @MoTa, @PhuCapChucVu)";

            return Db.Execute(
                sql,
                Db.P("@MaChucVu", maChucVu.Trim()),
                Db.P("@TenChucVu", tenChucVu.Trim()),
                Db.P("@MoTa", moTa),
                Db.P("@PhuCapChucVu", phuCapChucVu));
        }

        public int Sua(string maChucVu, string tenChucVu,
            string moTa, decimal phuCapChucVu)
        {
            KiemTraDuLieu(maChucVu, tenChucVu, phuCapChucVu);

            string sql = @"UPDATE ChucVu
                           SET TenChucVu = @TenChucVu,
                               MoTa = @MoTa,
                               PhuCapChucVu = @PhuCapChucVu
                           WHERE MaChucVu = @MaChucVu";

            return Db.Execute(
                sql,
                Db.P("@MaChucVu", maChucVu.Trim()),
                Db.P("@TenChucVu", tenChucVu.Trim()),
                Db.P("@MoTa", moTa),
                Db.P("@PhuCapChucVu", phuCapChucVu));
        }

        public int Xoa(string maChucVu)
        {
            if (string.IsNullOrWhiteSpace(maChucVu))
                throw new Exception("Vui lòng chọn chức vụ cần xóa.");

            string sql = @"DELETE FROM ChucVu
                           WHERE MaChucVu = @MaChucVu";

            return Db.Execute(
                sql,
                Db.P("@MaChucVu", maChucVu.Trim()));
        }

        private void KiemTraDuLieu(
            string maChucVu,
            string tenChucVu,
            decimal phuCapChucVu)
        {
            if (string.IsNullOrWhiteSpace(maChucVu))
                throw new Exception("Vui lòng nhập mã chức vụ.");

            if (string.IsNullOrWhiteSpace(tenChucVu))
                throw new Exception("Vui lòng nhập tên chức vụ.");

            if (phuCapChucVu < 0)
                throw new Exception("Phụ cấp chức vụ không được âm.");

            if (maChucVu.Trim().Length > 20)
                throw new Exception("Mã chức vụ tối đa 20 ký tự.");

            if (tenChucVu.Trim().Length > 100)
                throw new Exception("Tên chức vụ tối đa 100 ký tự.");
        }
    }
}
