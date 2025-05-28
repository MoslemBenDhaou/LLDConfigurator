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
            new Model { Code = "alfaromeo_giulia", BrandCode = "alfaromeo", Name = "Giulia", ImgUrl = "/models/alfaromeo/giulia.webp", IsActive = true },
            new Model { Code = "alfaromeo_stelvio", BrandCode = "alfaromeo", Name = "Stelvio", ImgUrl = "/models/alfaromeo/stelvio.webp", IsActive = true }
        );
    }

    private static void SeedAudiModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "audi_q2", BrandCode = "audi", Name = "Q2", ImgUrl = "/models/audi/q2.webp", IsActive = true },
            new Model { Code = "audi_q3", BrandCode = "audi", Name = "Q3", ImgUrl = "/models/audi/q3.webp", IsActive = true },
            new Model { Code = "audi_q3sportback", BrandCode = "audi", Name = "Q3 Sportback", ImgUrl = "/models/audi/q3sportback.webp", IsActive = true },
            new Model { Code = "audi_q8etron", BrandCode = "audi", Name = "Q8 e-tron", ImgUrl = "/models/audi/q8etron.webp", IsActive = true },
            new Model { Code = "audi_q8sportbacketron", BrandCode = "audi", Name = "Q8 Sportback e-tron", ImgUrl = "/models/audi/q8sportbacketron.webp", IsActive = true },
            new Model { Code = "audi_etrongt", BrandCode = "audi", Name = "e-tron GT", ImgUrl = "/models/audi/etrongt.webp", IsActive = true },
            new Model { Code = "audi_q7", BrandCode = "audi", Name = "Q7", ImgUrl = "/models/audi/q7.webp", IsActive = true },
            new Model { Code = "audi_q8", BrandCode = "audi", Name = "Q8", ImgUrl = "/models/audi/q8.webp", IsActive = true }
        );
    }

    private static void SeedBMWModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "bmw_1", BrandCode = "bmw", Name = "1 Series", ImgUrl = "/models/bmw/1.webp", IsActive = true },
            new Model { Code = "bmw_2grancoupe", BrandCode = "bmw", Name = "2 Gran Coupé", ImgUrl = "/models/bmw/2grancoupe.webp", IsActive = true },
            new Model { Code = "bmw_3", BrandCode = "bmw", Name = "3 Series", ImgUrl = "/models/bmw/3.webp", IsActive = true },
            new Model { Code = "bmw_4grancoupe", BrandCode = "bmw", Name = "4 Gran Coupé", ImgUrl = "/models/bmw/4grancoupe.webp", IsActive = true },
            new Model { Code = "bmw_5", BrandCode = "bmw", Name = "5 Series", ImgUrl = "/models/bmw/5.webp", IsActive = true },
            new Model { Code = "bmw_i4", BrandCode = "bmw", Name = "i4", ImgUrl = "/models/bmw/i4.webp", IsActive = true },
            new Model { Code = "bmw_i5", BrandCode = "bmw", Name = "i5", ImgUrl = "/models/bmw/i5.webp", IsActive = true },
            new Model { Code = "bmw_ix", BrandCode = "bmw", Name = "iX", ImgUrl = "/models/bmw/ix.webp", IsActive = true },
            new Model { Code = "bmw_ix1", BrandCode = "bmw", Name = "iX1", ImgUrl = "/models/bmw/ix1.webp", IsActive = true },
            new Model { Code = "bmw_ix2", BrandCode = "bmw", Name = "iX2", ImgUrl = "/models/bmw/ix2.webp", IsActive = true },
            new Model { Code = "bmw_ix3", BrandCode = "bmw", Name = "iX3", ImgUrl = "/models/bmw/ix3.webp", IsActive = true },
            new Model { Code = "bmw_x1", BrandCode = "bmw", Name = "X1", ImgUrl = "/models/bmw/x1.webp", IsActive = true },
            new Model { Code = "bmw_x1hybride", BrandCode = "bmw", Name = "X1 Hybride", ImgUrl = "/models/bmw/x1hybride.webp", IsActive = true },
            new Model { Code = "bmw_x2", BrandCode = "bmw", Name = "X2", ImgUrl = "/models/bmw/x2.webp", IsActive = true },
            new Model { Code = "bmw_x3hybride", BrandCode = "bmw", Name = "X3 Hybride", ImgUrl = "/models/bmw/x3hybride.webp", IsActive = true },
            new Model { Code = "bmw_x4", BrandCode = "bmw", Name = "X4", ImgUrl = "/models/bmw/x4.webp", IsActive = true },
            new Model { Code = "bmw_x5hybride", BrandCode = "bmw", Name = "X5 Hybride", ImgUrl = "/models/bmw/x5hybride.webp", IsActive = true }
        );
    }

    private static void SeedBYDModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "byd_atto3", BrandCode = "byd", Name = "Atto 3", ImgUrl = "/models/byd/atto3.webp", IsActive = true },
            new Model { Code = "byd_dolphin", BrandCode = "byd", Name = "Dolphin", ImgUrl = "/models/byd/dolphin.webp", IsActive = true },
            new Model { Code = "byd_king", BrandCode = "byd", Name = "King", ImgUrl = "/models/byd/king.webp", IsActive = true },
            new Model { Code = "byd_songplus", BrandCode = "byd", Name = "Song Plus", ImgUrl = "/models/byd/songplus.webp", IsActive = true },
            new Model { Code = "byd_tangev", BrandCode = "byd", Name = "Tang EV", ImgUrl = "/models/byd/tangev.webp", IsActive = true }
        );
    }

    private static void SeedCheryModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "chery_arrizo5", BrandCode = "chery", Name = "Arrizo 5", ImgUrl = "/models/chery/arrizo5.webp", IsActive = true },
            new Model { Code = "chery_tiggo3x", BrandCode = "chery", Name = "Tiggo 3X", ImgUrl = "/models/chery/tiggo3x.webp", IsActive = true },
            new Model { Code = "chery_tiggo4pro", BrandCode = "chery", Name = "Tiggo 4 Pro", ImgUrl = "/models/chery/tiggo4pro.webp", IsActive = true },
            new Model { Code = "chery_tiggo7pro", BrandCode = "chery", Name = "Tiggo 7 Pro", ImgUrl = "/models/chery/tiggo7pro.webp", IsActive = true },
            new Model { Code = "chery_tiggo8pro", BrandCode = "chery", Name = "Tiggo 8 Pro", ImgUrl = "/models/chery/tiggo8pro.webp", IsActive = true }
        );
    }

    private static void SeedChevroletModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "chevrolet_captiva", BrandCode = "chevrolet", Name = "Captiva", ImgUrl = "/models/chevrolet/captiva.webp", IsActive = true },
            new Model { Code = "chevrolet_equinox", BrandCode = "chevrolet", Name = "Equinox", ImgUrl = "/models/chevrolet/equinox.webp", IsActive = true },
            new Model { Code = "chevrolet_groove", BrandCode = "chevrolet", Name = "Groove", ImgUrl = "/models/chevrolet/groove.webp", IsActive = true }
        );
    }

    private static void SeedCitroenModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "citroen_berlingo", BrandCode = "citroen", Name = "Berlingo", ImgUrl = "/models/citroen/berlingo.webp", IsActive = true },
            new Model { Code = "citroen_berlingovan", BrandCode = "citroen", Name = "Berlingo Van", ImgUrl = "/models/citroen/berlingovan.webp", IsActive = true },
            new Model { Code = "citroen_c4x", BrandCode = "citroen", Name = "C4X", ImgUrl = "/models/citroen/c4x.webp", IsActive = true },
            new Model { Code = "citroen_jumper", BrandCode = "citroen", Name = "Jumper", ImgUrl = "/models/citroen/jumper.webp", IsActive = true },
            new Model { Code = "citroen_jumpyfourgon", BrandCode = "citroen", Name = "Jumpy Fourgon", ImgUrl = "/models/citroen/jumpyfourgon.webp", IsActive = true }
        );
    }

    private static void SeedCupraModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "cupra_formentor", BrandCode = "cupra", Name = "Formentor", ImgUrl = "/models/cupra/formentor.webp", IsActive = true },
            new Model { Code = "cupra_leon", BrandCode = "cupra", Name = "Leon", ImgUrl = "/models/cupra/leon.webp", IsActive = true }
        );
    }

    private static void SeedDaciaModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "dacia_duster", BrandCode = "dacia", Name = "Duster", ImgUrl = "/models/dacia/duster.webp", IsActive = true },
            new Model { Code = "dacia_logan", BrandCode = "dacia", Name = "Logan", ImgUrl = "/models/dacia/logan.webp", IsActive = true },
            new Model { Code = "dacia_sandero", BrandCode = "dacia", Name = "Sandero", ImgUrl = "/models/dacia/sandero.webp", IsActive = true },
            new Model { Code = "dacia_sanderostepway", BrandCode = "dacia", Name = "Sandero Stepway", ImgUrl = "/models/dacia/sanderostepway.webp", IsActive = true }
        );
    }

    private static void SeedFiatModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "fiat_500", BrandCode = "fiat", Name = "500", ImgUrl = "/models/fiat/500.webp", IsActive = true },
            new Model { Code = "fiat_doblo", BrandCode = "fiat", Name = "Doblo", ImgUrl = "/models/fiat/doblo.webp", IsActive = true },
            new Model { Code = "fiat_doblocombi", BrandCode = "fiat", Name = "Doblo Combi", ImgUrl = "/models/fiat/doblocombi.webp", IsActive = true },
            new Model { Code = "fiat_ducato", BrandCode = "fiat", Name = "Ducato", ImgUrl = "/models/fiat/ducato.webp", IsActive = true },
            new Model { Code = "fiat_fiorinocombi", BrandCode = "fiat", Name = "Fiorino Combi", ImgUrl = "/models/fiat/fiorinocombi.webp", IsActive = true },
            new Model { Code = "fiat_tipoberline", BrandCode = "fiat", Name = "Tipo Berline", ImgUrl = "/models/fiat/tipoberline.webp", IsActive = true }
        );
    }

    private static void SeedFordModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "ford_everest", BrandCode = "ford", Name = "Everest", ImgUrl = "/models/ford/everest.webp", IsActive = true },
            new Model { Code = "ford_ranger", BrandCode = "ford", Name = "Ranger", ImgUrl = "/models/ford/ranger.webp", IsActive = true },
            new Model { Code = "ford_rangerraptor", BrandCode = "ford", Name = "Ranger Raptor", ImgUrl = "/models/ford/rangerraptor.webp", IsActive = true },
            new Model { Code = "ford_transitvan", BrandCode = "ford", Name = "Transit Van", ImgUrl = "/models/ford/transitvan.webp", IsActive = true }
        );
    }

    private static void SeedHavalModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "haval_h6hybride", BrandCode = "haval", Name = "H6 Hybride", ImgUrl = "/models/haval/h6hybride.webp", IsActive = true },
            new Model { Code = "haval_jolion", BrandCode = "haval", Name = "Jolion", ImgUrl = "/models/haval/jolion.webp", IsActive = true }
        );
    }

    private static void SeedHondaModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "honda_accord", BrandCode = "honda", Name = "Accord", ImgUrl = "/models/honda/accord.webp", IsActive = true },
            new Model { Code = "honda_city", BrandCode = "honda", Name = "City", ImgUrl = "/models/honda/city.webp", IsActive = true },
            new Model { Code = "honda_civic", BrandCode = "honda", Name = "Civic", ImgUrl = "/models/honda/civic.webp", IsActive = true },
            new Model { Code = "honda_civichybride", BrandCode = "honda", Name = "Civic Hybride", ImgUrl = "/models/honda/civichybride.webp", IsActive = true },
            new Model { Code = "honda_civictyper", BrandCode = "honda", Name = "Civic Type R", ImgUrl = "/models/honda/civictyper.webp", IsActive = true },
            new Model { Code = "honda_crv", BrandCode = "honda", Name = "CR-V", ImgUrl = "/models/honda/crv.webp", IsActive = true },
            new Model { Code = "honda_crvhybride", BrandCode = "honda", Name = "CR-V Hybride", ImgUrl = "/models/honda/crvhybride.webp", IsActive = true },
            new Model { Code = "honda_hrv", BrandCode = "honda", Name = "HR-V", ImgUrl = "/models/honda/hrv.webp", IsActive = true },
            new Model { Code = "honda_jazz", BrandCode = "honda", Name = "Jazz", ImgUrl = "/models/honda/jazz.webp", IsActive = true },
            new Model { Code = "honda_zrv", BrandCode = "honda", Name = "ZR-V", ImgUrl = "/models/honda/zrv.webp", IsActive = true }
        );
    }

    private static void SeedHyundaiModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "hyundai_azerahybride", BrandCode = "hyundai", Name = "Azera Hybride", ImgUrl = "/models/hyundai/azerahybride.webp", IsActive = true },
            new Model { Code = "hyundai_creta", BrandCode = "hyundai", Name = "Creta", ImgUrl = "/models/hyundai/creta.webp", IsActive = true },
            new Model { Code = "hyundai_i10", BrandCode = "hyundai", Name = "i10", ImgUrl = "/models/hyundai/i10.webp", IsActive = true },
            new Model { Code = "hyundai_i10sedan", BrandCode = "hyundai", Name = "i10 Sedan", ImgUrl = "/models/hyundai/i10sedan.webp", IsActive = true },
            new Model { Code = "hyundai_i20", BrandCode = "hyundai", Name = "i20", ImgUrl = "/models/hyundai/i20.webp", IsActive = true },
            new Model { Code = "hyundai_ioniq5", BrandCode = "hyundai", Name = "IONIQ 5", ImgUrl = "/models/hyundai/ioniq5.webp", IsActive = true },
            new Model { Code = "hyundai_kona", BrandCode = "hyundai", Name = "Kona", ImgUrl = "/models/hyundai/kona.webp", IsActive = true },
            new Model { Code = "hyundai_konaelectric", BrandCode = "hyundai", Name = "Kona Electric", ImgUrl = "/models/hyundai/konaelectric.webp", IsActive = true },
            new Model { Code = "hyundai_palisadecalligraphy", BrandCode = "hyundai", Name = "Palisade Calligraphy", ImgUrl = "/models/hyundai/palisadecalligraphy.webp", IsActive = true },
            new Model { Code = "hyundai_staria", BrandCode = "hyundai", Name = "Staria", ImgUrl = "/models/hyundai/staria.webp", IsActive = true },
            new Model { Code = "hyundai_tucson", BrandCode = "hyundai", Name = "Tucson", ImgUrl = "/models/hyundai/tucson.webp", IsActive = true },
            new Model { Code = "hyundai_tucsonhybride", BrandCode = "hyundai", Name = "Tucson Hybride", ImgUrl = "/models/hyundai/tucsonhybride.webp", IsActive = true },
            new Model { Code = "hyundai_venue", BrandCode = "hyundai", Name = "Venue", ImgUrl = "/models/hyundai/venue.webp", IsActive = true }
        );
    }

    private static void SeedJaguarModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "jaguar_epace", BrandCode = "jaguar", Name = "E-Pace", ImgUrl = "/models/jaguar/epace.webp", IsActive = true },
            new Model { Code = "jaguar_fpace", BrandCode = "jaguar", Name = "F-Pace", ImgUrl = "/models/jaguar/fpace.webp", IsActive = true }
        );
    }

    private static void SeedJeepModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "jeep_renegade", BrandCode = "jeep", Name = "Renegade", ImgUrl = "/models/jeep/renegade.webp", IsActive = true },
            new Model { Code = "jeep_wrangler", BrandCode = "jeep", Name = "Wrangler", ImgUrl = "/models/jeep/wrangler.webp", IsActive = true },
            new Model { Code = "jeep_wranglerunlimited", BrandCode = "jeep", Name = "Wrangler Unlimited", ImgUrl = "/models/jeep/wranglerunlimited.webp", IsActive = true }
        );
    }

    private static void SeedKiaModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "kia_ev6", BrandCode = "kia", Name = "EV6", ImgUrl = "/models/kia/ev6.webp", IsActive = true },
            new Model { Code = "kia_ev6gt", BrandCode = "kia", Name = "EV6 GT", ImgUrl = "/models/kia/ev6gt.webp", IsActive = true },
            new Model { Code = "kia_nirohybride", BrandCode = "kia", Name = "Niro Hybride", ImgUrl = "/models/kia/nirohybride.webp", IsActive = true },
            new Model { Code = "kia_picanto", BrandCode = "kia", Name = "Picanto", ImgUrl = "/models/kia/picanto.webp", IsActive = true },
            new Model { Code = "kia_seltos", BrandCode = "kia", Name = "Seltos", ImgUrl = "/models/kia/seltos.webp", IsActive = true },
            new Model { Code = "kia_sonet", BrandCode = "kia", Name = "Sonet", ImgUrl = "/models/kia/sonet.webp", IsActive = true },
            new Model { Code = "kia_sportage", BrandCode = "kia", Name = "Sportage", ImgUrl = "/models/kia/sportage.webp", IsActive = true },
            new Model { Code = "kia_sportagehypride", BrandCode = "kia", Name = "Sportage Hybride", ImgUrl = "/models/kia/sportagehypride.webp", IsActive = true },
            new Model { Code = "kia_stonic", BrandCode = "kia", Name = "Stonic", ImgUrl = "/models/kia/stonic.webp", IsActive = true }
        );
    }

    private static void SeedLandRoverModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "landrover_defender110", BrandCode = "landrover", Name = "Defender 110", ImgUrl = "/models/landrover/defender110.webp", IsActive = true },
            new Model { Code = "landrover_evoque", BrandCode = "landrover", Name = "Evoque", ImgUrl = "/models/landrover/evoque.webp", IsActive = true },
            new Model { Code = "landrover_rangerover", BrandCode = "landrover", Name = "Range Rover", ImgUrl = "/models/landrover/rangerover.webp", IsActive = true },
            new Model { Code = "landrover_rangeroversport", BrandCode = "landrover", Name = "Range Rover Sport", ImgUrl = "/models/landrover/rangeroversport.webp", IsActive = true },
            new Model { Code = "landrover_velar", BrandCode = "landrover", Name = "Velar", ImgUrl = "/models/landrover/velar.webp", IsActive = true }
        );
    }

    private static void SeedMahindraModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "mahindra_kuv100", BrandCode = "mahindra", Name = "KUV100", ImgUrl = "/models/mahindra/kuv100.webp", IsActive = true },
            new Model { Code = "mahindra_xuv300", BrandCode = "mahindra", Name = "XUV300", ImgUrl = "/models/mahindra/xuv300.webp", IsActive = true }
        );
    }

    private static void SeedMercedesModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "mercedes_a", BrandCode = "mercedes", Name = "A-Class", ImgUrl = "/models/mercedes/a.webp", IsActive = true },
            new Model { Code = "mercedes_aberline", BrandCode = "mercedes", Name = "A-Class Berline", ImgUrl = "/models/mercedes/aberline.webp", IsActive = true },
            new Model { Code = "mercedes_c", BrandCode = "mercedes", Name = "C-Class", ImgUrl = "/models/mercedes/c.webp", IsActive = true },
            new Model { Code = "mercedes_chybride", BrandCode = "mercedes", Name = "C-Class Hybride", ImgUrl = "/models/mercedes/chybride.webp", IsActive = true },
            new Model { Code = "mercedes_cla", BrandCode = "mercedes", Name = "CLA", ImgUrl = "/models/mercedes/cla.webp", IsActive = true },
            new Model { Code = "mercedes_clecoupe", BrandCode = "mercedes", Name = "CLE Coupé", ImgUrl = "/models/mercedes/clecoupe.webp", IsActive = true },
            new Model { Code = "mercedes_e", BrandCode = "mercedes", Name = "E-Class", ImgUrl = "/models/mercedes/e.webp", IsActive = true },
            new Model { Code = "mercedes_ehybride", BrandCode = "mercedes", Name = "E-Class Hybride", ImgUrl = "/models/mercedes/ehybride.webp", IsActive = true },
            new Model { Code = "mercedes_eqeberline", BrandCode = "mercedes", Name = "EQE Berline", ImgUrl = "/models/mercedes/eqeberline.webp", IsActive = true },
            new Model { Code = "mercedes_eqesuv", BrandCode = "mercedes", Name = "EQE SUV", ImgUrl = "/models/mercedes/eqesuv.webp", IsActive = true },
            new Model { Code = "mercedes_eqsberline", BrandCode = "mercedes", Name = "EQS Berline", ImgUrl = "/models/mercedes/eqsberline.webp", IsActive = true },
            new Model { Code = "mercedes_eqssuv", BrandCode = "mercedes", Name = "EQS SUV", ImgUrl = "/models/mercedes/eqssuv.webp", IsActive = true },
            new Model { Code = "mercedes_gla", BrandCode = "mercedes", Name = "GLA", ImgUrl = "/models/mercedes/gla.webp", IsActive = true },
            new Model { Code = "mercedes_glb", BrandCode = "mercedes", Name = "GLB", ImgUrl = "/models/mercedes/glb.webp", IsActive = true },
            new Model { Code = "mercedes_glc", BrandCode = "mercedes", Name = "GLC", ImgUrl = "/models/mercedes/glc.webp", IsActive = true },
            new Model { Code = "mercedes_glccoupe", BrandCode = "mercedes", Name = "GLC Coupé", ImgUrl = "/models/mercedes/glccoupe.webp", IsActive = true },
            new Model { Code = "mercedes_glccoupehybride", BrandCode = "mercedes", Name = "GLC Coupé Hybride", ImgUrl = "/models/mercedes/glccoupehybride.webp", IsActive = true },
            new Model { Code = "mercedes_glchybride", BrandCode = "mercedes", Name = "GLC Hybride", ImgUrl = "/models/mercedes/glchybride.webp", IsActive = true },
            new Model { Code = "mercedes_gle", BrandCode = "mercedes", Name = "GLE", ImgUrl = "/models/mercedes/gle.webp", IsActive = true },
            new Model { Code = "mercedes_glecoupe", BrandCode = "mercedes", Name = "GLE Coupé", ImgUrl = "/models/mercedes/glecoupe.webp", IsActive = true },
            new Model { Code = "mercedes_s", BrandCode = "mercedes", Name = "S-Class", ImgUrl = "/models/mercedes/s.webp", IsActive = true },
            new Model { Code = "mercedes_v", BrandCode = "mercedes", Name = "V-Class", ImgUrl = "/models/mercedes/v.webp", IsActive = true }
        );
    }

    private static void SeedMGModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "mg_3", BrandCode = "mg", Name = "MG3", ImgUrl = "/models/mg/3.webp", IsActive = true },
            new Model { Code = "mg_3hybride", BrandCode = "mg", Name = "MG3 Hybride", ImgUrl = "/models/mg/3hybride.webp", IsActive = true },
            new Model { Code = "mg_4", BrandCode = "mg", Name = "MG4", ImgUrl = "/models/mg/4.webp", IsActive = true },
            new Model { Code = "mg_5", BrandCode = "mg", Name = "MG5", ImgUrl = "/models/mg/5.webp", IsActive = true },
            new Model { Code = "mg_7", BrandCode = "mg", Name = "MG7", ImgUrl = "/models/mg/7.webp", IsActive = true },
            new Model { Code = "mg_ehs", BrandCode = "mg", Name = "eHS", ImgUrl = "/models/mg/ehs.webp", IsActive = true },
            new Model { Code = "mg_ezs", BrandCode = "mg", Name = "eZS", ImgUrl = "/models/mg/ezs.webp", IsActive = true },
            new Model { Code = "mg_gt", BrandCode = "mg", Name = "GT", ImgUrl = "/models/mg/gt.webp", IsActive = true },
            new Model { Code = "mg_marvelr", BrandCode = "mg", Name = "Marvel R", ImgUrl = "/models/mg/marvelr.webp", IsActive = true },
            new Model { Code = "mg_one", BrandCode = "mg", Name = "One", ImgUrl = "/models/mg/one.webp", IsActive = true },
            new Model { Code = "mg_rx5", BrandCode = "mg", Name = "RX5", ImgUrl = "/models/mg/rx5.webp", IsActive = true },
            new Model { Code = "mg_zs", BrandCode = "mg", Name = "ZS", ImgUrl = "/models/mg/zs.webp", IsActive = true }
        );
    }

    private static void SeedMiniModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "mini_aceman", BrandCode = "mini", Name = "Aceman", ImgUrl = "/models/mini/aceman.webp", IsActive = true },
            new Model { Code = "mini_coopercabrio", BrandCode = "mini", Name = "Cooper Cabrio", ImgUrl = "/models/mini/coopercabrio.webp", IsActive = true },
            new Model { Code = "mini_countryman", BrandCode = "mini", Name = "Countryman", ImgUrl = "/models/mini/countryman.webp", IsActive = true },
            new Model { Code = "mini_couperelectric", BrandCode = "mini", Name = "Cooper Electric", ImgUrl = "/models/mini/couperelectric.webp", IsActive = true }
        );
    }

    private static void SeedMitsubishiModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "mitsubishi_asx", BrandCode = "mitsubishi", Name = "ASX", ImgUrl = "/models/mitsubishi/asx.webp", IsActive = true },
            new Model { Code = "mitsubishi_eclipsecross", BrandCode = "mitsubishi", Name = "Eclipse Cross", ImgUrl = "/models/mitsubishi/eclipsecross.webp", IsActive = true },
            new Model { Code = "mitsubishi_l200", BrandCode = "mitsubishi", Name = "L200", ImgUrl = "/models/mitsubishi/l200.webp", IsActive = true },
            new Model { Code = "mitsubishi_pajero", BrandCode = "mitsubishi", Name = "Pajero", ImgUrl = "/models/mitsubishi/pajero.webp", IsActive = true },
            new Model { Code = "mitsubishi_pajerosport", BrandCode = "mitsubishi", Name = "Pajero Sport", ImgUrl = "/models/mitsubishi/pajerosport.webp", IsActive = true }
        );
    }

    private static void SeedNissanModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "nissan_juke", BrandCode = "nissan", Name = "Juke", ImgUrl = "/models/nissan/juke.webp", IsActive = true },
            new Model { Code = "nissan_qashqai", BrandCode = "nissan", Name = "Qashqai", ImgUrl = "/models/nissan/qashqai.webp", IsActive = true },
            new Model { Code = "nissan_qashqaiepower", BrandCode = "nissan", Name = "Qashqai e-Power", ImgUrl = "/models/nissan/qashqaiepower.webp", IsActive = true }
        );
    }

    private static void SeedOpelModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "opel_astra", BrandCode = "opel", Name = "Astra", ImgUrl = "/models/opel/astra.webp", IsActive = true },
            new Model { Code = "opel_combocargo", BrandCode = "opel", Name = "Combo Cargo", ImgUrl = "/models/opel/combocargo.webp", IsActive = true },
            new Model { Code = "opel_corsa", BrandCode = "opel", Name = "Corsa", ImgUrl = "/models/opel/corsa.webp", IsActive = true },
            new Model { Code = "opel_crossland", BrandCode = "opel", Name = "Crossland", ImgUrl = "/models/opel/crossland.webp", IsActive = true },
            new Model { Code = "opel_mokka", BrandCode = "opel", Name = "Mokka", ImgUrl = "/models/opel/mokka.webp", IsActive = true }
        );
    }

    private static void SeedPeugeotModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "peugeot_2008", BrandCode = "peugeot", Name = "2008", ImgUrl = "/models/peugeot/2008.webp", IsActive = true },
            new Model { Code = "peugeot_208", BrandCode = "peugeot", Name = "208", ImgUrl = "/models/peugeot/208.webp", IsActive = true },
            new Model { Code = "peugeot_308", BrandCode = "peugeot", Name = "308", ImgUrl = "/models/peugeot/308.webp", IsActive = true },
            new Model { Code = "peugeot_408", BrandCode = "peugeot", Name = "408", ImgUrl = "/models/peugeot/408.webp", IsActive = true },
            new Model { Code = "peugeot_408gt", BrandCode = "peugeot", Name = "408 GT", ImgUrl = "/models/peugeot/408gt.webp", IsActive = true },
            new Model { Code = "peugeot_boxer", BrandCode = "peugeot", Name = "Boxer", ImgUrl = "/models/peugeot/boxer.webp", IsActive = true },
            new Model { Code = "peugeot_boxerdouble", BrandCode = "peugeot", Name = "Boxer Double", ImgUrl = "/models/peugeot/boxerdouble.webp", IsActive = true },
            new Model { Code = "peugeot_expert", BrandCode = "peugeot", Name = "Expert", ImgUrl = "/models/peugeot/expert.webp", IsActive = true },
            new Model { Code = "peugeot_expertcombi", BrandCode = "peugeot", Name = "Expert Combi", ImgUrl = "/models/peugeot/expertcombi.webp", IsActive = true },
            new Model { Code = "peugeot_landtrekdouble", BrandCode = "peugeot", Name = "Landtrek Double", ImgUrl = "/models/peugeot/landtrekdouble.webp", IsActive = true },
            new Model { Code = "peugeot_landtreksimple", BrandCode = "peugeot", Name = "Landtrek Simple", ImgUrl = "/models/peugeot/landtreksimple.webp", IsActive = true },
            new Model { Code = "peugeot_partner", BrandCode = "peugeot", Name = "Partner", ImgUrl = "/models/peugeot/partner.webp", IsActive = true },
            new Model { Code = "peugeot_rifter", BrandCode = "peugeot", Name = "Rifter", ImgUrl = "/models/peugeot/rifter.webp", IsActive = true },
            new Model { Code = "peugeot_traveller", BrandCode = "peugeot", Name = "Traveller", ImgUrl = "/models/peugeot/traveller.webp", IsActive = true }
        );
    }

    private static void SeedPorscheModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "porsche_911", BrandCode = "porsche", Name = "911", ImgUrl = "/models/porsche/911.webp", IsActive = true },
            new Model { Code = "porsche_cayenne", BrandCode = "porsche", Name = "Cayenne", ImgUrl = "/models/porsche/cayenne.webp", IsActive = true },
            new Model { Code = "porsche_cayennecoupe", BrandCode = "porsche", Name = "Cayenne Coupé", ImgUrl = "/models/porsche/cayennecoupe.webp", IsActive = true },
            new Model { Code = "porsche_macanelectric", BrandCode = "porsche", Name = "Macan Electric", ImgUrl = "/models/porsche/macanelectric.webp", IsActive = true },
            new Model { Code = "porsche_taycan", BrandCode = "porsche", Name = "Taycan", ImgUrl = "/models/porsche/taycan.webp", IsActive = true },
            new Model { Code = "porsche_taycancrossturismo", BrandCode = "porsche", Name = "Taycan Cross Turismo", ImgUrl = "/models/porsche/taycancrossturismo.webp", IsActive = true }
        );
    }

    private static void SeedRenaultModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "renault_austral", BrandCode = "renault", Name = "Austral", ImgUrl = "/models/renault/austral.webp", IsActive = true },
            new Model { Code = "renault_clio", BrandCode = "renault", Name = "Clio", ImgUrl = "/models/renault/clio.webp", IsActive = true },
            new Model { Code = "renault_expresscombi", BrandCode = "renault", Name = "Express Combi", ImgUrl = "/models/renault/expresscombi.webp", IsActive = true },
            new Model { Code = "renault_expressvan", BrandCode = "renault", Name = "Express Van", ImgUrl = "/models/renault/expressvan.webp", IsActive = true },
            new Model { Code = "renault_master", BrandCode = "renault", Name = "Master", ImgUrl = "/models/renault/master.webp", IsActive = true },
            new Model { Code = "renault_megane", BrandCode = "renault", Name = "Megane", ImgUrl = "/models/renault/megane.webp", IsActive = true },
            new Model { Code = "renault_meganesedan", BrandCode = "renault", Name = "Megane Sedan", ImgUrl = "/models/renault/meganesedan.webp", IsActive = true }
        );
    }

    private static void SeedSeatModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "seat_arona", BrandCode = "seat", Name = "Arona", ImgUrl = "/models/seat/arona.webp", IsActive = true },
            new Model { Code = "seat_ateca", BrandCode = "seat", Name = "Ateca", ImgUrl = "/models/seat/ateca.webp", IsActive = true },
            new Model { Code = "seat_ibiza", BrandCode = "seat", Name = "Ibiza", ImgUrl = "/models/seat/ibiza.webp", IsActive = true },
            new Model { Code = "seat_leon", BrandCode = "seat", Name = "Leon", ImgUrl = "/models/seat/leon.webp", IsActive = true }
        );
    }

    private static void SeedSkodaModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "skoda_fabia", BrandCode = "skoda", Name = "Fabia", ImgUrl = "/models/skoda/fabia.webp", IsActive = true },
            new Model { Code = "skoda_kamiq", BrandCode = "skoda", Name = "Kamiq", ImgUrl = "/models/skoda/kamiq.webp", IsActive = true },
            new Model { Code = "skoda_kushaq", BrandCode = "skoda", Name = "Kushaq", ImgUrl = "/models/skoda/kushaq.webp", IsActive = true },
            new Model { Code = "skoda_octavia", BrandCode = "skoda", Name = "Octavia", ImgUrl = "/models/skoda/octavia.webp", IsActive = true },
            new Model { Code = "skoda_scala", BrandCode = "skoda", Name = "Scala", ImgUrl = "/models/skoda/scala.webp", IsActive = true }
        );
    }

    private static void SeedKGMModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "kgm_korando", BrandCode = "kgm", Name = "Korando", ImgUrl = "/models/kgm/korando.webp", IsActive = true },
            new Model { Code = "kgm_musso", BrandCode = "kgm", Name = "Musso", ImgUrl = "/models/kgm/musso.webp", IsActive = true },
            new Model { Code = "kgm_rexton", BrandCode = "kgm", Name = "Rexton", ImgUrl = "/models/kgm/rexton.webp", IsActive = true },
            new Model { Code = "kgm_tivoli", BrandCode = "kgm", Name = "Tivoli", ImgUrl = "/models/kgm/tivoli.webp", IsActive = true },
            new Model { Code = "kgm_torres", BrandCode = "kgm", Name = "Torres", ImgUrl = "/models/kgm/torres.webp", IsActive = true }
        );
    }

    private static void SeedSuzukiModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "suzuki_baleno", BrandCode = "suzuki", Name = "Baleno", ImgUrl = "/models/suzuki/baleno.webp", IsActive = true },
            new Model { Code = "suzuki_ciaz", BrandCode = "suzuki", Name = "Ciaz", ImgUrl = "/models/suzuki/ciaz.webp", IsActive = true },
            new Model { Code = "suzuki_dzire", BrandCode = "suzuki", Name = "Dzire", ImgUrl = "/models/suzuki/dzire.webp", IsActive = true },
            new Model { Code = "suzuki_ertiga", BrandCode = "suzuki", Name = "Ertiga", ImgUrl = "/models/suzuki/ertiga.webp", IsActive = true },
            new Model { Code = "suzuki_fronx", BrandCode = "suzuki", Name = "Fronx", ImgUrl = "/models/suzuki/fronx.webp", IsActive = true },
            new Model { Code = "suzuki_jimny3p", BrandCode = "suzuki", Name = "Jimny 3 Portes", ImgUrl = "/models/suzuki/jimny3p.webp", IsActive = true },
            new Model { Code = "suzuki_jimny5p", BrandCode = "suzuki", Name = "Jimny 5 Portes", ImgUrl = "/models/suzuki/jimny5p.webp", IsActive = true },
            new Model { Code = "suzuki_swift", BrandCode = "suzuki", Name = "Swift", ImgUrl = "/models/suzuki/swift.webp", IsActive = true }
        );
    }

    private static void SeedToyotaModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "toyota_corollasedan", BrandCode = "toyota", Name = "Corolla Sedan", ImgUrl = "/models/toyota/corollasedan.webp", IsActive = true },
            new Model { Code = "toyota_corollasedanhybride", BrandCode = "toyota", Name = "Corolla Sedan Hybride", ImgUrl = "/models/toyota/corollasedanhybride.webp", IsActive = true },
            new Model { Code = "toyota_fortuner", BrandCode = "toyota", Name = "Fortuner", ImgUrl = "/models/toyota/fortuner.webp", IsActive = true },
            new Model { Code = "toyota_hiacevan", BrandCode = "toyota", Name = "Hiace Van", ImgUrl = "/models/toyota/hiacevan.webp", IsActive = true },
            new Model { Code = "toyota_hiluxdouble", BrandCode = "toyota", Name = "Hilux Double Cabine", ImgUrl = "/models/toyota/hiluxdouble.webp", IsActive = true },
            new Model { Code = "toyota_hiluxsimple", BrandCode = "toyota", Name = "Hilux Simple Cabine", ImgUrl = "/models/toyota/hiluxsimple.webp", IsActive = true },
            new Model { Code = "toyota_landcruiser300", BrandCode = "toyota", Name = "Land Cruiser 300", ImgUrl = "/models/toyota/landcruiser300.webp", IsActive = true },
            new Model { Code = "toyota_landcruiser76", BrandCode = "toyota", Name = "Land Cruiser 76", ImgUrl = "/models/toyota/landcruiser76.webp", IsActive = true },
            new Model { Code = "toyota_landcruiser79", BrandCode = "toyota", Name = "Land Cruiser 79", ImgUrl = "/models/toyota/landcruiser79.webp", IsActive = true },
            new Model { Code = "toyota_prado", BrandCode = "toyota", Name = "Land Cruiser Prado", ImgUrl = "/models/toyota/prado.webp", IsActive = true },
            new Model { Code = "toyota_rav4hybride", BrandCode = "toyota", Name = "RAV4 Hybride", ImgUrl = "/models/toyota/rav4hybride.webp", IsActive = true },
            new Model { Code = "toyota_yariscrosshybride", BrandCode = "toyota", Name = "Yaris Cross Hybride", ImgUrl = "/models/toyota/yariscrosshybride.webp", IsActive = true },
            new Model { Code = "toyota_yarishybride", BrandCode = "toyota", Name = "Yaris Hybride", ImgUrl = "/models/toyota/yarishybride.webp", IsActive = true }
        );
    }

    private static void SeedVolkswagenModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "volkswagen_amarok", BrandCode = "volkswagen", Name = "Amarok", ImgUrl = "/models/volkswagen/amarok.webp", IsActive = true },
            new Model { Code = "volkswagen_caddycargo", BrandCode = "volkswagen", Name = "Caddy Cargo", ImgUrl = "/models/volkswagen/caddycargo.webp", IsActive = true },
            new Model { Code = "volkswagen_golf8", BrandCode = "volkswagen", Name = "Golf 8", ImgUrl = "/models/volkswagen/golf8.webp", IsActive = true },
            new Model { Code = "volkswagen_polo", BrandCode = "volkswagen", Name = "Polo", ImgUrl = "/models/volkswagen/polo.webp", IsActive = true },
            new Model { Code = "volkswagen_tcross", BrandCode = "volkswagen", Name = "T-Cross", ImgUrl = "/models/volkswagen/tcross.webp", IsActive = true },
            new Model { Code = "volkswagen_tiguan", BrandCode = "volkswagen", Name = "Tiguan", ImgUrl = "/models/volkswagen/tiguan.webp", IsActive = true },
            new Model { Code = "volkswagen_virtus", BrandCode = "volkswagen", Name = "Virtus", ImgUrl = "/models/volkswagen/virtus.webp", IsActive = true }
        );
    }

    private static void SeedVolvoModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "volvo_ec40", BrandCode = "volvo", Name = "EC40", ImgUrl = "/models/volvo/ec40.webp", IsActive = true },
            new Model { Code = "volvo_ex30", BrandCode = "volvo", Name = "EX30", ImgUrl = "/models/volvo/ex30.webp", IsActive = true },
            new Model { Code = "volvo_xc40", BrandCode = "volvo", Name = "XC40", ImgUrl = "/models/volvo/xc40.webp", IsActive = true },
            new Model { Code = "volvo_xc60", BrandCode = "volvo", Name = "XC60", ImgUrl = "/models/volvo/xc60.webp", IsActive = true },
            new Model { Code = "volvo_xc90", BrandCode = "volvo", Name = "XC90", ImgUrl = "/models/volvo/xc90.webp", IsActive = true }
        );
    }

    private static void SeedWallysModels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().HasData(
            new Model { Code = "wallys_annibal", BrandCode = "wallys", Name = "Annibal", ImgUrl = "/models/wallys/annibal.webp", IsActive = true },
            new Model { Code = "wallys_annibalxxl", BrandCode = "wallys", Name = "Annibal XXL", ImgUrl = "/models/wallys/annibalxxl.webp", IsActive = true },
            new Model { Code = "wallys_wolf", BrandCode = "wallys", Name = "Wolf", ImgUrl = "/models/wallys/wolf.webp", IsActive = true }
        );
    }

}
