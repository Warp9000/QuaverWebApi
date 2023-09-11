using System;
using Newtonsoft.Json;
using QuaverWebApi.v1.Structures.Enums;

namespace QuaverWebApi.v1.Structures;

// /multiplayer/games/:id
public struct Match
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("time_played")]
    public DateTime TimePlayed { get; set; }

    [JsonProperty("aborted_early")]
    public bool AbortedEarly { get; set; }

    [JsonProperty("outcome")]
    public MatchOutcome Outcome { get; set; }

    [JsonProperty("rules")]
    public MatchRules Rules { get; set; }

    [JsonProperty("map")]
    public MatchMap Map { get; set; }

    [JsonProperty("most_valuable_player")]
    public MatchMostValuablePlayer MostValuablePlayer { get; set; }

    public struct MatchOutcome
    {
        [JsonProperty("result")]
        public int Result { get; set; }

        [JsonProperty("team")]
        public int Team { get; set; }
    }

    public struct MatchRules
    {
        [JsonProperty("ruleset")]
        public int Ruleset { get; set; }

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
        public int GameMode { get; set; }
    }

    public struct MatchMostValuablePlayer
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("score")]
        public MatchMostValuablePlayerScore Score { get; set; }

        public struct MatchMostValuablePlayerScore
        {
            [JsonProperty("team")]
            public int Team { get; set; }

            [JsonProperty("performance_rating")]
            public double PerformanceRating { get; set; }

            [JsonProperty("accuracy")]
            public double Accuracy { get; set; }
        }
    }
}