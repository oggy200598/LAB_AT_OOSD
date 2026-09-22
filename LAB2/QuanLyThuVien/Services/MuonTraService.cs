using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using QuanLyThuVien.Data;

namespace QuanLyThuVien.Services
{
    public class MuonTraService
    {
        public DataTable LaySachKho()
        {
            return Db.Query(@"
                SELECT
                    MaDauSach,
                    TenSach,
                    NamXuatBan,
                    SoLuongHienCo
                FROM DAUSACH
                WHERE SoLuongHienCo > 0
                ORDER BY MaDauSach");
        }

        public DataTable KiemTraDocGia(string maDocGia)
        {
            return Db.Query(@"
                SELECT
                    DG.MaDocGia,
                    DG.Ho,
                    DG.Ten,
                    T.MaThe,
                    T.NgayCap,
                    T.HanSuDung,
                    T.DaDongLePhi,
                    T.TrangThai
                FROM DOCGIA DG
                LEFT JOIN THEDOCGIA T
                    ON DG.MaDocGia = T.MaDocGia
                WHERE DG.MaDocGia = @MaDocGia",
                new SqlParameter("@MaDocGia", maDocGia));
        }

        public bool KiemTraNhanVien(string maNhanVien)
        {
            object result = Db.Scalar(@"
                SELECT COUNT(*)
                FROM NHANVIEN
                WHERE MaNhanVien = @MaNhanVien",
                new SqlParameter("@MaNhanVien", maNhanVien));

            return Convert.ToInt32(result) > 0;
        }

        public DataTable LayDocGiaDangMuon()
        {
            return Db.Query(@"
                SELECT
                    DG.MaDocGia,
                    DG.Ho + N' ' + DG.Ten AS TenDocGia,
                    COUNT(*) AS SoSachDangMuon
                FROM DOCGIA DG
                INNER JOIN PHIEUMUON PM
                    ON PM.MaDocGia = DG.MaDocGia
                INNER JOIN CHITIETPHIEUMUON CT
                    ON CT.MaPhieuMuon = PM.MaPhieuMuon
                WHERE CT.NgayTraThucTe IS NULL
                GROUP BY
                    DG.MaDocGia,
                    DG.Ho,
                    DG.Ten
                ORDER BY DG.MaDocGia");
        }

        public DataTable LaySachDangMuon()
        {
            return Db.Query(@"
                SELECT
                    CT.MaChiTiet,
                    PM.MaPhieuMuon,
                    PM.MaDocGia,
                    DG.Ho + N' ' + DG.Ten AS TenDocGia,
                    CT.MaDauSach,
                    DS.TenSach,
                    PM.NgayMuon,
                    PM.NgayHenTra
                FROM CHITIETPHIEUMUON CT
                INNER JOIN PHIEUMUON PM
                    ON CT.MaPhieuMuon = PM.MaPhieuMuon
                INNER JOIN DOCGIA DG
                    ON PM.MaDocGia = DG.MaDocGia
                INNER JOIN DAUSACH DS
                    ON CT.MaDauSach = DS.MaDauSach
                WHERE CT.NgayTraThucTe IS NULL
                ORDER BY PM.NgayHenTra, PM.MaPhieuMuon");
        }

        public DataTable LaySachDangMuon(string maDocGia)
        {
            return Db.Query(@"
                SELECT
                    CT.MaChiTiet,
                    PM.MaPhieuMuon,
                    PM.MaDocGia,
                    DG.Ho + N' ' + DG.Ten AS TenDocGia,
                    CT.MaDauSach,
                    DS.TenSach,
                    PM.NgayMuon,
                    PM.NgayHenTra
                FROM CHITIETPHIEUMUON CT
                INNER JOIN PHIEUMUON PM
                    ON CT.MaPhieuMuon = PM.MaPhieuMuon
                INNER JOIN DOCGIA DG
                    ON PM.MaDocGia = DG.MaDocGia
                INNER JOIN DAUSACH DS
                    ON CT.MaDauSach = DS.MaDauSach
                WHERE PM.MaDocGia = @MaDocGia
                  AND CT.NgayTraThucTe IS NULL
                ORDER BY PM.NgayHenTra, DS.TenSach",
                new SqlParameter("@MaDocGia", maDocGia));
        }

        public DataTable LayChiTietDangMuon(string maChiTiet)
        {
            return Db.Query(@"
                SELECT
                    CT.MaChiTiet,
                    PM.MaPhieuMuon,
                    PM.MaDocGia,
                    DG.Ho + N' ' + DG.Ten AS TenDocGia,
                    CT.MaDauSach,
                    DS.TenSach,
                    PM.NgayMuon,
                    PM.NgayHenTra
                FROM CHITIETPHIEUMUON CT
                INNER JOIN PHIEUMUON PM
                    ON CT.MaPhieuMuon = PM.MaPhieuMuon
                INNER JOIN DOCGIA DG
                    ON PM.MaDocGia = DG.MaDocGia
                INNER JOIN DAUSACH DS
                    ON CT.MaDauSach = DS.MaDauSach
                WHERE CT.MaChiTiet = @MaChiTiet
                  AND CT.NgayTraThucTe IS NULL",
                new SqlParameter("@MaChiTiet", maChiTiet));
        }

        public string LapPhieuMuon(
            string maDocGia,
            string maNhanVien,
            DateTime ngayMuon,
            DateTime ngayHenTra,
            List<string> danhSachSach)
        {
            if (string.IsNullOrWhiteSpace(maDocGia))
                throw new Exception("Vui lòng nhập mã độc giả.");

            if (string.IsNullOrWhiteSpace(maNhanVien))
                throw new Exception("Vui lòng nhập mã nhân viên.");

            if (ngayHenTra.Date < ngayMuon.Date)
                throw new Exception(
                    "Ngày hẹn trả không được trước ngày mượn.");

            if (danhSachSach == null ||
                danhSachSach.Count == 0)
                throw new Exception("Chưa chọn sách.");

            List<string> unique =
                danhSachSach
                    .Where(x => !string.IsNullOrWhiteSpace(x))
                    .Select(x => x.Trim())
                    .Distinct(StringComparer.OrdinalIgnoreCase)
                    .ToList();

            if (unique.Count > 3)
                throw new Exception(
                    "Một độc giả chỉ được mượn tối đa 3 sách.");

            using (SqlConnection cn = Db.OpenConnection())
            using (SqlTransaction tx =
                cn.BeginTransaction(IsolationLevel.Serializable))
            {
                try
                {
                    int docGiaTonTai;

                    using (SqlCommand cmd = new SqlCommand(@"
                        SELECT COUNT(*)
                        FROM DOCGIA
                        WHERE MaDocGia = @MaDocGia",
                        cn,
                        tx))
                    {
                        cmd.Parameters.AddWithValue(
                            "@MaDocGia",
                            maDocGia);

                        docGiaTonTai =
                            Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    if (docGiaTonTai == 0)
                        throw new Exception(
                            "Độc giả không tồn tại.");

                    int nhanVienTonTai;

                    using (SqlCommand cmd = new SqlCommand(@"
                        SELECT COUNT(*)
                        FROM NHANVIEN
                        WHERE MaNhanVien = @MaNhanVien",
                        cn,
                        tx))
                    {
                        cmd.Parameters.AddWithValue(
                            "@MaNhanVien",
                            maNhanVien);

                        nhanVienTonTai =
                            Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    if (nhanVienTonTai == 0)
                        throw new Exception(
                            "Nhân viên không tồn tại.");

                    DateTime? hanThe = null;
                    bool daDongLePhi = false;
                    string trangThaiThe = null;

                    using (SqlCommand cmd = new SqlCommand(@"
                        SELECT TOP 1
                            HanSuDung,
                            DaDongLePhi,
                            TrangThai
                        FROM THEDOCGIA
                        WHERE MaDocGia = @MaDocGia
                        ORDER BY HanSuDung DESC",
                        cn,
                        tx))
                    {
                        cmd.Parameters.AddWithValue(
                            "@MaDocGia",
                            maDocGia);

                        using (SqlDataReader rd =
                            cmd.ExecuteReader())
                        {
                            if (rd.Read())
                            {
                                hanThe =
                                    rd.IsDBNull(0)
                                        ? (DateTime?)null
                                        : rd.GetDateTime(0);

                                daDongLePhi =
                                    !rd.IsDBNull(1) &&
                                    rd.GetBoolean(1);

                                trangThaiThe =
                                    rd.IsDBNull(2)
                                        ? ""
                                        : rd.GetString(2);
                            }
                        }
                    }

                    if (!hanThe.HasValue)
                        throw new Exception(
                            "Độc giả chưa có thẻ.");

                    if (hanThe.Value.Date < ngayMuon.Date)
                        throw new Exception(
                            "Thẻ độc giả đã hết hạn.");

                    if (!daDongLePhi)
                        throw new Exception(
                            "Độc giả chưa đóng lệ phí.");

                    if (!string.Equals(
                        trangThaiThe,
                        "Đang hoạt động",
                        StringComparison.OrdinalIgnoreCase))
                        throw new Exception(
                            "Thẻ độc giả không ở trạng thái hoạt động.");

                    int soSachDangMuon = 0;

                    using (SqlCommand cmd = new SqlCommand(@"
                        SELECT COUNT(*)
                        FROM PHIEUMUON PM
                        INNER JOIN CHITIETPHIEUMUON CT
                            ON PM.MaPhieuMuon = CT.MaPhieuMuon
                        WHERE PM.MaDocGia = @MaDocGia
                          AND CT.NgayTraThucTe IS NULL",
                        cn,
                        tx))
                    {
                        cmd.Parameters.AddWithValue(
                            "@MaDocGia",
                            maDocGia);

                        soSachDangMuon =
                            Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    if (soSachDangMuon >= 3)
                        throw new Exception(
                            "Độc giả đang mượn đủ 3 sách.");

                    if (soSachDangMuon + unique.Count > 3)
                        throw new Exception(
                            "Tổng số sách đang mượn không được vượt quá 3.");

                    int soSachQuaHan = 0;

                    using (SqlCommand cmd = new SqlCommand(@"
                        SELECT COUNT(*)
                        FROM PHIEUMUON PM
                        INNER JOIN CHITIETPHIEUMUON CT
                            ON PM.MaPhieuMuon = CT.MaPhieuMuon
                        WHERE PM.MaDocGia = @MaDocGia
                          AND CT.NgayTraThucTe IS NULL
                          AND PM.NgayHenTra < @NgayMuon",
                        cn,
                        tx))
                    {
                        cmd.Parameters.AddWithValue(
                            "@MaDocGia",
                            maDocGia);

                        cmd.Parameters.AddWithValue(
                            "@NgayMuon",
                            ngayMuon.Date);

                        soSachQuaHan =
                            Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    if (soSachQuaHan > 0)
                        throw new Exception(
                            "Độc giả còn sách quá hạn chưa trả.");

                    foreach (string maSach in unique)
                    {
                        int tonKho;

                        using (SqlCommand cmd = new SqlCommand(@"
                            SELECT SoLuongHienCo
                            FROM DAUSACH
                            WHERE MaDauSach = @MaDauSach",
                            cn,
                            tx))
                        {
                            cmd.Parameters.AddWithValue(
                                "@MaDauSach",
                                maSach);

                            object value =
                                cmd.ExecuteScalar();

                            if (value == null)
                                throw new Exception(
                                    "Không tìm thấy sách: " +
                                    maSach);

                            tonKho =
                                Convert.ToInt32(value);
                        }

                        if (tonKho <= 0)
                            throw new Exception(
                                "Sách " +
                                maSach +
                                " đã hết.");

                        int trungTrongPhieu;

                        using (SqlCommand cmd = new SqlCommand(@"
                            SELECT COUNT(*)
                            FROM CHITIETPHIEUMUON CT
                            INNER JOIN PHIEUMUON PM
                                ON CT.MaPhieuMuon = PM.MaPhieuMuon
                            WHERE PM.MaDocGia = @MaDocGia
                              AND CT.MaDauSach = @MaDauSach
                              AND CT.NgayTraThucTe IS NULL",
                            cn,
                            tx))
                        {
                            cmd.Parameters.AddWithValue(
                                "@MaDocGia",
                                maDocGia);

                            cmd.Parameters.AddWithValue(
                                "@MaDauSach",
                                maSach);

                            trungTrongPhieu =
                                Convert.ToInt32(
                                    cmd.ExecuteScalar());
                        }

                        if (trungTrongPhieu > 0)
                            throw new Exception(
                                "Độc giả đang mượn sách " +
                                maSach +
                                " chưa trả.");
                    }

                    string maPhieu =
                        "PM" +
                        DateTime.Now.ToString(
                            "yyMMddHHmmssfff");

                    using (SqlCommand cmd = new SqlCommand(@"
                        INSERT INTO PHIEUMUON
                        (
                            MaPhieuMuon,
                            MaDocGia,
                            MaNhanVien,
                            NgayMuon,
                            NgayHenTra
                        )
                        VALUES
                        (
                            @MaPhieu,
                            @MaDocGia,
                            @MaNhanVien,
                            @NgayMuon,
                            @NgayHenTra
                        )",
                        cn,
                        tx))
                    {
                        cmd.Parameters.AddWithValue(
                            "@MaPhieu",
                            maPhieu);

                        cmd.Parameters.AddWithValue(
                            "@MaDocGia",
                            maDocGia);

                        cmd.Parameters.AddWithValue(
                            "@MaNhanVien",
                            maNhanVien);

                        cmd.Parameters.AddWithValue(
                            "@NgayMuon",
                            ngayMuon.Date);

                        cmd.Parameters.AddWithValue(
                            "@NgayHenTra",
                            ngayHenTra.Date);

                        cmd.ExecuteNonQuery();
                    }

                    int i = 1;

                    foreach (string maSach in unique)
                    {
                        string maChiTiet =
                            "CT" +
                            DateTime.Now.ToString(
                                "yyMMddHHmmssfff") +
                            i.ToString("0");

                        using (SqlCommand cmd = new SqlCommand(@"
                            INSERT INTO CHITIETPHIEUMUON
                            (
                                MaChiTiet,
                                MaPhieuMuon,
                                MaDauSach
                            )
                            VALUES
                            (
                                @MaChiTiet,
                                @MaPhieu,
                                @MaSach
                            )",
                            cn,
                            tx))
                        {
                            cmd.Parameters.AddWithValue(
                                "@MaChiTiet",
                                maChiTiet);

                            cmd.Parameters.AddWithValue(
                                "@MaPhieu",
                                maPhieu);

                            cmd.Parameters.AddWithValue(
                                "@MaSach",
                                maSach);

                            cmd.ExecuteNonQuery();
                        }

                        using (SqlCommand cmd = new SqlCommand(@"
                            UPDATE DAUSACH
                            SET SoLuongHienCo =
                                SoLuongHienCo - 1
                            WHERE MaDauSach = @MaSach
                              AND SoLuongHienCo > 0",
                            cn,
                            tx))
                        {
                            cmd.Parameters.AddWithValue(
                                "@MaSach",
                                maSach);

                            if (cmd.ExecuteNonQuery() != 1)
                                throw new Exception(
                                    "Không thể cập nhật tồn kho sách " +
                                    maSach);
                        }

                        i++;
                    }

                    tx.Commit();

                    return maPhieu;
                }
                catch
                {
                    try
                    {
                        tx.Rollback();
                    }
                    catch
                    {
                    }

                    throw;
                }
            }
        }

        public KetQuaXuLy TraSach(
            string maChiTiet,
            string maNhanVien,
            DateTime ngayTra,
            string tinhTrang,
            decimal phiPhat)
        {
            if (string.IsNullOrWhiteSpace(maChiTiet))
                return KetQuaXuLy.Loi(
                    "Vui lòng chọn sách cần trả.");

            if (string.IsNullOrWhiteSpace(maNhanVien))
                return KetQuaXuLy.Loi(
                    "Vui lòng nhập nhân viên nhận trả.");

            if (string.IsNullOrWhiteSpace(tinhTrang))
                return KetQuaXuLy.Loi(
                    "Vui lòng chọn tình trạng sách.");

            if (phiPhat < 0)
                return KetQuaXuLy.Loi(
                    "Phí phạt không được âm.");

            using (SqlConnection cn = Db.OpenConnection())
            using (SqlTransaction tx =
                cn.BeginTransaction(IsolationLevel.Serializable))
            {
                try
                {
                    string maSach;
                    DateTime ngayMuon;
                    DateTime ngayHenTra;
                    bool daTra;

                    using (SqlCommand cmd = new SqlCommand(@"
                        SELECT
                            CT.MaDauSach,
                            CT.NgayTraThucTe,
                            PM.NgayMuon,
                            PM.NgayHenTra
                        FROM CHITIETPHIEUMUON CT
                        INNER JOIN PHIEUMUON PM
                            ON PM.MaPhieuMuon =
                               CT.MaPhieuMuon
                        WHERE CT.MaChiTiet = @MaChiTiet",
                        cn,
                        tx))
                    {
                        cmd.Parameters.AddWithValue(
                            "@MaChiTiet",
                            maChiTiet);

                        using (SqlDataReader rd =
                            cmd.ExecuteReader())
                        {
                            if (!rd.Read())
                                return KetQuaXuLy.Loi(
                                    "Không tìm thấy chi tiết mượn.");

                            maSach =
                                rd.GetString(0);

                            daTra =
                                !rd.IsDBNull(1);

                            ngayMuon =
                                rd.GetDateTime(2);

                            ngayHenTra =
                                rd.GetDateTime(3);
                        }
                    }

                    if (daTra)
                        return KetQuaXuLy.Loi(
                            "Sách này đã được trả trước đó.");

                    if (ngayTra.Date < ngayMuon.Date)
                        return KetQuaXuLy.Loi(
                            "Ngày trả không thể trước ngày mượn.");

                    string tt =
                        tinhTrang.Trim();

                    bool quaHan =
                        ngayTra.Date > ngayHenTra.Date;

                    bool mat =
                        tt.Equals(
                            "Mất",
                            StringComparison.OrdinalIgnoreCase);

                    bool huHong =
                        tt.IndexOf(
                            "Rách",
                            StringComparison.OrdinalIgnoreCase) >= 0
                        ||
                        tt.IndexOf(
                            "Hư",
                            StringComparison.OrdinalIgnoreCase) >= 0
                        ||
                        tt.IndexOf(
                            "Hu",
                            StringComparison.OrdinalIgnoreCase) >= 0;

                    bool canPhat =
                        quaHan ||
                        mat ||
                        huHong;

                    if (canPhat && phiPhat <= 0)
                    {
                        return KetQuaXuLy.Loi(
                            "Trường hợp trả trễ, mất hoặc hư hỏng phải nhập phí phạt lớn hơn 0.");
                    }

                    using (SqlCommand cmd = new SqlCommand(@"
                        UPDATE CHITIETPHIEUMUON
                        SET
                            NgayTraThucTe = @NgayTra,
                            TinhTrangTra = @TinhTrang
                        WHERE MaChiTiet = @MaChiTiet
                          AND NgayTraThucTe IS NULL",
                        cn,
                        tx))
                    {
                        cmd.Parameters.AddWithValue(
                            "@NgayTra",
                            ngayTra.Date);

                        cmd.Parameters.AddWithValue(
                            "@TinhTrang",
                            tt);

                        cmd.Parameters.AddWithValue(
                            "@MaChiTiet",
                            maChiTiet);

                        if (cmd.ExecuteNonQuery() != 1)
                            throw new Exception(
                                "Không cập nhật được trạng thái trả sách.");
                    }

                    if (!mat && !huHong)
                    {
                        using (SqlCommand cmd = new SqlCommand(@"
                            UPDATE DAUSACH
                            SET SoLuongHienCo =
                                SoLuongHienCo + 1
                            WHERE MaDauSach = @MaSach",
                            cn,
                            tx))
                        {
                            cmd.Parameters.AddWithValue(
                                "@MaSach",
                                maSach);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    if (canPhat)
                    {
                        List<string> lyDo =
                            new List<string>();

                        if (quaHan)
                            lyDo.Add("Trả trễ hạn");

                        if (mat)
                            lyDo.Add("Mất sách");

                        if (huHong)
                            lyDo.Add("Rách/hư hỏng");

                        string maPhat =
                            "PP" +
                            DateTime.Now.ToString(
                                "yyMMddHHmmssfff");

                        using (SqlCommand cmd = new SqlCommand(@"
                            INSERT INTO PHIEUPHAT
                            (
                                MaPhieuPhat,
                                MaChiTiet,
                                MaNhanVien,
                                NgayPhat,
                                LyDo,
                                PhiPhat
                            )
                            VALUES
                            (
                                @MaPhat,
                                @MaChiTiet,
                                @MaNhanVien,
                                @NgayPhat,
                                @LyDo,
                                @PhiPhat
                            )",
                            cn,
                            tx))
                        {
                            cmd.Parameters.AddWithValue(
                                "@MaPhat",
                                maPhat);

                            cmd.Parameters.AddWithValue(
                                "@MaChiTiet",
                                maChiTiet);

                            cmd.Parameters.AddWithValue(
                                "@MaNhanVien",
                                maNhanVien);

                            cmd.Parameters.AddWithValue(
                                "@NgayPhat",
                                ngayTra.Date);

                            cmd.Parameters.AddWithValue(
                                "@LyDo",
                                string.Join(
                                    ", ",
                                    lyDo));

                            cmd.Parameters.AddWithValue(
                                "@PhiPhat",
                                phiPhat);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    tx.Commit();

                    if (canPhat)
                    {
                        return KetQuaXuLy.Ok(
                            "Trả sách thành công và đã lập phiếu phạt.");
                    }

                    return KetQuaXuLy.Ok(
                        "Trả sách thành công.");
                }
                catch (Exception ex)
                {
                    try
                    {
                        tx.Rollback();
                    }
                    catch
                    {
                    }

                    return KetQuaXuLy.Loi(
                        "Không thể xử lý trả sách: " +
                        ex.Message);
                }
            }
        }
    }
}