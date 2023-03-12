using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MyFirstWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CrystalExercismController : ControllerBase
    {
        private readonly ILogger<CrystalExercismController> _logger;

        public CrystalExercismController(ILogger<CrystalExercismController> logger)
        {
            _logger = logger;
        }

        [HttpGet("generate/acronym/name")]
        public IActionResult GetTheAcronyms([FromQuery] string name)
        {

            String abbreviation = string.Join(string.Empty, name.Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s[0]));


            //abbreviation = abbreviation.Substring(words);

            return Ok(abbreviation);
        }




    }

}
