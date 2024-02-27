using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpticonBackend.Migrations
{
    /// <inheritdoc />
    public partial class produnit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Components_ComponentTypes_ComponentTypeName",
                table: "Components");

            migrationBuilder.AlterColumn<string>(
                name: "ComponentTypeName",
                table: "Components",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_Components_ComponentTypes_ComponentTypeName",
                table: "Components",
                column: "ComponentTypeName",
                principalTable: "ComponentTypes",
                principalColumn: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Components_ComponentTypes_ComponentTypeName",
                table: "Components");

            migrationBuilder.AlterColumn<string>(
                name: "ComponentTypeName",
                table: "Components",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Components_ComponentTypes_ComponentTypeName",
                table: "Components",
                column: "ComponentTypeName",
                principalTable: "ComponentTypes",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
