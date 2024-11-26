using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Product
    { 

        public int Id { get; set; }
        [Required(ErrorMessage = "ürün adı girmek zorunlu")]
        [StringLength(100)]
        public string Name { get; set; }

        [Range(0,100000)]
        public decimal Price { get; set; }
    }
}
