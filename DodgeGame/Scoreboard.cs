﻿using System.Net.Http;
using System.Text;
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

        public class ScoreData
        {
            public string Username = "";
            public int LifeCount = 0;
            public int Score = 0;

            internal HttpContent CreateContent() =>
                new MultipartFormDataContent
                {
                    { new StringContent(Username), "Username" },
                    { new StringContent(LifeCount.ToString()), "LifeCount" },
                    { new StringContent(Score.ToString()), "Score" }
                };
        }
    }
}
