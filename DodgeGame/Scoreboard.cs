using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DodgeGame
{
    static class Scoreboard
    {
        private const string ApiUrl = "http://php.mmc.school.nz/201BH/benjamindavies/DodgeGameScoreboard/scoreboard";

        private static HttpClient httpClient = new HttpClient();

        public static void PostScore(ScoreData score)
        {
            Task.Run(async () =>
            {
                var content = score.CreateContent();
                await httpClient.PostAsync(ApiUrl, content);
            });
        }

        public static async Task<ScoreData[]> GetScores()
        {
            var response = await httpClient.GetStringAsync(ApiUrl);
            return JsonConvert.DeserializeObject<ScoreData[]>(response);
        }

        public class ScoreData
        {
            public string Username = "";
            public int LifeCount = 0;
            public int Score = 0;

            internal HttpContent CreateContent() =>
                new MultipartFormDataContent { { new StringContent(Username), "Username" },
                    { new StringContent(LifeCount.ToString()), "LifeCount" },
                    { new StringContent(Score.ToString()), "Score" }
                };
        }
    }
}
