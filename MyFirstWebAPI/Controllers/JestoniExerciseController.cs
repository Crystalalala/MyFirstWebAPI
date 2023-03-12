using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JestoniExerciseController : ControllerBase
    {
        private readonly ILogger<JestoniExerciseController> _logger;

        public JestoniExerciseController(ILogger<JestoniExerciseController> logger)
        {
            _logger = logger;
        }
        [HttpGet("exchange/number")]
        public IActionResult ExchangeTheNumber([FromQuery] int firstNumber, [FromQuery] int secondNumber)
        {

            var x = firstNumber;
            firstNumber = secondNumber;
            secondNumber = x;
            string output = "First Number: " + firstNumber + " ";
            output = output + "Second Number: " + secondNumber + " ";
            return Ok(output);
        }

        [HttpGet("result/number")]
        public IActionResult ResultOfThreeNumber([FromQuery] int firstNumber, [FromQuery] int secondNumber, [FromQuery] int thirdNumber)
        {
            int result = (firstNumber * secondNumber * thirdNumber);
            string output = ($"OutPut: {firstNumber} x {secondNumber} x {thirdNumber} = {result}");
            return Ok(output);
        }
        [HttpGet("outcome/number")]
        public IActionResult MeanOfFourNumber([FromQuery] int firstNumber, [FromQuery] int secondNumber, [FromQuery] int thirdNumber, [FromQuery] int fourthNumber)
        {
            int result = (firstNumber + secondNumber + thirdNumber + fourthNumber);
            int ave = result / 4;
            string output = ($"The average of : {firstNumber} , {secondNumber} , {thirdNumber} , {fourthNumber} is {ave}");
            return Ok(output);
        }
        [HttpGet("line/number")]
        public IActionResult SeriesInFourTimes([FromQuery] int number)
        {
            string result = "";
            for (int i = 0; i <= 3; i++)
            {
                int x = (i % 2);

                if (x == 0)
                {
                    result = result + ($"{number} {number} {number} {number} \n");
                }
                else
                {
                    result = result + ($"{number}{number}{number}{number} \n");
                }

            }
            return Ok(result);
        }
        [HttpGet("integer/number")]
        public IActionResult ResultOfInteger([FromQuery] int firstInteger, [FromQuery] int secondInteger)
        {
            if (firstInteger < 0 && secondInteger > 0)
            {
                return Ok("True");

            }
            else
                return Ok("false");
        }
        [HttpGet("sum/product/number")]
        public IActionResult CheckTheResultOfANumber([FromQuery] int firstInteger, [FromQuery] int secondInteger)
        {
            int x = firstInteger + secondInteger;
            int result = x * 3;

            if (firstInteger == secondInteger)
            {
                return Ok($"{result}");

            }
            else

            {
                return Ok($"{x}");
            }
        }
        [HttpGet("reversal/word")]
        public IActionResult ReverseTheSentence([FromQuery] string words)
        {
            string sentence = $"{words} \n";
            string word = "";
            var reverse = words.Split('*');
            for (int i = reverse.Length - 1; i >= 0; i--)
            {
                string rev = reverse[i];
                word = word + ' ' + rev;
            }
            sentence = sentence + ($"Word Result: {word} \n");
            return Ok(sentence);
        }
        [HttpGet("true/false/integer")]
        public IActionResult CheckIfTrueOrFalse([FromQuery] int first)
        {
            string Traulse = "";
            int result = first % 3;
            int x = first % 7;

            if (result == 0 || x == 0)
            {
                Traulse = ("True");
            }
            else
            {
                Traulse = ("false");
            }
            return Ok(Traulse);
        }
        [HttpGet("result/integer")]
        public IActionResult CheckTheResultOfInteger([FromQuery] int firstNumber, [FromQuery] int secondNumber)
        {
            string traulse = "";
            int x = firstNumber;
            int y = secondNumber;

            if (x < 100 && y > 200)
            {
                traulse = ("TRUE");
            }

            else
            {
                traulse = ("FALSE");
            }
            return Ok(traulse);
        }
        [HttpGet("odd/number")]
        public IActionResult PrintTheOddNumbers()
        {
            string value = "";
            for (int i = 1; i <= 99; i++)
            {
                int result = i % 2;
                bool even = i % 2 == 0;
                bool odd = !(i % 2 == 0);

                if (!(i % 2 == 0))
                {
                    value = value + $"{i} \n";
                }
            }
            return Ok(value);
        }
        [HttpGet("long/word")]
        public IActionResult PrintTheLongWord([FromQuery] string word, [FromQuery] string Txt)
        {
            var words = Txt.Split(' ');

            for (int i = 0; i <= words.Length - 1; i++)
            {
                Console.WriteLine($"{i}, {words[i]}  {words[i].Length} {word} ");
                int x = words[i].Length;
                if (word.Length < x)
                {
                    word = words[i];

                }
            }
            return Ok(word);
        }
    }
}
