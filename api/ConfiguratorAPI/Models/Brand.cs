namespace ConfiguratorAPI.Models;

public class Brand
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string ImgUrl { get; set; } // Logo or brand image
    public List<Model> Models { get; set; } = new();
    public bool IsActive { get; set; } = true;
}
