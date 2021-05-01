using System.Collections.Generic;

namespace WeatherWinFormsApp.MODEL
{
    public class Day
    {
        
        private int temp = 0;
        private int windSpeed = 0;
        private float rainIntensive = 0;
        private float snowIntensive = 0;
        private int clouds = 0;

        private string date = "";
        public int Temp { get => temp; set => temp = value; }
        public int WindSpeed { get => windSpeed; set => windSpeed = value; }
        public float RainIntensive { get => rainIntensive; set => rainIntensive = value; }
        public float SnowIntensive { get => snowIntensive; set => snowIntensive = value; }
        public int Clouds { get => clouds; set => clouds = value; }
        public string Date { get => date; set => date = value; }
    }

    public class WeekWeather
    {
        private List<Day> days = new List<Day>();
        private string cityName = "";

        public string CityName { get => cityName; set => cityName = value; }
        public List<Day> Days { get => days; set => days = value; }
    }
}
