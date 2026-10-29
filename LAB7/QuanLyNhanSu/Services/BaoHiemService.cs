
using System;
using System.Data;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class BaoHiemService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(@"
                SELECT bh.MaBaoHiem, bh.MaHopDong,
                       hd.SoHopDong, nv.HoTen,
                       bh.SoBHXH, bh.SoBHYT,
                       bh.NgayThamGia, bh.MucDongBHXH,
                       bh.MucDongBHYT, bh.TrangThai
                FROM HoSoBaoHiem bh
                INNER JOIN HopDongLaoDong hd
                    ON bh.MaHopDong = hd.MaHopDong
                INNER JOIN NhanVien nv
                    ON hd.MaNV = nv.MaNV
                ORDER BY bh.MaBaoHiem");
        }

        public DataTable LayHopDong()
        {
            return Db.Query(@"
                SELECT hd.MaHopDong,
                       hd.SoHopDong + ' - ' + nv.HoTen AS TenHopDong
                FROM HopDongLaoDong hd
                INNER JOIN NhanVien nv
                    ON hd.MaNV = nv.MaNV
                WHERE hd.LoaiHopDong = N'Dài hạn'
                ORDER BY hd.SoHopDong");
        }

        public DataTable TimKiem(string tuKhoa)
        {
            return Db.Query(@"
                SELECT bh.MaBaoHiem, bh.MaHopDong,
                       hd.SoHopDong, nv.HoTen,
                       bh.SoBHXH, bh.SoBHYT,
                       bh.NgayThamGia, bh.MucDongBHXH,
                       bh.MucDongBHYT, bh.TrangThai
                FROM HoSoBaoHiem bh
                INNER JOIN HopDongLaoDong hd
                    ON bh.MaHopDong = hd.MaHopDong
                INNER JOIN NhanVien nv
                    ON hd.MaNV = nv.MaNV
                WHERE bh.MaBaoHiem LIKE @TuKhoa
                   OR bh.MaHopDong LIKE @TuKhoa
                   OR hd.SoHopDong LIKE @TuKhoa
                   OR nv.HoTen LIKE @TuKhoa
                   OR bh.SoBHXH LIKE @TuKhoa
                   OR bh.SoBHYT LIKE @TuKhoa
                   OR bh.TrangThai LIKE @TuKhoa
                ORDER BY bh.MaBaoHiem",
                Db.P("@TuKhoa", "%" + (tuKhoa ?? "").Trim() + "%"));
        }

        public bool KiemTraTonTai(string maBaoHiem)
        {
            return Convert.ToInt32(Db.Scalar(
                "SELECT COUNT(*) FROM HoSoBaoHiem WHERE MaBaoHiem = @Ma",
                Db.P("@Ma", maBaoHiem.Trim()))) > 0;
        }

        public bool KiemTraHopDongDaCoBaoHiem(
            string maHopDong, string maBaoHiem)
        {
            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM HoSoBaoHiem
                WHERE MaHopDong = @MaHopDong
                  AND MaBaoHiem <> @MaBaoHiem",
                Db.P("@MaHopDong", maHopDong),
                Db.P("@MaBaoHiem", maBaoHiem))) > 0;
        }

        public bool LaHopDongDaiHan(string maHopDong)
        {
            return Convert.ToInt32(Db.Scalar(@"
                SELECT COUNT(*)
                FROM HopDongLaoDong
                WHERE MaHopDong = @MaHopDong
                  AND LoaiHopDong = N'Dài hạn'",
                Db.P("@MaHopDong", maHopDong))) > 0;
        }

        public int Them(
            string maBaoHiem,
            string maHopDong,
            string soBHXH,
            string soBHYT,
            DateTime ngayThamGia,
            decimal mucDongBHXH,
            decimal mucDongBHYT,
            string trangThai)
        {
            KiemTraDuLieu(
                maBaoHiem, maHopDong, soBHXH, soBHYT,
                mucDongBHXH, mucDongBHYT, trangThai);

            if (KiemTraTonTai(maBaoHiem))
                throw new Exception("Mã bảo hiểm đã tồn tại.");

            if (KiemTraHopDongDaCoBaoHiem(maHopDong, maBaoHiem))
                throw new Exception("Hợp đồng đã có hồ sơ bảo hiểm.");

            return Db.Execute(@"
                INSERT INTO HoSoBaoHiem
                (
                    MaBaoHiem, MaHopDong, SoBHXH, SoBHYT,
                    NgayThamGia, MucDongBHXH, MucDongBHYT,
                    TrangThai
                )
                VALUES
                (
                    @MaBaoHiem, @MaHopDong, @SoBHXH, @SoBHYT,
                    @NgayThamGia, @MucDongBHXH, @MucDongBHYT,
                    @TrangThai
                )",
                Db.P("@MaBaoHiem", maBaoHiem.Trim()),
                Db.P("@MaHopDong", maHopDong),
                Db.P("@SoBHXH", soBHXH.Trim()),
                Db.P("@SoBHYT", soBHYT.Trim()),
                Db.P("@NgayThamGia", ngayThamGia.Date),
                Db.P("@MucDongBHXH", mucDongBHXH),
                Db.P("@MucDongBHYT", mucDongBHYT),
                Db.P("@TrangThai", trangThai));
        }

        public int Sua(
            string maBaoHiem,
            string maHopDong,
            string soBHXH,
            string soBHYT,
            DateTime ngayThamGia,
            decimal mucDongBHXH,
            decimal mucDongBHYT,
            string trangThai)
        {
            KiemTraDuLieu(
                maBaoHiem, maHopDong, soBHXH, soBHYT,
                mucDongBHXH, mucDongBHYT, trangThai);

            if (KiemTraHopDongDaCoBaoHiem(maHopDong, maBaoHiem))
                throw new Exception("Hợp đồng đã có hồ sơ bảo hiểm khác.");

            return Db.Execute(@"
                UPDATE HoSoBaoHiem
                SET MaHopDong = @MaHopDong,
                    SoBHXH = @SoBHXH,
                    SoBHYT = @SoBHYT,
                    NgayThamGia = @NgayThamGia,
                    MucDongBHXH = @MucDongBHXH,
                    MucDongBHYT = @MucDongBHYT,
                    TrangThai = @TrangThai
                WHERE MaBaoHiem = @MaBaoHiem",
                Db.P("@MaBaoHiem", maBaoHiem.Trim()),
                Db.P("@MaHopDong", maHopDong),
                Db.P("@SoBHXH", soBHXH.Trim()),
                Db.P("@SoBHYT", soBHYT.Trim()),
                Db.P("@NgayThamGia", ngayThamGia.Date),
                Db.P("@MucDongBHXH", mucDongBHXH),
                Db.P("@MucDongBHYT", mucDongBHYT),
                Db.P("@TrangThai", trangThai));
        }

        public int Xoa(string maBaoHiem)
        {
            if (string.IsNullOrWhiteSpace(maBaoHiem))
                throw new Exception("Vui lòng chọn hồ sơ cần xóa.");

            return Db.Execute(@"
                DELETE FROM HoSoBaoHiem
                WHERE MaBaoHiem = @MaBaoHiem",
                Db.P("@MaBaoHiem", maBaoHiem.Trim()));
        }

        private void KiemTraDuLieu(
            string maBaoHiem,
            string maHopDong,
            string soBHXH,
            string soBHYT,
            decimal mucDongBHXH,
            decimal mucDongBHYT,
            string trangThai)
        {
            if (string.IsNullOrWhiteSpace(maBaoHiem))
                throw new Exception("Vui lòng nhập mã bảo hiểm.");

            if (string.IsNullOrWhiteSpace(maHopDong))
                throw new Exception("Vui lòng chọn hợp đồng.");

            if (string.IsNullOrWhiteSpace(soBHXH))
                throw new Exception("Vui lòng nhập số BHXH.");

            if (string.IsNullOrWhiteSpace(soBHYT))
                throw new Exception("Vui lòng nhập số BHYT.");

            if (maBaoHiem.Trim().Length > 20)
                throw new Exception("Mã bảo hiểm tối đa 20 ký tự.");

            if (soBHXH.Trim().Length > 30 ||
                soBHYT.Trim().Length > 30)
                throw new Exception("Số bảo hiểm tối đa 30 ký tự.");

            if (mucDongBHXH < 0 || mucDongBHYT < 0)
                throw new Exception("Mức đóng bảo hiểm không được âm.");

            if (trangThai != "Đang tham gia" &&
                trangThai != "Ngừng tham gia")
                throw new Exception("Trạng thái không hợp lệ.");

            if (!LaHopDongDaiHan(maHopDong))
                throw new Exception(
                    "Chỉ hợp đồng dài hạn mới được lập hồ sơ bảo hiểm.");
        }
    }
}
