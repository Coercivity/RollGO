using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSeededLobbyData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("01ba7309-4d6e-4f7d-b243-2d4d5e1a9096"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("01dc75ce-e1f3-4e02-912b-2efc1deec4c1"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("0300f773-50ad-469e-a957-58a8aa5c08e8"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("0319c5c9-9c1a-46e4-aee0-6e7ac65c29cb"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("03e86fb6-f97d-495b-88ff-291ffa54b4b4"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("05e98f15-92bc-44aa-b81c-e801d6a3a912"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("08ec4dbc-c977-46fd-a302-1394f5fc959b"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("09f5a9b1-4ad8-4bb4-9b18-7d7d9b2ee568"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("0c729c6d-3682-43f4-b599-997b0fc1a75c"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("10193655-2668-422d-b31d-a9acd1871be1"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("104260ec-416f-4a07-8095-e2d53fbe1816"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("109adee8-fd81-416b-9efe-80bd4b68b837"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("12631c40-4819-48fb-ac64-d311b5d718df"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("12d23e3c-ec2b-4a10-916a-0a71c088b3c9"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("137cd491-5f59-441c-bc23-533249a94d1e"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("146a6119-f432-4f44-b1b8-3687fa6b0f34"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("14936198-0334-4d7c-b2b6-b41390b33d6e"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("17feb865-39cf-49f4-978d-7104245fe970"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("19558c93-b0f5-4a0e-84ce-98fc802199a0"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("2308cf56-7301-4621-9c94-39e8b87b551c"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("2452d595-48dd-4f21-874a-359ada863991"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("245f641e-f290-41a9-98c2-c9fa34c1b27b"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("26a369a8-d593-4721-9abf-9f8733355aa4"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("2bee5462-7b61-4a08-91ad-2b15fe03323c"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("2d876e78-3442-45f4-a054-a8d249805608"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("31bc22a1-c43a-43a2-b2ed-0965ab4207d9"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("327d49dc-9a1d-413e-9650-b4e86d0e4f6e"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("37f6f3ec-5740-488f-ab92-f8997648c6a1"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("3e964ce8-923b-42c6-ac63-1cb90b632389"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("43200604-fb1f-46a1-8463-36777f751bb2"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("43af7fc5-51fd-49d8-8a83-6745865e6202"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("4442b8da-0709-42b6-8d2e-a50064577d54"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("465180a2-7f58-4211-9a40-15b409aebe59"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("47586aba-227f-4959-b8c5-63b705a02b6b"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("486a235e-b604-417f-9a2a-5e5d6c8f5180"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("4ae17d2b-57fb-4eb9-a6fc-d16779819995"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("4bd467bb-cad2-4bdf-ae8c-d26679b009b3"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("4e6aecd9-1eaf-4dc4-b335-cbed6d30c15e"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("4f1633db-1bd6-49d9-9553-5d3b026a1418"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("52d4ab13-5c1d-4bde-bf90-824827a8a5f2"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("5357381d-f833-4481-9b05-e3b04f536a73"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("5461f354-2089-4d66-80f4-4fdad6caca75"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("58a20751-726f-4406-8b91-07a4dae89eed"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("5a18f372-3a3e-40b4-8d04-e726f5de43f0"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("5f8f7646-a741-4a9e-b358-89aef83eadec"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("64f55903-abb3-4f6d-b840-4db4b5ce53ce"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("7225e54f-3099-4add-b707-d9c64a570d20"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("78bc1066-b493-4bf4-9e89-38c8c5f7b6b5"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("812a1fac-c74a-4b4d-b229-db7434bb2621"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("86337025-724b-4517-b6f2-4a926a0318f6"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("873649fd-d378-461d-9df7-bda32af154c9"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("87daf135-6dd9-44b5-9b6e-f6285fd5ee8b"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("9220791c-001d-45fe-8c16-6649c88bb132"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("9347b77f-bfb5-46b1-8780-609129e05079"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("966b5251-1579-46be-8fcd-db478aef377f"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("993e13dd-39b0-452f-baf2-014ac62b2044"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("994e01f7-ebcc-428b-b1e6-65394452ba86"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("9adbe09d-6ab2-4494-b6ab-90dce08c0564"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("9cc0c21b-cfa9-4943-b047-6fc568a66939"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("9d5d992b-ceaf-48cd-afbc-ac049efda8c3"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("9e2dfef9-23b6-433f-b761-b14760fb8700"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("a3118778-eec0-4ff6-abe7-f814f0c2ed73"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("a394af75-100b-4adc-b1d1-e8b38364f794"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("a63bebeb-027e-41db-b25e-af7d9ca56b28"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("a902d392-a80d-459b-b194-c76b01f277fe"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("a99e36e7-1c1a-4c19-b3a2-cdbc405e4647"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("aaac0492-9a7d-48fb-9bca-39775833e557"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("abfff5a0-76d3-4d64-bb5d-56fe5ce5cc13"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("b0c054ea-8b0a-484a-abde-469d8a15608b"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("b0e98a97-a1a3-4773-bee8-9aa2af68c64f"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("b395259e-591e-4e10-b91b-b5835e503d92"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("b8636a80-9fe1-4521-bdaa-faaed7b672a9"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("b8ac0eaa-bd37-433e-8d6c-28a0084e932e"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("bba0d27e-b6f9-4882-8fe1-e14b25874c6e"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("bc6d80be-4e90-4105-8ff6-33cf79d57314"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("bf4b4599-2953-401c-a9b3-68d98bcec9eb"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("c6357a7d-866e-4a77-ab45-40a9ef8af1a6"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("c670de2f-6c45-485a-978b-9db36fbfef48"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("cdd6f3bd-10c4-43ac-a098-671ecf725b0d"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("d146efb4-b8b0-4a96-ba28-6fdd8c00ca5f"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("d484cde8-9a3d-408a-9fa3-69d33f0941db"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("d539b5da-fd31-4ae6-883a-760035aabecf"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("d8772ae9-0668-47a7-9883-5b52d2b6dd0b"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("d883fe8b-9eea-4fb1-8460-c443c0fb4ae1"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("d8aa1bfc-4c8b-4011-88e1-284a1641a47b"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("de0067ac-f2b2-49f7-8ecb-ea2c187284d3"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("de9c0326-4cf9-4b1a-8bf1-48a80a384a27"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("e05b9aa9-c86b-4749-a8ea-f9c2e9abcab0"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("e28ca5a6-6756-418f-a051-f1033c2ce979"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("e57bfd43-d2a0-4f0c-8274-f8d491d0905e"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("e649acea-42e4-426a-9afa-9f6818b8d0b0"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("e7929beb-40ad-41b2-960a-28d6226187e0"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("ed3c207b-2e52-4287-a480-c04fedb50860"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("ef3a3534-c089-4e6c-b6fc-d68de149b640"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("f1a3d011-1b50-4123-a449-2c68eebbe27d"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("f407e3b6-a049-4c72-bd14-8f06d8fa7c3d"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("f69b5c31-6863-498e-961a-cdb524d5cfd8"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("fb5e3f3b-a908-4306-98dc-022f1db9ca21"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("ff12f1f3-9343-4239-92a5-ae0f6eda3a88"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("ff15586d-6a6c-44d1-b75d-4e03761749b5"));

            migrationBuilder.InsertData(
                table: "Lobby",
                columns: new[] { "Id", "CreatedDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("014b408c-ac7d-4333-a542-4c374071d1ef"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3553), "Elizabeth Nelson" },
                    { new Guid("04b42db1-b473-44f9-9818-ee628ef8fb81"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3652), "Lisa Campbell" },
                    { new Guid("0ba9a9a6-73d8-425d-8771-aa79445609dd"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3366), "Ethan Campbell" },
                    { new Guid("102c3b9f-6f19-4fc1-91ba-b7900d1fe8ce"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3488), "Danial Jones" },
                    { new Guid("113f503f-4489-4476-b39e-87ea80c3fe5b"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3528), "Jessica Sanchez" },
                    { new Guid("120bc5d3-c07b-4082-82a1-108979530f88"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3372), "Jacxon Hill" },
                    { new Guid("13a76d94-4f52-4f79-9f7c-b6e57856803a"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3473), "Wyatt Adams" },
                    { new Guid("13b26f2a-4c11-4c73-88a1-ed29aafcf4fe"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3435), "Jessica Moore" },
                    { new Guid("1448de8b-0b2c-47a7-bdd5-eafa7bc72999"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3551), "Jacxon Thompson" },
                    { new Guid("151a9c06-b08b-453a-a452-3f9f6d36eafa"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3537), "Mason Scott" },
                    { new Guid("16f01135-be1b-4432-90b5-ea1103371de1"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3526), "Christopher Nguyen" },
                    { new Guid("1aefa716-ac36-43d1-ae6d-113da3e09036"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3386), "Brenda Garcia" },
                    { new Guid("1be18b58-abea-4046-b6c4-85d1593ef348"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3390), "Nancy Rivera" },
                    { new Guid("20508e3e-f6b9-4ca7-967e-a2f11de3c3a4"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3456), "Lincoln Lopez" },
                    { new Guid("239be8c9-5b1c-46f1-9d2f-c0b0dabedbdc"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3396), "Theodore Lee" },
                    { new Guid("2434e60f-e5d9-4e95-bffb-2e003cf6d161"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3462), "Luke Sanchez" },
                    { new Guid("2461b2de-a72f-485c-8452-a74b389955a4"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3499), "Aiden Rodriguez" },
                    { new Guid("2afa1988-2d9a-47d4-b3e8-b0641ce9b043"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3638), "Mateo Rivera" },
                    { new Guid("2bde6e96-e782-4875-acaf-9e6a4f3da80a"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3577), "Michelle Nguyen" },
                    { new Guid("2c1ff806-7c58-49fd-9423-d5a62552a70f"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3450), "Henry Garcia" },
                    { new Guid("2cfcdf1f-362f-4fb0-a2de-0d1f310edbc0"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3454), "Cynthia Scott" },
                    { new Guid("2e107bb1-aced-49db-978c-821498a10358"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3497), "Levi Hall" },
                    { new Guid("2f1217de-1f74-4b7d-b523-42ab443a3e6c"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3647), "Jacob Wilson" },
                    { new Guid("320a65c7-f49b-44f9-af9e-d6242301dcc8"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3535), "Brenda Young" },
                    { new Guid("328fc7c5-febe-4717-93ea-1ec36c9d82d4"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3347), "Jack Moore" },
                    { new Guid("32fc5116-8f04-48a4-b0eb-5539b3a489ec"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3623), "Leo Wright" },
                    { new Guid("339a7fc7-51aa-4733-90e4-5ff2ee6b7327"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3565), "Henry Gonzalez" },
                    { new Guid("341c281a-f544-4158-8b25-903808f4d29d"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3464), "Michelle Lopez" },
                    { new Guid("371f0efa-cf9a-4049-8f00-7a109bb7ee67"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3543), "Jayden Nelson" },
                    { new Guid("3818495f-5361-4107-a430-e6238f1a9475"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3432), "Jacxon Rodriguez" },
                    { new Guid("3ba0844a-b34f-42a9-a0e6-44d69ee85922"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3523), "Sandra Smith" },
                    { new Guid("3baae940-cb73-4485-9599-37d7aeda034c"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3490), "Nancy Jones" },
                    { new Guid("3db91276-000d-4082-bb5c-8f51dc8ed87b"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3481), "Maria Wilson" },
                    { new Guid("3ff6e0d2-37b5-4ff0-b89f-8e44019121ad"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3440), "Carol Flores" },
                    { new Guid("428e2bca-d870-4fc2-9e61-3c7dac4f7cdb"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3568), "Isaac Harris" },
                    { new Guid("46007c63-d7e2-4703-aec9-782910dbade0"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3644), "Lincoln Martinez" },
                    { new Guid("55bd1654-a66b-4d4f-9314-20a0e212513b"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3374), "Joseph Carter" },
                    { new Guid("60e03da6-c3fb-4895-a0a1-0cfb9d95d030"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3437), "Ruth Mitchell" },
                    { new Guid("685d7242-f27b-48e1-ae0c-876be7624bcf"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3650), "Maria Carter" },
                    { new Guid("699de902-a5cd-4272-89e9-73ba6592171d"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3635), "John Nguyen" },
                    { new Guid("6be0b6d7-c23e-4c86-9518-39cb05bf52a0"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3570), "Jacob Walker" },
                    { new Guid("6d6bc34c-bc48-4cd1-b7c9-183bb5abdc29"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3561), "Michael Baker" },
                    { new Guid("6dc49161-f6fe-4c39-ba9d-8af74b2f577f"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3426), "Helen Harris" },
                    { new Guid("6fb369ce-bbe3-46c7-a5a8-a8268fa70bcc"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3478), "Linda Hernandez" },
                    { new Guid("7088c068-3e05-41d4-8280-6ecae24b30db"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3343), "Jackson Nelson" },
                    { new Guid("76f03e7f-a318-43d1-bb9b-a66b06d6a3f1"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3656), "Asher Hall" },
                    { new Guid("775d1a89-d9be-4213-9b82-8dad3433779c"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3452), "Linda Adams" },
                    { new Guid("78351a38-8fa2-42a8-8bc4-f34b40f30232"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3661), "Alexander Jackson" },
                    { new Guid("78e55d3d-6ff7-4e13-91ad-b758b8aa42f5"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3531), "Sharon Martin" },
                    { new Guid("7ae1bf6b-f26a-4678-abc4-a1367c5d4a26"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3632), "Shirley Taylor" },
                    { new Guid("81be7f6e-71ee-46b8-82a8-f5789fda7bba"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3518), "Michelle Moore" },
                    { new Guid("8785116e-45d7-46d2-8afd-d3e99a5d1121"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3465), "Margaret Ramirez" },
                    { new Guid("8906a625-8693-4f88-8d1e-2c61645b3598"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3430), "Sarah Nguyen" },
                    { new Guid("8a50612f-59c1-4338-a853-543a07ad8f7b"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3659), "Leo Davis" },
                    { new Guid("93e71c1e-7602-4e8e-a063-57f89c9e3c44"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3402), "Mason Hall" },
                    { new Guid("9a4f7972-e958-4b6c-a941-a1593cd2be16"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3474), "Angela Nguyen" },
                    { new Guid("9e7a8d59-0d8a-40c0-833a-8d41a1dbd7e0"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3470), "Kimberly White" },
                    { new Guid("9fab262d-0056-4b9b-8ca7-4baa4e84f99f"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3495), "Anna Gonzalez" },
                    { new Guid("a2444940-9b5f-4b45-a4bb-c3d552987027"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3629), "Lisa Perez" },
                    { new Guid("a7bcb7e8-9572-46cf-8dbc-36ccf450cb16"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3384), "Melissa Taylor" },
                    { new Guid("ab5a8aa7-49f5-4214-b3a2-a26b225202fc"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3557), "Jacob Ramirez" },
                    { new Guid("abf99d31-19e5-4672-83c2-d925d61bae97"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3400), "Isaac Nguyen" },
                    { new Guid("ad2f3f77-d0b6-40cd-aeaa-d964a5c233f3"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3521), "Cynthia Thomas" },
                    { new Guid("b098b895-59af-4a05-8a45-73655ba517a9"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3377), "Helen Harris" },
                    { new Guid("b140fd27-a4fc-4c4d-9c6b-106eb49071b3"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3579), "Donna Allen" },
                    { new Guid("b362ad62-fbf9-40f8-b249-b5f4f620d75d"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3361), "Michelle Baker" },
                    { new Guid("b4a90a57-8585-40c8-aeeb-e2a78f534e9c"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3393), "Susan Hall" },
                    { new Guid("b4e5cd25-c774-4404-9332-0170ee915822"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3483), "Asher Miller" },
                    { new Guid("b59cb294-4da6-4fab-ad35-22b140a6fb92"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3645), "Logan Smith" },
                    { new Guid("b5a62df3-92b6-4457-8791-4d77c95c0922"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3618), "Deborah Thomas" },
                    { new Guid("b815445b-07b1-4b50-a435-4b747ffcf0cd"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3547), "Sarah Clark" },
                    { new Guid("bcf8e173-85a2-49c6-9f12-0a76bec434f6"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3479), "Karen Green" },
                    { new Guid("c0b1adf2-b690-4235-b1a4-54b9c82a0ab2"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3642), "Anthony Green" },
                    { new Guid("c1019b57-127b-4db6-9bd7-fe5312ddc7be"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3572), "Lincoln Miller" },
                    { new Guid("c302340d-7c7f-4191-98cb-648f75da563a"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3469), "Owen Thomas" },
                    { new Guid("c325c0ad-31b4-4b3a-991c-1e8840ab9706"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3654), "Laura Hernandez" },
                    { new Guid("c53a42e2-b658-4b10-8a38-435105269de3"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3581), "Sebastian Williams" },
                    { new Guid("c548e79a-5884-4e30-82cb-6013bc2756cd"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3625), "Jessica Nelson" },
                    { new Guid("c55cdc99-5dca-4cc6-89a4-b628b7f4c045"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3391), "Liam Anderson" },
                    { new Guid("c6453dee-3e61-4fae-8764-1146022e2ad8"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3533), "Angela White" },
                    { new Guid("c7a7c38e-0dc2-4862-b63e-8890343ef18d"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3399), "Patricia Thompson" },
                    { new Guid("c8eef35e-0012-45ed-ab28-7e76ea6e9894"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3574), "Mason Lee" },
                    { new Guid("cb509d77-1928-40a5-b45a-225323c82830"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3545), "Owen Rodriguez" },
                    { new Guid("cb8186d7-bc39-46ba-b64a-912db5732a9d"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3460), "Luke Martin" },
                    { new Guid("ce8d318e-e286-42b7-a2ab-b8ae79855702"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3541), "William Davis" },
                    { new Guid("d0167458-3420-45c6-b01e-4840e19afb24"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3370), "Melissa White" },
                    { new Guid("d1f8dda4-3336-4d6c-b53c-80861a82fd64"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3563), "Carter Baker" },
                    { new Guid("d3d2c86f-37fa-4eec-b3d4-f64c1aef346e"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3560), "Angela Carter" },
                    { new Guid("d4ccfe0f-2d39-4276-a0bc-0268e8504801"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3555), "Aiden Rivera" },
                    { new Guid("d72d4288-60a8-432a-894e-07e78eb27514"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3381), "Danial Walker" },
                    { new Guid("d9f09e57-d4cf-4a1c-9c82-2d99d96d0974"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3444), "Isaac Lee" },
                    { new Guid("ddbdfc84-e321-43af-9a63-c6f26b010d7f"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3492), "James Sanchez" },
                    { new Guid("e17fa551-9b11-4b5f-bcf3-b3efae015c58"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3636), "Andre Jackson" },
                    { new Guid("e2e04fea-f5bb-4c03-96cf-0de8aeb65c7b"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3486), "Barbara Lee" },
                    { new Guid("e4457dd1-3e22-49f6-8d85-8bb381133768"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3446), "Grayson Brown" },
                    { new Guid("e9bfc376-cf45-4cc9-902c-59f7e27f6938"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3382), "John Adams" },
                    { new Guid("f179a38f-d12d-45c7-a8c5-5c1b9acdcb1d"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3627), "Lisa Nguyen" },
                    { new Guid("fca0a66f-27fa-453d-82a8-06e907d55c37"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3364), "Lucas Lewis" },
                    { new Guid("fdd9586d-ca42-46ba-acf4-b9cecbf4251e"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3442), "Donna Sanchez" },
                    { new Guid("feacf81a-8f8e-4f65-beb2-bcf2c060355c"), new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3357), "Dylon Mitchell" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("014b408c-ac7d-4333-a542-4c374071d1ef"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("04b42db1-b473-44f9-9818-ee628ef8fb81"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("0ba9a9a6-73d8-425d-8771-aa79445609dd"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("102c3b9f-6f19-4fc1-91ba-b7900d1fe8ce"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("113f503f-4489-4476-b39e-87ea80c3fe5b"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("120bc5d3-c07b-4082-82a1-108979530f88"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("13a76d94-4f52-4f79-9f7c-b6e57856803a"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("13b26f2a-4c11-4c73-88a1-ed29aafcf4fe"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("1448de8b-0b2c-47a7-bdd5-eafa7bc72999"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("151a9c06-b08b-453a-a452-3f9f6d36eafa"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("16f01135-be1b-4432-90b5-ea1103371de1"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("1aefa716-ac36-43d1-ae6d-113da3e09036"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("1be18b58-abea-4046-b6c4-85d1593ef348"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("20508e3e-f6b9-4ca7-967e-a2f11de3c3a4"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("239be8c9-5b1c-46f1-9d2f-c0b0dabedbdc"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("2434e60f-e5d9-4e95-bffb-2e003cf6d161"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("2461b2de-a72f-485c-8452-a74b389955a4"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("2afa1988-2d9a-47d4-b3e8-b0641ce9b043"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("2bde6e96-e782-4875-acaf-9e6a4f3da80a"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("2c1ff806-7c58-49fd-9423-d5a62552a70f"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("2cfcdf1f-362f-4fb0-a2de-0d1f310edbc0"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("2e107bb1-aced-49db-978c-821498a10358"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("2f1217de-1f74-4b7d-b523-42ab443a3e6c"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("320a65c7-f49b-44f9-af9e-d6242301dcc8"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("328fc7c5-febe-4717-93ea-1ec36c9d82d4"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("32fc5116-8f04-48a4-b0eb-5539b3a489ec"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("339a7fc7-51aa-4733-90e4-5ff2ee6b7327"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("341c281a-f544-4158-8b25-903808f4d29d"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("371f0efa-cf9a-4049-8f00-7a109bb7ee67"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("3818495f-5361-4107-a430-e6238f1a9475"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("3ba0844a-b34f-42a9-a0e6-44d69ee85922"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("3baae940-cb73-4485-9599-37d7aeda034c"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("3db91276-000d-4082-bb5c-8f51dc8ed87b"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("3ff6e0d2-37b5-4ff0-b89f-8e44019121ad"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("428e2bca-d870-4fc2-9e61-3c7dac4f7cdb"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("46007c63-d7e2-4703-aec9-782910dbade0"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("55bd1654-a66b-4d4f-9314-20a0e212513b"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("60e03da6-c3fb-4895-a0a1-0cfb9d95d030"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("685d7242-f27b-48e1-ae0c-876be7624bcf"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("699de902-a5cd-4272-89e9-73ba6592171d"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("6be0b6d7-c23e-4c86-9518-39cb05bf52a0"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("6d6bc34c-bc48-4cd1-b7c9-183bb5abdc29"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("6dc49161-f6fe-4c39-ba9d-8af74b2f577f"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("6fb369ce-bbe3-46c7-a5a8-a8268fa70bcc"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("7088c068-3e05-41d4-8280-6ecae24b30db"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("76f03e7f-a318-43d1-bb9b-a66b06d6a3f1"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("775d1a89-d9be-4213-9b82-8dad3433779c"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("78351a38-8fa2-42a8-8bc4-f34b40f30232"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("78e55d3d-6ff7-4e13-91ad-b758b8aa42f5"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("7ae1bf6b-f26a-4678-abc4-a1367c5d4a26"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("81be7f6e-71ee-46b8-82a8-f5789fda7bba"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("8785116e-45d7-46d2-8afd-d3e99a5d1121"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("8906a625-8693-4f88-8d1e-2c61645b3598"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("8a50612f-59c1-4338-a853-543a07ad8f7b"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("93e71c1e-7602-4e8e-a063-57f89c9e3c44"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("9a4f7972-e958-4b6c-a941-a1593cd2be16"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("9e7a8d59-0d8a-40c0-833a-8d41a1dbd7e0"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("9fab262d-0056-4b9b-8ca7-4baa4e84f99f"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("a2444940-9b5f-4b45-a4bb-c3d552987027"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("a7bcb7e8-9572-46cf-8dbc-36ccf450cb16"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("ab5a8aa7-49f5-4214-b3a2-a26b225202fc"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("abf99d31-19e5-4672-83c2-d925d61bae97"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("ad2f3f77-d0b6-40cd-aeaa-d964a5c233f3"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("b098b895-59af-4a05-8a45-73655ba517a9"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("b140fd27-a4fc-4c4d-9c6b-106eb49071b3"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("b362ad62-fbf9-40f8-b249-b5f4f620d75d"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("b4a90a57-8585-40c8-aeeb-e2a78f534e9c"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("b4e5cd25-c774-4404-9332-0170ee915822"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("b59cb294-4da6-4fab-ad35-22b140a6fb92"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("b5a62df3-92b6-4457-8791-4d77c95c0922"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("b815445b-07b1-4b50-a435-4b747ffcf0cd"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("bcf8e173-85a2-49c6-9f12-0a76bec434f6"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("c0b1adf2-b690-4235-b1a4-54b9c82a0ab2"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("c1019b57-127b-4db6-9bd7-fe5312ddc7be"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("c302340d-7c7f-4191-98cb-648f75da563a"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("c325c0ad-31b4-4b3a-991c-1e8840ab9706"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("c53a42e2-b658-4b10-8a38-435105269de3"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("c548e79a-5884-4e30-82cb-6013bc2756cd"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("c55cdc99-5dca-4cc6-89a4-b628b7f4c045"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("c6453dee-3e61-4fae-8764-1146022e2ad8"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("c7a7c38e-0dc2-4862-b63e-8890343ef18d"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("c8eef35e-0012-45ed-ab28-7e76ea6e9894"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("cb509d77-1928-40a5-b45a-225323c82830"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("cb8186d7-bc39-46ba-b64a-912db5732a9d"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("ce8d318e-e286-42b7-a2ab-b8ae79855702"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("d0167458-3420-45c6-b01e-4840e19afb24"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("d1f8dda4-3336-4d6c-b53c-80861a82fd64"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("d3d2c86f-37fa-4eec-b3d4-f64c1aef346e"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("d4ccfe0f-2d39-4276-a0bc-0268e8504801"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("d72d4288-60a8-432a-894e-07e78eb27514"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("d9f09e57-d4cf-4a1c-9c82-2d99d96d0974"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("ddbdfc84-e321-43af-9a63-c6f26b010d7f"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("e17fa551-9b11-4b5f-bcf3-b3efae015c58"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("e2e04fea-f5bb-4c03-96cf-0de8aeb65c7b"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("e4457dd1-3e22-49f6-8d85-8bb381133768"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("e9bfc376-cf45-4cc9-902c-59f7e27f6938"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("f179a38f-d12d-45c7-a8c5-5c1b9acdcb1d"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("fca0a66f-27fa-453d-82a8-06e907d55c37"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("fdd9586d-ca42-46ba-acf4-b9cecbf4251e"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("feacf81a-8f8e-4f65-beb2-bcf2c060355c"));

            migrationBuilder.InsertData(
                table: "Lobby",
                columns: new[] { "Id", "CreatedDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("01ba7309-4d6e-4f7d-b243-2d4d5e1a9096"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(4104), "Lobby a9208582-4b6a-46c2-a4cb-0625e41a6406" },
                    { new Guid("01dc75ce-e1f3-4e02-912b-2efc1deec4c1"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3480), "Lobby 4221ed7f-bfa4-49d0-b9f2-f7e1ea2f4a32" },
                    { new Guid("0300f773-50ad-469e-a957-58a8aa5c08e8"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3473), "Lobby 1c919900-6e8b-4351-aa58-7734ec674348" },
                    { new Guid("0319c5c9-9c1a-46e4-aee0-6e7ac65c29cb"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3440), "Lobby fb76a6d6-b61b-4ee1-b62c-d2e2c50e8845" },
                    { new Guid("03e86fb6-f97d-495b-88ff-291ffa54b4b4"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3832), "Lobby d0faf8c5-2721-4c3b-b38a-b40aef767b5a" },
                    { new Guid("05e98f15-92bc-44aa-b81c-e801d6a3a912"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3975), "Lobby b206d591-547a-4fa7-a770-bd733209e758" },
                    { new Guid("08ec4dbc-c977-46fd-a302-1394f5fc959b"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3645), "Lobby d65f6c82-da36-464a-8e55-db5574948dcf" },
                    { new Guid("09f5a9b1-4ad8-4bb4-9b18-7d7d9b2ee568"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(4098), "Lobby 04e53c2f-7e93-4a4e-a6f0-62b8f404531a" },
                    { new Guid("0c729c6d-3682-43f4-b599-997b0fc1a75c"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3900), "Lobby 02459540-3271-4a31-848d-603525b586d2" },
                    { new Guid("10193655-2668-422d-b31d-a9acd1871be1"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3569), "Lobby c66336b8-ad37-4992-a0e9-c1bf1843193c" },
                    { new Guid("104260ec-416f-4a07-8095-e2d53fbe1816"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3314), "Lobby efd52bfb-8a9c-459b-99ae-77caf338826f" },
                    { new Guid("109adee8-fd81-416b-9efe-80bd4b68b837"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(4072), "Lobby 3a189cdc-f3a8-415f-b1a8-d2ba8ca8b273" },
                    { new Guid("12631c40-4819-48fb-ac64-d311b5d718df"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3968), "Lobby 76d7880d-6b63-4bbf-b368-13075411d6ee" },
                    { new Guid("12d23e3c-ec2b-4a10-916a-0a71c088b3c9"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3939), "Lobby d1006940-931b-4e3f-9e7d-d14b6665bf3f" },
                    { new Guid("137cd491-5f59-441c-bc23-533249a94d1e"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(4127), "Lobby 29648a44-e804-41dd-bdde-e661bd2d4184" },
                    { new Guid("146a6119-f432-4f44-b1b8-3687fa6b0f34"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3412), "Lobby 735b5485-7c99-4875-a729-437b0aef85f4" },
                    { new Guid("14936198-0334-4d7c-b2b6-b41390b33d6e"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3424), "Lobby e08ab2c3-9db7-414f-b0d3-759ce1c2f6a8" },
                    { new Guid("17feb865-39cf-49f4-978d-7104245fe970"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(4082), "Lobby b2c72884-0e45-450b-a849-b36aa0cf2e23" },
                    { new Guid("19558c93-b0f5-4a0e-84ce-98fc802199a0"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3637), "Lobby a9989bf0-5091-4fab-bc01-31964e48075c" },
                    { new Guid("2308cf56-7301-4621-9c94-39e8b87b551c"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(4020), "Lobby cee5df40-37a4-4655-94f1-f7192280b429" },
                    { new Guid("2452d595-48dd-4f21-874a-359ada863991"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3959), "Lobby 2fc9da77-4265-4e11-930d-6d25878bb9e3" },
                    { new Guid("245f641e-f290-41a9-98c2-c9fa34c1b27b"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3660), "Lobby c3cd03be-9588-4faa-95eb-de7624d20175" },
                    { new Guid("26a369a8-d593-4721-9abf-9f8733355aa4"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3933), "Lobby e1c5a530-0c76-4762-8a22-d2263eaac036" },
                    { new Guid("2bee5462-7b61-4a08-91ad-2b15fe03323c"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3486), "Lobby 9d29462f-1fbe-47da-b52c-120a1bc5e182" },
                    { new Guid("2d876e78-3442-45f4-a054-a8d249805608"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3348), "Lobby f76f1c37-4000-4996-acbb-24fb7d693f2c" },
                    { new Guid("31bc22a1-c43a-43a2-b2ed-0965ab4207d9"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3851), "Lobby 01ea74dc-93b7-4e34-96a4-8a832c53ba96" },
                    { new Guid("327d49dc-9a1d-413e-9650-b4e86d0e4f6e"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3653), "Lobby 90e8bd9b-9dfd-4b9e-bad7-2b69355c05b5" },
                    { new Guid("37f6f3ec-5740-488f-ab92-f8997648c6a1"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3946), "Lobby 8944ed7c-972f-4630-a9ad-384f32c87b44" },
                    { new Guid("3e964ce8-923b-42c6-ac63-1cb90b632389"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(4111), "Lobby 4717009e-36af-4b51-b4d0-ca803dcb8e82" },
                    { new Guid("43200604-fb1f-46a1-8463-36777f751bb2"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3738), "Lobby 47688736-1b5e-4d34-bd68-3147e7731f97" },
                    { new Guid("43af7fc5-51fd-49d8-8a83-6745865e6202"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3586), "Lobby 7b942615-afeb-448d-9346-6c6281ea9bdb" },
                    { new Guid("4442b8da-0709-42b6-8d2e-a50064577d54"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3745), "Lobby 8adf89bd-391a-4cdd-b626-2b6e3fa06b90" },
                    { new Guid("465180a2-7f58-4211-9a40-15b409aebe59"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(4064), "Lobby 896fd01c-2b49-4abd-8cb6-cc6569cd4660" },
                    { new Guid("47586aba-227f-4959-b8c5-63b705a02b6b"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3578), "Lobby 28ac6ecc-dd15-4b17-a1af-0b60779eab8f" },
                    { new Guid("486a235e-b604-417f-9a2a-5e5d6c8f5180"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3683), "Lobby 9ca2056e-8d04-49ba-886e-cd408a8ff3e6" },
                    { new Guid("4ae17d2b-57fb-4eb9-a6fc-d16779819995"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3784), "Lobby f65350a7-0307-4a26-a187-f6b9adb57094" },
                    { new Guid("4bd467bb-cad2-4bdf-ae8c-d26679b009b3"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(4039), "Lobby a111540b-5998-4984-9d2f-2f2b5ac0d524" },
                    { new Guid("4e6aecd9-1eaf-4dc4-b335-cbed6d30c15e"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3777), "Lobby 62ceaf33-7847-4bdc-8782-c7203dde8e0f" },
                    { new Guid("4f1633db-1bd6-49d9-9553-5d3b026a1418"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3338), "Lobby 805567e2-480f-450d-9011-db805e744089" },
                    { new Guid("52d4ab13-5c1d-4bde-bf90-824827a8a5f2"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3551), "Lobby 38635886-50a6-4d5c-9942-b66ec9b512d9" },
                    { new Guid("5357381d-f833-4481-9b05-e3b04f536a73"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3707), "Lobby 922b0d95-6347-474f-ba41-377dcaa90996" },
                    { new Guid("5461f354-2089-4d66-80f4-4fdad6caca75"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3363), "Lobby 0544be33-e8bc-44a1-93b2-b11d5b972879" },
                    { new Guid("58a20751-726f-4406-8b91-07a4dae89eed"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3356), "Lobby 4760a3cb-2a00-43ac-aa0c-97dbbd7c1d60" },
                    { new Guid("5a18f372-3a3e-40b4-8d04-e726f5de43f0"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3448), "Lobby 91136aea-f262-4e67-8251-7983ce0a87b5" },
                    { new Guid("5f8f7646-a741-4a9e-b358-89aef83eadec"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3387), "Lobby 6546eaf2-a029-4047-bd60-874a1a36fd5d" },
                    { new Guid("64f55903-abb3-4f6d-b840-4db4b5ce53ce"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3464), "Lobby 24efcdd0-0935-46b1-87cc-e8f102fc691f" },
                    { new Guid("7225e54f-3099-4add-b707-d9c64a570d20"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(4121), "Lobby 4effaa41-ff37-4420-87f7-d5ec952e4f36" },
                    { new Guid("78bc1066-b493-4bf4-9e89-38c8c5f7b6b5"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(4151), "Lobby 100ea941-4a51-4249-a099-b897ea01e9bc" },
                    { new Guid("812a1fac-c74a-4b4d-b229-db7434bb2621"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3502), "Lobby 2b3d6421-5c72-495b-bb19-76d0abdd2869" },
                    { new Guid("86337025-724b-4517-b6f2-4a926a0318f6"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3560), "Lobby 7760018b-8ce6-42eb-a38d-a654d0a4587c" },
                    { new Guid("873649fd-d378-461d-9df7-bda32af154c9"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3403), "Lobby d120eb90-e7b8-4b07-bff5-ba7257f2b813" },
                    { new Guid("87daf135-6dd9-44b5-9b6e-f6285fd5ee8b"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(4135), "Lobby 78dddd36-4e82-4b00-9a98-8a96fa7948f9" },
                    { new Guid("9220791c-001d-45fe-8c16-6649c88bb132"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3990), "Lobby 7ba001e9-ef08-4006-b8cc-b415b1c6465c" },
                    { new Guid("9347b77f-bfb5-46b1-8780-609129e05079"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3819), "Lobby 8f55c6ed-4ac1-46c4-b361-24ed671a6bd6" },
                    { new Guid("966b5251-1579-46be-8fcd-db478aef377f"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3618), "Lobby c1829351-34de-4d4a-ac2f-f897221a37b5" },
                    { new Guid("993e13dd-39b0-452f-baf2-014ac62b2044"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3910), "Lobby 54122439-4f8f-4abf-9cdc-dec9095d3491" },
                    { new Guid("994e01f7-ebcc-428b-b1e6-65394452ba86"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(4013), "Lobby e3145695-017e-41fa-9f54-b82ec6e7f79b" },
                    { new Guid("9adbe09d-6ab2-4494-b6ab-90dce08c0564"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3722), "Lobby 4ea42c03-be14-4fd7-8fe0-66a960d38712" },
                    { new Guid("9cc0c21b-cfa9-4943-b047-6fc568a66939"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3953), "Lobby 66dd9418-e6d7-4a87-9c76-bfc1b7a87b43" },
                    { new Guid("9d5d992b-ceaf-48cd-afbc-ac049efda8c3"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3698), "Lobby e72492a1-cd69-4c8d-95be-a6c6833da983" },
                    { new Guid("9e2dfef9-23b6-433f-b761-b14760fb8700"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3925), "Lobby 5941d150-e9d9-4f81-9aab-1d54e510d1a7" },
                    { new Guid("a3118778-eec0-4ff6-abe7-f814f0c2ed73"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(4057), "Lobby 5f66a917-2035-45fc-83f9-cc90ba2caf28" },
                    { new Guid("a394af75-100b-4adc-b1d1-e8b38364f794"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3331), "Lobby 458bd713-ade9-4dce-9247-5d7f954a63f4" },
                    { new Guid("a63bebeb-027e-41db-b25e-af7d9ca56b28"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3669), "Lobby 68c0a113-7dcc-482f-b1d6-67b6b47c2258" },
                    { new Guid("a902d392-a80d-459b-b194-c76b01f277fe"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3996), "Lobby 09421f31-62ce-4692-9795-0e69fa369f5b" },
                    { new Guid("a99e36e7-1c1a-4c19-b3a2-cdbc405e4647"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3629), "Lobby 63c96a14-65c6-43a5-86b3-8096a700459d" },
                    { new Guid("aaac0492-9a7d-48fb-9bca-39775833e557"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3603), "Lobby f1f5b2c6-5cb1-46f4-9de2-1ee5322a977d" },
                    { new Guid("abfff5a0-76d3-4d64-bb5d-56fe5ce5cc13"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3754), "Lobby 0afa6c1f-15a5-463e-ae8c-83f5696a8529" },
                    { new Guid("b0c054ea-8b0a-484a-abde-469d8a15608b"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3824), "Lobby a871ec05-62ad-4b4a-a90d-467446b2619f" },
                    { new Guid("b0e98a97-a1a3-4773-bee8-9aa2af68c64f"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3810), "Lobby 94054b4e-5a51-467d-bf2d-98ad388f6b74" },
                    { new Guid("b395259e-591e-4e10-b91b-b5835e503d92"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3761), "Lobby ff999504-635a-4f96-84a2-62c5663db3e7" },
                    { new Guid("b8636a80-9fe1-4521-bdaa-faaed7b672a9"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3304), "Lobby 4f3abfe4-dd27-41d0-a62a-51ca5a3fec76" },
                    { new Guid("b8ac0eaa-bd37-433e-8d6c-28a0084e932e"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(4143), "Lobby 1b323ef6-4d50-4033-b21c-58cacc33bd48" },
                    { new Guid("bba0d27e-b6f9-4882-8fe1-e14b25874c6e"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3918), "Lobby 7f79f30f-e8e5-403e-a775-8dc1deec93d7" },
                    { new Guid("bc6d80be-4e90-4105-8ff6-33cf79d57314"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3676), "Lobby 4516a5ac-047b-4dad-8bb4-8a75a362a31d" },
                    { new Guid("bf4b4599-2953-401c-a9b3-68d98bcec9eb"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3396), "Lobby dea3a106-0a37-4ab0-8018-db4fec82b96a" },
                    { new Guid("c6357a7d-866e-4a77-ab45-40a9ef8af1a6"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3380), "Lobby bfc3c2e2-554b-4e88-8302-9ba2dbac3a3f" },
                    { new Guid("c670de2f-6c45-485a-978b-9db36fbfef48"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3893), "Lobby c529734b-5f0e-493a-af86-0ba1a7e3f804" },
                    { new Guid("cdd6f3bd-10c4-43ac-a098-671ecf725b0d"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3731), "Lobby ec762c9a-634e-47b9-8788-9a5079741036" },
                    { new Guid("d146efb4-b8b0-4a96-ba28-6fdd8c00ca5f"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3433), "Lobby 5a073a96-e32a-4607-8cba-2ecbb6b71c74" },
                    { new Guid("d484cde8-9a3d-408a-9fa3-69d33f0941db"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(4030), "Lobby 068a5dfa-edc9-4476-93bd-836a5c350826" },
                    { new Guid("d539b5da-fd31-4ae6-883a-760035aabecf"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(4004), "Lobby f6af3a30-d2d5-4d6f-8ee2-d1ecf8b0c53d" },
                    { new Guid("d8772ae9-0668-47a7-9883-5b52d2b6dd0b"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3457), "Lobby f524834a-5c6b-4e00-a7c5-72d8d463db59" },
                    { new Guid("d883fe8b-9eea-4fb1-8460-c443c0fb4ae1"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3495), "Lobby 81b3df76-2dfd-400c-9550-43365c06b1c5" },
                    { new Guid("d8aa1bfc-4c8b-4011-88e1-284a1641a47b"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3982), "Lobby c23257c6-e382-48a5-90b9-0cbba890f1bf" },
                    { new Guid("de0067ac-f2b2-49f7-8ecb-ea2c187284d3"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3593), "Lobby 61b301a8-d11c-454e-b111-9a6bbbbf4f4a" },
                    { new Guid("de9c0326-4cf9-4b1a-8bf1-48a80a384a27"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3609), "Lobby 2fbd2c1d-cd59-48cb-b828-33cb802b43cb" },
                    { new Guid("e05b9aa9-c86b-4749-a8ea-f9c2e9abcab0"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3843), "Lobby 0bd82eef-3020-443e-8f57-22758de35057" },
                    { new Guid("e28ca5a6-6756-418f-a051-f1033c2ce979"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3418), "Lobby a1a1d283-3474-45cf-bd1b-2f3a6c4864a1" },
                    { new Guid("e57bfd43-d2a0-4f0c-8274-f8d491d0905e"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3715), "Lobby e6cc8ebc-e683-4f63-95b2-ef4f81d69706" },
                    { new Guid("e649acea-42e4-426a-9afa-9f6818b8d0b0"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(4089), "Lobby fe7138cb-3e0b-4fbc-9e31-cad992564944" },
                    { new Guid("e7929beb-40ad-41b2-960a-28d6226187e0"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3795), "Lobby e76d47a7-1f6e-4c84-87b1-315d355dbfda" },
                    { new Guid("ed3c207b-2e52-4287-a480-c04fedb50860"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3837), "Lobby 028290cc-d76e-4db4-b2d5-408ed8f3cfd9" },
                    { new Guid("ef3a3534-c089-4e6c-b6fc-d68de149b640"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3770), "Lobby 1ed93ad1-3419-4692-998d-1dd3503a0f5c" },
                    { new Guid("f1a3d011-1b50-4123-a449-2c68eebbe27d"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3802), "Lobby b3e92fa1-ca46-4e0c-8e87-7f7c0d111787" },
                    { new Guid("f407e3b6-a049-4c72-bd14-8f06d8fa7c3d"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3856), "Lobby 106a14f4-23d7-453a-b379-8248ca423220" },
                    { new Guid("f69b5c31-6863-498e-961a-cdb524d5cfd8"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3864), "Lobby 6c51967e-7cb7-4703-9bf7-a8ef3a5ced9a" },
                    { new Guid("fb5e3f3b-a908-4306-98dc-022f1db9ca21"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(4048), "Lobby ace2ade5-7de3-4bd0-adf1-afffffa16e31" },
                    { new Guid("ff12f1f3-9343-4239-92a5-ae0f6eda3a88"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3692), "Lobby 223786cd-dd9e-4a84-a288-978646adc791" },
                    { new Guid("ff15586d-6a6c-44d1-b75d-4e03761749b5"), new DateTime(2023, 12, 3, 15, 24, 1, 464, DateTimeKind.Utc).AddTicks(3372), "Lobby cb297331-a398-43e8-b35e-be1679e2e306" }
                });
        }
    }
}
