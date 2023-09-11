using System;
using Newtonsoft.Json;

namespace QuaverWebApi.v1.Structures;

    public class GraphStatistics
    {
        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }
    }