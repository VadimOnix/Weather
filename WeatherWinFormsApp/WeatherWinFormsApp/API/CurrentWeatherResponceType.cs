using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int dt = 0;
        public Sys sys = new Sys();
        public int timezone = 0;
        public int id = 0;
        public string name = "";
        public int cod = 0;
    }
}
