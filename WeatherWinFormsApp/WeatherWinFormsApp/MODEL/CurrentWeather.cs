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
        public string Description = "";
        public float Temp = 0;
        public float FeelsLike = 0;
        public int Pressure = 0;
        public int Humidity = 0;
        public float WindSpeed = 0;
        private string windDirection;
        // TODO: реализовать преобразование градусов в направление ветра
        public string WindDirection { get => windDirection; set => windDirection = value; }
        public DateTime SunriseTime = new DateTime();
        public DateTime SunsetTime = new DateTime();
    }
}
