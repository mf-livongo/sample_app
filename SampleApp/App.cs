using System;
using SampleApp.Services;

namespace SampleApp
{
    public class App
    {
        public static string BackendUrl = "https://api.mystrength.com";
        public static IRestService restService;

        public static void Initialize()
        {
            restService = new RestService();
        }
    }
}
