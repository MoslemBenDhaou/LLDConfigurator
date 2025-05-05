using ConfiguratorAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ConfiguratorAPI.Data.Seeding;

public static class DatabaseSeeder
{
    public static void SeedDatabase(this ModelBuilder modelBuilder)
    {
        // Seed brands first
        SeedBrands(modelBuilder);
        
        // Seed each brand's data
        SeedAlfaRomeoData(modelBuilder);
        SeedAudiData(modelBuilder);
        SeedBMWData(modelBuilder);
        SeedBYDData(modelBuilder);
        SeedCheryData(modelBuilder);
        SeedChevroletData(modelBuilder);
        SeedCitroenData(modelBuilder);
        SeedCupraData(modelBuilder);
        SeedDaciaData(modelBuilder);
        SeedFiatData(modelBuilder);
        SeedFordData(modelBuilder);
        SeedHavalData(modelBuilder);
        SeedHondaData(modelBuilder);
        SeedHyundaiData(modelBuilder);
        SeedJaguarData(modelBuilder);
        SeedJeepData(modelBuilder);
        SeedKiaData(modelBuilder);
        SeedLandRoverData(modelBuilder);
        SeedMahindraData(modelBuilder);
        SeedMercedesData(modelBuilder);
        SeedMGData(modelBuilder);
        SeedMiniData(modelBuilder);
        SeedMitsubishiData(modelBuilder);
        SeedNissanData(modelBuilder);
        SeedOpelData(modelBuilder);
        SeedPeugeotData(modelBuilder);
        SeedPorscheData(modelBuilder);
        SeedRenaultData(modelBuilder);
        SeedSeatData(modelBuilder);
        SeedSkodaData(modelBuilder);
        SeedKGMData(modelBuilder);
        SeedSuzukiData(modelBuilder);
        SeedToyotaData(modelBuilder);
        SeedVolkswagenData(modelBuilder);
        SeedVolvoData(modelBuilder);
        SeedWallysData(modelBuilder);
    }

    private static void SeedBrands(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Brand>().HasData(
            new Brand { Id = "alfaromeo", Name = "Alfa Romeo", Logo = "/brands/alfaromeo.webp", IsActive = true },
            new Brand { Id = "audi", Name = "Audi", Logo = "/brands/audi.webp", IsActive = true },
            new Brand { Id = "bmw", Name = "BMW", Logo = "/brands/bmw.webp", IsActive = true },
            new Brand { Id = "byd", Name = "BYD", Logo = "/brands/byd.webp", IsActive = true },
            new Brand { Id = "chery", Name = "Chery", Logo = "/brands/chery.webp", IsActive = true },
            new Brand { Id = "chevrolet", Name = "Chevrolet", Logo = "/brands/chevrolet.webp", IsActive = true },
            new Brand { Id = "citroen", Name = "Citroen", Logo = "/brands/citroen.webp", IsActive = true },
            new Brand { Id = "cupra", Name = "Cupra", Logo = "/brands/cupra.webp", IsActive = true },
            new Brand { Id = "dacia", Name = "Dacia", Logo = "/brands/dacia.webp", IsActive = true },
            new Brand { Id = "fiat", Name = "FIAT", Logo = "/brands/fiat.webp", IsActive = true },
            new Brand { Id = "ford", Name = "Ford", Logo = "/brands/ford.webp", IsActive = true },
            new Brand { Id = "haval", Name = "Haval", Logo = "/brands/haval.webp", IsActive = true },
            new Brand { Id = "honda", Name = "Honda", Logo = "/brands/honda.webp", IsActive = true },
            new Brand { Id = "hyundai", Name = "Hyundai", Logo = "/brands/hyundai.webp", IsActive = true },
            new Brand { Id = "jaguar", Name = "Jaguar", Logo = "/brands/jaguar.webp", IsActive = true },
            new Brand { Id = "jeep", Name = "Jeep", Logo = "/brands/jeep.webp", IsActive = true },
            new Brand { Id = "kia", Name = "Kia", Logo = "/brands/kia.webp", IsActive = true },
            new Brand { Id = "landrover", Name = "Land Rover", Logo = "/brands/landrover.webp", IsActive = true },
            new Brand { Id = "mahindra", Name = "Mahindra", Logo = "/brands/mahindra.webp", IsActive = true },
            new Brand { Id = "mercedes", Name = "Mercedes", Logo = "/brands/mercedes.webp", IsActive = true },
            new Brand { Id = "mg", Name = "MG", Logo = "/brands/mg.webp", IsActive = true },
            new Brand { Id = "mini", Name = "Mini", Logo = "/brands/mini.webp", IsActive = true },
            new Brand { Id = "mitsubishi", Name = "Mitsubishi", Logo = "/brands/mitsubishi.webp", IsActive = true },
            new Brand { Id = "nissan", Name = "Nissan", Logo = "/brands/nissan.webp", IsActive = true },
            new Brand { Id = "opel", Name = "Opel", Logo = "/brands/opel.webp", IsActive = true },
            new Brand { Id = "peugeot", Name = "Peugeot", Logo = "/brands/peugeot.webp", IsActive = true },
            new Brand { Id = "porsche", Name = "Porsche", Logo = "/brands/porsche.webp", IsActive = true },
            new Brand { Id = "renault", Name = "Renault", Logo = "/brands/renault.webp", IsActive = true },
            new Brand { Id = "seat", Name = "SEAT", Logo = "/brands/seat.webp", IsActive = true },
            new Brand { Id = "skoda", Name = "Skoda", Logo = "/brands/skoda.webp", IsActive = true },
            new Brand { Id = "kgm", Name = "KGM", Logo = "/brands/kgm.webp", IsActive = true },
            new Brand { Id = "suzuki", Name = "Suzuki", Logo = "/brands/suzuki.webp", IsActive = true },
            new Brand { Id = "toyota", Name = "Toyota", Logo = "/brands/toyota.webp", IsActive = true },
            new Brand { Id = "volkswagen", Name = "Volkswagen", Logo = "/brands/volkswagen.webp", IsActive = true },
            new Brand { Id = "volvo", Name = "Volvo", Logo = "/brands/volvo.webp", IsActive = true },
            new Brand { Id = "wallys", Name = "Wallys", Logo = "/brands/wallys.webp", IsActive = true }
        );
    }

