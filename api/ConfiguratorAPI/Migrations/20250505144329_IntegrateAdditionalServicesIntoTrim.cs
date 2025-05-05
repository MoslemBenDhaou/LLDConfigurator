using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConfiguratorAPI.Migrations
{
    /// <inheritdoc />
    public partial class IntegrateAdditionalServicesIntoTrim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "additional_services");

            migrationBuilder.AddColumn<bool>(
                name: "full_insurance_0_percent_default",
                table: "trims",
                type: "boolean",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<decimal>(
                name: "full_insurance_0_percent_price",
                table: "trims",
                type: "numeric(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "full_insurance_0_percent_required",
                table: "trims",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "full_insurance_4_percent_default",
                table: "trims",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "full_insurance_4_percent_price",
                table: "trims",
                type: "numeric(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "full_insurance_4_percent_required",
                table: "trims",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "geolocalisation_default",
                table: "trims",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "geolocalisation_price",
                table: "trims",
                type: "numeric(10,2)",
                nullable: false,
                defaultValue: 19.90m);

            migrationBuilder.AddColumn<bool>(
                name: "geolocalisation_required",
                table: "trims",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "maintenance_package_default",
                table: "trims",
                type: "boolean",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<decimal>(
                name: "maintenance_package_price",
                table: "trims",
                type: "numeric(10,2)",
                nullable: false,
                defaultValue: 49.99m);

            migrationBuilder.AddColumn<bool>(
                name: "maintenance_package_required",
                table: "trims",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "purchase_option_default",
                table: "trims",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "purchase_option_price",
                table: "trims",
                type: "numeric(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "purchase_option_required",
                table: "trims",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "road_assistance_default",
                table: "trims",
                type: "boolean",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<decimal>(
                name: "road_assistance_price",
                table: "trims",
                type: "numeric(10,2)",
                nullable: false,
                defaultValue: 15.99m);

            migrationBuilder.AddColumn<bool>(
                name: "road_assistance_required",
                table: "trims",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "vignettes_default",
                table: "trims",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "vignettes_price",
                table: "trims",
                type: "numeric(10,2)",
                nullable: false,
                defaultValue: 29.99m);

            migrationBuilder.AddColumn<bool>(
                name: "vignettes_required",
                table: "trims",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "is_active", "logo", "name" },
                values: new object[,]
                {
                    { "byd", true, "/brands/byd.webp", "BYD" },
                    { "chery", true, "/brands/chery.webp", "Chery" },
                    { "chevrolet", true, "/brands/chevrolet.webp", "Chevrolet" },
                    { "citroen", true, "/brands/citroen.webp", "Citroen" },
                    { "cupra", true, "/brands/cupra.webp", "Cupra" },
                    { "dacia", true, "/brands/dacia.webp", "Dacia" },
                    { "fiat", true, "/brands/fiat.webp", "FIAT" },
                    { "ford", true, "/brands/ford.webp", "Ford" },
                    { "haval", true, "/brands/haval.webp", "Haval" },
                    { "honda", true, "/brands/honda.webp", "Honda" },
                    { "hyundai", true, "/brands/hyundai.webp", "Hyundai" },
                    { "jaguar", true, "/brands/jaguar.webp", "Jaguar" },
                    { "jeep", true, "/brands/jeep.webp", "Jeep" },
                    { "kgm", true, "/brands/kgm.webp", "KGM" },
                    { "kia", true, "/brands/kia.webp", "Kia" },
                    { "landrover", true, "/brands/landrover.webp", "Land Rover" },
                    { "mahindra", true, "/brands/mahindra.webp", "Mahindra" },
                    { "mg", true, "/brands/mg.webp", "MG" },
                    { "mini", true, "/brands/mini.webp", "Mini" },
                    { "mitsubishi", true, "/brands/mitsubishi.webp", "Mitsubishi" },
                    { "nissan", true, "/brands/nissan.webp", "Nissan" },
                    { "opel", true, "/brands/opel.webp", "Opel" },
                    { "peugeot", true, "/brands/peugeot.webp", "Peugeot" },
                    { "porsche", true, "/brands/porsche.webp", "Porsche" },
                    { "renault", true, "/brands/renault.webp", "Renault" },
                    { "seat", true, "/brands/seat.webp", "SEAT" },
                    { "skoda", true, "/brands/skoda.webp", "Skoda" },
                    { "suzuki", true, "/brands/suzuki.webp", "Suzuki" },
                    { "toyota", true, "/brands/toyota.webp", "Toyota" },
                    { "volkswagen", true, "/brands/volkswagen.webp", "Volkswagen" },
                    { "volvo", true, "/brands/volvo.webp", "Volvo" },
                    { "wallys", true, "/brands/wallys.webp", "Wallys" }
                });

            migrationBuilder.UpdateData(
                table: "trims",
                keyColumns: new[] { "brand_id", "id", "model_id" },
                keyValues: new object[] { "alfaromeo", "2.0-turbo-super-bva", "giulia" },
                columns: new[] { "features", "full_insurance_0_percent_default", "full_insurance_0_percent_price", "full_insurance_4_percent_price", "geolocalisation_price", "maintenance_package_default", "maintenance_package_price", "purchase_option_price", "road_assistance_default", "road_assistance_price", "vignettes_price" },
                values: new object[] { new List<string> { "2.0L Turbo Engine", "8-Speed Automatic Transmission", "Rear-Wheel Drive", "Leather Interior", "Dual-Zone Climate Control", "Infotainment System with Navigation", "Parking Sensors", "Cruise Control" }, true, 35.92m, 26.94m, 19.90m, true, 49.99m, 79200.00m, true, 15.99m, 29.99m });

            migrationBuilder.UpdateData(
                table: "trims",
                keyColumns: new[] { "brand_id", "id", "model_id" },
                keyValues: new object[] { "audi", "35-tfsi-business-extended", "a3-berline" },
                columns: new[] { "features", "full_insurance_0_percent_default", "full_insurance_0_percent_price", "full_insurance_4_percent_price", "geolocalisation_price", "maintenance_package_default", "maintenance_package_price", "purchase_option_price", "road_assistance_default", "road_assistance_price", "vignettes_price" },
                values: new object[] { new List<string> { "1.5L TFSI Engine", "150 ch", "Manual 6-Speed Transmission", "Front-Wheel Drive", "MMI Navigation System", "Audi Virtual Cockpit", "Dual-Zone Climate Control", "Parking Sensors" }, true, 27.92m, 20.94m, 19.90m, true, 49.99m, 58000.00m, true, 15.99m, 29.99m });

            migrationBuilder.UpdateData(
                table: "trims",
                keyColumns: new[] { "brand_id", "id", "model_id" },
                keyValues: new object[] { "audi", "35-tfsi-s-line-bva", "q2" },
                columns: new[] { "features", "full_insurance_0_percent_default", "full_insurance_0_percent_price", "full_insurance_4_percent_price", "geolocalisation_price", "maintenance_package_default", "maintenance_package_price", "purchase_option_price", "road_assistance_default", "road_assistance_price", "vignettes_price" },
                values: new object[] { new List<string> { "1.5L TFSI Engine", "150 ch", "Automatic 7-Speed Transmission", "Front-Wheel Drive", "S Line Package", "MMI Navigation System", "Audi Virtual Cockpit", "LED Headlights" }, true, 31.92m, 23.94m, 19.90m, true, 49.99m, 62000.00m, true, 15.99m, 29.99m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "byd");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "chery");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "chevrolet");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "citroen");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "cupra");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "dacia");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "fiat");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "ford");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "haval");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "honda");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "hyundai");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "jaguar");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "jeep");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "kgm");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "kia");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "landrover");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "mahindra");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "mg");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "mini");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "mitsubishi");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "nissan");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "opel");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "peugeot");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "porsche");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "renault");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "seat");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "skoda");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "suzuki");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "toyota");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "volkswagen");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "volvo");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: "wallys");

            migrationBuilder.DropColumn(
                name: "full_insurance_0_percent_default",
                table: "trims");

            migrationBuilder.DropColumn(
                name: "full_insurance_0_percent_price",
                table: "trims");

            migrationBuilder.DropColumn(
                name: "full_insurance_0_percent_required",
                table: "trims");

            migrationBuilder.DropColumn(
                name: "full_insurance_4_percent_default",
                table: "trims");

            migrationBuilder.DropColumn(
                name: "full_insurance_4_percent_price",
                table: "trims");

            migrationBuilder.DropColumn(
                name: "full_insurance_4_percent_required",
                table: "trims");

            migrationBuilder.DropColumn(
                name: "geolocalisation_default",
                table: "trims");

            migrationBuilder.DropColumn(
                name: "geolocalisation_price",
                table: "trims");

            migrationBuilder.DropColumn(
                name: "geolocalisation_required",
                table: "trims");

            migrationBuilder.DropColumn(
                name: "maintenance_package_default",
                table: "trims");

            migrationBuilder.DropColumn(
                name: "maintenance_package_price",
                table: "trims");

            migrationBuilder.DropColumn(
                name: "maintenance_package_required",
                table: "trims");

            migrationBuilder.DropColumn(
                name: "purchase_option_default",
                table: "trims");

            migrationBuilder.DropColumn(
                name: "purchase_option_price",
                table: "trims");

            migrationBuilder.DropColumn(
                name: "purchase_option_required",
                table: "trims");

            migrationBuilder.DropColumn(
                name: "road_assistance_default",
                table: "trims");

            migrationBuilder.DropColumn(
                name: "road_assistance_price",
                table: "trims");

            migrationBuilder.DropColumn(
                name: "road_assistance_required",
                table: "trims");

            migrationBuilder.DropColumn(
                name: "vignettes_default",
                table: "trims");

            migrationBuilder.DropColumn(
                name: "vignettes_price",
                table: "trims");

            migrationBuilder.DropColumn(
                name: "vignettes_required",
                table: "trims");

            migrationBuilder.CreateTable(
                name: "additional_services",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    trim_id = table.Column<string>(type: "text", nullable: false),
                    model_id = table.Column<string>(type: "text", nullable: false),
                    brand_id = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    is_default = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    is_percentage = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    is_required = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    price = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    type = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_additional_services", x => new { x.id, x.trim_id, x.model_id, x.brand_id });
                    table.ForeignKey(
                        name: "FK_additional_services_trims_trim_id_model_id_brand_id",
                        columns: x => new { x.trim_id, x.model_id, x.brand_id },
                        principalTable: "trims",
                        principalColumns: new[] { "id", "model_id", "brand_id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "additional_services",
                columns: new[] { "brand_id", "id", "model_id", "trim_id", "description", "is_default", "is_percentage", "name", "price", "type" },
                values: new object[] { "alfaromeo", 1, "giulia", "2.0-turbo-super-bva", "Complete insurance coverage with 0% deductible", true, true, "Full Insurance 0%", 35.92m, "FullInsurance0Percent" });

            migrationBuilder.InsertData(
                table: "additional_services",
                columns: new[] { "brand_id", "id", "model_id", "trim_id", "description", "is_percentage", "name", "price", "type" },
                values: new object[] { "alfaromeo", 2, "giulia", "2.0-turbo-super-bva", "Complete insurance coverage with 4% deductible", true, "Full Insurance 4%", 26.94m, "FullInsurance4Percent" });

            migrationBuilder.InsertData(
                table: "additional_services",
                columns: new[] { "brand_id", "id", "model_id", "trim_id", "description", "is_default", "name", "price", "type" },
                values: new object[,]
                {
                    { "alfaromeo", 3, "giulia", "2.0-turbo-super-bva", "24/7 roadside assistance service", true, "Road Assistance", 15.99m, "RoadAssistance" },
                    { "alfaromeo", 4, "giulia", "2.0-turbo-super-bva", "Regular maintenance service including oil changes and inspections", true, "Maintenance Package", 49.99m, "MaintenancePackage" }
                });

            migrationBuilder.InsertData(
                table: "additional_services",
                columns: new[] { "brand_id", "id", "model_id", "trim_id", "description", "name", "price", "type" },
                values: new object[,]
                {
                    { "alfaromeo", 5, "giulia", "2.0-turbo-super-bva", "Road tax vignettes for European countries", "Vignettes", 29.99m, "Vignettes" },
                    { "alfaromeo", 6, "giulia", "2.0-turbo-super-bva", "GPS tracking system for your vehicle", "Geolocalisation", 19.90m, "Geolocalisation" },
                    { "alfaromeo", 7, "giulia", "2.0-turbo-super-bva", "Option to purchase the vehicle at the end of the lease", "Purchase Option", 79200.00m, "PurchaseOption" }
                });

            migrationBuilder.InsertData(
                table: "additional_services",
                columns: new[] { "brand_id", "id", "model_id", "trim_id", "description", "is_default", "is_percentage", "name", "price", "type" },
                values: new object[] { "audi", 8, "a3-berline", "35-tfsi-business-extended", "Complete insurance coverage with 0% deductible", true, true, "Full Insurance 0%", 27.92m, "FullInsurance0Percent" });

            migrationBuilder.InsertData(
                table: "additional_services",
                columns: new[] { "brand_id", "id", "model_id", "trim_id", "description", "is_percentage", "name", "price", "type" },
                values: new object[] { "audi", 9, "a3-berline", "35-tfsi-business-extended", "Complete insurance coverage with 4% deductible", true, "Full Insurance 4%", 20.94m, "FullInsurance4Percent" });

            migrationBuilder.InsertData(
                table: "additional_services",
                columns: new[] { "brand_id", "id", "model_id", "trim_id", "description", "is_default", "name", "price", "type" },
                values: new object[,]
                {
                    { "audi", 10, "a3-berline", "35-tfsi-business-extended", "24/7 roadside assistance service", true, "Road Assistance", 15.99m, "RoadAssistance" },
                    { "audi", 11, "a3-berline", "35-tfsi-business-extended", "Regular maintenance service including oil changes and inspections", true, "Maintenance Package", 49.99m, "MaintenancePackage" }
                });

            migrationBuilder.InsertData(
                table: "additional_services",
                columns: new[] { "brand_id", "id", "model_id", "trim_id", "description", "name", "price", "type" },
                values: new object[,]
                {
                    { "audi", 12, "a3-berline", "35-tfsi-business-extended", "Road tax vignettes for European countries", "Vignettes", 29.99m, "Vignettes" },
                    { "audi", 13, "a3-berline", "35-tfsi-business-extended", "GPS tracking system for your vehicle", "Geolocalisation", 19.90m, "Geolocalisation" },
                    { "audi", 14, "a3-berline", "35-tfsi-business-extended", "Option to purchase the vehicle at the end of the lease", "Purchase Option", 58000.00m, "PurchaseOption" }
                });

            migrationBuilder.UpdateData(
                table: "trims",
                keyColumns: new[] { "brand_id", "id", "model_id" },
                keyValues: new object[] { "alfaromeo", "2.0-turbo-super-bva", "giulia" },
                column: "features",
                value: new List<string> { "2.0L Turbo Engine", "8-Speed Automatic Transmission", "Rear-Wheel Drive", "Leather Interior", "Dual-Zone Climate Control", "Infotainment System with Navigation", "Parking Sensors", "Cruise Control" });

            migrationBuilder.UpdateData(
                table: "trims",
                keyColumns: new[] { "brand_id", "id", "model_id" },
                keyValues: new object[] { "audi", "35-tfsi-business-extended", "a3-berline" },
                column: "features",
                value: new List<string> { "1.5L TFSI Engine", "150 ch", "Manual 6-Speed Transmission", "Front-Wheel Drive", "MMI Navigation System", "Audi Virtual Cockpit", "Dual-Zone Climate Control", "Parking Sensors" });

            migrationBuilder.UpdateData(
                table: "trims",
                keyColumns: new[] { "brand_id", "id", "model_id" },
                keyValues: new object[] { "audi", "35-tfsi-s-line-bva", "q2" },
                column: "features",
                value: new List<string> { "1.5L TFSI Engine", "150 ch", "Automatic 7-Speed Transmission", "Front-Wheel Drive", "S Line Package", "MMI Navigation System", "Audi Virtual Cockpit", "LED Headlights" });

            migrationBuilder.CreateIndex(
                name: "IX_additional_services_trim_id_model_id_brand_id",
                table: "additional_services",
                columns: new[] { "trim_id", "model_id", "brand_id" });
        }
    }
}
