using System;
using Newtonsoft.Json;
using QuaverWebApi.v1.Structures.Enums;

namespace QuaverWebApi.v1.Structures;

// /users/full/:id
public struct FullUser
{
    [JsonProperty("info")]
    public UserInfo Info { get; set; }

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
            public long TotalScore { get; set; }

            [JsonProperty("ranked_score")]
            public long RankedScore { get; set; }

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

    public struct UserInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("steam_id")]
        public string SteamId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("time_registered")]
        public DateTime TimeRegistered { get; set; }

        [JsonProperty("allowed")]
        public bool Allowed { get; set; }

        [JsonProperty("privileges")]
        public Privileges Privileges { get; set; }

        [JsonProperty("usergroups")]
        public UserGroups UserGroups { get; set; }

        [JsonProperty("mute_end_time")]
        public DateTime MuteEndTime { get; set; }

        [JsonProperty("latest_activity")]
        public DateTime LatestActivity { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }
    
        [JsonProperty("userpage")]
        public string Userpage { get; set; }

        [JsonProperty("information")]
        public UserInformation Information { get; set; }

        [JsonProperty("userpage_disabled")]
        public bool UserpageDisabled { get; set; }

        [JsonProperty("clan_id")]
        public int? ClanId { get; set; }

        [JsonProperty("online")]
        public bool Online { get; set; }

        public struct UserInformation
        {
            [JsonProperty("default_mode")]
            public GameMode DefaultMode { get; set; }

            [JsonProperty("discord")]
            public string Discord { get; set; }

            [JsonProperty("twitter")]
            public string Twitter { get; set; }

            [JsonProperty("twitch")]
            public string Twitch { get; set; }

            [JsonProperty("youtube")]
            public string Youtube { get; set; }

            [JsonProperty("notif_action_mapset")]
            public bool NotifActionMapset { get; set; }
        }
    }
}