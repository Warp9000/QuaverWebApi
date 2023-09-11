using System;
using Newtonsoft.Json;

namespace QuaverWebApi.v1.Structures;

public struct MultiplayerGame
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("unique_id")]
    public string UniqueId { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("type")]
    public int? Type { get; set; }

    [JsonProperty("time_created")]
    public DateTime TimeCreated { get; set; }
}