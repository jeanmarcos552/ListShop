using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ListaShop.Services;
using ListaShop.Model;

namespace ListaShop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        
        private readonly ILogger<PersonController> _logger;
        private IPersonService _personService;

        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personService.Get());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            return Ok(_personService.GetById(id));
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
