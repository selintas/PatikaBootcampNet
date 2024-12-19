using CrazyMusiciansAPI.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrazyMusiciansAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicianController : ControllerBase
    {
        // GET: api/<MusicianController>
        [HttpGet]
        public List<Musician> Get()
        {
            return DataStore.Musicians();
        }

        // GET api/<MusicianController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MusicianController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MusicianController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MusicianController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
