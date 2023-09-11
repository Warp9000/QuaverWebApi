using System;
using Newtonsoft.Json;
using QuaverWebApi.v1.Structures.Enums;

namespace QuaverWebApi.v1.Structures;

public struct Mapset
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("creator_id")]
    public int CreatorId { get; set; }

    [JsonProperty("creator_username")]
    public string CreatorUsername { get; set; }

    [JsonProperty("creator_avatar_url")]
    public string CreatorAvatarUrl { get; set; }

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

    [JsonProperty("ranking_queue_status")]
    public object RankingQueueStatus { get; set; }

    [JsonProperty("ranking_queue_last_updated")]
    public DateTime RankingQueueLastUpdated { get; set; }

    [JsonProperty("ranking_queue_vote_count")]
    public object RankingQueueVoteCount { get; set; }

    [JsonProperty("mapset_ranking_queue_id")]
    public object MapsetRankingQueueId { get; set; }

    [JsonProperty("maps")]
    public Map[] Maps { get; set; }

    public struct Map
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("mapset_id")]
        public int MapsetId { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }

        [JsonProperty("alternative_md5")]
        public string? AlternativeMd5 { get; set; }

        [JsonProperty("creator_id")]
        public int CreatorId { get; set; }

        [JsonProperty("creator_username")]
        public string CreatorUsername { get; set; }

        [JsonProperty("game_mode")]
        public GameMode GameMode { get; set; }

        [JsonProperty("ranked_status")]
        public RankedStatus RankedStatus { get; set; }

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

        [JsonProperty("mods_pending")]
        public int ModsPending { get; set; }

        [JsonProperty("mods_accepted")]
        public int ModsAccepted { get; set; }

        [JsonProperty("mods_denied")]
        public int ModsDenied { get; set; }

        [JsonProperty("mods_ignored")]
        public int ModsIgnored { get; set; }
    }
}