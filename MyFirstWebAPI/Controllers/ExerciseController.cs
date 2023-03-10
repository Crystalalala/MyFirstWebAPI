using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MyFirstWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExerciseController : ControllerBase
    {

        private readonly ILogger<ExerciseController> _logger;
        private int age;
        private int secondresult;
        private int firstresult;
        private bool greaterThan;
        private bool lessthan;
        private bool equalto;
        private bool notequal;
        private bool greaterthanorequalto;
        private bool lessthanorequalto;
        private object firstNumber;
        private object secondNumber;
        private int x;
        private int temperature;
        private int first;
        private int second;
        private int choice;

        public ExerciseController(ILogger<ExerciseController> logger)
        {
            _logger = logger;
        }

        [HttpGet("helloworld")]
        public IActionResult HelloWorld([FromQuery] int number)
        {
          return Ok($"Hello World");
        }

        [HttpGet("helloworld/crystal")]
        public IActionResult HelloWorldCrystal([FromQuery] int number)
        {
          return Ok($"Hello World Crystal");
        }

        [HttpGet("even/odd/identifier")]
        public IActionResult CheckNumberIfEvenOrOdd([FromQuery] int number)
        {
            int x = number % 2;

            if (x == 0)
            {
                return Ok($"{number} in an even integer");
            }
            else
            {
                return Ok($"{number} is an odd integers");
            }
        }

        [HttpGet("leaf/year/identifier")]
        public IActionResult CheckIfLeafYear([FromQuery] int number)
        {

            int year = number % 4;

            if (year == 0)
            {
                return Ok($"{number} is a leafyear");
            }
            else
            {
                return Ok($"{number} is not a leafyear");
            }

        }
        [HttpGet("possitive/negative/number/identifier")]
        public IActionResult CheckIfPossitiveNegativeIdentifier([FromQuery] int number)
        {

            bool possitive = number > 0;

            if (possitive)
            {
                return Ok($"{number} is possitive number");
            }
            else
            {

            }
            return Ok($"{number} is negative number");
        }

        [HttpGet("voter/age/eligible/identifier")]
        public IActionResult CheckIfVotersAgeIsEligibleIdentifier([FromQuery] int age)
        {
            string result = "";
            bool eligible = age > 18;

            if (eligible)
            {
                result = ("Congratulation! You are eligible for casting your vote");
            }
            else
            {
                result = ("I\'m sorry you are not eligible for casting a vote");
            }
            return Ok(result);

        }
        [HttpGet("decrement/increment/identifier")]
        public IActionResult CheckIfDecrementOrIncrement([FromQuery] int number)
        {
            int result = 0;
            return Ok("Moving Forward using Increment");
            for (int i = 0; i <= 10; i++)
            {
                result = (i);
            }

            return Ok("Moving Backward using Decrement");
            for (int i = 10; i >= 0; i--)
            {
               result = (i);
            }
            return Ok(result);
        }
        [HttpGet("comparison/accurate")]
        public IActionResult CheckIfComparisonIsAccurate([FromQuery] int number)
        {
            int x = 2;
            int y = 1;


            var greaterThan = x > y;
            var lessthan = x < y;
            var equalto = x == y;
            var notequal = x != y;
            var greaterthanorequalto = x >= y;
            var lessthanorequalto = x <= y;

            if (greaterThan)
            {
                return Ok("Greater than");
            }
            if (lessthan)
            {
                return Ok("Less than");
            }
            if (equalto)
            {
                return Ok("Equal to");
            }
            if (notequal)
            {
                return Ok("Not equal to");
            }
            if (greaterthanorequalto)
            {
                return Ok("Greater than or equal to");
            }
            if (lessthanorequalto)
            {
                return Ok("Less than or not equal to");
            }

            return Ok();
        }
        [HttpGet("comparison/integers")]
        public IActionResult CheckIfCorrectComparison([FromQuery] int number)
        {
            string result = ("");

            if (firstresult < 0 && secondresult > 0)
            {
                result = ("true");
            }
            else if (firstresult > 0 && secondresult < 0)
            {
                result = ("true");
            }
            else
            {
                result = ("false");
            }
            return Ok(result);
        }
        //[HttpGet("decrement/increment/identifier")]
        //public IActionResult CheckIfDecrementOrIncrement([FromQuery] int firstNumber, [FromQuery] int secondNumber)
        //{
        //    string result = "";
        //    if (firstNumber == secondNumber)
        //    {
        //        result = ($"{firstNumber} and {secondNumber} are Equal");
        //    }
        //    else
        //    {
        //       result = ($"{firstNumber} and {secondNumber} are not Equal");
        //    }
        //    return Ok(result);

        //}
        [HttpGet("odd/even/identifier")]
        public IActionResult CheckIfOddOrEven([FromQuery] int number)
        {

            if (x == 0)
            {
                return Ok($"{number} in an even integer");
            }

            else
            {
                return Ok($"{number} is an odd integers");
            }


        }
        [HttpGet("coordinates/identifier")]
        public IActionResult CheckIfSameCoordinates([FromQuery] int number)
        {
            int firstCoordinate = 0, secondCoordinate = 0;


            bool quadrant1 = firstCoordinate > 0 && secondCoordinate > 0;
            bool quadrant2 = firstCoordinate < 0 && secondCoordinate > 0;
            bool quadrant3 = firstCoordinate < 0 && secondCoordinate < 0;
            bool quadrant4 = firstCoordinate > 0 && secondCoordinate < 0;

            if (firstCoordinate > 0 && secondCoordinate > 0)
            {
                return Ok($"The coordinate point ({firstCoordinate},{secondCoordinate}) lies in the First quadrant.");
            }
            else if (quadrant2)
            {
                return Ok($"The coordinate point ({firstCoordinate},{secondCoordinate}) lies in the Second quadrant.");
            }
            else if (quadrant3)
            {
                return Ok($"The coordinate point ({firstCoordinate},{secondCoordinate}) lies in the Third quadrant.");
            }
            else if (quadrant4)
            {
                return Ok($"The coordinate point ({firstCoordinate},{secondCoordinate}) lies in the Fourth quadrant.");
            }
            else
            {
                return Ok($"The coordinate point does not exist in quadrant.");
            }

        }
        [HttpGet("temperature/identifier")]
        public IActionResult CheckIfTemperatureIsCorrect([FromQuery] int number)
        {

            if (temperature < 0)
            {
                return Ok($"{temperature} is Freezing weather");
            }
            else if (temperature >= 0 && temperature <= 10)
            {
                return Ok($"{temperature} is Very Cold weather");
            }
            else if (temperature >= 10 && temperature <= 20)
            {
                return Ok($"{temperature} is Cold weather");
            }
            else if (temperature >= 20 && temperature <= 30)
            {
                return Ok($"{temperature} is Normal in Temp");
            }
            else if (temperature >= 30 && temperature <= 40)
            {
                return Ok($"{temperature} its Hot");
            }
            else
            {
                return Ok("the temperature is very hot");
            }

        }
        [HttpGet("forward/increment/backward/decrement")]
        public IActionResult CheckIfIncrementOrDecrement([FromQuery] int number)
        {


            for (int i = 0; i <= 10; i++)
            {
                return Ok(i);
            }

            for (int i = 10; i >= 0; i--)
            {
                return Ok(i);
            }

            return Ok();
        }
        [HttpGet("month/number/identifier")]
        public IActionResult CheckIfCorrectMonthNUmber([FromQuery] int number)
        {

            if (number == 1)
            {
                return Ok("January");
            }
            else if (number == 2)
            {
                return Ok("February");
            }
            else if (number == 3)
            {
                return Ok("March");
            }
            else if (number == 4)
            {
                return Ok("April");
            }
            else if (number == 5)
            {
                return Ok("May");
            }
            else if (number == 6)
            {
                return Ok("June");
            }
            else if (number == 7)
            {
                return Ok("July");
            }
            else if (number == 8)
            {
                return Ok("August");
            }
            else if (number == 9)
            {
                return Ok("September");
            }
            else if (number == 10)
            {
                return Ok("October");
            }
            else if (number == 11)
            {
                return Ok("November");
            }
            else if (number == 12)
            {
                return Ok("December");
            }
            else
            {
                return Ok("Unrecognize month number");
            }

        }
        [HttpGet("arithmetic/formula")]
        public IActionResult CheckIfCorrectArithmeticFormula([FromQuery] int number)
        {

            int addition = first + second;
            int subtraction = first - second;
            int multiplication = first * second;
            int division = first / second;

            if (choice == 1)
            {
                return Ok($"The addition of {first} & {second} is: {addition} ");
            }
            else if (choice == 2)
            {
                return Ok($"The subtraction of {first} & {second} is: {subtraction} ");
            }
            else if (choice == 3)
            {
                return Ok($"The multiplication of {first} & {second} is: {multiplication} ");
            }
            else if (choice == 4)
            {
                return Ok($"The division of {first} & {second} is: {division}");
            }
            else
            {
                return Ok();
            }


        }

        [HttpGet("addition/formula")]
        public IActionResult CheckIfCorrectAdditionFormula([FromQuery] int number)
        {
            int result = 0;
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
                result = (i);
            }
            return Ok(result);
        }
        [HttpGet("sum/natural/number/formula")]
        public IActionResult CheckIfSumNaturalNUmber([FromQuery] int number)
        {
            int result = 0;
            int add = 0, add2 = 0;

            for (int i = 1; i <= add; i++)
            {
                 result = (i);
                add2 = add2 + i;
            }
            return Ok($"The sum of natural number up to {add} terms:{add2}");

        }
        [HttpGet("multiplication/formula")]
        public IActionResult CheckIfCorrectMultiplicationFormula([FromQuery] int number)
        {
            string result = "";
            int m = 0, x = 0;

            for (int i = 1; i <= 10; i++)
            {
                x = m * i;
                result = ($"{m} x {i} = {x}");
            }
            return Ok(result);
        }

        [HttpGet("increment/data")]
        public IActionResult CheckIfDataIsIncrementing([FromQuery] int number)
        {
            string result = "";
            for (int i = 1; i <= 4; i++)
            {
                if (i == 1)
                {
                    result = result + ($"{i} \n");
                }
                if (i == 2)
                {
                    result = result + ($"{i}{i} \n");
                }
                if (i == 3)
                {
                    result = result + ($"{i}{i}{i} \n");
                }
                if (i == 4)
                {
                    result = result + ($"{i}{i}{i}{i} \n");
                }

            }
            return Ok(result);
        }
        //[HttpGet("cube/formula")]
        //public IActionResult CheckIfCorrectCubeFormula([FromQuery] int number)
        //{
        //    int b = 0;

        //    for (int i = 1; i <= 5; i++)
        //    {
        //        b = i * i * i;
        //        return Ok ($"Number is: {i} and cube of the {i} is: {b}");
        //    }
        //    return Ok ();
        //}
        //[HttpGet("integers/formula")]
        //public IActionResult CheckIfCorrectFormula([FromQuery] int number)
        //{
        //    int x = 0, y = 0;
        //    int n = 0;

        //    for (int i = 1; i <= n; i++)
        //    {
        //        if (i == 1)
        //        {
        //            x = 0;
        //            return Ok ($"{x} ");
        //        }
        //        else if (i == 2)
        //        {
        //            y = 1;
        //           return Ok ($"{y} ");
        //        }
        //        else
        //        {
        //            int temp = y;
        //            y = y + x;
        //            x = temp;
        //           return Ok ($"{y} ");
        //        }

        //    }
        //    return Ok();
        //}
        //[HttpGet("sum/of/elements")]
        //public IActionResult CheckIfCorrectSumOfElements ([FromQuery] int number)
        //{

        //    int[] elements = { 2, 5, 8 };
        //    int sum = 0;

        //    for (int i = 0; i <= elements.Length - 1; i++)
        //    {
        //        int total = elements[i];
        //        sum = sum + total;

        //        return Ok (total);

        //    }
        //    return Ok (sum);

        //}
    }
}
    




