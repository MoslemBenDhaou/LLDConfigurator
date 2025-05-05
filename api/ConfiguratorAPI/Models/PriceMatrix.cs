namespace ConfiguratorAPI.Models;

public class PriceMatrix
{
    public string TrimId { get; set; } = string.Empty;
    public string ModelId { get; set; } = string.Empty;
    public string BrandId { get; set; } = string.Empty;
    public List<PricePoint> Points { get; set; } = new List<PricePoint>();
}
