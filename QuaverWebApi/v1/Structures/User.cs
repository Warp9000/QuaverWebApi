using System;
using Newtonsoft.Json;
using QuaverWebApi.v1.Structures.Enums;

namespace QuaverWebApi.v1.Structures;

// /users
public struct User
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
}