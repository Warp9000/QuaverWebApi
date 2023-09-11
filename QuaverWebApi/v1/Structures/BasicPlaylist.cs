using Newtonsoft.Json;

namespace QuaverWebApi.v1.Structures;

// /users/:id/playlists
public struct BasicPlaylist
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("like_count")]
    public int LikeCount { get; set; }

    [JsonProperty("map_count")]
    public int MapCount { get; set; }
}