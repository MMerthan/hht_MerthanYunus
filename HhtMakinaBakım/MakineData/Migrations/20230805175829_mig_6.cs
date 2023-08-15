using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakineData.Migrations
{
    public partial class mig_6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16EA936C-7A28-4C30-86A2-9A9704B6115E");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7CB750CF-3612-4FB4-9F7D-A38BA8F16BF4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EDF6C246-41D8-475F-8D92-41DDDAC3AEFB");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3AA42229-1C0F-4630-8C1A-DB879ECD0427");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CB94223B-CCB8-4F2F-93D7-0DF96A7F065C");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetRoles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "16EA936C-7A28-4C30-86A2-9A9704B6115E", "819a45aa-2dc8-4b67-9b9e-f7f0b5904315", "AppRole", "Superadmin", "SUPERADMIN" },
                    { "7CB750CF-3612-4FB4-9F7D-A38BA8F16BF4", "4bb63497-692b-41ac-96e5-2840e02fe960", "AppRole", "Admin", "ADMIN" },
                    { "EDF6C246-41D8-475F-8D92-41DDDAC3AEFB", "21fe9bb6-c067-415a-a33d-02d1ca2e0c99", "AppRole", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "ImageId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3AA42229-1C0F-4630-8C1A-DB879ECD0427", 0, "64dc1a9b-5d67-476e-a7d8-34cdd6cfbeed", "AppUser", "admin@gmail.com", false, "Admin", 0, "User", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAELT+F8FC68b+oCiGzKrGHLMPOljtXYqODMALTV6F2PO1jyy2zFvZxhEIE33O6nzl7g==", "+905439999988", false, "252e05f8-8962-4a6d-9200-a5665774d992", false, "admin@gmail.com" },
                    { "CB94223B-CCB8-4F2F-93D7-0DF96A7F065C", 0, "61038214-36a2-479e-a2dd-cb0258a30c03", "AppUser", "superadmin@gmail.com", true, "Yunus Emre", 0, "Apak", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEK0MgRNQtYOcqOW9ba8e6OdfydEiKiF7cpd53uJ5OSYZ/OnwZf6msP767KoRpQ+nKg==", "+905439999999", true, "b8b33f42-1b15-4971-8101-c39e9b4deea7", false, "superadmin@gmail.com" }
                });
        }
    }
}
