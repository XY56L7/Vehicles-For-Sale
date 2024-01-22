using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XY56L7_SOF_2022231.Data.Migrations
{
    public partial class data_seed_further : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { "user1", 0, "9f2109a5-5322-433e-bcb9-1d680c7d5f54", "", new byte[] { 1, 2, 3 }, "SiteUser", "user1@example.com", false, "Elena", "Martinez", false, null, null, null, null, null, false, "e0de5734-d822-4e98-8c94-b6ed3f477432", false, null },
                    { "user10", 0, "ae55ccec-7878-4966-8c37-e08b91da5ae1", "", new byte[] { 10, 11, 12 }, "SiteUser", "user10@example.com", false, "Liam", "Taylor", false, null, null, null, null, null, false, "ea7cb9b5-9eef-4e94-b23e-c650f86c65de", false, null },
                    { "user11", 0, "16f82b96-ba70-41fe-943d-dbaed9c54061", "", new byte[] { 11, 12, 13 }, "SiteUser", "user11@example.com", false, "Mia", "Clark", false, null, null, null, null, null, false, "128aee05-d80c-4be2-b1c5-4a5ae941281b", false, null },
                    { "user12", 0, "21f28bd1-a9d0-46b4-be73-e5e02a73329f", "", new byte[] { 12, 13, 14 }, "SiteUser", "user12@example.com", false, "Gabriel", "Lewis", false, null, null, null, null, null, false, "819140d2-502b-4141-b004-426aeb7c7574", false, null },
                    { "user13", 0, "a6854466-760f-436e-af3f-1f822277abe3", "", new byte[] { 13, 14, 15 }, "SiteUser", "user13@example.com", false, "Luna", "Walker", false, null, null, null, null, null, false, "66adab50-8ede-4b32-8871-192c7d55b73b", false, null },
                    { "user14", 0, "a6067129-62dd-4bb6-9a6e-e58ee9a7fee6", "", new byte[] { 14, 15, 16 }, "SiteUser", "user14@example.com", false, "Sebastian", "Hall", false, null, null, null, null, null, false, "2b9c75d5-5cc9-4687-aeb4-c4de74b17a73", false, null },
                    { "user15", 0, "2d2f85c0-b5ba-4ec9-a963-7aa920a7db52", "", new byte[] { 15, 16, 17 }, "SiteUser", "user15@example.com", false, "Zoe", "Young", false, null, null, null, null, null, false, "51075bee-26e5-42df-be60-413c039a2f7d", false, null },
                    { "user16", 0, "2e434f1c-3552-4ddf-aff8-16b32f397fb9", "", new byte[] { 16, 17, 18 }, "SiteUser", "user16@example.com", false, "Lucas", "Hill", false, null, null, null, null, null, false, "576f9dda-cd6a-46a0-9f28-a6a417adfc3d", false, null },
                    { "user17", 0, "496252fd-d7dd-4397-b7fa-cfe2e96514e2", "", new byte[] { 17, 18, 19 }, "SiteUser", "user17@example.com", false, "Chloe", "Cooper", false, null, null, null, null, null, false, "9e20e88f-69d5-4eb5-b2bc-4bf0172294ed", false, null },
                    { "user18", 0, "1815cad8-9f83-4d60-8cdb-cd37513ec86f", "", new byte[] { 18, 19, 20 }, "SiteUser", "user18@example.com", false, "Mateo", "Baker", false, null, null, null, null, null, false, "09e12b65-ac05-4f92-bf04-8568d3aafcce", false, null },
                    { "user19", 0, "dd21fea5-c1cd-478f-9172-2af610bd0a2f", "", new byte[] { 19, 20, 21 }, "SiteUser", "user19@example.com", false, "Nora", "Ward", false, null, null, null, null, null, false, "0217efd2-ce5d-442b-99f4-aba571fd1b84", false, null },
                    { "user2", 0, "86408f54-a96a-45a4-a5f7-4f58d09a3c01", "", new byte[] { 2, 3, 4 }, "SiteUser", "user2@example.com", false, "Victor", "Smith", false, null, null, null, null, null, false, "d300948f-1259-49f0-96f2-b54653045327", false, null },
                    { "user20", 0, "2930d76d-8e8b-4576-89be-0e792a8090b4", "", new byte[] { 20, 21, 22 }, "SiteUser", "user20@example.com", false, "Alex", "Anderson", false, null, null, null, null, null, false, "673fb79e-7021-4636-a859-1ee04a796949", false, null },
                    { "user3", 0, "8d60cee1-986b-4eec-b563-5b6e52a056a9", "", new byte[] { 3, 4, 5 }, "SiteUser", "user3@example.com", false, "Sophia", "Garcia", false, null, null, null, null, null, false, "3df54b47-e3a9-41bf-80ae-e61ba7e03cb4", false, null },
                    { "user4", 0, "453ba5fe-690a-4ec0-a97b-51f507009c9b", "", new byte[] { 4, 5, 6 }, "SiteUser", "user4@example.com", false, "Oliver", "Johnson", false, null, null, null, null, null, false, "bdf58f93-9aab-4f62-9422-9144fbfda90b", false, null },
                    { "user5", 0, "b978fa9f-2f33-4a1a-a7a2-65447e115535", "", new byte[] { 5, 6, 7 }, "SiteUser", "user5@example.com", false, "Isabella", "Rodriguez", false, null, null, null, null, null, false, "e50891ba-148b-4de9-a002-6dfcadb1d84d", false, null },
                    { "user6", 0, "a65fe783-0560-4575-a8e0-0857a0c6b2b8", "", new byte[] { 6, 7, 8 }, "SiteUser", "user6@example.com", false, "Max", "Brown", false, null, null, null, null, null, false, "a3d468dd-e59f-423d-b632-10d34355c38f", false, null },
                    { "user7", 0, "8abd2c1d-4f0f-47e5-b291-dc090113add2", "", new byte[] { 7, 8, 9 }, "SiteUser", "user7@example.com", false, "Emma", "Lee", false, null, null, null, null, null, false, "5007530f-aa94-4995-b0b8-16ac0c618999", false, null },
                    { "user8", 0, "3f38b4d0-9a26-4d08-945d-4acca855ce86", "", new byte[] { 8, 9, 10 }, "SiteUser", "user8@example.com", false, "Leo", "Davis", false, null, null, null, null, null, false, "c34bdb8a-1381-4482-9112-b9ff059fe174", false, null },
                    { "user9", 0, "b99f19fc-6f19-4400-83bf-a35774b31784", "", new byte[] { 9, 10, 11 }, "SiteUser", "user9@example.com", false, "Ava", "Hernandez", false, null, null, null, null, null, false, "0e1cb82f-2b8a-4e54-b715-9dc08acd030d", false, null }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Uid", "OwnerId", "Title" },
                values: new object[,]
                {
                    { "1444df50-85f1-4a23-95c5-45e1d47ce0ab", "user12", "Nebula 12" },
                    { "16d51f5f-3beb-4e3a-82cf-1309d583b1b6", "user8", "Zenith 8" },
                    { "199428d4-ff96-4252-8489-fe457e151bcc", "user17", "Raptor 17" },
                    { "3741ee39-92c5-4f91-a3b3-3ba4c60d4f21", "user20", "Spectra 20" },
                    { "377da23b-f18d-455a-96ca-d532ebb4947d", "user16", "Aurora 16" },
                    { "4bf45715-5450-4f0c-b1ad-60d982827999", "user19", "Vortex 19" },
                    { "518a5e2f-7882-49d4-8540-a079a193a445", "user10", "Spectra 10" },
                    { "56201d89-adbe-4bce-9882-2332c35a1d7c", "user9", "Vortex 9" },
                    { "59ba80f1-8d10-4a28-b8d2-2856ef17cab6", "user1", "Phoenix 1" },
                    { "6437c5b6-a1fa-490b-9db3-f652ac098c60", "user13", "Quantum 13" },
                    { "6f56e67a-5692-4095-89d3-f461b1349a1e", "user2", "Nebula 2" },
                    { "74e95ae3-abaa-4c2b-84bb-d37a65c85f6a", "user18", "Zenith 18" },
                    { "8179e0a5-a21b-4f28-94a4-7e9323d31cec", "user6", "Aurora 6" },
                    { "87c1fd44-cea5-4691-9d85-95823da0e914", "user15", "Pegasus 15" },
                    { "87d81206-9073-4e49-8cdb-2f4aa6706c83", "user11", "Phoenix 11" },
                    { "ac94881b-92fb-45da-929e-58111b16f01c", "user7", "Raptor 7" },
                    { "c8b16786-0686-42aa-901e-6470260eca56", "user5", "Pegasus 5" },
                    { "da815278-031a-4c7e-b86e-33f4e0ec7468", "user14", "Infinity 14" },
                    { "ea6561a9-9d98-49db-9efc-639686e8017f", "user3", "Quantum 3" },
                    { "f9b6127f-b4ce-4430-90af-de1223b7cb14", "user4", "Infinity 4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "1444df50-85f1-4a23-95c5-45e1d47ce0ab");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "16d51f5f-3beb-4e3a-82cf-1309d583b1b6");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "199428d4-ff96-4252-8489-fe457e151bcc");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "3741ee39-92c5-4f91-a3b3-3ba4c60d4f21");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "377da23b-f18d-455a-96ca-d532ebb4947d");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "4bf45715-5450-4f0c-b1ad-60d982827999");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "518a5e2f-7882-49d4-8540-a079a193a445");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "56201d89-adbe-4bce-9882-2332c35a1d7c");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "59ba80f1-8d10-4a28-b8d2-2856ef17cab6");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "6437c5b6-a1fa-490b-9db3-f652ac098c60");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "6f56e67a-5692-4095-89d3-f461b1349a1e");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "74e95ae3-abaa-4c2b-84bb-d37a65c85f6a");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "8179e0a5-a21b-4f28-94a4-7e9323d31cec");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "87c1fd44-cea5-4691-9d85-95823da0e914");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "87d81206-9073-4e49-8cdb-2f4aa6706c83");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "ac94881b-92fb-45da-929e-58111b16f01c");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "c8b16786-0686-42aa-901e-6470260eca56");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "da815278-031a-4c7e-b86e-33f4e0ec7468");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "ea6561a9-9d98-49db-9efc-639686e8017f");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "f9b6127f-b4ce-4430-90af-de1223b7cb14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9");

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
    }
}
