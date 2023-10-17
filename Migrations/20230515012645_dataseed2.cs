using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tp3_serveur.Migrations
{
    public partial class dataseed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e4dd756-bbf7-4d0a-9692-4360e8fdf4d1", "AQAAAAEAACcQAAAAEGKhnL2/L6vWjOETdXwI7Xk0rsl3xwnxwYCEQoSuxkUb00cIvurldCcl+hrP9jc0gQ==", "7b2da2f2-5b72-4e28-bd13-b9a38d34d71c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5fe90b0-e34a-4832-b672-1c96534619b6", "AQAAAAEAACcQAAAAEE0uP7roIwKqVj0jewQyakUt43yOU7HXgunvbxWE+pKRdx67fbC03n7+ZyUi6BU7kw==", "17254603-034a-4228-8141-2c10098597f6" });
        }
    }
}
