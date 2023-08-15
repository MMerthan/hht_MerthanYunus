using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakineData.Migrations
{
    public partial class mig_15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Images_ImageId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Images_ImageId1",
                table: "Assets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Images",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Assets_ImageId1",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "ImageId1",
                table: "Assets");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "ImageId",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Images",
                table: "Images",
                column: "Id");

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

            migrationBuilder.CreateIndex(
                name: "IX_Assets_ImageId",
                table: "Assets",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Images_ImageId",
                table: "AspNetUsers",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Images_ImageId",
                table: "Assets",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Images_ImageId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Images_ImageId",
                table: "Assets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Images",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Assets_ImageId",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Images");

            migrationBuilder.AddColumn<string>(
                name: "ImageId",
                table: "Images",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageId1",
                table: "Assets",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Images",
                table: "Images",
                column: "ImageId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16EA936C-7A28-4C30-86A2-9A9704B6115E",
                column: "ConcurrencyStamp",
                value: "a12a4491-e0ca-4821-b4a7-0faff28046a5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7CB750CF-3612-4FB4-9F7D-A38BA8F16BF4",
                column: "ConcurrencyStamp",
                value: "63ad9ca2-b886-4e06-ba5e-dda39365c1c0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EDF6C246-41D8-475F-8D92-41DDDAC3AEFB",
                column: "ConcurrencyStamp",
                value: "2a8e26e3-50ee-4d9e-bd6f-5f105bb2230c");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_ImageId1",
                table: "Assets",
                column: "ImageId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Images_ImageId",
                table: "AspNetUsers",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Images_ImageId1",
                table: "Assets",
                column: "ImageId1",
                principalTable: "Images",
                principalColumn: "ImageId");
        }
    }
}
