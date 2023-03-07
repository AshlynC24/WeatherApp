using System;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var APIKey = "75273250a2a5c479dd0913ad991c55cd";

            Console.WriteLine("Please enter the city you want to see the weather for:");
            var cityName = Console.ReadLine();

            var WeatherMapURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={APIKey}&units=imperial";
            string weatherResponse = client.GetStringAsync(WeatherMapURL).Result;
            JObject weatherObject = JObject.Parse(weatherResponse);
            Console.WriteLine("Weather Object");

            Console.WriteLine("Weather:  ");
            Console.WriteLine($"It is {weatherObject["main"]["temp"]} degrees fahrenheit in {cityName}");

        }
    }
}

