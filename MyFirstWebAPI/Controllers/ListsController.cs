using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyFirstWebAPI.Models;

namespace MyFirstWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListsController : ControllerBase
    {
        private readonly ILogger<ListsController> _logger;

        public ListsController(ILogger<ListsController> logger)
        {
            _logger = logger;
        }

        [HttpPost("school")]
        public IActionResult AddSchool([FromBody] School school)
        {
            List<School> schools = new List<School>();

            var jruSchool = new School()
            {
                Name = "Jose Rizal University",
                Address = "Mandaluyong",
                Country = "PH",
                BuildingNo = 1,
                IsPrivate = true
            };

            schools.Add(jruSchool);

            schools.Add(new School()
            {
                Name = "San Beda University",
                Address = "Manila",
                Country = "PH",
                BuildingNo = 2,
                IsPrivate = true
            });

            schools.Add(school);

            string result = "";

            //foreach (var x in schools)
            //{
            //    result = result + $"School {x.Name} \n";
            //}

            schools.ForEach(x =>
            {
                result = result + $"School {x.Name} \n";
            });

            return Ok(result);
        }
    }
}
