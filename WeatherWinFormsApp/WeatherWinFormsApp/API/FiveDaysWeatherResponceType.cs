using System.Collections.Generic;

namespace WeatherWinFormsApp.API
{
    class WeatherListData
    {
        public int dt = 0;
        public Main Main = new Main();
        public List<WeatherItem> weather = new List<WeatherItem>();
        public Clouds clouds = new Clouds();
        public Wind wind = new Wind();
        public Dictionary<string,float> rain = new Dictionary<string, float> { { "1h", 0 },{ "3h", 0 } };
        public Dictionary<string, float> snow = new Dictionary<string, float> { { "1h", 0 }, { "3h", 0 } };
        public Dictionary<string,string> sys = new Dictionary<string, string> { { "pod", "" } };
        public string dt_txt = "";
    }
    class FiveDaysWeatherResponceType
    {
        public int cod=0;
        public int message=0;
        public int cnt=0;
        public List<WeatherListData> list = new List<WeatherListData>();
        public City city=new City();
    }
}
