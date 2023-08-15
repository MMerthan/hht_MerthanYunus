using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakineData.Migrations
{
    public partial class mig_20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoutineMaintenancesDetails_RoutineMaintenances_RoutineMaintenanceId",
                table: "RoutineMaintenancesDetails");

            migrationBuilder.DropIndex(
                name: "IX_RoutineMaintenancesDetails_RoutineMaintenanceId",
                table: "RoutineMaintenancesDetails");

            migrationBuilder.DropColumn(
                name: "RoutineMaintenanceId",
                table: "RoutineMaintenancesDetails");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "RoutineMaintenanceDetailId",
                table: "RoutineMaintenances",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoutineMaintenanceDetailsId",
                table: "RoutineMaintenances",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_RoutineMaintenances_RoutineMaintenanceDetailId",
                table: "RoutineMaintenances",
                column: "RoutineMaintenanceDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoutineMaintenances_RoutineMaintenances_RoutineMaintenanceDetailId",
                table: "RoutineMaintenances",
                column: "RoutineMaintenanceDetailId",
                principalTable: "RoutineMaintenances",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoutineMaintenances_RoutineMaintenances_RoutineMaintenanceDetailId",
                table: "RoutineMaintenances");

            migrationBuilder.DropIndex(
                name: "IX_RoutineMaintenances_RoutineMaintenanceDetailId",
                table: "RoutineMaintenances");

            migrationBuilder.DropColumn(
                name: "RoutineMaintenanceDetailId",
                table: "RoutineMaintenances");

            migrationBuilder.DropColumn(
                name: "RoutineMaintenanceDetailsId",
                table: "RoutineMaintenances");

            migrationBuilder.AddColumn<int>(
                name: "RoutineMaintenanceId",
                table: "RoutineMaintenancesDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_RoutineMaintenancesDetails_RoutineMaintenanceId",
                table: "RoutineMaintenancesDetails",
                column: "RoutineMaintenanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoutineMaintenancesDetails_RoutineMaintenances_RoutineMaintenanceId",
                table: "RoutineMaintenancesDetails",
                column: "RoutineMaintenanceId",
                principalTable: "RoutineMaintenances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
