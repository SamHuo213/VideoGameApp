using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoGameApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Video_Game",
                columns: table => new
                {
                    Rating = table.Column<int>(type: "int", maxLength: 1000, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Difficulty = table.Column<int>(type: "int", nullable: false),
                    Rating1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video_Game", x => x.Rating);
                });

            migrationBuilder.InsertData(
                table: "Video_Game",
                columns: new[] { "Rating", "Difficulty", "Genre", "Name", "Rating1" },
                values: new object[,]
                {
                    { 1, 5, "Real-time", "Starcraft BroodWar", 5 },
                    { 2, 3, "Real-time", "Starcraft 2", 5 },
                    { 3, 2, "MOBA", "League Of Legends", 5 },
                    { 4, 5, "MOBA", "Dota", 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Video_Game");
        }
    }
}
