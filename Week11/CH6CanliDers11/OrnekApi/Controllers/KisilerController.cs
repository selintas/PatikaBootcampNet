using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrnekApi.Data;

namespace OrnekApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KisilerController : ControllerBase
    {
        [HttpGet] // Get: api/Kisiler
        public List<Kisi> Get()
        {
            return Veri.Kisiler();
        } 
        [HttpGet("id")] // GET: spi/Kisiler/3
        public ActionResult<Kisi> Get(int id)
        {
            Kisi? kisi = Veri.Kisiler().FirstOrDefault(x => x.Id == id);

            if (kisi == null)
            {
                return NotFound();
            }
            return kisi;
        }
    }
}
