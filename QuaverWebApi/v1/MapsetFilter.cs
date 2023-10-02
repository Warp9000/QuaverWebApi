using QuaverWebApi.v1.Structures.Enums;

namespace QuaverWebApi;

public class MapsetFilter
{
    public string? query { get; set; }
    public GameMode? mode { get; set; }
    public RankedStatus? status { get; set; }
    public int? page { get; set; }
    public int? limit { get; set; }
    public double? mindiff { get; set; }
    public double? maxdiff { get; set; }
    public float? minbpm { get; set; }
    public float? maxbpm { get; set; }
    public float? minlength { get; set; }
    public float? maxlength { get; set; }
    public int? minlns { get; set; }
    public int? maxlns { get; set; }
    public int? minplaycount { get; set; }
    public int? maxplaycount { get; set; }
    public long? mindate { get; set; }
    public long? maxdate { get; set; }
}