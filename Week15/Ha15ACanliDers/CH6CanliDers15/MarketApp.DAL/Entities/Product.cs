using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp.DAL.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = "";

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; } = null!;
    }
}
