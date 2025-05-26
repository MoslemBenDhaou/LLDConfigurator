
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConfiguratorAPI.Models;

public class Configuration
{
    [Key]
    public int Id { get; set; } = 1;
    
    // General
    public decimal StandardInterestRate { get; set; } // e.g., 0.035m = 3.5%
    public decimal StandardMarginRate { get; set; } // e.g., 0.10m = 10%
    public decimal VatRate { get; set; } // e.g., 0.19m for 19% VAT
    public decimal DefaultResidualValuePercent { get; set; } // e.g., 0.30m = 30% of vehicle price

    // Fees
    public decimal AdministrativeFee { get; set; } // Fixed fee per contract
    public decimal DeliveryFee { get; set; } // Fixed or variable per delivery
    public decimal RegistrationFee { get; set; }

    // Duration Constraints
    public int MinDurationMonths { get; set; } = 12;
    public int MaxDurationMonths { get; set; } = 60;
    public int DurationStepMonths { get; set; } = 1;

    // Kilometrage Constraints
    public int MinAnnualKm { get; set; } = 10000;
    public int MaxAnnualKm { get; set; } = 30000;
    public int AnnualKmStep { get; set; } = 5000;

    // Advance Payment Options
    [NotMapped]
    public List<int> AdvancePaymentOptions => AdvancePaymentOptionsCsv?.Split(',').Select(int.Parse).ToList() ?? new();
    public string AdvancePaymentOptionsCsv { get; internal set; } = "0,10,20,30";

    // Purchase Option
    public decimal PurchaseOptionPercent { get; set; } = 40;

    // Custom Logic Flags
    public bool EnableDynamicResidualValueCalculation { get; set; } = true;
    public bool EnableTieredPricing { get; set; } = true;
    
}
