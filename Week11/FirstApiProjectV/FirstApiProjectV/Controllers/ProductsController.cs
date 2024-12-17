using FirstApiProjectV.Models; 
using Microsoft.AspNetCore.Mvc;

namespace FirstApiProjectV.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase // because Api
    {
        // api/products/2 yazabılsın [HttpGet("{id}")] kullandık
        private static List<Product> _products = new List<Product>()
        {
            new Product{ Id = 1, Name ="Product1", Price=200},
            new Product{ Id = 2, Name ="Product2", Price=300},
        };
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _products;

        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);
            if(product == null)
            {
                return NotFound(); //404
            }

            return Ok(product);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Product product) //ekleme post
        {
            var id = _products.Max(x => x.Id) + 1;
            product.Id = id;
            _products.Add(product);

            return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
        }
        [HttpPut]
        public IActionResult Put(int id, [FromBody] Product product)  // guncellecek
        {   
            if(product == null || id != product.Id)
            {
                return BadRequest();//400
            }

            var existingProduct = _products.FirstOrDefault(x => x.Id ==id);
            if(existingProduct == null) 
            {
                return NotFound();
            }

            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;

            return Ok(existingProduct); //200
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var existingProduct = _products.FirstOrDefault(y => y.Id == id);
            if (existingProduct is null)
            {
                return NotFound();
            }

            _products.Remove(existingProduct);

            return NoContent();
        }
    }
}


