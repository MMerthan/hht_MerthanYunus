using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakineData.Migrations
{
    public partial class mig_13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "16EA936C-7A28-4C30-86A2-9A9704B6115E", "fd8081d7-693a-409b-a778-d2def8cb00bf", "AppRole", "Superadmin", "SUPERADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "7CB750CF-3612-4FB4-9F7D-A38BA8F16BF4", "25243f04-4a9a-46aa-a0ed-f8d1bf9d6d37", "AppRole", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "EDF6C246-41D8-475F-8D92-41DDDAC3AEFB", "493fd716-8812-4c24-8d34-7fe602afbb48", "AppRole", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16EA936C-7A28-4C30-86A2-9A9704B6115E");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7CB750CF-3612-4FB4-9F7D-A38BA8F16BF4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EDF6C246-41D8-475F-8D92-41DDDAC3AEFB");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetRoles");
        }
    }
}
