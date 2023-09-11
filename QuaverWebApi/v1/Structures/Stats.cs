using Newtonsoft.Json;

namespace QuaverWebApi.v1.Structures;

public struct Stats
{
    [JsonProperty("total_online_users")]
    public int TotalOnlineUsers { get; set; }

    [JsonProperty("total_users")]
    public int TotalUsers { get; set; }

    [JsonProperty("total_mapsets")]
    public int TotalMapsets { get; set; }

    [JsonProperty("total_scores")]
    public int TotalScores { get; set; }
}