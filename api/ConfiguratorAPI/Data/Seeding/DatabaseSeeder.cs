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
            new Brand { Code = "alfaromeo", Name = "Alfa Romeo", ImgUrl = "/brands/alfaromeo.webp", IsActive = true },
            new Brand { Code = "audi", Name = "Audi", ImgUrl = "/brands/audi.webp", IsActive = true },
            new Brand { Code = "bmw", Name = "BMW", ImgUrl = "/brands/bmw.webp", IsActive = true },
            new Brand { Code = "byd", Name = "BYD", ImgUrl = "/brands/byd.webp", IsActive = true },
            new Brand { Code = "chery", Name = "Chery", ImgUrl = "/brands/chery.webp", IsActive = true },
            new Brand { Code = "chevrolet", Name = "Chevrolet", ImgUrl = "/brands/chevrolet.webp", IsActive = true },
            new Brand { Code = "citroen", Name = "Citroen", ImgUrl = "/brands/citroen.webp", IsActive = true },
            new Brand { Code = "cupra", Name = "Cupra", ImgUrl = "/brands/cupra.webp", IsActive = true },
            new Brand { Code = "dacia", Name = "Dacia", ImgUrl = "/brands/dacia.webp", IsActive = true },
            new Brand { Code = "fiat", Name = "FIAT", ImgUrl = "/brands/fiat.webp", IsActive = true },
            new Brand { Code = "ford", Name = "Ford", ImgUrl = "/brands/ford.webp", IsActive = true },
            new Brand { Code = "haval", Name = "Haval", ImgUrl = "/brands/haval.webp", IsActive = true },
            new Brand { Code = "honda", Name = "Honda", ImgUrl = "/brands/honda.webp", IsActive = true },
            new Brand { Code = "hyundai", Name = "Hyundai", ImgUrl = "/brands/hyundai.webp", IsActive = true },
            new Brand { Code = "jaguar", Name = "Jaguar", ImgUrl = "/brands/jaguar.webp", IsActive = true },
            new Brand { Code = "jeep", Name = "Jeep", ImgUrl = "/brands/jeep.webp", IsActive = true },
            new Brand { Code = "kia", Name = "Kia", ImgUrl = "/brands/kia.webp", IsActive = true },
            new Brand { Code = "landrover", Name = "Land Rover", ImgUrl = "/brands/landrover.webp", IsActive = true },
            new Brand { Code = "mahindra", Name = "Mahindra", ImgUrl = "/brands/mahindra.webp", IsActive = true },
            new Brand { Code = "mercedes", Name = "Mercedes", ImgUrl = "/brands/mercedes.webp", IsActive = true },
            new Brand { Code = "mg", Name = "MG", ImgUrl = "/brands/mg.webp", IsActive = true },
            new Brand { Code = "mini", Name = "Mini", ImgUrl = "/brands/mini.webp", IsActive = true },
            new Brand { Code = "mitsubishi", Name = "Mitsubishi", ImgUrl = "/brands/mitsubishi.webp", IsActive = true },
            new Brand { Code = "nissan", Name = "Nissan", ImgUrl = "/brands/nissan.webp", IsActive = true },
            new Brand { Code = "opel", Name = "Opel", ImgUrl = "/brands/opel.webp", IsActive = true },
            new Brand { Code = "peugeot", Name = "Peugeot", ImgUrl = "/brands/peugeot.webp", IsActive = true },
            new Brand { Code = "porsche", Name = "Porsche", ImgUrl = "/brands/porsche.webp", IsActive = true },
            new Brand { Code = "renault", Name = "Renault", ImgUrl = "/brands/renault.webp", IsActive = true },
            new Brand { Code = "seat", Name = "SEAT", ImgUrl = "/brands/seat.webp", IsActive = true },
            new Brand { Code = "skoda", Name = "Skoda", ImgUrl = "/brands/skoda.webp", IsActive = true },
            new Brand { Code = "kgm", Name = "KGM", ImgUrl = "/brands/kgm.webp", IsActive = true },
            new Brand { Code = "suzuki", Name = "Suzuki", ImgUrl = "/brands/suzuki.webp", IsActive = true },
            new Brand { Code = "toyota", Name = "Toyota", ImgUrl = "/brands/toyota.webp", IsActive = true },
            new Brand { Code = "volkswagen", Name = "Volkswagen", ImgUrl = "/brands/volkswagen.webp", IsActive = true },
            new Brand { Code = "volvo", Name = "Volvo", ImgUrl = "/brands/volvo.webp", IsActive = true },
            new Brand { Code = "wallys", Name = "Wallys", ImgUrl = "/brands/wallys.webp", IsActive = true }
        );
    }

    private static void SeedAlfaRomeoModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "giulia", BrandId = "alfaromeo", Name = "Giulia", ImgUrl = "/models/alfaromeo/giulia.webp", IsActive = true },
            new Model { Code = "stelvio", BrandId = "alfaromeo", Name = "Stelvio", ImgUrl = "/models/alfaromeo/stelvio.webp", IsActive = true }
        );
    }

    private static void SeedAudiModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "a3berline", BrandId = "audi", Name = "A3 Berline", ImgUrl = "/models/audi/a3berline.webp", IsActive = true },
            new Model { Code = "q2", BrandId = "audi", Name = "Q2", ImgUrl = "/models/audi/q2.webp", IsActive = true },
            new Model { Code = "q3", BrandId = "audi", Name = "Q3", ImgUrl = "/models/audi/q3.webp", IsActive = true },
            new Model { Code = "q3sportback", BrandId = "audi", Name = "Q3 Sportback", ImgUrl = "/models/audi/q3sportback.webp", IsActive = true },
            new Model { Code = "q8etron", BrandId = "audi", Name = "Q8 e-tron", ImgUrl = "/models/audi/q8etron.webp", IsActive = true },
            new Model { Code = "q8sportbacketron", BrandId = "audi", Name = "Q8 Sportback e-tron", ImgUrl = "/models/audi/q8sportbacketron.webp", IsActive = true },
            new Model { Code = "etrongt", BrandId = "audi", Name = "e-tron GT", ImgUrl = "/models/audi/etrongt.webp", IsActive = true },
            new Model { Code = "q7", BrandId = "audi", Name = "Q7", ImgUrl = "/models/audi/q7.webp", IsActive = true },
            new Model { Code = "q8", BrandId = "audi", Name = "Q8", ImgUrl = "/models/audi/q8.webp", IsActive = true }
        );
    }

    private static void SeedBMWModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "1", BrandId = "bmw", Name = "1 Series", ImgUrl = "/models/bmw/1.webp", IsActive = true },
            new Model { Code = "2grancoupe", BrandId = "bmw", Name = "2 Gran Coupé", ImgUrl = "/models/bmw/2grancoupe.webp", IsActive = true },
            new Model { Code = "3", BrandId = "bmw", Name = "3 Series", ImgUrl = "/models/bmw/3.webp", IsActive = true },
            new Model { Code = "4grancoupe", BrandId = "bmw", Name = "4 Gran Coupé", ImgUrl = "/models/bmw/4grancoupe.webp", IsActive = true },
            new Model { Code = "5", BrandId = "bmw", Name = "5 Series", ImgUrl = "/models/bmw/5.webp", IsActive = true },
            new Model { Code = "i4", BrandId = "bmw", Name = "i4", ImgUrl = "/models/bmw/i4.webp", IsActive = true },
            new Model { Code = "i5", BrandId = "bmw", Name = "i5", ImgUrl = "/models/bmw/i5.webp", IsActive = true },
            new Model { Code = "ix", BrandId = "bmw", Name = "iX", ImgUrl = "/models/bmw/ix.webp", IsActive = true },
            new Model { Code = "ix1", BrandId = "bmw", Name = "iX1", ImgUrl = "/models/bmw/ix1.webp", IsActive = true },
            new Model { Code = "ix2", BrandId = "bmw", Name = "iX2", ImgUrl = "/models/bmw/ix2.webp", IsActive = true },
            new Model { Code = "ix3", BrandId = "bmw", Name = "iX3", ImgUrl = "/models/bmw/ix3.webp", IsActive = true },
            new Model { Code = "x1", BrandId = "bmw", Name = "X1", ImgUrl = "/models/bmw/x1.webp", IsActive = true },
            new Model { Code = "x1hybride", BrandId = "bmw", Name = "X1 Hybride", ImgUrl = "/models/bmw/x1hybride.webp", IsActive = true },
            new Model { Code = "x2", BrandId = "bmw", Name = "X2", ImgUrl = "/models/bmw/x2.webp", IsActive = true },
            new Model { Code = "x3hybride", BrandId = "bmw", Name = "X3 Hybride", ImgUrl = "/models/bmw/x3hybride.webp", IsActive = true },
            new Model { Code = "x4", BrandId = "bmw", Name = "X4", ImgUrl = "/models/bmw/x4.webp", IsActive = true },
            new Model { Code = "x5hybride", BrandId = "bmw", Name = "X5 Hybride", ImgUrl = "/models/bmw/x5hybride.webp", IsActive = true }
        );
    }

    private static void SeedBYDModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "atto3", BrandId = "byd", Name = "Atto 3", ImgUrl = "/models/byd/atto3.webp", IsActive = true },
            new Model { Code = "dolphin", BrandId = "byd", Name = "Dolphin", ImgUrl = "/models/byd/dolphin.webp", IsActive = true },
            new Model { Code = "king", BrandId = "byd", Name = "King", ImgUrl = "/models/byd/king.webp", IsActive = true },
            new Model { Code = "songplus", BrandId = "byd", Name = "Song Plus", ImgUrl = "/models/byd/songplus.webp", IsActive = true },
            new Model { Code = "tangev", BrandId = "byd", Name = "Tang EV", ImgUrl = "/models/byd/tangev.webp", IsActive = true }
        );
    }

    private static void SeedCheryModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "arrizo5", BrandId = "chery", Name = "Arrizo 5", ImgUrl = "/models/chery/arrizo5.webp", IsActive = true },
            new Model { Code = "tiggo3x", BrandId = "chery", Name = "Tiggo 3X", ImgUrl = "/models/chery/tiggo3x.webp", IsActive = true },
            new Model { Code = "tiggo4pro", BrandId = "chery", Name = "Tiggo 4 Pro", ImgUrl = "/models/chery/tiggo4pro.webp", IsActive = true },
            new Model { Code = "tiggo7pro", BrandId = "chery", Name = "Tiggo 7 Pro", ImgUrl = "/models/chery/tiggo7pro.webp", IsActive = true },
            new Model { Code = "tiggo8pro", BrandId = "chery", Name = "Tiggo 8 Pro", ImgUrl = "/models/chery/tiggo8pro.webp", IsActive = true }
        );
    }

    private static void SeedChevroletModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "captiva", BrandId = "chevrolet", Name = "Captiva", ImgUrl = "/models/chevrolet/captiva.webp", IsActive = true },
            new Model { Code = "equinox", BrandId = "chevrolet", Name = "Equinox", ImgUrl = "/models/chevrolet/equinox.webp", IsActive = true },
            new Model { Code = "groove", BrandId = "chevrolet", Name = "Groove", ImgUrl = "/models/chevrolet/groove.webp", IsActive = true }
        );
    }

    private static void SeedCitroenModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "berlingo", BrandId = "citroen", Name = "Berlingo", ImgUrl = "/models/citroen/berlingo.webp", IsActive = true },
            new Model { Code = "berlingovan", BrandId = "citroen", Name = "Berlingo Van", ImgUrl = "/models/citroen/berlingovan.webp", IsActive = true },
            new Model { Code = "c4x", BrandId = "citroen", Name = "C4X", ImgUrl = "/models/citroen/c4x.webp", IsActive = true },
            new Model { Code = "jumper", BrandId = "citroen", Name = "Jumper", ImgUrl = "/models/citroen/jumper.webp", IsActive = true },
            new Model { Code = "jumpyfourgon", BrandId = "citroen", Name = "Jumpy Fourgon", ImgUrl = "/models/citroen/jumpyfourgon.webp", IsActive = true }
        );
    }

    private static void SeedCupraModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "formentor", BrandId = "cupra", Name = "Formentor", ImgUrl = "/models/cupra/formentor.webp", IsActive = true },
            new Model { Code = "leon", BrandId = "cupra", Name = "Leon", ImgUrl = "/models/cupra/leon.webp", IsActive = true }
        );
    }

    private static void SeedDaciaModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "duster", BrandId = "dacia", Name = "Duster", ImgUrl = "/models/dacia/duster.webp", IsActive = true },
            new Model { Code = "logan", BrandId = "dacia", Name = "Logan", ImgUrl = "/models/dacia/logan.webp", IsActive = true },
            new Model { Code = "sandero", BrandId = "dacia", Name = "Sandero", ImgUrl = "/models/dacia/sandero.webp", IsActive = true },
            new Model { Code = "sanderostepway", BrandId = "dacia", Name = "Sandero Stepway", ImgUrl = "/models/dacia/sanderostepway.webp", IsActive = true }
        );
    }

    private static void SeedFiatModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "500", BrandId = "fiat", Name = "500", ImgUrl = "/models/fiat/500.webp", IsActive = true },
            new Model { Code = "doblo", BrandId = "fiat", Name = "Doblo", ImgUrl = "/models/fiat/doblo.webp", IsActive = true },
            new Model { Code = "doblocombi", BrandId = "fiat", Name = "Doblo Combi", ImgUrl = "/models/fiat/doblocombi.webp", IsActive = true },
            new Model { Code = "ducato", BrandId = "fiat", Name = "Ducato", ImgUrl = "/models/fiat/ducato.webp", IsActive = true },
            new Model { Code = "fiorinocombi", BrandId = "fiat", Name = "Fiorino Combi", ImgUrl = "/models/fiat/fiorinocombi.webp", IsActive = true },
            new Model { Code = "tipoberline", BrandId = "fiat", Name = "Tipo Berline", ImgUrl = "/models/fiat/tipoberline.webp", IsActive = true }
        );
    }

    private static void SeedFordModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "everest", BrandId = "ford", Name = "Everest", ImgUrl = "/models/ford/everest.webp", IsActive = true },
            new Model { Code = "ranger", BrandId = "ford", Name = "Ranger", ImgUrl = "/models/ford/ranger.webp", IsActive = true },
            new Model { Code = "rangerraptor", BrandId = "ford", Name = "Ranger Raptor", ImgUrl = "/models/ford/rangerraptor.webp", IsActive = true },
            new Model { Code = "transitvan", BrandId = "ford", Name = "Transit Van", ImgUrl = "/models/ford/transitvan.webp", IsActive = true }
        );
    }

    private static void SeedHavalModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "h6hybride", BrandId = "haval", Name = "H6 Hybride", ImgUrl = "/models/haval/h6hybride.webp", IsActive = true },
            new Model { Code = "jolion", BrandId = "haval", Name = "Jolion", ImgUrl = "/models/haval/jolion.webp", IsActive = true }
        );
    }

    private static void SeedHondaModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "accord", BrandId = "honda", Name = "Accord", ImgUrl = "/models/honda/accord.webp", IsActive = true },
            new Model { Code = "city", BrandId = "honda", Name = "City", ImgUrl = "/models/honda/city.webp", IsActive = true },
            new Model { Code = "civic", BrandId = "honda", Name = "Civic", ImgUrl = "/models/honda/civic.webp", IsActive = true },
            new Model { Code = "civichybride", BrandId = "honda", Name = "Civic Hybride", ImgUrl = "/models/honda/civichybride.webp", IsActive = true },
            new Model { Code = "civictyper", BrandId = "honda", Name = "Civic Type R", ImgUrl = "/models/honda/civictyper.webp", IsActive = true },
            new Model { Code = "crv", BrandId = "honda", Name = "CR-V", ImgUrl = "/models/honda/crv.webp", IsActive = true },
            new Model { Code = "crvhybride", BrandId = "honda", Name = "CR-V Hybride", ImgUrl = "/models/honda/crvhybride.webp", IsActive = true },
            new Model { Code = "hrv", BrandId = "honda", Name = "HR-V", ImgUrl = "/models/honda/hrv.webp", IsActive = true },
            new Model { Code = "jazz", BrandId = "honda", Name = "Jazz", ImgUrl = "/models/honda/jazz.webp", IsActive = true },
            new Model { Code = "zrv", BrandId = "honda", Name = "ZR-V", ImgUrl = "/models/honda/zrv.webp", IsActive = true }
        );
    }

    private static void SeedHyundaiModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "azerahybride", BrandId = "hyundai", Name = "Azera Hybride", ImgUrl = "/models/hyundai/azerahybride.webp", IsActive = true },
            new Model { Code = "creta", BrandId = "hyundai", Name = "Creta", ImgUrl = "/models/hyundai/creta.webp", IsActive = true },
            new Model { Code = "i10", BrandId = "hyundai", Name = "i10", ImgUrl = "/models/hyundai/i10.webp", IsActive = true },
            new Model { Code = "i10sedan", BrandId = "hyundai", Name = "i10 Sedan", ImgUrl = "/models/hyundai/i10sedan.webp", IsActive = true },
            new Model { Code = "i20", BrandId = "hyundai", Name = "i20", ImgUrl = "/models/hyundai/i20.webp", IsActive = true },
            new Model { Code = "ioniq5", BrandId = "hyundai", Name = "IONIQ 5", ImgUrl = "/models/hyundai/ioniq5.webp", IsActive = true },
            new Model { Code = "kona", BrandId = "hyundai", Name = "Kona", ImgUrl = "/models/hyundai/kona.webp", IsActive = true },
            new Model { Code = "konaelectric", BrandId = "hyundai", Name = "Kona Electric", ImgUrl = "/models/hyundai/konaelectric.webp", IsActive = true },
            new Model { Code = "palisadecalligraphy", BrandId = "hyundai", Name = "Palisade Calligraphy", ImgUrl = "/models/hyundai/palisadecalligraphy.webp", IsActive = true },
            new Model { Code = "staria", BrandId = "hyundai", Name = "Staria", ImgUrl = "/models/hyundai/staria.webp", IsActive = true },
            new Model { Code = "tucson", BrandId = "hyundai", Name = "Tucson", ImgUrl = "/models/hyundai/tucson.webp", IsActive = true },
            new Model { Code = "tucsonhybride", BrandId = "hyundai", Name = "Tucson Hybride", ImgUrl = "/models/hyundai/tucsonhybride.webp", IsActive = true },
            new Model { Code = "venue", BrandId = "hyundai", Name = "Venue", ImgUrl = "/models/hyundai/venue.webp", IsActive = true }
        );
    }

    private static void SeedJaguarModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "epace", BrandId = "jaguar", Name = "E-Pace", ImgUrl = "/models/jaguar/epace.webp", IsActive = true },
            new Model { Code = "fpace", BrandId = "jaguar", Name = "F-Pace", ImgUrl = "/models/jaguar/fpace.webp", IsActive = true }
        );
    }

    private static void SeedJeepModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "renegade", BrandId = "jeep", Name = "Renegade", ImgUrl = "/models/jeep/renegade.webp", IsActive = true },
            new Model { Code = "wrangler", BrandId = "jeep", Name = "Wrangler", ImgUrl = "/models/jeep/wrangler.webp", IsActive = true },
            new Model { Code = "wranglerunlimited", BrandId = "jeep", Name = "Wrangler Unlimited", ImgUrl = "/models/jeep/wranglerunlimited.webp", IsActive = true }
        );
    }

    private static void SeedKiaModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "ev6", BrandId = "kia", Name = "EV6", ImgUrl = "/models/kia/ev6.webp", IsActive = true },
            new Model { Code = "ev6gt", BrandId = "kia", Name = "EV6 GT", ImgUrl = "/models/kia/ev6gt.webp", IsActive = true },
            new Model { Code = "nirohybride", BrandId = "kia", Name = "Niro Hybride", ImgUrl = "/models/kia/nirohybride.webp", IsActive = true },
            new Model { Code = "picanto", BrandId = "kia", Name = "Picanto", ImgUrl = "/models/kia/picanto.webp", IsActive = true },
            new Model { Code = "seltos", BrandId = "kia", Name = "Seltos", ImgUrl = "/models/kia/seltos.webp", IsActive = true },
            new Model { Code = "sonet", BrandId = "kia", Name = "Sonet", ImgUrl = "/models/kia/sonet.webp", IsActive = true },
            new Model { Code = "sportage", BrandId = "kia", Name = "Sportage", ImgUrl = "/models/kia/sportage.webp", IsActive = true },
            new Model { Code = "sportagehypride", BrandId = "kia", Name = "Sportage Hybride", ImgUrl = "/models/kia/sportagehypride.webp", IsActive = true },
            new Model { Code = "stonic", BrandId = "kia", Name = "Stonic", ImgUrl = "/models/kia/stonic.webp", IsActive = true }
        );
    }

    private static void SeedLandRoverModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "defender110", BrandId = "landrover", Name = "Defender 110", ImgUrl = "/models/landrover/defender110.webp", IsActive = true },
            new Model { Code = "evoque", BrandId = "landrover", Name = "Evoque", ImgUrl = "/models/landrover/evoque.webp", IsActive = true },
            new Model { Code = "rangerover", BrandId = "landrover", Name = "Range Rover", ImgUrl = "/models/landrover/rangerover.webp", IsActive = true },
            new Model { Code = "rangeroversport", BrandId = "landrover", Name = "Range Rover Sport", ImgUrl = "/models/landrover/rangeroversport.webp", IsActive = true },
            new Model { Code = "velar", BrandId = "landrover", Name = "Velar", ImgUrl = "/models/landrover/velar.webp", IsActive = true }
        );
    }

    private static void SeedMahindraModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "kuv100", BrandId = "mahindra", Name = "KUV100", ImgUrl = "/models/mahindra/kuv100.webp", IsActive = true },
            new Model { Code = "xuv300", BrandId = "mahindra", Name = "XUV300", ImgUrl = "/models/mahindra/xuv300.webp", IsActive = true }
        );
    }

    private static void SeedMercedesModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "a", BrandId = "mercedes", Name = "A-Class", ImgUrl = "/models/mercedes/a.webp", IsActive = true },
            new Model { Code = "aberline", BrandId = "mercedes", Name = "A-Class Berline", ImgUrl = "/models/mercedes/aberline.webp", IsActive = true },
            new Model { Code = "c", BrandId = "mercedes", Name = "C-Class", ImgUrl = "/models/mercedes/c.webp", IsActive = true },
            new Model { Code = "chybride", BrandId = "mercedes", Name = "C-Class Hybride", ImgUrl = "/models/mercedes/chybride.webp", IsActive = true },
            new Model { Code = "cla", BrandId = "mercedes", Name = "CLA", ImgUrl = "/models/mercedes/cla.webp", IsActive = true },
            new Model { Code = "clecoupe", BrandId = "mercedes", Name = "CLE Coupé", ImgUrl = "/models/mercedes/clecoupe.webp", IsActive = true },
            new Model { Code = "e", BrandId = "mercedes", Name = "E-Class", ImgUrl = "/models/mercedes/e.webp", IsActive = true },
            new Model { Code = "ehybride", BrandId = "mercedes", Name = "E-Class Hybride", ImgUrl = "/models/mercedes/ehybride.webp", IsActive = true },
            new Model { Code = "eqeberline", BrandId = "mercedes", Name = "EQE Berline", ImgUrl = "/models/mercedes/eqeberline.webp", IsActive = true },
            new Model { Code = "eqesuv", BrandId = "mercedes", Name = "EQE SUV", ImgUrl = "/models/mercedes/eqesuv.webp", IsActive = true },
            new Model { Code = "eqsberline", BrandId = "mercedes", Name = "EQS Berline", ImgUrl = "/models/mercedes/eqsberline.webp", IsActive = true },
            new Model { Code = "eqssuv", BrandId = "mercedes", Name = "EQS SUV", ImgUrl = "/models/mercedes/eqssuv.webp", IsActive = true },
            new Model { Code = "gla", BrandId = "mercedes", Name = "GLA", ImgUrl = "/models/mercedes/gla.webp", IsActive = true },
            new Model { Code = "glb", BrandId = "mercedes", Name = "GLB", ImgUrl = "/models/mercedes/glb.webp", IsActive = true },
            new Model { Code = "glc", BrandId = "mercedes", Name = "GLC", ImgUrl = "/models/mercedes/glc.webp", IsActive = true },
            new Model { Code = "glccoupe", BrandId = "mercedes", Name = "GLC Coupé", ImgUrl = "/models/mercedes/glccoupe.webp", IsActive = true },
            new Model { Code = "glccoupehybride", BrandId = "mercedes", Name = "GLC Coupé Hybride", ImgUrl = "/models/mercedes/glccoupehybride.webp", IsActive = true },
            new Model { Code = "glchybride", BrandId = "mercedes", Name = "GLC Hybride", ImgUrl = "/models/mercedes/glchybride.webp", IsActive = true },
            new Model { Code = "gle", BrandId = "mercedes", Name = "GLE", ImgUrl = "/models/mercedes/gle.webp", IsActive = true },
            new Model { Code = "glecoupe", BrandId = "mercedes", Name = "GLE Coupé", ImgUrl = "/models/mercedes/glecoupe.webp", IsActive = true },
            new Model { Code = "s", BrandId = "mercedes", Name = "S-Class", ImgUrl = "/models/mercedes/s.webp", IsActive = true },
            new Model { Code = "v", BrandId = "mercedes", Name = "V-Class", ImgUrl = "/models/mercedes/v.webp", IsActive = true }
        );
    }

    private static void SeedMGModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "3", BrandId = "mg", Name = "MG3", ImgUrl = "/models/mg/3.webp", IsActive = true },
            new Model { Code = "3hybride", BrandId = "mg", Name = "MG3 Hybride", ImgUrl = "/models/mg/3hybride.webp", IsActive = true },
            new Model { Code = "4", BrandId = "mg", Name = "MG4", ImgUrl = "/models/mg/4.webp", IsActive = true },
            new Model { Code = "5", BrandId = "mg", Name = "MG5", ImgUrl = "/models/mg/5.webp", IsActive = true },
            new Model { Code = "7", BrandId = "mg", Name = "MG7", ImgUrl = "/models/mg/7.webp", IsActive = true },
            new Model { Code = "ehs", BrandId = "mg", Name = "eHS", ImgUrl = "/models/mg/ehs.webp", IsActive = true },
            new Model { Code = "ezs", BrandId = "mg", Name = "eZS", ImgUrl = "/models/mg/ezs.webp", IsActive = true },
            new Model { Code = "gt", BrandId = "mg", Name = "GT", ImgUrl = "/models/mg/gt.webp", IsActive = true },
            new Model { Code = "marvelr", BrandId = "mg", Name = "Marvel R", ImgUrl = "/models/mg/marvelr.webp", IsActive = true },
            new Model { Code = "one", BrandId = "mg", Name = "One", ImgUrl = "/models/mg/one.webp", IsActive = true },
            new Model { Code = "rx5", BrandId = "mg", Name = "RX5", ImgUrl = "/models/mg/rx5.webp", IsActive = true },
            new Model { Code = "zs", BrandId = "mg", Name = "ZS", ImgUrl = "/models/mg/zs.webp", IsActive = true }
        );
    }

    private static void SeedMiniModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "aceman", BrandId = "mini", Name = "Aceman", ImgUrl = "/models/mini/aceman.webp", IsActive = true },
            new Model { Code = "coopercabrio", BrandId = "mini", Name = "Cooper Cabrio", ImgUrl = "/models/mini/coopercabrio.webp", IsActive = true },
            new Model { Code = "countryman", BrandId = "mini", Name = "Countryman", ImgUrl = "/models/mini/countryman.webp", IsActive = true },
            new Model { Code = "couperelectric", BrandId = "mini", Name = "Cooper Electric", ImgUrl = "/models/mini/couperelectric.webp", IsActive = true }
        );
    }

    private static void SeedMitsubishiModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "asx", BrandId = "mitsubishi", Name = "ASX", ImgUrl = "/models/mitsubishi/asx.webp", IsActive = true },
            new Model { Code = "eclipsecross", BrandId = "mitsubishi", Name = "Eclipse Cross", ImgUrl = "/models/mitsubishi/eclipsecross.webp", IsActive = true },
            new Model { Code = "l200", BrandId = "mitsubishi", Name = "L200", ImgUrl = "/models/mitsubishi/l200.webp", IsActive = true },
            new Model { Code = "pajero", BrandId = "mitsubishi", Name = "Pajero", ImgUrl = "/models/mitsubishi/pajero.webp", IsActive = true },
            new Model { Code = "pajerosport", BrandId = "mitsubishi", Name = "Pajero Sport", ImgUrl = "/models/mitsubishi/pajerosport.webp", IsActive = true }
        );
    }

    private static void SeedNissanModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "juke", BrandId = "nissan", Name = "Juke", ImgUrl = "/models/nissan/juke.webp", IsActive = true },
            new Model { Code = "qashqai", BrandId = "nissan", Name = "Qashqai", ImgUrl = "/models/nissan/qashqai.webp", IsActive = true },
            new Model { Code = "qashqaiepower", BrandId = "nissan", Name = "Qashqai e-Power", ImgUrl = "/models/nissan/qashqaiepower.webp", IsActive = true }
        );
    }

    private static void SeedOpelModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "astra", BrandId = "opel", Name = "Astra", ImgUrl = "/models/opel/astra.webp", IsActive = true },
            new Model { Code = "combocargo", BrandId = "opel", Name = "Combo Cargo", ImgUrl = "/models/opel/combocargo.webp", IsActive = true },
            new Model { Code = "corsa", BrandId = "opel", Name = "Corsa", ImgUrl = "/models/opel/corsa.webp", IsActive = true },
            new Model { Code = "crossland", BrandId = "opel", Name = "Crossland", ImgUrl = "/models/opel/crossland.webp", IsActive = true },
            new Model { Code = "mokka", BrandId = "opel", Name = "Mokka", ImgUrl = "/models/opel/mokka.webp", IsActive = true }
        );
    }

    private static void SeedPeugeotModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "2008", BrandId = "peugeot", Name = "2008", ImgUrl = "/models/peugeot/2008.webp", IsActive = true },
            new Model { Code = "208", BrandId = "peugeot", Name = "208", ImgUrl = "/models/peugeot/208.webp", IsActive = true },
            new Model { Code = "308", BrandId = "peugeot", Name = "308", ImgUrl = "/models/peugeot/308.webp", IsActive = true },
            new Model { Code = "408", BrandId = "peugeot", Name = "408", ImgUrl = "/models/peugeot/408.webp", IsActive = true },
            new Model { Code = "408gt", BrandId = "peugeot", Name = "408 GT", ImgUrl = "/models/peugeot/408gt.webp", IsActive = true },
            new Model { Code = "boxer", BrandId = "peugeot", Name = "Boxer", ImgUrl = "/models/peugeot/boxer.webp", IsActive = true },
            new Model { Code = "boxerdouble", BrandId = "peugeot", Name = "Boxer Double", ImgUrl = "/models/peugeot/boxerdouble.webp", IsActive = true },
            new Model { Code = "expert", BrandId = "peugeot", Name = "Expert", ImgUrl = "/models/peugeot/expert.webp", IsActive = true },
            new Model { Code = "expertcombi", BrandId = "peugeot", Name = "Expert Combi", ImgUrl = "/models/peugeot/expertcombi.webp", IsActive = true },
            new Model { Code = "landtrekdouble", BrandId = "peugeot", Name = "Landtrek Double", ImgUrl = "/models/peugeot/landtrekdouble.webp", IsActive = true },
            new Model { Code = "landtreksimple", BrandId = "peugeot", Name = "Landtrek Simple", ImgUrl = "/models/peugeot/landtreksimple.webp", IsActive = true },
            new Model { Code = "partner", BrandId = "peugeot", Name = "Partner", ImgUrl = "/models/peugeot/partner.webp", IsActive = true },
            new Model { Code = "rifter", BrandId = "peugeot", Name = "Rifter", ImgUrl = "/models/peugeot/rifter.webp", IsActive = true },
            new Model { Code = "traveller", BrandId = "peugeot", Name = "Traveller", ImgUrl = "/models/peugeot/traveller.webp", IsActive = true }
        );
    }

    private static void SeedPorscheModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "911", BrandId = "porsche", Name = "911", ImgUrl = "/models/porsche/911.webp", IsActive = true },
            new Model { Code = "cayenne", BrandId = "porsche", Name = "Cayenne", ImgUrl = "/models/porsche/cayenne.webp", IsActive = true },
            new Model { Code = "cayennecoupe", BrandId = "porsche", Name = "Cayenne Coupé", ImgUrl = "/models/porsche/cayennecoupe.webp", IsActive = true },
            new Model { Code = "macanelectric", BrandId = "porsche", Name = "Macan Electric", ImgUrl = "/models/porsche/macanelectric.webp", IsActive = true },
            new Model { Code = "taycan", BrandId = "porsche", Name = "Taycan", ImgUrl = "/models/porsche/taycan.webp", IsActive = true },
            new Model { Code = "taycancrossturismo", BrandId = "porsche", Name = "Taycan Cross Turismo", ImgUrl = "/models/porsche/taycancrossturismo.webp", IsActive = true }
        );
    }

    private static void SeedRenaultModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "austral", BrandId = "renault", Name = "Austral", ImgUrl = "/models/renault/austral.webp", IsActive = true },
            new Model { Code = "clio", BrandId = "renault", Name = "Clio", ImgUrl = "/models/renault/clio.webp", IsActive = true },
            new Model { Code = "expresscombi", BrandId = "renault", Name = "Express Combi", ImgUrl = "/models/renault/expresscombi.webp", IsActive = true },
            new Model { Code = "expressvan", BrandId = "renault", Name = "Express Van", ImgUrl = "/models/renault/expressvan.webp", IsActive = true },
            new Model { Code = "master", BrandId = "renault", Name = "Master", ImgUrl = "/models/renault/master.webp", IsActive = true },
            new Model { Code = "megane", BrandId = "renault", Name = "Megane", ImgUrl = "/models/renault/megane.webp", IsActive = true },
            new Model { Code = "meganesedan", BrandId = "renault", Name = "Megane Sedan", ImgUrl = "/models/renault/meganesedan.webp", IsActive = true }
        );
    }

    private static void SeedSeatModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "arona", BrandId = "seat", Name = "Arona", ImgUrl = "/models/seat/arona.webp", IsActive = true },
            new Model { Code = "ateca", BrandId = "seat", Name = "Ateca", ImgUrl = "/models/seat/ateca.webp", IsActive = true },
            new Model { Code = "ibiza", BrandId = "seat", Name = "Ibiza", ImgUrl = "/models/seat/ibiza.webp", IsActive = true },
            new Model { Code = "leon", BrandId = "seat", Name = "Leon", ImgUrl = "/models/seat/leon.webp", IsActive = true }
        );
    }

    private static void SeedSkodaModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "fabia", BrandId = "skoda", Name = "Fabia", ImgUrl = "/models/skoda/fabia.webp", IsActive = true },
            new Model { Code = "kamiq", BrandId = "skoda", Name = "Kamiq", ImgUrl = "/models/skoda/kamiq.webp", IsActive = true },
            new Model { Code = "kushaq", BrandId = "skoda", Name = "Kushaq", ImgUrl = "/models/skoda/kushaq.webp", IsActive = true },
            new Model { Code = "octavia", BrandId = "skoda", Name = "Octavia", ImgUrl = "/models/skoda/octavia.webp", IsActive = true },
            new Model { Code = "scala", BrandId = "skoda", Name = "Scala", ImgUrl = "/models/skoda/scala.webp", IsActive = true }
        );
    }

    private static void SeedKGMModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "korando", BrandId = "kgm", Name = "Korando", ImgUrl = "/models/kgm/korando.webp", IsActive = true },
            new Model { Code = "musso", BrandId = "kgm", Name = "Musso", ImgUrl = "/models/kgm/musso.webp", IsActive = true },
            new Model { Code = "rexton", BrandId = "kgm", Name = "Rexton", ImgUrl = "/models/kgm/rexton.webp", IsActive = true },
            new Model { Code = "tivoli", BrandId = "kgm", Name = "Tivoli", ImgUrl = "/models/kgm/tivoli.webp", IsActive = true },
            new Model { Code = "torres", BrandId = "kgm", Name = "Torres", ImgUrl = "/models/kgm/torres.webp", IsActive = true }
        );
    }

    private static void SeedSuzukiModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "baleno", BrandId = "suzuki", Name = "Baleno", ImgUrl = "/models/suzuki/baleno.webp", IsActive = true },
            new Model { Code = "ciaz", BrandId = "suzuki", Name = "Ciaz", ImgUrl = "/models/suzuki/ciaz.webp", IsActive = true },
            new Model { Code = "dzire", BrandId = "suzuki", Name = "Dzire", ImgUrl = "/models/suzuki/dzire.webp", IsActive = true },
            new Model { Code = "ertiga", BrandId = "suzuki", Name = "Ertiga", ImgUrl = "/models/suzuki/ertiga.webp", IsActive = true },
            new Model { Code = "fronx", BrandId = "suzuki", Name = "Fronx", ImgUrl = "/models/suzuki/fronx.webp", IsActive = true },
            new Model { Code = "jimny3p", BrandId = "suzuki", Name = "Jimny 3 Portes", ImgUrl = "/models/suzuki/jimny3p.webp", IsActive = true },
            new Model { Code = "jimny5p", BrandId = "suzuki", Name = "Jimny 5 Portes", ImgUrl = "/models/suzuki/jimny5p.webp", IsActive = true },
            new Model { Code = "swift", BrandId = "suzuki", Name = "Swift", ImgUrl = "/models/suzuki/swift.webp", IsActive = true }
        );
    }

    private static void SeedToyotaModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "corollasedan", BrandId = "toyota", Name = "Corolla Sedan", ImgUrl = "/models/toyota/corollasedan.webp", IsActive = true },
            new Model { Code = "corollasedanhybride", BrandId = "toyota", Name = "Corolla Sedan Hybride", ImgUrl = "/models/toyota/corollasedanhybride.webp", IsActive = true },
            new Model { Code = "fortuner", BrandId = "toyota", Name = "Fortuner", ImgUrl = "/models/toyota/fortuner.webp", IsActive = true },
            new Model { Code = "hiacevan", BrandId = "toyota", Name = "Hiace Van", ImgUrl = "/models/toyota/hiacevan.webp", IsActive = true },
            new Model { Code = "hiluxdouble", BrandId = "toyota", Name = "Hilux Double Cabine", ImgUrl = "/models/toyota/hiluxdouble.webp", IsActive = true },
            new Model { Code = "hiluxsimple", BrandId = "toyota", Name = "Hilux Simple Cabine", ImgUrl = "/models/toyota/hiluxsimple.webp", IsActive = true },
            new Model { Code = "landcruiser300", BrandId = "toyota", Name = "Land Cruiser 300", ImgUrl = "/models/toyota/landcruiser300.webp", IsActive = true },
            new Model { Code = "landcruiser76", BrandId = "toyota", Name = "Land Cruiser 76", ImgUrl = "/models/toyota/landcruiser76.webp", IsActive = true },
            new Model { Code = "landcruiser79", BrandId = "toyota", Name = "Land Cruiser 79", ImgUrl = "/models/toyota/landcruiser79.webp", IsActive = true },
            new Model { Code = "prado", BrandId = "toyota", Name = "Land Cruiser Prado", ImgUrl = "/models/toyota/prado.webp", IsActive = true },
            new Model { Code = "rav4hybride", BrandId = "toyota", Name = "RAV4 Hybride", ImgUrl = "/models/toyota/rav4hybride.webp", IsActive = true },
            new Model { Code = "yariscrosshybride", BrandId = "toyota", Name = "Yaris Cross Hybride", ImgUrl = "/models/toyota/yariscrosshybride.webp", IsActive = true },
            new Model { Code = "yarishybride", BrandId = "toyota", Name = "Yaris Hybride", ImgUrl = "/models/toyota/yarishybride.webp", IsActive = true }
        );
    }

    private static void SeedVolkswagenModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "amarok", BrandId = "volkswagen", Name = "Amarok", ImgUrl = "/models/volkswagen/amarok.webp", IsActive = true },
            new Model { Code = "caddycargo", BrandId = "volkswagen", Name = "Caddy Cargo", ImgUrl = "/models/volkswagen/caddycargo.webp", IsActive = true },
            new Model { Code = "golf8", BrandId = "volkswagen", Name = "Golf 8", ImgUrl = "/models/volkswagen/golf8.webp", IsActive = true },
            new Model { Code = "polo", BrandId = "volkswagen", Name = "Polo", ImgUrl = "/models/volkswagen/polo.webp", IsActive = true },
            new Model { Code = "tcross", BrandId = "volkswagen", Name = "T-Cross", ImgUrl = "/models/volkswagen/tcross.webp", IsActive = true },
            new Model { Code = "tiguan", BrandId = "volkswagen", Name = "Tiguan", ImgUrl = "/models/volkswagen/tiguan.webp", IsActive = true },
            new Model { Code = "virtus", BrandId = "volkswagen", Name = "Virtus", ImgUrl = "/models/volkswagen/virtus.webp", IsActive = true }
        );
    }

    private static void SeedVolvoModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "ec40", BrandId = "volvo", Name = "EC40", ImgUrl = "/models/volvo/ec40.webp", IsActive = true },
            new Model { Code = "ex30", BrandId = "volvo", Name = "EX30", ImgUrl = "/models/volvo/ex30.webp", IsActive = true },
            new Model { Code = "xc40", BrandId = "volvo", Name = "XC40", ImgUrl = "/models/volvo/xc40.webp", IsActive = true },
            new Model { Code = "xc60", BrandId = "volvo", Name = "XC60", ImgUrl = "/models/volvo/xc60.webp", IsActive = true },
            new Model { Code = "xc90", BrandId = "volvo", Name = "XC90", ImgUrl = "/models/volvo/xc90.webp", IsActive = true }
        );
    }

    private static void SeedWallysModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "annibal", BrandId = "wallys", Name = "Annibal", ImgUrl = "/models/wallys/annibal.webp", IsActive = true },
            new Model { Code = "annibalxxl", BrandId = "wallys", Name = "Annibal XXL", ImgUrl = "/models/wallys/annibalxxl.webp", IsActive = true },
            new Model { Code = "wolf", BrandId = "wallys", Name = "Wolf", ImgUrl = "/models/wallys/wolf.webp", IsActive = true }
        );
    }

}
