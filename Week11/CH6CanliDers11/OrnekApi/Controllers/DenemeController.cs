using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrnekApi.Dtos;

namespace OrnekApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DenemeController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] string baslik)
        {
            // bir takım işlemler

            return Ok();
        }

        // SORU: dto içinde Baslik adında bir property var
        // default olarak bunu gövdeden bilgisini alır
        // querystring'den aldırabilir miyiz?
        [HttpPut]
        public IActionResult Put([FromQuery] DenemeDto dto)
        {
            return Ok();
        }
    }
}
