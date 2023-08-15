using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakineData.Migrations
{
    public partial class mig_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FileType",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16EA936C-7A28-4C30-86A2-9A9704B6115E",
                column: "ConcurrencyStamp",
                value: "7222eef1-7392-4470-9b0c-7d8ab0f101fd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7CB750CF-3612-4FB4-9F7D-A38BA8F16BF4",
                column: "ConcurrencyStamp",
                value: "5511150a-ea70-4027-b300-11cdf206f23a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EDF6C246-41D8-475F-8D92-41DDDAC3AEFB",
                column: "ConcurrencyStamp",
                value: "90ab8ae0-a09f-4f9f-90d5-a53121ba530b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3AA42229-1C0F-4630-8C1A-DB879ECD0427",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "728d2f84-3fbd-4ed1-9e6b-1da68c4f1b7f", "AQAAAAEAACcQAAAAELfwqKjjNd5TALgY9kJ7naThlD3DDoq05fFFwlAYr4gsmSVCxOrFC8VWIGc+tdgqYw==", "b915ee62-0b80-40d6-a5d3-8074b8aa4dbf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CB94223B-CCB8-4F2F-93D7-0DF96A7F065C",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db2ab05e-759e-4f09-92f7-89953ed8f1c4", "AQAAAAEAACcQAAAAEAhRLzJTvEkW8RaQBYMgvVLBM9X8hvodT5b708n2mAY7OEf4bJoeax6gnSa+WkqgSA==", "d0ec8890-02ae-4b4f-ab93-5dd04712898d" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ImageId",
                table: "AspNetUsers",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Images_ImageId",
                table: "AspNetUsers",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Images_ImageId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ImageId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "FileType",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16EA936C-7A28-4C30-86A2-9A9704B6115E",
                column: "ConcurrencyStamp",
                value: "90b0c793-d5d0-40cb-9836-d3d8b03fdd3a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7CB750CF-3612-4FB4-9F7D-A38BA8F16BF4",
                column: "ConcurrencyStamp",
                value: "7d0f1698-a38d-451b-92fa-9690b0b88870");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EDF6C246-41D8-475F-8D92-41DDDAC3AEFB",
                column: "ConcurrencyStamp",
                value: "c6c5d5d5-06e7-4452-b500-6c778c1cded6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3AA42229-1C0F-4630-8C1A-DB879ECD0427",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5963c29-a518-4d90-a7d4-b10318280955", "AQAAAAEAACcQAAAAEJIKc1DbDj2zQ4glm432VhQPOQdFixMFHKWhCjbt0WVjb3nqMH57Zty+EqiFg2C9HQ==", "075da6b2-b9af-45fb-a950-aa82d3b98717" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CB94223B-CCB8-4F2F-93D7-0DF96A7F065C",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "911e13d9-764c-4ec4-a0ec-67b9404ee53c", "AQAAAAEAACcQAAAAEFB9+JB9efS7heEYGAy/5o4mGcfXRMXOh8I4ver1/nvUZARokyUizzhKi82o4GgPJQ==", "ddaa95d6-240d-4c9c-ab30-994599288b95" });
        }
    }
}
