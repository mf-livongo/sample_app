using System.Collections.Generic;
using Newtonsoft.Json;

namespace SampleApp.Models
{
    public class Config
    {
        [JsonProperty(PropertyName = "loginModes")]
        public LoginModes LoginModes { get; set; }

        [JsonProperty(PropertyName = "isProduction")]
        public bool IsProduction { get; set; }

        [JsonProperty(PropertyName = "apiDomain")]
        public string ApiDomain { get; set; }

        [JsonProperty(PropertyName = "pingOneLogoutUrl")]
        public string PingOneLogoutUrl { get; set; }

        [JsonProperty(PropertyName = "livongoSettingsUrl")]
        public string LivongoSettingsUrl { get; set; }

        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        [JsonProperty(PropertyName = "platforms")]
        public Platforms Platforms { get; set; }

        [JsonIgnore]
        public bool HasPlatforms => Platforms != null;

        public Config()
        {
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        public List<ConfigItem> GetItems()
        {
            var items = new List<ConfigItem>();
            void addItem(string name, string value, object detail)
            {
                items.Add(new ConfigItem()
                {
                    Name = name,
                    Value = value,
                    FullDetails = detail
                });
            }
            addItem("Login Modes", "View Details", LoginModes);
            addItem("Is Production", "View Details", IsProduction ? "True" : "False");
            addItem("Api Domain", "View Details", ApiDomain);
            addItem("Ping One Logout Url", "View Details", PingOneLogoutUrl);
            addItem("Livongo Settings Url", "View Details", LivongoSettingsUrl);
            addItem("Version", "View Details", Version);
            addItem("Platforms", "View Details", Platforms);
            return items;
        }
    }
}

