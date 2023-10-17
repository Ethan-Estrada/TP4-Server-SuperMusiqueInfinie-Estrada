using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tp3_serveur.Migrations
{
    public partial class dataseed9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "e5bf1d3f-23fa-442b-b87c-8b01b0890242", "AQAAAAEAACcQAAAAEI1Xs5d6N1OAbqghDti5GsnbaLb+93rFjkV2qPvKxmmF/gpLIRfDUkcnBObJA9hNVA==", "4df748f5-6764-4edc-9ef8-c61761fe31a8" });

            migrationBuilder.InsertData(
                table: "Gallery",
                columns: new[] { "Id", "FileName", "MimeType", "Name", "UserId" },
                values: new object[] { 53, "11111111-1111-1111-1111-111111111111.jpg", "image/jpg", "Galerie numero 53", "11111111-1111-1111-1111-111111111111" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 53);

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
    }
}
