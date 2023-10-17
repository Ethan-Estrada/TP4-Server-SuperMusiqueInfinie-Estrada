using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tp3_serveur.Migrations
{
    public partial class dataseed8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "abc5627e-1cbd-4979-b85b-41037b737fa4", "AQAAAAEAACcQAAAAEEOFiQfcnRBv3fp0ZnPt2J28OzbI43RwNubVOTGjb01CjR4dCboPN83kkPBVlj2MCg==", "4afa2c81-6010-470a-a3ba-9a8d13dc5cc0" });

            migrationBuilder.InsertData(
                table: "Gallery",
                columns: new[] { "Id", "FileName", "MimeType", "Name", "UserId" },
                values: new object[] { 52, "11111111-1111-1111-1111-111111111111.jpg", "image/jpg", "Galerie numero 52", "11111111-1111-1111-1111-111111111111" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 52);

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
    }
}
