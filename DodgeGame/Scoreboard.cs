using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DodgeGame
{
    static class Scoreboard
    {
        private static HttpClient httpClient = new HttpClient();

        public static void PostScore(string username, int lifeCount, int score)
        {
            Task.Run(async () =>
            {
                var content = new MultipartFormDataContent
                {
                    { new StringContent(username), "Username" },
                    { new StringContent(lifeCount.ToString()), "LifeCount" },
                    { new StringContent(score.ToString()), "Score" }
                };

                await httpClient.PostAsync("http://php.mmc.school.nz/201BH/benjamindavies/DodgeGameScoreboard/scoreboard", content);
            });
        }
    }
}
