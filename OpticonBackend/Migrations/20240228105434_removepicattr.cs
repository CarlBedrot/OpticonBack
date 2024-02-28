using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpticonBackend.Migrations
{
    /// <inheritdoc />
    public partial class removepicattr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureData",
                table: "Pictures");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PictureData",
                table: "Pictures",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
