using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherWinFormsApp.MODEL;

namespace WeatherWinFormsApp
{
    public partial class MainForm : Form
    {
        private WeatherAPI WeatherAPI = new WeatherAPI();
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrentWeather currentWeather = WeatherAPI.GetCurrentWeatherByCityName("London");
        }

    }
}

