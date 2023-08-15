using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakineData.Migrations
{
    public partial class mig_19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssetPartId",
                table: "WorkOrders");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16EA936C-7A28-4C30-86A2-9A9704B6115E",
                column: "ConcurrencyStamp",
                value: "e7c1812a-9055-4a06-a9bc-55f945a26d66");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7CB750CF-3612-4FB4-9F7D-A38BA8F16BF4",
                column: "ConcurrencyStamp",
                value: "b480dd9b-7677-4049-9573-40714da097c9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EDF6C246-41D8-475F-8D92-41DDDAC3AEFB",
                column: "ConcurrencyStamp",
                value: "6515e0d6-d31a-4d9f-be5c-168eb3feac8a");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssetPartId",
                table: "WorkOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16EA936C-7A28-4C30-86A2-9A9704B6115E",
                column: "ConcurrencyStamp",
                value: "938a58fc-3311-40e1-b501-b935aa40c65e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7CB750CF-3612-4FB4-9F7D-A38BA8F16BF4",
                column: "ConcurrencyStamp",
                value: "19bd65ad-af49-480c-9f8c-e03b1d4a0b41");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EDF6C246-41D8-475F-8D92-41DDDAC3AEFB",
                column: "ConcurrencyStamp",
                value: "3ffc4421-a934-45e3-8d2d-15c7e053323b");
        }
    }
}
