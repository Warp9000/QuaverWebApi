using System;
using Newtonsoft.Json;
using QuaverWebApi.v1.Structures.Enums;

namespace QuaverWebApi.v1.Structures;

// /scores/map/:id
public struct Score
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("map_md5")]
    public string MapMd5 { get; set; }

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

    [JsonProperty("user")]
    public BasicUser User { get; set; }

    public struct BasicUser
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("username")]
    public string Username { get; set; }

    [JsonProperty("steam_id")]
    public string SteamId { get; set; }

    [JsonProperty("country")]
    public string Country { get; set; }

    [JsonProperty("privileges")]
    public Privileges Privileges { get; set; }

    [JsonProperty("usergroups")]
    public UserGroups UserGroups { get; set; }

    [JsonProperty("time_registered")]
    public DateTime TimeRegistered { get; set; }

    [JsonProperty("latest_activity")]
    public DateTime LatestActivity { get; set; }

    [JsonProperty("avatar_url")]
    public string AvatarUrl { get; set; }
}
}
