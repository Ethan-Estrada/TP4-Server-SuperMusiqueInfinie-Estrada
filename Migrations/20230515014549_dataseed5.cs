using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tp3_serveur.Migrations
{
    public partial class dataseed5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74d944a4-4942-47d7-ade4-56c24182e93e", "AQAAAAEAACcQAAAAEOkOg4MWfq0f7eUvbuuzpxIOO8+ekhfIh3iLhY7j1eN0YWNmabmL4xiZ4gtO2/JtiQ==", "d14dfd6c-d575-4c7d-8a3e-7444e714ab0b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd39d37a-f3bd-47e7-9a86-1e6bbacf17eb", "AQAAAAEAACcQAAAAEHBeFAL25/FC+9fOWVHDhYixy5QsBArSnEHQV1ntbh6ELFfxLx3XSr6MIE7j35uITw==", "4c4cddb2-42c6-4134-ba4a-2c118f3c24a8" });
        }
    }
}
