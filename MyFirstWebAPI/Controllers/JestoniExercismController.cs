using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyFirstWebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebAPI
{
    [ApiController]
    [Route("[controller]")]
    public class JestoniExercismController : ControllerBase
    {
        private readonly ILogger<JestoniExercismController> _logger;

        public JestoniExercismController(ILogger<JestoniExercismController> logger)
        {
            _logger = logger;
        }

        [HttpGet("convertion/phrase")]
        public IActionResult FindTheAcronyms([FromQuery] String words)
        {
            String abbreviation = string.Join(string.Empty, words.Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s[0]));


            //abbreviation = abbreviation.Substring(words);

            return Ok(abbreviation);
            
        }
        
    }
}
