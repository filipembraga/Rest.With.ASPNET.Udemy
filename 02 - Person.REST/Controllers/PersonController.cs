using _02___Person.REST.Business.Interfaces;
using _02___Person.REST.Model;
using Microsoft.AspNetCore.Mvc;

namespace _02___Person.REST.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v1/[controller]")]
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
        public IActionResult Post([FromBody] Person person)
        {
            if (person == null)
                return BadRequest();
            return Ok(_personBusiness.Create(person));
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _personBusiness.FindById(id);
            if (person == null)
                return NotFound();
            return Ok(person);
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok(_personBusiness.FindAll());
        }

        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            if (person == null)
                return BadRequest();
            return Ok(_personBusiness.Update(person));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personBusiness.Delete(id);
            return NoContent();
        }
    }
}
