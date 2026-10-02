namespace eSHOPPING.Models
{
    public class PaymentResult
    {
        public bool ThanhCong { get; set; }
        public string MaGiaoDich { get; set; }
        public string ThongBao { get; set; }
        public string CardType { get; set; }
        public string MaskedCardNumberForStorage { get; set; }
    }
}
