using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tp3_serveur.Migrations
{
    public partial class dataseed4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd39d37a-f3bd-47e7-9a86-1e6bbacf17eb", "AQAAAAEAACcQAAAAEHBeFAL25/FC+9fOWVHDhYixy5QsBArSnEHQV1ntbh6ELFfxLx3XSr6MIE7j35uITw==", "4c4cddb2-42c6-4134-ba4a-2c118f3c24a8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "093be6e0-3105-40ed-ae0d-2838e522017c", "AQAAAAEAACcQAAAAEFxD8br3/SVfMrfvSnOz1XXXDAkRT58gAntGF+SIvIFgru0fOc+6dvFR5+SBPAL7Aw==", "06869aa7-9855-42b9-a4ee-f53b096e1e50" });

            migrationBuilder.InsertData(
                table: "Gallery",
                columns: new[] { "Id", "FileName", "MimeType", "Name", "UserId" },
                values: new object[] { 4, "11111111-1111-1111-1111-111111111111.jpg", "image/jpg", "Galerie numero deux22", "11111111-1111-1111-1111-111111111111" });
        }
    }
}
