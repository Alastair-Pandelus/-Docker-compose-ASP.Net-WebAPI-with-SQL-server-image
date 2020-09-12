using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyDocker.Data;
using MyDocker.Domain;

namespace MyDocker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly WeatherForecastContext weatherForecastContext;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, WeatherForecastContext weatherForecastContext)
        {
            _logger = logger;
            this.weatherForecastContext = weatherForecastContext;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            /*weatherForecastContext.EnsureCreated();*/

            return weatherForecastContext.WeatherForecasts.ToArray();
        }
    }
}
