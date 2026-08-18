using Microsoft.AspNetCore.Mvc;
using Services;

namespace MyWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<ICar> Get()
    {
        ICarService carService = new CarService();
        return carServiceService.GetCars;
    }
}
