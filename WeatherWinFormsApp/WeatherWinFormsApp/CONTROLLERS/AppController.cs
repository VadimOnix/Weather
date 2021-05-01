using System;
using WeatherWinFormsApp.API;
using WeatherWinFormsApp.MODEL;
using WeatherWinFormsApp.UTILS;

namespace WeatherWinFormsApp.CONTROLLERS
{
    public class AppController
    {
        WeatherAPI WeatherAPI = new WeatherAPI();
        public static CurrentWeather CurrentWeather = new CurrentWeather();
        public static WeekWeather WeekWeather = new WeekWeather();

        private ConnectChecker connectChecker = new ConnectChecker(); 

        public bool CheckConnect()
        {
            return connectChecker.IsAvailable();
        }

        public void GetWeather(string cityName, bool onOneDay)
        {
            if (onOneDay)
            {
                var responce = WeatherAPI.GetResponceOnOneDayByCityName(cityName);
                FillCurrentWeather(cityName, responce);
            }
            else
            {
                var responce = WeatherAPI.GetFiveDaysResponceByCityName(cityName);
                FillFiveDaysWeather(cityName, responce);
            }

        }


        private void FillFiveDaysWeather(string cityName, FiveDaysWeatherResponceType responce)
        {
            try
            {
                WeekWeather.Days.Clear();

                WeekWeather.CityName = cityName;
                for (int i = 0; i < 40; i += 8)
                {
                    var day = new Day();
                    day.Temp = Convert.ToInt32(responce.list[i].Main.temp);
                    day.Clouds = responce.list[i].clouds.all;

                    if (responce.list[i].rain["1h"] > 0 || responce.list[i].rain["3h"] > 0)
                    {
                        day.RainIntensive = responce.list[i].rain["1h"] > responce.list[i].rain["3h"] ? responce.list[i].rain["1h"] : responce.list[i].rain["3h"];
                    }

                    if (responce.list[i].snow["1h"] > 0 || responce.list[i].snow["3h"] > 0)
                    {
                        day.SnowIntensive = responce.list[i].snow["1h"] > responce.list[i].snow["3h"] ? responce.list[i].snow["1h"] : responce.list[i].snow["3h"];
                    }


                    day.Date = responce.list[i].dt_txt;

                    WeekWeather.Days.Add(day);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}\n{e.StackTrace}\n{e.InnerException}");
            }
        }


        private void FillCurrentWeather(string cityName, CurrentWeatherResponceType responce)
        {
            try
            {
                CurrentWeather.Description = responce.weather[0].description;
                CurrentWeather.FeelsLike = responce.main.feels_like;
                CurrentWeather.Humidity = responce.main.humidity;
                CurrentWeather.Pressure = responce.main.pressure;
                CurrentWeather.SunriseTime = new DateTime(responce.sys.sunrise);
                CurrentWeather.SunsetTime = new DateTime(responce.sys.sunset);
                CurrentWeather.Temp = Convert.ToInt32(responce.main.temp);
                CurrentWeather.Lat = responce.coord.lat;
                CurrentWeather.Lon = responce.coord.lon;
                CurrentWeather.WindSpeed = Convert.ToInt32(Math.Ceiling(responce.wind.speed));
                CurrentWeather.WindDirection = CalcWindDirection(responce.wind.deg);
                CurrentWeather.CityName = cityName;
                CurrentWeather.Clouds = responce.clouds.all;
                if (responce.rain["1h"] > 0 || responce.rain["3h"] > 0)
                {
                    CurrentWeather.RainIntensive = responce.rain["1h"] > responce.rain["3h"] ? responce.rain["1h"] : responce.rain["3h"];
                }
                if (responce.snow["1h"] > 0 || responce.snow["3h"] > 0)
                {
                    CurrentWeather.SnowIntensive = responce.snow["1h"] > responce.snow["3h"] ? responce.snow["1h"] : responce.snow["3h"];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}\n{e.StackTrace}\n{e.InnerException}");
            }
        }

        private string CalcWindDirection(float deg)
        {
            if (deg > 337.5) return "Северный";
            if (deg > 292.5) return "Северо-Западный";
            if (deg > 247.5) return "Западный";
            if (deg > 202.5) return "Юго-Западный";
            if (deg > 157.5) return "Южный";
            if (deg > 122.5) return "Юго-Восточный";
            if (deg > 67.5) return "Восточный";
            if (deg > 22.5) { return "Северо-Восточный"; }
            return "Северный";
        }
    }
}
