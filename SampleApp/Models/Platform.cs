using System;
using Newtonsoft.Json;

namespace SampleApp.Models
{
    public class Platform
    {
        [JsonProperty(PropertyName = "googleAnalyticsTrackingCode")]
        public string GoogleAnalyticsTrackingCode { get; set; }

        [JsonProperty(PropertyName = "minimumVersion")]
        public string MinimumVersion { get; set; }

        [JsonProperty(PropertyName = "currentVersion")]
        public string CurrentVersion { get; set; }

        [JsonProperty(PropertyName = "features")]
        public Features Features { get; set; }

        public Platform()
        {
        }
    }
}
