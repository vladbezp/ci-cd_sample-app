using WebApp.Infrastructure.Services;

namespace WebApp.Tests.Services
{
    public class WeatherForecastServiceTests
    {
        [Fact]
        public void GetForecasts_ReturnsCorrectNumberOfForecasts()
        {
            // Arrange
            var service = new WeatherForecastService();

            // Act
            var result = service.GetForecasts();

            // Assert
            Assert.Equal(5, result.Count());
        }
    }
}