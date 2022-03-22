using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using static System.Console;

namespace json
{
    public class Program
    {
        public static void Main()
        {
            var weatherForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelsius = 25,
                Summary = "Hot"
            };

            var phoenixForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2022-03-22"),
                TemperatureCelsius = 28,
                Summary = "Warm"
            };

            string jsonString = JsonSerializer.Serialize(weatherForecast);

            Console.WriteLine(jsonString);

            string phoenixString = JsonSerializer.Serialize(phoenixForecast);

            WriteLine(phoenixString);

            WeatherForecast w = JsonSerializer.Deserialize<WeatherForecast>(phoenixString);
            WriteLine(w.Summary);
            ReadKey();
        }
    }
}
