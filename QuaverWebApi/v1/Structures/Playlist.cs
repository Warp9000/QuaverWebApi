using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using QuaverWebApi.v1.Structures.Enums;

namespace QuaverWebApi.v1.Structures;

// /playlist/:id
public struct Playlist
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("user_id")]
    public int UserId { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("like_count")]
    public int LikeCount { get; set; }

    [JsonProperty("map_count")]
    public int MapCount { get; set; }

    [JsonProperty("time_created")]
    public DateTime TimeCreated { get; set; }

    [JsonProperty("time_last_updated")]
    public DateTime TimeLastUpdated { get; set; }

    [JsonProperty("owner_id")]
    public int OwnerId { get; set; }

    [JsonProperty("owner_username")]
    public string OwnerUsername { get; set; }

    [JsonProperty("maps")]
    public List<PlaylistMap> Maps { get; set; }

    public struct PlaylistMap
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("mapset_id")]
        public int MapsetId { get; set; }

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

        [JsonProperty("difficulty_name")]
        public string DifficultyName { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("difficulty_rating")]
        public double DifficultyRating { get; set; }

        [JsonProperty("play_count")]
        public int PlayCount { get; set; }

        [JsonProperty("fail_count")]
        public int FailCount { get; set; }
    }
}