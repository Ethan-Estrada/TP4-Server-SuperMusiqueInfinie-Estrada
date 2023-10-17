using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tp3_serveur.Migrations
{
    public partial class dataseed3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "093be6e0-3105-40ed-ae0d-2838e522017c", "AQAAAAEAACcQAAAAEFxD8br3/SVfMrfvSnOz1XXXDAkRT58gAntGF+SIvIFgru0fOc+6dvFR5+SBPAL7Aw==", "06869aa7-9855-42b9-a4ee-f53b096e1e50" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e4dd756-bbf7-4d0a-9692-4360e8fdf4d1", "AQAAAAEAACcQAAAAEGKhnL2/L6vWjOETdXwI7Xk0rsl3xwnxwYCEQoSuxkUb00cIvurldCcl+hrP9jc0gQ==", "7b2da2f2-5b72-4e28-bd13-b9a38d34d71c" });
        }
    }
}
