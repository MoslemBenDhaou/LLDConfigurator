using System.Collections.Generic;
using System.Threading.Tasks;
using ConfiguratorAPI.Models;

namespace ConfiguratorAPI.Services;

public interface IVehicleService
{
    /// <summary>
    /// Gets all available vehicle brands
    /// </summary>
    /// <returns>List of vehicle brands</returns>
    Task<IEnumerable<Brand>> GetBrandsAsync();

    /// <summary>
    /// Gets a specific brand by its code
    /// </summary>
    /// <param name="code">The brand code</param>
    /// <returns>The requested brand or null if not found</returns>
    Task<Brand?> GetBrandByCodeAsync(string code);

    /// <summary>
    /// Gets all models for a specific brand
    /// </summary>
    /// <param name="brandCode">The brand code</param>
    /// <returns>List of models for the specified brand</returns>
    Task<IEnumerable<Model>> GetModelsByBrandAsync(string brandCode);

    /// <summary>
    /// Gets a specific model by brand and model codes
    /// </summary>
    /// <param name="brandCode">The brand code</param>
    /// <param name="modelCode">The model code</param>
    /// <returns>The requested model or null if not found</returns>
    Task<Model?> GetModelByCodeAsync(string brandCode, string modelCode);

    /// <summary>
    /// Gets all trims for a specific model
    /// </summary>
    /// <param name="brandCode">The brand code</param>
    /// <param name="modelCode">The model code</param>
    /// <returns>List of trims for the specified model</returns>
    Task<IEnumerable<Trim>> GetTrimsByModelAsync(string brandCode, string modelCode);

    /// <summary>
    /// Gets a specific trim by brand, model, and trim name
    /// </summary>
    /// <param name="brandCode">The brand code</param>
    /// <param name="modelCode">The model code</param>
    /// <param name="trimName">The trim name</param>
    /// <returns>The requested trim or null if not found</returns>
    Task<Trim?> GetTrimByNameAsync(string brandCode, string modelCode, string trimName);
}
