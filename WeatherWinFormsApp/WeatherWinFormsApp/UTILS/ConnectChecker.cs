using System.Net;

namespace WeatherWinFormsApp.UTILS
{
    /// <summary>
    /// Класс, проверяющий интернет соединение
    /// </summary>
    class ConnectChecker
    {
        public bool IsAvailable()
        {
            try
            {
                var client = new WebClient();
                using (client.OpenRead("https://www.google.com"))
                {
                    return true;
                }
            } catch
            {
                return false;
            }
        }
    }
}
