namespace ConfiguratorAPI.Models;

public class Trim
{
    public string Id { get; set; } = string.Empty;
    public string ModelId { get; set; } = string.Empty;
    public string BrandId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public List<string> Features { get; set; } = new List<string>();
    public string FeaturesJson { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public decimal ListPrice { get; set; }
    public bool IsActive { get; set; } = true;
    
    // Additional Services
    public decimal FullInsurance0PercentPrice { get; set; } // 8% of base price
    public decimal FullInsurance4PercentPrice { get; set; } // 6% of base price
    public decimal StandardInsurancePrice { get; set; } = 15.99m; // Renamed from RoadAssistancePrice
    public decimal MaintenancePackagePrice { get; set; } = 49.99m;
    public decimal VignettesPrice { get; set; } = 29.99m;
    public decimal GeolocalisationPrice { get; set; } = 19.90m;
    public decimal PurchaseOptionPrice { get; set; } // 40% of list price
}
