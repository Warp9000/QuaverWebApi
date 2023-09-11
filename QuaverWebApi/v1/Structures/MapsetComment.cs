using System;
using Newtonsoft.Json;
using QuaverWebApi.v1.Structures.Enums;

namespace QuaverWebApi.v1.Structures;

// /mapsets/:id/comments
public struct MapsetComment
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("mapset_id")]
    public int MapsetId { get; set; }

    [JsonProperty("timestamp")]
    public DateTime Timestamp { get; set; }

    [JsonProperty("comment")]
    public string Comment { get; set; }

    [JsonProperty("user")]
    public BasicUser User { get; set; }

    public struct BasicUser
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("privileges")]
        public Privileges Privileges { get; set; }

        [JsonProperty("usergroups")]
        public UserGroups UserGroups { get; set; }
    }
}