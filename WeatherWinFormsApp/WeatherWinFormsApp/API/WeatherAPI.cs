using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;


namespace WeatherWinFormsApp.API
{
    class WeatherAPI
    {
        // Клиент, который будет стучаться на сервер с погодой

        // Указание клиенту базовой ссылки
        private readonly RestClient restClient = new RestClient();

        public WeatherAPI()
        {
            // Создаём словарь заголовоков
            Dictionary<string, string> headers = new Dictionary<string, string>
            {
                // Добвляем значения в словарь
                { "x-rapidapi-host", "community-open-weather-map.p.rapidapi.com" },
                { "x-rapidapi-key", "4b3ce770c3msh089eaf260cd3ff2p1c7618jsnf7c6643d955c" }
            };

            // инициализация клиента
            restClient.BaseUrl = new Uri("https://community-open-weather-map.p.rapidapi.com/");
            restClient.AddDefaultHeaders(headers);
        }

        public CurrentWeatherResponceType GetResponceOnOneDayByCityName(string cityName)
        {
            // создаём запрос
            var request = new RestRequest("weather", DataFormat.Json);
            request.AddParameter("lang", "ru");
            request.AddParameter("units", "metric");
            request.AddParameter("mode", "json");
            request.AddParameter("q", cityName);
            // вызываем у клиента метод Get с настройками request
            var response = restClient.Get(request);

            var formatedResponce = JsonConvert.DeserializeObject<CurrentWeatherResponceType>(response.Content);
            return formatedResponce;
        }

        public FiveDaysWeatherResponceType GetFiveDaysResponceByCityName(string cityName)
        {
            // создаём запрос
            var request = new RestRequest("forecast", DataFormat.Json);
            request.AddParameter("lang", "ru");
            request.AddParameter("units", "metric");
            request.AddParameter("mode", "json");
            request.AddParameter("q", cityName);

            // вызываем у клиента метод Get с настройками request
            var response = restClient.Get(request);

            // возвращаем преобразованный объект
            return JsonConvert.DeserializeObject<FiveDaysWeatherResponceType>(response.Content);
        }
    }
}

