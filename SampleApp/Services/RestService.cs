using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SampleApp.Models;

namespace SampleApp.Services
{
    public class RestService : IRestService
    {
        public async Task<Config> GetConfig()
        {
            using (var client = new HttpClient())
            {
                Config config = new Config();
                Uri uri = new Uri(App.BackendUrl + "/config");
                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    config = JsonConvert.DeserializeObject<Config>(content);
                }

                return config;
            }
        }
    }
}
