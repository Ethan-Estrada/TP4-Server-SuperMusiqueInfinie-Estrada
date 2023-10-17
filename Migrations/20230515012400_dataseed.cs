using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tp3_serveur.Migrations
{
    public partial class dataseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5fe90b0-e34a-4832-b672-1c96534619b6", "AQAAAAEAACcQAAAAEE0uP7roIwKqVj0jewQyakUt43yOU7HXgunvbxWE+pKRdx67fbC03n7+ZyUi6BU7kw==", "17254603-034a-4228-8141-2c10098597f6" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FileName", "MimeType" },
                values: new object[] { "11111111-1111-1111-1111-111111111111.jpg", "image/jpg" });

            migrationBuilder.InsertData(
                table: "Gallery",
                columns: new[] { "Id", "FileName", "MimeType", "Name", "UserId" },
                values: new object[] { 4, "11111111-1111-1111-1111-111111111111.jpg", "image/jpg", "Galerie numero deux22", "11111111-1111-1111-1111-111111111111" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "b84c5574-5678-4c61-aaca-46039b516d3c", "AQAAAAEAACcQAAAAENrSKC0yLDWs0HYC0BOhr2tr1uRQAW7BptNf6kNJTrVVuzDo8B40ZFhcsqhp7mXnJQ==", "0ed15296-46a7-460b-8672-528ecd2e1009" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FileName", "MimeType" },
                values: new object[] { null, null });
        }
    }
}
