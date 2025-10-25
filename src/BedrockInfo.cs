using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BedrockInfoApi
{
    public class BedrockInfo
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://api.bedrockinfo.com/v2";
        public BedrockInfo() {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36");
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> GetServerStatus(string address, int port = 19132, int history = 5) {
            var response = await httpClient.GetAsync($"{apiUrl}/status?server={address}&port={port}&history={history}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
