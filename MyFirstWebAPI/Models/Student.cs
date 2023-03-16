using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Section { get; set; }
        public int Grade {get; set; }
        public char Gender { get; set; }
        public object Name { get; internal set; }
    }
}
