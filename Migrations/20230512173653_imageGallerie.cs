using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tp3_serveur.Migrations
{
    public partial class imageGallerie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Gallery",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MimeType",
                table: "Gallery",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26b2f29a-f32d-4440-9698-e8854632dcfa", "AQAAAAEAACcQAAAAEEC63uU9VF4lE0WW8K2qdsg3+HmIRy4OjfzwgTsccPLqDsnK7MYTvi3PkAuWFqJKDg==", "5a2914f7-ee1e-4fba-83ea-1a5bb5e1f767" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Gallery");

            migrationBuilder.DropColumn(
                name: "MimeType",
                table: "Gallery");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bcdde23-321e-48ef-9b30-56bfedf1d266", "AQAAAAEAACcQAAAAEHBXcdK0A/nQEzQFwpRDiJQ5kG44oXVsilkprJC5X560Aj+J2y9d68MGvdhwvZQoEg==", "0dd41f13-0765-4980-8edd-55a480dfc540" });
        }
    }
}
