using BasicMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BasicMVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {

            // 1. Adım: Customer nesnesini oluştur
            var customer = new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "johndoe@example.com"
            };

            // 2. Adım: Order nesnelerinin listesini oluştur
            var orders = new List<Order>
        {
            new Order { Id = 1, ProductName = "Laptop", Price = 1000.00m, Quantity = 1 },
            new Order { Id = 2, ProductName = "Mouse", Price = 20.00m, Quantity = 2 },
            new Order { Id = 3, ProductName = "Keyboard", Price = 50.00m, Quantity = 1 }
        };

            // 3. Adım: CustomerOrderViewModel nesnesini oluştur
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            // 4. Adım: View'a viewModel'i ilet
            return View(viewModel);
        }
    }
}
