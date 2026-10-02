using System;
using System.Data;
using System.Data.SqlClient;
using eSHOPPING.Data;
using eSHOPPING.Models;

namespace eSHOPPING.Services
{
    public class OrderService
    {
        public int CreateOrder(DonHang order, PaymentResult payment)
        {
            using (var cn = Db.CreateConnection())
            {
                cn.Open();
                using (var tx = cn.BeginTransaction())
                {
                    try
                    {
                        var cmdOrder = new SqlCommand(@"INSERT INTO DonHang(MaKH, HoTenNguoiNhan, DiaChiNguoiNhan, DienThoaiNguoiNhan, LoaiGiaoHang, KhuVuc, PhiGiaoHang, TongTienHang, TongThanhToan, TrangThai, ThoiGianDat) VALUES(@kh, @hoten, @diachi, @dt, @loai, @kv, @phi, @tth, @tt, @trangthai, @thoigian); SELECT CAST(SCOPE_IDENTITY() AS INT);", cn, tx);
                        cmdOrder.Parameters.AddWithValue("@kh", order.MaKH);
                        cmdOrder.Parameters.AddWithValue("@hoten", order.HoTenNguoiNhan);
                        cmdOrder.Parameters.AddWithValue("@diachi", order.DiaChiNguoiNhan);
                        cmdOrder.Parameters.AddWithValue("@dt", order.DienThoaiNguoiNhan);
                        cmdOrder.Parameters.AddWithValue("@loai", order.LoaiGiaoHang);
                        cmdOrder.Parameters.AddWithValue("@kv", order.KhuVuc);
                        cmdOrder.Parameters.AddWithValue("@phi", order.PhiGiaoHang);
                        cmdOrder.Parameters.AddWithValue("@tth", order.TongTienHang);
                        cmdOrder.Parameters.AddWithValue("@tt", order.TongThanhToan);
                        cmdOrder.Parameters.AddWithValue("@trangthai", "Đã thanh toán");
                        cmdOrder.Parameters.AddWithValue("@thoigian", order.ThoiGianDat);
                        int maDonHang = Convert.ToInt32(cmdOrder.ExecuteScalar());

                        foreach (var item in order.ChiTiet)
                        {
                            var cmdDetail = new SqlCommand("INSERT INTO ChiTietDonHang(MaDonHang, MaSP, SoLuong, DonGia) VALUES(@dh, @sp, @sl, @gia)", cn, tx);
                            cmdDetail.Parameters.AddWithValue("@dh", maDonHang);
                            cmdDetail.Parameters.AddWithValue("@sp", item.SanPham.MaSP);
                            cmdDetail.Parameters.AddWithValue("@sl", item.SoLuong);
                            cmdDetail.Parameters.AddWithValue("@gia", item.SanPham.GiaBan);
                            cmdDetail.ExecuteNonQuery();

                            var cmdStock = new SqlCommand("UPDATE SanPham SET TonKho = TonKho - @sl WHERE MaSP=@sp AND TonKho >= @sl", cn, tx);
                            cmdStock.Parameters.AddWithValue("@sl", item.SoLuong);
                            cmdStock.Parameters.AddWithValue("@sp", item.SanPham.MaSP);
                            if (cmdStock.ExecuteNonQuery() == 0) throw new Exception("Sản phẩm không đủ tồn kho.");
                        }

                        var masked = MaskCard(payment.MaskedCardNumberForStorage);
                        var cmdPayment = new SqlCommand("INSERT INTO ThanhToan(MaDonHang, LoaiThe, SoTheMasked, MaGiaoDich, TrangThai, ThoiGianThanhToan) VALUES(@dh, @loaithe, @mask, @gd, @tt, @tg)", cn, tx);
                        cmdPayment.Parameters.AddWithValue("@dh", maDonHang);
                        cmdPayment.Parameters.AddWithValue("@loaithe", payment.CardType);
                        cmdPayment.Parameters.AddWithValue("@mask", masked);
                        cmdPayment.Parameters.AddWithValue("@gd", payment.MaGiaoDich);
                        cmdPayment.Parameters.AddWithValue("@tt", "Thành công");
                        cmdPayment.Parameters.AddWithValue("@tg", DateTime.Now);
                        cmdPayment.ExecuteNonQuery();

                        tx.Commit();
                        return maDonHang;
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }

        private string MaskCard(string raw)
        {
            if (string.IsNullOrWhiteSpace(raw)) return "";
            var s = raw.Trim();
            if (s.Length <= 4) return s;
            return new string('*', s.Length - 4) + s.Substring(s.Length - 4);
        }
    }
}
