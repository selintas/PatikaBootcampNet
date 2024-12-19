using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrnekApi.Data;
using OrnekApi.Dtos;

namespace OrnekApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KisilerController : ControllerBase
    {
        // GET: api/Kisiler
        [HttpGet]
        
        public List<Kisi> Get()
        {
            return Veri.Kisiler();
        }

        // GET: api/Kisiler/3
        [HttpGet("{id}")]
        

        public ActionResult<Kisi> Get(int id)
        {
            Kisi? kisi = Veri.Kisiler().FirstOrDefault(x => x.Id == id);

            if (kisi == null)
                return NotFound();

            return kisi;
        }

        // POST: api/Kisiler
        [HttpPost]
        public ActionResult<Kisi> PostKisi(YeniKisiDto dto)
        {
            // peki hiç kişi yoksa max metodu hata verir mi
            Kisi kisi = new Kisi()
            {
                Id = Veri.Kisiler().Any() ? Veri.Kisiler().Max(k => k.Id) + 1 : 1,
                Ad = dto.Ad
            };

            Veri.Kisiler().Add(kisi);

            return CreatedAtAction("Get", new { id = kisi.Id }, kisi);
        }

        // PUT: api/Kisiler/5
        [HttpPut("{id}")]
        public IActionResult PutKisi(int id, KisiGuncelleDto dto)
        {
            if (id != dto.Id)
                return BadRequest();

            Kisi? kisi = Veri.Kisiler().FirstOrDefault(x => x.Id == id);

            if (kisi == null)
                return NotFound();

            kisi.Ad = dto.Ad;

            return NoContent();
        }

        // DELETE: api/Kisiler/5
        [HttpDelete("{id}")]
        public IActionResult DeleteKisi(int id)
        {
            Kisi? kisi = Veri.Kisiler().FirstOrDefault(x => x.Id == id);

            if (kisi == null)
                return NotFound();

            Veri.Kisiler().Remove(kisi);

            return NoContent();
        }
    }
}