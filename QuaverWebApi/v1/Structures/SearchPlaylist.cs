using System;
using Newtonsoft.Json;

namespace QuaverWebApi.v1.Structures;

// /playlist/all/search
public struct SearchPlaylist
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("owner_id")]
    public int OwnerId { get; set; }

    [JsonProperty("owner_username")]
    public string OwnerUsername { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("like_count")]
    public int LikeCount { get; set; }

    [JsonProperty("map_count")]
    public int MapCount { get; set; }

    [JsonProperty("time_created")]
    public DateTime TimeCreated { get; set; }

    [JsonProperty("time_last_updated")]
    public DateTime TimeLastUpdated { get; set; }
}