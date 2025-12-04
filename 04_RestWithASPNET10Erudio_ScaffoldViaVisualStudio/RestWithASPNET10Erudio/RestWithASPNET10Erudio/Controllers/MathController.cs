using Microsoft.AspNetCore.Mvc;
using RestWithASPNET10Erudio.Model.Utils;
using RestWithASPNET10Erudio.Services;

namespace RestWithASPNET10Erudio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        private readonly MathService _service;
        public MathController(MathService service)
        {
            _service = service;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var sum = _service.Sum(
                NumberHelper.ConvertToDecimal(firstNumber),
                NumberHelper.ConvertToDecimal(secondNumber));
                return Ok(sum);
            }
            return BadRequest("Invalid Input!");
        }

        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult Sub(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var subtraction = _service.Subtraction(
                    NumberHelper.ConvertToDecimal(firstNumber), 
                    NumberHelper.ConvertToDecimal(secondNumber));
                return Ok(subtraction);
            }
            return BadRequest("Invalid Input!");
        }


        [HttpGet("mult/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var multiplication = _service.Multiplication(
                    NumberHelper.ConvertToDecimal(firstNumber),
                    NumberHelper.ConvertToDecimal(secondNumber));
                return Ok(multiplication);
            }
            return BadRequest("Invalid Input!");
        }

        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public IActionResult Division(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var division = _service.Division(
                    NumberHelper.ConvertToDecimal(firstNumber),
                    NumberHelper.ConvertToDecimal(secondNumber));
                return Ok(division);
            }
            return BadRequest("Invalid Input!");
        }

        [HttpGet("med/{firstNumber}/{secondNumber}")]
        public IActionResult Media(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var med = _service.Media(
                    NumberHelper.ConvertToDecimal(firstNumber),
                    NumberHelper.ConvertToDecimal(secondNumber));
                return Ok(med);
            }
            return BadRequest("Invalid Input!");
        }

        [HttpGet("raiz/{firstNumber}")]
        public IActionResult Raiz(string firstNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber))
            {
                var raiz = _service.SquareRoot(Double.Parse(firstNumber));
                return Ok(raiz);
            }
            return BadRequest("Invalid Input!");
        }
        
    }
}
