using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyThuVien.Data;

namespace QuanLyThuVien.Services
{
    public class ThongKeService
    {
        public ThongKeTongHop LayTongHop(
            DateTime tuNgay,
            DateTime denNgay)
        {
            DateTime from =
                tuNgay.Date;

            DateTime to =
                denNgay.Date;

            if (to < from)
            {
                DateTime temp = from;
                from = to;
                to = temp;
            }

            ThongKeTongHop kq =
                new ThongKeTongHop();

            kq.LuotSachMuon =
                Convert.ToInt32(
                    Db.Scalar(@"
                        SELECT COUNT(*)
                        FROM CHITIETPHIEUMUON CT
                        INNER JOIN PHIEUMUON PM
                            ON PM.MaPhieuMuon =
                               CT.MaPhieuMuon
                        WHERE PM.NgayMuon
                              BETWEEN @Tu AND @Den",
                        new SqlParameter(
                            "@Tu", from),
                        new SqlParameter(
                            "@Den", to)));

            kq.SachQuaHan =
                Convert.ToInt32(
                    Db.Scalar(@"
                        SELECT COUNT(*)
                        FROM CHITIETPHIEUMUON CT
                        INNER JOIN PHIEUMUON PM
                            ON PM.MaPhieuMuon =
                               CT.MaPhieuMuon
                        WHERE
                        (
                            CT.NgayTraThucTe IS NULL
                            AND PM.NgayHenTra <
                                CAST(GETDATE() AS date)
                        )
                        OR
                        (
                            CT.NgayTraThucTe IS NOT NULL
                            AND CT.NgayTraThucTe >
                                PM.NgayHenTra
                            AND CT.NgayTraThucTe
                                BETWEEN @Tu AND @Den
                        )",
                        new SqlParameter(
                            "@Tu", from),
                        new SqlParameter(
                            "@Den", to)));

            kq.SachMat =
                Convert.ToInt32(
                    Db.Scalar(@"
                        SELECT COUNT(*)
                        FROM CHITIETPHIEUMUON
                        WHERE NgayTraThucTe
                              BETWEEN @Tu AND @Den
                          AND TinhTrangTra
                              LIKE N'%Mất%'",
                        new SqlParameter(
                            "@Tu", from),
                        new SqlParameter(
                            "@Den", to)));

            kq.SachHuHong =
                Convert.ToInt32(
                    Db.Scalar(@"
                        SELECT COUNT(*)
                        FROM CHITIETPHIEUMUON
                        WHERE NgayTraThucTe
                              BETWEEN @Tu AND @Den
                          AND
                          (
                              TinhTrangTra
                                  LIKE N'%Rách%'
                              OR
                              TinhTrangTra
                                  LIKE N'%Hư%'
                          )",
                        new SqlParameter(
                            "@Tu", from),
                        new SqlParameter(
                            "@Den", to)));

            object tong =
                Db.Scalar(@"
                    SELECT ISNULL(
                        SUM(PhiPhat),
                        0)
                    FROM PHIEUPHAT
                    WHERE NgayPhat
                          BETWEEN @Tu AND @Den",
                    new SqlParameter(
                        "@Tu", from),
                    new SqlParameter(
                        "@Den", to));

            kq.TongPhiPhat =
                Convert.ToDecimal(tong);

            return kq;
        }

        public DataTable LayChiTietPhat(
            DateTime tuNgay,
            DateTime denNgay)
        {
            DateTime from =
                tuNgay.Date;

            DateTime to =
                denNgay.Date;

            if (to < from)
            {
                DateTime temp = from;
                from = to;
                to = temp;
            }

            return Db.Query(@"
                SELECT
                    PP.MaPhieuPhat,
                    PP.NgayPhat,
                    PM.MaDocGia,
                    CT.MaDauSach,
                    DS.TenSach,
                    PP.LyDo,
                    PP.PhiPhat,
                    PP.MaNhanVien
                FROM PHIEUPHAT PP
                INNER JOIN CHITIETPHIEUMUON CT
                    ON CT.MaChiTiet =
                       PP.MaChiTiet
                INNER JOIN PHIEUMUON PM
                    ON PM.MaPhieuMuon =
                       CT.MaPhieuMuon
                INNER JOIN DAUSACH DS
                    ON DS.MaDauSach =
                       CT.MaDauSach
                WHERE PP.NgayPhat
                      BETWEEN @Tu AND @Den
                ORDER BY
                    PP.NgayPhat DESC,
                    PP.MaPhieuPhat",
                new SqlParameter(
                    "@Tu", from),
                new SqlParameter(
                    "@Den", to));
        }
    }
}