using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherWinFormsApp.MODEL
{
    class WeatherAPI
    {
        // Клиент, который будет стучаться на сервер с погодой

        // Указание клиенту базовой ссылки
        private RestClient restClient = new RestClient();
        
        public WeatherAPI()
        {
            // Создаём словарь заголовоков
            Dictionary<string, string> headers = new Dictionary<string, string>();
            // Добвляем значения в словарь
            headers.Add("x-rapidapi-host", "community-open-weather-map.p.rapidapi.com");
            headers.Add("x-rapidapi-key", "4b3ce770c3msh089eaf260cd3ff2p1c7618jsnf7c6643d955c");

            // инициализация клиента
            restClient.BaseUrl = new Uri("https://community-open-weather-map.p.rapidapi.com/");
            restClient.AddDefaultHeaders(headers);
        }

        public CurrentWeather GetCurrentWeatherByCityName(string cityName)
        {
            // создаём запрос
            var request = new RestRequest("weather", DataFormat.Json);
            request.AddParameter("lang", "ru");
            request.AddParameter("units", "metric");
            request.AddParameter("mode", "json");
            request.AddParameter("q", cityName);
            // вызываем у клиента метод Get с настройками request
            var response = restClient.Get(request);

            CurrentWeather currentWeather = new CurrentWeather();
            return currentWeather;
        }
    }
}

