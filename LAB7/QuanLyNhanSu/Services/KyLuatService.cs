using System;
using System.Data;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class KyLuatService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(@"
                SELECT q.MaQDKL, q.SoQuyetDinh, q.NgayQuyetDinh,
                       q.LoaiDoiTuong, q.MaNV, nv.HoTen,
                       q.MaPhongBan, p.TenPhongBan,
                       q.LyDoKyLuat, q.HinhThucKyLuat,
                       q.SoTienPhat, q.NguoiKy
                FROM QuyetDinhKyLuat q
                LEFT JOIN NhanVien nv ON q.MaNV = nv.MaNV
                LEFT JOIN PhongBan p ON q.MaPhongBan = p.MaPhongBan
                ORDER BY q.NgayQuyetDinh DESC, q.MaQDKL");
        }

        public DataTable LayNhanVien()
        {
            return Db.Query(@"
                SELECT MaNV, MaNV + N' - ' + HoTen AS TenNhanVien
                FROM NhanVien
                ORDER BY MaNV");
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
                SELECT q.MaQDKL, q.SoQuyetDinh, q.NgayQuyetDinh,
                       q.LoaiDoiTuong, q.MaNV, nv.HoTen,
                       q.MaPhongBan, p.TenPhongBan,
                       q.LyDoKyLuat, q.HinhThucKyLuat,
                       q.SoTienPhat, q.NguoiKy
                FROM QuyetDinhKyLuat q
                LEFT JOIN NhanVien nv ON q.MaNV = nv.MaNV
                LEFT JOIN PhongBan p ON q.MaPhongBan = p.MaPhongBan
                WHERE q.MaQDKL LIKE @TuKhoa
                   OR q.SoQuyetDinh LIKE @TuKhoa
                   OR q.LoaiDoiTuong LIKE @TuKhoa
                   OR q.MaNV LIKE @TuKhoa
                   OR nv.HoTen LIKE @TuKhoa
                   OR q.MaPhongBan LIKE @TuKhoa
                   OR p.TenPhongBan LIKE @TuKhoa
                   OR q.LyDoKyLuat LIKE @TuKhoa
                   OR q.HinhThucKyLuat LIKE @TuKhoa
                   OR q.NguoiKy LIKE @TuKhoa
                ORDER BY q.NgayQuyetDinh DESC, q.MaQDKL",
                Db.P("@TuKhoa", "%" + (tuKhoa ?? "").Trim() + "%"));
        }

        public bool KiemTraTonTai(string maQDKL)
        {
            if (string.IsNullOrWhiteSpace(maQDKL))
                return false;

            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM QuyetDinhKyLuat
                WHERE MaQDKL = @Ma",
                Db.P("@Ma", maQDKL.Trim()))) > 0;
        }

        public bool KiemTraTrungSoQuyetDinh(
            string soQuyetDinh, string maQDKL)
        {
            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM QuyetDinhKyLuat
                WHERE SoQuyetDinh = @So
                  AND MaQDKL <> @Ma",
                Db.P("@So", soQuyetDinh.Trim()),
                Db.P("@Ma", maQDKL.Trim()))) > 0;
        }

        public int Them(
            string maQDKL,
            string soQuyetDinh,
            DateTime ngayQuyetDinh,
            string loaiDoiTuong,
            string maNV,
            string maPhongBan,
            string lyDoKyLuat,
            string hinhThucKyLuat,
            decimal soTienPhat,
            string nguoiKy)
        {
            KiemTraDuLieu(
                maQDKL, soQuyetDinh, loaiDoiTuong,
                maNV, maPhongBan, lyDoKyLuat,
                hinhThucKyLuat, soTienPhat, nguoiKy);

            if (KiemTraTonTai(maQDKL))
                throw new Exception("Mã quyết định kỷ luật đã tồn tại.");

            if (KiemTraTrungSoQuyetDinh(soQuyetDinh, maQDKL))
                throw new Exception("Số quyết định đã tồn tại.");

            return Db.Execute(@"
                INSERT INTO QuyetDinhKyLuat
                (
                    MaQDKL, SoQuyetDinh, NgayQuyetDinh,
                    LoaiDoiTuong, MaNV, MaPhongBan,
                    LyDoKyLuat, HinhThucKyLuat, SoTienPhat, NguoiKy
                )
                VALUES
                (
                    @Ma, @So, @Ngay, @Loai, @MaNV, @MaPhongBan,
                    @LyDo, @HinhThuc, @SoTien, @NguoiKy
                )",
                Db.P("@Ma", maQDKL.Trim()),
                Db.P("@So", soQuyetDinh.Trim()),
                Db.P("@Ngay", ngayQuyetDinh.Date),
                Db.P("@Loai", loaiDoiTuong),
                Db.P("@MaNV", string.IsNullOrWhiteSpace(maNV)
                    ? (object)DBNull.Value : maNV),
                Db.P("@MaPhongBan", string.IsNullOrWhiteSpace(maPhongBan)
                    ? (object)DBNull.Value : maPhongBan),
                Db.P("@LyDo", lyDoKyLuat.Trim()),
                Db.P("@HinhThuc", hinhThucKyLuat.Trim()),
                Db.P("@SoTien", soTienPhat),
                Db.P("@NguoiKy", nguoiKy.Trim()));
        }

        public int Sua(
            string maQDKL,
            string soQuyetDinh,
            DateTime ngayQuyetDinh,
            string loaiDoiTuong,
            string maNV,
            string maPhongBan,
            string lyDoKyLuat,
            string hinhThucKyLuat,
            decimal soTienPhat,
            string nguoiKy)
        {
            KiemTraDuLieu(
                maQDKL, soQuyetDinh, loaiDoiTuong,
                maNV, maPhongBan, lyDoKyLuat,
                hinhThucKyLuat, soTienPhat, nguoiKy);

            if (KiemTraTrungSoQuyetDinh(soQuyetDinh, maQDKL))
                throw new Exception("Số quyết định đã tồn tại.");

            return Db.Execute(@"
                UPDATE QuyetDinhKyLuat
                SET SoQuyetDinh = @So,
                    NgayQuyetDinh = @Ngay,
                    LoaiDoiTuong = @Loai,
                    MaNV = @MaNV,
                    MaPhongBan = @MaPhongBan,
                    LyDoKyLuat = @LyDo,
                    HinhThucKyLuat = @HinhThuc,
                    SoTienPhat = @SoTien,
                    NguoiKy = @NguoiKy
                WHERE MaQDKL = @Ma",
                Db.P("@Ma", maQDKL.Trim()),
                Db.P("@So", soQuyetDinh.Trim()),
                Db.P("@Ngay", ngayQuyetDinh.Date),
                Db.P("@Loai", loaiDoiTuong),
                Db.P("@MaNV", string.IsNullOrWhiteSpace(maNV)
                    ? (object)DBNull.Value : maNV),
                Db.P("@MaPhongBan", string.IsNullOrWhiteSpace(maPhongBan)
                    ? (object)DBNull.Value : maPhongBan),
                Db.P("@LyDo", lyDoKyLuat.Trim()),
                Db.P("@HinhThuc", hinhThucKyLuat.Trim()),
                Db.P("@SoTien", soTienPhat),
                Db.P("@NguoiKy", nguoiKy.Trim()));
        }

        public int Xoa(string maQDKL)
        {
            if (string.IsNullOrWhiteSpace(maQDKL))
                throw new Exception("Vui lòng chọn quyết định cần xóa.");

            return Db.Execute(@"
                DELETE FROM QuyetDinhKyLuat
                WHERE MaQDKL = @Ma",
                Db.P("@Ma", maQDKL.Trim()));
        }

        private void KiemTraDuLieu(
            string maQDKL,
            string soQuyetDinh,
            string loaiDoiTuong,
            string maNV,
            string maPhongBan,
            string lyDoKyLuat,
            string hinhThucKyLuat,
            decimal soTienPhat,
            string nguoiKy)
        {
            if (string.IsNullOrWhiteSpace(maQDKL))
                throw new Exception("Vui lòng nhập mã quyết định.");

            if (maQDKL.Trim().Length > 20)
                throw new Exception("Mã quyết định tối đa 20 ký tự.");

            if (string.IsNullOrWhiteSpace(soQuyetDinh))
                throw new Exception("Vui lòng nhập số quyết định.");

            if (soQuyetDinh.Trim().Length > 30)
                throw new Exception("Số quyết định tối đa 30 ký tự.");

            if (loaiDoiTuong == "Cá nhân")
            {
                if (string.IsNullOrWhiteSpace(maNV))
                    throw new Exception("Vui lòng chọn nhân viên.");

                if (!string.IsNullOrWhiteSpace(maPhongBan))
                    throw new Exception(
                        "Kỷ luật cá nhân không chọn phòng ban.");
            }
            else if (loaiDoiTuong == "Tập thể")
            {
                if (string.IsNullOrWhiteSpace(maPhongBan))
                    throw new Exception("Vui lòng chọn phòng ban.");

                if (!string.IsNullOrWhiteSpace(maNV))
                    throw new Exception(
                        "Kỷ luật tập thể không chọn nhân viên.");
            }
            else
            {
                throw new Exception("Loại đối tượng không hợp lệ.");
            }

            if (string.IsNullOrWhiteSpace(lyDoKyLuat))
                throw new Exception("Vui lòng nhập lý do kỷ luật.");

            if (lyDoKyLuat.Trim().Length > 500)
                throw new Exception("Lý do kỷ luật tối đa 500 ký tự.");

            if (string.IsNullOrWhiteSpace(hinhThucKyLuat))
                throw new Exception("Vui lòng nhập hình thức kỷ luật.");

            if (hinhThucKyLuat.Trim().Length > 100)
                throw new Exception("Hình thức kỷ luật tối đa 100 ký tự.");

            if (soTienPhat < 0)
                throw new Exception("Số tiền phạt không được âm.");

            if (decimal.Round(soTienPhat, 2) != soTienPhat)
                throw new Exception("Số tiền phạt có tối đa 2 số thập phân.");

            if (string.IsNullOrWhiteSpace(nguoiKy))
                throw new Exception("Vui lòng nhập người ký.");

            if (nguoiKy.Trim().Length > 100)
                throw new Exception("Người ký tối đa 100 ký tự.");
        }
    }
}