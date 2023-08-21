using Newtonsoft.Json.Linq;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        public static double CurrTemp()
        {
            var client = new HttpClient();
            
            var apiKeyObj = File.ReadAllText("appsettings.json");

            var apiKey = JObject.Parse(apiKeyObj).GetValue("apiKey").ToString();

            var openWeatherURL = $"https://api.openweathermap.org/data/2.5/weather?zip=47302,us&appid={apiKey}&units=imperial";

            var openWeatherResponse = client.GetStringAsync(openWeatherURL).Result;

            var openWeatherInfo = JObject.Parse(openWeatherResponse);

            var temp = Math.Round(double.Parse(openWeatherInfo["main"]["temp"].ToString()), 0);

            var currDesc = openWeatherInfo["weather"][0]["description"].ToString();

            return temp;
        }
        public static string CurrDescription()
        {
            var client = new HttpClient();
            
            var apiKeyObj = File.ReadAllText("appsettings.json");

            var apiKey = JObject.Parse(apiKeyObj).GetValue("apiKey").ToString();

            var openWeatherURL = $"https://api.openweathermap.org/data/2.5/weather?zip=47302,us&appid={apiKey}&units=imperial";

            var openWeatherResponse = client.GetStringAsync(openWeatherURL).Result;

            var openWeatherInfo = JObject.Parse(openWeatherResponse);

            var description = openWeatherInfo["weather"][0]["description"].ToString();

            return description;
        }

    }
}
