using MarketApp.Business.Dtos;
using MarketApp.Business.Interfaces;
using MarketApp.DAL.Entities;
using MarketApp.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp.Business.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepo;

        public ProductService(IRepository<Product> productRepo)
        {
            _productRepo = productRepo;
        }

        public List<ProductDto> GetProducts()
        {
            return _productRepo.GetAll().Select(p => new ProductDto()
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                CategoryId = p.CategoryId
            }).ToList();
        }

        public List<ProductDto> GetProducts(int categoryId)
        {
            return _productRepo
            .GetAll(p => p.CategoryId == categoryId)
            .Select(p => new ProductDto()
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                CategoryId = p.CategoryId
            }).ToList();
        }
    }
}
