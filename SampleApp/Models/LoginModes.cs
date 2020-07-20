using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SampleApp.Models
{
    public class LoginModes
    {
        [JsonProperty(PropertyName = "organizations")]
        public List<Organization> Organizations { get; set; }

        public LoginModes()
        {
        }
    }
}
