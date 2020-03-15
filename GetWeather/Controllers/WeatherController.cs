using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetWeather.Models;
using GetWeather.Services;
using Microsoft.AspNetCore.Mvc;

namespace GetWeather.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly WeatherService _weatherService;

        public WeatherController(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        public ActionResult<List<Weather>> Get() => _weatherService.Get();
        
        [HttpGet("{id:length(24)}",Name ="GetWeather")]
        public ActionResult<Weather> Get(string id)
        {
            var weather = _weatherService.Get(id);
            if (weather == null)
            {
                return NotFound();
            }
            
            return weather;

        }
    }
}