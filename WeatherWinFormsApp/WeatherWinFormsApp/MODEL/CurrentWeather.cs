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
        public string Description;
        public int Temp;
        public int FeelsLike;
        public int Pressure;
        public int Humidity;
        public int WindSpeed;
        private string windDirection;
        // TODO: реализовать преобразование градусов в направление ветра
        public string WindDirection { get => windDirection; set => windDirection = value; }
        public DateTime SunriseTime;
        public DateTime SunsetTime;
    }
}
