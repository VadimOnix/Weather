using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWinFormsApp.API
{
    class WeatherListData
    {
        public int dt;
        public Main Main;
        public List<WeatherItem> weather = new List<WeatherItem>();
        public Clouds clouds;
        public Wind wind;
        public Dictionary<string,float> rain = new Dictionary<string, float> { { "3h", 0 } };
        public Dictionary<string,string> sys = new Dictionary<string, string> { { "pod", "d" } };
        public string dt_txt;
    }
    class FiveDaysWeatherResponceType
    {
        public int cod;
        public int message;
        public int cnt;
        public List<WeatherListData> list = new List<WeatherListData>();
        public City city;
    }
}
