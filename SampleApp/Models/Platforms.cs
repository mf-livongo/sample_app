using System;
using Newtonsoft.Json;

namespace SampleApp.Models
{
    public class Platforms
    {
        [JsonProperty(PropertyName = "web")]
        public Platform Web { get; set; }

        [JsonProperty(PropertyName = "android")]
        public Platform Android { get; set; }

        [JsonProperty(PropertyName = "ios")]
        public Platform Ios { get; set; }

        public Platforms()
        {
        }
    }
}
