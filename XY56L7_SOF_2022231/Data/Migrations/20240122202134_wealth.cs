using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XY56L7_SOF_2022231.Data.Migrations
{
    public partial class wealth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Wealth",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "Wealth" },
                values: new object[] { "9709a6e3-7ddd-495e-a78f-2b2f01db38a0", "21bc9374-00e3-4672-a319-8ba71d5c9a07", 50000 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "Wealth" },
                values: new object[] { "60ba26ae-080d-458c-a948-c330cbab659e", "131ae216-8e14-46bf-8c5e-9df94e159972", 50000 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "Wealth" },
                values: new object[] { "07d60f33-69e3-44d7-bb0a-1cf64655bed6", "de142ade-5d8c-4ea6-9de4-c756818f9099", 50000 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "Wealth" },
                values: new object[] { "03372ada-80a4-4308-a290-108df0662f9e", "cc62c1f7-ef64-4dd1-a317-f4005ee72dce", 50000 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "Wealth" },
                values: new object[] { "83d6f606-0b19-427c-a3de-adfb8ed8f83e", "75e24a49-279d-48f7-afe9-c2271b05c2bf", 50000 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "Wealth" },
                values: new object[] { "67528342-e72f-4ecf-8fb0-9a27983d02f6", "e3ab75a3-35bf-4ca3-8333-55fdc1ec0896", 50000 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "Wealth" },
                values: new object[] { "e9839da3-7e23-4907-86ec-84ea9067271b", "6c9fc8a0-92fa-43d3-80f7-2995318d7df5", 50000 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "Wealth" },
                values: new object[] { "cf173f44-3ca7-4f27-a568-c7ed64b04763", "6d2138ce-191c-4d6b-afe9-3b96197515fc", 50000 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "Wealth" },
                values: new object[] { "de48add7-bc4e-4454-ac34-b3a3d8af7cf7", "3b83b860-e0da-4e41-b7d3-e6bc6e28dd72", 50000 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "Wealth" },
                values: new object[] { "81471d5f-c379-496f-9868-19d54ed33db7", "acba27cb-2ea9-4056-8562-cbff962f4c6a", 50000 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "Wealth" },
                values: new object[] { "995f670d-ee70-4eae-bb0c-cdd88c2e19b8", "9b56c1ac-3d0b-4f11-a5e5-9b13244dacd1", 50000 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "Wealth" },
                values: new object[] { "e8c1c34c-16b5-4525-98c5-db6da02a06d6", "5c800d2b-55a2-48ed-8810-40ff3a41b7ad", 50000 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "Wealth" },
                values: new object[] { "e3ad810b-7deb-4c7c-82de-31cd1055f15f", "110a26a6-ee7e-429e-ae39-d4f4cba488bf", 50000 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "Wealth" },
                values: new object[] { "98962e84-e7e1-4dc7-801c-aaf03db39f04", "e0cbd28f-59e2-49a5-bfbf-0ee22d853700", 50000 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "Wealth" },
                values: new object[] { "571acb98-ef9e-493a-a00a-a0af24d7b55c", "6842bafa-f0da-4e2b-a4e7-27a47f1d3203", 50000 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "Wealth" },
                values: new object[] { "d361b617-7ce6-4243-97e7-4cb4d65beba0", "b78e30d7-f3ff-4b64-b1a6-89f93392bb3f", 50000 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "Wealth" },
                values: new object[] { "475292bb-b8db-4788-9bdd-f1c748f9ed3d", "ab9b1207-c602-4feb-a6c1-834b0be1f49c", 50000 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "Wealth" },
                values: new object[] { "3ffdc11b-a688-49f7-89cb-bc83ea340b8e", "8941ffe5-7aaf-4d59-baf6-4995c0b4b4ef", 50000 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "Wealth" },
                values: new object[] { "ae41eacf-f215-4845-bf0e-a005cc5e04d8", "80507a16-5c82-435a-8988-ac3221599aed", 50000 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "Wealth" },
                values: new object[] { "e9b819f5-4969-4cc8-8a93-8d29f7a4af67", "bdbccfd8-2ba5-4d98-895a-afacd37d6427", 50000 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Uid", "OwnerId", "Title" },
                values: new object[,]
                {
                    { "03eb4535-ac55-4b4e-a138-9d8e9ca6f1de", "user19", "Vortex 19" },
                    { "0c7273fa-9482-45ee-b786-64a08882a065", "user20", "Spectra 20" },
                    { "0d04c8a9-472a-46a7-8968-60eea495e2f6", "user9", "Vortex 9" },
                    { "1de48a11-651d-443d-9b3a-208f67884931", "user11", "Phoenix 11" },
                    { "1f3cc892-600f-40e8-b73a-93ff5ba4e389", "user5", "Pegasus 5" },
                    { "35c93841-3c90-4c7c-aed0-5f6c144c14e5", "user14", "Infinity 14" },
                    { "3f10f324-04c7-40af-bce7-40f478f3f4ec", "user8", "Zenith 8" },
                    { "4a480f3c-b09b-40d5-b8f7-f3141b38d4b1", "user12", "Nebula 12" },
                    { "58d531cd-05c5-4a0e-bb6b-b3039bf2aca3", "user18", "Zenith 18" },
                    { "655cb977-cdef-4a8b-8451-acda6c72e69b", "user7", "Raptor 7" },
                    { "74c0b2d9-12bc-43ed-b46c-d727942dbfc1", "user15", "Pegasus 15" },
                    { "7e0a75c1-526e-455c-961e-a0be63287e7a", "user4", "Infinity 4" },
                    { "8636e2e4-c3fc-46b0-abb0-b9f6130fc8c8", "user1", "Phoenix 1" },
                    { "9681fbaf-ddf9-4d30-93bc-440b5e166361", "user10", "Spectra 10" },
                    { "aacab682-7d9d-42bc-975a-79dce680fc67", "user3", "Quantum 3" },
                    { "b015850d-71fd-45bc-bb63-71dc370336c5", "user17", "Raptor 17" },
                    { "c08361ce-08bc-4915-8975-6cad00eeee7d", "user2", "Nebula 2" },
                    { "c57627f4-9e51-46b1-ab9a-98cfae371761", "user6", "Aurora 6" },
                    { "e59ce669-9f52-40bf-874d-2eb1c23b699d", "user13", "Quantum 13" },
                    { "ecdab5a4-387b-4386-b8c0-5a7a4df574ed", "user16", "Aurora 16" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "03eb4535-ac55-4b4e-a138-9d8e9ca6f1de");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "0c7273fa-9482-45ee-b786-64a08882a065");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "0d04c8a9-472a-46a7-8968-60eea495e2f6");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "1de48a11-651d-443d-9b3a-208f67884931");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "1f3cc892-600f-40e8-b73a-93ff5ba4e389");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "35c93841-3c90-4c7c-aed0-5f6c144c14e5");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "3f10f324-04c7-40af-bce7-40f478f3f4ec");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "4a480f3c-b09b-40d5-b8f7-f3141b38d4b1");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "58d531cd-05c5-4a0e-bb6b-b3039bf2aca3");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "655cb977-cdef-4a8b-8451-acda6c72e69b");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "74c0b2d9-12bc-43ed-b46c-d727942dbfc1");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "7e0a75c1-526e-455c-961e-a0be63287e7a");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "8636e2e4-c3fc-46b0-abb0-b9f6130fc8c8");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "9681fbaf-ddf9-4d30-93bc-440b5e166361");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "aacab682-7d9d-42bc-975a-79dce680fc67");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "b015850d-71fd-45bc-bb63-71dc370336c5");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "c08361ce-08bc-4915-8975-6cad00eeee7d");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "c57627f4-9e51-46b1-ab9a-98cfae371761");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "e59ce669-9f52-40bf-874d-2eb1c23b699d");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "ecdab5a4-387b-4386-b8c0-5a7a4df574ed");

            migrationBuilder.DropColumn(
                name: "Wealth",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9f2109a5-5322-433e-bcb9-1d680c7d5f54", "e0de5734-d822-4e98-8c94-b6ed3f477432" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ae55ccec-7878-4966-8c37-e08b91da5ae1", "ea7cb9b5-9eef-4e94-b23e-c650f86c65de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "16f82b96-ba70-41fe-943d-dbaed9c54061", "128aee05-d80c-4be2-b1c5-4a5ae941281b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "21f28bd1-a9d0-46b4-be73-e5e02a73329f", "819140d2-502b-4141-b004-426aeb7c7574" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a6854466-760f-436e-af3f-1f822277abe3", "66adab50-8ede-4b32-8871-192c7d55b73b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a6067129-62dd-4bb6-9a6e-e58ee9a7fee6", "2b9c75d5-5cc9-4687-aeb4-c4de74b17a73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2d2f85c0-b5ba-4ec9-a963-7aa920a7db52", "51075bee-26e5-42df-be60-413c039a2f7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2e434f1c-3552-4ddf-aff8-16b32f397fb9", "576f9dda-cd6a-46a0-9f28-a6a417adfc3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "496252fd-d7dd-4397-b7fa-cfe2e96514e2", "9e20e88f-69d5-4eb5-b2bc-4bf0172294ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1815cad8-9f83-4d60-8cdb-cd37513ec86f", "09e12b65-ac05-4f92-bf04-8568d3aafcce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dd21fea5-c1cd-478f-9172-2af610bd0a2f", "0217efd2-ce5d-442b-99f4-aba571fd1b84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86408f54-a96a-45a4-a5f7-4f58d09a3c01", "d300948f-1259-49f0-96f2-b54653045327" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2930d76d-8e8b-4576-89be-0e792a8090b4", "673fb79e-7021-4636-a859-1ee04a796949" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8d60cee1-986b-4eec-b563-5b6e52a056a9", "3df54b47-e3a9-41bf-80ae-e61ba7e03cb4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "453ba5fe-690a-4ec0-a97b-51f507009c9b", "bdf58f93-9aab-4f62-9422-9144fbfda90b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b978fa9f-2f33-4a1a-a7a2-65447e115535", "e50891ba-148b-4de9-a002-6dfcadb1d84d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a65fe783-0560-4575-a8e0-0857a0c6b2b8", "a3d468dd-e59f-423d-b632-10d34355c38f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8abd2c1d-4f0f-47e5-b291-dc090113add2", "5007530f-aa94-4995-b0b8-16ac0c618999" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3f38b4d0-9a26-4d08-945d-4acca855ce86", "c34bdb8a-1381-4482-9112-b9ff059fe174" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b99f19fc-6f19-4400-83bf-a35774b31784", "0e1cb82f-2b8a-4e54-b715-9dc08acd030d" });

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
    }
}
