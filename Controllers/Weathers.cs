using ApiWeather.Context;
using ApiWeather.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeather.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Weathers : ControllerBase
    {
        WeatherContext context = new WeatherContext();

        [HttpGet]
        public IActionResult WeatherCityList()
        {
            var values = context.City.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateWeatherCity(Cities cities)
        {
            context.City.Add(cities);
            context.SaveChanges();
            return Ok("Şehir Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteWeatherCity(int id)
        {
            var value = context.City.Find(id);
            context.City.Remove(value);
            context.SaveChanges();
            return Ok("Şehir Silindi");

        }

        [HttpPut]
        public IActionResult UpdateWeatherCity(Cities cities)
        {
            var value = context.City.Find(cities.CityId);
            value.CityName = cities.CityName;
            value.Details = cities.Details;
            value.Temp = cities.Temp;
            context.SaveChanges();
            return Ok("Güncelleme İşlemi Başarılı.");

        }

        [HttpGet("GetByIdWeatherCity")]
        public IActionResult GetByIdWeatherCity(int id)
        {
            var value = context.City.Find(id);
            return Ok(value);
        }

        [HttpGet("TotalCityCount")]
        public IActionResult TotalCityCount()
        {
            var value = context.City.Count();
            return Ok(value);
        }

        [HttpGet("MaxTempCityName")]
        public IActionResult MaxTempCityName()
        {
            var value = context.City.OrderByDescending(x => x.Temp).Select(y => y.CityName).FirstOrDefault();
            return Ok(value);
        }



    }
}
