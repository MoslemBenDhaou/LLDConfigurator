namespace ConfiguratorAPI.Models;

public class Model
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string ImgUrl { get; set; } // Vehicle or model image
    public Brand Brand { get; set; }
    public List<Trim> Trims { get; set; } = new();
    public bool IsActive { get; set; } = true;
}
