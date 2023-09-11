using Newtonsoft.Json;

namespace QuaverWebApi.v1.Structures;

// /users/search/:name
public struct BasicUser
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("username")]
    public string Username { get; set; }

    [JsonProperty("steam_id")]
    public string SteamId { get; set; }

    [JsonProperty("avatar_url")]
    public string AvatarUrl { get; set; }
}