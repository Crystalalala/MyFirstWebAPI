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
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }


        [HttpPost("student")]
        public IActionResult Addstudent([FromBody] Student student)
        {
            List<Student> students = new List<Student>();
            var firstStudent = new Student()
            {
                Id = 1,
                FirstName = "Bambie",
                MiddleName = "Lat",
                LastName = "Lomio",
                Section = 5,
                Grade = 1,
                Gender = 'F',
            };
            students.Add(firstStudent);
            students.Add(student);

            string result = "";
            students.ForEach(x =>
           {
               result = result + $"Student {x.FirstName} {x.MiddleName} {x.LastName} \n";
           });

            return Ok(result);
        }
        [HttpGet("student")]
        public IActionResult GetStudent([FromQuery] int Grade)
        {
            List<Student> students = new List<Student>() {
                new Student()
                {    Id = 1,
                     FirstName = "Bambie",
                    MiddleName = "Lat",
                    LastName = "Lomio",
                    Section = 5,
                    Grade = 1,
                    Gender = 'F',
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Apple",
                    MiddleName = "Ban",
                    LastName = "Tot",
                    Section = 5,
                    Grade = 1,
                    Gender = 'F',
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "Wanwan",
                    MiddleName = "Te",
                    LastName = "Nga",
                    Section = 1,
                    Grade = 2,
                    Gender = 'F',
                },
                new Student()
                {
                    Id = 1,
                    FirstName = "Pogi",
                    MiddleName = "Gal",
                    LastName = "Lis",
                    Section = 5,
                    Grade = 1,
                    Gender = 'M',
                },
                new Student()
                {
                    Id = 4,
                    FirstName = "Guin",
                    MiddleName = "Hams",
                    LastName = "Ter",
                    Section = 1,
                    Grade = 2,
                    Gender = 'F',
                },
                new Student()
                {
                    Id = 5,
                    FirstName = "Kopi",
                    MiddleName = "Ka",
                    LastName = "Gat",
                    Section = 1,
                    Grade = 1,
                    Gender = 'F',
                },
            };
            string result = "";

            students = students.Where(x => x.Grade == Grade).ToList();

            students.ForEach(x =>
            {
                result = result + $"Students {x.LastName} \n";
            });

            return Ok(result);

        }
        [HttpGet("student/one")]
        public IActionResult GetStudentOne([FromQuery] char Gender)
        {
            List<Student> students = new List<Student>() {
                new Student()
                {    Id = 1,
                     FirstName = "Bambie",
                    MiddleName = "Lat",
                    LastName = "Lomio",
                    Section = 5,
                    Grade = 1,
                    Gender = 'F',
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Apple",
                    MiddleName = "Ban",
                    LastName = "Tot",
                    Section = 5,
                    Grade = 1,
                    Gender = 'F',
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "Wanwan",
                    MiddleName = "Te",
                    LastName = "Nga",
                    Section = 1,
                    Grade = 2,
                    Gender = 'F',
                },
                new Student()
                {
                    Id = 1,
                    FirstName = "Pogi",
                    MiddleName = "Gal",
                    LastName = "Lis",
                    Section = 5,
                    Grade = 1,
                    Gender = 'M',
                },
                new Student()
                {
                    Id = 4,
                    FirstName = "Guin",
                    MiddleName = "Hams",
                    LastName = "Ter",
                    Section = 1,
                    Grade = 2,
                    Gender = 'F',
                },
                new Student()
                {
                    Id = 5,
                    FirstName = "Kopi",
                    MiddleName = "Ka",
                    LastName = "Gat",
                    Section = 1,
                    Grade = 1,
                    Gender = 'F',
                },

            };
            Student student = students.Where(x => x.Gender == Gender).LastOrDefault();

            return Ok($"Student {student.FirstName} \n");

        }
        [HttpGet("student/sort/asc")]
        public IActionResult GetStudentOrderByGrade()
        {
            List<Student> students = new List<Student>()
            {
                new Student()
                {    Id = 1,
                     FirstName = "Bambie",
                    MiddleName = "Lat",
                    LastName = "Lomio",
                    Section = 5,
                    Grade = 1,
                    Gender = 'F',
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Apple",
                    MiddleName = "Ban",
                    LastName = "Tot",
                    Section = 5,
                    Grade = 1,
                    Gender = 'F',
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "Wanwan",
                    MiddleName = "Te",
                    LastName = "Nga",
                    Section = 1,
                    Grade = 2,
                    Gender = 'F',
                },
                new Student()
                {
                    Id = 1,
                    FirstName = "Pogi",
                    MiddleName = "Gal",
                    LastName = "Lis",
                    Section = 5,
                    Grade = 1,
                    Gender = 'M',
                },
                new Student()
                {
                    Id = 4,
                    FirstName = "Guin",
                    MiddleName = "Hams",
                    LastName = "Ter",
                    Section = 1,
                    Grade = 2,
                    Gender = 'F',
                },
                new Student()
                {
                    Id = 5,
                    FirstName = "Kopi",
                    MiddleName = "Ka",
                    LastName = "Gat",
                    Section = 1,
                    Grade = 1,
                    Gender = 'F',
                },

            };
            string result = "";

            students = students.OrderBy(x => x.Grade).ToList();

            students.ForEach(x =>
            {
                result = result + $"Student {x.LastName} \n";
            });

            return Ok(result);
        }
        [HttpGet("student/sort/desc")]
        public IActionResult GetStudentOrderByGradeDesc()
        {
            List<Student> students = new List<Student>()
        {
                new Student()
                {    Id = 1,
                     FirstName = "Bambie",
                    MiddleName = "Lat",
                    LastName = "Lomio",
                    Section = 5,
                    Grade = 1,
                    Gender = 'F',
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Apple",
                    MiddleName = "Ban",
                    LastName = "Tot",
                    Section = 5,
                    Grade = 1,
                    Gender = 'F',
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "Wanwan",
                    MiddleName = "Te",
                    LastName = "Nga",
                    Section = 1,
                    Grade = 2,
                    Gender = 'F',
                },
                new Student()
                {
                    Id = 1,
                    FirstName = "Pogi",
                    MiddleName = "Gal",
                    LastName = "Lis",
                    Section = 5,
                    Grade = 1,
                    Gender = 'M',
                },
                new Student()
                {
                    Id = 4,
                    FirstName = "Guin",
                    MiddleName = "Hams",
                    LastName = "Ter",
                    Section = 1,
                    Grade = 2,
                    Gender = 'F',
                },
                new Student()
                {
                    Id = 5,
                    FirstName = "Kopi",
                    MiddleName = "Ka",
                    LastName = "Gat",
                    Section = 1,
                    Grade = 1,
                    Gender = 'F',
                },

            };
            string result = "";

            students = students.OrderByDescending(x => x.Grade).ToList();

            students.ForEach(x =>
            {
                result = result + $"Student {x.FirstName} \n";
            });

            return Ok(result);

        }



    }

}