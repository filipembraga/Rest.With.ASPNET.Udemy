using _02___Person.REST.Business.Interfaces;
using _02___Person.REST.Model;
using Microsoft.AspNetCore.Mvc;

namespace _02___Person.REST.Controllers.V2
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v2/[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;
        private IPersonBusiness _personBusiness;

        public PersonController(ILogger<PersonController> logger, IPersonBusiness personService)
        {
            _logger = logger;
            _personBusiness = personService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] PersonV2 person)
        {
            if (person == null)
                return BadRequest();
            return Ok(_personBusiness.Create(person));
        }
    }
}
