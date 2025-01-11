using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp.Business.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public decimal Price { get; set; }

        public int CategoryId { get; set; }
    }
}
