using Newtonsoft.Json;

namespace QuaverWebApi.v1.Structures;

public struct Achievement
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("steam_api_name")]
    public string SteamApiName { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("difficulty")]
    public string Difficulty { get; set; }

    [JsonProperty("unlocked")]
    public bool Unlocked { get; set; }
}