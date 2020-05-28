using System;
using System.Drawing;
using System.Windows.Forms;
using WeatherWinFormsApp.CONTROLLERS;
using WeatherWinFormsApp.MODEL;

namespace WeatherWinFormsApp
{
    public partial class MainForm : Form
    {
        AppController appController = new AppController();
        CurrentWeather cw = AppController.CurrentWeather;
        WeekWeather ww = AppController.WeekWeather;

        private bool onOneDay = true;

        private Bitmap GetWeatherImg(int temp, int windSpeed, int cloud, float rainIntense, float snowIntense)
        {
            if (windSpeed > 12) return Properties.Resources.tornado;
            if (snowIntense > 4) return Properties.Resources.snowflake_1;
            if (temp > -20 && cloud <= 35 && rainIntense < 1 && snowIntense < 1) return Properties.Resources.sun;
            if (temp <= -20 && rainIntense < 1 && snowIntense < 1) return Properties.Resources.penguin;
            if (rainIntense > 1) return Properties.Resources.umbrella;
            if (rainIntense > 4) return Properties.Resources.lightening;
            if (temp > 0 && windSpeed < 3 && cloud > 35 && rainIntense < 1 && snowIntense < 1) return Properties.Resources.cloudy;
            return Properties.Resources.cloudy;
        }

        private void Render()
        {
            if (onOneDay)
            {
                lbLastRequest.Text = DateTime.Now.TimeOfDay.ToString().Substring(0, 5);

                lbTodayCityName.Text = cw.CityName;
                lbTodayDescription.Text = cw.Description;
                lbTodayTemp.Text = cw.Temp > 0 ? $"+{cw.Temp}" : cw.Temp.ToString();
                lbTodayWind.Text = $"{cw.WindSpeed} м/с {cw.WindDirection}";
                lbTodayHumidity.Text = $"{cw.Humidity} %";
                lbTodayPressure.Text = $"{cw.Pressure} гПа";
                lbTodayLon.Text = $"{cw.Lon}";
                lbTodayLat.Text = $"{cw.Lat}";
                imgTodayStatus.BackgroundImage = GetWeatherImg(cw.Temp, cw.WindSpeed, cw.Clouds, cw.RainIntensive, cw.SnowIntensive);

            }
            else
            {
                lbWeekCityName.Text = ww.CityName;
                // TODO: Оптимизировать через цикл, обходя дочерние элементы панели
                imgWeekDay1.BackgroundImage = GetWeatherImg(ww.Days[0].Temp, ww.Days[0].WindSpeed, ww.Days[0].Clouds, ww.Days[0].RainIntensive, ww.Days[0].SnowIntensive);
                lbWeekDay1Temp.Text = ww.Days[0].Temp > 0 ? $"+{ww.Days[0].Temp}" : ww.Days[0].Temp.ToString();
                lbWeekDay1Date.Text = ww.Days[0].Date.Substring(0, 10);

                imgWeekDay2.BackgroundImage = GetWeatherImg(ww.Days[1].Temp, ww.Days[1].WindSpeed, ww.Days[1].Clouds, ww.Days[1].RainIntensive, ww.Days[1].SnowIntensive);
                lbWeekDay2Temp.Text = ww.Days[1].Temp > 0 ? $"+{ww.Days[1].Temp}" : ww.Days[1].Temp.ToString();
                lbWeekDay2Date.Text = ww.Days[1].Date.Substring(0, 10);

                imgWeekDay3.BackgroundImage = GetWeatherImg(ww.Days[2].Temp, ww.Days[2].WindSpeed, ww.Days[2].Clouds, ww.Days[2].RainIntensive, ww.Days[2].SnowIntensive);
                lbWeekDay3Temp.Text = ww.Days[2].Temp > 0 ? $"+{ww.Days[2].Temp}" : ww.Days[2].Temp.ToString();
                lbWeekDay3Date.Text = ww.Days[2].Date.Substring(0, 10);

                imgWeekDay4.BackgroundImage = GetWeatherImg(ww.Days[3].Temp, ww.Days[3].WindSpeed, ww.Days[3].Clouds, ww.Days[3].RainIntensive, ww.Days[3].SnowIntensive);
                lbWeekDay4Temp.Text = ww.Days[3].Temp > 0 ? $"+{ww.Days[3].Temp}" : ww.Days[3].Temp.ToString();
                lbWeekDay4Date.Text = ww.Days[3].Date.Substring(0, 10);

                imgWeekDay5.BackgroundImage = GetWeatherImg(ww.Days[4].Temp, ww.Days[4].WindSpeed, ww.Days[4].Clouds, ww.Days[4].RainIntensive, ww.Days[4].SnowIntensive);
                lbWeekDay5Temp.Text = ww.Days[4].Temp > 0 ? $"+{ww.Days[4].Temp}" : ww.Days[4].Temp.ToString();
                lbWeekDay5Date.Text = ww.Days[4].Date.Substring(0, 10);
                ////////////////////////////////////////////////////////////////////////

            }
        }

        public MainForm()
        {
            InitializeComponent();
            if (!appController.CheckConnect())
            {
                pnError.BringToFront();
                pnNetworkStatus.BackgroundImage = WeatherWinFormsApp.Properties.Resources.bad_network;
            }
            else
            {
                pnApp.BringToFront();
                pnNetworkStatus.BackgroundImage = WeatherWinFormsApp.Properties.Resources.good_network;
            }
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

            onOneDay = true;

            //поднятие наверх панели погоды на сегодня
            pnToday.BringToFront();
        }

        private void btnSetWeek_Click(object sender, EventArgs e)
        {
            pnMenuTab.Height = btnSetWeek.Height;
            pnMenuTab.Top = btnSetWeek.Top;


            onOneDay = false;
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
            appController.GetWeather(tbSearch.Text, onOneDay);
            Render();
        }
    }
}

