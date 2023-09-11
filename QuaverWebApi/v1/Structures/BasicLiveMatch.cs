using Newtonsoft.Json;
using QuaverWebApi.v1.Structures.Enums;

namespace QuaverWebApi.v1.Structures;

// /multiplayer/games
public struct BasicLiveMatch
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("type")]
    public int? Type { get; set; }

    [JsonProperty("has_password")]
    public bool HasPassword { get; set; }

    [JsonProperty("max_players")]
    public int MaxPlayers { get; set; }

    [JsonProperty("host_id")]
    public int HostId { get; set; }

    [JsonProperty("in_progress")]
    public bool InProgress { get; set; }

    [JsonProperty("rules")]
    public MatchRules Rules { get; set; }

    [JsonProperty("team_scores")]
    public MatchTeamScores TeamScores { get; set; }

    [JsonProperty("map")]
    public MatchMap Map { get; set; }

    public struct MatchRules
    {
        [JsonProperty("ruleset")]
        public int Ruleset { get; set; }

        [JsonProperty("auto_host_rotation")]
        public bool AutoHostRotation { get; set; }

        [JsonProperty("mods")]
        public ModIdentifier Mods { get; set; }

        [JsonProperty("mods_string")]
        public string ModsString { get; set; }

        [JsonProperty("free_mod_type")]
        public int FreeModType { get; set; }

        [JsonProperty("health_type")]
        public int? HealthType { get; set; }

        [JsonProperty("lives")]
        public int? Lives { get; set; }
    }

    public struct MatchTeamScores
    {
        [JsonProperty("red_team")]
        public int? RedTeam { get; set; }

        [JsonProperty("blue_team")]
        public int? BlueTeam { get; set; }
    }

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

        [JsonProperty("game_mode")]
        public GameMode GameMode { get; set; }

        [JsonProperty("difficulty_rating")]
        public double DifficultyRating { get; set; }
    }
}