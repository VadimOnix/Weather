using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWinFormsApp.MODEL
{
    class CurrentWeather
    {
        private string cityName = "";
        private string description = "";
        private int temp = 0;
        private float feelsLike = 0;
        private int pressure = 0;
        private int humidity = 0;
        private int windSpeed = 0;
        private string windDirection = "";
        private DateTime sunriseTime = new DateTime();
        private DateTime sunsetTime = new DateTime();
        private float lon = 0;
        private float lat = 0;
        private float rainIntensive = 0;
        private float snowIntensive = 0;
        private int clouds = 0;

        public string Description { get => description; set => description = value; }
        public int Temp { get => temp; set => temp = value; }
        public float FeelsLike { get => feelsLike; set => feelsLike = value; }
        public int Pressure { get => pressure; set => pressure = value; }
        public int Humidity { get => humidity; set => humidity = value; }
        public int WindSpeed { get => windSpeed; set => windSpeed = value; }
        public string WindDirection { get => windDirection; set => windDirection = value; }
        public DateTime SunriseTime { get => sunriseTime; set => sunriseTime = value; }
        public DateTime SunsetTime { get => sunsetTime; set => sunsetTime = value; }
        public string CityName { get => cityName; set => cityName = value; }
        public float Lon { get => lon; set => lon = value; }
        public float Lat { get => lat; set => lat = value; }
        public float RainIntensive { get => rainIntensive; set => rainIntensive = value; }
        public float SnowIntensive { get => snowIntensive; set => snowIntensive = value; }
        public int Clouds { get => clouds; set => clouds = value; }
    }
}
