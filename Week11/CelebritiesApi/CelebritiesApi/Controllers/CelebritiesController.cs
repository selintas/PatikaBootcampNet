using Microsoft.AspNetCore.Mvc;
using CelebritiesApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace CelebritiesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CelebritiesController : ControllerBase
    {
        private static readonly List<Celebrity> celebrities = new List<Celebrity>
        {
            new Celebrity { Id = 1, Name = "Tarkan", Profession = "Pop Müzik Sanatçısı" },
            new Celebrity { Id = 2, Name = "Sıla", Profession = "Pop Müzik Sanatçısı" },
            new Celebrity { Id = 3, Name = "Kenan İmirzalioğlu", Profession = "Oyuncu" },
            new Celebrity { Id = 4, Name = "Bergüzar Korel", Profession = "Oyuncu" }
        };

        // GET: api/celebrities
        [HttpGet]
        public ActionResult<IEnumerable<Celebrity>> Get()
        {
            return Ok(celebrities);
        }
        // GET: api/celebrities/5
        [HttpGet("{id}")]
        public ActionResult<Celebrity> Get(int id)
        {
            var celebrity = celebrities.FirstOrDefault(c => c.Id == id);
            if (celebrity == null)
            {
                return NotFound();
            }
            return Ok(celebrity);
        }
        // POST: api/celebrities
        [HttpPost]
        public ActionResult<Celebrity> Post([FromBody] Celebrity celebrity)
        {
            celebrity.Id = celebrities.Max(c => c.Id) + 1; // Yeni ID oluştur
            celebrities.Add(celebrity);
            return CreatedAtAction(nameof(Get), new { id = celebrity.Id }, celebrity);
        }
        // PUT: api/celebrities/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Celebrity updatedCelebrity)
        {
            var celebrity = celebrities.FirstOrDefault(c => c.Id == id);
            if (celebrity == null)
            {
                return NotFound();
            }
            celebrity.Name = updatedCelebrity.Name;
            celebrity.Profession = updatedCelebrity.Profession;
            return NoContent();
        }
        // DELETE: api/celebrities/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var celebrity = celebrities.FirstOrDefault(c => c.Id == id);
            if (celebrity == null)
            {
                return NotFound();
            }
            celebrities.Remove(celebrity);
            return NoContent();
        }
    }
}
//Beraber Api Projesi Oluşturuyoruz.
