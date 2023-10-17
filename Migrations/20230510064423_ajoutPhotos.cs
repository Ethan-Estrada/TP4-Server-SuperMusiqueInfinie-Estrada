using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tp3_serveur.Migrations
{
    public partial class ajoutPhotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MimeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GalleryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photo_Gallery_GalleryId",
                        column: x => x.GalleryId,
                        principalTable: "Gallery",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75e52930-b140-4be8-93c7-fb762d71b779", "AQAAAAEAACcQAAAAEE3PVdyj7yVYKDNbEIlFLrIdxGfxWW4ZJczbDeFgBdsdC/mEfFJ4ZxGVqLfHIhcJAw==", "3e360555-a2e5-46d3-8982-ce6311abb44c" });

            migrationBuilder.CreateIndex(
                name: "IX_Photo_GalleryId",
                table: "Photo",
                column: "GalleryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "038b093d-5d8c-45bf-bcb8-f0d9241c1456", "AQAAAAEAACcQAAAAEKWEdzZ+sUTzn4nheoWrlhSoTOEsAi1+cHZoyfKWBm5yeDLB0f8ZCnl12XoZqo7nuA==", "cf5526dc-5f95-457d-9255-af55b6b7ec7e" });
        }
    }
}
