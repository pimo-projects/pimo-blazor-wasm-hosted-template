using Microsoft.AspNetCore.Mvc;
using PimoBlazorWasmHostedTemplate.Shared;

namespace PimoBlazorWasmHostedTemplate.Server.Controllers;

[ApiController]
public sealed class WeatherForecastController
{
    [HttpGet("/api/weather-forecasts")]
    public async Task<ActionResult<WeatherForecast[]>> GetWeatherForecasts()
    {
        WeatherForecast[] something =
        [
            new()
            {
                Date = new DateOnly(2022, 01, 06),
                TemperatureC = 1,
                Summary = "Freezing"
            },
            new()
            {
                Date = new DateOnly(2022, 01, 07),
                TemperatureC = 14,
                Summary = "Bracing"
            },
            new()
            {
                Date = new DateOnly(2022, 01, 08),
                TemperatureC = -13,
                Summary = "Freezing"
            },
            new()
            {
                Date = new DateOnly(2022, 01, 09),
                TemperatureC = -16,
                Summary = "Balmy"
            },
            new()
            {
                Date = new DateOnly(2022, 01, 10),
                TemperatureC = -2,
                Summary = "Chilly"
            }
        ];

        await Task.CompletedTask;
        return something;
    }
}
