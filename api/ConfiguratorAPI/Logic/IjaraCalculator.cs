using ConfiguratorAPI.Models;

namespace ConfiguratorAPI.Logic;

public static class IjaraCalculator
{
    public static decimal CalculateMonthlyRepayment(
        decimal vehiclePrice,
        decimal advancePaymentPercent,
        int loanTermMonths,
        decimal annualInterestRate)
    {
        decimal advancePayment = vehiclePrice * (advancePaymentPercent / 100m);
        decimal loanAmount = vehiclePrice - advancePayment;

        decimal monthlyInterestRate = annualInterestRate / 12m / 100m; // convert % to decimal

        if (monthlyInterestRate == 0)
            return Math.Round(loanAmount / loanTermMonths, 2); // zero-interest fallback

        decimal numerator = monthlyInterestRate * (decimal)Math.Pow((double)(1 + monthlyInterestRate), loanTermMonths);
        decimal denominator = (decimal)Math.Pow((double)(1 + monthlyInterestRate), loanTermMonths) - 1;

        decimal monthlyPayment = loanAmount * numerator / denominator;

        return Math.Round(monthlyPayment, 2);
    }

    public static decimal CalculateRemainingPrincipal(
        decimal vehiclePrice,
        decimal advancePaymentPercent,
        int totalMonths,
        int currentMonth,
        decimal annualInterestRate)
    {
        if (currentMonth >= totalMonths) return 0;

        decimal advancePayment = vehiclePrice * (advancePaymentPercent / 100m);
        decimal principal = vehiclePrice - advancePayment;
        decimal monthlyRate = annualInterestRate / 12m / 100m;

        if (monthlyRate == 0)
        {
            decimal monthly = principal / totalMonths;
            return Math.Round(monthly * (totalMonths - currentMonth), 2);
        }

        double r = (double)monthlyRate;
        double n = totalMonths;
        double x = currentMonth;

        double numerator = Math.Pow(1 + r, n) - Math.Pow(1 + r, x);
        double denominator = Math.Pow(1 + r, n) - 1;

        decimal remaining = principal * (decimal)(numerator / denominator);
        return Math.Round(remaining, 2);
    }
    
    public static decimal SimulateRemainingPrincipal(
    decimal vehiclePrice,
    decimal advancePaymentPercent,
    int loanTermMonths,
    int currentMonth,
    decimal annualInterestRate)
    {
        if (currentMonth >= loanTermMonths) return 0;

        decimal advancePayment = vehiclePrice * (advancePaymentPercent / 100m);
        decimal principal = vehiclePrice - advancePayment;
        decimal monthlyRate = annualInterestRate / 12m / 100m;

        decimal monthlyPayment = CalculateMonthlyRepayment(
            vehiclePrice,
            advancePaymentPercent,
            loanTermMonths,
            annualInterestRate);

        for (int month = 1; month <= currentMonth; month++)
        {
            decimal interest = principal * monthlyRate;
            decimal principalPaid = monthlyPayment - interest;
            principal -= principalPaid;
        }

        return Math.Round(principal, 2);
    }

    public static decimal CalculatePurchasePrice(
        decimal listPriceTTC,
        decimal remainingPrincipal,
        double monthsPassed,
        Configuration config)
    {
        decimal VAT = config.VatRate;
        decimal PURCHASE_COMMISSION_RATE = 0.05m; // TODO: Move to config
        decimal COMMISSION_VAT_RATE = 0.19m; // TODO: Move to config
        decimal SURCHARGE_RATE = 0.10m; // TODO: Move to config

        int yearsPassed = (int)Math.Ceiling(monthsPassed / 12.0);

        decimal listPriceHT = listPriceTTC / (1 + VAT);
        decimal vatAmount = listPriceTTC - listPriceHT;
        decimal yearlyVATAmortization = vatAmount / 5;
        int remainingYears = Math.Max(0, 5 - yearsPassed);

        decimal purchaseCommission = remainingPrincipal * PURCHASE_COMMISSION_RATE;
        decimal purchaseCommissionVAT = purchaseCommission * COMMISSION_VAT_RATE;

        decimal unamortizedVAT = yearlyVATAmortization * remainingYears;

        decimal subtotal = remainingPrincipal + purchaseCommission + purchaseCommissionVAT + unamortizedVAT;

        decimal surcharge = subtotal * SURCHARGE_RATE;
        decimal surchargeVAT = surcharge * VAT;

        decimal finalPrice = subtotal + surcharge + surchargeVAT;

        decimal minimumAllowed = listPriceHT * (config.PurchaseOptionPercent / 100m);
        return Math.Round(Math.Max(finalPrice, minimumAllowed), 3);
    }

}