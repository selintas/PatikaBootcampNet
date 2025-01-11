using MarketApp.Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp.Business.Interfaces
{
    public interface IProductService
    {
        List<ProductDto> GetProducts();

        List<ProductDto> GetProducts(int categoryId);
    }
}
