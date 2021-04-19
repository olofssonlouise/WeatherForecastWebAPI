using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherForecastWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IReadCsvFile _readCsv;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IReadCsvFile readCsv)
        {
            _readCsv = readCsv;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _readCsv.GetData();
            return Ok(result);
        }
    }
}
