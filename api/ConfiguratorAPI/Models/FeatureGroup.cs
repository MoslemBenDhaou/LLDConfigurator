namespace ConfiguratorAPI.Models;

public class FeatureGroup
{
    public int Id { get; set; }
    public string TrimId { get; set; } = string.Empty;
    public string ModelId { get; set; } = string.Empty;
    public string BrandId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public List<TrimFeature> Features { get; set; } = new List<TrimFeature>();
}
