using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tp3_serveur.Migrations
{
    public partial class changePhotoModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bcdde23-321e-48ef-9b30-56bfedf1d266", "AQAAAAEAACcQAAAAEHBXcdK0A/nQEzQFwpRDiJQ5kG44oXVsilkprJC5X560Aj+J2y9d68MGvdhwvZQoEg==", "0dd41f13-0765-4980-8edd-55a480dfc540" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b61c3b29-a0af-4c68-8b0c-0bf4eb17c233", "AQAAAAEAACcQAAAAEKo1w8sqRt/7nbiskcdV1rMc3By7g9hWck/XsdBlAwl/3gLA//Fa4zz5iq1GvduCUA==", "218d95c8-26b7-462f-a397-ad366a2501d9" });
        }
    }
}
