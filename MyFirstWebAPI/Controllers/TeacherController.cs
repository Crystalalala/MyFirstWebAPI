using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyFirstWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly ILogger<TeacherController> _logger;

        public TeacherController(ILogger<TeacherController> logger)
        {
            _logger = logger;
        }
        [HttpPost("govsteacher1")]
        public IActionResult AddTeacher([FromBody] Teacher teacher)
        {
            List<Teacher> teachers = new List<Teacher>();

            var teacher1 = new Teacher()
            {
                Id = 1,
                firstName = "Ivana",
                middleName = "Wilawil",
                lastName = "Alawi",
                section = 1,
                age = 29,
                gender = 'F'

            };

            teachers.Add(teacher1);

            var teacher2 = new Teacher()
            {
                Id = 2,
                firstName = "Mark",
                middleName = "Martines",
                lastName = "Nasol",
                section = 2,
                age = 30,
                gender = 'M'
            };
            teachers.Add(teacher2);

            var teacher3 = new Teacher()
            {
                Id = 3,
                firstName = "Darius",
                middleName = "Fortes",
                lastName = "Trance",
                section = 3,
                age = 28,
                gender = 'M'
            };
            teachers.Add(teacher3);


            teachers.Add(teacher);
            string result = "";
            foreach (var x in teachers)
            {
                result = result + $"Teacher {x.firstName}  \n";
            }
            return Ok(result);

        }
        [HttpGet("govsteacher2")]
        public IActionResult GetTeacher([FromQuery] char gender)
        {
            List<Teacher> teachers = new List<Teacher>()
           {
            new Teacher()
                {
                Id = 1,
                firstName = "Ivana",
                middleName = "Wilawil",
                lastName = "Alawi",
                section = 1,
                age = 29,
                gender = 'F'
                 },
            new Teacher()
            {
                Id = 2,
                firstName = "Mark",
                middleName = "Martines",
                lastName = "Nasol",
                section = 2,
                age = 30,
                gender = 'M'
            },
            new Teacher()
            {
                Id = 3,
                firstName = "Darius",
                middleName = "Fortes",
                lastName = "Trance",
                section = 3,
                age = 28,
                gender = 'M'
            },
            new Teacher()
            {
                Id = 4,
                firstName = "Jessebeth",
                middleName = "Lecciones",
                lastName = "Aduana",
                section = 4,
                age = 40,
                gender = 'F'
            },
           };

            teachers = teachers.Where(x => x.gender == gender).ToList();
            string result = "";
            foreach (var x in teachers)
            {
                result = result + $"Teacher {x.firstName}  \n";
            }
            return Ok(result);
        }
        [HttpGet("govsteacher3")]
        public IActionResult GetOneTeacher([FromQuery] char gender)
        {
            List<Teacher> teachers = new List<Teacher>()
           {
            new Teacher()
                {
                Id = 1,
                firstName = "Ivana",
                middleName = "Wilawil",
                lastName = "Alawi",
                section = 1,
                age = 29,
                gender = 'F'
                 },
            new Teacher()
            {
                Id = 2,
                firstName = "Mark",
                middleName = "Martines",
                lastName = "Nasol",
                section = 2,
                age = 30,
                gender = 'M'
            },
            new Teacher()
            {
                Id = 3,
                firstName = "Darius",
                middleName = "Fortes",
                lastName = "Trance",
                section = 3,
                age = 28,
                gender = 'M'
            },
            new Teacher()
            {
                Id = 4,
                firstName = "Jessebeth",
                middleName = "Lecciones",
                lastName = "Aduana",
                section = 4,
                age = 40,
                gender = 'F'
            },
           };

            Teacher teacher = teachers.Where(x => x.gender == gender).FirstOrDefault();

            return Ok($"Teacher{teacher.firstName} \n");
        }
        [HttpGet("govsteacher/asc")]
        public IActionResult GetTeacherOrderByAge()
        {
            List<Teacher> teachers = new List<Teacher>()
           {
            new Teacher()
                {
                Id = 1,
                firstName = "Ivana",
                middleName = "Wilawil",
                lastName = "Alawi",
                section = 1,
                age = 29,
                gender = 'F'
                 },
            new Teacher()
            {
                Id = 2,
                firstName = "Mark",
                middleName = "Martines",
                lastName = "Nasol",
                section = 2,
                age = 30,
                gender = 'M'
            },
            new Teacher()
            {
                Id = 3,
                firstName = "Darius",
                middleName = "Fortes",
                lastName = "Trance",
                section = 3,
                age = 28,
                gender = 'M'
            },
            new Teacher()
            {
                Id = 4,
                firstName = "Jessebeth",
                middleName = "Lecciones",
                lastName = "Aduana",
                section = 4,
                age = 40,
                gender = 'F'
            },
           };
            string result = "";

            teachers = teachers.OrderBy(x => x.age).ToList();

            teachers.ForEach(x =>
            {
                result = result + $"School {x.age} \n";
            });

            return Ok(result);
        }
        [HttpGet("govsteacher/desc")]
        public IActionResult GetTeacherOrderByAgeDesc()
        {
            List<Teacher> teachers = new List<Teacher>()
           {
            new Teacher()
                {
                Id = 1,
                firstName = "Ivana",
                middleName = "Wilawil",
                lastName = "Alawi",
                section = 1,
                age = 29,
                gender = 'F'
                 },
            new Teacher()
            {
                Id = 2,
                firstName = "Mark",
                middleName = "Martines",
                lastName = "Nasol",
                section = 2,
                age = 30,
                gender = 'M'
            },
            new Teacher()
            {
                Id = 3,
                firstName = "Darius",
                middleName = "Fortes",
                lastName = "Trance",
                section = 3,
                age = 28,
                gender = 'M'
            },
            new Teacher()
            {
                Id = 4,
                firstName = "Jessebeth",
                middleName = "Lecciones",
                lastName = "Aduana",
                section = 4,
                age = 40,
                gender = 'F'
            },
           };
            string result = "";

            teachers = teachers.OrderByDescending(x => x.age).ToList();

            teachers.ForEach(x =>
            {
                result = result + $"School {x.age} \n";
            });

            return Ok(result);
        }
    }
}
