using System;
using Newtonsoft.Json;
using QuaverWebApi.v1.Structures.Enums;

namespace QuaverWebApi.v1.Structures;

// /users/scores/best
// /users/scores/recent
// /users/scores/firstplace
public struct UserScore
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("time")]
    public DateTime Time { get; set; }

    [JsonProperty("mode")]
    public GameMode Mode { get; set; }

    [JsonProperty("mods")]
    public ModIdentifier Mods { get; set; }

    [JsonProperty("mods_string")]
    public string ModsString { get; set; }

    [JsonProperty("performance_rating")]
    public double PerformanceRating { get; set; }

    [JsonProperty("personal_best")]
    public bool PersonalBest { get; set; }

    [JsonProperty("total_score")]
    public int TotalScore { get; set; }

    [JsonProperty("accuracy")]
    public double Accuracy { get; set; }

    [JsonProperty("grade")]
    public Grade Grade { get; set; }

    [JsonProperty("max_combo")]
    public int MaxCombo { get; set; }

    [JsonProperty("count_marv")]
    public int CountMarv { get; set; }

    [JsonProperty("count_perf")]
    public int CountPerf { get; set; }

    [JsonProperty("count_great")]
    public int CountGreat { get; set; }

    [JsonProperty("count_good")]
    public int CountGood { get; set; }

    [JsonProperty("count_okay")]
    public int CountOkay { get; set; }

    [JsonProperty("count_miss")]
    public int CountMiss { get; set; }

    [JsonProperty("scroll_speed")]
    public int ScrollSpeed { get; set; }

    [JsonProperty("tournament_game_id")]
    public int TournamentGameId { get; set; }

    [JsonProperty("ratio")]
    public double Ratio { get; set; }

    [JsonProperty("map")]
    public BasicMap Map { get; set; }

    public struct BasicMap
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("mapset_id")]
        public int MapsetId { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("difficulty_name")]
        public string DifficultyName { get; set; }

        [JsonProperty("creator_id")]
        public int CreatorId { get; set; }

        [JsonProperty("creator_username")]
        public string CreatorUsername { get; set; }

        [JsonProperty("ranked_status")]
        public int RankedStatus { get; set; }
    }
}
