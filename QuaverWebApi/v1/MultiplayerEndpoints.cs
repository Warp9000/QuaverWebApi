using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using QuaverWebApi.v1.Structures;
using QuaverWebApi.v1.Structures.Enums;

namespace QuaverWebApi;

public partial class Endpoints
{
    public async Task<MultiplayerMatches> GetMultiplayerMatches()
    {
        return await Wrapper.GetAsync<MultiplayerMatches>("multiplayer/games", "matches");
    }

    public async Task<Match[]> GetMatches(int id)
    {
        return await Wrapper.GetAsync<Match[]>($"multiplayer/games/{id}", "matches");
    }

    /// <summary>
    ///     this function returns raw json cause im lazy
    /// </summary>
    public async Task<string> GetLiveMatch(int id)
    {
        return await Wrapper.GetAsync($"multiplayer/games/{id}/live");
    }

    public async Task<LeaderBoardUser[]> GetMultiplayerLeaderBoard(GameMode mode = GameMode.Keys4, int? page = null)
    {
        Dictionary<string, string> queryParameters = new Dictionary<string, string>();

        queryParameters.Add("mode", ((int)mode).ToString());
        if (page != null)
            queryParameters.Add("page", page.ToString()!);

        return await Wrapper.GetAsync<LeaderBoardUser[]>("multiplayer/leaderboard", "users", queryParameters);
    }

    public async Task<string> GetMultiplayerMatch(int id)
    {
        return await Wrapper.GetAsync($"multiplayer/match/{id}");
    }
}