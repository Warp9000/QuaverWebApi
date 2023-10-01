using System.Collections.Generic;
using System.Threading.Tasks;
using QuaverWebApi.v1.Structures;
using QuaverWebApi.v1.Structures.Enums;

namespace QuaverWebApi;

public partial class Endpoints
{
    public async Task<LeaderBoardUser[]> GetLeaderboard(GameMode mode = GameMode.Keys4, string? country = null, int? page = null)
    {
        Dictionary<string, string> parameters = new Dictionary<string, string>();

        if (country != null)
            parameters.Add("country", country!);
        if (page != null)
            parameters.Add("page", page.ToString()!);

        return await Wrapper.GetAsync<LeaderBoardUser[]>($"leaderboard/{mode}", "users", parameters);
    }

    public async Task<LeaderBoardUser[]> GetHitsLeaderboard(int? page = null)
    {
        Dictionary<string, string> parameters = new Dictionary<string, string>();

        if (page != null)
            parameters.Add("page", page.ToString()!);

        return await Wrapper.GetAsync<LeaderBoardUser[]>("leaderboard/hits", "users", parameters);
    }
}