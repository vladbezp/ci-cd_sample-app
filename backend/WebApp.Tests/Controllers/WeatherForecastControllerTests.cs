using Microsoft.Extensions.Logging;
using Moq;
using WebApp.API.Controllers;
using WebApp.Core.DTOs;
using WebApp.Core.Interfaces;

namespace WebApp.Tests.Controllers
{
    public class WeatherForecastControllerTests
    {
        private readonly Mock<ILogger<WeatherForecastController>> _loggerMock;
        private readonly Mock<IWeatherForecastService> _weatherForecastServiceMock;
        private readonly WeatherForecastController _controller;

        public WeatherForecastControllerTests()
        {
            _loggerMock = new Mock<ILogger<WeatherForecastController>>();
            _weatherForecastServiceMock = new Mock<IWeatherForecastService>();
            _controller = new WeatherForecastController(_loggerMock.Object, _weatherForecastServiceMock.Object);
        }

        [Fact]
        public void Get_ReturnsForecasts()
        {
            // Arrange
            var mockForecasts = new List<WeatherForecastDto>
            {
                new WeatherForecastDto { Date = DateOnly.FromDateTime(System.DateTime.Now), TemperatureC = 25, Summary = "Hot" },
                new WeatherForecastDto { Date = DateOnly.FromDateTime(System.DateTime.Now.AddDays(1)), TemperatureC = 15, Summary = "Cool" }
            };

            _weatherForecastServiceMock.Setup(s => s.GetForecasts()).Returns(mockForecasts);

            // Act
            var result = _controller.Get();

            // Assert
            var actionResult = Assert.IsType<List<WeatherForecastDto>>(result);
            Assert.Equal(mockForecasts.Count, actionResult.Count);
            _weatherForecastServiceMock.Verify(s => s.GetForecasts(), Times.Once);
        }
    }
}
