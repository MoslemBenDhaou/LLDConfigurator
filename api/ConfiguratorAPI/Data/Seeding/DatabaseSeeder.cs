using ConfiguratorAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ConfiguratorAPI.Data.Seeding;

public static class DatabaseSeeder
{
    public static void SeedDatabase(this ModelBuilder modelBuilder)
    {
        // Seed brands first
        SeedBrands(modelBuilder);
        
        // Seed models
        SeedAlfaRomeoModels(modelBuilder);
        SeedAudiModels(modelBuilder);
        SeedBMWModels(modelBuilder);
        SeedBYDModels(modelBuilder);
        SeedCheryModels(modelBuilder);
        SeedChevroletModels(modelBuilder);
        SeedCitroenModels(modelBuilder);
        SeedCupraModels(modelBuilder);
        SeedDaciaModels(modelBuilder);
        SeedFiatModels(modelBuilder);
        SeedFordModels(modelBuilder);
        SeedHavalModels(modelBuilder);
        SeedHondaModels(modelBuilder);
        SeedHyundaiModels(modelBuilder);
        SeedJaguarModels(modelBuilder);
        SeedJeepModels(modelBuilder);
        SeedKiaModels(modelBuilder);
        SeedLandRoverModels(modelBuilder);
        SeedMahindraModels(modelBuilder);
        SeedMercedesModels(modelBuilder);
        SeedMGModels(modelBuilder);
        SeedMiniModels(modelBuilder);
        SeedMitsubishiModels(modelBuilder);
        SeedNissanModels(modelBuilder);
        SeedOpelModels(modelBuilder);
        SeedPeugeotModels(modelBuilder);
        SeedPorscheModels(modelBuilder);
        SeedRenaultModels(modelBuilder);
        SeedSeatModels(modelBuilder);
        SeedSkodaModels(modelBuilder);
        SeedKGMModels(modelBuilder);
        SeedSuzukiModels(modelBuilder);
        SeedToyotaModels(modelBuilder);
        SeedVolkswagenModels(modelBuilder);
        SeedVolvoModels(modelBuilder);
        SeedWallysModels(modelBuilder);
        
        // Seed trims using the dedicated TrimSeeder
        TrimSeeder.SeedTrims(modelBuilder);
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

    private static void SeedAlfaRomeoModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "giulia", BrandId = "alfaromeo", Name = "Giulia", Image = "/models/alfaromeo/giulia.webp", IsActive = true },
            new Model { Id = "stelvio", BrandId = "alfaromeo", Name = "Stelvio", Image = "/models/alfaromeo/stelvio.webp", IsActive = true }
        );
    }

    private static void SeedAudiModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "a3berline", BrandId = "audi", Name = "A3 Berline", Image = "/models/audi/a3berline.webp", IsActive = true },
            new Model { Id = "q2", BrandId = "audi", Name = "Q2", Image = "/models/audi/q2.webp", IsActive = true },
            new Model { Id = "q3", BrandId = "audi", Name = "Q3", Image = "/models/audi/q3.webp", IsActive = true },
            new Model { Id = "q3sportback", BrandId = "audi", Name = "Q3 Sportback", Image = "/models/audi/q3sportback.webp", IsActive = true },
            new Model { Id = "q8etron", BrandId = "audi", Name = "Q8 e-tron", Image = "/models/audi/q8etron.webp", IsActive = true },
            new Model { Id = "q8sportbacketron", BrandId = "audi", Name = "Q8 Sportback e-tron", Image = "/models/audi/q8sportbacketron.webp", IsActive = true },
            new Model { Id = "etrongt", BrandId = "audi", Name = "e-tron GT", Image = "/models/audi/etrongt.webp", IsActive = true },
            new Model { Id = "q7", BrandId = "audi", Name = "Q7", Image = "/models/audi/q7.webp", IsActive = true },
            new Model { Id = "q8", BrandId = "audi", Name = "Q8", Image = "/models/audi/q8.webp", IsActive = true }
        );
    }

    private static void SeedBMWModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "1", BrandId = "bmw", Name = "1 Series", Image = "/models/bmw/1.webp", IsActive = true },
            new Model { Id = "2grancoupe", BrandId = "bmw", Name = "2 Gran Coupé", Image = "/models/bmw/2grancoupe.webp", IsActive = true },
            new Model { Id = "3", BrandId = "bmw", Name = "3 Series", Image = "/models/bmw/3.webp", IsActive = true },
            new Model { Id = "4grancoupe", BrandId = "bmw", Name = "4 Gran Coupé", Image = "/models/bmw/4grancoupe.webp", IsActive = true },
            new Model { Id = "5", BrandId = "bmw", Name = "5 Series", Image = "/models/bmw/5.webp", IsActive = true },
            new Model { Id = "i4", BrandId = "bmw", Name = "i4", Image = "/models/bmw/i4.webp", IsActive = true },
            new Model { Id = "i5", BrandId = "bmw", Name = "i5", Image = "/models/bmw/i5.webp", IsActive = true },
            new Model { Id = "ix", BrandId = "bmw", Name = "iX", Image = "/models/bmw/ix.webp", IsActive = true },
            new Model { Id = "ix1", BrandId = "bmw", Name = "iX1", Image = "/models/bmw/ix1.webp", IsActive = true },
            new Model { Id = "ix2", BrandId = "bmw", Name = "iX2", Image = "/models/bmw/ix2.webp", IsActive = true },
            new Model { Id = "ix3", BrandId = "bmw", Name = "iX3", Image = "/models/bmw/ix3.webp", IsActive = true },
            new Model { Id = "x1", BrandId = "bmw", Name = "X1", Image = "/models/bmw/x1.webp", IsActive = true },
            new Model { Id = "x1hybride", BrandId = "bmw", Name = "X1 Hybride", Image = "/models/bmw/x1hybride.webp", IsActive = true },
            new Model { Id = "x2", BrandId = "bmw", Name = "X2", Image = "/models/bmw/x2.webp", IsActive = true },
            new Model { Id = "x3hybride", BrandId = "bmw", Name = "X3 Hybride", Image = "/models/bmw/x3hybride.webp", IsActive = true },
            new Model { Id = "x4", BrandId = "bmw", Name = "X4", Image = "/models/bmw/x4.webp", IsActive = true },
            new Model { Id = "x5hybride", BrandId = "bmw", Name = "X5 Hybride", Image = "/models/bmw/x5hybride.webp", IsActive = true }
        );
    }

    private static void SeedBYDModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "atto3", BrandId = "byd", Name = "Atto 3", Image = "/models/byd/atto3.webp", IsActive = true },
            new Model { Id = "dolphin", BrandId = "byd", Name = "Dolphin", Image = "/models/byd/dolphin.webp", IsActive = true },
            new Model { Id = "king", BrandId = "byd", Name = "King", Image = "/models/byd/king.webp", IsActive = true },
            new Model { Id = "songplus", BrandId = "byd", Name = "Song Plus", Image = "/models/byd/songplus.webp", IsActive = true },
            new Model { Id = "tangev", BrandId = "byd", Name = "Tang EV", Image = "/models/byd/tangev.webp", IsActive = true }
        );
    }

    private static void SeedCheryModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "arrizo5", BrandId = "chery", Name = "Arrizo 5", Image = "/models/chery/arrizo5.webp", IsActive = true },
            new Model { Id = "tiggo3x", BrandId = "chery", Name = "Tiggo 3X", Image = "/models/chery/tiggo3x.webp", IsActive = true },
            new Model { Id = "tiggo4pro", BrandId = "chery", Name = "Tiggo 4 Pro", Image = "/models/chery/tiggo4pro.webp", IsActive = true },
            new Model { Id = "tiggo7pro", BrandId = "chery", Name = "Tiggo 7 Pro", Image = "/models/chery/tiggo7pro.webp", IsActive = true },
            new Model { Id = "tiggo8pro", BrandId = "chery", Name = "Tiggo 8 Pro", Image = "/models/chery/tiggo8pro.webp", IsActive = true }
        );
    }

    private static void SeedChevroletModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "captiva", BrandId = "chevrolet", Name = "Captiva", Image = "/models/chevrolet/captiva.webp", IsActive = true },
            new Model { Id = "equinox", BrandId = "chevrolet", Name = "Equinox", Image = "/models/chevrolet/equinox.webp", IsActive = true },
            new Model { Id = "groove", BrandId = "chevrolet", Name = "Groove", Image = "/models/chevrolet/groove.webp", IsActive = true }
        );
    }

    private static void SeedCitroenModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "berlingo", BrandId = "citroen", Name = "Berlingo", Image = "/models/citroen/berlingo.webp", IsActive = true },
            new Model { Id = "berlingovan", BrandId = "citroen", Name = "Berlingo Van", Image = "/models/citroen/berlingovan.webp", IsActive = true },
            new Model { Id = "c4x", BrandId = "citroen", Name = "C4X", Image = "/models/citroen/c4x.webp", IsActive = true },
            new Model { Id = "jumper", BrandId = "citroen", Name = "Jumper", Image = "/models/citroen/jumper.webp", IsActive = true },
            new Model { Id = "jumpyfourgon", BrandId = "citroen", Name = "Jumpy Fourgon", Image = "/models/citroen/jumpyfourgon.webp", IsActive = true }
        );
    }

    private static void SeedCupraModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "formentor", BrandId = "cupra", Name = "Formentor", Image = "/models/cupra/formentor.webp", IsActive = true },
            new Model { Id = "leon", BrandId = "cupra", Name = "Leon", Image = "/models/cupra/leon.webp", IsActive = true }
        );
    }

    private static void SeedDaciaModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "duster", BrandId = "dacia", Name = "Duster", Image = "/models/dacia/duster.webp", IsActive = true },
            new Model { Id = "logan", BrandId = "dacia", Name = "Logan", Image = "/models/dacia/logan.webp", IsActive = true },
            new Model { Id = "sandero", BrandId = "dacia", Name = "Sandero", Image = "/models/dacia/sandero.webp", IsActive = true },
            new Model { Id = "sanderostepway", BrandId = "dacia", Name = "Sandero Stepway", Image = "/models/dacia/sanderostepway.webp", IsActive = true }
        );
    }

    private static void SeedFiatModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "500", BrandId = "fiat", Name = "500", Image = "/models/fiat/500.webp", IsActive = true },
            new Model { Id = "doblo", BrandId = "fiat", Name = "Doblo", Image = "/models/fiat/doblo.webp", IsActive = true },
            new Model { Id = "doblocombi", BrandId = "fiat", Name = "Doblo Combi", Image = "/models/fiat/doblocombi.webp", IsActive = true },
            new Model { Id = "ducato", BrandId = "fiat", Name = "Ducato", Image = "/models/fiat/ducato.webp", IsActive = true },
            new Model { Id = "fiorinocombi", BrandId = "fiat", Name = "Fiorino Combi", Image = "/models/fiat/fiorinocombi.webp", IsActive = true },
            new Model { Id = "tipoberline", BrandId = "fiat", Name = "Tipo Berline", Image = "/models/fiat/tipoberline.webp", IsActive = true }
        );
    }

    private static void SeedFordModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "everest", BrandId = "ford", Name = "Everest", Image = "/models/ford/everest.webp", IsActive = true },
            new Model { Id = "ranger", BrandId = "ford", Name = "Ranger", Image = "/models/ford/ranger.webp", IsActive = true },
            new Model { Id = "rangerraptor", BrandId = "ford", Name = "Ranger Raptor", Image = "/models/ford/rangerraptor.webp", IsActive = true },
            new Model { Id = "transitvan", BrandId = "ford", Name = "Transit Van", Image = "/models/ford/transitvan.webp", IsActive = true }
        );
    }

    private static void SeedHavalModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "h6hybride", BrandId = "haval", Name = "H6 Hybride", Image = "/models/haval/h6hybride.webp", IsActive = true },
            new Model { Id = "jolion", BrandId = "haval", Name = "Jolion", Image = "/models/haval/jolion.webp", IsActive = true }
        );
    }

    private static void SeedHondaModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "accord", BrandId = "honda", Name = "Accord", Image = "/models/honda/accord.webp", IsActive = true },
            new Model { Id = "city", BrandId = "honda", Name = "City", Image = "/models/honda/city.webp", IsActive = true },
            new Model { Id = "civic", BrandId = "honda", Name = "Civic", Image = "/models/honda/civic.webp", IsActive = true },
            new Model { Id = "civichybride", BrandId = "honda", Name = "Civic Hybride", Image = "/models/honda/civichybride.webp", IsActive = true },
            new Model { Id = "civictyper", BrandId = "honda", Name = "Civic Type R", Image = "/models/honda/civictyper.webp", IsActive = true },
            new Model { Id = "crv", BrandId = "honda", Name = "CR-V", Image = "/models/honda/crv.webp", IsActive = true },
            new Model { Id = "crvhybride", BrandId = "honda", Name = "CR-V Hybride", Image = "/models/honda/crvhybride.webp", IsActive = true },
            new Model { Id = "hrv", BrandId = "honda", Name = "HR-V", Image = "/models/honda/hrv.webp", IsActive = true },
            new Model { Id = "jazz", BrandId = "honda", Name = "Jazz", Image = "/models/honda/jazz.webp", IsActive = true },
            new Model { Id = "zrv", BrandId = "honda", Name = "ZR-V", Image = "/models/honda/zrv.webp", IsActive = true }
        );
    }

    private static void SeedHyundaiModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "azerahybride", BrandId = "hyundai", Name = "Azera Hybride", Image = "/models/hyundai/azerahybride.webp", IsActive = true },
            new Model { Id = "creta", BrandId = "hyundai", Name = "Creta", Image = "/models/hyundai/creta.webp", IsActive = true },
            new Model { Id = "i10", BrandId = "hyundai", Name = "i10", Image = "/models/hyundai/i10.webp", IsActive = true },
            new Model { Id = "i10sedan", BrandId = "hyundai", Name = "i10 Sedan", Image = "/models/hyundai/i10sedan.webp", IsActive = true },
            new Model { Id = "i20", BrandId = "hyundai", Name = "i20", Image = "/models/hyundai/i20.webp", IsActive = true },
            new Model { Id = "ioniq5", BrandId = "hyundai", Name = "IONIQ 5", Image = "/models/hyundai/ioniq5.webp", IsActive = true },
            new Model { Id = "kona", BrandId = "hyundai", Name = "Kona", Image = "/models/hyundai/kona.webp", IsActive = true },
            new Model { Id = "konaelectric", BrandId = "hyundai", Name = "Kona Electric", Image = "/models/hyundai/konaelectric.webp", IsActive = true },
            new Model { Id = "palisadecalligraphy", BrandId = "hyundai", Name = "Palisade Calligraphy", Image = "/models/hyundai/palisadecalligraphy.webp", IsActive = true },
            new Model { Id = "staria", BrandId = "hyundai", Name = "Staria", Image = "/models/hyundai/staria.webp", IsActive = true },
            new Model { Id = "tucson", BrandId = "hyundai", Name = "Tucson", Image = "/models/hyundai/tucson.webp", IsActive = true },
            new Model { Id = "tucsonhybride", BrandId = "hyundai", Name = "Tucson Hybride", Image = "/models/hyundai/tucsonhybride.webp", IsActive = true },
            new Model { Id = "venue", BrandId = "hyundai", Name = "Venue", Image = "/models/hyundai/venue.webp", IsActive = true }
        );
    }

    private static void SeedJaguarModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "epace", BrandId = "jaguar", Name = "E-Pace", Image = "/models/jaguar/epace.webp", IsActive = true },
            new Model { Id = "fpace", BrandId = "jaguar", Name = "F-Pace", Image = "/models/jaguar/fpace.webp", IsActive = true }
        );
    }

    private static void SeedJeepModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "renegade", BrandId = "jeep", Name = "Renegade", Image = "/models/jeep/renegade.webp", IsActive = true },
            new Model { Id = "wrangler", BrandId = "jeep", Name = "Wrangler", Image = "/models/jeep/wrangler.webp", IsActive = true },
            new Model { Id = "wranglerunlimited", BrandId = "jeep", Name = "Wrangler Unlimited", Image = "/models/jeep/wranglerunlimited.webp", IsActive = true }
        );
    }

    private static void SeedKiaModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "ev6", BrandId = "kia", Name = "EV6", Image = "/models/kia/ev6.webp", IsActive = true },
            new Model { Id = "ev6gt", BrandId = "kia", Name = "EV6 GT", Image = "/models/kia/ev6gt.webp", IsActive = true },
            new Model { Id = "nirohybride", BrandId = "kia", Name = "Niro Hybride", Image = "/models/kia/nirohybride.webp", IsActive = true },
            new Model { Id = "picanto", BrandId = "kia", Name = "Picanto", Image = "/models/kia/picanto.webp", IsActive = true },
            new Model { Id = "seltos", BrandId = "kia", Name = "Seltos", Image = "/models/kia/seltos.webp", IsActive = true },
            new Model { Id = "sonet", BrandId = "kia", Name = "Sonet", Image = "/models/kia/sonet.webp", IsActive = true },
            new Model { Id = "sportage", BrandId = "kia", Name = "Sportage", Image = "/models/kia/sportage.webp", IsActive = true },
            new Model { Id = "sportagehypride", BrandId = "kia", Name = "Sportage Hybride", Image = "/models/kia/sportagehypride.webp", IsActive = true },
            new Model { Id = "stonic", BrandId = "kia", Name = "Stonic", Image = "/models/kia/stonic.webp", IsActive = true }
        );
    }

    private static void SeedLandRoverModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "defender110", BrandId = "landrover", Name = "Defender 110", Image = "/models/landrover/defender110.webp", IsActive = true },
            new Model { Id = "evoque", BrandId = "landrover", Name = "Evoque", Image = "/models/landrover/evoque.webp", IsActive = true },
            new Model { Id = "rangerover", BrandId = "landrover", Name = "Range Rover", Image = "/models/landrover/rangerover.webp", IsActive = true },
            new Model { Id = "rangeroversport", BrandId = "landrover", Name = "Range Rover Sport", Image = "/models/landrover/rangeroversport.webp", IsActive = true },
            new Model { Id = "velar", BrandId = "landrover", Name = "Velar", Image = "/models/landrover/velar.webp", IsActive = true }
        );
    }

    private static void SeedMahindraModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "kuv100", BrandId = "mahindra", Name = "KUV100", Image = "/models/mahindra/kuv100.webp", IsActive = true },
            new Model { Id = "xuv300", BrandId = "mahindra", Name = "XUV300", Image = "/models/mahindra/xuv300.webp", IsActive = true }
        );
    }

    private static void SeedMercedesModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "a", BrandId = "mercedes", Name = "A-Class", Image = "/models/mercedes/a.webp", IsActive = true },
            new Model { Id = "aberline", BrandId = "mercedes", Name = "A-Class Berline", Image = "/models/mercedes/aberline.webp", IsActive = true },
            new Model { Id = "c", BrandId = "mercedes", Name = "C-Class", Image = "/models/mercedes/c.webp", IsActive = true },
            new Model { Id = "chybride", BrandId = "mercedes", Name = "C-Class Hybride", Image = "/models/mercedes/chybride.webp", IsActive = true },
            new Model { Id = "cla", BrandId = "mercedes", Name = "CLA", Image = "/models/mercedes/cla.webp", IsActive = true },
            new Model { Id = "clecoupe", BrandId = "mercedes", Name = "CLE Coupé", Image = "/models/mercedes/clecoupe.webp", IsActive = true },
            new Model { Id = "e", BrandId = "mercedes", Name = "E-Class", Image = "/models/mercedes/e.webp", IsActive = true },
            new Model { Id = "ehybride", BrandId = "mercedes", Name = "E-Class Hybride", Image = "/models/mercedes/ehybride.webp", IsActive = true },
            new Model { Id = "eqeberline", BrandId = "mercedes", Name = "EQE Berline", Image = "/models/mercedes/eqeberline.webp", IsActive = true },
            new Model { Id = "eqesuv", BrandId = "mercedes", Name = "EQE SUV", Image = "/models/mercedes/eqesuv.webp", IsActive = true },
            new Model { Id = "eqsberline", BrandId = "mercedes", Name = "EQS Berline", Image = "/models/mercedes/eqsberline.webp", IsActive = true },
            new Model { Id = "eqssuv", BrandId = "mercedes", Name = "EQS SUV", Image = "/models/mercedes/eqssuv.webp", IsActive = true },
            new Model { Id = "gla", BrandId = "mercedes", Name = "GLA", Image = "/models/mercedes/gla.webp", IsActive = true },
            new Model { Id = "glb", BrandId = "mercedes", Name = "GLB", Image = "/models/mercedes/glb.webp", IsActive = true },
            new Model { Id = "glc", BrandId = "mercedes", Name = "GLC", Image = "/models/mercedes/glc.webp", IsActive = true },
            new Model { Id = "glccoupe", BrandId = "mercedes", Name = "GLC Coupé", Image = "/models/mercedes/glccoupe.webp", IsActive = true },
            new Model { Id = "glccoupehybride", BrandId = "mercedes", Name = "GLC Coupé Hybride", Image = "/models/mercedes/glccoupehybride.webp", IsActive = true },
            new Model { Id = "glchybride", BrandId = "mercedes", Name = "GLC Hybride", Image = "/models/mercedes/glchybride.webp", IsActive = true },
            new Model { Id = "gle", BrandId = "mercedes", Name = "GLE", Image = "/models/mercedes/gle.webp", IsActive = true },
            new Model { Id = "glecoupe", BrandId = "mercedes", Name = "GLE Coupé", Image = "/models/mercedes/glecoupe.webp", IsActive = true },
            new Model { Id = "s", BrandId = "mercedes", Name = "S-Class", Image = "/models/mercedes/s.webp", IsActive = true },
            new Model { Id = "v", BrandId = "mercedes", Name = "V-Class", Image = "/models/mercedes/v.webp", IsActive = true }
        );
    }

    private static void SeedMGModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "3", BrandId = "mg", Name = "MG3", Image = "/models/mg/3.webp", IsActive = true },
            new Model { Id = "3hybride", BrandId = "mg", Name = "MG3 Hybride", Image = "/models/mg/3hybride.webp", IsActive = true },
            new Model { Id = "4", BrandId = "mg", Name = "MG4", Image = "/models/mg/4.webp", IsActive = true },
            new Model { Id = "5", BrandId = "mg", Name = "MG5", Image = "/models/mg/5.webp", IsActive = true },
            new Model { Id = "7", BrandId = "mg", Name = "MG7", Image = "/models/mg/7.webp", IsActive = true },
            new Model { Id = "ehs", BrandId = "mg", Name = "eHS", Image = "/models/mg/ehs.webp", IsActive = true },
            new Model { Id = "ezs", BrandId = "mg", Name = "eZS", Image = "/models/mg/ezs.webp", IsActive = true },
            new Model { Id = "gt", BrandId = "mg", Name = "GT", Image = "/models/mg/gt.webp", IsActive = true },
            new Model { Id = "marvelr", BrandId = "mg", Name = "Marvel R", Image = "/models/mg/marvelr.webp", IsActive = true },
            new Model { Id = "one", BrandId = "mg", Name = "One", Image = "/models/mg/one.webp", IsActive = true },
            new Model { Id = "rx5", BrandId = "mg", Name = "RX5", Image = "/models/mg/rx5.webp", IsActive = true },
            new Model { Id = "zs", BrandId = "mg", Name = "ZS", Image = "/models/mg/zs.webp", IsActive = true }
        );
    }

    private static void SeedMiniModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "aceman", BrandId = "mini", Name = "Aceman", Image = "/models/mini/aceman.webp", IsActive = true },
            new Model { Id = "coopercabrio", BrandId = "mini", Name = "Cooper Cabrio", Image = "/models/mini/coopercabrio.webp", IsActive = true },
            new Model { Id = "countryman", BrandId = "mini", Name = "Countryman", Image = "/models/mini/countryman.webp", IsActive = true },
            new Model { Id = "couperelectric", BrandId = "mini", Name = "Cooper Electric", Image = "/models/mini/couperelectric.webp", IsActive = true }
        );
    }

    private static void SeedMitsubishiModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "asx", BrandId = "mitsubishi", Name = "ASX", Image = "/models/mitsubishi/asx.webp", IsActive = true },
            new Model { Id = "eclipsecross", BrandId = "mitsubishi", Name = "Eclipse Cross", Image = "/models/mitsubishi/eclipsecross.webp", IsActive = true },
            new Model { Id = "l200", BrandId = "mitsubishi", Name = "L200", Image = "/models/mitsubishi/l200.webp", IsActive = true },
            new Model { Id = "pajero", BrandId = "mitsubishi", Name = "Pajero", Image = "/models/mitsubishi/pajero.webp", IsActive = true },
            new Model { Id = "pajerosport", BrandId = "mitsubishi", Name = "Pajero Sport", Image = "/models/mitsubishi/pajerosport.webp", IsActive = true }
        );
    }

    private static void SeedNissanModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "juke", BrandId = "nissan", Name = "Juke", Image = "/models/nissan/juke.webp", IsActive = true },
            new Model { Id = "qashqai", BrandId = "nissan", Name = "Qashqai", Image = "/models/nissan/qashqai.webp", IsActive = true },
            new Model { Id = "qashqaiepower", BrandId = "nissan", Name = "Qashqai e-Power", Image = "/models/nissan/qashqaiepower.webp", IsActive = true }
        );
    }

    private static void SeedOpelModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "astra", BrandId = "opel", Name = "Astra", Image = "/models/opel/astra.webp", IsActive = true },
            new Model { Id = "combocargo", BrandId = "opel", Name = "Combo Cargo", Image = "/models/opel/combocargo.webp", IsActive = true },
            new Model { Id = "corsa", BrandId = "opel", Name = "Corsa", Image = "/models/opel/corsa.webp", IsActive = true },
            new Model { Id = "crossland", BrandId = "opel", Name = "Crossland", Image = "/models/opel/crossland.webp", IsActive = true },
            new Model { Id = "mokka", BrandId = "opel", Name = "Mokka", Image = "/models/opel/mokka.webp", IsActive = true }
        );
    }

    private static void SeedPeugeotModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "2008", BrandId = "peugeot", Name = "2008", Image = "/models/peugeot/2008.webp", IsActive = true },
            new Model { Id = "208", BrandId = "peugeot", Name = "208", Image = "/models/peugeot/208.webp", IsActive = true },
            new Model { Id = "308", BrandId = "peugeot", Name = "308", Image = "/models/peugeot/308.webp", IsActive = true },
            new Model { Id = "408", BrandId = "peugeot", Name = "408", Image = "/models/peugeot/408.webp", IsActive = true },
            new Model { Id = "408gt", BrandId = "peugeot", Name = "408 GT", Image = "/models/peugeot/408gt.webp", IsActive = true },
            new Model { Id = "boxer", BrandId = "peugeot", Name = "Boxer", Image = "/models/peugeot/boxer.webp", IsActive = true },
            new Model { Id = "boxerdouble", BrandId = "peugeot", Name = "Boxer Double", Image = "/models/peugeot/boxerdouble.webp", IsActive = true },
            new Model { Id = "expert", BrandId = "peugeot", Name = "Expert", Image = "/models/peugeot/expert.webp", IsActive = true },
            new Model { Id = "expertcombi", BrandId = "peugeot", Name = "Expert Combi", Image = "/models/peugeot/expertcombi.webp", IsActive = true },
            new Model { Id = "landtrekdouble", BrandId = "peugeot", Name = "Landtrek Double", Image = "/models/peugeot/landtrekdouble.webp", IsActive = true },
            new Model { Id = "landtreksimple", BrandId = "peugeot", Name = "Landtrek Simple", Image = "/models/peugeot/landtreksimple.webp", IsActive = true },
            new Model { Id = "partner", BrandId = "peugeot", Name = "Partner", Image = "/models/peugeot/partner.webp", IsActive = true },
            new Model { Id = "rifter", BrandId = "peugeot", Name = "Rifter", Image = "/models/peugeot/rifter.webp", IsActive = true },
            new Model { Id = "traveller", BrandId = "peugeot", Name = "Traveller", Image = "/models/peugeot/traveller.webp", IsActive = true }
        );
    }

    private static void SeedPorscheModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "911", BrandId = "porsche", Name = "911", Image = "/models/porsche/911.webp", IsActive = true },
            new Model { Id = "cayenne", BrandId = "porsche", Name = "Cayenne", Image = "/models/porsche/cayenne.webp", IsActive = true },
            new Model { Id = "cayennecoupe", BrandId = "porsche", Name = "Cayenne Coupé", Image = "/models/porsche/cayennecoupe.webp", IsActive = true },
            new Model { Id = "macanelectric", BrandId = "porsche", Name = "Macan Electric", Image = "/models/porsche/macanelectric.webp", IsActive = true },
            new Model { Id = "taycan", BrandId = "porsche", Name = "Taycan", Image = "/models/porsche/taycan.webp", IsActive = true },
            new Model { Id = "taycancrossturismo", BrandId = "porsche", Name = "Taycan Cross Turismo", Image = "/models/porsche/taycancrossturismo.webp", IsActive = true }
        );
    }

    private static void SeedRenaultModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "austral", BrandId = "renault", Name = "Austral", Image = "/models/renault/austral.webp", IsActive = true },
            new Model { Id = "clio", BrandId = "renault", Name = "Clio", Image = "/models/renault/clio.webp", IsActive = true },
            new Model { Id = "expresscombi", BrandId = "renault", Name = "Express Combi", Image = "/models/renault/expresscombi.webp", IsActive = true },
            new Model { Id = "expressvan", BrandId = "renault", Name = "Express Van", Image = "/models/renault/expressvan.webp", IsActive = true },
            new Model { Id = "master", BrandId = "renault", Name = "Master", Image = "/models/renault/master.webp", IsActive = true },
            new Model { Id = "megane", BrandId = "renault", Name = "Megane", Image = "/models/renault/megane.webp", IsActive = true },
            new Model { Id = "meganesedan", BrandId = "renault", Name = "Megane Sedan", Image = "/models/renault/meganesedan.webp", IsActive = true }
        );
    }

    private static void SeedSeatModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "arona", BrandId = "seat", Name = "Arona", Image = "/models/seat/arona.webp", IsActive = true },
            new Model { Id = "ateca", BrandId = "seat", Name = "Ateca", Image = "/models/seat/ateca.webp", IsActive = true },
            new Model { Id = "ibiza", BrandId = "seat", Name = "Ibiza", Image = "/models/seat/ibiza.webp", IsActive = true },
            new Model { Id = "leon", BrandId = "seat", Name = "Leon", Image = "/models/seat/leon.webp", IsActive = true }
        );
    }

    private static void SeedSkodaModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "fabia", BrandId = "skoda", Name = "Fabia", Image = "/models/skoda/fabia.webp", IsActive = true },
            new Model { Id = "kamiq", BrandId = "skoda", Name = "Kamiq", Image = "/models/skoda/kamiq.webp", IsActive = true },
            new Model { Id = "kushaq", BrandId = "skoda", Name = "Kushaq", Image = "/models/skoda/kushaq.webp", IsActive = true },
            new Model { Id = "octavia", BrandId = "skoda", Name = "Octavia", Image = "/models/skoda/octavia.webp", IsActive = true },
            new Model { Id = "scala", BrandId = "skoda", Name = "Scala", Image = "/models/skoda/scala.webp", IsActive = true }
        );
    }

    private static void SeedKGMModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "korando", BrandId = "kgm", Name = "Korando", Image = "/models/kgm/korando.webp", IsActive = true },
            new Model { Id = "musso", BrandId = "kgm", Name = "Musso", Image = "/models/kgm/musso.webp", IsActive = true },
            new Model { Id = "rexton", BrandId = "kgm", Name = "Rexton", Image = "/models/kgm/rexton.webp", IsActive = true },
            new Model { Id = "tivoli", BrandId = "kgm", Name = "Tivoli", Image = "/models/kgm/tivoli.webp", IsActive = true },
            new Model { Id = "torres", BrandId = "kgm", Name = "Torres", Image = "/models/kgm/torres.webp", IsActive = true }
        );
    }

    private static void SeedSuzukiModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "baleno", BrandId = "suzuki", Name = "Baleno", Image = "/models/suzuki/baleno.webp", IsActive = true },
            new Model { Id = "ciaz", BrandId = "suzuki", Name = "Ciaz", Image = "/models/suzuki/ciaz.webp", IsActive = true },
            new Model { Id = "dzire", BrandId = "suzuki", Name = "Dzire", Image = "/models/suzuki/dzire.webp", IsActive = true },
            new Model { Id = "ertiga", BrandId = "suzuki", Name = "Ertiga", Image = "/models/suzuki/ertiga.webp", IsActive = true },
            new Model { Id = "fronx", BrandId = "suzuki", Name = "Fronx", Image = "/models/suzuki/fronx.webp", IsActive = true },
            new Model { Id = "jimny3p", BrandId = "suzuki", Name = "Jimny 3 Portes", Image = "/models/suzuki/jimny3p.webp", IsActive = true },
            new Model { Id = "jimny5p", BrandId = "suzuki", Name = "Jimny 5 Portes", Image = "/models/suzuki/jimny5p.webp", IsActive = true },
            new Model { Id = "swift", BrandId = "suzuki", Name = "Swift", Image = "/models/suzuki/swift.webp", IsActive = true }
        );
    }

    private static void SeedToyotaModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "corollasedan", BrandId = "toyota", Name = "Corolla Sedan", Image = "/models/toyota/corollasedan.webp", IsActive = true },
            new Model { Id = "corollasedanhybride", BrandId = "toyota", Name = "Corolla Sedan Hybride", Image = "/models/toyota/corollasedanhybride.webp", IsActive = true },
            new Model { Id = "fortuner", BrandId = "toyota", Name = "Fortuner", Image = "/models/toyota/fortuner.webp", IsActive = true },
            new Model { Id = "hiacevan", BrandId = "toyota", Name = "Hiace Van", Image = "/models/toyota/hiacevan.webp", IsActive = true },
            new Model { Id = "hiluxdouble", BrandId = "toyota", Name = "Hilux Double Cabine", Image = "/models/toyota/hiluxdouble.webp", IsActive = true },
            new Model { Id = "hiluxsimple", BrandId = "toyota", Name = "Hilux Simple Cabine", Image = "/models/toyota/hiluxsimple.webp", IsActive = true },
            new Model { Id = "landcruiser300", BrandId = "toyota", Name = "Land Cruiser 300", Image = "/models/toyota/landcruiser300.webp", IsActive = true },
            new Model { Id = "landcruiser76", BrandId = "toyota", Name = "Land Cruiser 76", Image = "/models/toyota/landcruiser76.webp", IsActive = true },
            new Model { Id = "landcruiser79", BrandId = "toyota", Name = "Land Cruiser 79", Image = "/models/toyota/landcruiser79.webp", IsActive = true },
            new Model { Id = "prado", BrandId = "toyota", Name = "Land Cruiser Prado", Image = "/models/toyota/prado.webp", IsActive = true },
            new Model { Id = "rav4hybride", BrandId = "toyota", Name = "RAV4 Hybride", Image = "/models/toyota/rav4hybride.webp", IsActive = true },
            new Model { Id = "yariscrosshybride", BrandId = "toyota", Name = "Yaris Cross Hybride", Image = "/models/toyota/yariscrosshybride.webp", IsActive = true },
            new Model { Id = "yarishybride", BrandId = "toyota", Name = "Yaris Hybride", Image = "/models/toyota/yarishybride.webp", IsActive = true }
        );
    }

    private static void SeedVolkswagenModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "amarok", BrandId = "volkswagen", Name = "Amarok", Image = "/models/volkswagen/amarok.webp", IsActive = true },
            new Model { Id = "caddycargo", BrandId = "volkswagen", Name = "Caddy Cargo", Image = "/models/volkswagen/caddycargo.webp", IsActive = true },
            new Model { Id = "golf8", BrandId = "volkswagen", Name = "Golf 8", Image = "/models/volkswagen/golf8.webp", IsActive = true },
            new Model { Id = "polo", BrandId = "volkswagen", Name = "Polo", Image = "/models/volkswagen/polo.webp", IsActive = true },
            new Model { Id = "tcross", BrandId = "volkswagen", Name = "T-Cross", Image = "/models/volkswagen/tcross.webp", IsActive = true },
            new Model { Id = "tiguan", BrandId = "volkswagen", Name = "Tiguan", Image = "/models/volkswagen/tiguan.webp", IsActive = true },
            new Model { Id = "virtus", BrandId = "volkswagen", Name = "Virtus", Image = "/models/volkswagen/virtus.webp", IsActive = true }
        );
    }

    private static void SeedVolvoModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "ec40", BrandId = "volvo", Name = "EC40", Image = "/models/volvo/ec40.webp", IsActive = true },
            new Model { Id = "ex30", BrandId = "volvo", Name = "EX30", Image = "/models/volvo/ex30.webp", IsActive = true },
            new Model { Id = "xc40", BrandId = "volvo", Name = "XC40", Image = "/models/volvo/xc40.webp", IsActive = true },
            new Model { Id = "xc60", BrandId = "volvo", Name = "XC60", Image = "/models/volvo/xc60.webp", IsActive = true },
            new Model { Id = "xc90", BrandId = "volvo", Name = "XC90", Image = "/models/volvo/xc90.webp", IsActive = true }
        );
    }

    private static void SeedWallysModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Id = "annibal", BrandId = "wallys", Name = "Annibal", Image = "/models/wallys/annibal.webp", IsActive = true },
            new Model { Id = "annibalxxl", BrandId = "wallys", Name = "Annibal XXL", Image = "/models/wallys/annibalxxl.webp", IsActive = true },
            new Model { Id = "wolf", BrandId = "wallys", Name = "Wolf", Image = "/models/wallys/wolf.webp", IsActive = true }
        );
    }

}
