using System;
using Newtonsoft.Json;

namespace QuaverWebApi.v1.Structures;

public struct LiveMultiplayerGame
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("type")]
    public int? Type { get; set; }

    [JsonProperty("has_password")]
    public bool HasPassword { get; set; }

    [JsonProperty("max_players")]
    public int MaxPlayers { get; set; }

    [JsonProperty("in_progress")]
    public bool InProgress { get; set; }
}