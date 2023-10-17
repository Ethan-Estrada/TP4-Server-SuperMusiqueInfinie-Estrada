using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tp3_serveur.Migrations
{
    public partial class dataseed6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fafa0def-a0b5-4f0d-94a6-e7154ffe1193", "AQAAAAEAACcQAAAAEE/kQ90y7/+QQCaEKaTvMYdVsVOA1BTjr+LiBCUY8ZSKN5rP/AdCgn0gtyFHp9v2hg==", "ae977c22-0217-45eb-900c-a1a52921da81" });

            migrationBuilder.InsertData(
                table: "Gallery",
                columns: new[] { "Id", "FileName", "MimeType", "Name", "UserId" },
                values: new object[] { 50, "11111111-1111-1111-1111-111111111111.jpg", "image/jpg", "Galerie numero 50", "11111111-1111-1111-1111-111111111111" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74d944a4-4942-47d7-ade4-56c24182e93e", "AQAAAAEAACcQAAAAEOkOg4MWfq0f7eUvbuuzpxIOO8+ekhfIh3iLhY7j1eN0YWNmabmL4xiZ4gtO2/JtiQ==", "d14dfd6c-d575-4c7d-8a3e-7444e714ab0b" });
        }
    }
}
