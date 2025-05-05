namespace ConfiguratorAPI.Models;

public class Model
{
    public string Id { get; set; } = string.Empty;
    public string BrandId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
}
