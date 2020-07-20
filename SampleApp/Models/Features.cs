using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SampleApp.Models
{
    public class Features : Dictionary<string, bool>
    {
        [JsonIgnore]
        public bool MobileWa
        {
            get
            {
                return this["mobile_wa"];
            }
        }
        [JsonIgnore]
        public bool Promotions
        {
            get
            {
                return this["promotions"];
            }
        }
        [JsonIgnore]
        public bool RacialSensitivityBanner
        {
            get
            {
                return this["racial_sensitivity_banner"];
            }
        }
        [JsonIgnore]
        public bool Websockets
        {
            get
            {
                return this["websockets"];
            }
        }

        public Features()
        {
        }
    }
}
