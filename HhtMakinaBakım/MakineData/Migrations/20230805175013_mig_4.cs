using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakineData.Migrations
{
    public partial class mig_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
