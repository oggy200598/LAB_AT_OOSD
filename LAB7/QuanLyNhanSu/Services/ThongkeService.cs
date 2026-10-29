using System;
using System.Data;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class ThongKeService
    {
        public DataTable LayPhongBan()
        {
            return Db.Query(@"
                SELECT MaPhongBan, TenPhongBan
                FROM PhongBan
                ORDER BY TenPhongBan");
        }

        public DataTable ThongKe(
            string nhom,
            string phanLoai,
            int thang,
            int nam,
            string maPhongBan)
        {
            if (thang < 1 || thang > 12)
                throw new Exception("Tháng phải từ 1 đến 12.");

            if (nam < 2000 || nam > 2100)
                throw new Exception("Năm phải từ 2000 đến 2100.");

            string maPB = maPhongBan ?? "";

            if (nhom == "Nhân viên")
                return ThongKeNhanVien(phanLoai, maPB);

            if (nhom == "Tuyển dụng")
                return ThongKeTuyenDung(thang, nam, maPB);

            if (nhom == "Chấm công")
                return ThongKeChamCong(thang, nam, maPB);

            if (nhom == "Khen thưởng - Kỷ luật")
                return ThongKeKhenThuongKyLuat(thang, nam, maPB);

            if (nhom == "Lương")
                return ThongKeLuong(thang, nam, maPB);

            throw new Exception("Vui lòng chọn nhóm thống kê.");
        }

        private DataTable ThongKeNhanVien(
            string phanLoai,
            string maPhongBan)
        {
            if (phanLoai == "Giới tính")
            {
                return Db.Query(@"
                    SELECT ISNULL(nv.GioiTinh, N'Chưa cập nhật')
                               AS NhomThongKe,
                           COUNT(*) AS SoNhanVien
                    FROM NhanVien nv
                    WHERE (@MaPB = '' OR nv.MaPhongBan = @MaPB)
                    GROUP BY ISNULL(nv.GioiTinh, N'Chưa cập nhật')
                    ORDER BY SoNhanVien DESC, NhomThongKe",
                    Db.P("@MaPB", maPhongBan));
            }

            if (phanLoai == "Trạng thái")
            {
                return Db.Query(@"
                    SELECT nv.TrangThai AS NhomThongKe,
                           COUNT(*) AS SoNhanVien
                    FROM NhanVien nv
                    WHERE (@MaPB = '' OR nv.MaPhongBan = @MaPB)
                    GROUP BY nv.TrangThai
                    ORDER BY SoNhanVien DESC, NhomThongKe",
                    Db.P("@MaPB", maPhongBan));
            }

            return Db.Query(@"
                SELECT p.MaPhongBan,
                       p.TenPhongBan,
                       COUNT(nv.MaNV) AS SoNhanVien,
                       SUM(CASE WHEN nv.TrangThai = N'Chính thức'
                                THEN 1 ELSE 0 END) AS ChinhThuc,
                       SUM(CASE WHEN nv.TrangThai = N'Thử việc'
                                THEN 1 ELSE 0 END) AS ThuViec,
                       SUM(CASE WHEN nv.TrangThai = N'Nghỉ việc'
                                THEN 1 ELSE 0 END) AS NghiViec
                FROM PhongBan p
                LEFT JOIN NhanVien nv
                    ON p.MaPhongBan = nv.MaPhongBan
                WHERE (@MaPB = '' OR p.MaPhongBan = @MaPB)
                GROUP BY p.MaPhongBan, p.TenPhongBan
                ORDER BY p.TenPhongBan",
                Db.P("@MaPB", maPhongBan));
        }

        private DataTable ThongKeTuyenDung(
            int thang,
            int nam,
            string maPhongBan)
        {
            return Db.Query(@"
                SELECT p.MaPhongBan,
                       p.TenPhongBan,
                       COUNT(q.MaQDTD) AS SoQuyetDinh,
                       COUNT(DISTINCT q.MaNV) AS SoNhanVienTuyen,
                       ISNULL(SUM(q.LuongThuViec), 0)
                           AS TongLuongThuViec
                FROM PhongBan p
                LEFT JOIN QuyetDinhTuyenDung q
                    ON p.MaPhongBan = q.MaPhongBan
                   AND MONTH(q.NgayQuyetDinh) = @Thang
                   AND YEAR(q.NgayQuyetDinh) = @Nam
                WHERE (@MaPB = '' OR p.MaPhongBan = @MaPB)
                GROUP BY p.MaPhongBan, p.TenPhongBan
                ORDER BY p.TenPhongBan",
                Db.P("@Thang", thang),
                Db.P("@Nam", nam),
                Db.P("@MaPB", maPhongBan));
        }

        private DataTable ThongKeChamCong(
            int thang,
            int nam,
            string maPhongBan)
        {
            return Db.Query(@"
                SELECT p.MaPhongBan,
                       p.TenPhongBan,
                       COUNT(ct.MaChiTietChamCong) AS SoLuotChamCong,
                       COUNT(DISTINCT ct.MaNV) AS SoNhanVien,
                       SUM(CASE WHEN ct.TrangThai = N'Có mặt'
                                THEN 1 ELSE 0 END) AS CoMat,
                       SUM(CASE WHEN ct.TrangThai = N'Vắng mặt'
                                THEN 1 ELSE 0 END) AS VangMat,
                       SUM(CASE WHEN ct.TrangThai = N'Nghỉ phép'
                                THEN 1 ELSE 0 END) AS NghiPhep,
                       SUM(CASE WHEN ct.TrangThai = N'Nghỉ lễ'
                                THEN 1 ELSE 0 END) AS NghiLe,
                       ISNULL(SUM(ct.SoGioLam), 0) AS TongGioLam
                FROM PhongBan p
                LEFT JOIN BangChamCong b
                    ON p.MaPhongBan = b.MaPhongBan
                   AND b.Thang = @Thang
                   AND b.Nam = @Nam
                LEFT JOIN ChiTietChamCong ct
                    ON b.MaBangChamCong = ct.MaBangChamCong
                WHERE (@MaPB = '' OR p.MaPhongBan = @MaPB)
                GROUP BY p.MaPhongBan, p.TenPhongBan
                ORDER BY p.TenPhongBan",
                Db.P("@Thang", thang),
                Db.P("@Nam", nam),
                Db.P("@MaPB", maPhongBan));
        }

        private DataTable ThongKeKhenThuongKyLuat(
            int thang,
            int nam,
            string maPhongBan)
        {
            return Db.Query(@"
                SELECT p.MaPhongBan,
                       p.TenPhongBan,
                       COUNT(kt.MaQDKT) AS SoQuyetDinhKhenThuong,
                       ISNULL(SUM(kt.SoTienThuong), 0)
                           AS TongTienThuong,
                       COUNT(kl.MaQDKL) AS SoQuyetDinhKyLuat,
                       ISNULL(SUM(kl.SoTienPhat), 0)
                           AS TongTienPhat
                FROM PhongBan p
                LEFT JOIN
                (
                    SELECT q.MaQDKT,
                           CASE
                               WHEN q.LoaiDoiTuong = N'Tập thể'
                                   THEN q.MaPhongBan
                               ELSE nv.MaPhongBan
                           END AS MaPhongBan,
                           q.SoTienThuong
                    FROM QuyetDinhKhenThuong q
                    LEFT JOIN NhanVien nv ON q.MaNV = nv.MaNV
                    WHERE MONTH(q.NgayQuyetDinh) = @Thang
                      AND YEAR(q.NgayQuyetDinh) = @Nam
                ) kt ON p.MaPhongBan = kt.MaPhongBan
                LEFT JOIN
                (
                    SELECT q.MaQDKL,
                           CASE
                               WHEN q.LoaiDoiTuong = N'Tập thể'
                                   THEN q.MaPhongBan
                               ELSE nv.MaPhongBan
                           END AS MaPhongBan,
                           q.SoTienPhat
                    FROM QuyetDinhKyLuat q
                    LEFT JOIN NhanVien nv ON q.MaNV = nv.MaNV
                    WHERE MONTH(q.NgayQuyetDinh) = @Thang
                      AND YEAR(q.NgayQuyetDinh) = @Nam
                ) kl ON p.MaPhongBan = kl.MaPhongBan
                WHERE (@MaPB = '' OR p.MaPhongBan = @MaPB)
                GROUP BY p.MaPhongBan, p.TenPhongBan
                ORDER BY p.TenPhongBan",
                Db.P("@Thang", thang),
                Db.P("@Nam", nam),
                Db.P("@MaPB", maPhongBan));
        }

        private DataTable ThongKeLuong(
            int thang,
            int nam,
            string maPhongBan)
        {
            return Db.Query(@"
                SELECT p.MaPhongBan,
                       p.TenPhongBan,
                       COUNT(ct.MaChiTietLuong) AS SoNhanVienCoLuong,
                       ISNULL(SUM(ct.LuongCoBan), 0)
                           AS TongLuongCoBan,
                       ISNULL(SUM(ct.PhuCapLuong
                                  + ct.PhuCapChucVu
                                  + ct.PhuCapDocHai), 0)
                           AS TongPhuCap,
                       ISNULL(SUM(ct.TienPhuTroi), 0)
                           AS TongPhuTroi,
                       ISNULL(SUM(ct.TienThuong), 0)
                           AS TongTienThuong,
                       ISNULL(SUM(ct.TienPhat
                                  + ct.TienBHXH
                                  + ct.TienBHYT), 0)
                           AS TongKhauTru,
                       ISNULL(SUM(ct.ThucLanh), 0)
                           AS TongThucLanh
                FROM PhongBan p
                LEFT JOIN NhanVien nv
                    ON p.MaPhongBan = nv.MaPhongBan
                LEFT JOIN ChiTietBangLuong ct
                    ON nv.MaNV = ct.MaNV
                   AND ct.MaBangLuong IN
                   (
                       SELECT MaBangLuong
                       FROM BangLuong
                       WHERE Thang = @Thang
                         AND Nam = @Nam
                   )
                WHERE (@MaPB = '' OR p.MaPhongBan = @MaPB)
                GROUP BY p.MaPhongBan, p.TenPhongBan
                ORDER BY p.TenPhongBan",
                Db.P("@Thang", thang),
                Db.P("@Nam", nam),
                Db.P("@MaPB", maPhongBan));
        }
    }
}