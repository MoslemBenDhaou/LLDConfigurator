namespace ConfiguratorAPI.Models;

public class TrimFeature
{
    public int Id { get; set; }
    public int FeatureGroupId { get; set; }
    public string TrimId { get; set; } = string.Empty;
    public string ModelId { get; set; } = string.Empty;
    public string BrandId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
}
