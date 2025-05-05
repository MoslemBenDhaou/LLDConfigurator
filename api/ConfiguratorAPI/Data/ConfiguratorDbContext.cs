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
    public DbSet<PriceMatrix> PriceMatrices { get; set; } = null!;
    public DbSet<PricePoint> PricePoints { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure Brand entity
        modelBuilder.Entity<Brand>(entity =>
        {
            entity.ToTable("brands");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name").IsRequired();
            entity.Property(e => e.Logo).HasColumnName("logo");
            entity.Property(e => e.IsActive).HasColumnName("is_active").HasDefaultValue(true);
        });

        // Configure Model entity
        modelBuilder.Entity<Model>(entity =>
        {
            entity.ToTable("models");
            entity.HasKey(e => new { e.Id, e.BrandId });
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Name).HasColumnName("name").IsRequired();
            entity.Property(e => e.Image).HasColumnName("image");
            entity.Property(e => e.IsActive).HasColumnName("is_active").HasDefaultValue(true);

            // Add relationship to Brand
            entity.HasOne<Brand>()
                  .WithMany()
                  .HasForeignKey(e => e.BrandId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        // Configure Trim entity
        modelBuilder.Entity<Trim>(entity =>
        {
            entity.ToTable("trims");
            entity.HasKey(e => new { e.Id, e.ModelId, e.BrandId });
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ModelId).HasColumnName("model_id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Name).HasColumnName("name").IsRequired();
            entity.Property(e => e.Price).HasColumnName("price").HasColumnType("decimal(10,2)");
            entity.Property(e => e.ListPrice).HasColumnName("list_price").HasColumnType("decimal(10,2)");
            entity.Property(e => e.IsActive).HasColumnName("is_active").HasDefaultValue(true);
            
            // Features will be stored as JSON
            entity.Property(e => e.Features).HasColumnName("features").HasColumnType("jsonb");

            // Additional Service properties
            entity.Property(e => e.FullInsurance0PercentPrice).HasColumnName("full_insurance_0_percent_price").HasColumnType("decimal(10,2)");
            entity.Property(e => e.FullInsurance4PercentPrice).HasColumnName("full_insurance_4_percent_price").HasColumnType("decimal(10,2)");
            entity.Property(e => e.StandardInsurancePrice).HasColumnName("standard_insurance_price").HasColumnType("decimal(10,2)").HasDefaultValue(15.99m);
            entity.Property(e => e.MaintenancePackagePrice).HasColumnName("maintenance_package_price").HasColumnType("decimal(10,2)").HasDefaultValue(49.99m);
            entity.Property(e => e.VignettesPrice).HasColumnName("vignettes_price").HasColumnType("decimal(10,2)").HasDefaultValue(29.99m);
            entity.Property(e => e.GeolocalisationPrice).HasColumnName("geolocalisation_price").HasColumnType("decimal(10,2)").HasDefaultValue(19.90m);
            entity.Property(e => e.PurchaseOptionPrice).HasColumnName("purchase_option_price").HasColumnType("decimal(10,2)");
            
            // Add relationship to Model
            entity.HasOne<Model>()
                  .WithMany()
                  .HasForeignKey(e => new { e.ModelId, e.BrandId })
                  .OnDelete(DeleteBehavior.Cascade);
        });

        // Configure PriceMatrix entity
        modelBuilder.Entity<PriceMatrix>(entity =>
        {
            entity.ToTable("price_matrices");
            entity.HasKey(e => new { e.TrimId, e.ModelId, e.BrandId });
            entity.Property(e => e.TrimId).HasColumnName("trim_id");
            entity.Property(e => e.ModelId).HasColumnName("model_id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");

            // Add relationship to Trim
            entity.HasOne<Trim>()
                  .WithOne()
                  .HasForeignKey<PriceMatrix>(e => new { e.TrimId, e.ModelId, e.BrandId })
                  .OnDelete(DeleteBehavior.Cascade);
        });

        // Configure PricePoint entity
        modelBuilder.Entity<PricePoint>(entity =>
        {
            entity.ToTable("price_points");
            entity.HasKey(e => new { e.TrimId, e.ModelId, e.BrandId, e.Duration, e.Kilometers });
            entity.Property(e => e.TrimId).HasColumnName("trim_id");
            entity.Property(e => e.ModelId).HasColumnName("model_id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.Kilometers).HasColumnName("kilometers");
            
            // Configure AdvancePaymentPrices as owned entity
            entity.OwnsOne(e => e.Prices, prices =>
            {
                prices.Property(p => p.Advance0).HasColumnName("advance_0").HasColumnType("decimal(10,2)");
                prices.Property(p => p.Advance10).HasColumnName("advance_10").HasColumnType("decimal(10,2)");
                prices.Property(p => p.Advance20).HasColumnName("advance_20").HasColumnType("decimal(10,2)");
                prices.Property(p => p.Advance30).HasColumnName("advance_30").HasColumnType("decimal(10,2)");
            });

            // Add relationship to PriceMatrix
            entity.HasOne<PriceMatrix>()
                  .WithMany(e => e.Points)
                  .HasForeignKey(e => new { e.TrimId, e.ModelId, e.BrandId })
                  .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.SeedDatabase();
    }
}
