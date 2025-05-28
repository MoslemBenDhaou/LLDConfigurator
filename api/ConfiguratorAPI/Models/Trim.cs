using ConfiguratorAPI.Models.Enums;

namespace ConfiguratorAPI.Models;

public class Trim
{
    public string TrimCode { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string ModelCode { get; set; } = string.Empty; // Foreign key
    public Model? Model { get; set; }
    public int FiscalPower { get; set; }

    // Highlighted features
    public int Seats { get; set; }
    public int CylinderCount { get; set; }
    public int HorsePower { get; set; }
    public FuelType FuelType { get; set; }
    public TransmissionType Transmission { get; set; }
    public int MaxSpeedKph { get; set; }
    

    public string? ExtendedCharacteristicsUrl { get; set; }
    public decimal ListPrice { get; set; }
    public bool IsActive { get; set; } = true;
    
    // Additional Services
    public decimal FullInsurance0PercentPrice { get; set; } 
    public decimal FullInsurance4PercentPrice { get; set; } 
    public decimal MaintenancePackagePrice { get; set; }
    public decimal VignettesPrice => ComputeVignettesPrice();
    public int MaxDurationMonths => FiscalPower <= 5 ? 42 : 60;
    public decimal GeolocalisationPrice { get; set; } = 19.90m;
    public decimal PurchaseOptionPrice { get; set; }

    private decimal ComputeVignettesPrice()
    {
        var group = GetFiscalPowerGroup(FiscalPower);
        if (!VignettePriceTable.TryGetValue(group, out var fuelPrices))
            return 0;

        string fuelKey = GetFuelKey(FuelType);
        return fuelPrices.TryGetValue(fuelKey, out var price) ? price : 0;
    }

    private static string GetFiscalPowerGroup(int cv)
    {
        return cv switch
        {
            <= 4 => "4",
            >= 5 and <= 7 => "5-7",
            8 => "8",
            9 => "9",
            >= 10 and <= 11 => "10-11",
            >= 12 and <= 13 => "12-13",
            >= 14 and <= 15 => "14-15",
            _ => "16+"
        };
    }

    private static string GetFuelKey(FuelType type)
    {
        return type switch
        {
            FuelType.Electric => "Energie",
            FuelType.Essence => "Essence",
            FuelType.Hybrid or FuelType.PlugInHybrid or FuelType.LightHybrid => "Essence",
            FuelType.Diesel => "Diesel",
            FuelType.LPG => "LPG",
            _ => "Essence"
        };
    }

    private static readonly Dictionary<string, Dictionary<string, decimal>> VignettePriceTable = new()
    {
        ["4"] = new() { ["Essence"] = 130, ["Diesel"] = 280, ["LPG"] = 455 },
        ["5-7"] = new() { ["Essence"] = 260, ["Diesel"] = 410, ["LPG"] = 585 },
        ["8"] = new() { ["Essence"] = 360, ["Diesel"] = 510, ["LPG"] = 685 },
        ["9"] = new() { ["Essence"] = 360, ["Diesel"] = 585, ["LPG"] = 760 },
        ["10-11"] = new() { ["Essence"] = 460, ["Diesel"] = 685, ["LPG"] = 860 },
        ["12-13"] = new() { ["Essence"] = 2100, ["Diesel"] = 2325, ["LPG"] = 2500 },
        ["14-15"] = new() { ["Essence"] = 2800, ["Diesel"] = 3025, ["LPG"] = 3200 },
        ["16+"] = new() { ["Essence"] = 4200, ["Diesel"] = 4425, ["LPG"] = 4600 },
    };
}
