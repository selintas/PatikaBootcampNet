using CrazyMusiciansAPI.Data;
using CrazyMusiciansAPI.Dtos;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
//using Microsoft.AspNetCore.JsonPatch;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrazyMusiciansAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusiciansController : ControllerBase
    {
        // GET: api/<MusiciansController>
        [HttpGet]
        public List<Musician> Get()
        {
            return DataStore.Musicians();
        }

        // GET api/<MusicianController>/5
        [HttpGet("{id:int:min(1)}", Name = "GetMusicianbyId")]
        public ActionResult<Musician> Get(int id)
        {
            Musician? musician = DataStore.Musicians().FirstOrDefault(x => x.Id == id);

            if (musician == null)
                return NotFound();

            return musician;

        }
        ////ornek uygulama
        [HttpGet("search/{keyword:alpha:minlength(3)}")]
        ////search?keyword=deneme& page=1
        public IActionResult Search(string keyword)
        {
            return Ok();
        }
        ////ornek uygulama
        //[HttpGet("search")]
        ////search?keyword=deneme& page=1
        //public IActionResult Search([FromQuery] string keyword, [FromQuery] int? page = 1)
        //{
        //    return Ok();
        //}
        
        // POST api/<MusiciansController>  //POST eklemek
        [HttpPost]
        public ActionResult<Musician> Post(PostMusicianDto dto)
        {
            Musician musician = new Musician()
            {
                Id = DataStore.Musicians().Any() ? DataStore.Musicians().Max(x => x.Id) + 1 : 1, // 1 fazlası ıd ekler 
                Name = dto.Name,
                Instrument = dto.Instrument,
                Genre = dto.Genre,
                YearsActive = dto.YearsActive
            };
            DataStore.Musicians().Add(musician);
            // 201 creadted
            return CreatedAtAction("Get", new {id =musician.Id}, musician);
        }
        //PUT(Create - Oluştur)
        // PUT api/<MusiciansController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, PutMusicianDto dto) //(Create - Oluştur)
        {
            if (id != dto.Id)
                return BadRequest(); 

            Musician? musician = DataStore.Musicians().FirstOrDefault(o => o.Id == id);
            if (musician == null)
                return NotFound(); // Müzisyen bulunamadıysa 404 döndür
            
            musician.Name = dto.Name;
            musician.Instrument = dto.Instrument;
            musician.Genre = dto.Genre;
            musician.YearsActive = dto.YearsActive;

            return NoContent(); // Başarılı güncelleme, içerik yok (204) //204 no content içerik yok

        }
        // Patch 
        // PATCH api/<MusiciansController>/5
        // PATCH: api/Musician/{id}
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromQuery] string? name, [FromQuery] string? instrument, [FromQuery] string? genre, [FromQuery] int? YearsActive)
        {
            // İlgili müzisyeni bul
            Musician? musician = DataStore.Musicians().FirstOrDefault(m => m.Id == id);
            if (musician == null)
                return NotFound("Musician not found."); // 404: Müzisyen bulunamadı

            // Gönderilen parametrelere göre alanları güncelle
            if (!string.IsNullOrEmpty(name))
                musician.Name = name;

            if (!string.IsNullOrEmpty(instrument))
                musician.Instrument = instrument;

            if (!string.IsNullOrEmpty(genre))
                musician.Genre = genre;

            // yearsActive kontrolü ve güncellemesi
            // yearsActive kontrolü ve güncellemesi
            if (YearsActive != null && YearsActive > 0)
                musician.YearsActive = YearsActive.Value;

            return Ok(musician); // Güncellenmiş müzisyeni döndür
        }


        // DELETE api/<MusiciansController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Musician? musician = DataStore.Musicians().FirstOrDefault(o => o.Id == id);

            if (musician == null)
                return NotFound();

            DataStore.Musicians().Remove(musician);

            return NoContent();
        }
    }

    //public interface IActionResult<T>
    //{
    //}
}
