using NLog;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static HttpClient client = new HttpClient();

        public static async Task DoStuff()
        {
            logger.Info("hello");

            try
            {
                client.Timeout = TimeSpan.FromSeconds(5);
                string google = "https://www.google.com/";
                logger.Info("got client");
                HttpResponseMessage response = await client.GetAsync(google);
                logger.Info("GetAsync");
                response.EnsureSuccessStatusCode();
                logger.Info("EnsureSuccessStatusCode");
                string responseBody = await response.Content.ReadAsStringAsync();
                logger.Info("ReadAsStringAsync");
                logger.Info(responseBody);

            }
            catch (Exception ex)
            {

                logger.Error(ex);

            }

            logger.Info("goodbye");
        }
    }
}
