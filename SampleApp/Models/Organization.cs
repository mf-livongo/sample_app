using System;
using Newtonsoft.Json;

namespace SampleApp.Models
{
    public class Organization
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "program")]
        public string Program { get; set; }

        [JsonProperty(PropertyName = "callbackUrl")]
        public string CallbackUrl { get; set; }

        public Organization()
        {
        }
    }
}
