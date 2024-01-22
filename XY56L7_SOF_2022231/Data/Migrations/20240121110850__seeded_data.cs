using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XY56L7_SOF_2022231.Data.Migrations
{
    public partial class _seeded_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "user1", 0, "ee8e58d9-569f-43ab-b215-9b5b00a4139a", "", new byte[] { 1, 2, 3 }, "SiteUser", "user1@example.com", false, "Teszt", "Elek", false, null, null, null, null, null, false, "2445de0c-ce83-4c74-bf20-6ac0d423be40", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "user2", 0, "a12a10b2-8fe3-4d69-91d8-f21df02b01d2", "", new byte[] { 4, 5, 6 }, "SiteUser", "user2@example.com", false, "Teszt", "Elek", false, null, null, null, null, null, false, "e7cb4fbf-7d31-4069-8e2b-5e7164fb325e", false, null });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Uid", "OwnerId", "Title" },
                values: new object[] { "38a510dd-b263-47d6-8e49-75a3d04c6f85", "user1", "Car 1" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Uid", "OwnerId", "Title" },
                values: new object[] { "715361ec-0712-4481-992f-35502f49f5ce", "user2", "Car 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "38a510dd-b263-47d6-8e49-75a3d04c6f85");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "715361ec-0712-4481-992f-35502f49f5ce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2");
        }
    }
}
