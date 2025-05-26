
namespace ConfiguratorAPI.Models;

public class PriceFactorTable
{
    public Trim Trim { get; set; }

    // Duration in months to base monthly price
    public Dictionary<int, decimal> BasePricesByDuration { get; set; } = new();

    // Annual KM limit to additional monthly price (offset)
    public Dictionary<int, decimal> KmAdjustments { get; set; } = new();

    // Advance payment percentage to discount
    public Dictionary<int, decimal> AdvancePaymentDiscounts { get; set; } = new();
}
