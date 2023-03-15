using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebAPI.Models
{
    public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public int BuildingNo { get; set; }
        public bool IsPrivate { get; set; }
    }
}