    #region Alfa Romeo Data
    private static void SeedAlfaRomeoData(ModelBuilder modelBuilder)
    {
        // Alfa Romeo Models
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "giulia", BrandId = "alfaromeo", Name = "Giulia", Image = "/models/alfaromeo/giulia.webp", IsActive = true },
            new Model { Id = "stelvio", BrandId = "alfaromeo", Name = "Stelvio", Image = "/models/alfaromeo/stelvio.webp", IsActive = true }
        );

        // Alfa Romeo Giulia Trims
        modelBuilder.Entity<Trim>().HasData(
            new Trim
            {
                Id = "2.0-turbo-super-bva",
                BrandId = "alfaromeo",
                ModelId = "giulia",
                Name = "2.0 Turbo Super BVA",
                Features = new List<string>
                {
                    "2.0L Turbo Engine",
                    "8-Speed Automatic Transmission",
                    "Rear-Wheel Drive",
                    "Leather Interior",
                    "Dual-Zone Climate Control",
                    "Infotainment System with Navigation",
                    "Parking Sensors",
                    "Cruise Control"
                },
                Price = 449,
                ListPrice = 198000,
                IsActive = true,
                FullInsurance0PercentPrice = 35.92m,
                FullInsurance4PercentPrice = 26.94m,
                StandardInsurancePrice = 15.99m,
                MaintenancePackagePrice = 49.99m,
                VignettesPrice = 29.99m,
                GeolocalisationPrice = 19.90m,
                PurchaseOptionPrice = 79200.00m
            }
        );

        // Alfa Romeo Giulia Feature Groups
        modelBuilder.Entity<FeatureGroup>().HasData(
            new FeatureGroup
            {
                Id = 1,
                TrimId = "2.0-turbo-super-bva",
                ModelId = "giulia",
                BrandId = "alfaromeo",
                Name = "Caractéristiques"
            },
            new FeatureGroup
            {
                Id = 2,
                TrimId = "2.0-turbo-super-bva",
                ModelId = "giulia",
                BrandId = "alfaromeo",
                Name = "Transmission"
            },
            new FeatureGroup
            {
                Id = 3,
                TrimId = "2.0-turbo-super-bva",
                ModelId = "giulia",
                BrandId = "alfaromeo",
                Name = "Performances"
            }
        );

        // Alfa Romeo Giulia Features
        modelBuilder.Entity<TrimFeature>().HasData(
            new TrimFeature { Id = 1, FeatureGroupId = 1, TrimId = "2.0-turbo-super-bva", ModelId = "giulia", BrandId = "alfaromeo", Name = "Moteur", Value = "2.0L Turbo" },
            new TrimFeature { Id = 2, FeatureGroupId = 1, TrimId = "2.0-turbo-super-bva", ModelId = "giulia", BrandId = "alfaromeo", Name = "Puissance", Value = "200 ch" },
            new TrimFeature { Id = 3, FeatureGroupId = 1, TrimId = "2.0-turbo-super-bva", ModelId = "giulia", BrandId = "alfaromeo", Name = "Couple", Value = "330 Nm" },
            new TrimFeature { Id = 4, FeatureGroupId = 1, TrimId = "2.0-turbo-super-bva", ModelId = "giulia", BrandId = "alfaromeo", Name = "Cylindrée", Value = "1995 cc" },
            new TrimFeature { Id = 5, FeatureGroupId = 2, TrimId = "2.0-turbo-super-bva", ModelId = "giulia", BrandId = "alfaromeo", Name = "Boîte de vitesses", Value = "Automatique 8 rapports" },
            new TrimFeature { Id = 6, FeatureGroupId = 2, TrimId = "2.0-turbo-super-bva", ModelId = "giulia", BrandId = "alfaromeo", Name = "Transmission", Value = "Propulsion arrière" },
            new TrimFeature { Id = 7, FeatureGroupId = 3, TrimId = "2.0-turbo-super-bva", ModelId = "giulia", BrandId = "alfaromeo", Name = "Vitesse maximale", Value = "235 km/h" },
            new TrimFeature { Id = 8, FeatureGroupId = 3, TrimId = "2.0-turbo-super-bva", ModelId = "giulia", BrandId = "alfaromeo", Name = "0-100 km/h", Value = "6.6 secondes" }
        );
    }
    #endregion

    #region Audi Data
    private static void SeedAudiData(ModelBuilder modelBuilder)
    {
        // Audi Models
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "a3-berline", BrandId = "audi", Name = "A3 Berline", Image = "/models/audi/a3-berline.webp", IsActive = true },
            new Model { Id = "q2", BrandId = "audi", Name = "Q2", Image = "/models/audi/q2.webp", IsActive = true },
            new Model { Id = "q3", BrandId = "audi", Name = "Q3", Image = "/models/audi/q3.webp", IsActive = true },
            new Model { Id = "q3-sportback", BrandId = "audi", Name = "Q3 Sportback", Image = "/models/audi/q3-sportback.webp", IsActive = true },
            new Model { Id = "q8-e-tron", BrandId = "audi", Name = "Q8 e-tron", Image = "/models/audi/q8-e-tron.webp", IsActive = true },
            new Model { Id = "q8-sportback-e-tron", BrandId = "audi", Name = "Q8 Sportback e-tron", Image = "/models/audi/q8-sportback-e-tron.webp", IsActive = true },
            new Model { Id = "e-tron-gt", BrandId = "audi", Name = "e-tron GT", Image = "/models/audi/e-tron-gt.webp", IsActive = true },
            new Model { Id = "q7", BrandId = "audi", Name = "Q7", Image = "/models/audi/q7.webp", IsActive = true },
            new Model { Id = "q8", BrandId = "audi", Name = "Q8", Image = "/models/audi/q8.webp", IsActive = true }
        );

        // Audi A3 Berline Trims
        modelBuilder.Entity<Trim>().HasData(
            new Trim
            {
                Id = "35-tfsi-business-extended",
                BrandId = "audi",
                ModelId = "a3-berline",
                Name = "35 TFSI Business Extended",
                Features = new List<string>
                {
                    "1.5L TFSI Engine",
                    "150 ch",
                    "Manual 6-Speed Transmission",
                    "Front-Wheel Drive",
                    "MMI Navigation System",
                    "Audi Virtual Cockpit",
                    "Dual-Zone Climate Control",
                    "Parking Sensors"
                },
                Price = 349,
                ListPrice = 145000,
                IsActive = true,
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
                Features = new List<string>
                {
                    "1.5L TFSI Engine",
                    "150 ch",
                    "Automatic 7-Speed Transmission",
                    "Front-Wheel Drive",
                    "S Line Package",
                    "MMI Navigation System",
                    "Audi Virtual Cockpit",
                    "LED Headlights"
                },
                Price = 399,
                ListPrice = 155000,
                IsActive = true,
                FullInsurance0PercentPrice = 31.92m,
                FullInsurance4PercentPrice = 23.94m,
                StandardInsurancePrice = 15.99m,
                MaintenancePackagePrice = 49.99m,
                VignettesPrice = 29.99m,
                GeolocalisationPrice = 19.90m,
                PurchaseOptionPrice = 62000.00m
            }
        );

        // Audi A3 Berline Feature Groups
        modelBuilder.Entity<FeatureGroup>().HasData(
            new FeatureGroup
            {
                Id = 4,
                TrimId = "35-tfsi-business-extended",
                ModelId = "a3-berline",
                BrandId = "audi",
                Name = "Caractéristiques"
            },
            new FeatureGroup
            {
                Id = 5,
                TrimId = "35-tfsi-business-extended",
                ModelId = "a3-berline",
                BrandId = "audi",
                Name = "Transmission"
            },
            new FeatureGroup
            {
                Id = 6,
                TrimId = "35-tfsi-business-extended",
                ModelId = "a3-berline",
                BrandId = "audi",
                Name = "Performances"
            }
        );

        // Audi A3 Berline Features
        modelBuilder.Entity<TrimFeature>().HasData(
            new TrimFeature { Id = 9, FeatureGroupId = 4, TrimId = "35-tfsi-business-extended", ModelId = "a3-berline", BrandId = "audi", Name = "Moteur", Value = "1.5L TFSI" },
            new TrimFeature { Id = 10, FeatureGroupId = 4, TrimId = "35-tfsi-business-extended", ModelId = "a3-berline", BrandId = "audi", Name = "Puissance", Value = "150 ch" },
            new TrimFeature { Id = 11, FeatureGroupId = 4, TrimId = "35-tfsi-business-extended", ModelId = "a3-berline", BrandId = "audi", Name = "Couple", Value = "250 Nm" },
            new TrimFeature { Id = 12, FeatureGroupId = 4, TrimId = "35-tfsi-business-extended", ModelId = "a3-berline", BrandId = "audi", Name = "Cylindrée", Value = "1498 cc" },
            new TrimFeature { Id = 13, FeatureGroupId = 5, TrimId = "35-tfsi-business-extended", ModelId = "a3-berline", BrandId = "audi", Name = "Boîte de vitesses", Value = "Manuelle 6 rapports" },
            new TrimFeature { Id = 14, FeatureGroupId = 5, TrimId = "35-tfsi-business-extended", ModelId = "a3-berline", BrandId = "audi", Name = "Transmission", Value = "Traction avant" },
            new TrimFeature { Id = 15, FeatureGroupId = 6, TrimId = "35-tfsi-business-extended", ModelId = "a3-berline", BrandId = "audi", Name = "Vitesse maximale", Value = "224 km/h" },
            new TrimFeature { Id = 16, FeatureGroupId = 6, TrimId = "35-tfsi-business-extended", ModelId = "a3-berline", BrandId = "audi", Name = "0-100 km/h", Value = "8.2 secondes" }
        );
    }
    #endregion

    #region BMW Data
    private static void SeedBMWData(ModelBuilder modelBuilder)
    {
        // BMW Models
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "3-series", BrandId = "bmw", Name = "3 Series", Image = "/models/bmw/3-series.webp", IsActive = true },
            new Model { Id = "5-series", BrandId = "bmw", Name = "5 Series", Image = "/models/bmw/5-series.webp", IsActive = true },
            new Model { Id = "x3", BrandId = "bmw", Name = "X3", Image = "/models/bmw/x3.webp", IsActive = true },
            new Model { Id = "x5", BrandId = "bmw", Name = "X5", Image = "/models/bmw/x5.webp", IsActive = true }
        );

        // Add BMW trims, feature groups, features, and services here when needed
    }
    #endregion

    #region BYD Data
    private static void SeedBYDData(ModelBuilder modelBuilder)
    {
        // BYD Models
        // Add BYD models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Chery Data
    private static void SeedCheryData(ModelBuilder modelBuilder)
    {
        // Chery Models
        // Add Chery models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Chevrolet Data
    private static void SeedChevroletData(ModelBuilder modelBuilder)
    {
        // Chevrolet Models
        // Add Chevrolet models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Citroen Data
    private static void SeedCitroenData(ModelBuilder modelBuilder)
    {
        // Citroen Models
        // Add Citroen models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Cupra Data
    private static void SeedCupraData(ModelBuilder modelBuilder)
    {
        // Cupra Models
        // Add Cupra models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Dacia Data
    private static void SeedDaciaData(ModelBuilder modelBuilder)
    {
        // Dacia Models
        // Add Dacia models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Fiat Data
    private static void SeedFiatData(ModelBuilder modelBuilder)
    {
        // Fiat Models
        // Add Fiat models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Ford Data
    private static void SeedFordData(ModelBuilder modelBuilder)
    {
        // Ford Models
        // Add Ford models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Haval Data
    private static void SeedHavalData(ModelBuilder modelBuilder)
    {
        // Haval Models
        // Add Haval models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Honda Data
    private static void SeedHondaData(ModelBuilder modelBuilder)
    {
        // Honda Models
        // Add Honda models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Hyundai Data
    private static void SeedHyundaiData(ModelBuilder modelBuilder)
    {
        // Hyundai Models
        // Add Hyundai models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Jaguar Data
    private static void SeedJaguarData(ModelBuilder modelBuilder)
    {
        // Jaguar Models
        // Add Jaguar models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Jeep Data
    private static void SeedJeepData(ModelBuilder modelBuilder)
    {
        // Jeep Models
        // Add Jeep models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Kia Data
    private static void SeedKiaData(ModelBuilder modelBuilder)
    {
        // Kia Models
        // Add Kia models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Land Rover Data
    private static void SeedLandRoverData(ModelBuilder modelBuilder)
    {
        // Land Rover Models
        // Add Land Rover models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Mahindra Data
    private static void SeedMahindraData(ModelBuilder modelBuilder)
    {
        // Mahindra Models
        // Add Mahindra models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Mercedes Data
    private static void SeedMercedesData(ModelBuilder modelBuilder)
    {
        // Mercedes Models
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "a-class", BrandId = "mercedes", Name = "A-Class", Image = "/models/mercedes/a-class.webp", IsActive = true },
            new Model { Id = "c-class", BrandId = "mercedes", Name = "C-Class", Image = "/models/mercedes/c-class.webp", IsActive = true },
            new Model { Id = "e-class", BrandId = "mercedes", Name = "E-Class", Image = "/models/mercedes/e-class.webp", IsActive = true },
            new Model { Id = "glc", BrandId = "mercedes", Name = "GLC", Image = "/models/mercedes/glc.webp", IsActive = true }
        );

        // Add Mercedes trims, feature groups, features, and services here when needed
    }
    #endregion

    #region MG Data
    private static void SeedMGData(ModelBuilder modelBuilder)
    {
        // MG Models
        // Add MG models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Mini Data
    private static void SeedMiniData(ModelBuilder modelBuilder)
    {
        // Mini Models
        // Add Mini models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Mitsubishi Data
    private static void SeedMitsubishiData(ModelBuilder modelBuilder)
    {
        // Mitsubishi Models
        // Add Mitsubishi models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Nissan Data
    private static void SeedNissanData(ModelBuilder modelBuilder)
    {
        // Nissan Models
        // Add Nissan models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Opel Data
    private static void SeedOpelData(ModelBuilder modelBuilder)
    {
        // Opel Models
        // Add Opel models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Peugeot Data
    private static void SeedPeugeotData(ModelBuilder modelBuilder)
    {
        // Peugeot Models
        // Add Peugeot models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Porsche Data
    private static void SeedPorscheData(ModelBuilder modelBuilder)
    {
        // Porsche Models
        // Add Porsche models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Renault Data
    private static void SeedRenaultData(ModelBuilder modelBuilder)
    {
        // Renault Models
        // Add Renault models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region SEAT Data
    private static void SeedSeatData(ModelBuilder modelBuilder)
    {
        // SEAT Models
        // Add SEAT models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Skoda Data
    private static void SeedSkodaData(ModelBuilder modelBuilder)
    {
        // Skoda Models
        // Add Skoda models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region KGM Data
    private static void SeedKGMData(ModelBuilder modelBuilder)
    {
        // KGM Models
        // Add KGM models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Suzuki Data
    private static void SeedSuzukiData(ModelBuilder modelBuilder)
    {
        // Suzuki Models
        // Add Suzuki models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Toyota Data
    private static void SeedToyotaData(ModelBuilder modelBuilder)
    {
        // Toyota Models
        // Add Toyota models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Volkswagen Data
    private static void SeedVolkswagenData(ModelBuilder modelBuilder)
    {
        // Volkswagen Models
        // Add Volkswagen models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Volvo Data
    private static void SeedVolvoData(ModelBuilder modelBuilder)
    {
        // Volvo Models
        // Add Volvo models, trims, feature groups, features, and services here when needed
    }
    #endregion

    #region Wallys Data
    private static void SeedWallysData(ModelBuilder modelBuilder)
    {
        // Wallys Models
        // Add Wallys models, trims, feature groups, features, and services here when needed
    }
    #endregion
}
