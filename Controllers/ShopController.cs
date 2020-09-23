using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

using ListaShop.Model;

namespace ListaShop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShopController : ControllerBase
    {
        public ShopController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("getAll");
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            return Ok($"get {id}");
        }


        [HttpPost]
        public IActionResult Post ([FromBody] Shop listaShop)
        {
            return Ok(listaShop);
        }

        [HttpPut("{id}")]
        public IActionResult Update ([FromBody] Shop listaShop)
        {
            return Ok(listaShop);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete (long id)
        {
            return NoContent();
        }
    }
}
