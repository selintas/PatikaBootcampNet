using CrazyMusiciansAPI.Data;
using CrazyMusiciansAPI.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

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
        [HttpGet("{id}")]
        public ActionResult<Musician> Get(int id)
        {
            Musician? musician = DataStore.Musicians().FirstOrDefault(x => x.Id == id);

            if (musician == null)
                return NotFound();

            return musician;
        }

        // POST api/<MusiciansController>
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

        // PUT api/<MusiciansController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, PutMusicianDto dto)
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

            return NotFound(); //204 no content içerik yok

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
