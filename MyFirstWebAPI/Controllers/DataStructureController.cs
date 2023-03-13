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

            string result = "";

            foreach (var item in numbers)
            {
                result = result + $"{item} \n";
            }
            return Ok(result);
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


        [HttpGet("queue/number")]
        public IActionResult ExampleOfQueue()
        {
            Queue<int> number = new Queue<int>();
            number.Enqueue(1);
            number.Enqueue(2);
            number.Enqueue(3);
            number.Enqueue(4);
            number.Enqueue(5);

            string result = "";

            foreach (var id in number)
            {
                result = result + $"{id} \n";
            }
            return Ok(result);
        }
        [HttpGet("dictionary")]
        public IActionResult ExampleOfDictionary()
        {
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");
            string result = "";

            foreach (KeyValuePair<int, string> kvp in numberNames)
            {
                result = result + $"Key: {kvp.Key}, Value: {kvp.Value} \n"; 
            }
            return Ok(result);
        }
        [HttpGet("helloworld")]

        public IActionResult HelloWorld()
        {
            return Ok("HelloWorld Anton");
        }

    }
}
