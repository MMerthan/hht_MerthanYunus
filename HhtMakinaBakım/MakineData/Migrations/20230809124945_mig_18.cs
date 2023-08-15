using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakineData.Migrations
{
    public partial class mig_18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkOrders_AssetParts_AssetPartId",
                table: "WorkOrders");

            migrationBuilder.DropTable(
                name: "AssetParts");

            migrationBuilder.DropIndex(
                name: "IX_WorkOrders_AssetPartId",
                table: "WorkOrders");

            migrationBuilder.DropColumn(
                name: "AssetPartId",
                table: "Assets");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssetPartId",
                table: "Assets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AssetParts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetParts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssetParts_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16EA936C-7A28-4C30-86A2-9A9704B6115E",
                column: "ConcurrencyStamp",
                value: "c611ee9b-fae2-40c2-9887-d7d930afc5ea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7CB750CF-3612-4FB4-9F7D-A38BA8F16BF4",
                column: "ConcurrencyStamp",
                value: "826dc386-0841-4a66-842f-bc71a8fcd088");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EDF6C246-41D8-475F-8D92-41DDDAC3AEFB",
                column: "ConcurrencyStamp",
                value: "ded00910-a0f2-4ca4-a11d-3582d358264f");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_AssetPartId",
                table: "WorkOrders",
                column: "AssetPartId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetParts_AssetId",
                table: "AssetParts",
                column: "AssetId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkOrders_AssetParts_AssetPartId",
                table: "WorkOrders",
                column: "AssetPartId",
                principalTable: "AssetParts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
