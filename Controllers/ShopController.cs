using Microsoft.AspNetCore.Mvc;

using ListaShop.Model;
using ListaShop.Services.Implementations;
using ListaShop.Services;

namespace ListaShop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShopController : ControllerBase
    {
        private IShopService _service;

        public ShopController(IShopService service) {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            return Ok(_service.FindById(id));
        }


        [HttpPost]
        public IActionResult Post ([FromBody] Shop listaShop)
        {
            return Ok(_service.Create(listaShop));
        }

        [HttpPut("{id}")]
        public IActionResult Update ([FromBody] Shop listaShop)
        {
            return Ok(_service.Update(listaShop));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete (long id)
        {
            _service.Delete(id);

            return NoContent();
        }
    }
}
