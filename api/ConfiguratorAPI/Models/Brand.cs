using System.Text.Json.Serialization;

namespace ConfiguratorAPI.Models;

public class Brand
{
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string ImgUrl { get; set; } = string.Empty; // Logo or brand image
    [JsonIgnore]
    public List<Model> Models { get; set; } = new();
    public bool IsActive { get; set; } = true;
}
