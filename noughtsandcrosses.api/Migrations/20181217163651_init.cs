using Microsoft.EntityFrameworkCore.Migrations;

namespace noughtsandcrosses.api.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TurnChoice = table.Column<int>(nullable: false),
                    GameLevel = table.Column<int>(nullable: false),
                    BoardDimension = table.Column<int>(nullable: false),
                    IsGameOver = table.Column<bool>(nullable: false),
                    IsGameWon = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
