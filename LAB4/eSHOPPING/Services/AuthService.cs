using System;
using System.Data.SqlClient;
using eSHOPPING.Data;
using eSHOPPING.Models;

namespace eSHOPPING.Services
{
    public class AuthService
    {
        public KhachHang Login(string username, string password)
        {
            using (var cn = Db.CreateConnection())
            using (var cmd = new SqlCommand("SELECT TOP 1 MaKH, HoTen, NgaySinh, CMNDPassport, DiaChi, DienThoai, TenDangNhap, MatKhau, Email FROM KhachHang WHERE TenDangNhap=@u AND MatKhau=@p", cn))
            {
                cmd.Parameters.AddWithValue("@u", username.Trim());
                cmd.Parameters.AddWithValue("@p", password);
                cn.Open();
                using (var rd = cmd.ExecuteReader())
                {
                    if (!rd.Read()) return null;
                    return new KhachHang
                    {
                        MaKH = Convert.ToInt32(rd["MaKH"]),
                        HoTen = rd["HoTen"].ToString(),
                        NgaySinh = rd["NgaySinh"] == DBNull.Value ? "" : Convert.ToDateTime(rd["NgaySinh"]).ToString("dd/MM/yyyy"),
                        CMNDPassport = rd["CMNDPassport"].ToString(),
                        DiaChi = rd["DiaChi"].ToString(),
                        DienThoai = rd["DienThoai"].ToString(),
                        TenDangNhap = rd["TenDangNhap"].ToString(),
                        MatKhau = rd["MatKhau"].ToString(),
                        Email = rd["Email"].ToString()
                    };
                }
            }
        }

        public bool Register(KhachHang item, out string message)
        {
            message = "";
            using (var cn = Db.CreateConnection())
            using (var check = new SqlCommand("SELECT COUNT(1) FROM KhachHang WHERE TenDangNhap=@u", cn))
            {
                check.Parameters.AddWithValue("@u", item.TenDangNhap.Trim());
                cn.Open();
                if (Convert.ToInt32(check.ExecuteScalar()) > 0)
                {
                    message = "Tên đăng nhập đã tồn tại.";
                    return false;
                }
            }

            using (var cn = Db.CreateConnection())
            using (var cmd = new SqlCommand("INSERT INTO KhachHang(HoTen, NgaySinh, CMNDPassport, DiaChi, DienThoai, TenDangNhap, MatKhau, Email) VALUES(@hoten, @ngaysinh, @cmnd, @diachi, @dienthoai, @u, @p, @email)", cn))
            {
                DateTime dt;
                object ngay = DBNull.Value;
                if (DateTime.TryParse(item.NgaySinh, out dt)) ngay = dt.Date;
                cmd.Parameters.AddWithValue("@hoten", item.HoTen.Trim());
                cmd.Parameters.AddWithValue("@ngaysinh", ngay);
                cmd.Parameters.AddWithValue("@cmnd", (object)item.CMNDPassport ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@diachi", item.DiaChi.Trim());
                cmd.Parameters.AddWithValue("@dienthoai", item.DienThoai.Trim());
                cmd.Parameters.AddWithValue("@u", item.TenDangNhap.Trim());
                cmd.Parameters.AddWithValue("@p", item.MatKhau);
                cmd.Parameters.AddWithValue("@email", (object)item.Email ?? DBNull.Value);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            return true;
        }
    }
}
