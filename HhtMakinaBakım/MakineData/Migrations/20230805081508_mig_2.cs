using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakineData.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssetId",
                table: "AssetCategories");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssetId",
                table: "AssetCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16EA936C-7A28-4C30-86A2-9A9704B6115E",
                column: "ConcurrencyStamp",
                value: "06ade495-35d6-4e31-9750-3ddf045dfc33");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7CB750CF-3612-4FB4-9F7D-A38BA8F16BF4",
                column: "ConcurrencyStamp",
                value: "b7db93f7-f962-49f1-a8d2-1aa94b0b943c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EDF6C246-41D8-475F-8D92-41DDDAC3AEFB",
                column: "ConcurrencyStamp",
                value: "6f2d8fff-b12b-49bb-8a47-46f120a7d268");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3AA42229-1C0F-4630-8C1A-DB879ECD0427",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cae5f5cf-0336-48f5-8d9a-c2275ee6091d", "AQAAAAEAACcQAAAAEPWyi4pzt0/vY7U9DRPxR84hP8wpY7jmY6wnJoOG/g3M+jUEPMhjhP/c4HNNYYvz8w==", "c1c81642-ebdd-4e06-8a94-14692653d680" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CB94223B-CCB8-4F2F-93D7-0DF96A7F065C",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7e5ab33-5ab5-4c15-86a4-d2d48dd89def", "AQAAAAEAACcQAAAAEHd84v9BsO9wl8+6Xo9xSVXF2GbqwsOHSZhu4bFxaXooifBG1a3QJExN2IcqHoQTeQ==", "d60c3d8f-dd04-46f2-944b-79b010eb058d" });
        }
    }
}
