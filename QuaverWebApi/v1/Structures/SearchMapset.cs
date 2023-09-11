using System;
using Newtonsoft.Json;
using QuaverWebApi.v1.Structures.Enums;

namespace QuaverWebApi.v1.Structures;

//  /mapsets/maps/search
public struct SearchMapset
{
    [JsonProperty("id")]
    public int Id { get; set; }

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

    [JsonProperty("ranked_status")]
    public RankedStatus RankedStatus { get; set; }

    [JsonProperty("date_submitted")]
    public DateTime DateSubmitted { get; set; }

    [JsonProperty("date_last_updated")]
    public DateTime DateLastUpdated { get; set; }

    [JsonProperty("bpms")]
    public float[] Bpms { get; set; }

    [JsonProperty("game_modes")]
    public GameMode[] GameModes { get; set; }

    [JsonProperty("difficulty_names")]
    public string[] DifficultyNames { get; set; }

    [JsonProperty("difficulty_range")]
    public double[] DifficultyRange { get; set; }

    [JsonProperty("min_length_seconds")]
    public float MinLengthSeconds { get; set; }

    [JsonProperty("max_length_seconds")]
    public float MaxLengthSeconds { get; set; }

    [JsonProperty("min_ln_percent")]
    public float MinLnPercent { get; set; }

    [JsonProperty("max_ln_percent")]
    public float MaxLnPercent { get; set; }

    [JsonProperty("min_play_count")]
    public int MinPlayCount { get; set; }

    [JsonProperty("max_play_count")]
    public int MaxPlayCount { get; set; }

    [JsonProperty("min_date_submitted")]
    public DateTime MinDateSubmitted { get; set; }

    [JsonProperty("max_date_submitted")]
    public DateTime MaxDateSubmitted { get; set; }

    [JsonProperty("min_date_last_updated")]
    public DateTime MinDateLastUpdated { get; set; }

    [JsonProperty("max_date_last_updated")]
    public DateTime MaxDateLastUpdated { get; set; }

    [JsonProperty("min_combo")]
    public int MinCombo { get; set; }

    [JsonProperty("max_combo")]
    public int MaxCombo { get; set; }
}