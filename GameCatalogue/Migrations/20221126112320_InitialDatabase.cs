using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameCatalogue.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "game",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_game", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tag",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameTag",
                columns: table => new
                {
                    GamesId = table.Column<string>(type: "text", nullable: false),
                    TagsId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameTag", x => new { x.GamesId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_GameTag_game_GamesId",
                        column: x => x.GamesId,
                        principalTable: "game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameTag_tag_TagsId",
                        column: x => x.TagsId,
                        principalTable: "tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameUser",
                columns: table => new
                {
                    LikedById = table.Column<string>(type: "text", nullable: false),
                    LikedGamesId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameUser", x => new { x.LikedById, x.LikedGamesId });
                    table.ForeignKey(
                        name: "FK_GameUser_game_LikedGamesId",
                        column: x => x.LikedGamesId,
                        principalTable: "game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameUser_user_LikedById",
                        column: x => x.LikedById,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "review",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    RatingScore = table.Column<int>(type: "integer", nullable: false),
                    GameId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_review_game_GameId",
                        column: x => x.GameId,
                        principalTable: "game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_review_user_UserId",
                        column: x => x.UserId,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameTag_TagsId",
                table: "GameTag",
                column: "TagsId");

            migrationBuilder.CreateIndex(
                name: "IX_GameUser_LikedGamesId",
                table: "GameUser",
                column: "LikedGamesId");

            migrationBuilder.CreateIndex(
                name: "IX_review_GameId",
                table: "review",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_review_UserId",
                table: "review",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameTag");

            migrationBuilder.DropTable(
                name: "GameUser");

            migrationBuilder.DropTable(
                name: "review");

            migrationBuilder.DropTable(
                name: "tag");

            migrationBuilder.DropTable(
                name: "game");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
