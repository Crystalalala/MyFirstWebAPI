using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MyFirstWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CjAct1 : ControllerBase
    {
        private readonly ILogger<CjAct1> _logger;

        public CjAct1(ILogger<CjAct1> logger)
        {
            _logger = logger;
        }

        [HttpGet("small/to/capital")]
        public IActionResult ExampleOfStingManipulation([FromQuery] string originalString)
        {
            string replacedString = originalString.Replace("the", "THE");

            return Ok(replacedString);
        }

        [HttpGet("remove/space/and/special/characters")]
        public IActionResult ExampleOfStingManipulation2([FromQuery] string originalString)
        {
            string removedString = originalString.Replace(" ", "").Replace("\t", "");
            removedString = Regex.Replace(removedString, "[^a-zA-Z0-9]+", "");

            return Ok(removedString);
        }

        [HttpGet("uppercase/lowercase")]
        public IActionResult ExampleOfStingManipulation3([FromQuery] string originalString)
        {

            // Convert to lowercase
            string lowercaseString = originalString.ToLower();

            // Convert to uppercase
            string uppercaseString = originalString.ToUpper();

            string result = "";

            result = result + $"{uppercaseString} \n{lowercaseString} \n";

            return Ok(result);

        }
        [HttpGet("phone/number")]
        public IActionResult ExampleOfStingManipulation4([FromQuery] string phoneNumber)
        {

            bool isValid = Regex.IsMatch(phoneNumber, @"^(09|\+639)\d{9}$");

            if (isValid)
            {
                return Ok("Phone number is valid.");
            }
            else
            {
                return Ok("Phone number is not valid.");
            }

        }
        [HttpGet("the")]
        public IActionResult ExampleOfStingManipulation5([FromQuery] string originalString)
        {
            if (originalString.Contains("the") == true)
            {
                return Ok("\"the\" Word found!" );
            }
            else
            {
                return Ok("\"the\" Word not found!");
            }
                
        }
        [HttpGet("string/format")]
        public IActionResult ExampleOfStingFormat6()
        {
            string firstName = "Crystal";
            string lastName = "Lomio";
            int age = 23;

            string message = string.Format("My name is {0} {1} and I am {2} years old.", firstName, lastName, age);

            return Ok (message);
        }

        [HttpGet("string/builder")]
        public IActionResult ExampleOfStingFormat7()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Hello, ");
            sb.Append("world!");
            sb.AppendLine(" How are you today?");
            sb.AppendFormat("The time is {0:T}.", DateTime.Now);
           
            // Convert the StringBuilder to a string and output it
            return Ok (sb.ToString());
            
        }

        [HttpGet("\".\"")]
        public IActionResult ExampleOfStingManipulation8([FromQuery] string originalString)
        {
            if (originalString.EndsWith(".") == true)
            {
                return Ok("is end with \".\"");
            }
            else
            {
                return Ok("doesn't end with\".\"");
            }

        }

        [HttpGet("capital/letters")]
        public IActionResult ExampleOfStingManipulation9([FromQuery] string sentence)
        {

            if (sentence.Length > 0 && char.IsUpper(sentence[0]))
            {
                return Ok ("The sentence starts with a capital letter.");
            }
            else
            {
                return Ok ("The sentence doesn't start with a capital letter.");
            }

        }



    }
}
