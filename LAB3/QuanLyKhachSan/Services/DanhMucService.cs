using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyKhachSan.Data;

namespace QuanLyKhachSan.Services
{
    public class DanhMucService
    {
        public DataTable LayKhuVuc() { return Db.Query("SELECT * FROM KhuVuc ORDER BY MaKhuVuc"); }
        public DataTable LayNhanVien() { return Db.Query("SELECT * FROM NhanVien ORDER BY MaNV"); }
        public DataTable LayLoaiTienNghi() { return Db.Query("SELECT * FROM LoaiTienNghi ORDER BY MaLoaiTN"); }
        public DataTable LayDichVu() { return Db.Query("SELECT * FROM DichVu ORDER BY MaDV"); }
        public DataTable LayQuyDinhDenBu() { return Db.Query("SELECT q.*, l.TenLoaiTN FROM QuyDinhDenBu q JOIN LoaiTienNghi l ON q.MaLoaiTN=l.MaLoaiTN ORDER BY q.MaQuyDinh"); }

        public bool ThemKhu(string ma, string ten, out string msg)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten))
            { msg = "Mã khu vực và tên khu vực không được để trống."; return false; }
            try
            {
                Db.Execute("INSERT INTO KhuVuc VALUES(@m, @t)", new SqlParameter("@m", ma), new SqlParameter("@t", ten));
                msg = "Đã thêm khu vực."; return true;
            }
            catch (Exception ex) { msg = ex.Message; return false; }
        }

        public bool ThemNhanVien(string ma, string ten, string vaiTro, string sdt, out string msg)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(vaiTro))
            { msg = "Thông tin nhân viên chưa đầy đủ."; return false; }
            try
            {
                Db.Execute("INSERT INTO NhanVien VALUES(@m, @t, @v, @s)",
                    new SqlParameter("@m", ma), new SqlParameter("@t", ten),
                    new SqlParameter("@v", vaiTro), new SqlParameter("@s", (object)sdt ?? DBNull.Value));
                msg = "Đã thêm nhân viên."; return true;
            }
            catch (Exception ex) { msg = ex.Message; return false; }
        }

        public bool ThemLoaiTN(string ma, string ten, out string msg)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten))
            { msg = "Thông tin loại tiện nghi chưa đủ."; return false; }
            try
            {
                Db.Execute("INSERT INTO LoaiTienNghi VALUES(@m, @t)", new SqlParameter("@m", ma), new SqlParameter("@t", ten));
                msg = "Đã thêm loại tiện nghi."; return true;
            }
            catch (Exception ex) { msg = ex.Message; return false; }
        }

        public bool ThemDichVu(string ma, string ten, string dvt, decimal gia, out string msg)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(dvt) || gia < 0)
            { msg = "Thông tin dịch vụ không hợp lệ."; return false; }
            try
            {
                Db.Execute("INSERT INTO DichVu VALUES(@m, @t, @d, @g)",
                    new SqlParameter("@m", ma), new SqlParameter("@t", ten),
                    new SqlParameter("@d", dvt), new SqlParameter("@g", gia));
                msg = "Đã thêm dịch vụ."; return true;
            }
            catch (Exception ex) { msg = ex.Message; return false; }
        }

        public bool ThemQuyDinh(string ma, string loai, string muc, decimal tien, out string msg)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(loai) || string.IsNullOrWhiteSpace(muc) || tien < 0)
            { msg = "Quy định đền bù không hợp lệ."; return false; }
            try
            {
                Db.Execute("INSERT INTO QuyDinhDenBu VALUES(@m, @l, @u, @t)",
                    new SqlParameter("@m", ma), new SqlParameter("@l", loai),
                    new SqlParameter("@u", muc), new SqlParameter("@t", tien));
                msg = "Đã thêm quy định đền bù."; return true;
            }
            catch (Exception ex) { msg = ex.Message; return false; }
        }
    }
}