namespace ConfiguratorAPI.Models;

public class Brand
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Logo { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
}
