using DodgeGame.Properties;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DodgeGame
{
    static class RapidApi
    {
        private static readonly string ApiKey = Resources.RapidApiKey;
        private const string ApiUrl = "https://neutrinoapi-bad-word-filter.p.rapidapi.com/bad-word-filter";

        public static async Task<bool> BadWordFilter(string text)
        {
            var content = new MultipartFormDataContent
            {
                { new StringContent(text), "content" },
            };

            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(ApiUrl),
                Method = HttpMethod.Post,
                Headers =
                {
                    { "x-rapidapi-host", "neutrinoapi-bad-word-filter.p.rapidapi.com" },
                    { "x-rapidapi-key", ApiKey },
                },
                Content = content,
            };
            var response = await Scoreboard.httpClient.PostAsync(ApiUrl, content);

            var str = await response.Content.ReadAsStringAsync();
            var obj = JsonConvert.DeserializeObject<BadWordFilterResponse>(str);

            return obj.IsBad;
        }

        private class BadWordFilterResponse
        {
            [JsonProperty("is-bad")]
            public bool IsBad;
        }
    }
}
