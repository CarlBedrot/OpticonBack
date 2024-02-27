using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpticonBackend.Migrations
{
    /// <inheritdoc />
    public partial class yyalla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MeasurementUnit",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Components");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MeasurementUnit",
                table: "Components",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Components",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
