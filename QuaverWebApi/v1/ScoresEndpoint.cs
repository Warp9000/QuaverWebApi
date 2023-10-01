using System.Threading.Tasks;
using QuaverWebApi.v1.Structures;

namespace QuaverWebApi;

public partial class Endpoints
{
    public async Task<Score[]> GetMapScores(int id)
    {
        return await Wrapper.GetAsync<Score[]>($"maps/{id}/scores", "scores");
    }

    public async Task<string[]> GetScoreHitData(int id)
    {
        return await Wrapper.GetAsync<string[]>($"scores/data/{id}", "hits");
    }
}