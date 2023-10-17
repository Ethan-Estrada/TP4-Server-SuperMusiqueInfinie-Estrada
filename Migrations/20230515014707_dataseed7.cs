using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tp3_serveur.Migrations
{
    public partial class dataseed7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "0e7384b3-cc02-4503-a9cd-745ec914368a", "AQAAAAEAACcQAAAAEMoB7LqCnp4v+0w4TpiP8nVKolubphqGfrqqNuqte4pKUByXP7Kh2iitJTt+I+wVRg==", "6ae841d7-f97b-47bd-ac3c-dcd22f69fe19" });

            migrationBuilder.InsertData(
                table: "Gallery",
                columns: new[] { "Id", "FileName", "MimeType", "Name", "UserId" },
                values: new object[] { 51, null, null, "Galerie numero 51", "11111111-1111-1111-1111-111111111111" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 51);

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
    }
}
