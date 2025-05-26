
namespace ConfiguratorAPI.Models;

public class LeaseTermOption
{
    public int DurationMonths { get; set; } // 12 to 60 (by 1)
    public int AnnualKmLimit { get; set; }  // e.g., 10000, 15000, ..., 30000
    public int TotalKm => (DurationMonths / 12) * AnnualKmLimit;
    public int AdvancePaymentPercent { get; set; } // 0, 10, 20, 30
}
