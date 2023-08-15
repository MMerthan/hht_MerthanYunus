using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakineData.Migrations
{
    public partial class mig_21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoutineMaintenances_RoutineMaintenances_RoutineMaintenanceDetailId",
                table: "RoutineMaintenances");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16EA936C-7A28-4C30-86A2-9A9704B6115E",
                column: "ConcurrencyStamp",
                value: "36fe7bc8-3e93-4f9c-9bc7-d606ed534a5e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7CB750CF-3612-4FB4-9F7D-A38BA8F16BF4",
                column: "ConcurrencyStamp",
                value: "29face5c-a1b1-4ec9-b47a-ef56b912dcfb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EDF6C246-41D8-475F-8D92-41DDDAC3AEFB",
                column: "ConcurrencyStamp",
                value: "bae3a96c-56e0-4807-8b8c-7cb8afc881b2");

            migrationBuilder.AddForeignKey(
                name: "FK_RoutineMaintenances_RoutineMaintenancesDetails_RoutineMaintenanceDetailId",
                table: "RoutineMaintenances",
                column: "RoutineMaintenanceDetailId",
                principalTable: "RoutineMaintenancesDetails",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoutineMaintenances_RoutineMaintenancesDetails_RoutineMaintenanceDetailId",
                table: "RoutineMaintenances");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16EA936C-7A28-4C30-86A2-9A9704B6115E",
                column: "ConcurrencyStamp",
                value: "aba15323-bb34-4688-83a6-1e7b988d42b7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7CB750CF-3612-4FB4-9F7D-A38BA8F16BF4",
                column: "ConcurrencyStamp",
                value: "b89fd853-b43d-4f00-923b-b1b5f522ad14");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EDF6C246-41D8-475F-8D92-41DDDAC3AEFB",
                column: "ConcurrencyStamp",
                value: "5733daf7-ce86-417f-873e-86b5da6f08cf");

            migrationBuilder.AddForeignKey(
                name: "FK_RoutineMaintenances_RoutineMaintenances_RoutineMaintenanceDetailId",
                table: "RoutineMaintenances",
                column: "RoutineMaintenanceDetailId",
                principalTable: "RoutineMaintenances",
                principalColumn: "Id");
        }
    }
}
