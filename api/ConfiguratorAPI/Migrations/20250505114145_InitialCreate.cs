using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConfiguratorAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "brands",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    logo = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brands", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "models",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    brand_id = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    image = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_models", x => new { x.id, x.brand_id });
                    table.ForeignKey(
                        name: "FK_models_brands_brand_id",
                        column: x => x.brand_id,
                        principalTable: "brands",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "trims",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    model_id = table.Column<string>(type: "text", nullable: false),
                    brand_id = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    features = table.Column<List<string>>(type: "jsonb", nullable: false),
                    price = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    list_price = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trims", x => new { x.id, x.model_id, x.brand_id });
                    table.ForeignKey(
                        name: "FK_trims_models_model_id_brand_id",
                        columns: x => new { x.model_id, x.brand_id },
                        principalTable: "models",
                        principalColumns: new[] { "id", "brand_id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "additional_services",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    trim_id = table.Column<string>(type: "text", nullable: false),
                    model_id = table.Column<string>(type: "text", nullable: false),
                    brand_id = table.Column<string>(type: "text", nullable: false),
                    type = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    price = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    is_percentage = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    is_required = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    is_default = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false)
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

            migrationBuilder.CreateTable(
                name: "feature_groups",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    trim_id = table.Column<string>(type: "text", nullable: false),
                    model_id = table.Column<string>(type: "text", nullable: false),
                    brand_id = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_feature_groups", x => new { x.id, x.trim_id, x.model_id, x.brand_id });
                    table.ForeignKey(
                        name: "FK_feature_groups_trims_trim_id_model_id_brand_id",
                        columns: x => new { x.trim_id, x.model_id, x.brand_id },
                        principalTable: "trims",
                        principalColumns: new[] { "id", "model_id", "brand_id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "price_matrices",
                columns: table => new
                {
                    trim_id = table.Column<string>(type: "text", nullable: false),
                    model_id = table.Column<string>(type: "text", nullable: false),
                    brand_id = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_price_matrices", x => new { x.trim_id, x.model_id, x.brand_id });
                    table.ForeignKey(
                        name: "FK_price_matrices_trims_trim_id_model_id_brand_id",
                        columns: x => new { x.trim_id, x.model_id, x.brand_id },
                        principalTable: "trims",
                        principalColumns: new[] { "id", "model_id", "brand_id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "trim_features",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    feature_group_id = table.Column<int>(type: "integer", nullable: false),
                    trim_id = table.Column<string>(type: "text", nullable: false),
                    model_id = table.Column<string>(type: "text", nullable: false),
                    brand_id = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    value = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trim_features", x => new { x.id, x.feature_group_id, x.trim_id, x.model_id, x.brand_id });
                    table.ForeignKey(
                        name: "FK_trim_features_feature_groups_feature_group_id_trim_id_model~",
                        columns: x => new { x.feature_group_id, x.trim_id, x.model_id, x.brand_id },
                        principalTable: "feature_groups",
                        principalColumns: new[] { "id", "trim_id", "model_id", "brand_id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "price_points",
                columns: table => new
                {
                    trim_id = table.Column<string>(type: "text", nullable: false),
                    model_id = table.Column<string>(type: "text", nullable: false),
                    brand_id = table.Column<string>(type: "text", nullable: false),
                    duration = table.Column<int>(type: "integer", nullable: false),
                    kilometers = table.Column<int>(type: "integer", nullable: false),
                    advance_0 = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    advance_10 = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    advance_20 = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    advance_30 = table.Column<decimal>(type: "numeric(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_price_points", x => new { x.trim_id, x.model_id, x.brand_id, x.duration, x.kilometers });
                    table.ForeignKey(
                        name: "FK_price_points_price_matrices_trim_id_model_id_brand_id",
                        columns: x => new { x.trim_id, x.model_id, x.brand_id },
                        principalTable: "price_matrices",
                        principalColumns: new[] { "trim_id", "model_id", "brand_id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "is_active", "logo", "name" },
                values: new object[,]
                {
                    { "alfaromeo", true, "/brands/alfaromeo.webp", "Alfa Romeo" },
                    { "audi", true, "/brands/audi.webp", "Audi" },
                    { "bmw", true, "/brands/bmw.webp", "BMW" },
                    { "mercedes", true, "/brands/mercedes.webp", "Mercedes" }
                });

            migrationBuilder.InsertData(
                table: "models",
                columns: new[] { "brand_id", "id", "image", "is_active", "name" },
                values: new object[,]
                {
                    { "bmw", "3-series", "/models/bmw/3-series.webp", true, "3 Series" },
                    { "bmw", "5-series", "/models/bmw/5-series.webp", true, "5 Series" },
                    { "mercedes", "a-class", "/models/mercedes/a-class.webp", true, "A-Class" },
                    { "audi", "a3-berline", "/models/audi/a3-berline.webp", true, "A3 Berline" },
                    { "mercedes", "c-class", "/models/mercedes/c-class.webp", true, "C-Class" },
                    { "mercedes", "e-class", "/models/mercedes/e-class.webp", true, "E-Class" },
                    { "audi", "e-tron-gt", "/models/audi/e-tron-gt.webp", true, "e-tron GT" },
                    { "alfaromeo", "giulia", "/models/alfaromeo/giulia.webp", true, "Giulia" },
                    { "mercedes", "glc", "/models/mercedes/glc.webp", true, "GLC" },
                    { "audi", "q2", "/models/audi/q2.webp", true, "Q2" },
                    { "audi", "q3", "/models/audi/q3.webp", true, "Q3" },
                    { "audi", "q3-sportback", "/models/audi/q3-sportback.webp", true, "Q3 Sportback" },
                    { "audi", "q7", "/models/audi/q7.webp", true, "Q7" },
                    { "audi", "q8", "/models/audi/q8.webp", true, "Q8" },
                    { "audi", "q8-e-tron", "/models/audi/q8-e-tron.webp", true, "Q8 e-tron" },
                    { "audi", "q8-sportback-e-tron", "/models/audi/q8-sportback-e-tron.webp", true, "Q8 Sportback e-tron" },
                    { "alfaromeo", "stelvio", "/models/alfaromeo/stelvio.webp", true, "Stelvio" },
                    { "bmw", "x3", "/models/bmw/x3.webp", true, "X3" },
                    { "bmw", "x5", "/models/bmw/x5.webp", true, "X5" }
                });

            migrationBuilder.InsertData(
                table: "trims",
                columns: new[] { "brand_id", "id", "model_id", "features", "is_active", "list_price", "name", "price" },
                values: new object[,]
                {
                    { "alfaromeo", "2.0-turbo-super-bva", "giulia", new List<string> { "2.0L Turbo Engine", "8-Speed Automatic Transmission", "Rear-Wheel Drive", "Leather Interior", "Dual-Zone Climate Control", "Infotainment System with Navigation", "Parking Sensors", "Cruise Control" }, true, 198000m, "2.0 Turbo Super BVA", 449m },
                    { "audi", "35-tfsi-business-extended", "a3-berline", new List<string> { "1.5L TFSI Engine", "150 ch", "Manual 6-Speed Transmission", "Front-Wheel Drive", "MMI Navigation System", "Audi Virtual Cockpit", "Dual-Zone Climate Control", "Parking Sensors" }, true, 145000m, "35 TFSI Business Extended", 349m },
                    { "audi", "35-tfsi-s-line-bva", "q2", new List<string> { "1.5L TFSI Engine", "150 ch", "Automatic 7-Speed Transmission", "Front-Wheel Drive", "S Line Package", "MMI Navigation System", "Audi Virtual Cockpit", "LED Headlights" }, true, 155000m, "35 TFSI S Line BVA", 399m }
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

            migrationBuilder.InsertData(
                table: "feature_groups",
                columns: new[] { "brand_id", "id", "model_id", "trim_id", "name" },
                values: new object[,]
                {
                    { "alfaromeo", 1, "giulia", "2.0-turbo-super-bva", "Caractéristiques" },
                    { "alfaromeo", 2, "giulia", "2.0-turbo-super-bva", "Transmission" },
                    { "alfaromeo", 3, "giulia", "2.0-turbo-super-bva", "Performances" },
                    { "audi", 4, "a3-berline", "35-tfsi-business-extended", "Caractéristiques" },
                    { "audi", 5, "a3-berline", "35-tfsi-business-extended", "Transmission" },
                    { "audi", 6, "a3-berline", "35-tfsi-business-extended", "Performances" }
                });

            migrationBuilder.InsertData(
                table: "trim_features",
                columns: new[] { "brand_id", "feature_group_id", "id", "model_id", "trim_id", "name", "value" },
                values: new object[,]
                {
                    { "alfaromeo", 1, 1, "giulia", "2.0-turbo-super-bva", "Moteur", "2.0L Turbo" },
                    { "alfaromeo", 1, 2, "giulia", "2.0-turbo-super-bva", "Puissance", "200 ch" },
                    { "alfaromeo", 1, 3, "giulia", "2.0-turbo-super-bva", "Couple", "330 Nm" },
                    { "alfaromeo", 1, 4, "giulia", "2.0-turbo-super-bva", "Cylindrée", "1995 cc" },
                    { "alfaromeo", 2, 5, "giulia", "2.0-turbo-super-bva", "Boîte de vitesses", "Automatique 8 rapports" },
                    { "alfaromeo", 2, 6, "giulia", "2.0-turbo-super-bva", "Transmission", "Propulsion arrière" },
                    { "alfaromeo", 3, 7, "giulia", "2.0-turbo-super-bva", "Vitesse maximale", "235 km/h" },
                    { "alfaromeo", 3, 8, "giulia", "2.0-turbo-super-bva", "0-100 km/h", "6.6 secondes" },
                    { "audi", 4, 9, "a3-berline", "35-tfsi-business-extended", "Moteur", "1.5L TFSI" },
                    { "audi", 4, 10, "a3-berline", "35-tfsi-business-extended", "Puissance", "150 ch" },
                    { "audi", 4, 11, "a3-berline", "35-tfsi-business-extended", "Couple", "250 Nm" },
                    { "audi", 4, 12, "a3-berline", "35-tfsi-business-extended", "Cylindrée", "1498 cc" },
                    { "audi", 5, 13, "a3-berline", "35-tfsi-business-extended", "Boîte de vitesses", "Manuelle 6 rapports" },
                    { "audi", 5, 14, "a3-berline", "35-tfsi-business-extended", "Transmission", "Traction avant" },
                    { "audi", 6, 15, "a3-berline", "35-tfsi-business-extended", "Vitesse maximale", "224 km/h" },
                    { "audi", 6, 16, "a3-berline", "35-tfsi-business-extended", "0-100 km/h", "8.2 secondes" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_additional_services_trim_id_model_id_brand_id",
                table: "additional_services",
                columns: new[] { "trim_id", "model_id", "brand_id" });

            migrationBuilder.CreateIndex(
                name: "IX_feature_groups_trim_id_model_id_brand_id",
                table: "feature_groups",
                columns: new[] { "trim_id", "model_id", "brand_id" });

            migrationBuilder.CreateIndex(
                name: "IX_models_brand_id",
                table: "models",
                column: "brand_id");

            migrationBuilder.CreateIndex(
                name: "IX_trim_features_feature_group_id_trim_id_model_id_brand_id",
                table: "trim_features",
                columns: new[] { "feature_group_id", "trim_id", "model_id", "brand_id" });

            migrationBuilder.CreateIndex(
                name: "IX_trims_model_id_brand_id",
                table: "trims",
                columns: new[] { "model_id", "brand_id" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "additional_services");

            migrationBuilder.DropTable(
                name: "price_points");

            migrationBuilder.DropTable(
                name: "trim_features");

            migrationBuilder.DropTable(
                name: "price_matrices");

            migrationBuilder.DropTable(
                name: "feature_groups");

            migrationBuilder.DropTable(
                name: "trims");

            migrationBuilder.DropTable(
                name: "models");

            migrationBuilder.DropTable(
                name: "brands");
        }
    }
}
