using System;
using Newtonsoft.Json;

namespace QuaverWebApi.v1.Structures;

// /mapsets/queue
public struct QueueMapset
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("mapset_id")]
    public int MapsetId { get; set; }

    [JsonProperty("timestamp")]
    public DateTime Timestamp { get; set; }

    [JsonProperty("date_last_updated")]
    public DateTime DateLastUpdated { get; set; }

    [JsonProperty("status")]
    public int Status { get; set; }

    [JsonProperty("needs_attention")]
    public int NeedsAttention { get; set; }

    [JsonProperty("votes")]
    public string Votes { get; set; }

    [JsonProperty("artist")]
    public string Artist { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("creator_id")]
    public int CreatorId { get; set; }

    [JsonProperty("creator_username")]
    public string CreatorUsername { get; set; }

    [JsonProperty("date_submitted")]
    public DateTime DateSubmitted { get; set; }

    [JsonProperty("votes_count")]
    public int VotesCount { get; set; }

    [JsonProperty("difficulties")]
    public Difficulty[] Difficulties { get; set; }

    public struct Difficulty
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("game_mode")]
        public string GameMode { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("difficulty_rating")]
        public double DifficultyRating { get; set; }

        [JsonProperty("difficulty_name")]
        public string DifficultyName { get; set; }
    }
}