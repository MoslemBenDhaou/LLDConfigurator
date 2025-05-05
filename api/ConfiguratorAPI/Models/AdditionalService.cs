namespace ConfiguratorAPI.Models;

public enum ServiceType
{
    FullInsurance0Percent,
    FullInsurance4Percent,
    RoadAssistance,
    MaintenancePackage,
    Vignettes,
    Geolocalisation,
    PurchaseOption
}

public class AdditionalService
{
    public int Id { get; set; }
    public string TrimId { get; set; } = string.Empty;
    public string ModelId { get; set; } = string.Empty;
    public string BrandId { get; set; } = string.Empty;
    public ServiceType Type { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public bool IsPercentage { get; set; }
    public bool IsRequired { get; set; }
    public bool IsDefault { get; set; }
}
