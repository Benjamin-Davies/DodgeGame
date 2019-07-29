using System.Net.Http;
using System.Threading.Tasks;

namespace DodgeGame
{
    static class Scoreboard
    {
        private static HttpClient httpClient;
        public static void PostScore(string name, int lifeCount, int score)
        {
            Task.Run(async () =>
            {
                if (httpClient == null)
                {
                    httpClient = new HttpClient();
                }

                await httpClient.PostAsync("http://php.mmc.school.nz/");
            });
        }
    }
}
