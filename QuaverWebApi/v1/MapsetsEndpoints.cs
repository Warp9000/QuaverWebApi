using System.Collections.Generic;
using System.Threading.Tasks;
using QuaverWebApi.v1.Structures;
using QuaverWebApi.v1.Structures.Enums;

namespace QuaverWebApi;

public partial class Endpoints
{
    public async Task<int[]> GetRankedMapsets()
    {
        return await Wrapper.GetAsync<int[]>("mapsets/ranked", "mapsets");
    }

    public async Task<QueueMapset[]> GetQueueMapsets(GameMode mode, int page = 0)
    {
        (string key, string value)[] queryParameters =
        {
            ("mode", ((int)mode).ToString()),
            ("page", page.ToString())
        };

        return await Wrapper.GetAsync<QueueMapset[]>("mapsets/queue", "queue", queryParameters);
    }

    public async Task<Mapset> GetMapset(int id)
    {
        return await Wrapper.GetAsync<Mapset>($"mapsets/{id}", "mapset");
    }

    public async Task<SearchMapset[]> SearchMapsets(
        string? query = null,
        GameMode? mode = null,
        RankedStatus? status = null,
        int? page = null,
        int? limit = null,
        double? mindiff = null,
        double? maxdiff = null,
        float? minbpm = null,
        float? maxbpm = null,
        float? minlength = null,
        float? maxlength = null,
        int? minlns = null,
        int? maxlns = null,
        int? minplaycount = null,
        int? maxplaycount = null,
        long? mindate = null,
        long? maxdate = null)
    {
        Dictionary<string, string> queryParameters = new();

        if (query != null)
            queryParameters.Add("query", query!);
        if (mode != null)
            queryParameters.Add("mode", ((int)mode).ToString()!);
        if (status != null)
            queryParameters.Add("status", ((int)status).ToString()!);
        if (page != null)
            queryParameters.Add("page", page.ToString()!);
        if (limit != null)
            queryParameters.Add("limit", limit.ToString()!);
        if (mindiff != null)
            queryParameters.Add("mindiff", mindiff.ToString()!);
        if (maxdiff != null)
            queryParameters.Add("maxdiff", maxdiff.ToString()!);
        if (minbpm != null)
            queryParameters.Add("minbpm", minbpm.ToString()!);
        if (maxbpm != null)
            queryParameters.Add("maxbpm", maxbpm.ToString()!);
        if (minlength != null)
            queryParameters.Add("minlength", minlength.ToString()!);
        if (maxlength != null)
            queryParameters.Add("maxlength", maxlength.ToString()!);
        if (minlns != null)
            queryParameters.Add("minlns", minlns.ToString()!);
        if (maxlns != null)
            queryParameters.Add("maxlns", maxlns.ToString()!);
        if (minplaycount != null)
            queryParameters.Add("minplaycount", minplaycount.ToString()!);
        if (maxplaycount != null)
            queryParameters.Add("maxplaycount", maxplaycount.ToString()!);
        if (mindate != null)
            queryParameters.Add("mindate", mindate.ToString()!);
        if (maxdate != null)
            queryParameters.Add("maxdate", maxdate.ToString()!);

        return await Wrapper.GetAsync<SearchMapset[]>("mapsets/maps/search", "mapsets", queryParameters);
    }

    public async Task<MapsetComment[]> GetMapsetComments(int id)
    {
        return await Wrapper.GetAsync<MapsetComment[]>($"mapsets/{id}/comments", "comments");
    }
}