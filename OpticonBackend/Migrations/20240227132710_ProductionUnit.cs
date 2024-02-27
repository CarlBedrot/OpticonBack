using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpticonBackend.Migrations
{
    /// <inheritdoc />
    public partial class ProductionUnit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuxiliaryPowerForm",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "AuxiliaryPowerRel",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "ColdStartRamp",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "CoolingTimeHeat",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "CoolingTimeWarm",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "HeatStartRamp",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "LoadInterval",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "MaxLoadChangeSpeed",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "MeasurePoint",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "Performance",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "PreparationTimeCold",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "PreparationTimeHeat",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "PreparationTimeWarm",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "StartRamp",
                table: "Components");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuxiliaryPowerForm",
                table: "Components",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuxiliaryPowerRel",
                table: "Components",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ColdStartRamp",
                table: "Components",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CoolingTimeHeat",
                table: "Components",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CoolingTimeWarm",
                table: "Components",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeatStartRamp",
                table: "Components",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "LoadInterval",
                table: "Components",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxLoadChangeSpeed",
                table: "Components",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MeasurePoint",
                table: "Components",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Performance",
                table: "Components",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PreparationTimeCold",
                table: "Components",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PreparationTimeHeat",
                table: "Components",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PreparationTimeWarm",
                table: "Components",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "StartRamp",
                table: "Components",
                type: "INTEGER",
                nullable: true);
        }
    }
}
