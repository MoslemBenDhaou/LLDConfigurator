using ConfiguratorAPI.Models;

namespace ConfiguratorAPI.Logic;

public class PricingEngine
{
    public decimal CalculateMonthlyPrice(
        Trim trim, 
        int durationMonths, 
        int annualKm, 
        int advancePaymentPercent,
        PriceFactorTable table)
    {
        decimal basePrice = table.BasePricesByDuration.GetValueOrDefault(durationMonths, 0);
        decimal kmAdjustment = table.KmAdjustments.GetValueOrDefault(annualKm, 0);
        decimal advanceDiscount = table.AdvancePaymentDiscounts.GetValueOrDefault(advancePaymentPercent, 0);

        return basePrice + kmAdjustment - advanceDiscount;
    }
}
