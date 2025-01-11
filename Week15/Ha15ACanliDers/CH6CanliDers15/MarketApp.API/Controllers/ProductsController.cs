using MarketApp.Business.Dtos;
using MarketApp.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarketApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<ProductDto> GetProducts(int? categoryId)
        {
            if (categoryId.HasValue)
                return _productService.GetProducts(categoryId.Value);

            return _productService.GetProducts();
        }
    }
}
