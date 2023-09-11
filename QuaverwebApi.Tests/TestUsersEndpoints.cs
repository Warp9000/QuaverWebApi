using System;
using System.Linq;
using Newtonsoft.Json;
using QuaverWebApi;
using QuaverWebApi.v1.Structures.Enums;
using Xunit;

namespace QuaverwebApi.Tests;

public class TestUsersEndpoints
{
    [Fact]
    public void TestGetUsers()
    {
        var wrapper = new Wrapper();
        var users = wrapper.Endpoints.GetUsersAsync(1, 2).Result;
        Assert.Equal(2, users.Length);

        var user1 = users.Where(user => user.Id == 1).First();
        Assert.Equal("Swan", user1.Username);
        Assert.Equal(1, user1.Id);
        Assert.Equal("76561198162013525", user1.SteamId);
        Assert.Equal("UM", user1.Country);

        var user2 = users.Where(user => user.Id == 2).First();
        Assert.Equal("QuaverBot", user2.Username);
        Assert.Equal(2, user2.Id);
        Assert.Equal("1", user2.SteamId);
        Assert.Equal("US", user2.Country);
    }

    [Fact]
    public void TestGetFullUser()
    {
        var wrapper = new Wrapper();
        var user = wrapper.Endpoints.GetFullUserAsync(1).Result;
        Assert.Equal("Swan", user.Info.Username);
        Assert.Equal(1, user.Info.Id);
        Assert.Equal("76561198162013525", user.Info.SteamId);
        Assert.Equal("UM", user.Info.Country);
        Assert.Contains("Donator", user.ProfileBadges.Select(badge => badge.Name));
        Assert.NotEqual(0, user.Keys4.GlobalRank);
    }

    [Fact]
    public void TestSearchUsers()
    {
        var wrapper = new Wrapper();
        var users = wrapper.Endpoints.SearchUsersAsync("Swan").Result;
        Assert.True(users.Length > 0);

        var user = users.Where(user => user.Id == 1).First();
        Assert.Equal("Swan", user.Username);
        Assert.Equal(1, user.Id);
        Assert.Equal("76561198162013525", user.SteamId);
    }

    [Fact]
    public void TestetUserScoresBest()
    {
        var wrapper = new Wrapper();
        var scores = wrapper.Endpoints.GetUserScoresBestAsync(1, GameMode.Keys4).Result;
        Assert.True(scores.Length > 0);

        var score = scores.First();
        Assert.True(score.Accuracy > 0);
    }

    [Fact]
    public void TestGetUserScoresRecent()
    {
        var wrapper = new Wrapper();
        var scores = wrapper.Endpoints.GetUserScoresRecentAsync(1, GameMode.Keys4).Result;
        Assert.True(scores.Length > 0);

        var score = scores.First();
        Assert.True(score.Accuracy > 0);
    }

    [Fact]
    public void TestGetUserScoresFirstplace()
    {
        var wrapper = new Wrapper();
        var scores = wrapper.Endpoints.GetUserScoresFirstplaceAsync(1, GameMode.Keys4).Result;
        Assert.True(scores.Length > 0);

        var score = scores.First();
        Assert.True(score.Accuracy > 0);
    }

    [Fact]
    public void TestGetUserMapsets()
    {
        var wrapper = new Wrapper();
        var mapsets = wrapper.Endpoints.GetUserMapsetsAsync(1).Result;
        Assert.True(mapsets.Length > 0);

        var mapset = mapsets.First();
        Assert.True(mapset.Id > 0);
    }

    [Fact]
    public void TestGetUserGraphStatistics()
    {
        var wrapper = new Wrapper();
        var graphStatistics = wrapper.Endpoints.GetUserGraphStatisticsAsync(1, GameMode.Keys4).Result;
        Assert.True(graphStatistics.Length > 0);

        var graphStatistic = graphStatistics.First();
        Assert.True(graphStatistic.Rank > 0);
        Assert.True(graphStatistic.Timestamp.Year == DateTime.UtcNow.Year);
    }

    [Fact]
    public void TestGetUserPlaylists()
    {
        var wrapper = new Wrapper();
        var playlists = wrapper.Endpoints.GetUserPlaylistsAsync(1).Result;
        Assert.True(playlists.Length > 0);

        var playlist = playlists.First();
        Assert.True(playlist.Id > 0);
        Assert.True(playlist.MapCount > 0);
    }

    [Fact]
    public void TestGetUserAchievements()
    {
        var wrapper = new Wrapper();
        var achievements = wrapper.Endpoints.GetUserAchievementsAsync(1).Result;
        Assert.True(achievements.Length > 0);

        var achievement = achievements.First();
        Assert.True(achievement.Id > 0);
    }
}