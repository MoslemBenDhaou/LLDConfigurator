using System.Text.Json.Serialization;

namespace ConfiguratorAPI.Models;

public class Model
{
    public string Code { get; set; } = string.Empty; // Primary key
    public string Name { get; set; } = string.Empty;
    public string ImgUrl { get; set; } = string.Empty; // Vehicle or model image
    public string BrandCode { get; set; } = string.Empty; // Foreign key
    public Brand? Brand { get; set; }
    [JsonIgnore]
    public List<Trim> Trims { get; set; } = new();
    public bool IsActive { get; set; } = true;
}
