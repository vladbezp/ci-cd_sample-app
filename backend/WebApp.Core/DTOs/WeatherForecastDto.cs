﻿namespace WebApp.Core.DTOs
{
    public class WeatherForecastDto
    {
        public DateOnly Date { get; set; }
        public int TemperatureC { get; set; }
        public string? Summary { get; set; }
    }
}
