using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConfiguratorAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedReference : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Brands_BrandId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Trims_Models_ModelId",
                table: "Trims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trims",
                table: "Trims");

            migrationBuilder.RenameColumn(
                name: "ModelId",
                table: "Trims",
                newName: "ModelCode");

            migrationBuilder.RenameIndex(
                name: "IX_Trims_ModelId",
                table: "Trims",
                newName: "IX_Trims_ModelCode");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "Models",
                newName: "BrandCode");

            migrationBuilder.RenameIndex(
                name: "IX_Models_BrandId",
                table: "Models",
                newName: "IX_Models_BrandCode");

            migrationBuilder.AddColumn<string>(
                name: "TrimCode",
                table: "Trims",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trims",
                table: "Trims",
                columns: new[] { "TrimCode", "ModelCode" });

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Brands_BrandCode",
                table: "Models",
                column: "BrandCode",
                principalTable: "Brands",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trims_Models_ModelCode",
                table: "Trims",
                column: "ModelCode",
                principalTable: "Models",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Brands_BrandCode",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Trims_Models_ModelCode",
                table: "Trims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trims",
                table: "Trims");

            migrationBuilder.DropColumn(
                name: "TrimCode",
                table: "Trims");

            migrationBuilder.RenameColumn(
                name: "ModelCode",
                table: "Trims",
                newName: "ModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Trims_ModelCode",
                table: "Trims",
                newName: "IX_Trims_ModelId");

            migrationBuilder.RenameColumn(
                name: "BrandCode",
                table: "Models",
                newName: "BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_Models_BrandCode",
                table: "Models",
                newName: "IX_Models_BrandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trims",
                table: "Trims",
                columns: new[] { "Name", "ModelId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Brands_BrandId",
                table: "Models",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trims_Models_ModelId",
                table: "Trims",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
