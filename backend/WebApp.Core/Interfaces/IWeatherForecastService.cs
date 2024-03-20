using WebApp.Core.DTOs;

namespace WebApp.Core.Interfaces
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecastDto> GetForecasts();
    }
}
