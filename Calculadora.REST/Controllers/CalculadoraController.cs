using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Calculadora.REST.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {

        private readonly ILogger<CalculadoraController> _logger;

        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if(isNumeric(firstNumber) && isNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Entrada(s) inválida(s)");
        }

        [HttpGet("subtract/{firstNumber}/{secondNumber}")]
        public IActionResult Subtract(string firstNumber, string secondNumber)
        {
            if (isNumeric(firstNumber) && isNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Entrada(s) inválida(s)");
        }

        [HttpGet("multiply/{firstNumber}/{secondNumber}")]
        public IActionResult Multiply(string firstNumber, string secondNumber)
        {
            if (isNumeric(firstNumber) && isNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Entrada(s) inválida(s)");
        }

        [HttpGet("divide/{firstNumber}/{secondNumber}")]
        public IActionResult Divide(string firstNumber, string secondNumber)
        {
            if (isNumeric(firstNumber) && isNumeric(secondNumber) && ConvertToDecimal(secondNumber) != 0)
            {
                var sum = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Entrada(s) inválida(s)");
        }

        [HttpGet("mean/{firstNumber}/{secondNumber}")]
        public IActionResult GetMean(string firstNumber, string secondNumber)
        {
            if (isNumeric(firstNumber) && isNumeric(secondNumber))
            {
                var mean = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber))/2;
                return Ok(mean.ToString());
            }
            return BadRequest("Entrada(s) inválida(s)");
        }

        [HttpGet("square-root/{number}")]
        public IActionResult GetSquareRoot(string number)
        {
            if (isNumeric(number))
            {
                var squareRoot = Math.Sqrt((double) ConvertToDecimal(number));
                return Ok(squareRoot.ToString());
            }
            return BadRequest("Entrada inválida");
        }

        private decimal ConvertToDecimal(string stringNumber)
        {
            decimal decimalNumber;
            if(Decimal.TryParse(stringNumber,out decimalNumber))
            {
                return decimalNumber;
            }
            return 0;
        }

        private bool isNumeric(string stringNumber)
        {
            double number;
            bool isNumber = double.TryParse(stringNumber,NumberStyles.Any, NumberFormatInfo.InvariantInfo, out number);

            return isNumber;
        }
    }
}