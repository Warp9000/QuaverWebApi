using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuaverWebApi.v1.Structures;
using QuaverWebApi.v1.Structures.Enums;

namespace QuaverWebApi;

public partial class Endpoints
{
    public async Task<User[]> GetUsersAsync(params int[] ids)
    {
        (string key, string value)[] queryParameters = ids.Select(id => ("id", id.ToString())).ToArray();
        return await Wrapper.GetAsync<User[]>("users", "users", queryParameters);
    }

    public async Task<FullUser> GetFullUserAsync(int id)
    {
        return await Wrapper.GetAsync<FullUser>($"users/full/{id}", "user");
    }

    public async Task<BasicUser[]> SearchUsersAsync(string username)
    {
        return await Wrapper.GetAsync<BasicUser[]>($"users/search/{username}", "users");
    }

    public async Task<UserScore[]> GetUserScoresBestAsync(int id, GameMode mode, int limit = 50, int page = 0)
    {
        (string key, string value)[] queryParameters =
        {
            ("id", id.ToString()),
            ("mode", ((int)mode).ToString()),
            ("limit", limit.ToString()),
            ("page", page.ToString())
        };

        return await Wrapper.GetAsync<UserScore[]>("users/scores/best", "scores", queryParameters);
    }

    public async Task<UserScore[]> GetUserScoresRecentAsync(int id, GameMode mode, int limit = 50, int page = 0)
    {
        (string key, string value)[] queryParameters =
        {
            ("id", id.ToString()),
            ("mode", ((int)mode).ToString()),
            ("limit", limit.ToString()),
            ("page", page.ToString())
        };

        return await Wrapper.GetAsync<UserScore[]>("users/scores/recent", "scores", queryParameters);
    }

    public async Task<UserScore[]> GetUserScoresFirstplaceAsync(int id, GameMode mode, int limit = 50, int page = 0)
    {
        (string key, string value)[] queryParameters =
        {
            ("id", id.ToString()),
            ("mode", ((int)mode).ToString()),
            ("limit", limit.ToString()),
            ("page", page.ToString())
        };

        return await Wrapper.GetAsync<UserScore[]>("users/scores/firstplace", "scores", queryParameters);
    }

    public async Task<BasicMapset[]> GetUserMapsetsAsync(int id, GameMode? mode = null, RankedStatus? status = null, int page = 0)
    {
        List<(string key, string value)> queryParameters = new()
        {
            ("id", id.ToString())
        };
        if (mode != null)
            queryParameters.Add(("mode", ((int)mode).ToString()));
        if (status != null)
            queryParameters.Add(("status", ((int)status).ToString()));
        queryParameters.Add(("page", page.ToString()));

        return await Wrapper.GetAsync<BasicMapset[]>("users/mapsets", "mapsets", queryParameters.ToArray());
    }

    public async Task<GraphStatistics[]> GetUserGraphStatisticsAsync(int id, GameMode mode)
    {
        (string key, string value)[] queryParameters =
        {
            ("id", id.ToString()),
            ("mode", ((int)mode).ToString())
        };

        return await Wrapper.GetAsync<GraphStatistics[]>("users/graph/rank", "statistics", queryParameters);
    }

    public async Task<BasicPlaylist[]> GetUserPlaylistsAsync(int id)
    {
        return await Wrapper.GetAsync<BasicPlaylist[]>($"users/playlists/{id}", "playlists");
    }

    public async Task<Achievement[]> GetUserAchievementsAsync(int id)
    {
        return await Wrapper.GetAsync<Achievement[]>($"users/achievements/{id}", "achievements");
    }
}