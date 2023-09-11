using System;
using Newtonsoft.Json;
using QuaverWebApi.v1.Structures.Enums;

namespace QuaverWebApi.v1.Structures;

// /users/mapsets/:id
public struct BasicMapset
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("package_md5")]
    public string PackageMd5 { get; set; }

    [JsonProperty("creator_id")]
    public int CreatorId { get; set; }

    [JsonProperty("creator_username")]
    public string CreatorUsername { get; set; }

    [JsonProperty("artist")]
    public string Artist { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("source")]
    public string Source { get; set; }

    [JsonProperty("tags")]
    public string Tags { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("date_submitted")]
    public DateTime DateSubmitted { get; set; }

    [JsonProperty("date_last_updated")]
    public DateTime DateLastUpdated { get; set; }

    [JsonProperty("visible")]
    public int Visible { get; set; }

    [JsonProperty("ranked_status")]
    public RankedStatus RankedStatus { get; set; }

    [JsonProperty("maps")]
    public BasicMap[] Maps { get; set; }

    public struct BasicMap
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }

        [JsonProperty("game_mode")]
        public GameMode GameMode { get; set; }

        [JsonProperty("ranked_status")]
        public RankedStatus RankedStatus { get; set; }

        [JsonProperty("difficulty_name")]
        public string DifficultyName { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("bpm")]
        public float Bpm { get; set; }

        [JsonProperty("difficulty_rating")]
        public double DifficultyRating { get; set; }

        [JsonProperty("count_hitobject_normal")]
        public int CountHitobjectNormal { get; set; }

        [JsonProperty("count_hitobject_long")]
        public int CountHitobjectLong { get; set; }

        [JsonProperty("play_count")]
        public int PlayCount { get; set; }

        [JsonProperty("fail_count")]
        public int FailCount { get; set; }
    }
}