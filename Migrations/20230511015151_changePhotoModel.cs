using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tp3_serveur.Migrations
{
    public partial class changePhotoModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Photo");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b61c3b29-a0af-4c68-8b0c-0bf4eb17c233", "AQAAAAEAACcQAAAAEKo1w8sqRt/7nbiskcdV1rMc3By7g9hWck/XsdBlAwl/3gLA//Fa4zz5iq1GvduCUA==", "218d95c8-26b7-462f-a397-ad366a2501d9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Photo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17924af4-2b3d-4ef9-a616-81936c41220f", "AQAAAAEAACcQAAAAEFY8VQmXGXS1XcsunpORqf6+L0SdhjRy28ZnRbFwLQzxJLnwnASTo11/GWnO+LlWcQ==", "1d8ddf8e-2f0c-40de-b34d-b8c5af3dfc3d" });
        }
    }
}
