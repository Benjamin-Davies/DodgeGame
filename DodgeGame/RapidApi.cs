using DodgeGame.Properties;
using System.Threading.Tasks;

namespace DodgeGame
{
    static class RapidApi
    {
        private static readonly string ApiKey = Resources.RapidApiKey;

        public static async Task<bool> BadWordFilter(string text)
        {
            return false;
        }
    }
}
