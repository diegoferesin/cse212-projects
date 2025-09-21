public class FeatureCollection
{
    public string Type { get; set; } = "";
    public Metadata Metadata { get; set; } = new Metadata();
    public List<Feature> Features { get; set; } = new List<Feature>();
}

public class Metadata
{
    public long Generated { get; set; }
    public string Url { get; set; } = "";
    public string Title { get; set; } = "";
    public int Status { get; set; }
    public string Api { get; set; } = "";
    public int Count { get; set; }
}

public class Feature
{
    public string Type { get; set; } = "";
    public Properties Properties { get; set; } = new Properties();
    public Geometry Geometry { get; set; } = new Geometry();
    public string Id { get; set; } = "";
}

public class Properties
{
    public double? Mag { get; set; }
    public string? Place { get; set; }
    public long? Time { get; set; }
    public long? Updated { get; set; }
    public string? Url { get; set; }
    public string? Detail { get; set; }
    public object? Felt { get; set; }
    public object? Cdi { get; set; }
    public object? Mmi { get; set; }
    public string? Alert { get; set; }
    public string? Status { get; set; }
    public int? Tsunami { get; set; }
    public int? Sig { get; set; }
    public string? Net { get; set; }
    public string? Code { get; set; }
    public string? Ids { get; set; }
    public string? Sources { get; set; }
    public string? Types { get; set; }
    public object? Nst { get; set; }
    public double? Dmin { get; set; }
    public double? Rms { get; set; }
    public double? Gap { get; set; }
    public string? MagType { get; set; }
    public string? Type { get; set; }
    public string? Title { get; set; }
}

public class Geometry
{
    public string Type { get; set; } = "";
    public List<double> Coordinates { get; set; } = new List<double>();
}