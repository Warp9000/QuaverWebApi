using System;
using Newtonsoft.Json;

namespace QuaverWebApi.v1.Structures;

// /users/full/:id
public struct FullUser
{
    [JsonProperty("info")]
    public User Info { get; set; }

    [JsonProperty("profile_badges")]
    public ProfileBadge[] ProfileBadges { get; set; }

    [JsonProperty("activity_feed")]
    public Activity[] ActivityFeed { get; set; }

    [JsonProperty("keys4")]
    public Keys Keys4 { get; set; }

    [JsonProperty("keys7")]
    public Keys Keys7 { get; set; }

    public struct ProfileBadge
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public struct Activity
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("map")]
        public object Map { get; set; }

        public struct ActivityMap
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }
    }

    public struct Keys
    {
        [JsonProperty("globalRank")]
        public int GlobalRank { get; set; }

        [JsonProperty("countryRank")]
        public int CountryRank { get; set; }

        [JsonProperty("multiplayerWinRank")]
        public int MultiplayerWinRank { get; set; }

        [JsonProperty("stats")]
        public Stat Stats { get; set; }

        public struct Stat
        {
            [JsonProperty("user_id")]
            public int UserId { get; set; }

            [JsonProperty("total_score")]
            public int TotalScore { get; set; }

            [JsonProperty("ranked_score")]
            public int RankedScore { get; set; }

            [JsonProperty("overall_accuracy")]
            public double OverallAccuracy { get; set; }

            [JsonProperty("overall_performance_rating")]
            public double OverallPerformanceRating { get; set; }

            [JsonProperty("play_count")]
            public int PlayCount { get; set; }

            [JsonProperty("fail_count")]
            public int FailCount { get; set; }

            [JsonProperty("max_combo")]
            public int MaxCombo { get; set; }

            [JsonProperty("replays_watched")]
            public int ReplaysWatched { get; set; }

            [JsonProperty("total_marv")]
            public int TotalMarv { get; set; }

            [JsonProperty("total_perf")]
            public int TotalPerf { get; set; }

            [JsonProperty("total_great")]
            public int TotalGreat { get; set; }

            [JsonProperty("total_good")]
            public int TotalGood { get; set; }

            [JsonProperty("total_okay")]
            public int TotalOkay { get; set; }

            [JsonProperty("total_miss")]
            public int TotalMiss { get; set; }

            [JsonProperty("total_pauses")]
            public int TotalPauses { get; set; }

            [JsonProperty("multiplayer_wins")]
            public int MultiplayerWins { get; set; }

            [JsonProperty("multiplayer_losses")]
            public int MultiplayerLosses { get; set; }

            [JsonProperty("multiplayer_ties")]
            public int MultiplayerTies { get; set; }
        }
    }
}