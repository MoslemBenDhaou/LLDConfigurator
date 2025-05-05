using Microsoft.AspNetCore.Mvc;
using ConfiguratorAPI.Services;
using ConfiguratorAPI.Models;

namespace ConfiguratorAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConfiguratorController : ControllerBase
{
    private readonly ILogger<ConfiguratorController> _logger;
    private readonly IConfiguratorService _configuratorService;

    public ConfiguratorController(
        ILogger<ConfiguratorController> logger,
        IConfiguratorService configuratorService)
    {
        _logger = logger;
        _configuratorService = configuratorService;
    }

    [HttpGet("brands")]
    public async Task<IActionResult> GetBrands()
    {
        var brands = await _configuratorService.GetBrandsAsync();
        return Ok(brands);
    }

    [HttpGet("models/{brandId}")]
    public async Task<IActionResult> GetModels(string brandId)
    {
        var models = await _configuratorService.GetModelsByBrandAsync(brandId);
        return Ok(models);
    }

    [HttpGet("trims/{brandId}/{modelId}")]
    public async Task<IActionResult> GetTrims(string brandId, string modelId)
    {
        var trims = await _configuratorService.GetTrimsByBrandAndModelAsync(brandId, modelId);
        return Ok(trims);
    }

    [HttpGet("pricing/{brandId}/{modelId}/{trimId}")]
    public async Task<IActionResult> GetPricing(string brandId, string modelId, string trimId)
    {
        var pricing = await _configuratorService.GetPricingAsync(brandId, modelId, trimId);
        return Ok(pricing);
    }

    [HttpGet("features/{brandId}/{modelId}/{trimId}")]
    public async Task<IActionResult> GetFeatures(string brandId, string modelId, string trimId)
    {
        return Ok(new List<object>());
    }

    [HttpGet("additional-services/{brandId}/{modelId}/{trimId}")]
    public async Task<IActionResult> GetAdditionalServices(string brandId, string modelId, string trimId)
    {
        try
        {
            var trims = await _configuratorService.GetTrimsByBrandAndModelAsync(brandId, modelId);
            var trim = trims.FirstOrDefault(t => t.Id == trimId);

            if (trim == null)
            {
                return NotFound($"Trim with ID {trimId} not found for brand {brandId} and model {modelId}");
            }

            var services = new List<object>
            {
                new
                {
                    id = "full-insurance-0",
                    name = "Full Insurance 0%",
                    description = "Comprehensive insurance coverage with 0% deductible",
                    price = trim.FullInsurance0PercentPrice,
                    isPercentage = false,
                    isDefault = true,
                    isRequired = false
                },
                new
                {
                    id = "full-insurance-4",
                    name = "Full Insurance 4%",
                    description = "Comprehensive insurance coverage with 4% deductible",
                    price = trim.FullInsurance4PercentPrice,
                    isPercentage = false,
                    isDefault = false,
                    isRequired = false
                },
                new
                {
                    id = "standard-insurance",
                    name = "Standard Insurance",
                    description = "Basic insurance coverage for your vehicle",
                    price = trim.StandardInsurancePrice,
                    isPercentage = false,
                    isDefault = true,
                    isRequired = false
                },
                new
                {
                    id = "maintenance-package",
                    name = "Maintenance Package",
                    description = "Regular maintenance and service for your vehicle",
                    price = trim.MaintenancePackagePrice,
                    isPercentage = false,
                    isDefault = true,
                    isRequired = false
                },
                new
                {
                    id = "vignettes",
                    name = "Vignettes",
                    description = "Road tax vignettes for highway travel",
                    price = trim.VignettesPrice,
                    isPercentage = false,
                    isDefault = false,
                    isRequired = false
                },
                new
                {
                    id = "geolocalisation",
                    name = "Geolocalisation",
                    description = "GPS tracking and location services",
                    price = trim.GeolocalisationPrice,
                    isPercentage = false,
                    isDefault = false,
                    isRequired = false
                },
                new
                {
                    id = "purchase-option",
                    name = "Purchase Option",
                    description = "Option to purchase the vehicle at the end of the lease",
                    price = trim.PurchaseOptionPrice,
                    isPercentage = false,
                    isDefault = false,
                    isRequired = false
                }
            };

            return Ok(services);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting additional services for brand {BrandId}, model {ModelId}, and trim {TrimId}", brandId, modelId, trimId);
            return StatusCode(500, "An error occurred while retrieving additional services");
        }
    }
}
