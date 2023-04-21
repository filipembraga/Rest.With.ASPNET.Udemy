﻿using Microsoft.AspNetCore.Mvc;

namespace _02___Person.REST.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult X()
        {

            return 0;
        }
    }
}
