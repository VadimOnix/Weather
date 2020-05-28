using System.Collections.Generic;

namespace WeatherWinFormsApp.API
{
    class CurrentWeatherResponceType
    {
        public Coord coord = new Coord();
        public List<WeatherItem> weather = new List<WeatherItem>();
        public string Base = "";
        public Main main = new Main();
        public int visibility = 0;
        public Wind wind = new Wind();
        public Clouds clouds = new Clouds();
        public Dictionary<string, float> rain = new Dictionary<string, float> { { "1h", 0 }, { "3h", 0 } };
        public Dictionary<string, float> snow = new Dictionary<string, float> { { "1h", 0 }, { "3h", 0 } };
        public int dt = 0;
        public Sys sys = new Sys();
        public int timezone = 0;
        public int id = 0;
        public string name = "";
        public int cod = 0;
    }
}
