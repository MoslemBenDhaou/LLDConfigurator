using ConfiguratorAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ConfiguratorAPI.Data.Seeding;

public static class TrimSeeder
{
    public static void SeedTrims(ModelBuilder modelBuilder)
    {
        SeedAlfaRomeoTrims(modelBuilder);
        SeedAudiTrims(modelBuilder);
        // Add other brand trim seeding methods as needed
    }

    #region Alfa Romeo Trims
    private static void SeedAlfaRomeoTrims(ModelBuilder modelBuilder)
    {
        // Alfa Romeo Giulia Trims
        modelBuilder.Entity<Trim>().HasData(
            new Trim
            {
                Id = "2.0-turbo-super-bva",
                BrandId = "alfaromeo",
                ModelId = "giulia",
                Name = "2.0 Turbo Super BVA",
                Features = new List<string>(),
                Price = 449,
                ListPrice = 198000,
                IsActive = true,
                // Additional Services
                FullInsurance0PercentPrice = 35.92m, 
                FullInsurance4PercentPrice = 26.94m, 
                StandardInsurancePrice = 15.99m,
                MaintenancePackagePrice = 49.99m,
                VignettesPrice = 29.99m,
                GeolocalisationPrice = 19.90m,
                PurchaseOptionPrice = 79200.00m
            }
        );

        // Alfa Romeo Stelvio Trims
        modelBuilder.Entity<Trim>().HasData(
            new Trim
            {
                Id = "2.0-turbo-q4-super",
                BrandId = "alfaromeo",
                ModelId = "stelvio",
                Name = "2.0 Turbo Q4 Super",
                Features = new List<string>(),
                Price = 499,
                ListPrice = 220000,
                IsActive = true,
                // Additional Services
                FullInsurance0PercentPrice = 39.92m, 
                FullInsurance4PercentPrice = 29.94m, 
                StandardInsurancePrice = 15.99m,
                MaintenancePackagePrice = 49.99m,
                VignettesPrice = 29.99m,
                GeolocalisationPrice = 19.90m,
                PurchaseOptionPrice = 88000.00m 
            }
        );
    }
    #endregion

    #region Audi Trims
    private static void SeedAudiTrims(ModelBuilder modelBuilder)
    {
        // Audi A3 Berline Trims
        modelBuilder.Entity<Trim>().HasData(
            new Trim
            {
                Id = "35-tfsi-business-extended",
                BrandId = "audi",
                ModelId = "a3berline",
                Name = "35 TFSI Business Extended",
                Features = new List<string>(),
                Price = 349,
                ListPrice = 145000,
                IsActive = true,
                // Additional Services
                FullInsurance0PercentPrice = 27.92m, 
                FullInsurance4PercentPrice = 20.94m, 
                StandardInsurancePrice = 15.99m,
                MaintenancePackagePrice = 49.99m,
                VignettesPrice = 29.99m,
                GeolocalisationPrice = 19.90m,
                PurchaseOptionPrice = 58000.00m 
            }
        );

        // Audi Q2 Trims
        modelBuilder.Entity<Trim>().HasData(
            new Trim
            {
                Id = "35-tfsi-s-line-bva",
                BrandId = "audi",
                ModelId = "q2",
                Name = "35 TFSI S Line BVA",
                Features = new List<string>(),
                Price = 399,
                ListPrice = 155000,
                IsActive = true,
                // Additional Services
                FullInsurance0PercentPrice = 31.92m, 
                FullInsurance4PercentPrice = 23.94m, 
                StandardInsurancePrice = 15.99m,
                MaintenancePackagePrice = 49.99m,
                VignettesPrice = 29.99m,
                GeolocalisationPrice = 19.90m,
                PurchaseOptionPrice = 62000.00m 
            }
        );
    }
    #endregion
}
