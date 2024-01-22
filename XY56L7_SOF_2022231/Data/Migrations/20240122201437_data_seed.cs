using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XY56L7_SOF_2022231.Data.Migrations
{
    public partial class data_seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "54ed7c9c-e7d2-471e-94ab-f0ec4fb15277");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "af957ba3-96a4-4a84-8954-4f91056f21ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "40b49bef-df2b-4a05-9602-a58ef0c55b00", 0, "d3a056ca-fc48-4c8a-8f05-b0b4f66ad852", "", new byte[] { 4, 5, 6 }, "SiteUser", "user2@example.com", false, "Teszt", "Elek", false, null, null, null, null, null, false, "d9cc3d41-5ae4-4dea-adab-840c3a1f167c", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f97fc284-4690-441a-882d-c655e9c512d8", 0, "a6b07725-fe74-41ad-aaae-03cb3150971c", "", new byte[] { 1, 2, 3 }, "SiteUser", "user1@example.com", false, "Teszt", "Elek", false, null, null, null, null, null, false, "f807e1f4-c873-4a63-bad7-a99664ec0446", false, null });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Uid", "OwnerId", "Title" },
                values: new object[] { "0f9f5fbe-ecf3-47f2-9c2f-2df5daeb79e5", "40b49bef-df2b-4a05-9602-a58ef0c55b00", "Car 1" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Uid", "OwnerId", "Title" },
                values: new object[] { "3f18de21-eb5f-4971-80a2-3737c631c69a", "f97fc284-4690-441a-882d-c655e9c512d8", "Car 1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "0f9f5fbe-ecf3-47f2-9c2f-2df5daeb79e5");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "3f18de21-eb5f-4971-80a2-3737c631c69a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40b49bef-df2b-4a05-9602-a58ef0c55b00");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f97fc284-4690-441a-882d-c655e9c512d8");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "user1", 0, "1023bc4e-f1bb-4895-81d9-3ae23738bf68", "", new byte[] { 1, 2, 3 }, "SiteUser", "user1@example.com", false, "Teszt", "Elek", false, null, null, null, null, null, false, "9e748a05-eaf0-4b81-978a-3bb1b1235ba3", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "user2", 0, "2d9e744a-9f36-4aab-906e-c2303fdb5497", "", new byte[] { 4, 5, 6 }, "SiteUser", "user2@example.com", false, "Teszt", "Elek", false, null, null, null, null, null, false, "ce1f84e8-f161-4b9e-ad48-1337b91b853e", false, null });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Uid", "OwnerId", "Title" },
                values: new object[] { "54ed7c9c-e7d2-471e-94ab-f0ec4fb15277", "user2", "Car 2" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Uid", "OwnerId", "Title" },
                values: new object[] { "af957ba3-96a4-4a84-8954-4f91056f21ae", "user1", "Car 1" });
        }
    }
}
