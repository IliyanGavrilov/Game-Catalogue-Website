using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameCatalogue.Migrations
{
    /// <inheritdoc />
    public partial class removeCS8618 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "AvgRating",
                table: "game",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvgRating",
                table: "game");
        }
    }
}
