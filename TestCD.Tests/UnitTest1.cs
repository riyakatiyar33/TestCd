using Microsoft.AspNetCore.Mvc;
using TestCD.Controllers;
using Xunit;

namespace TestCD.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void AddNumbers_WhenPositiveNumbersAreGiven_ReturnsCorrectSum()
        {
            WeatherForecastController controller = new WeatherForecastController();

            IActionResult actionResult = controller.AddNumbers(10, 20);

            OkObjectResult okResult = Assert.IsType<OkObjectResult>(actionResult);
            int result = Assert.IsType<int>(okResult.Value);

            Assert.Equal(30, result);
        }

        [Fact]
        public void AddNumbers_WhenNegtaiveNumberAregiven_ReturnCorrectSum()
        {
            WeatherForecastController controller = new WeatherForecastController();
            IActionResult actionResult = controller.AddNumbers(-10, 30);
            OkObjectResult okResult = Assert.IsType<OkObjectResult>(actionResult);
            int result = Assert.IsType<int>(okResult.Value);
            Assert.Equal(20, result);
        }
    }
}