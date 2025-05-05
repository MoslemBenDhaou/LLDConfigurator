namespace ConfiguratorAPI.Models;

public class PricePoint
{
    public string TrimId { get; set; } = string.Empty;
    public string ModelId { get; set; } = string.Empty;
    public string BrandId { get; set; } = string.Empty;
    public int Duration { get; set; }
    public int Kilometers { get; set; }
    public AdvancePaymentPrices Prices { get; set; } = new AdvancePaymentPrices();
}
