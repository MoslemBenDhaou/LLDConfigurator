namespace ConfiguratorAPI.Models;

public class LeasePrice
{
    public Trim Trim { get; set; }
    public LeaseTermOption TermOption { get; set; }

    public decimal MonthlyPrice { get; set; }

    public bool IsOverridden { get; set; }
    
}