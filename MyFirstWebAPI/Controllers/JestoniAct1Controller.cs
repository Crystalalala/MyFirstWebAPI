using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyFirstWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JestoniAct1Controller : ControllerBase
    {
        private readonly ILogger<JestoniAct1Controller> _logger;
        private object d;
        private stringBuilder stringBuilder;

        public JestoniAct1Controller(ILogger<JestoniAct1Controller> logger)
        {
            _logger = logger;
        }

        [HttpGet("activity/upper")]
        public IActionResult ConvertTheToUpper([FromQuery] string Sentence)
        {
            string result = Sentence.Replace("the", "THE");

            return Ok(result);
        }

        [HttpGet("remove/space")]
        public IActionResult RemoveSpaceAndSpecialChar([FromQuery] string words)
        {
            words = words.Replace(" ", "");
            string result = Regex.Replace(words, @"[^0-9a-zA-Z]+", "");

            return Ok(result);

        }
        [HttpGet("lower/upper/words")]
        public IActionResult GetLowerAndUpperCase([FromQuery] String words)
        {
            string lower = words.ToLower();
            string upper = words.ToUpper();
            string result = "";
            result = result + ($"{upper}\n{lower}\n");

            return Ok(result);
        }

        [HttpGet("validate/phonenumber")]
        public IActionResult CheckThePhoneNumberIsValid([FromQuery] string phoneNumber)
        {
            bool isValid = Regex.IsMatch(phoneNumber, @"^(09|\+639)\d{9}$");

            if (isValid)
            {
                return Ok($"{phoneNumber} is valid");
            }
            else
            {
                return Ok($"{phoneNumber} is not valid");
            }
        }
        [HttpGet("keyword/sentence")]
        public IActionResult CheckTheKeyWordInSentence([FromQuery] string words)
        {
            if (words.Any(x => words.Contains("the")))
            {
                return Ok($"{words} have \"the\" keywords");
            }
            else
            {
                return Ok($"{words} don`t have \"the\" keywords");
            }
        }
        [HttpGet("string/format/example")]
        public IActionResult ExampleStringFormat([FromQuery] string name, [FromQuery]int age)
        {
            string formattedString = string.Format($"Hi! My name is {name} and I am {age} years old.");

            return Ok(formattedString);
        }
        [HttpGet("string/builder/example")]
        public IActionResult ExampleStringBuilder([FromQuery]string txt)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(txt );
            builder.AppendLine("World!");
            builder.AppendLine("Hello Anton");

            return Ok(builder.ToString());
            
        }
        [HttpGet("endwith\".\"")]
        public IActionResult ExampleOfEndWithDot([FromQuery]string words)
        {
            if (words.EndsWith(".") == true)
            {
                return Ok($"\"{words}\" is end with \".\"");
            }
            else
            {
                return Ok($"\"{words}\" doesn't end with\".\"");
            }
        }
        [HttpGet("start/capital/letter")]
        public IActionResult CheckifFirstLetterisCapital([FromQuery]string text)
        {
            if (text.Length > 0 && char.IsUpper(text[0]))
            {
                return Ok($"\"{text}\" starts with a capital letter.");
            }
            else
            {
                return Ok($"\"{text}\" doesn't start with a capital letter.");
            }

        }
    }
}
