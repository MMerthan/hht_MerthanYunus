using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakineData.Migrations
{
    public partial class Seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16EA936C-7A28-4C30-86A2-9A9704B6115E",
                column: "ConcurrencyStamp",
                value: "fe4c909b-35d8-4eee-906b-813cbaefc907");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7CB750CF-3612-4FB4-9F7D-A38BA8F16BF4",
                column: "ConcurrencyStamp",
                value: "0522670a-a7eb-457b-bc68-9d5d29dd7348");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EDF6C246-41D8-475F-8D92-41DDDAC3AEFB",
                column: "ConcurrencyStamp",
                value: "2496d3ff-5734-4359-80b4-bae91f409bb8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3AA42229-1C0F-4630-8C1A-DB879ECD0427",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9082f98-5270-4666-a988-87d8acf0a05b", "AQAAAAEAACcQAAAAEDW+yybBEMwi4Ff50YtUhEPC23a6xpr3RgOMov1oBkGRoIyxdS36ERK1IT2k+g5Nrg==", "66b07b78-1738-4a5b-a43b-2bf518b7c1c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CB94223B-CCB8-4F2F-93D7-0DF96A7F065C",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f21bdf5-c051-458f-8c01-4e26e49cb962", "AQAAAAEAACcQAAAAEG7ASgYZ25RZVQI46eDQR6ELn00KdBx8NzliWuux5W/S069+gYZJRVP7YVnFRdiSOg==", "bd3d9426-6f2a-4ea5-99ab-658dbbbd345e" });
        }
    }
}
