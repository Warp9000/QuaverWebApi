using System;
using Newtonsoft.Json;
using QuaverWebApi.v1.Structures.Enums;

namespace QuaverWebApi.v1.Structures;

// /maps/:id/mods
public class MapMod
{
    [JsonProperty("author")]
    public ModAuthor Author { get; set; }

    [JsonProperty("mod")]
    public ModMod Mod { get; set; }

    public struct ModAuthor
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("steam_id")]
        public string SteamId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("privileges")]
        public Privileges Privileges { get; set; }

        [JsonProperty("usergroups")]
        public UserGroups UserGroups { get; set; }
    }

    public struct ModMod
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("map_id")]
        public int MapId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("map_timestamp")]
        public string? MapTimestamp { get; set; }

        [JsonProperty("map_timestamp_readable")]
        public string? MapTimestampReadable { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("replies")]
        public ModReply[] Replies { get; set; }

        public struct ModReply
        {
            [JsonProperty("author")]
            public ModAuthor Author { get; set; }

            [JsonProperty("message")]
            public ModMessage Message { get; set; }

            public struct ModMessage
            {
                [JsonProperty("id")]
                public int Id { get; set; }

                [JsonProperty("timestamp")]
                public DateTime Timestamp { get; set; }

                [JsonProperty("comment")]
                public string Comment { get; set; }

                [JsonProperty("spam")]
                public bool Spam { get; set; }
            }
        }
    }
}