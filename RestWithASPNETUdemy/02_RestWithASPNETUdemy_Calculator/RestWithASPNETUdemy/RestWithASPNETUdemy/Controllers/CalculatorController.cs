using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            var rng = new Random();
            {
                if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
                {
                    var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                    return Ok(sum.ToString());
                }
                return BadRequest();
            }
        }

        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(string firstNumber, string secondNumber)
        {
            var rng = new Random();
            {
                if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
                {
                    var subtraction = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                    return Ok(subtraction.ToString());
                }
                return BadRequest();
            }
        }

        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber)
        {
            var rng = new Random();
            {
                if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
                {
                    var multiplication = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                    return Ok(multiplication.ToString());
                }
                return BadRequest();
            }
        }

        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult Division(string firstNumber, string secondNumber)
        {
            var rng = new Random();
            {
                if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
                {
                    var division = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                    return Ok(division.ToString());
                }
                return BadRequest();
            }
        }

        [HttpGet("mean/{firstNumber}/{secondNumber}")]
        public IActionResult Mean(string firstNumber, string secondNumber)
        {
            var rng = new Random();
            {
                if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
                {
                    var mean = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber)) / 2;
                    return Ok(mean.ToString());
                }
                return BadRequest();
            }
        }

        [HttpGet("square-root/{firstNumber}/{secondNumber}")]
        public IActionResult SquareRoot(string firstNumber)
        {
            var rng = new Random();
            {
                if (IsNumeric(firstNumber))
                {
                    var SquareRoot = Math.Sqrt((double)ConvertToDecimal(firstNumber));
                    return Ok(SquareRoot.ToString());
                }
                return BadRequest();
            }
        }
        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(
                strNumber
                ,System.Globalization.NumberStyles.Any
                ,System.Globalization.NumberFormatInfo.InvariantInfo
                ,out number
            );
            return isNumber;
        }

        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if(decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

    }
}
