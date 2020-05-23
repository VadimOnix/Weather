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
using WeatherWinFormsApp;
using WeatherWinFormsApp.API;
using WeatherWinFormsApp.CONTROLLERS;
using WeatherWinFormsApp.MODEL;
using WeatherWinFormsApp.UTILS;

namespace WeatherWinFormsApp
{
    public partial class MainForm : Form
    {
        AppController appController = new AppController();
        CurrentWeather cw = AppController.CurrentWeather;

        private Bitmap GetWeatherImg(int temp, int windSpeed, int cloud, float rainIntense, float snowIntense)
        {
            if (windSpeed > 12) return WeatherWinFormsApp.Properties.Resources.tornado;
            if (snowIntense > 4) return WeatherWinFormsApp.Properties.Resources.snowflake_1;
            if (temp > -20 && cloud <= 35 && rainIntense < 1 && snowIntense < 1) return WeatherWinFormsApp.Properties.Resources.sun;
            if (temp <= -20 && rainIntense < 1 && snowIntense < 1) return WeatherWinFormsApp.Properties.Resources.penguin;
            if (rainIntense > 1) return WeatherWinFormsApp.Properties.Resources.umbrella;
            if (rainIntense > 4) return WeatherWinFormsApp.Properties.Resources.lightening;
            if (temp > 0 && windSpeed < 3 && cloud > 35 && rainIntense < 1 && snowIntense < 1) return WeatherWinFormsApp.Properties.Resources.cloudy;
            return WeatherWinFormsApp.Properties.Resources.cloudy;
        }

        private void Rerender()
        {
            lbLastRequest.Text = DateTime.Now.TimeOfDay.ToString().Substring(0,5);

            lbTodayCityName.Text = cw.CityName;
            lbTodayDescription.Text = cw.Description;
            lbTodayTemp.Text = cw.Temp > 0 ? $"+{cw.Temp.ToString()}" : cw.Temp.ToString();
            lbTodayWind.Text = $"{cw.WindSpeed} м/с {cw.WindDirection}";
            lbTodayHumidity.Text = $"{cw.Humidity} %";
            lbTodayPressure.Text = $"{cw.Pressure} гПа";
            lbTodayLon.Text = $"{cw.Lon}";
            lbTodayLat.Text = $"{cw.Lat}";
            imgTodayStatus.BackgroundImage = GetWeatherImg(cw.Temp, cw.WindSpeed, cw.Clouds, cw.RainIntensive, cw.SnowIntensive);
        }

        public MainForm()
        {
            InitializeComponent();
            this.Text = new ConnectChecker().IsAvailable() ? "Доступно!" : "Недоступно";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            pnSearchBorder.BackColor = Color.White;
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            pnSearchBorder.BackColor = Color.FromArgb(108, 117, 125);
        }

        private void btnSetToday_Click(object sender, EventArgs e)
        {
            pnMenuTab.Top = btnSetToday.Top;
            pnMenuTab.Height = btnSetToday.Height;

            //поднятие наверх панели погоды на сегодня
            pnToday.BringToFront();
        }

        private void btnSetWeek_Click(object sender, EventArgs e)
        {
            pnMenuTab.Height = btnSetWeek.Height;
            pnMenuTab.Top = btnSetWeek.Top;

            //поднятие наверх панели погоды на 5 дней
            pnWeek.BringToFront();
        }

        private void imgSetTooday_Click(object sender, EventArgs e)
        {
            btnSetToday_Click(sender, e);
        }

        private void lbSetToday_Click(object sender, EventArgs e)
        {
            btnSetToday_Click(sender, e);
        }

        private void imgSetWeek_Click(object sender, EventArgs e)
        {
            btnSetWeek_Click(sender, e);
        }

        private void lbSetWeek_Click(object sender, EventArgs e)
        {
            btnSetWeek_Click(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            appController.GetWeather(tbSearch.Text, true);
            Rerender();
        }
    }
}

