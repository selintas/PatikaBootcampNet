using CrazyMusiciansAPI.Data;
using Microsoft.AspNetCore.Mvc;

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
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MusiciansController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MusiciansController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
