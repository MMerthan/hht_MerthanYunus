using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakineData.Migrations
{
    public partial class mig_7 : Migration
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
                values: new object[] { "16EA936C-7A28-4C30-86A2-9A9704B6115E", "4d8176f7-8de5-4be2-af72-8b2b9e8041bc", "AppRole", "Superadmin", "SUPERADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "7CB750CF-3612-4FB4-9F7D-A38BA8F16BF4", "21f81320-2923-4681-a976-4b35ca42e39d", "AppRole", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "EDF6C246-41D8-475F-8D92-41DDDAC3AEFB", "68585fa8-fbe1-408a-818b-d0459f9e3e6f", "AppRole", "User", "USER" });
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
