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


        [HttpGet("school")]
        public IActionResult GetSchool([FromQuery] bool isPrivate)
        {
            List<School> schools = new List<School>(){
                new School(){ Id = 1, 
                    Name="JRU",
                    Address="Manda",
                    BuildingNo = 1,
                    Country = "PH",
                    IsPrivate = true
                },
                new School(){ Id = 2,
                    Name="SBU",
                    Address="Manila",
                    BuildingNo = 2,
                    Country = "PH",
                    IsPrivate = true
                },
                    new School(){ Id = 3,
                    Name="SEHS",
                    Address="Marikina",
                    BuildingNo = 3,
                    Country = "PH",
                    IsPrivate = false
                },
                     new School(){ Id = 4,
                    Name="RTU",
                    Address="Manda",
                    BuildingNo = 4,
                    Country = "PH",
                    IsPrivate = false
                },
            };


            string result = "";

            schools = schools.Where(x => x.IsPrivate == isPrivate).ToList();

            schools.ForEach(x =>
            {
                result = result + $"School {x.Name} \n";
            });

            return Ok(result);
        }

        [HttpGet("school/one")]
        public IActionResult GetSchoolOne([FromQuery] bool isPrivate)
        {
            List<School> schools = new List<School>(){
                new School(){ Id = 1,
                    Name="JRU",
                    Address="Manda",
                    BuildingNo = 1,
                    Country = "PH",
                    IsPrivate = true
                },
                new School(){ Id = 2,
                    Name="SBU",
                    Address="Manila",
                    BuildingNo = 2,
                    Country = "PH",
                    IsPrivate = true
                },
                    new School(){ Id = 3,
                    Name="SEHS",
                    Address="Marikina",
                    BuildingNo = 3,
                    Country = "PH",
                    IsPrivate = false
                },
                     new School(){ Id = 4,
                    Name="RTU",
                    Address="Manda",
                    BuildingNo = 4,
                    Country = "PH",
                    IsPrivate = false
                },
            };


            //School school = schools.Where(x => x.IsPrivate == isPrivate).FirstOrDefault();
            School school = schools.Where(x => x.IsPrivate == isPrivate).LastOrDefault();

            return Ok($"School {school.Name} \n");
        }

        [HttpGet("school/sort/asc")]
        public IActionResult GetSchoolOrderByName()
        {
            List<School> schools = new List<School>(){
                new School(){ Id = 1,
                    Name="JRU",
                    Address="Manda",
                    BuildingNo = 1,
                    Country = "PH",
                    IsPrivate = true
                },
                new School(){ Id = 2,
                    Name="SBU",
                    Address="Manila",
                    BuildingNo = 2,
                    Country = "PH",
                    IsPrivate = true
                },
                    new School(){ Id = 3,
                    Name="SEHS",
                    Address="Marikina",
                    BuildingNo = 3,
                    Country = "PH",
                    IsPrivate = false
                },
                     new School(){ Id = 4,
                    Name="RTU",
                    Address="Manda",
                    BuildingNo = 4,
                    Country = "PH",
                    IsPrivate = false
                },
            };


            string result = "";

            schools = schools.OrderBy(x => x.Name).ToList();

            schools.ForEach(x =>
            {
                result = result + $"School {x.Name} \n";
            });

            return Ok(result);
        }

        [HttpGet("school/sort/desc")]
        public IActionResult GetSchoolOrderByNameDesc()
        {
            List<School> schools = new List<School>(){
                new School(){ Id = 1,
                    Name="JRU",
                    Address="Manda",
                    BuildingNo = 1,
                    Country = "PH",
                    IsPrivate = true
                },
                new School(){ Id = 2,
                    Name="SBU",
                    Address="Manila",
                    BuildingNo = 2,
                    Country = "PH",
                    IsPrivate = true
                },
                    new School(){ Id = 3,
                    Name="SEHS",
                    Address="Marikina",
                    BuildingNo = 3,
                    Country = "PH",
                    IsPrivate = false
                },
                     new School(){ Id = 4,
                    Name="RTU",
                    Address="Manda",
                    BuildingNo = 4,
                    Country = "PH",
                    IsPrivate = false
                },
            };

            string result = "";

            schools = schools.OrderByDescending(x => x.Name).ToList();

            schools.ForEach(x =>
            {
                result = result + $"School {x.Name} \n";
            });

            return Ok(result);
        }
    }
}
