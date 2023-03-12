using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebAPI
{
    [ApiController]
    [Route("[controller]")]
    public class DataStructureController : ControllerBase
    {
        private readonly ILogger<DataStructureController> _logger;

        public DataStructureController(ILogger<DataStructureController> logger)
        {
            _logger = logger;
        }

        [HttpGet("stack/number")]
        public IActionResult ExampleOFStack()
        {
            Stack<int> numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            numbers.Push(5);

            foreach (var item in numbers) ;
            return Ok(numbers);
        }

        [HttpGet("list")]
        public IActionResult GetList()
        {
            var lists = new List<string>();
            lists.Add("new York");
            lists.Add("London");
            lists.Add("Mumbai");
            lists.Add("Chicago");
            string result = "";
            foreach (var list in lists)
            {
                result = result + $"{list} \n";
            }
            return Ok(result);
        }
    }
}
