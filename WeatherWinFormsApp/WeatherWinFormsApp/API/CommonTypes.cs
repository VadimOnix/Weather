﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWinFormsApp.API
{
    class Rain
    {
        public float h;
    }
    class Coord
    {
        public float lon;
        public float lat;
    }

    class WeatherItem
    {
        public int id;
        public string main;
        public string description;
        public string icon;
    }

    class Main
    {
        public float temp;
        public float feels_like;
        public int temp_min;
        public float temp_max;
        public int pressure;
        public int humidity;
        public int sea_level;
        public int grnd_level;
        public float temp_kf;
    }
    class Wind
    {
        public float speed;
        public int deg;
    }
    class Clouds
    {
        public int all;
    }
    class Sys
    {
        public int type;
        public int id;
        public string country;
        public int sunrise;
        public int sunset;
        public string pod;
    }
    class City
    {
        public int id;
        public string name;
        public Coord coord;
        public string country;
        public int population;
        public int timezone;
        public int sunrise;
        public int sunset;  
    }
}
