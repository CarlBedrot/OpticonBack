using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpticonBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddProductionUnitAndComponent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Pictures",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.CreateTable(
                name: "ComponentTypes",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    BasedOn = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentTypes", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "PictureAccesses",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    PictureId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PictureAccesses", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Components",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    MeasurementUnit = table.Column<string>(type: "TEXT", nullable: false),
                    ComponentTypeName = table.Column<string>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 21, nullable: false),
                    StartType = table.Column<string>(type: "TEXT", nullable: true),
                    AuxiliaryPowerAbs = table.Column<int>(type: "INTEGER", nullable: true),
                    AuxiliaryPowerRel = table.Column<int>(type: "INTEGER", nullable: true),
                    AuxiliaryPowerForm = table.Column<string>(type: "TEXT", nullable: true),
                    MaxLoadChangeSpeed = table.Column<int>(type: "INTEGER", nullable: true),
                    PreparationTimeHeat = table.Column<double>(type: "REAL", nullable: true),
                    PreparationTimeWarm = table.Column<double>(type: "REAL", nullable: true),
                    PreparationTimeCold = table.Column<double>(type: "REAL", nullable: true),
                    CoolingTimeHeat = table.Column<double>(type: "REAL", nullable: true),
                    CoolingTimeWarm = table.Column<double>(type: "REAL", nullable: true),
                    MeasurePoint = table.Column<string>(type: "TEXT", nullable: true),
                    StartRamp = table.Column<bool>(type: "INTEGER", nullable: true),
                    HeatStartRamp = table.Column<string>(type: "TEXT", nullable: true),
                    ColdStartRamp = table.Column<string>(type: "TEXT", nullable: true),
                    LoadInterval = table.Column<double>(type: "REAL", nullable: true),
                    Performance = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Components", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Components_ComponentTypes_ComponentTypeName",
                        column: x => x.ComponentTypeName,
                        principalTable: "ComponentTypes",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PicturePictureAccess",
                columns: table => new
                {
                    PictureAccessesUserId = table.Column<string>(type: "TEXT", nullable: false),
                    PicturesId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PicturePictureAccess", x => new { x.PictureAccessesUserId, x.PicturesId });
                    table.ForeignKey(
                        name: "FK_PicturePictureAccess_PictureAccesses_PictureAccessesUserId",
                        column: x => x.PictureAccessesUserId,
                        principalTable: "PictureAccesses",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PicturePictureAccess_Pictures_PicturesId",
                        column: x => x.PicturesId,
                        principalTable: "Pictures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComponentEnergyFlow",
                columns: table => new
                {
                    ComponentId = table.Column<int>(type: "INTEGER", nullable: false),
                    EnergyFlowId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentEnergyFlow", x => new { x.ComponentId, x.EnergyFlowId });
                    table.ForeignKey(
                        name: "FK_ComponentEnergyFlow_Components_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComponentEnergyFlow_Components_EnergyFlowId",
                        column: x => x.EnergyFlowId,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComponentRelation",
                columns: table => new
                {
                    ComponentId = table.Column<int>(type: "INTEGER", nullable: false),
                    RelatedComponentId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentRelation", x => new { x.ComponentId, x.RelatedComponentId });
                    table.ForeignKey(
                        name: "FK_ComponentRelation_Components_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComponentRelation_Components_RelatedComponentId",
                        column: x => x.RelatedComponentId,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComponentEnergyFlow_EnergyFlowId",
                table: "ComponentEnergyFlow",
                column: "EnergyFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_ComponentRelation_RelatedComponentId",
                table: "ComponentRelation",
                column: "RelatedComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_Components_ComponentTypeName",
                table: "Components",
                column: "ComponentTypeName");

            migrationBuilder.CreateIndex(
                name: "IX_PicturePictureAccess_PicturesId",
                table: "PicturePictureAccess",
                column: "PicturesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComponentEnergyFlow");

            migrationBuilder.DropTable(
                name: "ComponentRelation");

            migrationBuilder.DropTable(
                name: "PicturePictureAccess");

            migrationBuilder.DropTable(
                name: "Components");

            migrationBuilder.DropTable(
                name: "PictureAccesses");

            migrationBuilder.DropTable(
                name: "ComponentTypes");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Pictures",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);
        }
    }
}
