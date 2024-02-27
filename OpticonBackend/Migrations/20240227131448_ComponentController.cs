using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpticonBackend.Migrations
{
    /// <inheritdoc />
    public partial class ComponentController : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComponentEnergyFlow");

            migrationBuilder.DropTable(
                name: "ComponentRelation");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
