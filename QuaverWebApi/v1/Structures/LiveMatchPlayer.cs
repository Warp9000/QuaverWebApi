using Newtonsoft.Json;
using QuaverWebApi.v1.Structures.Enums;

namespace QuaverWebApi.v1.Structures;

public struct LiveMatchPlayer
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("steam_id")]
    public string SteamId { get; set; }

    [JsonProperty("username")]
    public string Username { get; set; }

    [JsonProperty("country")]
    public string Country { get; set; }

    [JsonProperty("avatar_url")]
    public string AvatarUrl { get; set; }

    [JsonProperty("team")]
    public int? Team { get; set; }

    [JsonProperty("wins")]
    public int Wins { get; set; }

    [JsonProperty("is_ready")]
    public bool IsReady { get; set; }

    [JsonProperty("has_map")]
    public bool HasMap { get; set; }

    [JsonProperty("mods")]
    public ModIdentifier Mods { get; set; }

    [JsonProperty("mods_string")]
    public string ModsString { get; set; }

    [JsonProperty("score")]
    public int? Score { get; set; }
}