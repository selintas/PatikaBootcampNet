namespace WebApplication1.Models
{
    public class ProductViewModel
    { 
        public Product Product { get; set; }

        public List<string> Review { get; set; }

        public bool IsInstock { get; set; }
    }
}
