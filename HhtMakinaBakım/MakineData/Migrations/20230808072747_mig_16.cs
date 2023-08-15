using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakineData.Migrations
{
    public partial class mig_16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16EA936C-7A28-4C30-86A2-9A9704B6115E",
                column: "ConcurrencyStamp",
                value: "00975c7b-d6b2-4e08-bce6-8e440dcca69d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7CB750CF-3612-4FB4-9F7D-A38BA8F16BF4",
                column: "ConcurrencyStamp",
                value: "942cc2e7-3bff-44e3-9fbd-a9d8425a794c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EDF6C246-41D8-475F-8D92-41DDDAC3AEFB",
                column: "ConcurrencyStamp",
                value: "ca7feb57-a688-4357-9a82-49cbbea88c89");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16EA936C-7A28-4C30-86A2-9A9704B6115E",
                column: "ConcurrencyStamp",
                value: "5f6a6c67-c31a-47b3-ae2d-0359cf57cbb8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7CB750CF-3612-4FB4-9F7D-A38BA8F16BF4",
                column: "ConcurrencyStamp",
                value: "41c20ea9-4cf3-435c-b774-31f2b8f97b84");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EDF6C246-41D8-475F-8D92-41DDDAC3AEFB",
                column: "ConcurrencyStamp",
                value: "0148fb22-ea90-4a3c-9612-7967f0440f00");
        }
    }
}
