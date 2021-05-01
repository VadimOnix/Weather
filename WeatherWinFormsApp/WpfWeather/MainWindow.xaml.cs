using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WeatherWinFormsApp.CONTROLLERS;
using WeatherWinFormsApp.MODEL;

namespace WpfWeather
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        AppController appController = new AppController();
        CurrentWeather cw = AppController.CurrentWeather;
        WeekWeather ww = AppController.WeekWeather;

        private bool onOneDay = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private ImageSource GetWeatherImg(int temp, int windSpeed, int cloud, float rainIntense, float snowIntense)
        {
            var source = "/cloudy.png";
            if (windSpeed > 12) source = "/tornado.png";
            if (snowIntense > 4) source = "/snowflake-1.png";
            if (temp > -20 && cloud <= 35 && rainIntense < 1 && snowIntense < 1) source = "/sun.png";
            if (temp <= -20 && rainIntense < 1 && snowIntense < 1) source = "/penguin.png";
            if (rainIntense > 1) source = "/umbrella.png";
            if (rainIntense > 4) source = "/lightening.png";
            ImageSource imageSource = new BitmapImage(new Uri(source, UriKind.Relative));
            return imageSource;
        }

        private void Render()
        {
            if (onOneDay)
            {
                LastRequestTime.Text = DateTime.Now.TimeOfDay.ToString().Substring(0, 5);

                CityTitle.Text = cw.CityName;
                CityStatus.Text = cw.Description;
                CityTemperature.Text = cw.Temp > 0 ? $"+{cw.Temp}" : cw.Temp.ToString();
                CityWindValue.Text = $"{cw.WindSpeed} м/с {cw.WindDirection}";
                CityHumidityValue.Text = $"{cw.Humidity} %";
                CityPleasureValue.Text = $"{cw.Pressure} гПа";
                CityLonValue.Text = $"{cw.Lon}";
                CityLatValue.Text = $"{cw.Lat}";
                CityImgStatus.Source = GetWeatherImg(cw.Temp, cw.WindSpeed, cw.Clouds, cw.RainIntensive, cw.SnowIntensive);

            }
            else
            {
                CityWeekTitle.Text = ww.CityName;
                // TODO: Оптимизировать через цикл, обходя дочерние элементы панели
                CityWeekImage1.Source = GetWeatherImg(ww.Days[0].Temp, ww.Days[0].WindSpeed, ww.Days[0].Clouds, ww.Days[0].RainIntensive, ww.Days[0].SnowIntensive);
                CityWeekTemp1.Text = ww.Days[0].Temp > 0 ? $"+{ww.Days[0].Temp}" : ww.Days[0].Temp.ToString();
                CityWeekDate1.Text = ww.Days[0].Date.Substring(0, 10);

                CityWeekImage2.Source = GetWeatherImg(ww.Days[1].Temp, ww.Days[1].WindSpeed, ww.Days[1].Clouds, ww.Days[1].RainIntensive, ww.Days[1].SnowIntensive);
                CityWeekTemp2.Text = ww.Days[1].Temp > 0 ? $"+{ww.Days[1].Temp}" : ww.Days[1].Temp.ToString();
                CityWeekDate2.Text = ww.Days[1].Date.Substring(0, 10);

                CityWeekImage3.Source = GetWeatherImg(ww.Days[2].Temp, ww.Days[2].WindSpeed, ww.Days[2].Clouds, ww.Days[2].RainIntensive, ww.Days[2].SnowIntensive);
                CityWeekTemp3.Text = ww.Days[2].Temp > 0 ? $"+{ww.Days[2].Temp}" : ww.Days[2].Temp.ToString();
                CityWeekDate3.Text = ww.Days[2].Date.Substring(0, 10);

                CityWeekImage4.Source = GetWeatherImg(ww.Days[3].Temp, ww.Days[3].WindSpeed, ww.Days[3].Clouds, ww.Days[3].RainIntensive, ww.Days[3].SnowIntensive);
                CityWeekTemp4.Text = ww.Days[3].Temp > 0 ? $"+{ww.Days[3].Temp}" : ww.Days[3].Temp.ToString();
                CityWeekDate4.Text = ww.Days[3].Date.Substring(0, 10);

                CityWeekImage5.Source = GetWeatherImg(ww.Days[4].Temp, ww.Days[4].WindSpeed, ww.Days[4].Clouds, ww.Days[4].RainIntensive, ww.Days[4].SnowIntensive);
                CityWeekTemp5.Text = ww.Days[4].Temp > 0 ? $"+{ww.Days[4].Temp}" : ww.Days[4].Temp.ToString();
                CityWeekDate5.Text = ww.Days[4].Date.Substring(0, 10);
                ////////////////////////////////////////////////////////////////////////

            }
        }

        private void ButtonClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void SearchButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            appController.GetWeather(SearchInput.Text, onOneDay);
            Render();
        }

        private void TodaySelect_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            onOneDay = true;
            TodayDisplay.Visibility = Visibility.Visible;
            WeekDisplay.Visibility = Visibility.Hidden;
        }

        private void WeekSelect_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            onOneDay = false;
            TodayDisplay.Visibility = Visibility.Hidden;
            WeekDisplay.Visibility = Visibility.Visible;
        }
    }
}
