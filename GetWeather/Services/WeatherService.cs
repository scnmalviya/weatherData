using GetWeather.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetWeather.Services
{
    public class WeatherService
    {
        public readonly IMongoCollection<Weather> _weathers;

        public WeatherService(IWeatherDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _weathers = database.GetCollection<Weather>(settings.WeatherCollectionName);
        }

        public List<Weather> Get() => _weathers.Find(weather => true).ToList();

        public Weather Get(string id) => _weathers.Find<Weather>(weather => weather.Id == id).FirstOrDefault();


    }
}
