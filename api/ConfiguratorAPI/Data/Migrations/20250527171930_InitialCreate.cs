using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConfiguratorAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ImgUrl = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Configuration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StandardInterestRate = table.Column<decimal>(type: "numeric", nullable: false),
                    StandardMarginRate = table.Column<decimal>(type: "numeric", nullable: false),
                    VatRate = table.Column<decimal>(type: "numeric", nullable: false),
                    DefaultResidualValuePercent = table.Column<decimal>(type: "numeric", nullable: false),
                    AdministrativeFee = table.Column<decimal>(type: "numeric", nullable: false),
                    DeliveryFee = table.Column<decimal>(type: "numeric", nullable: false),
                    RegistrationFee = table.Column<decimal>(type: "numeric", nullable: false),
                    MinDurationMonths = table.Column<int>(type: "integer", nullable: false),
                    MaxDurationMonths = table.Column<int>(type: "integer", nullable: false),
                    DurationStepMonths = table.Column<int>(type: "integer", nullable: false),
                    MinAnnualKm = table.Column<int>(type: "integer", nullable: false),
                    MaxAnnualKm = table.Column<int>(type: "integer", nullable: false),
                    AnnualKmStep = table.Column<int>(type: "integer", nullable: false),
                    AdvancePaymentOptionsCsv = table.Column<string>(type: "text", nullable: false),
                    PurchaseOptionPercent = table.Column<decimal>(type: "numeric", nullable: false),
                    EnableDynamicResidualValueCalculation = table.Column<bool>(type: "boolean", nullable: false),
                    EnableTieredPricing = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ImgUrl = table.Column<string>(type: "text", nullable: false),
                    BrandId = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Models_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trims",
                columns: table => new
                {
                    Name = table.Column<string>(type: "text", nullable: false),
                    ModelId = table.Column<string>(type: "text", nullable: false),
                    FiscalPower = table.Column<int>(type: "integer", nullable: false),
                    EnginePowerKW = table.Column<int>(type: "integer", nullable: false),
                    CylinderCount = table.Column<int>(type: "integer", nullable: false),
                    HorsePower = table.Column<int>(type: "integer", nullable: false),
                    FuelType = table.Column<int>(type: "integer", nullable: false),
                    Transmission = table.Column<int>(type: "integer", nullable: false),
                    MaxSpeedKph = table.Column<int>(type: "integer", nullable: false),
                    ExtendedCharacteristicsUrl = table.Column<string>(type: "text", nullable: true),
                    ListPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    FullInsurance0PercentPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    FullInsurance4PercentPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    MaintenancePackagePrice = table.Column<decimal>(type: "numeric", nullable: false),
                    GeolocalisationPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    PurchaseOptionPrice = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trims", x => new { x.Name, x.ModelId });
                    table.ForeignKey(
                        name: "FK_Trims_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Code", "ImgUrl", "IsActive", "Name" },
                values: new object[,]
                {
                    { "alfaromeo", "/brands/alfaromeo.webp", true, "Alfa Romeo" },
                    { "audi", "/brands/audi.webp", true, "Audi" },
                    { "bmw", "/brands/bmw.webp", true, "BMW" },
                    { "byd", "/brands/byd.webp", true, "BYD" },
                    { "chery", "/brands/chery.webp", true, "Chery" },
                    { "chevrolet", "/brands/chevrolet.webp", true, "Chevrolet" },
                    { "citroen", "/brands/citroen.webp", true, "Citroen" },
                    { "cupra", "/brands/cupra.webp", true, "Cupra" },
                    { "dacia", "/brands/dacia.webp", true, "Dacia" },
                    { "fiat", "/brands/fiat.webp", true, "FIAT" },
                    { "ford", "/brands/ford.webp", true, "Ford" },
                    { "haval", "/brands/haval.webp", true, "Haval" },
                    { "honda", "/brands/honda.webp", true, "Honda" },
                    { "hyundai", "/brands/hyundai.webp", true, "Hyundai" },
                    { "jaguar", "/brands/jaguar.webp", true, "Jaguar" },
                    { "jeep", "/brands/jeep.webp", true, "Jeep" },
                    { "kgm", "/brands/kgm.webp", true, "KGM" },
                    { "kia", "/brands/kia.webp", true, "Kia" },
                    { "landrover", "/brands/landrover.webp", true, "Land Rover" },
                    { "mahindra", "/brands/mahindra.webp", true, "Mahindra" },
                    { "mercedes", "/brands/mercedes.webp", true, "Mercedes" },
                    { "mg", "/brands/mg.webp", true, "MG" },
                    { "mini", "/brands/mini.webp", true, "Mini" },
                    { "mitsubishi", "/brands/mitsubishi.webp", true, "Mitsubishi" },
                    { "nissan", "/brands/nissan.webp", true, "Nissan" },
                    { "opel", "/brands/opel.webp", true, "Opel" },
                    { "peugeot", "/brands/peugeot.webp", true, "Peugeot" },
                    { "porsche", "/brands/porsche.webp", true, "Porsche" },
                    { "renault", "/brands/renault.webp", true, "Renault" },
                    { "seat", "/brands/seat.webp", true, "SEAT" },
                    { "skoda", "/brands/skoda.webp", true, "Skoda" },
                    { "suzuki", "/brands/suzuki.webp", true, "Suzuki" },
                    { "toyota", "/brands/toyota.webp", true, "Toyota" },
                    { "volkswagen", "/brands/volkswagen.webp", true, "Volkswagen" },
                    { "volvo", "/brands/volvo.webp", true, "Volvo" },
                    { "wallys", "/brands/wallys.webp", true, "Wallys" }
                });

            migrationBuilder.InsertData(
                table: "Configuration",
                columns: new[] { "Id", "AdministrativeFee", "AdvancePaymentOptionsCsv", "AnnualKmStep", "DefaultResidualValuePercent", "DeliveryFee", "DurationStepMonths", "EnableDynamicResidualValueCalculation", "EnableTieredPricing", "MaxAnnualKm", "MaxDurationMonths", "MinAnnualKm", "MinDurationMonths", "PurchaseOptionPercent", "RegistrationFee", "StandardInterestRate", "StandardMarginRate", "VatRate" },
                values: new object[] { 1, 150m, "0,10,20,30", 5000, 0.30m, 300m, 1, true, true, 30000, 60, 10000, 12, 40m, 100m, 0.035m, 0.10m, 0.19m });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Code", "BrandId", "ImgUrl", "IsActive", "Name" },
                values: new object[,]
                {
                    { "alfaromeo_giulia", "alfaromeo", "/models/alfaromeo/giulia.webp", true, "Giulia" },
                    { "alfaromeo_stelvio", "alfaromeo", "/models/alfaromeo/stelvio.webp", true, "Stelvio" },
                    { "audi_a3berline", "audi", "/models/audi/a3berline.webp", true, "A3 Berline" },
                    { "audi_etrongt", "audi", "/models/audi/etrongt.webp", true, "e-tron GT" },
                    { "audi_q2", "audi", "/models/audi/q2.webp", true, "Q2" },
                    { "audi_q3", "audi", "/models/audi/q3.webp", true, "Q3" },
                    { "audi_q3sportback", "audi", "/models/audi/q3sportback.webp", true, "Q3 Sportback" },
                    { "audi_q7", "audi", "/models/audi/q7.webp", true, "Q7" },
                    { "audi_q8", "audi", "/models/audi/q8.webp", true, "Q8" },
                    { "audi_q8etron", "audi", "/models/audi/q8etron.webp", true, "Q8 e-tron" },
                    { "audi_q8sportbacketron", "audi", "/models/audi/q8sportbacketron.webp", true, "Q8 Sportback e-tron" },
                    { "bmw_1", "bmw", "/models/bmw/1.webp", true, "1 Series" },
                    { "bmw_2grancoupe", "bmw", "/models/bmw/2grancoupe.webp", true, "2 Gran Coupé" },
                    { "bmw_3", "bmw", "/models/bmw/3.webp", true, "3 Series" },
                    { "bmw_4grancoupe", "bmw", "/models/bmw/4grancoupe.webp", true, "4 Gran Coupé" },
                    { "bmw_5", "bmw", "/models/bmw/5.webp", true, "5 Series" },
                    { "bmw_i4", "bmw", "/models/bmw/i4.webp", true, "i4" },
                    { "bmw_i5", "bmw", "/models/bmw/i5.webp", true, "i5" },
                    { "bmw_ix", "bmw", "/models/bmw/ix.webp", true, "iX" },
                    { "bmw_ix1", "bmw", "/models/bmw/ix1.webp", true, "iX1" },
                    { "bmw_ix2", "bmw", "/models/bmw/ix2.webp", true, "iX2" },
                    { "bmw_ix3", "bmw", "/models/bmw/ix3.webp", true, "iX3" },
                    { "bmw_x1", "bmw", "/models/bmw/x1.webp", true, "X1" },
                    { "bmw_x1hybride", "bmw", "/models/bmw/x1hybride.webp", true, "X1 Hybride" },
                    { "bmw_x2", "bmw", "/models/bmw/x2.webp", true, "X2" },
                    { "bmw_x3hybride", "bmw", "/models/bmw/x3hybride.webp", true, "X3 Hybride" },
                    { "bmw_x4", "bmw", "/models/bmw/x4.webp", true, "X4" },
                    { "bmw_x5hybride", "bmw", "/models/bmw/x5hybride.webp", true, "X5 Hybride" },
                    { "byd_atto3", "byd", "/models/byd/atto3.webp", true, "Atto 3" },
                    { "byd_dolphin", "byd", "/models/byd/dolphin.webp", true, "Dolphin" },
                    { "byd_king", "byd", "/models/byd/king.webp", true, "King" },
                    { "byd_songplus", "byd", "/models/byd/songplus.webp", true, "Song Plus" },
                    { "byd_tangev", "byd", "/models/byd/tangev.webp", true, "Tang EV" },
                    { "chery_arrizo5", "chery", "/models/chery/arrizo5.webp", true, "Arrizo 5" },
                    { "chery_tiggo3x", "chery", "/models/chery/tiggo3x.webp", true, "Tiggo 3X" },
                    { "chery_tiggo4pro", "chery", "/models/chery/tiggo4pro.webp", true, "Tiggo 4 Pro" },
                    { "chery_tiggo7pro", "chery", "/models/chery/tiggo7pro.webp", true, "Tiggo 7 Pro" },
                    { "chery_tiggo8pro", "chery", "/models/chery/tiggo8pro.webp", true, "Tiggo 8 Pro" },
                    { "chevrolet_captiva", "chevrolet", "/models/chevrolet/captiva.webp", true, "Captiva" },
                    { "chevrolet_equinox", "chevrolet", "/models/chevrolet/equinox.webp", true, "Equinox" },
                    { "chevrolet_groove", "chevrolet", "/models/chevrolet/groove.webp", true, "Groove" },
                    { "citroen_berlingo", "citroen", "/models/citroen/berlingo.webp", true, "Berlingo" },
                    { "citroen_berlingovan", "citroen", "/models/citroen/berlingovan.webp", true, "Berlingo Van" },
                    { "citroen_c4x", "citroen", "/models/citroen/c4x.webp", true, "C4X" },
                    { "citroen_jumper", "citroen", "/models/citroen/jumper.webp", true, "Jumper" },
                    { "citroen_jumpyfourgon", "citroen", "/models/citroen/jumpyfourgon.webp", true, "Jumpy Fourgon" },
                    { "cupra_formentor", "cupra", "/models/cupra/formentor.webp", true, "Formentor" },
                    { "cupra_leon", "cupra", "/models/cupra/leon.webp", true, "Leon" },
                    { "dacia_duster", "dacia", "/models/dacia/duster.webp", true, "Duster" },
                    { "dacia_logan", "dacia", "/models/dacia/logan.webp", true, "Logan" },
                    { "dacia_sandero", "dacia", "/models/dacia/sandero.webp", true, "Sandero" },
                    { "dacia_sanderostepway", "dacia", "/models/dacia/sanderostepway.webp", true, "Sandero Stepway" },
                    { "fiat_500", "fiat", "/models/fiat/500.webp", true, "500" },
                    { "fiat_doblo", "fiat", "/models/fiat/doblo.webp", true, "Doblo" },
                    { "fiat_doblocombi", "fiat", "/models/fiat/doblocombi.webp", true, "Doblo Combi" },
                    { "fiat_ducato", "fiat", "/models/fiat/ducato.webp", true, "Ducato" },
                    { "fiat_fiorinocombi", "fiat", "/models/fiat/fiorinocombi.webp", true, "Fiorino Combi" },
                    { "fiat_tipoberline", "fiat", "/models/fiat/tipoberline.webp", true, "Tipo Berline" },
                    { "ford_everest", "ford", "/models/ford/everest.webp", true, "Everest" },
                    { "ford_ranger", "ford", "/models/ford/ranger.webp", true, "Ranger" },
                    { "ford_rangerraptor", "ford", "/models/ford/rangerraptor.webp", true, "Ranger Raptor" },
                    { "ford_transitvan", "ford", "/models/ford/transitvan.webp", true, "Transit Van" },
                    { "haval_h6hybride", "haval", "/models/haval/h6hybride.webp", true, "H6 Hybride" },
                    { "haval_jolion", "haval", "/models/haval/jolion.webp", true, "Jolion" },
                    { "honda_accord", "honda", "/models/honda/accord.webp", true, "Accord" },
                    { "honda_city", "honda", "/models/honda/city.webp", true, "City" },
                    { "honda_civic", "honda", "/models/honda/civic.webp", true, "Civic" },
                    { "honda_civichybride", "honda", "/models/honda/civichybride.webp", true, "Civic Hybride" },
                    { "honda_civictyper", "honda", "/models/honda/civictyper.webp", true, "Civic Type R" },
                    { "honda_crv", "honda", "/models/honda/crv.webp", true, "CR-V" },
                    { "honda_crvhybride", "honda", "/models/honda/crvhybride.webp", true, "CR-V Hybride" },
                    { "honda_hrv", "honda", "/models/honda/hrv.webp", true, "HR-V" },
                    { "honda_jazz", "honda", "/models/honda/jazz.webp", true, "Jazz" },
                    { "honda_zrv", "honda", "/models/honda/zrv.webp", true, "ZR-V" },
                    { "hyundai_azerahybride", "hyundai", "/models/hyundai/azerahybride.webp", true, "Azera Hybride" },
                    { "hyundai_creta", "hyundai", "/models/hyundai/creta.webp", true, "Creta" },
                    { "hyundai_i10", "hyundai", "/models/hyundai/i10.webp", true, "i10" },
                    { "hyundai_i10sedan", "hyundai", "/models/hyundai/i10sedan.webp", true, "i10 Sedan" },
                    { "hyundai_i20", "hyundai", "/models/hyundai/i20.webp", true, "i20" },
                    { "hyundai_ioniq5", "hyundai", "/models/hyundai/ioniq5.webp", true, "IONIQ 5" },
                    { "hyundai_kona", "hyundai", "/models/hyundai/kona.webp", true, "Kona" },
                    { "hyundai_konaelectric", "hyundai", "/models/hyundai/konaelectric.webp", true, "Kona Electric" },
                    { "hyundai_palisadecalligraphy", "hyundai", "/models/hyundai/palisadecalligraphy.webp", true, "Palisade Calligraphy" },
                    { "hyundai_staria", "hyundai", "/models/hyundai/staria.webp", true, "Staria" },
                    { "hyundai_tucson", "hyundai", "/models/hyundai/tucson.webp", true, "Tucson" },
                    { "hyundai_tucsonhybride", "hyundai", "/models/hyundai/tucsonhybride.webp", true, "Tucson Hybride" },
                    { "hyundai_venue", "hyundai", "/models/hyundai/venue.webp", true, "Venue" },
                    { "jaguar_epace", "jaguar", "/models/jaguar/epace.webp", true, "E-Pace" },
                    { "jaguar_fpace", "jaguar", "/models/jaguar/fpace.webp", true, "F-Pace" },
                    { "jeep_renegade", "jeep", "/models/jeep/renegade.webp", true, "Renegade" },
                    { "jeep_wrangler", "jeep", "/models/jeep/wrangler.webp", true, "Wrangler" },
                    { "jeep_wranglerunlimited", "jeep", "/models/jeep/wranglerunlimited.webp", true, "Wrangler Unlimited" },
                    { "kgm_korando", "kgm", "/models/kgm/korando.webp", true, "Korando" },
                    { "kgm_musso", "kgm", "/models/kgm/musso.webp", true, "Musso" },
                    { "kgm_rexton", "kgm", "/models/kgm/rexton.webp", true, "Rexton" },
                    { "kgm_tivoli", "kgm", "/models/kgm/tivoli.webp", true, "Tivoli" },
                    { "kgm_torres", "kgm", "/models/kgm/torres.webp", true, "Torres" },
                    { "kia_ev6", "kia", "/models/kia/ev6.webp", true, "EV6" },
                    { "kia_ev6gt", "kia", "/models/kia/ev6gt.webp", true, "EV6 GT" },
                    { "kia_nirohybride", "kia", "/models/kia/nirohybride.webp", true, "Niro Hybride" },
                    { "kia_picanto", "kia", "/models/kia/picanto.webp", true, "Picanto" },
                    { "kia_seltos", "kia", "/models/kia/seltos.webp", true, "Seltos" },
                    { "kia_sonet", "kia", "/models/kia/sonet.webp", true, "Sonet" },
                    { "kia_sportage", "kia", "/models/kia/sportage.webp", true, "Sportage" },
                    { "kia_sportagehypride", "kia", "/models/kia/sportagehypride.webp", true, "Sportage Hybride" },
                    { "kia_stonic", "kia", "/models/kia/stonic.webp", true, "Stonic" },
                    { "landrover_defender110", "landrover", "/models/landrover/defender110.webp", true, "Defender 110" },
                    { "landrover_evoque", "landrover", "/models/landrover/evoque.webp", true, "Evoque" },
                    { "landrover_rangerover", "landrover", "/models/landrover/rangerover.webp", true, "Range Rover" },
                    { "landrover_rangeroversport", "landrover", "/models/landrover/rangeroversport.webp", true, "Range Rover Sport" },
                    { "landrover_velar", "landrover", "/models/landrover/velar.webp", true, "Velar" },
                    { "mahindra_kuv100", "mahindra", "/models/mahindra/kuv100.webp", true, "KUV100" },
                    { "mahindra_xuv300", "mahindra", "/models/mahindra/xuv300.webp", true, "XUV300" },
                    { "mercedes_a", "mercedes", "/models/mercedes/a.webp", true, "A-Class" },
                    { "mercedes_aberline", "mercedes", "/models/mercedes/aberline.webp", true, "A-Class Berline" },
                    { "mercedes_c", "mercedes", "/models/mercedes/c.webp", true, "C-Class" },
                    { "mercedes_chybride", "mercedes", "/models/mercedes/chybride.webp", true, "C-Class Hybride" },
                    { "mercedes_cla", "mercedes", "/models/mercedes/cla.webp", true, "CLA" },
                    { "mercedes_clecoupe", "mercedes", "/models/mercedes/clecoupe.webp", true, "CLE Coupé" },
                    { "mercedes_e", "mercedes", "/models/mercedes/e.webp", true, "E-Class" },
                    { "mercedes_ehybride", "mercedes", "/models/mercedes/ehybride.webp", true, "E-Class Hybride" },
                    { "mercedes_eqeberline", "mercedes", "/models/mercedes/eqeberline.webp", true, "EQE Berline" },
                    { "mercedes_eqesuv", "mercedes", "/models/mercedes/eqesuv.webp", true, "EQE SUV" },
                    { "mercedes_eqsberline", "mercedes", "/models/mercedes/eqsberline.webp", true, "EQS Berline" },
                    { "mercedes_eqssuv", "mercedes", "/models/mercedes/eqssuv.webp", true, "EQS SUV" },
                    { "mercedes_gla", "mercedes", "/models/mercedes/gla.webp", true, "GLA" },
                    { "mercedes_glb", "mercedes", "/models/mercedes/glb.webp", true, "GLB" },
                    { "mercedes_glc", "mercedes", "/models/mercedes/glc.webp", true, "GLC" },
                    { "mercedes_glccoupe", "mercedes", "/models/mercedes/glccoupe.webp", true, "GLC Coupé" },
                    { "mercedes_glccoupehybride", "mercedes", "/models/mercedes/glccoupehybride.webp", true, "GLC Coupé Hybride" },
                    { "mercedes_glchybride", "mercedes", "/models/mercedes/glchybride.webp", true, "GLC Hybride" },
                    { "mercedes_gle", "mercedes", "/models/mercedes/gle.webp", true, "GLE" },
                    { "mercedes_glecoupe", "mercedes", "/models/mercedes/glecoupe.webp", true, "GLE Coupé" },
                    { "mercedes_s", "mercedes", "/models/mercedes/s.webp", true, "S-Class" },
                    { "mercedes_v", "mercedes", "/models/mercedes/v.webp", true, "V-Class" },
                    { "mg_3", "mg", "/models/mg/3.webp", true, "MG3" },
                    { "mg_3hybride", "mg", "/models/mg/3hybride.webp", true, "MG3 Hybride" },
                    { "mg_4", "mg", "/models/mg/4.webp", true, "MG4" },
                    { "mg_5", "mg", "/models/mg/5.webp", true, "MG5" },
                    { "mg_7", "mg", "/models/mg/7.webp", true, "MG7" },
                    { "mg_ehs", "mg", "/models/mg/ehs.webp", true, "eHS" },
                    { "mg_ezs", "mg", "/models/mg/ezs.webp", true, "eZS" },
                    { "mg_gt", "mg", "/models/mg/gt.webp", true, "GT" },
                    { "mg_marvelr", "mg", "/models/mg/marvelr.webp", true, "Marvel R" },
                    { "mg_one", "mg", "/models/mg/one.webp", true, "One" },
                    { "mg_rx5", "mg", "/models/mg/rx5.webp", true, "RX5" },
                    { "mg_zs", "mg", "/models/mg/zs.webp", true, "ZS" },
                    { "mini_aceman", "mini", "/models/mini/aceman.webp", true, "Aceman" },
                    { "mini_coopercabrio", "mini", "/models/mini/coopercabrio.webp", true, "Cooper Cabrio" },
                    { "mini_countryman", "mini", "/models/mini/countryman.webp", true, "Countryman" },
                    { "mini_couperelectric", "mini", "/models/mini/couperelectric.webp", true, "Cooper Electric" },
                    { "mitsubishi_asx", "mitsubishi", "/models/mitsubishi/asx.webp", true, "ASX" },
                    { "mitsubishi_eclipsecross", "mitsubishi", "/models/mitsubishi/eclipsecross.webp", true, "Eclipse Cross" },
                    { "mitsubishi_l200", "mitsubishi", "/models/mitsubishi/l200.webp", true, "L200" },
                    { "mitsubishi_pajero", "mitsubishi", "/models/mitsubishi/pajero.webp", true, "Pajero" },
                    { "mitsubishi_pajerosport", "mitsubishi", "/models/mitsubishi/pajerosport.webp", true, "Pajero Sport" },
                    { "nissan_juke", "nissan", "/models/nissan/juke.webp", true, "Juke" },
                    { "nissan_qashqai", "nissan", "/models/nissan/qashqai.webp", true, "Qashqai" },
                    { "nissan_qashqaiepower", "nissan", "/models/nissan/qashqaiepower.webp", true, "Qashqai e-Power" },
                    { "opel_astra", "opel", "/models/opel/astra.webp", true, "Astra" },
                    { "opel_combocargo", "opel", "/models/opel/combocargo.webp", true, "Combo Cargo" },
                    { "opel_corsa", "opel", "/models/opel/corsa.webp", true, "Corsa" },
                    { "opel_crossland", "opel", "/models/opel/crossland.webp", true, "Crossland" },
                    { "opel_mokka", "opel", "/models/opel/mokka.webp", true, "Mokka" },
                    { "peugeot_2008", "peugeot", "/models/peugeot/2008.webp", true, "2008" },
                    { "peugeot_208", "peugeot", "/models/peugeot/208.webp", true, "208" },
                    { "peugeot_308", "peugeot", "/models/peugeot/308.webp", true, "308" },
                    { "peugeot_408", "peugeot", "/models/peugeot/408.webp", true, "408" },
                    { "peugeot_408gt", "peugeot", "/models/peugeot/408gt.webp", true, "408 GT" },
                    { "peugeot_boxer", "peugeot", "/models/peugeot/boxer.webp", true, "Boxer" },
                    { "peugeot_boxerdouble", "peugeot", "/models/peugeot/boxerdouble.webp", true, "Boxer Double" },
                    { "peugeot_expert", "peugeot", "/models/peugeot/expert.webp", true, "Expert" },
                    { "peugeot_expertcombi", "peugeot", "/models/peugeot/expertcombi.webp", true, "Expert Combi" },
                    { "peugeot_landtrekdouble", "peugeot", "/models/peugeot/landtrekdouble.webp", true, "Landtrek Double" },
                    { "peugeot_landtreksimple", "peugeot", "/models/peugeot/landtreksimple.webp", true, "Landtrek Simple" },
                    { "peugeot_partner", "peugeot", "/models/peugeot/partner.webp", true, "Partner" },
                    { "peugeot_rifter", "peugeot", "/models/peugeot/rifter.webp", true, "Rifter" },
                    { "peugeot_traveller", "peugeot", "/models/peugeot/traveller.webp", true, "Traveller" },
                    { "porsche_911", "porsche", "/models/porsche/911.webp", true, "911" },
                    { "porsche_cayenne", "porsche", "/models/porsche/cayenne.webp", true, "Cayenne" },
                    { "porsche_cayennecoupe", "porsche", "/models/porsche/cayennecoupe.webp", true, "Cayenne Coupé" },
                    { "porsche_macanelectric", "porsche", "/models/porsche/macanelectric.webp", true, "Macan Electric" },
                    { "porsche_taycan", "porsche", "/models/porsche/taycan.webp", true, "Taycan" },
                    { "porsche_taycancrossturismo", "porsche", "/models/porsche/taycancrossturismo.webp", true, "Taycan Cross Turismo" },
                    { "renault_austral", "renault", "/models/renault/austral.webp", true, "Austral" },
                    { "renault_clio", "renault", "/models/renault/clio.webp", true, "Clio" },
                    { "renault_expresscombi", "renault", "/models/renault/expresscombi.webp", true, "Express Combi" },
                    { "renault_expressvan", "renault", "/models/renault/expressvan.webp", true, "Express Van" },
                    { "renault_master", "renault", "/models/renault/master.webp", true, "Master" },
                    { "renault_megane", "renault", "/models/renault/megane.webp", true, "Megane" },
                    { "renault_meganesedan", "renault", "/models/renault/meganesedan.webp", true, "Megane Sedan" },
                    { "seat_arona", "seat", "/models/seat/arona.webp", true, "Arona" },
                    { "seat_ateca", "seat", "/models/seat/ateca.webp", true, "Ateca" },
                    { "seat_ibiza", "seat", "/models/seat/ibiza.webp", true, "Ibiza" },
                    { "seat_leon", "seat", "/models/seat/leon.webp", true, "Leon" },
                    { "skoda_fabia", "skoda", "/models/skoda/fabia.webp", true, "Fabia" },
                    { "skoda_kamiq", "skoda", "/models/skoda/kamiq.webp", true, "Kamiq" },
                    { "skoda_kushaq", "skoda", "/models/skoda/kushaq.webp", true, "Kushaq" },
                    { "skoda_octavia", "skoda", "/models/skoda/octavia.webp", true, "Octavia" },
                    { "skoda_scala", "skoda", "/models/skoda/scala.webp", true, "Scala" },
                    { "suzuki_baleno", "suzuki", "/models/suzuki/baleno.webp", true, "Baleno" },
                    { "suzuki_ciaz", "suzuki", "/models/suzuki/ciaz.webp", true, "Ciaz" },
                    { "suzuki_dzire", "suzuki", "/models/suzuki/dzire.webp", true, "Dzire" },
                    { "suzuki_ertiga", "suzuki", "/models/suzuki/ertiga.webp", true, "Ertiga" },
                    { "suzuki_fronx", "suzuki", "/models/suzuki/fronx.webp", true, "Fronx" },
                    { "suzuki_jimny3p", "suzuki", "/models/suzuki/jimny3p.webp", true, "Jimny 3 Portes" },
                    { "suzuki_jimny5p", "suzuki", "/models/suzuki/jimny5p.webp", true, "Jimny 5 Portes" },
                    { "suzuki_swift", "suzuki", "/models/suzuki/swift.webp", true, "Swift" },
                    { "toyota_corollasedan", "toyota", "/models/toyota/corollasedan.webp", true, "Corolla Sedan" },
                    { "toyota_corollasedanhybride", "toyota", "/models/toyota/corollasedanhybride.webp", true, "Corolla Sedan Hybride" },
                    { "toyota_fortuner", "toyota", "/models/toyota/fortuner.webp", true, "Fortuner" },
                    { "toyota_hiacevan", "toyota", "/models/toyota/hiacevan.webp", true, "Hiace Van" },
                    { "toyota_hiluxdouble", "toyota", "/models/toyota/hiluxdouble.webp", true, "Hilux Double Cabine" },
                    { "toyota_hiluxsimple", "toyota", "/models/toyota/hiluxsimple.webp", true, "Hilux Simple Cabine" },
                    { "toyota_landcruiser300", "toyota", "/models/toyota/landcruiser300.webp", true, "Land Cruiser 300" },
                    { "toyota_landcruiser76", "toyota", "/models/toyota/landcruiser76.webp", true, "Land Cruiser 76" },
                    { "toyota_landcruiser79", "toyota", "/models/toyota/landcruiser79.webp", true, "Land Cruiser 79" },
                    { "toyota_prado", "toyota", "/models/toyota/prado.webp", true, "Land Cruiser Prado" },
                    { "toyota_rav4hybride", "toyota", "/models/toyota/rav4hybride.webp", true, "RAV4 Hybride" },
                    { "toyota_yariscrosshybride", "toyota", "/models/toyota/yariscrosshybride.webp", true, "Yaris Cross Hybride" },
                    { "toyota_yarishybride", "toyota", "/models/toyota/yarishybride.webp", true, "Yaris Hybride" },
                    { "volkswagen_amarok", "volkswagen", "/models/volkswagen/amarok.webp", true, "Amarok" },
                    { "volkswagen_caddycargo", "volkswagen", "/models/volkswagen/caddycargo.webp", true, "Caddy Cargo" },
                    { "volkswagen_golf8", "volkswagen", "/models/volkswagen/golf8.webp", true, "Golf 8" },
                    { "volkswagen_polo", "volkswagen", "/models/volkswagen/polo.webp", true, "Polo" },
                    { "volkswagen_tcross", "volkswagen", "/models/volkswagen/tcross.webp", true, "T-Cross" },
                    { "volkswagen_tiguan", "volkswagen", "/models/volkswagen/tiguan.webp", true, "Tiguan" },
                    { "volkswagen_virtus", "volkswagen", "/models/volkswagen/virtus.webp", true, "Virtus" },
                    { "volvo_ec40", "volvo", "/models/volvo/ec40.webp", true, "EC40" },
                    { "volvo_ex30", "volvo", "/models/volvo/ex30.webp", true, "EX30" },
                    { "volvo_xc40", "volvo", "/models/volvo/xc40.webp", true, "XC40" },
                    { "volvo_xc60", "volvo", "/models/volvo/xc60.webp", true, "XC60" },
                    { "volvo_xc90", "volvo", "/models/volvo/xc90.webp", true, "XC90" },
                    { "wallys_annibal", "wallys", "/models/wallys/annibal.webp", true, "Annibal" },
                    { "wallys_annibalxxl", "wallys", "/models/wallys/annibalxxl.webp", true, "Annibal XXL" },
                    { "wallys_wolf", "wallys", "/models/wallys/wolf.webp", true, "Wolf" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Models_BrandId",
                table: "Models",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Trims_ModelId",
                table: "Trims",
                column: "ModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configuration");

            migrationBuilder.DropTable(
                name: "Trims");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
