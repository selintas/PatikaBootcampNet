using Microsoft.AspNetCore.Mvc;
using PratikAspNetCoreEmpty3.Models;

namespace PratikAspNetCoreEmpty3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
            new Product { Id = 1, Name = "pc", Price = 10000 },
            new Product { Id = 2, Name = "phone", Price = 5000 },
            };

            ProductViewModel viewModel = new()
            {
                Products = products
            };

            return View(viewModel);
        }



    }
}
