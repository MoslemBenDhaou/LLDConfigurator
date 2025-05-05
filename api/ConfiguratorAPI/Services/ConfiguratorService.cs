using ConfiguratorAPI.Models;
using Microsoft.EntityFrameworkCore;
using ConfiguratorAPI.Data;

namespace ConfiguratorAPI.Services;

public interface IConfiguratorService
{
    Task<List<Brand>> GetBrandsAsync();
    Task<List<Model>> GetModelsByBrandAsync(string brandId);
    Task<List<Trim>> GetTrimsByBrandAndModelAsync(string brandId, string modelId);
    Task<List<PricePoint>> GetPricingAsync(string brandId, string modelId, string trimId);
    Task<List<FeatureGroup>> GetFeaturesAsync(string brandId, string modelId, string trimId);
}

public class ConfiguratorService : IConfiguratorService
{
    private readonly ILogger<ConfiguratorService> _logger;
    private readonly ConfiguratorDbContext _dbContext;

    public ConfiguratorService(ILogger<ConfiguratorService> logger, ConfiguratorDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    public async Task<List<Brand>> GetBrandsAsync()
    {
        // In a real implementation, this would come from a database or external service
        // For now, we'll return hard-coded data
        _logger.LogInformation("Getting all brands");
        
        return new List<Brand>
        {
            new Brand { Id = "alfaromeo", Name = "Alfa Romeo", Logo = "/brands/alfaromeo.webp", IsActive = true },
            new Brand { Id = "audi", Name = "Audi", Logo = "/brands/audi.webp", IsActive = true },
            new Brand { Id = "bmw", Name = "BMW", Logo = "/brands/bmw.webp", IsActive = true },
            new Brand { Id = "mercedes", Name = "Mercedes", Logo = "/brands/mercedes.webp", IsActive = true }
        };
    }

    public async Task<List<Model>> GetModelsByBrandAsync(string brandId)
    {
        _logger.LogInformation("Getting models for brand: {BrandId}", brandId);
        
        if (brandId == "alfaromeo")
        {
            return new List<Model>
            {
                new Model { Id = "giulia", BrandId = brandId, Name = "Giulia", Image = "/models/alfaromeo/giulia.webp", IsActive = true },
                new Model { Id = "stelvio", BrandId = brandId, Name = "Stelvio", Image = "/models/alfaromeo/stelvio.webp", IsActive = true }
            };
        }
        else if (brandId == "audi")
        {
            return new List<Model>
            {
                new Model { Id = "a3-berline", BrandId = brandId, Name = "A3 Berline", Image = "/models/audi/a3-berline.webp", IsActive = true },
                new Model { Id = "q2", BrandId = brandId, Name = "Q2", Image = "/models/audi/q2.webp", IsActive = true },
                new Model { Id = "q3", BrandId = brandId, Name = "Q3", Image = "/models/audi/q3.webp", IsActive = true },
                new Model { Id = "q3-sportback", BrandId = brandId, Name = "Q3 Sportback", Image = "/models/audi/q3-sportback.webp", IsActive = true },
                new Model { Id = "q8-e-tron", BrandId = brandId, Name = "Q8 e-tron", Image = "/models/audi/q8-e-tron.webp", IsActive = true },
                new Model { Id = "q8-sportback-e-tron", BrandId = brandId, Name = "Q8 Sportback e-tron", Image = "/models/audi/q8-sportback-e-tron.webp", IsActive = true },
                new Model { Id = "e-tron-gt", BrandId = brandId, Name = "e-tron GT", Image = "/models/audi/e-tron-gt.webp", IsActive = true },
                new Model { Id = "q7", BrandId = brandId, Name = "Q7", Image = "/models/audi/q7.webp", IsActive = true },
                new Model { Id = "q8", BrandId = brandId, Name = "Q8", Image = "/models/audi/q8.webp", IsActive = true }
            };
        }

        // Return empty list for other brands
        return new List<Model>();
    }

    public async Task<List<Trim>> GetTrimsByBrandAndModelAsync(string brandId, string modelId)
    {
        _logger.LogInformation("Getting trims for brand: {BrandId}, model: {ModelId}", brandId, modelId);
        
        if (brandId == "alfaromeo" && modelId == "giulia")
        {
            return new List<Trim>
            {
                new Trim 
                { 
                    Id = "2.0-turbo-super-bva", 
                    BrandId = brandId,
                    ModelId = modelId,
                    Name = "2.0 Turbo Super BVA",
                    Features = new List<string>
                    {
                        "2.0L Turbo Engine",
                        "8-Speed Automatic Transmission",
                        "Rear-Wheel Drive",
                        "Leather Interior",
                        "Dual-Zone Climate Control",
                        "Infotainment System with Navigation",
                        "Parking Sensors",
                        "Cruise Control"
                    },
                    Price = 449,
                    ListPrice = 198000,
                    IsActive = true,
                    FullInsurance0PercentPrice = 35.92m, 
                    FullInsurance4PercentPrice = 26.94m, 
                    StandardInsurancePrice = 15.99m,
                    MaintenancePackagePrice = 49.99m,
                    VignettesPrice = 29.99m,
                    GeolocalisationPrice = 19.90m,
                    PurchaseOptionPrice = 79200.00m 
                }
            };
        }
        else if (brandId == "audi" && modelId == "a3-berline")
        {
            return new List<Trim>
            {
                new Trim
                {
                    Id = "35-tfsi-business-extended",
                    BrandId = brandId,
                    ModelId = modelId,
                    Name = "35 TFSI Business Extended",
                    Features = new List<string>
                    {
                        "1.5L TFSI Engine",
                        "150 ch",
                        "Manual 6-Speed Transmission",
                        "Front-Wheel Drive",
                        "MMI Navigation System",
                        "Audi Virtual Cockpit",
                        "Dual-Zone Climate Control",
                        "Parking Sensors"
                    },
                    Price = 349,
                    ListPrice = 145000,
                    IsActive = true,
                    FullInsurance0PercentPrice = 27.92m, 
                    FullInsurance4PercentPrice = 20.94m, 
                    StandardInsurancePrice = 15.99m,
                    MaintenancePackagePrice = 49.99m,
                    VignettesPrice = 29.99m,
                    GeolocalisationPrice = 19.90m,
                    PurchaseOptionPrice = 58000.00m 
                }
            };
        }
        else if (brandId == "audi" && modelId == "q2")
        {
            return new List<Trim>
            {
                new Trim
                {
                    Id = "35-tfsi-s-line-bva",
                    BrandId = brandId,
                    ModelId = modelId,
                    Name = "35 TFSI S Line BVA",
                    Features = new List<string>
                    {
                        "1.5L TFSI Engine",
                        "150 ch",
                        "Automatic 7-Speed Transmission",
                        "Front-Wheel Drive",
                        "S Line Package",
                        "MMI Navigation System",
                        "Audi Virtual Cockpit",
                        "LED Headlights"
                    },
                    Price = 399,
                    ListPrice = 155000,
                    IsActive = true,
                    FullInsurance0PercentPrice = 31.92m, 
                    FullInsurance4PercentPrice = 23.94m, 
                    StandardInsurancePrice = 15.99m,
                    MaintenancePackagePrice = 49.99m,
                    VignettesPrice = 29.99m,
                    GeolocalisationPrice = 19.90m,
                    PurchaseOptionPrice = 62000.00m 
                }
            };
        }

        // Return default trims for other models
        return new List<Trim>
        {
            new Trim 
            { 
                Id = "basic", 
                BrandId = brandId,
                ModelId = modelId,
                Name = "Basic", 
                Features = new List<string> 
                { 
                    "Air Conditioning", 
                    "Power Windows", 
                    "Bluetooth"
                },
                Price = 299,
                ListPrice = 32000,
                IsActive = true,
                FullInsurance0PercentPrice = 23.92m, 
                FullInsurance4PercentPrice = 17.94m, 
                StandardInsurancePrice = 15.99m,
                MaintenancePackagePrice = 49.99m,
                VignettesPrice = 29.99m,
                GeolocalisationPrice = 19.90m,
                PurchaseOptionPrice = 12800.00m 
            },
            new Trim 
            { 
                Id = "comfort", 
                BrandId = brandId,
                ModelId = modelId,
                Name = "Comfort", 
                Features = new List<string> 
                { 
                    "Air Conditioning", 
                    "Power Windows", 
                    "Bluetooth", 
                    "Parking Sensors", 
                    "Cruise Control"
                },
                Price = 349,
                ListPrice = 38000,
                IsActive = true,
                FullInsurance0PercentPrice = 27.92m, 
                FullInsurance4PercentPrice = 20.94m, 
                StandardInsurancePrice = 15.99m,
                MaintenancePackagePrice = 49.99m,
                VignettesPrice = 29.99m,
                GeolocalisationPrice = 19.90m,
                PurchaseOptionPrice = 15200.00m 
            },
            new Trim 
            { 
                Id = "premium", 
                BrandId = brandId,
                ModelId = modelId,
                Name = "Premium", 
                Features = new List<string> 
                { 
                    "Air Conditioning", 
                    "Power Windows", 
                    "Bluetooth", 
                    "Parking Sensors", 
                    "Cruise Control", 
                    "Leather Seats", 
                    "Navigation System"
                },
                Price = 399,
                ListPrice = 45000,
                IsActive = true,
                FullInsurance0PercentPrice = 31.92m, 
                FullInsurance4PercentPrice = 23.94m, 
                StandardInsurancePrice = 15.99m,
                MaintenancePackagePrice = 49.99m,
                VignettesPrice = 29.99m,
                GeolocalisationPrice = 19.90m,
                PurchaseOptionPrice = 18000.00m 
            }
        };
    }

    public async Task<List<PricePoint>> GetPricingAsync(string brandId, string modelId, string trimId)
    {
        _logger.LogInformation("Getting pricing for brand: {BrandId}, model: {ModelId}, trim: {TrimId}", brandId, modelId, trimId);
        
        // Sample pricing data - in a real implementation, this would come from a database or service
        return new List<PricePoint>
        {
            new PricePoint 
            { 
                TrimId = trimId,
                ModelId = modelId,
                BrandId = brandId,
                Duration = 12, 
                Kilometers = 10000, 
                Prices = new AdvancePaymentPrices { Advance0 = 399, Advance10 = 379, Advance20 = 359, Advance30 = 339 } 
            },
            new PricePoint 
            { 
                TrimId = trimId,
                ModelId = modelId,
                BrandId = brandId,
                Duration = 12, 
                Kilometers = 15000, 
                Prices = new AdvancePaymentPrices { Advance0 = 419, Advance10 = 399, Advance20 = 379, Advance30 = 359 } 
            },
            new PricePoint 
            { 
                TrimId = trimId,
                ModelId = modelId,
                BrandId = brandId,
                Duration = 24, 
                Kilometers = 10000, 
                Prices = new AdvancePaymentPrices { Advance0 = 379, Advance10 = 359, Advance20 = 339, Advance30 = 319 } 
            },
            new PricePoint 
            { 
                TrimId = trimId,
                ModelId = modelId,
                BrandId = brandId,
                Duration = 24, 
                Kilometers = 15000, 
                Prices = new AdvancePaymentPrices { Advance0 = 399, Advance10 = 379, Advance20 = 359, Advance30 = 339 } 
            },
            new PricePoint 
            { 
                TrimId = trimId,
                ModelId = modelId,
                BrandId = brandId,
                Duration = 36, 
                Kilometers = 10000, 
                Prices = new AdvancePaymentPrices { Advance0 = 359, Advance10 = 339, Advance20 = 319, Advance30 = 299 } 
            },
            new PricePoint 
            { 
                TrimId = trimId,
                ModelId = modelId,
                BrandId = brandId,
                Duration = 36, 
                Kilometers = 15000, 
                Prices = new AdvancePaymentPrices { Advance0 = 379, Advance10 = 359, Advance20 = 339, Advance30 = 319 } 
            }
        };
    }

    public Task<List<FeatureGroup>> GetFeaturesAsync(string brandId, string modelId, string trimId)
    {
        throw new NotImplementedException();
    }

}
