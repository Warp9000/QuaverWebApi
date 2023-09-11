using System;
using Newtonsoft.Json;
using QuaverWebApi.v1.Structures.Enums;

namespace QuaverWebApi.v1.Structures;

// /leaderboard
// /leaderboard/hits
public struct LeaderBoardUser
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("steam_id")]
    public string SteamId { get; set; }

    [JsonProperty("username")]
    public string Username { get; set; }

    [JsonProperty("country")]
    public string Country { get; set; }

    [JsonProperty("allowed")]
    public bool Allowed { get; set; }

    [JsonProperty("privileges")]
    public Privileges Privileges { get; set; }

    [JsonProperty("usergroups")]
    public UserGroups UserGroups { get; set; }

    [JsonProperty("avatar_url")]
    public string AvatarUrl { get; set; }

    [JsonProperty("time_registered")]
    public DateTime TimeRegistered { get; set; }

    [JsonProperty("latest_activity")]
    public DateTime LatestActivity { get; set; }

    [JsonProperty("stats")]
    public LeaderBoardUserStats Stats { get; set; }

    public struct LeaderBoardUserStats
    {
        [JsonProperty("rank")]
        public int Rank { get; set; }

        #region rating
        [JsonProperty("ranked_score")]
        public long RankedScore { get; set; }

        [JsonProperty("overall_accuracy")]
        public double OverallAccuracy { get; set; }

        [JsonProperty("overall_performance_rating")]
        public double OverallPerformanceRating { get; set; }

        [JsonProperty("play_count")]
        public int PlayCount { get; set; }

        [JsonProperty("max_combo")]
        public int MaxCombo { get; set; }
        #endregion

        #region hits
        [JsonProperty("total_hits")]
        public int TotalHits { get; set; }

        [JsonProperty("total_ranked_plays")]
        public int TotalRankedPlays { get; set; }

        [JsonProperty("total_ranked_failures")]
        public int TotalRankedFailures { get; set; }
        #endregion

        #region multiplayer
        [JsonProperty("multiplayer_wins")]
        public int MultiplayerWins { get; set; }

        [JsonProperty("multiplayer_losses")]
        public int MultiplayerLosses { get; set; }

        [JsonProperty("multiplayer_ties")]
        public int MultiplayerTies { get; set; }
        #endregion
    }
}