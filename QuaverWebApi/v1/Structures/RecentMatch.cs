using System;
using Newtonsoft.Json;

namespace QuaverWebApi.v1.Structures;

// /multiplayer/games
public struct RecentMatch
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("type")]
    public int? Type { get; set; }

    [JsonProperty("time_played")]
    public DateTime TimePlayed { get; set; }

    [JsonProperty("map")]
    public MatchMap Map { get; set; }

    public struct MatchMap
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("mapset_id")]
        public int MapsetId { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}