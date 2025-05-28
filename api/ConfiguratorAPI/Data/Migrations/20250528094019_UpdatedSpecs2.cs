using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConfiguratorAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSpecs2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Code",
                keyValue: "audi_a3berline");

            migrationBuilder.RenameColumn(
                name: "EnginePowerKW",
                table: "Trims",
                newName: "Seats");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Seats",
                table: "Trims",
                newName: "EnginePowerKW");

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Code", "BrandCode", "ImgUrl", "IsActive", "Name" },
                values: new object[] { "audi_a3berline", "audi", "/models/audi/a3berline.webp", true, "A3 Berline" });
        }
    }
}
