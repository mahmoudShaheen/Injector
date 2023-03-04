using Microsoft.AspNetCore.Mvc;
using TestAppServices.Services;

namespace TestApp.Controllers
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
        private readonly ISingletonGenericTestService _iSingletonGenericTestService;
        private readonly SingletonTestService _singletonTestService;
        private readonly ScopedTestService _scopedTestService;
        private readonly TransientTestService _transientTestService;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            ISingletonGenericTestService iSingletonGenericTestService,
            SingletonTestService singletonTestService,
            ScopedTestService scopedTestService,
            TransientTestService transientTestService
            )
        {
            _logger = logger;
            _iSingletonGenericTestService = iSingletonGenericTestService;
            _singletonTestService = singletonTestService;
            _scopedTestService = scopedTestService;
            _transientTestService = transientTestService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            _iSingletonGenericTestService.Log();
            _singletonTestService.Log();
            _scopedTestService.Log();
            _transientTestService.Log();

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}