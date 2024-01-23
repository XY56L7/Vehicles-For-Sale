using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XY56L7_SOF_2022231.Data.Migrations
{
    public partial class Motorcycle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Motorcycles",
                columns: table => new
                {
                    Uid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorcycles", x => x.Uid);
                    table.ForeignKey(
                        name: "FK_Motorcycles_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7999b68f-394a-459e-877d-1bbdb0765ff1", "864e2fe5-de92-4262-b2fa-a35dedc11a27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3a7425bd-4684-4580-878b-9ccef2eed3ed", "e867c6f1-4420-4322-b538-d6e697a7c754" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5b43eb42-5580-4485-97ac-2a08402bc850", "ddd7e167-e873-4c04-8b89-25b6ff5ec4eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0439418d-0441-41b6-8373-0581bd09d6d2", "5aab3d89-c70a-47af-992c-3e11c9bdbf97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b85dbde8-e943-4d88-a5a5-a113d5d2fb30", "8cc9d089-9a55-4518-aacc-b202d3a7cdd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5b59d596-d78e-4506-8e63-6445b244f349", "088c154d-2c74-4fd5-9a93-1b9c0ecc6877" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a82891ed-6399-4c51-aa75-832e85eb1f7b", "74c23604-457d-45ef-bc72-22c3bb30b607" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5b9491b1-8169-4ab1-bc62-7e3e69e66978", "89e7d79c-422f-4ea0-8ae2-9e4482a2fd4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b39b0e62-f116-477c-9feb-203a485bbf92", "0a3e4747-5aff-48c2-a68c-625e550a0ddc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "76100233-a69c-47f4-ac5e-8321b722595c", "f48bd03c-27b2-46eb-8291-0843e88614a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cfffb6cb-ea3f-4e35-8b47-4c670e56390a", "12d8f133-f3d8-4948-83eb-4e4daf0c9fec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a094c085-7123-4a4d-b6cb-ff465c824116", "de1b61f3-5189-4d11-8d81-3b8520ad1538" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b554f686-af01-4236-83b9-373824842642", "982c4503-60ed-433d-bece-a81d42c7a26d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b6985104-1521-49b7-acf7-a1efcb5e2d5e", "74d86ff9-2ad9-43c5-833b-981f573d5121" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bedb3439-6f5b-4f96-b113-6f0df9369d65", "b64e3030-16ed-478f-80ab-fa623dd10677" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bea03b12-ae79-4630-a384-fe36c25cea42", "a083feb3-54b3-4c6d-a887-551371a203e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2761a6ef-a5db-4d39-8e18-15b8d8a21636", "5639618c-263c-4a2c-b4c7-fdd0b539aed9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "714178df-aafd-4d15-9f52-6feb668f4d58", "3681d6e9-594f-49f2-b419-ec364acd1423" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b07d8bdc-1fc7-4e0c-b798-a254db094f2a", "b5abd512-ba42-4ce1-9ef5-02c91dbeeab7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a6871427-512f-41b5-9aa9-93334612e979", "2e444729-a70d-41d6-9676-08ca4279f12d" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Uid", "OwnerId", "Title" },
                values: new object[,]
                {
                    { "1d71645b-7104-4bfc-816d-9f43a02ee9ab", "user16", "Aurora 16" },
                    { "293d244a-88f2-4ef1-b3a1-bf6a9348a693", "user6", "Aurora 6" },
                    { "3045100d-d9b4-4e14-9a5b-ced1af130365", "user3", "Quantum 3" },
                    { "4125a4c2-813e-4f36-819e-3f683e031e1d", "user10", "Spectra 10" },
                    { "5c6c5e73-9461-4c38-9dcb-5f1502a2aba0", "user19", "Vortex 19" },
                    { "68e099e4-c7c0-4282-8ec4-a2ace8c780e3", "user14", "Infinity 14" },
                    { "8d8cb1d5-bab2-44c1-8c0c-03b371493d34", "user18", "Zenith 18" },
                    { "98eeb3f5-b70a-4cf3-8def-2bb5af6c984e", "user8", "Zenith 8" },
                    { "9b7cce93-d081-4e93-bcd6-4457b076b33a", "user7", "Raptor 7" },
                    { "a20df922-92e2-4f2b-9fc4-712fb38efe5a", "user4", "Infinity 4" },
                    { "a900632f-de6c-4adc-b8b7-74d3d78f7438", "user12", "Nebula 12" },
                    { "ae39701b-3063-454d-86a5-34dd1ab935dc", "user13", "Quantum 13" },
                    { "b142918e-e941-4f60-9545-813f16101ea9", "user20", "Spectra 20" },
                    { "cfb20bc7-5d7f-4ed3-9fb9-99858ea71b52", "user9", "Vortex 9" },
                    { "d17e7174-553a-46c9-8f3c-d8513ceeb864", "user17", "Raptor 17" },
                    { "d5b0fd8c-fb09-4508-8943-24144e9da6a4", "user5", "Pegasus 5" },
                    { "df80ef82-2d5d-456a-be36-1f04f6448644", "user2", "Nebula 2" },
                    { "ea06d6e5-06f3-4f65-9d14-123b727a69c4", "user11", "Phoenix 11" },
                    { "f3dc3f9c-afd6-46dd-9561-e17dba2f8b56", "user1", "Phoenix 1" },
                    { "ff4fb049-02c8-4b20-91b9-0c9147182657", "user15", "Pegasus 15" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Motorcycles_OwnerId",
                table: "Motorcycles",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Motorcycles");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "1d71645b-7104-4bfc-816d-9f43a02ee9ab");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "293d244a-88f2-4ef1-b3a1-bf6a9348a693");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "3045100d-d9b4-4e14-9a5b-ced1af130365");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "4125a4c2-813e-4f36-819e-3f683e031e1d");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "5c6c5e73-9461-4c38-9dcb-5f1502a2aba0");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "68e099e4-c7c0-4282-8ec4-a2ace8c780e3");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "8d8cb1d5-bab2-44c1-8c0c-03b371493d34");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "98eeb3f5-b70a-4cf3-8def-2bb5af6c984e");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "9b7cce93-d081-4e93-bcd6-4457b076b33a");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "a20df922-92e2-4f2b-9fc4-712fb38efe5a");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "a900632f-de6c-4adc-b8b7-74d3d78f7438");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "ae39701b-3063-454d-86a5-34dd1ab935dc");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "b142918e-e941-4f60-9545-813f16101ea9");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "cfb20bc7-5d7f-4ed3-9fb9-99858ea71b52");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "d17e7174-553a-46c9-8f3c-d8513ceeb864");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "d5b0fd8c-fb09-4508-8943-24144e9da6a4");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "df80ef82-2d5d-456a-be36-1f04f6448644");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "ea06d6e5-06f3-4f65-9d14-123b727a69c4");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "f3dc3f9c-afd6-46dd-9561-e17dba2f8b56");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Uid",
                keyValue: "ff4fb049-02c8-4b20-91b9-0c9147182657");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9709a6e3-7ddd-495e-a78f-2b2f01db38a0", "21bc9374-00e3-4672-a319-8ba71d5c9a07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "60ba26ae-080d-458c-a948-c330cbab659e", "131ae216-8e14-46bf-8c5e-9df94e159972" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "07d60f33-69e3-44d7-bb0a-1cf64655bed6", "de142ade-5d8c-4ea6-9de4-c756818f9099" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "03372ada-80a4-4308-a290-108df0662f9e", "cc62c1f7-ef64-4dd1-a317-f4005ee72dce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "83d6f606-0b19-427c-a3de-adfb8ed8f83e", "75e24a49-279d-48f7-afe9-c2271b05c2bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "67528342-e72f-4ecf-8fb0-9a27983d02f6", "e3ab75a3-35bf-4ca3-8333-55fdc1ec0896" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e9839da3-7e23-4907-86ec-84ea9067271b", "6c9fc8a0-92fa-43d3-80f7-2995318d7df5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cf173f44-3ca7-4f27-a568-c7ed64b04763", "6d2138ce-191c-4d6b-afe9-3b96197515fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "de48add7-bc4e-4454-ac34-b3a3d8af7cf7", "3b83b860-e0da-4e41-b7d3-e6bc6e28dd72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "81471d5f-c379-496f-9868-19d54ed33db7", "acba27cb-2ea9-4056-8562-cbff962f4c6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "995f670d-ee70-4eae-bb0c-cdd88c2e19b8", "9b56c1ac-3d0b-4f11-a5e5-9b13244dacd1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e8c1c34c-16b5-4525-98c5-db6da02a06d6", "5c800d2b-55a2-48ed-8810-40ff3a41b7ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e3ad810b-7deb-4c7c-82de-31cd1055f15f", "110a26a6-ee7e-429e-ae39-d4f4cba488bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "98962e84-e7e1-4dc7-801c-aaf03db39f04", "e0cbd28f-59e2-49a5-bfbf-0ee22d853700" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "571acb98-ef9e-493a-a00a-a0af24d7b55c", "6842bafa-f0da-4e2b-a4e7-27a47f1d3203" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d361b617-7ce6-4243-97e7-4cb4d65beba0", "b78e30d7-f3ff-4b64-b1a6-89f93392bb3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "475292bb-b8db-4788-9bdd-f1c748f9ed3d", "ab9b1207-c602-4feb-a6c1-834b0be1f49c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3ffdc11b-a688-49f7-89cb-bc83ea340b8e", "8941ffe5-7aaf-4d59-baf6-4995c0b4b4ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ae41eacf-f215-4845-bf0e-a005cc5e04d8", "80507a16-5c82-435a-8988-ac3221599aed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e9b819f5-4969-4cc8-8a93-8d29f7a4af67", "bdbccfd8-2ba5-4d98-895a-afacd37d6427" });

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
    }
}
