using Newtonsoft.Json;

namespace QuaverWebApi.v1.Structures;

public struct MultiplayerMatches
{
    [JsonProperty("live")]
    public BasicLiveMatch[] Live { get; set; }

    [JsonProperty("recently_played")]
    public RecentMatch[] RecentlyPlayed { get; set; }
}