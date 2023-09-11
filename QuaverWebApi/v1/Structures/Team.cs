using System.Collections.Generic;
using Newtonsoft.Json;
using QuaverWebApi.v1.Structures.Enums;

namespace QuaverWebApi.v1.Structures;

// /team
public struct Team
{
    [JsonProperty("developers")]
    public List<TeamMember> Developers { get; set; }

    [JsonProperty("admins")]
    public List<TeamMember> Admins { get; set; }

    [JsonProperty("moderators")]
    public List<TeamMember> Moderators { get; set; }

    [JsonProperty("rankingSupervisors")]
    public List<TeamMember> RankingSupervisors { get; set; }

    public struct TeamMember
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("steam_id")]
        public string SteamId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("usergroups")]
        public UserGroups UserGroups { get; set; }

        [JsonProperty("privileges")]
        public Privileges Privileges { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("github")]
        public string Github { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}