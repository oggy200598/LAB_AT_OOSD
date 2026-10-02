using System;
using System.Linq;
using eSHOPPING.Models;

namespace eSHOPPING.Adapters
{
    public class PaymentAdapter
    {
        public PaymentResult Authorize(string loaiThe, string soThe, string ngayHetHan, string chuThe, string csv, decimal soTien)
        {
            if (string.IsNullOrWhiteSpace(soThe) || !soThe.All(char.IsDigit))
                return new PaymentResult { ThanhCong = false, ThongBao = "Số thẻ không hợp lệ." };

            int expectedLength = loaiThe == "American Express" ? 15 : 16;
            int expectedCsv = loaiThe == "American Express" ? 4 : 3;
            if (soThe.Length != expectedLength)
                return new PaymentResult { ThanhCong = false, ThongBao = "Số thẻ không đúng độ dài." };
            if (string.IsNullOrWhiteSpace(csv) || csv.Length != expectedCsv || !csv.All(char.IsDigit))
                return new PaymentResult { ThanhCong = false, ThongBao = "Mã bảo mật không hợp lệ." };
            if (!DateTime.TryParseExact(ngayHetHan, "MM/yyyy", null, System.Globalization.DateTimeStyles.None, out var date))
                return new PaymentResult { ThanhCong = false, ThongBao = "Ngày hết hạn phải có dạng MM/yyyy." };
            if (date < new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1))
                return new PaymentResult { ThanhCong = false, ThongBao = "Thẻ đã hết hạn." };
            if (string.IsNullOrWhiteSpace(chuThe))
                return new PaymentResult { ThanhCong = false, ThongBao = "Vui lòng nhập họ tên chủ thẻ." };
            if (soTien <= 0)
                return new PaymentResult { ThanhCong = false, ThongBao = "Số tiền thanh toán không hợp lệ." };

            return new PaymentResult
            {
                ThanhCong = true,
                MaGiaoDich = "PAY" + DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                ThongBao = "Thanh toán được chấp nhận.",
                CardType = loaiThe,
                MaskedCardNumberForStorage = soThe
            };
        }
    }
}
