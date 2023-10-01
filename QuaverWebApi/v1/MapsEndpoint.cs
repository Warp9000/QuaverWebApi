using System.Threading.Tasks;
using QuaverWebApi.v1.Structures;

namespace QuaverWebApi;

public partial class Endpoints
{
    public async Task<Map> GetMap(int id)
    {
        return await Wrapper.GetAsync<Map>($"maps/{id}", "map");
    }

    public async Task<MapMod[]> GetMapMods(int id)
    {
        return await Wrapper.GetAsync<MapMod[]>($"maps/{id}/mods", "mods");
    }
}