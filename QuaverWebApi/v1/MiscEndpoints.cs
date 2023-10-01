using System.Collections.Generic;
using System.Threading.Tasks;
using QuaverWebApi.v1.Structures;

namespace QuaverWebApi;

public partial class Endpoints
{
    public async Task<Team> GetTeam()
    {
        return await Wrapper.GetAsync<Team>("team", "team");
    }

    public async Task<Stats> GetStats()
    {
        return await Wrapper.GetAsync<Stats>("stats", "stats");
    }

    public async Task<Dictionary<string, int>> GetCountryStats()
    {
        return await Wrapper.GetAsync<Dictionary<string, int>>("stats/country", "countries");
    }
}