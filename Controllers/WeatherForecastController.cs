using Microsoft.AspNetCore.Mvc;

namespace TestCD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("add")]
        public IActionResult AddNumbers(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;

            return Ok(result);
        }
        // This method subtracts two numbers and returns the result as an HTTP response.
        [HttpGet("subtract")]
        public IActionResult SubtractNumbers(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;

            return Ok(result);
        }
    }
}