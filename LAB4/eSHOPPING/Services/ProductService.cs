using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using eSHOPPING.Data;
using eSHOPPING.Models;

namespace eSHOPPING.Services
{
    public class ProductService
    {
        public List<NhomSanPham> GetGroups()
        {
            var list = new List<NhomSanPham>();
            using (var cn = Db.CreateConnection())
            using (var cmd = new SqlCommand("SELECT MaNhom, TenNhom FROM NhomSanPham ORDER BY TenNhom", cn))
            {
                cn.Open();
                using (var rd = cmd.ExecuteReader())
                while (rd.Read())
                    list.Add(new NhomSanPham { MaNhom = Convert.ToInt32(rd["MaNhom"]), TenNhom = rd["TenNhom"].ToString() });
            }
            return list;
        }

        public List<SanPham> GetProducts(int maNhom, string keyword)
        {
            var list = new List<SanPham>();
            using (var cn = Db.CreateConnection())
            using (var cmd = new SqlCommand(@"SELECT sp.*, n.TenNhom FROM SanPham sp INNER JOIN NhomSanPham n ON sp.MaNhom=n.MaNhom WHERE (@group=0 OR sp.MaNhom=@group) AND (@keyword='' OR sp.TenSP LIKE '%' + @keyword + '%') ORDER BY sp.TenSP", cn))
            {
                cmd.Parameters.AddWithValue("@group", maNhom);
                cmd.Parameters.AddWithValue("@keyword", keyword ?? "");
                cn.Open();
                using (var rd = cmd.ExecuteReader())
                while (rd.Read())
                    list.Add(Map(rd));
            }
            return list;
        }

        public SanPham GetProduct(int maSP)
        {
            using (var cn = Db.CreateConnection())
            using (var cmd = new SqlCommand("SELECT sp.*, n.TenNhom FROM SanPham sp INNER JOIN NhomSanPham n ON sp.MaNhom=n.MaNhom WHERE sp.MaSP=@id", cn))
            {
                cmd.Parameters.AddWithValue("@id", maSP);
                cn.Open();
                using (var rd = cmd.ExecuteReader())
                    return rd.Read() ? Map(rd) : null;
            }
        }

        private SanPham Map(SqlDataReader rd)
        {
            return new SanPham
            {
                MaSP = Convert.ToInt32(rd["MaSP"]),
                TenSP = rd["TenSP"].ToString(),
                NhaSanXuat = rd["NhaSanXuat"].ToString(),
                HinhAnh = rd["HinhAnh"].ToString(),
                MoTa = rd["MoTa"].ToString(),
                ThongSoKyThuat = rd["ThongSoKyThuat"].ToString(),
                GiaBan = Convert.ToDecimal(rd["GiaBan"]),
                TonKho = Convert.ToInt32(rd["TonKho"]),
                MaNhom = Convert.ToInt32(rd["MaNhom"]),
                TenNhom = rd["TenNhom"].ToString()
            };
        }
    }
}
