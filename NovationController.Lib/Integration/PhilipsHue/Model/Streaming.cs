﻿using Newtonsoft.Json;

namespace NovationController.Lib.Integration.PhilipsHue.Model
{
    public partial class Streaming
    {
        [JsonProperty("renderer")]
        public bool Renderer { get; set; }

        [JsonProperty("proxy")]
        public bool Proxy { get; set; }
    }
}