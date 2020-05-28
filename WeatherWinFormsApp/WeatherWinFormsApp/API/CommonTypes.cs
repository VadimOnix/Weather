namespace WeatherWinFormsApp.API
{
    class Coord
    {
        public float lon = 0;
        public float lat = 0;
    }

    class WeatherItem
    {
        public int id = 0;
        public string main = "";
        public string description = "";
        public string icon = "";
    }

    class Main
    {
        public float temp = 0;
        public float feels_like = 0;
        public float temp_min = 0;
        public float temp_max = 0;
        public int pressure = 0;
        public int humidity = 0;
        public float sea_level = 0;
        public float grnd_level = 0;
        public float temp_kf = 0;
    }
    class Wind
    {
        public float speed = 0;
        public float deg = 0;
    }
    class Clouds
    {
        public int all = 0;
    }
    class Sys
    {
        public int type = 0;
        public int id = 0;
        public string country = "";
        public int sunrise = 0;
        public int sunset = 0;
        public string pod = "";
    }
    class City
    {
        public int id = 0;
        public string name = "";
        public Coord coord = new Coord();
        public string country = "";
        public int population = 0;
        public int timezone = 0;
        public int sunrise = 0;
        public int sunset = 0;
    }
}
