using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConfiguratorAPI.Data;
using ConfiguratorAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace ConfiguratorAPI.Services;

public class VehicleService : IVehicleService
{
    private readonly ILogger<VehicleService> _logger;
    private readonly ConfiguratorDbContext _context;
    private readonly IMemoryCache _cache;
    private const string BrandsCacheKey = "Brands_All";
    private readonly MemoryCacheEntryOptions _cacheOptions;

    public VehicleService(
        ILogger<VehicleService> logger,
        ConfiguratorDbContext context,
        IMemoryCache cache)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _cache = cache ?? throw new ArgumentNullException(nameof(cache));
        
        // Configure cache options (5 minutes sliding expiration, 1 hour absolute expiration)
        _cacheOptions = new MemoryCacheEntryOptions()
            .SetSlidingExpiration(TimeSpan.FromMinutes(5))
            .SetAbsoluteExpiration(TimeSpan.FromHours(1));
    }

    public async Task<IEnumerable<Brand>> GetBrandsAsync()
    {
        _logger.LogInformation("Retrieving all brands from cache or database");
        
        // Try to get brands from cache
        if (!_cache.TryGetValue(BrandsCacheKey, out IEnumerable<Brand> brands))
        {
            _logger.LogInformation("Brands not found in cache, querying database...");
            
            // If not in cache, get from database
            brands = await _context.Brands
                .Where(b => b.IsActive)
                .OrderBy(b => b.Name)
                .AsNoTracking()
                .ToListAsync();

            // Add to cache
            _cache.Set(BrandsCacheKey, brands, _cacheOptions);
            _logger.LogInformation("Brands added to cache");
        }
        
        return brands;
    }

    public async Task<Brand?> GetBrandByCodeAsync(string code)
    {
        if (string.IsNullOrWhiteSpace(code))
        {
            throw new ArgumentException("Brand code cannot be empty", nameof(code));
        }

        _logger.LogInformation("Retrieving brand with code: {Code}", code);
        
        // Try to get from cache first
        string cacheKey = $"Brand_Code_{code.ToLower()}";
        
        if (!_cache.TryGetValue(cacheKey, out Brand? brand))
        {
            _logger.LogDebug("Brand with code {Code} not found in cache, querying database...", code);
            
            brand = await _context.Brands
                .AsNoTracking()
                .FirstOrDefaultAsync(b => 
                    b.IsActive && b.Code.ToLower() == code.ToLower());

            if (brand != null)
            {
                _cache.Set(cacheKey, brand, _cacheOptions);
                _logger.LogDebug("Brand with code {Code} added to cache", code);
            }
        }
        
        return brand;
    }

    public async Task<IEnumerable<Model>> GetModelsByBrandAsync(string brandCode)
    {
        if (string.IsNullOrWhiteSpace(brandCode))
        {
            throw new ArgumentException("Brand code cannot be empty", nameof(brandCode));
        }

        _logger.LogInformation("Retrieving models for brand: {BrandCode}", brandCode);
        string cacheKey = $"Models_Brand_{brandCode.ToLower()}";

        if (!_cache.TryGetValue(cacheKey, out IEnumerable<Model> models))
        {
            _logger.LogDebug("Models for brand {BrandCode} not found in cache, querying database...", brandCode);
            
            models = await _context.Models
                .Where(m => m.IsActive && 
                          m.Brand != null && 
                          m.Brand.Code.ToLower() == brandCode.ToLower())
                .OrderBy(m => m.Name)
                .AsNoTracking()
                .ToListAsync();

            _cache.Set(cacheKey, models, _cacheOptions);
            _logger.LogDebug("Added {Count} models for brand {BrandCode} to cache", models.Count(), brandCode);
        }

        
        return models;
    }

    public async Task<Model?> GetModelByCodeAsync(string brandCode, string modelCode)
    {
        if (string.IsNullOrWhiteSpace(brandCode))
            throw new ArgumentException("Brand code cannot be empty", nameof(brandCode));
        if (string.IsNullOrWhiteSpace(modelCode))
            throw new ArgumentException("Model code cannot be empty", nameof(modelCode));

        _logger.LogInformation("Retrieving model with brand code: {BrandCode}, model code: {ModelCode}", brandCode, modelCode);
        string cacheKey = $"Model_{brandCode.ToLower()}_{modelCode.ToLower()}";

        if (!_cache.TryGetValue(cacheKey, out Model? model))
        {
            _logger.LogDebug("Model {BrandCode}/{ModelCode} not found in cache, querying database...", brandCode, modelCode);
            
            model = await _context.Models
                .Include(m => m.Brand)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => 
                    m.IsActive && 
                    m.Brand != null &&
                    m.Brand.Code.ToLower() == brandCode.ToLower() &&
                    m.Code.ToLower() == modelCode.ToLower());

            if (model != null)
            {
                _cache.Set(cacheKey, model, _cacheOptions);
                _logger.LogDebug("Added model {BrandCode}/{ModelCode} to cache", brandCode, modelCode);
            }
        }
        
        return model;
    }

    public async Task<IEnumerable<Trim>> GetTrimsByModelAsync(string brandCode, string modelCode)
    {
        if (string.IsNullOrWhiteSpace(brandCode))
            throw new ArgumentException("Brand code cannot be empty", nameof(brandCode));
        if (string.IsNullOrWhiteSpace(modelCode))
            throw new ArgumentException("Model code cannot be empty", nameof(modelCode));

        _logger.LogInformation("Retrieving trims for brand: {BrandCode}, model: {ModelCode}", brandCode, modelCode);
        string cacheKey = $"Trims_{brandCode.ToLower()}_{modelCode.ToLower()}";

        if (!_cache.TryGetValue(cacheKey, out IEnumerable<Trim> trims))
        {
            _logger.LogDebug("Trims for {BrandCode}/{ModelCode} not found in cache, querying database...", brandCode, modelCode);
            
            trims = await _context.Trims
                .Include(t => t.Model)
                .ThenInclude(m => m.Brand)
                .Where(t => t.IsActive && 
                          t.Model != null && 
                          t.Model.Brand != null &&
                          t.Model.Brand.Code.ToLower() == brandCode.ToLower() &&
                          t.Model.Code.ToLower() == modelCode.ToLower())
                .OrderBy(t => t.Name)
                .AsNoTracking()
                .ToListAsync();

            _cache.Set(cacheKey, trims, _cacheOptions);
            _logger.LogDebug("Added {Count} trims for {BrandCode}/{ModelCode} to cache", trims.Count(), brandCode, modelCode);
        }
        
        return trims;
    }

    public async Task<Trim?> GetTrimByNameAsync(string brandCode, string modelCode, string trimName)
    {
        if (string.IsNullOrWhiteSpace(brandCode))
            throw new ArgumentException("Brand code cannot be empty", nameof(brandCode));
        if (string.IsNullOrWhiteSpace(modelCode))
            throw new ArgumentException("Model code cannot be empty", nameof(modelCode));
        if (string.IsNullOrWhiteSpace(trimName))
            throw new ArgumentException("Trim name cannot be empty", nameof(trimName));

        _logger.LogInformation("Retrieving trim: {BrandCode}/{ModelCode}/{TrimName}", brandCode, modelCode, trimName);
        string cacheKey = $"Trim_{brandCode.ToLower()}_{modelCode.ToLower()}_{trimName.ToLower()}";

        if (!_cache.TryGetValue(cacheKey, out Trim? trim))
        {
            _logger.LogDebug("Trim {BrandCode}/{ModelCode}/{TrimName} not found in cache, querying database...", 
                brandCode, modelCode, trimName);
            
            trim = await _context.Trims
                .Include(t => t.Model)
                    .ThenInclude(m => m.Brand)
                .AsNoTracking()
                .FirstOrDefaultAsync(t => 
                    t.IsActive && 
                    t.Model != null &&
                    t.Model.Brand != null &&
                    string.Equals(t.Model.Brand.Code, brandCode, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(t.Model.Code, modelCode, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(t.Name, trimName, StringComparison.OrdinalIgnoreCase));

            if (trim != null)
            {
                _cache.Set(cacheKey, trim, _cacheOptions);
                _logger.LogDebug("Added trim {BrandCode}/{ModelCode}/{TrimName} to cache", brandCode, modelCode, trimName);
            }
        }
        
        return trim;
    }
}
