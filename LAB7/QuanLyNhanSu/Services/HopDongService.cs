
using System;
using System.Data;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class HopDongService
    {
        public DataTable LayDanhSach()
        {
            string sql = @"
                SELECT hd.MaHopDong, hd.SoHopDong,
                       hd.MaNV, nv.HoTen,
                       hd.LoaiHopDong, hd.NgayKy,
                       hd.NgayBatDau, hd.NgayKetThuc,
                       hd.NoiDungHopDong, hd.TrangThai
                FROM HopDongLaoDong hd
                INNER JOIN NhanVien nv
                    ON hd.MaNV = nv.MaNV
                ORDER BY hd.NgayKy DESC, hd.MaHopDong";

            return Db.Query(sql);
        }

        public DataTable LayNhanVien()
        {
            return Db.Query(@"
                SELECT MaNV, HoTen
                FROM NhanVien
                ORDER BY HoTen");
        }

        public DataTable TimKiem(string tuKhoa)
        {
            string sql = @"
                SELECT hd.MaHopDong, hd.SoHopDong,
                       hd.MaNV, nv.HoTen,
                       hd.LoaiHopDong, hd.NgayKy,
                       hd.NgayBatDau, hd.NgayKetThuc,
                       hd.NoiDungHopDong, hd.TrangThai
                FROM HopDongLaoDong hd
                INNER JOIN NhanVien nv
                    ON hd.MaNV = nv.MaNV
                WHERE hd.MaHopDong LIKE @TuKhoa
                   OR hd.SoHopDong LIKE @TuKhoa
                   OR hd.MaNV LIKE @TuKhoa
                   OR nv.HoTen LIKE @TuKhoa
                   OR hd.LoaiHopDong LIKE @TuKhoa
                   OR hd.TrangThai LIKE @TuKhoa
                ORDER BY hd.NgayKy DESC, hd.MaHopDong";

            return Db.Query(
                sql,
                Db.P("@TuKhoa", "%" + (tuKhoa ?? "").Trim() + "%"));
        }

        public bool KiemTraTonTai(string maHopDong)
        {
            string sql = @"
                SELECT COUNT(*)
                FROM HopDongLaoDong
                WHERE MaHopDong = @MaHopDong";

            return Convert.ToInt32(
                Db.Scalar(
                    sql,
                    Db.P("@MaHopDong", maHopDong.Trim()))) > 0;
        }

        public int Them(
            string maHopDong,
            string soHopDong,
            string maNV,
            string loaiHopDong,
            DateTime ngayKy,
            DateTime ngayBatDau,
            DateTime? ngayKetThuc,
            string noiDungHopDong,
            string trangThai)
        {
            KiemTraDuLieu(
                maHopDong, soHopDong, maNV,
                loaiHopDong, ngayBatDau, ngayKetThuc,
                trangThai);

            if (KiemTraTonTai(maHopDong))
                throw new Exception("Mã hợp đồng đã tồn tại.");

            string sql = @"
                INSERT INTO HopDongLaoDong
                (
                    MaHopDong, SoHopDong, MaNV,
                    LoaiHopDong, NgayKy, NgayBatDau,
                    NgayKetThuc, NoiDungHopDong, TrangThai
                )
                VALUES
                (
                    @MaHopDong, @SoHopDong, @MaNV,
                    @LoaiHopDong, @NgayKy, @NgayBatDau,
                    @NgayKetThuc, @NoiDungHopDong, @TrangThai
                )";

            return Db.Execute(
                sql,
                Db.P("@MaHopDong", maHopDong.Trim()),
                Db.P("@SoHopDong", soHopDong.Trim()),
                Db.P("@MaNV", maNV),
                Db.P("@LoaiHopDong", loaiHopDong),
                Db.P("@NgayKy", ngayKy.Date),
                Db.P("@NgayBatDau", ngayBatDau.Date),
                Db.P("@NgayKetThuc",
                    ngayKetThuc.HasValue
                        ? (object)ngayKetThuc.Value.Date
                        : DBNull.Value),
                Db.P("@NoiDungHopDong", noiDungHopDong),
                Db.P("@TrangThai", trangThai));
        }

        public int Sua(
            string maHopDong,
            string soHopDong,
            string maNV,
            string loaiHopDong,
            DateTime ngayKy,
            DateTime ngayBatDau,
            DateTime? ngayKetThuc,
            string noiDungHopDong,
            string trangThai)
        {
            KiemTraDuLieu(
                maHopDong, soHopDong, maNV,
                loaiHopDong, ngayBatDau, ngayKetThuc,
                trangThai);

            string sql = @"
                UPDATE HopDongLaoDong
                SET SoHopDong = @SoHopDong,
                    MaNV = @MaNV,
                    LoaiHopDong = @LoaiHopDong,
                    NgayKy = @NgayKy,
                    NgayBatDau = @NgayBatDau,
                    NgayKetThuc = @NgayKetThuc,
                    NoiDungHopDong = @NoiDungHopDong,
                    TrangThai = @TrangThai
                WHERE MaHopDong = @MaHopDong";

            return Db.Execute(
                sql,
                Db.P("@MaHopDong", maHopDong.Trim()),
                Db.P("@SoHopDong", soHopDong.Trim()),
                Db.P("@MaNV", maNV),
                Db.P("@LoaiHopDong", loaiHopDong),
                Db.P("@NgayKy", ngayKy.Date),
                Db.P("@NgayBatDau", ngayBatDau.Date),
                Db.P("@NgayKetThuc",
                    ngayKetThuc.HasValue
                        ? (object)ngayKetThuc.Value.Date
                        : DBNull.Value),
                Db.P("@NoiDungHopDong", noiDungHopDong),
                Db.P("@TrangThai", trangThai));
        }

        public int Xoa(string maHopDong)
        {
            if (string.IsNullOrWhiteSpace(maHopDong))
                throw new Exception("Vui lòng chọn hợp đồng cần xóa.");

            string sql = @"
                DELETE FROM HopDongLaoDong
                WHERE MaHopDong = @MaHopDong";

            return Db.Execute(
                sql,
                Db.P("@MaHopDong", maHopDong.Trim()));
        }

        private void KiemTraDuLieu(
            string maHopDong,
            string soHopDong,
            string maNV,
            string loaiHopDong,
            DateTime ngayBatDau,
            DateTime? ngayKetThuc,
            string trangThai)
        {
            if (string.IsNullOrWhiteSpace(maHopDong))
                throw new Exception("Vui lòng nhập mã hợp đồng.");

            if (string.IsNullOrWhiteSpace(soHopDong))
                throw new Exception("Vui lòng nhập số hợp đồng.");

            if (string.IsNullOrWhiteSpace(maNV))
                throw new Exception("Vui lòng chọn nhân viên.");

            if (maHopDong.Trim().Length > 20)
                throw new Exception("Mã hợp đồng tối đa 20 ký tự.");

            if (soHopDong.Trim().Length > 30)
                throw new Exception("Số hợp đồng tối đa 30 ký tự.");

            if (loaiHopDong != "Dài hạn" &&
                loaiHopDong != "Ngắn hạn")
                throw new Exception("Loại hợp đồng không hợp lệ.");

            if (ngayKetThuc.HasValue &&
                ngayKetThuc.Value.Date < ngayBatDau.Date)
                throw new Exception(
                    "Ngày kết thúc không được trước ngày bắt đầu.");

            if (trangThai != "Có hiệu lực" &&
                trangThai != "Hết hiệu lực" &&
                trangThai != "Chấm dứt")
                throw new Exception("Trạng thái hợp đồng không hợp lệ.");
        }
    }
}
