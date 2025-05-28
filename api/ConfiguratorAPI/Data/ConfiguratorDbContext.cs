using ConfiguratorAPI.Models;
using Microsoft.EntityFrameworkCore;
using ConfiguratorAPI.Data.Seeding;

namespace ConfiguratorAPI.Data;

public class ConfiguratorDbContext : DbContext
{
    public ConfiguratorDbContext(DbContextOptions<ConfiguratorDbContext> options)
        : base(options)
    {
    }

    public DbSet<Brand> Brands { get; set; } = null!;
    public DbSet<Model> Models { get; set; } = null!;
    public DbSet<Trim> Trims { get; set; } = null!;
    public DbSet<Configuration> Configuration { get; set; } = null!;
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure Brand entity
        modelBuilder.Entity<Brand>()
            .HasKey(b => b.Code);
            
        modelBuilder.Entity<Brand>()
            .Property(b => b.Code)
            .ValueGeneratedNever(); // We'll set the ID manually
            
        modelBuilder.Entity<Brand>()
            .HasMany(b => b.Models)
            .WithOne(m => m.Brand)
            .HasForeignKey(m => m.BrandCode)
            .OnDelete(DeleteBehavior.Cascade);

        // Configure Model entity
        modelBuilder.Entity<Model>()
            .HasKey(m => m.Code);
            
        modelBuilder.Entity<Model>()
            .HasOne(m => m.Brand)
            .WithMany(b => b.Models)
            .HasForeignKey(m => m.BrandCode)
            .OnDelete(DeleteBehavior.Cascade);

        // Configure Trim entity
        modelBuilder.Entity<Trim>()
            .HasKey(t => new { t.TrimCode, t.ModelCode });
            
        modelBuilder.Entity<Trim>()
            .HasOne(t => t.Model)
            .WithMany(m => m.Trims)
            .HasForeignKey(t => t.ModelCode)
            .HasPrincipalKey(m => m.Code)
            .OnDelete(DeleteBehavior.Cascade);

        // Seed configuration
        modelBuilder.Entity<Configuration>().HasData(
            new Configuration
            {
                Id = 1,
                StandardInterestRate = 0.035m,
                StandardMarginRate = 0.10m,
                VatRate = 0.19m,
                DefaultResidualValuePercent = 0.30m,

                AdministrativeFee = 150,
                DeliveryFee = 300,
                RegistrationFee = 100,

                MinDurationMonths = 12,
                MaxDurationMonths = 60,
                DurationStepMonths = 1,


                MinAnnualKm = 10000,
                MaxAnnualKm = 30000,
                AnnualKmStep = 5000,

                AdvancePaymentOptionsCsv = "0,10,20,30",
                EnableDynamicResidualValueCalculation = true,
                EnableTieredPricing = true
            }
        );

        // Seed database with initial data
        modelBuilder.SeedDatabase();
    }
}
