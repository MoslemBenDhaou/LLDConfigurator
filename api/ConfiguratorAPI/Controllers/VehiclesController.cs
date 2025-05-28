using Microsoft.AspNetCore.Mvc;
using ConfiguratorAPI.Models;
using ConfiguratorAPI.Services;

namespace ConfiguratorAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VehiclesController : ControllerBase
{
    private readonly ILogger<VehiclesController> _logger;
    private readonly IVehicleService _vehicleService;

    public VehiclesController(
        ILogger<VehiclesController> logger,
        IVehicleService vehicleService)
    {
        _logger = logger;
        _vehicleService = vehicleService;
    }

    /// <summary>
    /// Gets all available vehicle brands
    /// </summary>
    /// <returns>List of vehicle brands</returns>
    [HttpGet("brands")]
    [ProducesResponseType(typeof(IEnumerable<Brand>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetBrands()
    {
        _logger.LogInformation("Getting all vehicle brands");
        var brands = await _vehicleService.GetBrandsAsync();
        return Ok(brands);
    }

    /// <summary>
    /// Gets a specific brand by its code
    /// </summary>
    /// <param name="code">The brand code</param>
    /// <returns>The requested brand or 404 if not found</returns>
    [HttpGet("brands/{code}")]
    [ProducesResponseType(typeof(Brand), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetBrandByCode(string code)
    {
        _logger.LogInformation("Getting brand with code: {Code}", code);
        var brand = await _vehicleService.GetBrandByCodeAsync(code);
        
        if (brand == null)
        {
            _logger.LogWarning("Brand with code {Code} not found", code);
            return NotFound();
        }

        return Ok(brand);
    }

    /// <summary>
    /// Gets all models for a specific brand
    /// </summary>
    /// <param name="brandCode">The brand code</param>
    /// <returns>List of models for the specified brand</returns>
    [HttpGet("brands/{brandCode}/models")]
    [ProducesResponseType(typeof(IEnumerable<Model>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetModels(string brandCode)
    {
        _logger.LogInformation("Getting all models for brand: {BrandCode}", brandCode);
        
        try
        {
            var models = await _vehicleService.GetModelsByBrandAsync(brandCode);
            if (!models.Any())
            {
                _logger.LogWarning("No models found for brand: {BrandCode}", brandCode);
                return NotFound("No models found for the specified brand");
            }
            
            return Ok(models);
        }
        catch (ArgumentException ex)
        {
            _logger.LogWarning(ex, "Invalid brand code: {BrandCode}", brandCode);
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Gets a specific model by brand and model codes
    /// </summary>
    /// <param name="brandCode">The brand code</param>
    /// <param name="modelCode">The model code</param>
    /// <returns>The requested model or 404 if not found</returns>
    [HttpGet("brands/{brandCode}/models/{modelCode}")]
    [ProducesResponseType(typeof(Model), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetModelByCode(string brandCode, string modelCode)
    {
        _logger.LogInformation("Getting model with brand code: {BrandCode}, model code: {ModelCode}", brandCode, modelCode);
        
        try
        {
            var model = await _vehicleService.GetModelByCodeAsync(brandCode, modelCode);
            if (model == null)
            {
                _logger.LogWarning("Model not found - Brand: {BrandCode}, Model: {ModelCode}", brandCode, modelCode);
                return NotFound("Model not found");
            }
            
            return Ok(model);
        }
        catch (ArgumentException ex)
        {
            _logger.LogWarning(ex, "Invalid parameters - Brand: {BrandCode}, Model: {ModelCode}", brandCode, modelCode);
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Gets all trims for a specific model
    /// </summary>
    /// <param name="brandCode">The brand code</param>
    /// <param name="modelCode">The model code</param>
    /// <returns>List of trims for the specified model</returns>
    [HttpGet("brands/{brandCode}/models/{modelCode}/trims")]
    [ProducesResponseType(typeof(IEnumerable<Trim>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetTrims(string brandCode, string modelCode)
    {
        _logger.LogInformation("Getting all trims for brand: {BrandCode}, model: {ModelCode}", brandCode, modelCode);
        
        try
        {
            var trims = await _vehicleService.GetTrimsByModelAsync(brandCode, modelCode);
            if (!trims.Any())
            {
                _logger.LogWarning("No trims found for brand: {BrandCode}, model: {ModelCode}", brandCode, modelCode);
                return NotFound("No trims found for the specified model");
            }
            
            return Ok(trims);
        }
        catch (ArgumentException ex)
        {
            _logger.LogWarning(ex, "Invalid parameters - Brand: {BrandCode}, Model: {ModelCode}", brandCode, modelCode);
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Gets a specific trim by brand, model, and trim name
    /// </summary>
    /// <param name="brandCode">The brand code</param>
    /// <param name="modelCode">The model code</param>
    /// <param name="trimName">The trim name</param>
    /// <returns>The requested trim or 404 if not found</returns>
    [HttpGet("brands/{brandCode}/models/{modelCode}/trims/{trimName}")]
    [ProducesResponseType(typeof(Trim), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetTrim(string brandCode, string modelCode, string trimName)
    {
        _logger.LogInformation("Getting trim: {BrandCode}/{ModelCode}/{TrimName}", brandCode, modelCode, trimName);
        
        try
        {
            var trim = await _vehicleService.GetTrimByNameAsync(brandCode, modelCode, trimName);
            if (trim == null)
            {
                _logger.LogWarning("Trim not found - Brand: {BrandCode}, Model: {ModelCode}, Trim: {TrimName}", 
                    brandCode, modelCode, trimName);
                return NotFound("Trim not found");
            }
            
            return Ok(trim);
        }
        catch (ArgumentException ex)
        {
            _logger.LogWarning(ex, "Invalid parameters - Brand: {BrandCode}, Model: {ModelCode}, Trim: {TrimName}", 
                brandCode, modelCode, trimName);
            return BadRequest(ex.Message);
        }
    }
}
