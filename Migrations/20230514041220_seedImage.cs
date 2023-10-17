using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tp3_serveur.Migrations
{
    public partial class seedImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b84c5574-5678-4c61-aaca-46039b516d3c", "AQAAAAEAACcQAAAAENrSKC0yLDWs0HYC0BOhr2tr1uRQAW7BptNf6kNJTrVVuzDo8B40ZFhcsqhp7mXnJQ==", "0ed15296-46a7-460b-8672-528ecd2e1009" });

            migrationBuilder.InsertData(
                table: "Gallery",
                columns: new[] { "Id", "FileName", "MimeType", "Name", "UserId" },
                values: new object[] { 2, null, null, "Galerie numero deux", "11111111-1111-1111-1111-111111111111" });

            migrationBuilder.InsertData(
                table: "Photo",
                columns: new[] { "Id", "FileName", "GalleryId", "MimeType" },
                values: new object[] { 1, "11111111-1111-1111-1111-111111111111.jpg", null, "image/jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26b2f29a-f32d-4440-9698-e8854632dcfa", "AQAAAAEAACcQAAAAEEC63uU9VF4lE0WW8K2qdsg3+HmIRy4OjfzwgTsccPLqDsnK7MYTvi3PkAuWFqJKDg==", "5a2914f7-ee1e-4fba-83ea-1a5bb5e1f767" });
        }
    }
}
