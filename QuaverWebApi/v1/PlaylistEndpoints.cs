using System.Collections.Generic;
using System.Threading.Tasks;
using QuaverWebApi.v1.Structures;

namespace QuaverWebApi;

public partial class Endpoints
{
    public async Task<Playlist> GetPlaylist(int id)
    {
        return await Wrapper.GetAsync<Playlist>($"playlist/{id}", "playlist");
    }

    public async Task<int[]> GetPlaylistMaps(int id)
    {
        return await Wrapper.GetAsync<int[]>($"playlist/{id}/maps", "maps");
    }

    public async Task<SearchPlaylist[]> SearchPlaylists(string? query, int? page = null)
    {
        Dictionary<string, string> queryParameters = new Dictionary<string, string>();

        if (query != null)
            queryParameters.Add("search", query!);
        if (page != null)
            queryParameters.Add("page", page.ToString()!);

        return await Wrapper.GetAsync<SearchPlaylist[]>("playlist/all/search", "playlists", queryParameters);
    }
}