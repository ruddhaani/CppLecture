using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayerRelationships.Migrations
{
    /// <inheritdoc />
    public partial class initialization3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clans",
                columns: table => new
                {
                    ClanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClanName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clans", x => x.ClanId);
                });

            migrationBuilder.CreateTable(
                name: "Clans_Player_Bridge",
                columns: table => new
                {
                    ClansClanId = table.Column<int>(type: "int", nullable: false),
                    PlayersPlayerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClansPlayer", x => new { x.ClansClanId, x.PlayersPlayerId });
                    table.ForeignKey(
                        name: "FK_ClansPlayer_Clans_ClansClanId",
                        column: x => x.ClansClanId,
                        principalTable: "Clans",
                        principalColumn: "ClanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClansPlayer_Players_PlayersPlayerId",
                        column: x => x.PlayersPlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClansPlayer_PlayersPlayerId",
                table: "ClansPlayer",
                column: "PlayersPlayerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClansPlayer");

            migrationBuilder.DropTable(
                name: "Clans");
        }
    }
}
