using System.Threading.Tasks;
using QuaverWebApi.v1.Structures;

namespace QuaverWebApi;

public partial class Endpoints
{
    public async Task DownloadMap(int id, string filename)
    {
        await Wrapper.DownloadAsync($"d/web/map/{id}", filename);
    }

    public async Task DownloadReplay(int id, string filename)
    {
        await Wrapper.DownloadAsync($"d/web/replay/{id}", filename);
    }
}