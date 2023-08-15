using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakineData.Migrations
{
    public partial class mig_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16EA936C-7A28-4C30-86A2-9A9704B6115E",
                column: "ConcurrencyStamp",
                value: "819a45aa-2dc8-4b67-9b9e-f7f0b5904315");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7CB750CF-3612-4FB4-9F7D-A38BA8F16BF4",
                column: "ConcurrencyStamp",
                value: "4bb63497-692b-41ac-96e5-2840e02fe960");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EDF6C246-41D8-475F-8D92-41DDDAC3AEFB",
                column: "ConcurrencyStamp",
                value: "21fe9bb6-c067-415a-a33d-02d1ca2e0c99");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3AA42229-1C0F-4630-8C1A-DB879ECD0427",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64dc1a9b-5d67-476e-a7d8-34cdd6cfbeed", "AQAAAAEAACcQAAAAELT+F8FC68b+oCiGzKrGHLMPOljtXYqODMALTV6F2PO1jyy2zFvZxhEIE33O6nzl7g==", "252e05f8-8962-4a6d-9200-a5665774d992" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CB94223B-CCB8-4F2F-93D7-0DF96A7F065C",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61038214-36a2-479e-a2dd-cb0258a30c03", "AQAAAAEAACcQAAAAEK0MgRNQtYOcqOW9ba8e6OdfydEiKiF7cpd53uJ5OSYZ/OnwZf6msP767KoRpQ+nKg==", "b8b33f42-1b15-4971-8101-c39e9b4deea7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16EA936C-7A28-4C30-86A2-9A9704B6115E",
                column: "ConcurrencyStamp",
                value: "4eaedaf2-84b3-45ad-aa17-16ff894d449c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7CB750CF-3612-4FB4-9F7D-A38BA8F16BF4",
                column: "ConcurrencyStamp",
                value: "a8a15828-1bdc-43d2-92aa-cdb502e662f6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EDF6C246-41D8-475F-8D92-41DDDAC3AEFB",
                column: "ConcurrencyStamp",
                value: "d1fcca57-05c7-4e82-a945-c92831462d42");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3AA42229-1C0F-4630-8C1A-DB879ECD0427",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bc984dc-ac5a-4563-80f2-071e71928d01", "AQAAAAEAACcQAAAAEHRCrNEF47nL5pK3mq4EIZMiTxdJc2kkktqrM0Cs3+0CqfMraA+tyAQgqTyvjj7qIw==", "14cb5652-73e7-49f9-bdd5-0e1e6618155f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CB94223B-CCB8-4F2F-93D7-0DF96A7F065C",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d3142a2-cd44-49d6-bd8e-a734d0340515", "AQAAAAEAACcQAAAAECNvTttew5OtVkWltHfrEooupR6Xg8xSujcDlclmubkhqBYaELGA+SHtPcJ4lAEiDg==", "98a4ce14-7176-407a-bc1c-36886384c7c7" });
        }
    }
}
