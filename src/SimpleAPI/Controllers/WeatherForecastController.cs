using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

   // private readonly ILogger<WeatherForecastController> _logger;

    //public WeatherForecastController(ILogger<WeatherForecastController> logger)
   // {
     //   _logger = logger;
    //}
   
    [HttpGet(Name = "GetWeatherForecast")]
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
     public string  Get(int i)
    {
        return "sumit";
    }

 public string  Get(int i, int j)
    {
        return "ravikant";
    }
    
 public string  Get(int i, int j, int k)
    {
        return "kathmandu";
    }

   }
