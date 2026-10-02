using System.Collections.Generic;
using eSHOPPING.Models;
using eSHOPPING.Services;

namespace eSHOPPING.Adapters
{
    public class ProductAdapter
    {
        private readonly ProductService _service = new ProductService();

        public List<SanPham> GetProducts(int maNhom, string keyword)
        {
            return _service.GetProducts(maNhom, keyword);
        }

        public SanPham GetProduct(int maSP)
        {
            return _service.GetProduct(maSP);
        }
    }
}
