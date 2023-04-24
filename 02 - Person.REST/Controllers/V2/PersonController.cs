using _02___Person.REST.Model;
using _02___Person.REST.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace _02___Person.REST.Controllers.V2
{    
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v2/[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;
        private IPersonService _personService;

        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] PersonV2 person)
        {
            if (person == null)
                return BadRequest();
            return Ok(_personService.Create(person));
        }
    }
}
