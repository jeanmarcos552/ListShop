using Microsoft.AspNetCore.Mvc;

using ListaShop.Services;
using ListaShop.Model;

namespace ListaShop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        
        private IPersonService _personService;

        public PersonController( IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personService.Find());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            return Ok(_personService.FindById(id));
        }

        [HttpPost]
        public IActionResult Post ([FromBody] Person person)
        {
            return Ok(_personService.Create(person));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] long id)
        {
            _personService.Delete(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult Update ([FromBody] Person person)
        {
            return Ok(_personService.Update(person));
        }
    }
}
