using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tp3_serveur.Migrations
{
    public partial class modelChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17924af4-2b3d-4ef9-a616-81936c41220f", "AQAAAAEAACcQAAAAEFY8VQmXGXS1XcsunpORqf6+L0SdhjRy28ZnRbFwLQzxJLnwnASTo11/GWnO+LlWcQ==", "1d8ddf8e-2f0c-40de-b34d-b8c5af3dfc3d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75e52930-b140-4be8-93c7-fb762d71b779", "AQAAAAEAACcQAAAAEE3PVdyj7yVYKDNbEIlFLrIdxGfxWW4ZJczbDeFgBdsdC/mEfFJ4ZxGVqLfHIhcJAw==", "3e360555-a2e5-46d3-8982-ce6311abb44c" });
        }
    }
}
