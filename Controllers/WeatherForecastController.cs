using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PFEBackend.Models;
using System.Security.Claims;

namespace PFEBackend.Controllers
{
    [ApiController]
    [Route("WeatherForecast")]
    public class WeatherForecastController : ControllerBase
    {
        private VinciMarketContext _context;
        private IConfiguration _configuration;
        private HttpContext _httpContext;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, VinciMarketContext context, IConfiguration config, HttpContext httpContext)
        {
            _logger = logger;
            _context = context;
            _configuration = config;
            _httpContext = httpContext;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("/free")]
        [AllowAnonymous]
        public IEnumerable<WeatherForecast> GetFree()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("/config")]
        [AllowAnonymous]
        public string? GetConfig()
        {
            return _configuration.GetConnectionString("DB");
        }

        [HttpGet("/administrator")]
        [Authorize(Roles = "administrator")]
        public IEnumerable<WeatherForecast> GetVIP()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        
        [HttpGet("/me")]
        [AllowAnonymous]
        public IEnumerable<Claim> GetMe()
        {
            return _httpContext.User.Claims;
        }
    }
}