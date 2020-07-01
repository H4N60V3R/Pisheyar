using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pisheyar.Infrastructure.Migrations
{
    public partial class AddSecondPageCoverDocument : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SecondPageCoverDocumentID",
                table: "Category",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "AdminID",
                keyValue: 1,
                columns: new[] { "AdminGUID", "ModifiedDate" },
                values: new object[] { new Guid("c8cccc12-14b4-4b89-9578-00918a777729"), new DateTime(2020, 7, 1, 17, 50, 21, 844, DateTimeKind.Local).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("c265fd02-0194-4d38-83e8-a93bc3698fcc"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("dec37f17-0ab2-4208-8ba7-11cc1120369b"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(3667) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("e3b1e3a1-4d79-454d-8b1f-6c9e24e290b2"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(3723) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 4,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("c5652bb9-6281-4e0a-88e6-49adb3658e92"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(3734) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 5,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("9ccfacea-333a-4fce-bbf8-c2f18af06f20"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(3742) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 6,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("3d23d831-7c85-4cff-a64c-4b388c911cf9"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 7,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("47cb28ce-1559-4db1-9a8b-c2d809a78ab4"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(3757) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 8,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("891c9159-2d75-49eb-bd2a-a9596eb03d54"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 9,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("a636dc6d-da7d-4787-bd4a-e7d912b1f922"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 10,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("3aef52b3-41ac-4e87-b700-75b99dd657f6"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(3845) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 11,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("4e113698-79e9-4165-a537-b0cecd865970"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 12,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("e9278744-83a7-4365-8b25-7a256d14d28b"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 13,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("4d03ab45-f474-479f-a614-f55c3bb9a1b2"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(3868) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 14,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("98afc1e5-756f-4c78-a5ff-93905f791c80"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(3876) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 15,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("44eae191-7208-4588-905f-55d266ea8eba"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 16,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("84a5de53-db86-476a-a27d-ff320d3cf527"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 17,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("848c316e-1e69-44a0-a9d7-bd3731dac307"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(3901) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 18,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("cad06d8c-f51a-4885-a194-dead0b419d0d"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(3909) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 19,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("a3aaab0f-0ac1-4f8f-9fbf-0547ccc085ac"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(3916) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 20,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("9b47c008-d271-4572-b318-69e16f1c00d4"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 21,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("f0aeedc9-7901-46cb-ab1a-fe3ed8296462"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 22,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("d7bc2132-cdda-448a-8a9a-c15f2217033a"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 23,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("40ef9916-c000-4d80-a486-00a5d368ff94"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 24,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("b2c63654-a51f-42b3-9429-653984817ae0"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(3985) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 25,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("66f04591-9dd5-4928-a303-19d3d8a1abaa"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 26,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("4b7a174d-94f8-49cf-9630-dede5024579f"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(4001) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 27,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("813c228b-219c-401e-b705-e9278f0bc5a3"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 28,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("7668e4ae-cbc3-4ad6-8d11-444ea8f00948"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(4018) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 29,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("75ac9158-4e0c-44f5-b7e2-f0fedc36f87d"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 30,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("8f497bc4-3bb3-495f-a831-c2f24e53641a"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 31,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("3dcb8ae9-e0ce-46ee-8562-43ccc63da4a5"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 32,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("e68c1481-a367-4ae7-94a4-39592e4ea314"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 33,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("4dbd5b01-be21-4eb1-9a37-c7400c549213"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(4059) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 34,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("31d6af95-ae1b-493f-98fd-51aa0508fc43"), true, new DateTime(2020, 7, 1, 17, 50, 21, 851, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1,
                column: "CityGUID",
                value: new Guid("2ef50d35-a767-4a05-acf2-113db68dfe54"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 2,
                column: "CityGUID",
                value: new Guid("ae9807e4-23b7-49a7-bc7f-da3d3c5a97a2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 3,
                column: "CityGUID",
                value: new Guid("b1ef0534-8cf3-44de-a639-7fda59ebbdd0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 4,
                column: "CityGUID",
                value: new Guid("12305cef-6e2d-403f-bb83-da2cc6456bb2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 5,
                column: "CityGUID",
                value: new Guid("a619cdb3-2d34-4676-9618-118ffb81b65c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 6,
                column: "CityGUID",
                value: new Guid("837a7149-c500-45b2-989d-f0cfec94b01c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 7,
                column: "CityGUID",
                value: new Guid("bae1f074-7269-437e-b200-70cac7091d84"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 8,
                column: "CityGUID",
                value: new Guid("19fd2eab-2d74-4e15-a010-db7229e03f67"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 9,
                column: "CityGUID",
                value: new Guid("796be2c2-3ed4-4675-8664-24721aebf3d9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 10,
                column: "CityGUID",
                value: new Guid("299b721d-6cac-42d4-bd1a-7d7a00211846"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 11,
                column: "CityGUID",
                value: new Guid("616e1d1c-5e61-4a99-8ce7-b10ce95ad964"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 12,
                column: "CityGUID",
                value: new Guid("6bd124a1-d2fd-47f5-ac86-e26ee48270e5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 13,
                column: "CityGUID",
                value: new Guid("269e4d75-1cea-4d7a-82b2-640f37ac2865"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 14,
                column: "CityGUID",
                value: new Guid("4a72dbfe-974a-467b-be7e-c326f41b5f2f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 15,
                column: "CityGUID",
                value: new Guid("6a5c8ecf-fdd7-4665-a00b-abcd253f9748"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 16,
                column: "CityGUID",
                value: new Guid("8a4feced-38d3-4f82-a255-f3dd2b67d404"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 17,
                column: "CityGUID",
                value: new Guid("654e19a1-ad6b-4afc-90cf-2b0c9e4b5a49"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 18,
                column: "CityGUID",
                value: new Guid("15a80e74-0b11-47a6-917f-1633230e7911"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 19,
                column: "CityGUID",
                value: new Guid("b34da962-b0fa-4aaa-b86c-9b51afb47d06"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 20,
                column: "CityGUID",
                value: new Guid("c2e6e13e-264d-446f-bdb4-a11a9ed8aad9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 21,
                column: "CityGUID",
                value: new Guid("2a40d47f-90bb-4814-abda-a897ef9e1436"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 22,
                column: "CityGUID",
                value: new Guid("8333b2bb-8da5-4a2c-ba52-faaa37cb8d97"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 23,
                column: "CityGUID",
                value: new Guid("def09c72-3be6-4b34-b505-9a338575fdf5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 24,
                column: "CityGUID",
                value: new Guid("91e24176-9997-47c1-8374-3674d3498246"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 25,
                column: "CityGUID",
                value: new Guid("0e5275c3-e4a8-4289-800e-3e51d6311b09"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 26,
                column: "CityGUID",
                value: new Guid("f6e15a44-1c15-41d9-a640-8762936507bf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 27,
                column: "CityGUID",
                value: new Guid("51731b7b-22c0-4303-b751-be2906387cd1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 28,
                column: "CityGUID",
                value: new Guid("61dd8fc5-c0f9-44f4-a4cf-2cb0eafb257e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 29,
                column: "CityGUID",
                value: new Guid("0d20b437-092d-4079-a036-99cd384bb038"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 30,
                column: "CityGUID",
                value: new Guid("75168011-8874-4b72-b7e6-bc498158af3e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 31,
                column: "CityGUID",
                value: new Guid("b3797be3-332b-44d6-b01d-02641b2a15eb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 32,
                column: "CityGUID",
                value: new Guid("f7c8a290-fdad-4c7a-89a9-439e895572a7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 33,
                column: "CityGUID",
                value: new Guid("378bc2c4-321c-4445-a48f-e8cf7f454aab"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 34,
                column: "CityGUID",
                value: new Guid("6a242df6-5ce8-42f1-a228-e4d17a8c11f3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 35,
                column: "CityGUID",
                value: new Guid("8655f61c-fbe7-4af0-b18e-dc13207b97fe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 36,
                column: "CityGUID",
                value: new Guid("28485bdc-dd89-4cfb-a33c-7a95ecff8ffd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 37,
                column: "CityGUID",
                value: new Guid("a4feb2db-28d7-4241-aa47-fd16d02ad51a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 38,
                column: "CityGUID",
                value: new Guid("142be12c-5320-4f64-9e0a-31d4078c6378"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 39,
                column: "CityGUID",
                value: new Guid("0e10ce60-3587-4556-b445-bd508fbc7c15"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 40,
                column: "CityGUID",
                value: new Guid("3e9b5961-6f16-4736-8e53-b8720afc081e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 41,
                column: "CityGUID",
                value: new Guid("cf56df30-bff8-4f15-a916-a4dc3390f577"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 42,
                column: "CityGUID",
                value: new Guid("f09c1523-81a4-496d-81e4-78fb8f85e563"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 43,
                column: "CityGUID",
                value: new Guid("2946d585-1e44-4178-8865-c11e9048bf75"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 44,
                column: "CityGUID",
                value: new Guid("6c7945ad-3fee-4249-afbe-29c6247f335f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 45,
                column: "CityGUID",
                value: new Guid("bd815c35-07e2-46a0-9fe3-fd2b1244450f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 46,
                column: "CityGUID",
                value: new Guid("59648800-2e5a-493b-ac25-35722e590ce2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 47,
                column: "CityGUID",
                value: new Guid("87e246eb-0ee3-4882-b89d-c20eb64751aa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 48,
                column: "CityGUID",
                value: new Guid("580c0332-d36f-4618-bf87-669f831e376b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 49,
                column: "CityGUID",
                value: new Guid("984e5b1f-82da-4e66-9efb-dec891076e7b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 50,
                column: "CityGUID",
                value: new Guid("338dd7f8-dfa0-4c92-8131-f7671762e458"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 51,
                column: "CityGUID",
                value: new Guid("5e63dc2b-13bf-4849-8cca-1e36d5567290"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 52,
                column: "CityGUID",
                value: new Guid("8d27ee1c-bc5b-4c6b-a160-8e0b7e456311"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 53,
                column: "CityGUID",
                value: new Guid("e6934405-a364-4bca-b424-d29e8602a089"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 54,
                column: "CityGUID",
                value: new Guid("75efa04e-6786-4a00-ae01-65e876592f5a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 55,
                column: "CityGUID",
                value: new Guid("f35ce423-b16f-4a3b-aa75-ca6705aa907d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 56,
                column: "CityGUID",
                value: new Guid("e92bf548-c258-4c84-860a-32c46251ec41"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 57,
                column: "CityGUID",
                value: new Guid("635a0a99-f991-47d4-bbc7-7bf218206c6f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 58,
                column: "CityGUID",
                value: new Guid("ff627b3f-799f-486b-abf2-0d9264b19e79"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 59,
                column: "CityGUID",
                value: new Guid("f17bda35-e941-4487-b4c6-841dd0ee685a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 60,
                column: "CityGUID",
                value: new Guid("0944c9dd-784e-4ebd-b2ef-c403c95b5587"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 61,
                column: "CityGUID",
                value: new Guid("eff7f130-9a41-4b64-823a-4224b6c01992"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 62,
                column: "CityGUID",
                value: new Guid("2b886866-d3e4-4846-95b3-72af65ebb72c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 63,
                column: "CityGUID",
                value: new Guid("0cea5c27-494e-4eb5-9ed7-0f1cdf19864a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 64,
                column: "CityGUID",
                value: new Guid("c27af46b-ebe5-4208-9fad-dc53b49d515c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 65,
                column: "CityGUID",
                value: new Guid("69693afe-5737-45a1-a95e-75af7ed97498"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 66,
                column: "CityGUID",
                value: new Guid("bf571c3f-cf83-4d37-b3f3-5015b44bb582"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 67,
                column: "CityGUID",
                value: new Guid("1d36feac-6b79-4093-8639-54f25623d89a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 68,
                column: "CityGUID",
                value: new Guid("df0cec8a-8a8e-4cf3-b02d-9951a60943de"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 69,
                column: "CityGUID",
                value: new Guid("79079b38-7a49-4b16-890b-178a398ccf5a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 70,
                column: "CityGUID",
                value: new Guid("ba6b2aad-1815-4ca1-bcc3-8a51fc13cf5b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 71,
                column: "CityGUID",
                value: new Guid("fb9e5b56-596c-4dbc-94e7-9ec0d755ef86"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 72,
                column: "CityGUID",
                value: new Guid("b63ec843-ea81-4af3-b893-00f4c5b927f8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 73,
                column: "CityGUID",
                value: new Guid("38ee00d6-fc4d-4fd6-aca5-60f6fde08d92"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 74,
                column: "CityGUID",
                value: new Guid("c7684b94-0c6f-4c11-b762-7e168127062a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 75,
                column: "CityGUID",
                value: new Guid("69427c7a-dfee-43a8-a7ec-afcb5eef5314"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 76,
                column: "CityGUID",
                value: new Guid("d2d698c5-8946-4010-bacf-df54680a48de"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 77,
                column: "CityGUID",
                value: new Guid("a338c75d-218d-4882-afb1-c0b05d9746bd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 78,
                column: "CityGUID",
                value: new Guid("ea11e18f-d672-4316-9ac9-64b3615eee31"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 79,
                column: "CityGUID",
                value: new Guid("3d9326c2-b309-484a-9be7-715f509706c8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 80,
                column: "CityGUID",
                value: new Guid("406d194e-8c0c-4dbf-a61d-974c1cf1fe53"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 81,
                column: "CityGUID",
                value: new Guid("62cf90d3-641b-4d26-b4d2-b0d65ab0e63e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 82,
                column: "CityGUID",
                value: new Guid("7222dfec-9046-4af7-a6c8-763a75c35c66"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 83,
                column: "CityGUID",
                value: new Guid("022eab2e-cfff-4384-9524-61b02453f590"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 84,
                column: "CityGUID",
                value: new Guid("7d873410-6f72-4d57-9111-9dacecd5724a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 85,
                column: "CityGUID",
                value: new Guid("948e839b-8533-491e-bed1-79872f340bdc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 86,
                column: "CityGUID",
                value: new Guid("8b31f997-3dd5-41ac-9964-c20760a6d1d0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 87,
                column: "CityGUID",
                value: new Guid("c8ccf9c2-14b4-47e2-ab09-146c156cc9e4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 88,
                column: "CityGUID",
                value: new Guid("c819ec30-cf4c-4e14-88cd-0b311c101956"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 89,
                column: "CityGUID",
                value: new Guid("29967ccd-de84-4909-9bda-6a916fee3629"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 90,
                column: "CityGUID",
                value: new Guid("7c3ee2f7-00e8-4052-9032-d57ce8a47fe4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 91,
                column: "CityGUID",
                value: new Guid("c187a12a-8541-42a7-909b-8b6f3e4e233e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 92,
                column: "CityGUID",
                value: new Guid("d0741541-6305-45a1-87c6-4915db695b87"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 93,
                column: "CityGUID",
                value: new Guid("9ba5dd47-c257-4515-bacc-84e2567c106c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 94,
                column: "CityGUID",
                value: new Guid("11249d79-4bfe-428b-9b7e-a00e84a72394"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 95,
                column: "CityGUID",
                value: new Guid("5b4b5c1e-8080-47d8-8315-dd4342b8d758"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 96,
                column: "CityGUID",
                value: new Guid("0d90a1dd-4d1f-4642-9305-96913e61af3c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 97,
                column: "CityGUID",
                value: new Guid("be2879a0-6d89-4965-92cf-f76363b39196"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 98,
                column: "CityGUID",
                value: new Guid("ca99c0b5-5234-4cfc-a75c-591764c6fb30"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 99,
                column: "CityGUID",
                value: new Guid("d1d12bc9-3d46-4fd9-acd5-acececdb8288"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 100,
                column: "CityGUID",
                value: new Guid("281fc732-1a06-4d24-8905-d71035f1a2e2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 101,
                column: "CityGUID",
                value: new Guid("b6944975-e30d-4300-ac39-aa867c11156b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 102,
                column: "CityGUID",
                value: new Guid("7a3dc98d-e587-4462-98b0-4a489b87f349"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 103,
                column: "CityGUID",
                value: new Guid("ce15b08e-45bb-4719-8522-3ff6760d1bb3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 104,
                column: "CityGUID",
                value: new Guid("d3146ef3-6e40-484c-a319-360580e6217f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 105,
                column: "CityGUID",
                value: new Guid("224177b4-e43a-4495-90f2-183a01b0949e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 106,
                column: "CityGUID",
                value: new Guid("72de91db-249c-46b1-af01-72eff09815d9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 107,
                column: "CityGUID",
                value: new Guid("663e56e0-9503-4f80-84c6-5c1daf8d4a90"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 108,
                column: "CityGUID",
                value: new Guid("83bc8b72-9b77-4867-80a3-e5b5fc4f64ae"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 109,
                column: "CityGUID",
                value: new Guid("56aec283-2c0b-4e8d-8453-a709fc7d3e8a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 110,
                column: "CityGUID",
                value: new Guid("31f2718d-fd9d-4626-947f-33c78c0b9d93"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 111,
                column: "CityGUID",
                value: new Guid("ea57a453-bb0b-45c1-8345-b029b5b486a6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 112,
                column: "CityGUID",
                value: new Guid("3b6c8c60-9c80-47b8-9d65-9e728302ec10"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 113,
                column: "CityGUID",
                value: new Guid("4d807b15-a973-482b-bdb4-6faa5776948d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 114,
                column: "CityGUID",
                value: new Guid("a450b8bc-ba04-4bbe-8ab6-3a10d4c0f869"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 115,
                column: "CityGUID",
                value: new Guid("a1230a67-75f2-476b-bdff-d479c98fdbc6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 116,
                column: "CityGUID",
                value: new Guid("88ca15b5-f265-46c1-a4f9-bab0d5c9ef96"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 117,
                column: "CityGUID",
                value: new Guid("0fc8fc2b-163b-4c34-91de-2c02947c7400"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 118,
                column: "CityGUID",
                value: new Guid("db7c1de5-c8f7-4ca5-98eb-bba69f8869f5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 119,
                column: "CityGUID",
                value: new Guid("c204e2d5-5a54-4e09-9aef-62b501b76ac1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 120,
                column: "CityGUID",
                value: new Guid("a1572d57-be0d-4931-9969-badb69cc2285"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 121,
                column: "CityGUID",
                value: new Guid("50c2e728-190a-4429-b112-af544f242192"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 122,
                column: "CityGUID",
                value: new Guid("61f916fb-2474-4e10-bbd5-5b852aa7e8bd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 123,
                column: "CityGUID",
                value: new Guid("a669395b-554c-44cf-9f45-5c4097ec421a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 124,
                column: "CityGUID",
                value: new Guid("bfbbf11e-48ff-444f-8352-b7fb5f336946"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 125,
                column: "CityGUID",
                value: new Guid("5dcccad0-5dee-46aa-b0a5-0f816f760ee1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 126,
                column: "CityGUID",
                value: new Guid("67846a5b-9abf-4911-a752-8697c5349758"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 127,
                column: "CityGUID",
                value: new Guid("8851c001-45ba-443f-8f56-b6c8c02416f3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 128,
                column: "CityGUID",
                value: new Guid("aaae9879-be78-43de-9420-f84ad6c82592"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 129,
                column: "CityGUID",
                value: new Guid("099b4d11-dc22-4b52-ab45-43e9950488b3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 130,
                column: "CityGUID",
                value: new Guid("868033f5-ccab-41b8-9e61-564b331a161f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 131,
                column: "CityGUID",
                value: new Guid("212b6674-809b-4f47-a017-7b5bc9b6ada6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 132,
                column: "CityGUID",
                value: new Guid("92f03bff-2aa5-4ab7-8ee7-9f42d63eb0b4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 133,
                column: "CityGUID",
                value: new Guid("f6377f0c-7832-4a71-8463-18b08fd89a78"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 134,
                column: "CityGUID",
                value: new Guid("90e779c3-8a82-4f24-b051-ac641ae67b7d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 135,
                column: "CityGUID",
                value: new Guid("8dbe35e5-89a4-4fdb-ae61-7986febd4174"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 136,
                column: "CityGUID",
                value: new Guid("b3bfd153-40b7-4389-a5df-e0a4acb37d23"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 137,
                column: "CityGUID",
                value: new Guid("1af9aceb-691e-4e8a-b3cd-48b922aa7597"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 138,
                column: "CityGUID",
                value: new Guid("87dddf3e-c1e4-4812-9cf8-84966ac85bae"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 139,
                column: "CityGUID",
                value: new Guid("ca39e412-2ff8-46a9-814d-307c0c1a0d19"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 140,
                column: "CityGUID",
                value: new Guid("e09e9ac3-d7f7-4acd-8b3b-86143f91ad33"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 141,
                column: "CityGUID",
                value: new Guid("1b9e2606-0a8d-4b65-8b34-a90f77747893"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 142,
                column: "CityGUID",
                value: new Guid("d38d27e5-b5ca-4454-a56f-756657319c65"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 143,
                column: "CityGUID",
                value: new Guid("26499541-7fbf-4c0f-a141-3c3358cf91c1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 144,
                column: "CityGUID",
                value: new Guid("1b6ae2eb-c0f4-43e9-b0ad-ee97baf07abd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 145,
                column: "CityGUID",
                value: new Guid("96f9c580-5e20-4482-a860-95f19710a3c4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 146,
                column: "CityGUID",
                value: new Guid("32b6d9bf-a37a-4da7-936c-ff2aae2fadd8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 147,
                column: "CityGUID",
                value: new Guid("eb36a3c9-14a5-4140-a08d-6aa560025702"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 148,
                column: "CityGUID",
                value: new Guid("98a4ab0d-cc46-40ee-a301-de3fafbaf4e5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 149,
                column: "CityGUID",
                value: new Guid("1d51434e-a45b-4eeb-baec-b870fc6af808"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 150,
                column: "CityGUID",
                value: new Guid("bc60a4e2-97dc-49a9-9c83-14b0efb253ed"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 151,
                column: "CityGUID",
                value: new Guid("1c2425cb-ecf2-491a-96d5-2021714bd6b7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 152,
                column: "CityGUID",
                value: new Guid("95dba551-f229-4807-80f0-f6d5cf20093d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 153,
                column: "CityGUID",
                value: new Guid("313f9870-aeba-47ef-8285-a8665adfb099"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 154,
                column: "CityGUID",
                value: new Guid("9e0fcf4d-cc7e-43b6-b153-f16402757b6c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 155,
                column: "CityGUID",
                value: new Guid("1a04a6fd-d86e-4837-bba4-637207e60c95"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 156,
                column: "CityGUID",
                value: new Guid("2270c56c-621b-45f7-bad4-db2c09b58a4d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 157,
                column: "CityGUID",
                value: new Guid("18382443-a3ed-4a81-abf2-1983f61ff8b4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 158,
                column: "CityGUID",
                value: new Guid("6bdeee05-aabe-4bd8-a93f-192a67ac7ddd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 159,
                column: "CityGUID",
                value: new Guid("884a40be-e1b1-46ea-b274-3561fb74511c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 160,
                column: "CityGUID",
                value: new Guid("30ba61e0-f84f-47f4-b23b-b3f19482f76d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 161,
                column: "CityGUID",
                value: new Guid("e02a1456-f1e9-4c3e-8f72-b94541f6d4e9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 162,
                column: "CityGUID",
                value: new Guid("0179a286-f4d7-4a28-b41a-15b52881f4d2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 163,
                column: "CityGUID",
                value: new Guid("d64bf568-003e-4322-b30e-30421fe7c54c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 164,
                column: "CityGUID",
                value: new Guid("52b6fdb4-9746-4e7b-b3c5-8cf60772f6d4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 165,
                column: "CityGUID",
                value: new Guid("6ee96435-c1b0-4465-93c5-1637d0191e7f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 166,
                column: "CityGUID",
                value: new Guid("fe70d18d-cd04-4051-8f19-7b0127699324"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 167,
                column: "CityGUID",
                value: new Guid("7e94478a-26b4-4d66-a145-3ce08437a8e3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 168,
                column: "CityGUID",
                value: new Guid("b5e7ad8f-d659-4bfa-aaef-79a91cf09e00"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 169,
                column: "CityGUID",
                value: new Guid("c43e626e-a977-47f9-ba6b-04766a0df20b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 170,
                column: "CityGUID",
                value: new Guid("44e892cb-d1da-4a64-a0e5-3d4a35524dcb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 171,
                column: "CityGUID",
                value: new Guid("cc526848-074d-465a-92da-62eea2223e5d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 172,
                column: "CityGUID",
                value: new Guid("8f1dc917-dbea-4a82-ba67-55b23b8c8695"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 173,
                column: "CityGUID",
                value: new Guid("f32fd091-cf1e-4039-876a-5e6f6e8196bd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 174,
                column: "CityGUID",
                value: new Guid("6d1d885a-267a-433c-b1a4-e980dc4c0fec"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 175,
                column: "CityGUID",
                value: new Guid("b5df183d-78ee-4f02-86b2-611d8ce32a18"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 176,
                column: "CityGUID",
                value: new Guid("df094c9e-fe17-41e3-a66f-2d298741b2b5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 177,
                column: "CityGUID",
                value: new Guid("f794e614-8c0e-4e7e-aa23-3c1cc18ff11f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 178,
                column: "CityGUID",
                value: new Guid("9277611d-c0c2-4fa6-b559-723bbb508dd0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 179,
                column: "CityGUID",
                value: new Guid("1f8a7113-9159-4db9-b668-7f46b0df71a4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 180,
                column: "CityGUID",
                value: new Guid("b1fac9ad-6c4b-4e18-8d88-bfff27f38ca4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 181,
                column: "CityGUID",
                value: new Guid("a28586db-8d26-4f69-bb16-9288e12cd178"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 182,
                column: "CityGUID",
                value: new Guid("e92fff5d-f71e-46d4-9b2e-ffb0eda4ee81"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 183,
                column: "CityGUID",
                value: new Guid("ffd6e6d4-84f3-4093-ba1a-c7c4197210ea"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 184,
                column: "CityGUID",
                value: new Guid("276ee39f-f408-4bf6-8651-a43aee88db09"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 185,
                column: "CityGUID",
                value: new Guid("be593a92-a273-4e51-be0b-9bf91504b7ca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 186,
                column: "CityGUID",
                value: new Guid("5363356b-35c9-4291-8dc9-093bc5969273"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 187,
                column: "CityGUID",
                value: new Guid("bc839627-1291-44e8-bd97-7da896bd0c71"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 188,
                column: "CityGUID",
                value: new Guid("01b9ea9b-8f82-44e2-93dd-3de4de23bee4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 189,
                column: "CityGUID",
                value: new Guid("82021b64-4d97-4da4-b8e5-b69f0d228536"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 190,
                column: "CityGUID",
                value: new Guid("83c4b2c5-2237-4e4f-b1a6-951acb037e39"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 191,
                column: "CityGUID",
                value: new Guid("2697bf05-95cb-4c33-ba66-c9bf2fd200f7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 192,
                column: "CityGUID",
                value: new Guid("bb6ce640-6462-4d27-91fd-7b58334a2ff9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 193,
                column: "CityGUID",
                value: new Guid("9fbf7a45-a1f1-4503-a3de-3b12fb65b75a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 194,
                column: "CityGUID",
                value: new Guid("38ab41b4-8319-4adf-9a64-549a733c8790"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 195,
                column: "CityGUID",
                value: new Guid("150f1e1a-d791-44ed-92c8-26c1ad4f5b96"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 196,
                column: "CityGUID",
                value: new Guid("ad3d60af-5aa1-4b7b-bb1b-bf1c0fe530ac"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 197,
                column: "CityGUID",
                value: new Guid("fc8ecab3-ae44-45ec-b7d3-a1d622dfda30"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 198,
                column: "CityGUID",
                value: new Guid("609b7a15-75d9-4937-b49e-6d3d838f2ebc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 199,
                column: "CityGUID",
                value: new Guid("982e790a-e92c-4001-aad9-0e13746ff2db"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 200,
                column: "CityGUID",
                value: new Guid("dcaac28e-f2be-4a6a-aca0-3ab5e4576015"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 201,
                column: "CityGUID",
                value: new Guid("203d19cb-41e8-4c0b-a621-542f256b0226"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 202,
                column: "CityGUID",
                value: new Guid("10bcc6e6-974b-4bf2-bb02-3fc45a9eb355"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 203,
                column: "CityGUID",
                value: new Guid("52baeb13-ba05-4d73-9029-c60efa7e8f29"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 204,
                column: "CityGUID",
                value: new Guid("dbb1da97-d784-4e02-ab92-66780ffe3232"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 205,
                column: "CityGUID",
                value: new Guid("e73f3495-8212-4946-97df-21c366eef364"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 206,
                column: "CityGUID",
                value: new Guid("6870cefd-903f-48e7-b549-66fd08f86101"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 207,
                column: "CityGUID",
                value: new Guid("d6a7b4c3-fb30-469f-a3f2-b70ffb4672c6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 208,
                column: "CityGUID",
                value: new Guid("5b5b2fca-3a2c-4d46-a744-9b958b9c31bb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 209,
                column: "CityGUID",
                value: new Guid("0d8b423b-ebca-4636-9ab3-bfbaf5a78a5a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 210,
                column: "CityGUID",
                value: new Guid("63245123-59c9-4958-9a57-c95f087f5609"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 211,
                column: "CityGUID",
                value: new Guid("a4fd68b6-ca69-4297-aaf5-d0077749e0e4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 212,
                column: "CityGUID",
                value: new Guid("505b3d9a-5bac-455a-9ffb-8d48afa980b0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 213,
                column: "CityGUID",
                value: new Guid("66d02b80-b260-4f2c-a193-006b71c82118"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 214,
                column: "CityGUID",
                value: new Guid("c79e3b35-a09c-4e16-b1fe-72ea513ea45d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 215,
                column: "CityGUID",
                value: new Guid("936a3605-993d-474f-8f4a-b355db819526"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 216,
                column: "CityGUID",
                value: new Guid("0138cc5e-8462-46a1-9eea-aba535b6628e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 217,
                column: "CityGUID",
                value: new Guid("d859ff3f-4d37-4cec-a9d3-ef2f09c403e2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 218,
                column: "CityGUID",
                value: new Guid("e011bbf2-783b-46a9-b09d-2a03e6afa396"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 219,
                column: "CityGUID",
                value: new Guid("0a390078-e384-4854-ac0b-fb920a065aa0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 220,
                column: "CityGUID",
                value: new Guid("b275d3b8-5562-46c8-b693-257b458b0e92"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 221,
                column: "CityGUID",
                value: new Guid("15154269-2d67-416b-9211-d18b6cec210e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 222,
                column: "CityGUID",
                value: new Guid("ae53250d-2cb8-4864-90e8-38af96aaa398"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 223,
                column: "CityGUID",
                value: new Guid("0c955d0a-be57-449e-b475-06ffb88fb131"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 224,
                column: "CityGUID",
                value: new Guid("21741fc3-88fb-4a55-852e-11f5279c19a1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 225,
                column: "CityGUID",
                value: new Guid("d9312e3f-a460-400e-9c5b-344d9576b522"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 226,
                column: "CityGUID",
                value: new Guid("16d97f53-aada-4a2b-8da4-bf661bc1a258"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 227,
                column: "CityGUID",
                value: new Guid("53ffe797-8d9c-408a-a56c-7025515bfda8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 228,
                column: "CityGUID",
                value: new Guid("dc029989-869e-4dc8-b710-c8dced3380d3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 229,
                column: "CityGUID",
                value: new Guid("2c5c3d0b-1f4b-46f1-8f6b-14a333ce895e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 230,
                column: "CityGUID",
                value: new Guid("18d32661-9a0a-4625-a5a4-8f8846d39ba1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 231,
                column: "CityGUID",
                value: new Guid("321f77db-8505-470e-b147-30b958454181"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 232,
                column: "CityGUID",
                value: new Guid("99a129a3-a5da-4921-9ae9-fa74112a3c44"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 233,
                column: "CityGUID",
                value: new Guid("5b2b8f9c-8444-485d-bc0b-cebef42c5261"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 234,
                column: "CityGUID",
                value: new Guid("2680d00e-a04f-427e-b5dd-d3f7be984146"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 235,
                column: "CityGUID",
                value: new Guid("fcee6a14-0ea5-498b-b63e-d6e29c34c5ef"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 236,
                column: "CityGUID",
                value: new Guid("859377fc-1b0f-4ec2-aae0-dbe554c140e7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 237,
                column: "CityGUID",
                value: new Guid("641dac21-2bd6-4584-ab31-ecb6409aecf6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 238,
                column: "CityGUID",
                value: new Guid("c67e6faf-dc0d-48e4-9e43-f512093e7622"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 239,
                column: "CityGUID",
                value: new Guid("3d66dcb9-d0d1-493d-a865-a0c55d7788e9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 240,
                column: "CityGUID",
                value: new Guid("0925138b-c034-4176-8b12-6c4157550070"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 241,
                column: "CityGUID",
                value: new Guid("f44481b3-016b-499b-8e50-6ca18a21d968"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 242,
                column: "CityGUID",
                value: new Guid("1b3049bf-b7c4-4f4a-963a-87d406e08b72"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 243,
                column: "CityGUID",
                value: new Guid("260360d7-57c5-4591-a6f5-dbe820005b00"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 244,
                column: "CityGUID",
                value: new Guid("1a9dbfb5-0eb3-4dd7-a2f3-bfa34e8759dd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 245,
                column: "CityGUID",
                value: new Guid("0664e4af-26ab-4fcf-998d-1eac6edb4955"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 246,
                column: "CityGUID",
                value: new Guid("df0f292c-7f8b-4f5a-9700-74ebbe899918"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 247,
                column: "CityGUID",
                value: new Guid("2dfd2aa2-b069-40ae-a4ed-da3e57bbe2e3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 248,
                column: "CityGUID",
                value: new Guid("24cd3456-376e-49a5-8f7d-20102fc12714"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 249,
                column: "CityGUID",
                value: new Guid("b66eb8d9-a7b4-4856-bea4-d1fe23f6fe06"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 250,
                column: "CityGUID",
                value: new Guid("1d2d01f1-4d6e-4992-9756-9047f7f42fb9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 251,
                column: "CityGUID",
                value: new Guid("6298b300-9cfc-4d9c-a806-9a6e1405481d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 252,
                column: "CityGUID",
                value: new Guid("b167423c-c064-40f2-94a3-5bf1a87f2693"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 253,
                column: "CityGUID",
                value: new Guid("c780054f-97f3-4cf0-82eb-1ac139eb076c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 254,
                column: "CityGUID",
                value: new Guid("22837441-152e-4b0d-bbd7-b865987930f1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 255,
                column: "CityGUID",
                value: new Guid("7bc6c36b-3078-4a3b-91a4-07fb2065dcbf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 256,
                column: "CityGUID",
                value: new Guid("64ff2f86-4fdb-4295-98df-2376d7b872aa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 257,
                column: "CityGUID",
                value: new Guid("c9ed924c-dada-445d-8ec0-0227d9779a2a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 258,
                column: "CityGUID",
                value: new Guid("eb290d8e-cc29-473b-ad54-f66e8fadc4fe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 259,
                column: "CityGUID",
                value: new Guid("d3f892f4-9ae8-4da2-a7a4-a7f5a433417b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 260,
                column: "CityGUID",
                value: new Guid("cb04f6f1-8aed-4078-956a-b958e8612025"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 261,
                column: "CityGUID",
                value: new Guid("2e79f82a-4fba-43e1-8e5a-cda9f9fce7fe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 262,
                column: "CityGUID",
                value: new Guid("4cb63f83-c897-4607-b08d-03320d1934a1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 263,
                column: "CityGUID",
                value: new Guid("bd59aab3-1766-4e90-bb97-e6edb94cf71f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 264,
                column: "CityGUID",
                value: new Guid("f71288c1-59fe-43d0-8a2f-72124e10c6a1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 265,
                column: "CityGUID",
                value: new Guid("20750f49-d1a9-4e5e-baf4-63f0f7867177"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 266,
                column: "CityGUID",
                value: new Guid("c483b742-65c0-49b5-a7b5-2663975a5071"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 267,
                column: "CityGUID",
                value: new Guid("607b1e40-49a4-418d-a291-3e00f70cff6c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 268,
                column: "CityGUID",
                value: new Guid("893d5a45-abcb-4470-895d-c5ad8009067f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 269,
                column: "CityGUID",
                value: new Guid("57f57d62-ae5e-473a-890d-07bb4da18283"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 270,
                column: "CityGUID",
                value: new Guid("643b7683-0409-4a4b-bd07-f99e122215cc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 271,
                column: "CityGUID",
                value: new Guid("e206d20e-ed13-4cc6-9846-f96618097eeb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 272,
                column: "CityGUID",
                value: new Guid("66931f7e-649a-462e-9506-636e8ad8e4dc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 273,
                column: "CityGUID",
                value: new Guid("7cf3f985-5f1d-42b7-aaf4-b1b1990717f0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 274,
                column: "CityGUID",
                value: new Guid("4078b28e-cd5f-4b07-a361-e551f7589247"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 275,
                column: "CityGUID",
                value: new Guid("8c58afec-1f76-449d-90e9-b8f256c08afc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 276,
                column: "CityGUID",
                value: new Guid("481cd2c8-bd68-406e-b325-29ab17e88632"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 277,
                column: "CityGUID",
                value: new Guid("25a8576b-dc26-4fc8-8e9b-35c9989054e7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 278,
                column: "CityGUID",
                value: new Guid("4844ae01-4b26-4a98-91f9-d300666943a0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 279,
                column: "CityGUID",
                value: new Guid("5b609c43-a215-40de-bc62-b851f8c8d680"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 280,
                column: "CityGUID",
                value: new Guid("28f6df2e-f58c-4dc8-aaff-32db38ed978b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 281,
                column: "CityGUID",
                value: new Guid("341c6069-150c-46a9-81bf-07e3a1bc0173"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 282,
                column: "CityGUID",
                value: new Guid("108c6359-1df9-455b-9b2f-c2e5c832b2cc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 283,
                column: "CityGUID",
                value: new Guid("b3384481-e42c-4ef6-998b-3170b60b2bf5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 284,
                column: "CityGUID",
                value: new Guid("e2891149-6de7-4f80-9a9f-0d57c8d090c3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 285,
                column: "CityGUID",
                value: new Guid("3235d830-8109-4855-8532-8e5ea926f838"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 286,
                column: "CityGUID",
                value: new Guid("ad27d529-a5ff-4839-90aa-44ae114df72c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 287,
                column: "CityGUID",
                value: new Guid("23c42ea7-5ba3-4d1b-ae00-6548a04dfbcc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 288,
                column: "CityGUID",
                value: new Guid("e6165d91-9763-4bfc-8159-2e9a507087e5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 289,
                column: "CityGUID",
                value: new Guid("d01af100-9390-4562-b904-992af15ed901"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 290,
                column: "CityGUID",
                value: new Guid("c42b17da-0824-469d-9ada-4c47a4d324ad"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 291,
                column: "CityGUID",
                value: new Guid("db46a188-322c-49df-92a4-6a923d954169"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 292,
                column: "CityGUID",
                value: new Guid("6957de5b-689a-4495-a258-c8ddc5b3b038"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 293,
                column: "CityGUID",
                value: new Guid("2dbd45b5-a168-40f0-bb9a-267b1815a5ea"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 294,
                column: "CityGUID",
                value: new Guid("c9ec5f36-965b-49b1-9fe0-06e4740fe4e2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 295,
                column: "CityGUID",
                value: new Guid("88841305-29a2-406c-80d4-054277d48ef6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 296,
                column: "CityGUID",
                value: new Guid("cccb7331-38b2-4b8f-8c17-6d2f0c761fdb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 297,
                column: "CityGUID",
                value: new Guid("b9b64553-c9c6-4b09-ba0e-7677deee3211"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 298,
                column: "CityGUID",
                value: new Guid("6cb03d87-9337-49f5-afef-9f3b9f34a30e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 299,
                column: "CityGUID",
                value: new Guid("b5907040-ef58-4a3d-a86f-cd5974833e00"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 300,
                column: "CityGUID",
                value: new Guid("82fa514b-2cb6-44fb-8cee-0fb75cb33376"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 301,
                column: "CityGUID",
                value: new Guid("63faa4e6-c374-45c8-b260-9ba77458647c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 302,
                column: "CityGUID",
                value: new Guid("9561b3c4-53f9-4dd1-81ec-4fd90aed658d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 303,
                column: "CityGUID",
                value: new Guid("25472dde-cdbe-4ab2-a072-5f5a2f6d6f92"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 304,
                column: "CityGUID",
                value: new Guid("8a2afaf4-250a-41aa-9429-67e4623ab2c1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 305,
                column: "CityGUID",
                value: new Guid("181c32b4-e42a-4e07-96a4-e72888efee7e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 306,
                column: "CityGUID",
                value: new Guid("b7e394e0-01d8-4c0f-93ae-8b660a414fc9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 307,
                column: "CityGUID",
                value: new Guid("e078d825-aa26-4edd-85af-6cf8bd356838"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 308,
                column: "CityGUID",
                value: new Guid("ec582f7d-250f-4009-9c79-d4286b5e41cf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 309,
                column: "CityGUID",
                value: new Guid("9108b37d-eace-4ede-a87b-02e8206001d5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 310,
                column: "CityGUID",
                value: new Guid("61225f3f-db57-4ce8-b925-f5301d73549b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 311,
                column: "CityGUID",
                value: new Guid("e96b6314-effe-4fbe-a12d-9fd284a14503"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 312,
                column: "CityGUID",
                value: new Guid("36a2e787-3c67-42aa-9200-0e394cb58d65"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 313,
                column: "CityGUID",
                value: new Guid("80be8d7d-f3c4-4d85-838a-85d368ac7e29"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 314,
                column: "CityGUID",
                value: new Guid("14c3677c-ad9d-4cdc-bc13-7cc3d226aba0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 315,
                column: "CityGUID",
                value: new Guid("f5a11650-7a70-4b34-b3b8-f52c3d2ca8cd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 316,
                column: "CityGUID",
                value: new Guid("1209472f-da5d-4ed4-b497-864bb439ce2c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 317,
                column: "CityGUID",
                value: new Guid("3088151c-4d46-4a37-8424-b14b7ebc35c2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 318,
                column: "CityGUID",
                value: new Guid("1e362f59-c16b-4eff-a522-6a45781948f2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 319,
                column: "CityGUID",
                value: new Guid("5d93a7aa-cb23-45cd-b454-b0d428b7cfb2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 320,
                column: "CityGUID",
                value: new Guid("6b8d721c-f206-404b-8b43-db595f931263"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 321,
                column: "CityGUID",
                value: new Guid("298fbcf5-0ed4-4457-a5e6-4b651c5d1128"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 322,
                column: "CityGUID",
                value: new Guid("d1797f3b-f78e-4ad6-8ed4-0ab8250edcff"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 323,
                column: "CityGUID",
                value: new Guid("6c7f7f11-db31-443a-a786-05fb0313d1b7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 324,
                column: "CityGUID",
                value: new Guid("4fc3c40e-2e2a-4a5f-9238-eb38966fe9de"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 325,
                column: "CityGUID",
                value: new Guid("9bf3e724-8b7c-48d9-81d0-152683a1a3af"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 326,
                column: "CityGUID",
                value: new Guid("5d81721e-a94c-4b3c-aa47-e5d941c591e3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 327,
                column: "CityGUID",
                value: new Guid("7be65f74-1dfe-475c-8410-985c29ae4dde"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 328,
                column: "CityGUID",
                value: new Guid("8ebcdca9-56e2-462e-9e0c-5a4454b14d34"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 329,
                column: "CityGUID",
                value: new Guid("3857ac1e-817b-4ba1-87e3-5c3f4073fbf6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 330,
                column: "CityGUID",
                value: new Guid("59c7ef57-77df-4745-ad99-27410c44a2a2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 331,
                column: "CityGUID",
                value: new Guid("17ee2d2a-8b31-48e2-9cb9-f633772eb25a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 332,
                column: "CityGUID",
                value: new Guid("3f79cbee-e739-4e51-89b4-e16b5c7de4b6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 333,
                column: "CityGUID",
                value: new Guid("91f7106a-66dc-4381-b5b9-3e2cb1fd4cda"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 334,
                column: "CityGUID",
                value: new Guid("b8246381-a11f-4d15-bfe1-1de4aa024ca4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 335,
                column: "CityGUID",
                value: new Guid("c8849a94-a898-4d7c-9862-8d5d659810e5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 336,
                column: "CityGUID",
                value: new Guid("31a0e4fc-46ce-4380-9f09-41f7881ce63c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 337,
                column: "CityGUID",
                value: new Guid("fe7025ab-175c-475f-a144-df97d559d8b4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 338,
                column: "CityGUID",
                value: new Guid("28f438bb-28c0-40cb-9324-b23a50c44c37"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 339,
                column: "CityGUID",
                value: new Guid("ae498cce-28ba-4fa0-b053-88e6a73d20a6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 340,
                column: "CityGUID",
                value: new Guid("99e60888-f66a-46cf-9d18-347df6ef0260"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 341,
                column: "CityGUID",
                value: new Guid("955238ea-a717-4642-8f88-0c4bd96eb97c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 342,
                column: "CityGUID",
                value: new Guid("6d42250e-17c2-454b-934d-0851eb266ab1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 343,
                column: "CityGUID",
                value: new Guid("ca9eacdf-758c-4c6c-b530-39ce10e21f47"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 344,
                column: "CityGUID",
                value: new Guid("17b92cf2-f623-47a7-9af8-6fb778dbdfa6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 345,
                column: "CityGUID",
                value: new Guid("7c4676f0-3687-4a1f-b8f6-ae51b7dc3230"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 346,
                column: "CityGUID",
                value: new Guid("4c7e865f-d539-44e8-8436-102743fd86f9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 347,
                column: "CityGUID",
                value: new Guid("5533d8cd-a357-4d80-bfe6-d08f32f77289"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 348,
                column: "CityGUID",
                value: new Guid("075f8d98-8588-4b8e-91fc-4fcbb36931ac"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 349,
                column: "CityGUID",
                value: new Guid("ce3bdd63-fc8f-49f3-af42-7224a176cdf7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 350,
                column: "CityGUID",
                value: new Guid("347f29af-454b-450e-a16f-71bb7241024e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 351,
                column: "CityGUID",
                value: new Guid("cef76d51-9f0a-4889-adbf-7465f147cde1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 352,
                column: "CityGUID",
                value: new Guid("a2eb37fa-3eb5-4347-9785-0cfbc66f4aa4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 353,
                column: "CityGUID",
                value: new Guid("d8fe7170-2214-4678-95b9-99aa81847620"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 354,
                column: "CityGUID",
                value: new Guid("68219e5d-9cd5-4539-bf29-efbffaaeb781"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 355,
                column: "CityGUID",
                value: new Guid("1354c67c-a31d-4fd5-b91d-47f5fd02b982"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 356,
                column: "CityGUID",
                value: new Guid("b06ef854-6161-4070-a9b4-6b654bc7eb84"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 357,
                column: "CityGUID",
                value: new Guid("ef0babdf-792e-4b23-886b-57938505455f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 358,
                column: "CityGUID",
                value: new Guid("62ea5c2b-5415-4886-8059-165f69699315"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 359,
                column: "CityGUID",
                value: new Guid("f7d1c941-e9df-4f45-9dd4-d08d620c156f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 360,
                column: "CityGUID",
                value: new Guid("e1cbf8c6-d7b7-46c5-a76b-a55c444ce977"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 361,
                column: "CityGUID",
                value: new Guid("4ef56324-de49-4e9d-9970-7e39854938ad"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 362,
                column: "CityGUID",
                value: new Guid("184f10e9-089d-4a31-b6e2-be14c5e7223d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 363,
                column: "CityGUID",
                value: new Guid("0f36a3d1-01a5-4a64-b96d-c9396faa2d8b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 364,
                column: "CityGUID",
                value: new Guid("8a9be8eb-29b9-4227-aac5-320f97034b15"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 365,
                column: "CityGUID",
                value: new Guid("0b0eef75-ec83-40b5-87c7-9bc1449e37bd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 366,
                column: "CityGUID",
                value: new Guid("d9a21b95-7acc-4321-a211-ef1919c214d0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 367,
                column: "CityGUID",
                value: new Guid("e0713b1d-5537-443a-b298-dccaf5c86978"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 368,
                column: "CityGUID",
                value: new Guid("a4d3adb0-b594-4b8c-b5c1-7545357a66c0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 369,
                column: "CityGUID",
                value: new Guid("2660a288-05d3-4e58-8a5a-463a26eebd35"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 370,
                column: "CityGUID",
                value: new Guid("940982e1-520d-452e-9fa0-02494a32cfe7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 371,
                column: "CityGUID",
                value: new Guid("25349167-6b5d-42b4-a069-fd10e25b985e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 372,
                column: "CityGUID",
                value: new Guid("76db7adf-3a2e-4458-9063-67f4b5bfcb34"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 373,
                column: "CityGUID",
                value: new Guid("78f9fd54-0a32-4745-a96c-d78312305898"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 374,
                column: "CityGUID",
                value: new Guid("8006efb0-e5d8-4519-ae9d-d4c36f2aeb67"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 375,
                column: "CityGUID",
                value: new Guid("3ac6a8ed-0f1f-48bf-bc33-71c62337d38e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 376,
                column: "CityGUID",
                value: new Guid("dfbbba1b-b6e7-454c-be63-053491402bd4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 377,
                column: "CityGUID",
                value: new Guid("545a6a1e-7bce-40a8-b0bd-760df635d55f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 378,
                column: "CityGUID",
                value: new Guid("cefd436b-515a-463e-8c7e-1e762a590e1b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 379,
                column: "CityGUID",
                value: new Guid("dfed319e-ef8a-4eb7-b7ac-0c04ccdfdeb3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 380,
                column: "CityGUID",
                value: new Guid("88fe73d5-fb34-4066-a397-39bdf87cec52"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 381,
                column: "CityGUID",
                value: new Guid("d3259860-6f32-465b-9ffa-f59f1bfa9576"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 382,
                column: "CityGUID",
                value: new Guid("4c5bffd2-bb02-4d14-86be-91e220f8aa1c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 383,
                column: "CityGUID",
                value: new Guid("90abb0cd-3e8d-4e10-80a8-d46ae6b8625e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 384,
                column: "CityGUID",
                value: new Guid("ba556aa8-4c62-49ca-bca6-ac26de0089de"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 385,
                column: "CityGUID",
                value: new Guid("bd4750fd-67f8-43b1-9de8-bf2178136305"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 386,
                column: "CityGUID",
                value: new Guid("dec1e566-877b-4fa7-b7b0-0ea361f763d2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 387,
                column: "CityGUID",
                value: new Guid("bf2c2a05-efb3-4dd8-9ef9-bc7810521ffa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 388,
                column: "CityGUID",
                value: new Guid("33ca3577-16d7-4815-98fc-d920b49db9a0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 389,
                column: "CityGUID",
                value: new Guid("23aabe83-1620-46d7-87d5-3f841749b136"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 390,
                column: "CityGUID",
                value: new Guid("a7061ccd-0da7-4ce7-ae83-dff9f4f2388b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 391,
                column: "CityGUID",
                value: new Guid("7f098e72-f46b-4c92-b156-c78507a4796d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 392,
                column: "CityGUID",
                value: new Guid("01d20c43-3610-4474-9daa-9696949ae518"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 393,
                column: "CityGUID",
                value: new Guid("788e060e-14b7-466a-ae8a-36257a1c547d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 394,
                column: "CityGUID",
                value: new Guid("73739437-0628-4528-a120-3570767ac450"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 395,
                column: "CityGUID",
                value: new Guid("a0215eff-0a56-4704-a6cb-87f74e273ee6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 396,
                column: "CityGUID",
                value: new Guid("fb1919e9-3343-44aa-ac8d-0817b961a7b6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 397,
                column: "CityGUID",
                value: new Guid("c06c8922-6052-4552-b614-59677c5a3cd3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 398,
                column: "CityGUID",
                value: new Guid("5041e6a9-21db-4e3b-9cd0-ffd3f0f7912d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 399,
                column: "CityGUID",
                value: new Guid("74429b2b-87d8-41b6-abbf-a3919ef6a5ac"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 400,
                column: "CityGUID",
                value: new Guid("c61cf4ef-ce11-4ca2-9769-921b0011bc3f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 401,
                column: "CityGUID",
                value: new Guid("5c4f6f75-0993-4c07-b56c-823aad82df30"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 402,
                column: "CityGUID",
                value: new Guid("e2cfb040-ff13-4096-baa4-a1920afa07e2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 403,
                column: "CityGUID",
                value: new Guid("058f88d7-98b3-4968-913d-f1e2bc2a8316"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 404,
                column: "CityGUID",
                value: new Guid("47b32e9e-8131-40ad-a674-6fe1786d71a1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 405,
                column: "CityGUID",
                value: new Guid("a058c5bd-dabd-409a-bcc9-9159a780af6d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 406,
                column: "CityGUID",
                value: new Guid("f1735bfa-1070-4054-b2cf-1ab97e7aa31e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 407,
                column: "CityGUID",
                value: new Guid("7ca8c910-9c7a-4fe5-8284-26c998c3387f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 408,
                column: "CityGUID",
                value: new Guid("f7ad8d2a-04b9-4661-8461-f60fb539a773"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 409,
                column: "CityGUID",
                value: new Guid("1902c19d-af8b-4422-a75e-1b5ee4b24bb8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 410,
                column: "CityGUID",
                value: new Guid("0927d7dd-3d4b-4d2c-99a1-7ce84f8bf4e6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 411,
                column: "CityGUID",
                value: new Guid("0d536618-e537-49dd-8f1a-0af2d4239969"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 412,
                column: "CityGUID",
                value: new Guid("4d1cfad7-a985-4df9-af56-978e74651817"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 413,
                column: "CityGUID",
                value: new Guid("04f22488-7c21-4a8c-bca9-7a7a54ee0190"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 414,
                column: "CityGUID",
                value: new Guid("96165b10-eb01-4e4f-8431-1b5cdfefb95e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 415,
                column: "CityGUID",
                value: new Guid("aba3740e-69fb-43f9-a81b-76ec1c123944"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 416,
                column: "CityGUID",
                value: new Guid("7c5be289-253b-49ce-9c08-67782965bc4f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 417,
                column: "CityGUID",
                value: new Guid("995fc366-d396-4b9b-8599-cd6c053d7136"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 418,
                column: "CityGUID",
                value: new Guid("9467c1ca-cc51-4a33-b393-df5fa8c3c0fa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 419,
                column: "CityGUID",
                value: new Guid("f312b990-632a-4f7c-803d-dcd155263e24"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 420,
                column: "CityGUID",
                value: new Guid("a98dcb2b-f3a4-489c-84c6-63f8d9f1f1e2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 421,
                column: "CityGUID",
                value: new Guid("68c50e5d-f7d6-4f14-8707-9449f9f41bb1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 422,
                column: "CityGUID",
                value: new Guid("2e129ef9-4b73-4f25-89c9-010c578b1fca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 423,
                column: "CityGUID",
                value: new Guid("20654350-5637-4daf-99fb-307eb259e341"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 424,
                column: "CityGUID",
                value: new Guid("dd1a4ef8-3fbf-45b1-a9e4-158eed9d6b59"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 425,
                column: "CityGUID",
                value: new Guid("a5818607-18de-4f98-a8d8-9ef6dcf605ae"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 426,
                column: "CityGUID",
                value: new Guid("6e9655b6-0275-4701-a7b5-2ee706c2a052"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 427,
                column: "CityGUID",
                value: new Guid("1de0b2be-bbe3-41bd-9a74-e7f3db1ad805"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 428,
                column: "CityGUID",
                value: new Guid("53b4d977-771e-4b53-ac20-d9557780592c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 429,
                column: "CityGUID",
                value: new Guid("af632479-46a7-4005-8789-cd82d7a00cad"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 430,
                column: "CityGUID",
                value: new Guid("0d91907b-73bf-4c1d-8a64-d9892fd17b93"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 431,
                column: "CityGUID",
                value: new Guid("e13b8af1-85f6-411f-be4a-85da61c86029"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 432,
                column: "CityGUID",
                value: new Guid("9777d4b2-715b-4aea-aa89-1e9967a25e97"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 433,
                column: "CityGUID",
                value: new Guid("b8573d92-69fd-46df-8214-242f74551b5a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 434,
                column: "CityGUID",
                value: new Guid("534753db-db0a-4c46-8475-79a2249ecab8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 435,
                column: "CityGUID",
                value: new Guid("8b8d4728-7ae1-4826-9aea-a47a708ab7e5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 436,
                column: "CityGUID",
                value: new Guid("82357438-504a-496f-9bbf-fec1616acde2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 437,
                column: "CityGUID",
                value: new Guid("680d08e4-2f20-49dd-98ae-7596b4569007"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 438,
                column: "CityGUID",
                value: new Guid("f089d0f2-14a7-4cd9-8838-1c475b139d09"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 439,
                column: "CityGUID",
                value: new Guid("3bcd816f-9eff-4aca-9820-ad741adf340b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 440,
                column: "CityGUID",
                value: new Guid("5e4e5b1c-de96-45aa-b556-64e4cbaf75dd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 441,
                column: "CityGUID",
                value: new Guid("73ca203b-3bdf-4cd0-b03d-81ce20286065"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 442,
                column: "CityGUID",
                value: new Guid("b11671d3-7ef3-461f-9cc0-fc46d34553f5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 443,
                column: "CityGUID",
                value: new Guid("976ef411-3a5f-4e65-a328-4810e3e746fa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 444,
                column: "CityGUID",
                value: new Guid("a39a49b3-14a6-4b3e-a22f-c615ec65ff9c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 445,
                column: "CityGUID",
                value: new Guid("d5611fe9-91af-445d-919a-227889f2793f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 446,
                column: "CityGUID",
                value: new Guid("47e620cb-15c7-4248-9a7d-2c0394e046a6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 447,
                column: "CityGUID",
                value: new Guid("049e12bc-67ea-4ae8-957e-a90ab7fd25c0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 448,
                column: "CityGUID",
                value: new Guid("4f97f015-2805-484e-81a8-fa95419e65df"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 449,
                column: "CityGUID",
                value: new Guid("ee9a5180-0a1a-4b5b-8da2-25df7912ac89"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 450,
                column: "CityGUID",
                value: new Guid("bf01b3c2-878c-4481-bc72-969a9cfcfeaa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 451,
                column: "CityGUID",
                value: new Guid("d62498fa-d66f-4be7-9ce9-76a57a73c1f9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 452,
                column: "CityGUID",
                value: new Guid("0c75285b-b292-484f-a978-99c0874741b8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 453,
                column: "CityGUID",
                value: new Guid("8a3f8af6-f172-47d2-9e9b-bd72e5352540"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 454,
                column: "CityGUID",
                value: new Guid("97450498-2825-4807-8eba-e3e4f4f44a8d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 455,
                column: "CityGUID",
                value: new Guid("4ba8eb90-117b-48df-aa30-c19d10b93603"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 456,
                column: "CityGUID",
                value: new Guid("c6256705-d4c6-4f95-816f-8ae293d72718"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 457,
                column: "CityGUID",
                value: new Guid("2f188419-5f9f-45de-b64f-a01c94c23d3c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 458,
                column: "CityGUID",
                value: new Guid("e6ec9f7c-3574-442b-8c4b-1febd313e74a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 459,
                column: "CityGUID",
                value: new Guid("88ffeb4a-26f4-4cfc-9f8e-c401fec1f17b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 460,
                column: "CityGUID",
                value: new Guid("f15f25e3-cfc7-46e6-9b05-95439774220c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 461,
                column: "CityGUID",
                value: new Guid("502cae0e-1174-452f-9012-78649bd1cbe2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 462,
                column: "CityGUID",
                value: new Guid("53422b44-442c-417a-a4b9-0acb1e895291"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 463,
                column: "CityGUID",
                value: new Guid("fba5c0c7-fe6b-4590-9bc0-b0a7f8584cd4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 464,
                column: "CityGUID",
                value: new Guid("aeb83d9c-6cc0-40cc-8f48-17c4af56fd72"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 465,
                column: "CityGUID",
                value: new Guid("fcfcac33-6223-4c81-8e04-6ef2671e2077"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 466,
                column: "CityGUID",
                value: new Guid("08924779-1df7-40c0-8cda-d80add4cccba"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 467,
                column: "CityGUID",
                value: new Guid("247f47be-00f5-4b5c-be01-ca149f2be679"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 468,
                column: "CityGUID",
                value: new Guid("5399009e-93d0-48fd-8e83-3f3a627a03fd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 469,
                column: "CityGUID",
                value: new Guid("1bb1db33-a844-4233-ad1c-a86af622fd45"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 470,
                column: "CityGUID",
                value: new Guid("402e8d59-38ff-4ff6-8611-caaa52617fd4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 471,
                column: "CityGUID",
                value: new Guid("570be778-8847-441f-bb18-9184ce03ce6e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 472,
                column: "CityGUID",
                value: new Guid("f6fda67c-a862-4c60-8bc9-1633e6dc9212"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 473,
                column: "CityGUID",
                value: new Guid("7611f4ed-3d79-494e-be06-e3efa0817513"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 474,
                column: "CityGUID",
                value: new Guid("afe85315-2ebd-48e1-aabe-f2d902963afc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 475,
                column: "CityGUID",
                value: new Guid("a2a2e50d-e459-4a46-9e61-7a55ceee4290"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 476,
                column: "CityGUID",
                value: new Guid("7ce4e285-6821-43e4-b8a4-73d4ec4333b5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 477,
                column: "CityGUID",
                value: new Guid("583bbe68-c9d0-4d4d-b501-71d532f120c7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 478,
                column: "CityGUID",
                value: new Guid("d135c618-012d-46e5-8133-b9e248b32734"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 479,
                column: "CityGUID",
                value: new Guid("1c7540a0-6439-4595-b208-e6177621f4c2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 480,
                column: "CityGUID",
                value: new Guid("0823e526-a64f-43f7-b2a4-5ea8d8c7ce55"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 481,
                column: "CityGUID",
                value: new Guid("bf7624e7-ca43-41f6-8368-2bbbdef450fc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 482,
                column: "CityGUID",
                value: new Guid("176d8964-deab-4ed5-aa52-c6e69fe28ff2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 483,
                column: "CityGUID",
                value: new Guid("2f8c8a27-59a0-48c4-841d-c4abbb3e1635"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 484,
                column: "CityGUID",
                value: new Guid("3e034dbc-d764-436d-b89c-ec472617a755"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 485,
                column: "CityGUID",
                value: new Guid("a9027cd7-b883-4eb8-a3df-1fba7ccc7b44"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 486,
                column: "CityGUID",
                value: new Guid("ef018520-914e-4321-b6b3-9b4816ea8aa2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 487,
                column: "CityGUID",
                value: new Guid("a883e54a-655b-433a-afcf-5f303fa82daf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 488,
                column: "CityGUID",
                value: new Guid("39faa6ec-e4ec-4b50-a2e5-606f9392dd75"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 489,
                column: "CityGUID",
                value: new Guid("4038d81d-1fab-49d1-8caa-751daaf39fa9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 490,
                column: "CityGUID",
                value: new Guid("8d4040a8-72b2-4e31-93ab-c61563810a5d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 491,
                column: "CityGUID",
                value: new Guid("425a1c94-e301-4212-8d2a-a5ad6c099eda"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 492,
                column: "CityGUID",
                value: new Guid("a0d8cd11-aa87-4456-9188-ec5c01e2d958"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 493,
                column: "CityGUID",
                value: new Guid("f09c8d90-148f-40d4-8cda-efe2c2e4d91b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 494,
                column: "CityGUID",
                value: new Guid("bd098b48-8ed7-4aac-a031-9f99dfe49fdd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 495,
                column: "CityGUID",
                value: new Guid("a01e55ff-a1f1-40ae-85a5-bbd56fa3dc1b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 496,
                column: "CityGUID",
                value: new Guid("c753337c-d300-46c3-ba3b-7dc98de5c2ee"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 497,
                column: "CityGUID",
                value: new Guid("c415b2a8-6013-47f7-a361-2b8c363e7efc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 498,
                column: "CityGUID",
                value: new Guid("7f2ac7f1-7aa8-4179-9b37-540c863584ae"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 499,
                column: "CityGUID",
                value: new Guid("c744156c-0852-4802-a991-a4e27912536f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 500,
                column: "CityGUID",
                value: new Guid("eb5ae1fe-e201-4d2b-a586-911ce01848ef"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 501,
                column: "CityGUID",
                value: new Guid("7dea90b6-aa7e-4f01-bf6e-e62760bf07c7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 502,
                column: "CityGUID",
                value: new Guid("c4f2f4d3-35ed-4701-b915-dfc18b21f9eb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 503,
                column: "CityGUID",
                value: new Guid("250869cc-640a-4ad1-8bb8-3700968de849"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 504,
                column: "CityGUID",
                value: new Guid("0f8a4d49-0d53-4e69-b56d-4920e5d449f9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 505,
                column: "CityGUID",
                value: new Guid("4fd9c5b6-e26f-4dc1-ba7d-dd134bb959d7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 506,
                column: "CityGUID",
                value: new Guid("4d77cbfd-9730-4a55-b7d6-c31e31c0fa4c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 507,
                column: "CityGUID",
                value: new Guid("11635085-deb2-4f6f-8c6d-bb0724655ebd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 508,
                column: "CityGUID",
                value: new Guid("8ff16c98-7ac5-4783-9038-53a98e7adb38"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 509,
                column: "CityGUID",
                value: new Guid("3818d8f0-0902-4d23-9ccb-34a8e1274e4b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 510,
                column: "CityGUID",
                value: new Guid("0db0ce51-9f40-4b70-b632-c302c3bb0023"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 511,
                column: "CityGUID",
                value: new Guid("01cb8f18-629d-4042-9f40-c342888640ae"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 512,
                column: "CityGUID",
                value: new Guid("644a3b43-dfb2-4450-bdf8-4b239a686e25"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 513,
                column: "CityGUID",
                value: new Guid("fa808d9b-662b-48a4-a242-0545e5d5b851"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 514,
                column: "CityGUID",
                value: new Guid("7b4e6605-e4ad-433c-80e4-a6a2ead0175b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 515,
                column: "CityGUID",
                value: new Guid("5fe026ad-4574-41d9-9d6a-0dbd674afc1b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 516,
                column: "CityGUID",
                value: new Guid("9b33e653-5b2a-45db-bbce-e2b8eefece69"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 517,
                column: "CityGUID",
                value: new Guid("87dc6951-0be3-4e2a-ae3d-eb107d0d182f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 518,
                column: "CityGUID",
                value: new Guid("41da15f4-cded-4934-b996-752137c36a3d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 519,
                column: "CityGUID",
                value: new Guid("60d44591-7f3f-4614-b96f-fbcc13552cc1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 520,
                column: "CityGUID",
                value: new Guid("1dfab9fa-947e-4ef9-841d-df2164f77f22"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 521,
                column: "CityGUID",
                value: new Guid("fb359482-890a-4b9e-8647-d212fb1845cc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 522,
                column: "CityGUID",
                value: new Guid("e1da15a9-d752-4d77-87c6-ded576505cba"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 523,
                column: "CityGUID",
                value: new Guid("ec357d90-b3ef-4324-938b-05a7fd0f31c0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 524,
                column: "CityGUID",
                value: new Guid("b5a34bdf-bd72-46c7-b4b3-3d375b21bb07"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 525,
                column: "CityGUID",
                value: new Guid("f94dc026-589d-4c51-9ed9-5f4bb894bdd8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 526,
                column: "CityGUID",
                value: new Guid("aa81c024-b09c-483f-be18-562bffc8bb48"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 527,
                column: "CityGUID",
                value: new Guid("5a7d5686-7a4d-4ea7-85bd-2c6ff0b0c465"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 528,
                column: "CityGUID",
                value: new Guid("0ae10c3e-0901-4cac-b718-3a00866f164a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 529,
                column: "CityGUID",
                value: new Guid("b7e735e1-a6de-45d2-8352-a49c1f476b26"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 530,
                column: "CityGUID",
                value: new Guid("190b7816-d42c-4eab-b2b8-e3398ddb391c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 531,
                column: "CityGUID",
                value: new Guid("11dfdcd4-b718-4910-87d7-1c999379442e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 532,
                column: "CityGUID",
                value: new Guid("a2bca319-d082-4862-86b0-6747a7d46aff"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 533,
                column: "CityGUID",
                value: new Guid("a66e2b4a-e2a7-4f96-b623-eadfaddc2a22"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 534,
                column: "CityGUID",
                value: new Guid("b472c016-2515-4df5-ab30-0edf14312f7c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 535,
                column: "CityGUID",
                value: new Guid("8a0f6755-1eee-491d-8258-e0ac5fb01039"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 536,
                column: "CityGUID",
                value: new Guid("5bd56b66-f51a-4880-8231-17fbc8190df7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 537,
                column: "CityGUID",
                value: new Guid("0a2e9730-3b96-446e-ac38-c3c2c7d89b9f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 538,
                column: "CityGUID",
                value: new Guid("baf5f18c-ff76-430f-959e-a81f95137159"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 539,
                column: "CityGUID",
                value: new Guid("8448de8c-bcad-4d2e-aabb-c83c1f729d71"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 540,
                column: "CityGUID",
                value: new Guid("8c835d72-0fe7-40a6-ba6d-d4562ce2ab4c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 541,
                column: "CityGUID",
                value: new Guid("d8222e9e-7b3a-42ad-9550-fae40af70bfe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 542,
                column: "CityGUID",
                value: new Guid("8b9cdd70-bebf-4f2b-80ec-ae36ab0e28d3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 543,
                column: "CityGUID",
                value: new Guid("c8ded6f8-027b-4a14-bba0-2129f8ed6559"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 544,
                column: "CityGUID",
                value: new Guid("b28bf0cf-070a-4144-a481-111492172a96"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 545,
                column: "CityGUID",
                value: new Guid("5d2c0f4c-ef05-41fc-b242-78275fd980bd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 546,
                column: "CityGUID",
                value: new Guid("0b05d46a-809b-40cf-97b1-762a486db6a4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 547,
                column: "CityGUID",
                value: new Guid("a59c00ed-9227-48f1-8863-9f6a5bed888d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 548,
                column: "CityGUID",
                value: new Guid("c9cf97aa-5d4b-4e76-a806-a31ee4e1ba38"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 549,
                column: "CityGUID",
                value: new Guid("f95999b6-f459-493d-943e-52cf5f25ac88"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 550,
                column: "CityGUID",
                value: new Guid("58c05e67-0507-41e4-b2a9-a817f5496a93"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 551,
                column: "CityGUID",
                value: new Guid("65b1ad69-2cd0-4c7b-aaf5-8cc9cddfd3b5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 552,
                column: "CityGUID",
                value: new Guid("bc9ac7a7-50d7-4d8d-85c2-8a2b780bf7d3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 553,
                column: "CityGUID",
                value: new Guid("f364dca6-b9d1-4a5e-8d5f-a7d7a55403c1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 554,
                column: "CityGUID",
                value: new Guid("e5557986-1354-4a4c-8d0f-72304c8a7810"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 555,
                column: "CityGUID",
                value: new Guid("2ce74425-9de2-4ac9-8fd1-457ace5f9c8e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 556,
                column: "CityGUID",
                value: new Guid("4a164c23-edf9-45a5-b8ee-5155e997ea67"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 557,
                column: "CityGUID",
                value: new Guid("7e67a1e4-b1e2-4268-b190-03134fe45923"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 558,
                column: "CityGUID",
                value: new Guid("e59025d7-4486-4a73-b3a0-1402f67f39b6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 559,
                column: "CityGUID",
                value: new Guid("b51b4756-1293-4930-a58c-ca42234b095d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 560,
                column: "CityGUID",
                value: new Guid("c368f075-be6a-4033-a956-aabd4f2ba6c3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 561,
                column: "CityGUID",
                value: new Guid("33b4dc38-2701-4088-b166-8231f3bd59e7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 562,
                column: "CityGUID",
                value: new Guid("569fe1b6-6d39-4a5b-90a2-fdd9f926ff3d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 563,
                column: "CityGUID",
                value: new Guid("b666af96-f040-4a71-b41c-5fe5dff9f9d8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 564,
                column: "CityGUID",
                value: new Guid("c2e431ca-4a35-48a7-89d9-1facf1388132"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 565,
                column: "CityGUID",
                value: new Guid("64c5c751-e5e3-44cd-a3b5-1292dcbb6f62"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 566,
                column: "CityGUID",
                value: new Guid("36344e6d-9272-4759-88b5-135493dbe55d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 567,
                column: "CityGUID",
                value: new Guid("9323cd85-f190-4c89-9d1a-de6bcfaf926a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 568,
                column: "CityGUID",
                value: new Guid("c610e6df-2dd2-4f26-af66-da3901b5faf8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 569,
                column: "CityGUID",
                value: new Guid("e8933c23-081f-48e0-b5ec-c01ef8b65ee7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 570,
                column: "CityGUID",
                value: new Guid("a7ea3377-4a1f-4f91-bd62-442f5bc52742"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 571,
                column: "CityGUID",
                value: new Guid("b420465c-0d9d-4b1c-a250-ef470fc072d1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 572,
                column: "CityGUID",
                value: new Guid("5bf90830-bd41-4948-be84-09ecc995a949"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 573,
                column: "CityGUID",
                value: new Guid("f17db1f9-dc3e-4245-b1ab-dcaea687c687"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 574,
                column: "CityGUID",
                value: new Guid("9c5d3f45-286d-4676-aeb5-601dc6aed1fb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 575,
                column: "CityGUID",
                value: new Guid("a4d07615-90ec-494a-8b37-63b06b09a876"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 576,
                column: "CityGUID",
                value: new Guid("d9fa4c63-ce5c-45e5-831b-66dd74a7d084"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 577,
                column: "CityGUID",
                value: new Guid("9451fcb8-31c3-4ac1-99f5-7e61b1fe2669"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 578,
                column: "CityGUID",
                value: new Guid("ee362ff3-ef3d-4aa1-9dee-65d5d666fb58"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 579,
                column: "CityGUID",
                value: new Guid("4afe5117-b89b-48da-8ceb-2e17a448c85a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 580,
                column: "CityGUID",
                value: new Guid("d5b587b9-e3d3-44c5-8e6c-9b898eba570c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 581,
                column: "CityGUID",
                value: new Guid("e34a49c8-2208-4c52-b029-d8a0f151533f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 582,
                column: "CityGUID",
                value: new Guid("e85893f8-8ec3-4931-89ce-165ee1526986"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 583,
                column: "CityGUID",
                value: new Guid("0a1a744c-c77d-4b23-b039-c1ce33520efc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 584,
                column: "CityGUID",
                value: new Guid("58fc975e-aa5a-42e4-adaf-a6413c8ea9d6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 585,
                column: "CityGUID",
                value: new Guid("20f6bb1b-cc38-4d1a-ae59-e93ad0c2dcd5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 586,
                column: "CityGUID",
                value: new Guid("4484835c-f13b-43a3-bf65-d38d14e20c94"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 587,
                column: "CityGUID",
                value: new Guid("d18f4bcb-ab83-402f-a6a6-8dd1ae886b14"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 588,
                column: "CityGUID",
                value: new Guid("98c166e4-440a-4b1f-88b0-ada413f35068"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 589,
                column: "CityGUID",
                value: new Guid("f34f5bb3-27a2-41b8-8405-2d8ce6550eed"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 590,
                column: "CityGUID",
                value: new Guid("1180299e-12b5-4da2-b39c-dfa3b9220380"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 591,
                column: "CityGUID",
                value: new Guid("95f1a81a-4c50-403d-98b2-408c4098d16d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 592,
                column: "CityGUID",
                value: new Guid("6fe27511-ad41-4001-ae23-208a626d7449"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 593,
                column: "CityGUID",
                value: new Guid("efbd3571-d9d2-4da2-9657-b55aa42609d6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 594,
                column: "CityGUID",
                value: new Guid("f3909384-94e4-4588-b00d-890f140434bf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 595,
                column: "CityGUID",
                value: new Guid("b38fb1a0-4330-43af-bc33-ec4cbb34050e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 596,
                column: "CityGUID",
                value: new Guid("afcf7aa5-268a-4356-aadc-32194ddd1878"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 597,
                column: "CityGUID",
                value: new Guid("ba60d913-d4bf-40f6-85d7-2d5f3d2a04b8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 598,
                column: "CityGUID",
                value: new Guid("361bf5a3-5e1b-49f0-87c9-fbf30d182ca9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 599,
                column: "CityGUID",
                value: new Guid("3c86124b-cb3c-4a39-a01a-3cbe8d1447fa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 600,
                column: "CityGUID",
                value: new Guid("55b26150-a44c-4ef5-adc9-f2514898ebf9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 601,
                column: "CityGUID",
                value: new Guid("6f91fa23-4d3c-417e-a695-b4c8a435c378"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 602,
                column: "CityGUID",
                value: new Guid("b5122958-65e7-4f20-b1cd-9e7fde5a5838"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 603,
                column: "CityGUID",
                value: new Guid("9a878ef6-44c9-47bc-b1b8-b401f06fed3a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 604,
                column: "CityGUID",
                value: new Guid("412db655-5708-4c0e-8fd3-6bb218f2fd9d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 605,
                column: "CityGUID",
                value: new Guid("cc137929-29b8-4373-9380-e02f87fe0a8a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 606,
                column: "CityGUID",
                value: new Guid("eb38d9e7-e400-4907-b22b-e26e36786011"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 607,
                column: "CityGUID",
                value: new Guid("90be2058-e5a8-4326-a45a-2d6f3fb2cae7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 608,
                column: "CityGUID",
                value: new Guid("78db0094-099f-4c52-8c69-620dfc7bfbeb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 609,
                column: "CityGUID",
                value: new Guid("57173681-5a0b-4ecf-9d9a-350288034ae7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 610,
                column: "CityGUID",
                value: new Guid("6930fa94-1e4a-44b2-99f8-8ca41cdc3e03"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 611,
                column: "CityGUID",
                value: new Guid("0ff4c6db-7473-4d1c-a8d3-38647ab2f34a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 612,
                column: "CityGUID",
                value: new Guid("39029bd7-fdae-479c-96d0-50a4cf0f5d13"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 613,
                column: "CityGUID",
                value: new Guid("238f68e5-5a5a-45fc-a5df-060de9a0eb32"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 614,
                column: "CityGUID",
                value: new Guid("7fcd06b4-f655-47c8-96e7-266bc753699c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 615,
                column: "CityGUID",
                value: new Guid("d9f39693-767b-444d-8e65-cf74316fbe75"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 616,
                column: "CityGUID",
                value: new Guid("44917c50-fe8a-44b4-8d62-042f9fdab19e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 617,
                column: "CityGUID",
                value: new Guid("eea9db3e-fddd-473a-a1d7-70c993b6e77f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 618,
                column: "CityGUID",
                value: new Guid("56dae90b-5fa1-4e49-92e6-ec5921713d9a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 619,
                column: "CityGUID",
                value: new Guid("b550f3b3-a4ad-4e7e-8f65-43bbfc6bb7f4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 620,
                column: "CityGUID",
                value: new Guid("e546708e-bbe3-473c-883b-ad3478168042"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 621,
                column: "CityGUID",
                value: new Guid("51318cf8-02be-4bee-9f59-ecfff8ed902b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 622,
                column: "CityGUID",
                value: new Guid("a378b872-3986-4d14-b2f0-6b70a82f1204"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 623,
                column: "CityGUID",
                value: new Guid("910e8e75-3022-4f17-84d0-251fedcdb0b8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 624,
                column: "CityGUID",
                value: new Guid("d72a23fd-4a75-49e4-877a-a53bbc52277a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 625,
                column: "CityGUID",
                value: new Guid("b44e3592-f0af-4063-87dd-e1deadd1e280"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 626,
                column: "CityGUID",
                value: new Guid("c1f496fe-e581-4178-bd04-b4f210036cbd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 627,
                column: "CityGUID",
                value: new Guid("c5d2ca4f-6ecb-47f7-afc5-7241e9e3cec1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 628,
                column: "CityGUID",
                value: new Guid("1e3bd790-f2c5-4891-8aa5-7374c32cd107"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 629,
                column: "CityGUID",
                value: new Guid("c0282fc5-e6fa-4057-9c54-ebc65033231e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 630,
                column: "CityGUID",
                value: new Guid("1721e681-3fb8-4173-8c28-1426ac132dae"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 631,
                column: "CityGUID",
                value: new Guid("91b5fb53-496c-450c-8a85-9b064ee2c71b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 632,
                column: "CityGUID",
                value: new Guid("b0df68e2-48b8-4c45-a1c4-1d6721c6c1bd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 633,
                column: "CityGUID",
                value: new Guid("b63bed85-671f-4277-a027-5fa625cf057e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 634,
                column: "CityGUID",
                value: new Guid("06d2702e-92f0-451a-aeb0-ffc3567aaebf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 635,
                column: "CityGUID",
                value: new Guid("da7a80c7-9299-49e6-8b38-b1ff2c7da69e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 636,
                column: "CityGUID",
                value: new Guid("1abbda5a-5c56-4387-9062-a617eeb07f49"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 637,
                column: "CityGUID",
                value: new Guid("cfc62c07-9a12-4e14-b972-2e7a8237d3e3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 638,
                column: "CityGUID",
                value: new Guid("fa49d4b1-2732-43c6-8d41-74c56a9c1112"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 639,
                column: "CityGUID",
                value: new Guid("c01d5839-cd81-4da4-acc5-b90baa955a6b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 640,
                column: "CityGUID",
                value: new Guid("ec98e627-920d-49db-a638-b35263443608"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 641,
                column: "CityGUID",
                value: new Guid("83444dd5-e60c-4520-8f64-bcce3c6255b5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 642,
                column: "CityGUID",
                value: new Guid("eee6f14a-e728-45a5-bb44-906a6f60da10"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 643,
                column: "CityGUID",
                value: new Guid("33df1eee-abd6-4290-9a86-e36c932d4b5c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 644,
                column: "CityGUID",
                value: new Guid("e114faea-169d-4ade-a12f-340235553bcd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 645,
                column: "CityGUID",
                value: new Guid("d943ef46-f80c-40c5-9f71-66eeecdaec81"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 646,
                column: "CityGUID",
                value: new Guid("a1e28642-07cf-4b04-b4d0-94f134aeec92"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 647,
                column: "CityGUID",
                value: new Guid("171a2527-2627-430b-bb75-fbb02be5cb3f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 648,
                column: "CityGUID",
                value: new Guid("a4880c02-5957-4908-83e6-14c333a01b17"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 649,
                column: "CityGUID",
                value: new Guid("5fd3aae3-5c6a-4810-b6af-d2324dce5b8a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 650,
                column: "CityGUID",
                value: new Guid("2cb117c8-6927-482d-906a-0f612aa19d66"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 651,
                column: "CityGUID",
                value: new Guid("88bb8a74-62c7-483c-85af-d39528fbcd2f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 652,
                column: "CityGUID",
                value: new Guid("acfd5373-407f-4f81-aebc-9842909fa30f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 653,
                column: "CityGUID",
                value: new Guid("2d9db6af-ab22-4138-8e4f-39517364d4b6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 654,
                column: "CityGUID",
                value: new Guid("24deb264-6791-4a82-a6ab-8c88957f2561"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 655,
                column: "CityGUID",
                value: new Guid("b048b824-3502-46bb-9f92-94981f3f8b21"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 656,
                column: "CityGUID",
                value: new Guid("c039767c-271e-4b9b-9455-1ec34e333fb2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 657,
                column: "CityGUID",
                value: new Guid("c0fce79f-5f10-46e7-8fbe-80e5db971f4b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 658,
                column: "CityGUID",
                value: new Guid("d502363e-b857-41ea-9201-c46627f9be61"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 659,
                column: "CityGUID",
                value: new Guid("87f8637d-2932-429e-9476-9d6ae968d642"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 660,
                column: "CityGUID",
                value: new Guid("675d2bad-7ad9-4335-8055-8875bf40df3f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 661,
                column: "CityGUID",
                value: new Guid("7f67df2a-4d76-4a57-8151-86ba8a5de282"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 662,
                column: "CityGUID",
                value: new Guid("ad9703bf-770c-4369-8f96-a5c3818d697a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 663,
                column: "CityGUID",
                value: new Guid("4b9b24cf-e2f7-4a59-b55b-06a49e82dcec"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 664,
                column: "CityGUID",
                value: new Guid("4b8ec883-4827-41ab-844e-d0f97bb1d592"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 665,
                column: "CityGUID",
                value: new Guid("0ad8f7d7-e79c-45c1-91a3-c1b0320e7745"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 666,
                column: "CityGUID",
                value: new Guid("5db8b8ae-57bc-4e01-a938-8e72bd1298e8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 667,
                column: "CityGUID",
                value: new Guid("ca60346e-9088-4581-bca3-ac736d60c43d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 668,
                column: "CityGUID",
                value: new Guid("3e0069f0-28c8-4a93-92d5-1047b858f031"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 669,
                column: "CityGUID",
                value: new Guid("94016d40-4446-41fc-8e75-73786408c408"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 670,
                column: "CityGUID",
                value: new Guid("a0b52b2d-8648-489a-a0e9-7ad9eaa4d27b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 671,
                column: "CityGUID",
                value: new Guid("52fd58ed-2d90-4dbb-bc6b-74ec74d32472"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 672,
                column: "CityGUID",
                value: new Guid("1ca0bcce-87b1-46bd-8329-17dbc88b2b68"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 673,
                column: "CityGUID",
                value: new Guid("d08b9798-7d84-4489-8ead-7db3416584aa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 674,
                column: "CityGUID",
                value: new Guid("c0c10735-7941-4efe-ac7a-f4372f104789"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 675,
                column: "CityGUID",
                value: new Guid("0e6b6069-5a79-4df3-b20c-7991bc226276"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 676,
                column: "CityGUID",
                value: new Guid("94c629ed-54c2-4474-bbeb-c3d4ea420c80"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 677,
                column: "CityGUID",
                value: new Guid("606b2310-a8da-4567-b40d-216f25b9bf74"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 678,
                column: "CityGUID",
                value: new Guid("100774b4-7e9f-4b51-964c-11642451261c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 679,
                column: "CityGUID",
                value: new Guid("09c57493-65c1-4423-a9f5-f0fa45f11685"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 680,
                column: "CityGUID",
                value: new Guid("5c41b3ee-eb22-4a3c-b193-4edfc17fad3f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 681,
                column: "CityGUID",
                value: new Guid("402be17e-9a0c-4078-a14d-b2507b5205c6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 682,
                column: "CityGUID",
                value: new Guid("df01a451-9091-4f3f-9d3a-542d868e9149"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 683,
                column: "CityGUID",
                value: new Guid("bfc7cd4e-7398-4d62-ae1f-bbcba7e18466"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 684,
                column: "CityGUID",
                value: new Guid("5b33fd6c-77e7-4491-b2fc-473fb7a68289"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 685,
                column: "CityGUID",
                value: new Guid("2ccf85f5-2dff-457e-b313-fc662578b48f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 686,
                column: "CityGUID",
                value: new Guid("3fce753a-c0ca-4e15-a29f-6b72b0c04141"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 687,
                column: "CityGUID",
                value: new Guid("b4bdb6ad-5454-4ece-bbea-dfc2c1f2b5f9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 688,
                column: "CityGUID",
                value: new Guid("1fada79d-1d04-45ea-9674-09789f54ef17"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 689,
                column: "CityGUID",
                value: new Guid("63647f0a-7504-42f8-9228-b3b0a755207a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 690,
                column: "CityGUID",
                value: new Guid("5dab510b-9c13-4330-af06-968b0873b284"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 691,
                column: "CityGUID",
                value: new Guid("7751053e-9a27-4452-82dc-4b84adc8c3d5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 692,
                column: "CityGUID",
                value: new Guid("95e30724-1ccd-49d1-b24b-e503eeb26b32"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 693,
                column: "CityGUID",
                value: new Guid("8c86f831-9208-424b-a3ec-d86ee74f7fb0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 694,
                column: "CityGUID",
                value: new Guid("954c0d81-97f1-47f7-a923-928f216f7bb4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 695,
                column: "CityGUID",
                value: new Guid("1b5ee285-f84a-4786-bf17-d090fc99966a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 696,
                column: "CityGUID",
                value: new Guid("ca685681-9539-4126-ac10-30daec3b8bf4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 697,
                column: "CityGUID",
                value: new Guid("22c0bba4-57a0-4d2b-8a30-cc46ac43f560"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 698,
                column: "CityGUID",
                value: new Guid("58a75057-88e6-4532-a93d-3ebcf521b0e7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 699,
                column: "CityGUID",
                value: new Guid("635e47e7-f4e2-4b10-8e75-add09119e4c3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 700,
                column: "CityGUID",
                value: new Guid("b69670ad-1640-4d0e-bab4-f28430410681"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 701,
                column: "CityGUID",
                value: new Guid("3d1cffa6-b0ba-4d47-858a-c174ac04d21c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 702,
                column: "CityGUID",
                value: new Guid("18a17370-1f53-491c-a562-d11045e8e31e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 703,
                column: "CityGUID",
                value: new Guid("fb13d5d0-005c-47f4-87b2-a66fde0241f6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 704,
                column: "CityGUID",
                value: new Guid("c9767d77-a744-4c97-8600-ed8ba3aed81f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 705,
                column: "CityGUID",
                value: new Guid("f494ac75-d591-48dd-a300-d0b00875b7db"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 706,
                column: "CityGUID",
                value: new Guid("aa1bad48-4d30-4630-9771-432759c9f609"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 707,
                column: "CityGUID",
                value: new Guid("a772164a-b552-4a32-936b-a578afab15a3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 708,
                column: "CityGUID",
                value: new Guid("52564029-c62a-4dd5-9b5f-626404a461c0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 709,
                column: "CityGUID",
                value: new Guid("2bf883da-6c0b-4470-94f4-8696e6caf154"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 710,
                column: "CityGUID",
                value: new Guid("dacef8eb-bce1-4555-97b5-85ff95a0efbf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 711,
                column: "CityGUID",
                value: new Guid("74baf9c5-e4bc-4196-ab93-b10bdcd8793c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 712,
                column: "CityGUID",
                value: new Guid("b080957d-18ff-4a3d-b525-7020cf7ea6ac"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 713,
                column: "CityGUID",
                value: new Guid("f974083d-d5b5-4752-ac37-07a28671195b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 714,
                column: "CityGUID",
                value: new Guid("79f315d9-42f9-4545-9ccc-3d46d644bee3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 715,
                column: "CityGUID",
                value: new Guid("cb569c50-3d34-4a06-8a2b-2f1c5ecb94ca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 716,
                column: "CityGUID",
                value: new Guid("8d2dfbee-37b0-4627-96be-5690682ed0e7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 717,
                column: "CityGUID",
                value: new Guid("9bab9a8d-2a6a-4a3c-88c9-9d2dc64f076a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 718,
                column: "CityGUID",
                value: new Guid("003f4958-3738-436b-b52c-1cf4491ef175"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 719,
                column: "CityGUID",
                value: new Guid("bec3aa37-26f8-4326-a67f-8442fa0b8347"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 720,
                column: "CityGUID",
                value: new Guid("7fadbb4d-13bf-4dd5-98d1-c16f0af91837"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 721,
                column: "CityGUID",
                value: new Guid("0168b3e3-0ed5-4091-a976-005cff4fc0dd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 722,
                column: "CityGUID",
                value: new Guid("d808d8c9-0f8c-4c09-81a5-6ce5f634ec3c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 723,
                column: "CityGUID",
                value: new Guid("f6da23b5-53e0-4f8c-8274-3d44a7cbd97a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 724,
                column: "CityGUID",
                value: new Guid("b853677a-282a-4769-93c5-4c5696b09326"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 725,
                column: "CityGUID",
                value: new Guid("032d6891-1024-429d-a93f-60084682acac"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 726,
                column: "CityGUID",
                value: new Guid("e610319e-6b82-4140-ac0f-bf79cc3975cd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 727,
                column: "CityGUID",
                value: new Guid("30700253-ae88-4797-8c97-272a39819d0e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 728,
                column: "CityGUID",
                value: new Guid("04aff160-c1cc-4d30-99e7-3d17b4cb6aaa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 729,
                column: "CityGUID",
                value: new Guid("9cd8d5d4-e0d3-483b-a51f-eeead469b0e9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 730,
                column: "CityGUID",
                value: new Guid("c8fa0a89-f8fd-4b9d-a972-11830e24ccc6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 731,
                column: "CityGUID",
                value: new Guid("db56123c-5d32-48b6-a285-a0e471086962"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 732,
                column: "CityGUID",
                value: new Guid("23d1cbf9-ee57-47ad-a4a0-225986a256a0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 733,
                column: "CityGUID",
                value: new Guid("fdf96484-1aec-4d54-ba5e-3ab765986ffb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 734,
                column: "CityGUID",
                value: new Guid("9433c25b-7a2a-4995-b57a-9ec389ce3a29"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 735,
                column: "CityGUID",
                value: new Guid("63e0be74-9c6a-4109-80e8-1d311a630d23"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 736,
                column: "CityGUID",
                value: new Guid("5aa2f0f1-b18e-4b6c-8f55-3645610b7186"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 737,
                column: "CityGUID",
                value: new Guid("162015ef-7524-4f77-b758-0a147ea153e2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 738,
                column: "CityGUID",
                value: new Guid("d5368072-cf65-4e7d-8b1e-7376a3674872"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 739,
                column: "CityGUID",
                value: new Guid("f4480231-fcf1-4821-a492-7bcb7f3a2593"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 740,
                column: "CityGUID",
                value: new Guid("540d0ee4-a0ad-4a38-aa53-3b2134fafdc8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 741,
                column: "CityGUID",
                value: new Guid("5c64fd55-1a25-4531-bbe2-640512ca0a3e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 742,
                column: "CityGUID",
                value: new Guid("6a227e61-7ab0-4c48-906b-f0ade093c22e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 743,
                column: "CityGUID",
                value: new Guid("82fb96dd-6c5c-499b-9178-2df0733a6d94"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 744,
                column: "CityGUID",
                value: new Guid("67c0bba2-a074-4074-8c85-355cac1b4e91"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 745,
                column: "CityGUID",
                value: new Guid("15c873f4-08fc-4ea5-8666-b3e254adf26d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 746,
                column: "CityGUID",
                value: new Guid("ed423422-3a16-4066-a772-23ac01478308"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 747,
                column: "CityGUID",
                value: new Guid("076f99bf-1dfa-48d3-8bd4-4345ea0ed6e8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 748,
                column: "CityGUID",
                value: new Guid("87a3c028-ae0b-4070-b98e-f3e058294aca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 749,
                column: "CityGUID",
                value: new Guid("5b288e4b-8498-4c25-b0b0-99b7640fadfa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 750,
                column: "CityGUID",
                value: new Guid("603a46de-1d8b-4cc3-b4ad-d3e7124e549c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 751,
                column: "CityGUID",
                value: new Guid("57ffd3bf-152e-413e-b16e-222f8e88feac"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 752,
                column: "CityGUID",
                value: new Guid("1333b4a6-c3d4-4c60-a03f-a781b5730f80"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 753,
                column: "CityGUID",
                value: new Guid("9477bd61-e342-4a82-b393-27d8e28b6340"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 754,
                column: "CityGUID",
                value: new Guid("a6d60785-4368-4793-bafd-86db13ab45f9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 755,
                column: "CityGUID",
                value: new Guid("d599b760-ffea-4d52-a1f3-87e25c2f105e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 756,
                column: "CityGUID",
                value: new Guid("41cecb0e-4731-4ef3-add6-aa33fa87d0c8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 757,
                column: "CityGUID",
                value: new Guid("095abfa0-6321-41f5-9bca-b084b93e09de"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 758,
                column: "CityGUID",
                value: new Guid("43e818ab-42d0-447f-a087-12d9bd0dd56b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 759,
                column: "CityGUID",
                value: new Guid("96604008-44bf-4c90-94dc-01903f90900b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 760,
                column: "CityGUID",
                value: new Guid("4292ae37-6bca-4703-b543-7fab53627263"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 761,
                column: "CityGUID",
                value: new Guid("a8e5294d-0cb3-42ae-b5bf-f0cc20a1a5ab"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 762,
                column: "CityGUID",
                value: new Guid("57741f4d-8e5c-4588-9caf-8dde92c64f91"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 763,
                column: "CityGUID",
                value: new Guid("b04610dc-b445-43e3-b7c5-411032224b45"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 764,
                column: "CityGUID",
                value: new Guid("bdaaf6d1-c239-4cb6-9042-214ec03ea0c8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 765,
                column: "CityGUID",
                value: new Guid("7bcd47a7-d0f7-4b29-98cc-4911566a3827"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 766,
                column: "CityGUID",
                value: new Guid("d3bb3a39-afa8-4442-9eab-3433ef9b945c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 767,
                column: "CityGUID",
                value: new Guid("f14db932-8da4-4fa9-8b91-271caf4bc78b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 768,
                column: "CityGUID",
                value: new Guid("81a709c7-134a-4442-9fc0-e34e11d45a59"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 769,
                column: "CityGUID",
                value: new Guid("2d2a1f35-f206-4544-beb6-c479c1141e33"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 770,
                column: "CityGUID",
                value: new Guid("f6a8edc6-2d8d-471f-b2b9-62de7214ac97"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 771,
                column: "CityGUID",
                value: new Guid("e567d013-2af1-4a3b-9bae-a5cbfd4489eb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 772,
                column: "CityGUID",
                value: new Guid("09ccffd7-83c5-4d85-96e5-facb72769022"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 773,
                column: "CityGUID",
                value: new Guid("39d5c389-5d6d-45e2-b7f0-3ef18060c500"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 774,
                column: "CityGUID",
                value: new Guid("59ab4a10-8d9c-49a8-a9d9-e856c6f07fc5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 775,
                column: "CityGUID",
                value: new Guid("0de24e8f-afbd-4a9c-8a62-b1e38a01ff6f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 776,
                column: "CityGUID",
                value: new Guid("0dd71807-fa0f-41b8-acb8-c238e87d43bb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 777,
                column: "CityGUID",
                value: new Guid("8fac9f4d-506d-4775-9824-bfc17bbf7a65"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 778,
                column: "CityGUID",
                value: new Guid("6b21f15b-b728-4eda-ae8f-90f7e297a109"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 779,
                column: "CityGUID",
                value: new Guid("9523996f-9ce1-4a88-865b-d980da8916a6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 780,
                column: "CityGUID",
                value: new Guid("b21159e5-243c-4898-bd7e-c00450944aa6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 781,
                column: "CityGUID",
                value: new Guid("7c478d34-8f66-4b1e-bbfe-c2c9bb50f973"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 782,
                column: "CityGUID",
                value: new Guid("e120b64d-8e24-47dd-978e-87546548bd4a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 783,
                column: "CityGUID",
                value: new Guid("eb20edb7-6542-497f-9e5b-418d00839d0e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 784,
                column: "CityGUID",
                value: new Guid("154ee176-26cf-4da4-8fad-88d3442cc9a6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 785,
                column: "CityGUID",
                value: new Guid("2408d1f1-71c8-4664-854c-499333a6590c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 786,
                column: "CityGUID",
                value: new Guid("a216d7be-2858-4425-98a8-85eba392fb12"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 787,
                column: "CityGUID",
                value: new Guid("e7ab4526-4796-4969-a14a-990aebded387"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 788,
                column: "CityGUID",
                value: new Guid("70969e10-3edf-4c5b-9fa7-012be657faea"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 789,
                column: "CityGUID",
                value: new Guid("f3c8cc18-c83a-484b-a67a-8a14483e951b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 790,
                column: "CityGUID",
                value: new Guid("bf84713a-5db5-4452-902f-69d76a8733d0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 791,
                column: "CityGUID",
                value: new Guid("96d8710f-7876-45ed-a335-d12e6a331dbe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 792,
                column: "CityGUID",
                value: new Guid("0d87e57f-659a-427a-9980-fd2a21d042ef"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 793,
                column: "CityGUID",
                value: new Guid("a6483017-0802-4908-994d-01e8dfe3b147"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 794,
                column: "CityGUID",
                value: new Guid("22a8eac7-4508-42f5-8dfb-994d6c10a485"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 795,
                column: "CityGUID",
                value: new Guid("54e57f0c-0d8c-47bd-80e2-722449924ccf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 796,
                column: "CityGUID",
                value: new Guid("5b3ccbd9-c02e-44b9-9e70-209c18c22fbc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 797,
                column: "CityGUID",
                value: new Guid("5c9a58ef-00a8-43e1-8541-b27c58bb5a4e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 798,
                column: "CityGUID",
                value: new Guid("e292b385-f032-4e4d-a6a3-0ca76a9f9616"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 799,
                column: "CityGUID",
                value: new Guid("61c3cdd6-91f7-46bc-8f95-95d9b264e591"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 800,
                column: "CityGUID",
                value: new Guid("7a22276b-96e6-471d-a30d-cb8ba93baa0c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 801,
                column: "CityGUID",
                value: new Guid("14cd28da-51d1-4060-bc37-394a5a63a82e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 802,
                column: "CityGUID",
                value: new Guid("2aa3416d-4fda-48f3-a725-60ebd0a3bd26"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 803,
                column: "CityGUID",
                value: new Guid("60de4eff-ab53-4550-b738-87e787b9c31f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 804,
                column: "CityGUID",
                value: new Guid("0d896577-7bef-4e7c-9366-0a472b3479cc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 805,
                column: "CityGUID",
                value: new Guid("b9380ebe-3ed3-4502-865d-23e5f7c54bca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 806,
                column: "CityGUID",
                value: new Guid("b2f5c1b0-a9a8-445e-8f14-c6b73c3e526c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 807,
                column: "CityGUID",
                value: new Guid("3a7e8840-bd8d-4a8b-be65-e0691399577f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 808,
                column: "CityGUID",
                value: new Guid("d020d6c6-e75a-45ca-95e5-fe722bc30da9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 809,
                column: "CityGUID",
                value: new Guid("3cf7ed3a-5abd-461e-9099-0d92b5b8acff"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 810,
                column: "CityGUID",
                value: new Guid("0c93fe75-8f64-41e7-9c73-cdc01c29a5af"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 811,
                column: "CityGUID",
                value: new Guid("1bed2695-2a84-4793-9207-1e1c66b1635e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 812,
                column: "CityGUID",
                value: new Guid("a4a3293f-78b9-4ce9-9863-51032ae4e28c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 813,
                column: "CityGUID",
                value: new Guid("538fe280-68da-43d4-82a5-b5bf2a732b60"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 814,
                column: "CityGUID",
                value: new Guid("07920619-190a-4a23-aac0-bfb67db65c64"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 815,
                column: "CityGUID",
                value: new Guid("cc3a297b-6648-4160-9ea0-e049ba359837"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 816,
                column: "CityGUID",
                value: new Guid("29c55647-775d-400c-978e-0c41bf8d0d1b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 817,
                column: "CityGUID",
                value: new Guid("585760b2-eb6b-4abe-81e5-df1c2a7da43e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 818,
                column: "CityGUID",
                value: new Guid("46ef3343-796e-4d1c-8f94-f629cff2a325"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 819,
                column: "CityGUID",
                value: new Guid("35acceb1-65a5-4049-9ba4-5f1cf577756a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 820,
                column: "CityGUID",
                value: new Guid("5f0dd9ae-57c7-4f82-a817-8402279b3118"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 821,
                column: "CityGUID",
                value: new Guid("2ebbeb14-f70f-4792-a67f-10a4d5b6d75a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 822,
                column: "CityGUID",
                value: new Guid("7b70674b-68e8-4cb7-8783-c0eae43f70a7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 823,
                column: "CityGUID",
                value: new Guid("e8fcc452-7fea-403c-97a3-f1a798eb05f2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 824,
                column: "CityGUID",
                value: new Guid("ca4dae34-ba21-44be-af38-849729929ba4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 825,
                column: "CityGUID",
                value: new Guid("3a357ad4-8834-4fa9-a162-df97f9bb302b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 826,
                column: "CityGUID",
                value: new Guid("d2a8996b-cc0d-456c-93e4-817df15e8165"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 827,
                column: "CityGUID",
                value: new Guid("ca9bb817-3807-4fa8-948d-15a3c328cec3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 828,
                column: "CityGUID",
                value: new Guid("afd01bcf-fda2-4381-a3b4-f5c0221941e8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 829,
                column: "CityGUID",
                value: new Guid("ff59e82c-1205-4661-ab99-dde60d965751"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 830,
                column: "CityGUID",
                value: new Guid("92504d76-09ea-43f9-8140-1fd13dbe1e3f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 831,
                column: "CityGUID",
                value: new Guid("0316bdf0-a92e-4855-b219-7422f03b113e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 832,
                column: "CityGUID",
                value: new Guid("77e72546-ff5a-47fb-9531-a39ccddc1319"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 833,
                column: "CityGUID",
                value: new Guid("d914a157-0b8e-45d4-9895-ca7e8e82d75f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 834,
                column: "CityGUID",
                value: new Guid("c3917110-907b-4ecf-adb3-9981fb504916"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 835,
                column: "CityGUID",
                value: new Guid("9a48967f-1d1b-4d4d-86ac-48e257c9a6b6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 836,
                column: "CityGUID",
                value: new Guid("e679c895-d348-4b64-90b5-ca1f5878427b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 837,
                column: "CityGUID",
                value: new Guid("de36dd9e-0dde-4406-b2e0-e56f996ff7e3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 838,
                column: "CityGUID",
                value: new Guid("e6561e22-2b45-43cd-bb21-da0f35ebfe6d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 839,
                column: "CityGUID",
                value: new Guid("ae670b6d-329a-4144-866a-24a1f60aa50f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 840,
                column: "CityGUID",
                value: new Guid("5cbdb7e8-3b38-4038-aae2-1b9cd2fd2cf5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 841,
                column: "CityGUID",
                value: new Guid("ed70b0e5-7595-447e-b2d3-0faa39ce6e36"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 842,
                column: "CityGUID",
                value: new Guid("05332a2c-9912-46f0-9d50-77adc6339a05"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 843,
                column: "CityGUID",
                value: new Guid("0264623f-a5eb-44ce-9b1b-79079ebaad37"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 844,
                column: "CityGUID",
                value: new Guid("d89bf40b-b39a-4249-89e6-86dff1d04d06"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 845,
                column: "CityGUID",
                value: new Guid("7afd9ae3-7334-4adc-a157-f810f941a574"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 846,
                column: "CityGUID",
                value: new Guid("029f195f-2b7e-4055-9422-089adf8a7ac9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 847,
                column: "CityGUID",
                value: new Guid("57262aae-b915-4e65-9a29-41f6ad42b0f2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 848,
                column: "CityGUID",
                value: new Guid("ce58f88c-4a27-4b2f-8bb5-2ab2b062c91d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 849,
                column: "CityGUID",
                value: new Guid("0942cd64-dbb9-4b9e-af0b-1829ca10d48c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 850,
                column: "CityGUID",
                value: new Guid("13c8950f-6ac2-4e21-89d0-912d6c9634a4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 851,
                column: "CityGUID",
                value: new Guid("beec46fd-cc2f-45a1-a1dd-e1f8d9f955fd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 852,
                column: "CityGUID",
                value: new Guid("cf5da660-91b4-4067-90eb-3dc948d12137"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 853,
                column: "CityGUID",
                value: new Guid("bca5c093-3a3f-4834-bd49-a7ef8fb6da1b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 854,
                column: "CityGUID",
                value: new Guid("d9affa18-c94a-4b9d-80a7-89a2380c9e3f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 855,
                column: "CityGUID",
                value: new Guid("7ceeab66-cda3-42bb-9094-9b27119b7614"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 856,
                column: "CityGUID",
                value: new Guid("8b0117e6-df8b-4519-8539-4e75428f21e9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 857,
                column: "CityGUID",
                value: new Guid("ba8b2f65-fb2f-4275-9855-e067ad0b6b22"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 858,
                column: "CityGUID",
                value: new Guid("482a3c2f-ffe2-41ea-905e-bba90c8584d9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 859,
                column: "CityGUID",
                value: new Guid("a6b771ad-bcd6-4188-aaf7-1090834c32de"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 860,
                column: "CityGUID",
                value: new Guid("2f1c5393-9348-45f5-9640-fb7dd640c00c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 861,
                column: "CityGUID",
                value: new Guid("d382ee01-10a3-4ae5-ae7d-dc58778ba060"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 862,
                column: "CityGUID",
                value: new Guid("506a815e-0e11-463d-bb1c-849f1cf69657"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 863,
                column: "CityGUID",
                value: new Guid("2c8e62f2-ff7f-498b-9449-48d9f478fde8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 864,
                column: "CityGUID",
                value: new Guid("a9fe8cae-bcc9-42d8-843a-03b9a1b32ad5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 865,
                column: "CityGUID",
                value: new Guid("6a72ab00-e13a-4d8f-a787-3c1387de0c85"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 866,
                column: "CityGUID",
                value: new Guid("ca65df4e-fe19-4703-a069-4b9e788509a4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 867,
                column: "CityGUID",
                value: new Guid("ee5d3dce-d9e6-4ec4-9f33-63a187f4ad89"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 868,
                column: "CityGUID",
                value: new Guid("66d74eb3-d822-4522-b431-e116363eaa41"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 869,
                column: "CityGUID",
                value: new Guid("0f2c80fd-f373-403b-9896-b199ae55da9e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 870,
                column: "CityGUID",
                value: new Guid("5aaef4c3-c4f9-412d-97bd-929fde321ff3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 871,
                column: "CityGUID",
                value: new Guid("b43fb3f5-15cc-40b0-989d-317b82580c86"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 872,
                column: "CityGUID",
                value: new Guid("2793359e-fc0c-473d-a76f-c11a1c769280"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 873,
                column: "CityGUID",
                value: new Guid("b1ae6bee-20ae-4eab-9132-abc2901527cd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 874,
                column: "CityGUID",
                value: new Guid("4b126afd-edb9-49d8-8489-5adb09cee368"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 875,
                column: "CityGUID",
                value: new Guid("e61f397c-e78e-409a-ba3a-1d86b78d9693"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 876,
                column: "CityGUID",
                value: new Guid("d1cd46cd-abb0-4ec4-a1ad-e42f38a09332"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 877,
                column: "CityGUID",
                value: new Guid("5392a7e5-ef6f-4892-aceb-a10cb2f5bb6a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 878,
                column: "CityGUID",
                value: new Guid("3ceb0d58-ea0c-40e7-8eea-a26a4f31c8c0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 879,
                column: "CityGUID",
                value: new Guid("901b52a3-cd06-4b4f-9860-0a1d121cc770"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 880,
                column: "CityGUID",
                value: new Guid("9f7bb43d-1a44-4d5e-90e8-48ea8a76075f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 881,
                column: "CityGUID",
                value: new Guid("8ca60c0b-8ab7-4bcb-99fb-d51982134cd3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 882,
                column: "CityGUID",
                value: new Guid("7bd152d7-4531-4bd3-b19f-b5cf22044aa0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 883,
                column: "CityGUID",
                value: new Guid("59fb74c1-cf0f-46bf-bf79-3c7c7ac36560"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 884,
                column: "CityGUID",
                value: new Guid("e81cb324-9ffa-4f37-af27-bf5ad6603e40"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 885,
                column: "CityGUID",
                value: new Guid("18ad8d2a-53a9-4b69-a1a0-274f1690bb8a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 886,
                column: "CityGUID",
                value: new Guid("8f45d113-c29e-4b0f-82d2-a1ce98ffeefd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 887,
                column: "CityGUID",
                value: new Guid("c2ee0240-f337-4f29-9bbd-29c6a9b32cff"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 888,
                column: "CityGUID",
                value: new Guid("547f33a3-130e-40b8-b4cb-19be6fe970d2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 889,
                column: "CityGUID",
                value: new Guid("f96e1620-4bdd-4341-afd3-54606c67ffff"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 890,
                column: "CityGUID",
                value: new Guid("980364b1-16a2-4cfa-a52d-bc62374462dd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 891,
                column: "CityGUID",
                value: new Guid("11be67f6-f607-4df9-b6de-f754437aeb99"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 892,
                column: "CityGUID",
                value: new Guid("b1a059d6-728b-4a4a-8dc5-f11544c48b9e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 893,
                column: "CityGUID",
                value: new Guid("b7616032-9b8d-469d-a8dd-d9410c5888f0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 894,
                column: "CityGUID",
                value: new Guid("5a71d997-b127-4773-906d-288acfa0995f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 895,
                column: "CityGUID",
                value: new Guid("bf160a91-ae6c-4784-8a83-64e4afcc634e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 896,
                column: "CityGUID",
                value: new Guid("bde2eb14-5c4d-4f0b-a538-87ab2b9c65b1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 897,
                column: "CityGUID",
                value: new Guid("51dd7318-219f-4761-bb92-e9828b50fd7a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 898,
                column: "CityGUID",
                value: new Guid("9b367a92-915c-498f-9ef0-4fe10b2cb215"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 899,
                column: "CityGUID",
                value: new Guid("c4f46ccd-e05f-46a6-adb5-4b9cc5237d31"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 900,
                column: "CityGUID",
                value: new Guid("bbc914ae-851f-465c-8bfe-26560e728cc5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 901,
                column: "CityGUID",
                value: new Guid("7c9ab03d-5c32-4ee8-af54-8cce8bbc1fc9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 902,
                column: "CityGUID",
                value: new Guid("6cd9f41b-5dad-411f-84c7-9d4ce7806c67"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 903,
                column: "CityGUID",
                value: new Guid("b8a365a1-6b3d-4713-9c7f-aa45e0039c14"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 904,
                column: "CityGUID",
                value: new Guid("07b1aa3b-c955-4ad0-89bd-d83fd79bbd69"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 905,
                column: "CityGUID",
                value: new Guid("cf0e7d13-39e7-48ec-8dd6-b4ccf23373c0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 906,
                column: "CityGUID",
                value: new Guid("6d7e0e16-d820-4de8-a4e7-bb2df94e732e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 907,
                column: "CityGUID",
                value: new Guid("8a8b8802-20fe-44c8-add4-4ee684125149"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 908,
                column: "CityGUID",
                value: new Guid("87ed39de-3f28-4a1c-af51-861d2c5915a4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 909,
                column: "CityGUID",
                value: new Guid("a9f39cf2-5be1-459f-9b1c-c858abab5c16"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 910,
                column: "CityGUID",
                value: new Guid("635e5e2a-a3f6-4c55-a5f4-8140692b122a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 911,
                column: "CityGUID",
                value: new Guid("efb72333-a0ee-43ed-9b34-1455d69c8489"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 912,
                column: "CityGUID",
                value: new Guid("5a34f5d6-3200-4566-b514-d5e0777b8a0f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 913,
                column: "CityGUID",
                value: new Guid("27dd7985-298b-48b0-a4b4-3e39a034c225"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 914,
                column: "CityGUID",
                value: new Guid("458bf281-81fb-45ef-8f11-b5833b9c743c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 915,
                column: "CityGUID",
                value: new Guid("91463d85-8e46-43b1-98b1-6d48ab347ad1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 916,
                column: "CityGUID",
                value: new Guid("6d9b7f86-dc50-4534-beb6-6e54d5b28e7e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 917,
                column: "CityGUID",
                value: new Guid("1bacf1cf-0b71-4556-9856-09766c0b3c36"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 918,
                column: "CityGUID",
                value: new Guid("7f828da6-80e0-4b53-8195-0f55ea95db3d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 919,
                column: "CityGUID",
                value: new Guid("ac99631d-0092-460a-b338-611716c74e2f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 920,
                column: "CityGUID",
                value: new Guid("97e2be3c-77af-4943-aa05-0a2576f84f8f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 921,
                column: "CityGUID",
                value: new Guid("1f8d1dd0-eb55-4c84-8666-f71be06f393f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 922,
                column: "CityGUID",
                value: new Guid("fbe1b1d7-955e-4826-ae74-8e95a2adb725"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 923,
                column: "CityGUID",
                value: new Guid("aa9c2598-5da3-44a9-8d1a-746ded6daf4e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 924,
                column: "CityGUID",
                value: new Guid("b5ae4cf4-7ac2-42e5-b3da-c4b11385de07"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 925,
                column: "CityGUID",
                value: new Guid("e681a525-1c24-40bd-af0d-833d55e9b7fa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 926,
                column: "CityGUID",
                value: new Guid("0b9b5bd3-6767-42a5-a0c5-e1fffc9ee960"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 927,
                column: "CityGUID",
                value: new Guid("c3ba8e44-0069-4bdb-9eb4-6a1410232529"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 928,
                column: "CityGUID",
                value: new Guid("27355861-070e-497a-985b-4f3396ee2e0b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 929,
                column: "CityGUID",
                value: new Guid("d5849842-84fd-43f7-b26e-a23b2456f872"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 930,
                column: "CityGUID",
                value: new Guid("b5af8879-79a5-4fd8-b6a2-199b24e86dca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 931,
                column: "CityGUID",
                value: new Guid("13a8f593-9f7d-40e8-b560-2d6bcb7fd66c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 932,
                column: "CityGUID",
                value: new Guid("4a771157-e8fd-4f44-8be6-6798a82f89bc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 933,
                column: "CityGUID",
                value: new Guid("1f355e6c-2dff-4942-9b5c-18212d643ab0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 934,
                column: "CityGUID",
                value: new Guid("38d266e0-93cd-45cd-9b2d-1a22d848c333"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 935,
                column: "CityGUID",
                value: new Guid("f0caf06a-6fb3-49f0-9596-7878db272478"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 936,
                column: "CityGUID",
                value: new Guid("9d7753d1-1c56-41eb-aae6-6dd4d3e0634d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 937,
                column: "CityGUID",
                value: new Guid("225fb415-ed74-4039-9e15-33376722e513"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 938,
                column: "CityGUID",
                value: new Guid("40fc4c4c-f1a6-4e00-9946-347c4dab0d64"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 939,
                column: "CityGUID",
                value: new Guid("bfca209e-ed37-4234-b443-9196d7101b11"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 940,
                column: "CityGUID",
                value: new Guid("0e5890e6-cd03-4563-ac8d-887e8aaa5cfc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 941,
                column: "CityGUID",
                value: new Guid("ef18ecc1-bea6-42db-8059-4bf7573af3b2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 942,
                column: "CityGUID",
                value: new Guid("9ec9ab90-15a8-4141-beba-adba15526701"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 943,
                column: "CityGUID",
                value: new Guid("93636d3d-d261-4fce-8710-7673753984b0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 944,
                column: "CityGUID",
                value: new Guid("1e68e9e2-d7cc-4645-a96b-677eaab5755d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 945,
                column: "CityGUID",
                value: new Guid("e97c93c4-e9e3-4758-945a-27f546f57a49"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 946,
                column: "CityGUID",
                value: new Guid("55d7447e-1638-4ca2-93c7-169ff9c2c0aa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 947,
                column: "CityGUID",
                value: new Guid("2ae0333d-ad84-498b-ac31-13b3455b4868"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 948,
                column: "CityGUID",
                value: new Guid("ed987e6f-65d1-44c7-b4ef-e9a6c2eb725f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 949,
                column: "CityGUID",
                value: new Guid("ba7c04d4-89b7-4048-b8b8-4d1fb1b44150"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 950,
                column: "CityGUID",
                value: new Guid("2338e02f-7f69-4f96-a161-d00c39dd3922"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 951,
                column: "CityGUID",
                value: new Guid("64fb74ef-f95d-4d30-aeda-8dc6056affc0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 952,
                column: "CityGUID",
                value: new Guid("ab9eda00-26a1-4211-88d3-91db4ffd8126"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 953,
                column: "CityGUID",
                value: new Guid("5a6e1a7e-b9fc-4648-8838-35fd860059c6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 954,
                column: "CityGUID",
                value: new Guid("57363095-f3b7-425f-9d28-7e021e7f2958"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 955,
                column: "CityGUID",
                value: new Guid("0fd1b55c-94d8-4fa2-8e81-2d2668b3b392"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 956,
                column: "CityGUID",
                value: new Guid("70b5553e-66d8-4666-82e8-fdacd44d85e2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 957,
                column: "CityGUID",
                value: new Guid("00e454bd-4e75-413b-b3d8-1dddf1489f60"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 958,
                column: "CityGUID",
                value: new Guid("f1496b0f-c368-48aa-b111-a5f763851c8d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 959,
                column: "CityGUID",
                value: new Guid("92ca82bc-9e2a-4634-8737-c4ff7c7fd8d5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 960,
                column: "CityGUID",
                value: new Guid("4f7702a3-4e14-43cf-ba7b-0252190301f6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 961,
                column: "CityGUID",
                value: new Guid("4a7aa882-450e-4d34-88a8-7e10c3514058"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 962,
                column: "CityGUID",
                value: new Guid("d81c5bb4-f639-4251-9e6e-7753ffa8725c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 963,
                column: "CityGUID",
                value: new Guid("522ed9be-0905-4db0-a2b9-e7720eaa3f8c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 964,
                column: "CityGUID",
                value: new Guid("dac06942-b5cc-4aae-ab92-72ad4135026b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 965,
                column: "CityGUID",
                value: new Guid("da033f7f-abec-4389-bd62-2cf80e674c2f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 966,
                column: "CityGUID",
                value: new Guid("ac607a3c-07a8-4c5a-8f6a-42f79168349f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 967,
                column: "CityGUID",
                value: new Guid("346fee54-6695-4337-8143-bc08147119bb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 968,
                column: "CityGUID",
                value: new Guid("6c797189-5043-4367-8f65-73ff2080a985"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 969,
                column: "CityGUID",
                value: new Guid("429dc5ce-319d-49d1-88da-f0d7a90fb50c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 970,
                column: "CityGUID",
                value: new Guid("4c37fa98-0c1c-46ae-9501-7cddc4032dc6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 971,
                column: "CityGUID",
                value: new Guid("7b236e09-9b3c-4223-8078-1218d8ebc03c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 972,
                column: "CityGUID",
                value: new Guid("97bf6bdf-426e-473e-a4f9-ea3f42905d84"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 973,
                column: "CityGUID",
                value: new Guid("8e9dda7c-3888-4fef-9a64-1657413417e9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 974,
                column: "CityGUID",
                value: new Guid("a3fabc58-f181-46da-9064-3ca467d66bc2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 975,
                column: "CityGUID",
                value: new Guid("4d1a0c0b-bb0b-4181-b062-f89dd0db4bb3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 976,
                column: "CityGUID",
                value: new Guid("7391f5a2-8cc5-49a8-a74d-7203c89930a9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 977,
                column: "CityGUID",
                value: new Guid("0ef319e6-057b-4c61-ae7f-883ce6feb986"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 978,
                column: "CityGUID",
                value: new Guid("08358892-873c-42f2-b8f9-ad78d4ef07fc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 979,
                column: "CityGUID",
                value: new Guid("d23aa343-9726-4b32-906d-fe059a6f296e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 980,
                column: "CityGUID",
                value: new Guid("77e242a4-6d0a-4411-936b-ce8e5cabe0a5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 981,
                column: "CityGUID",
                value: new Guid("fac49840-eae4-492f-a0db-2290adc2ba71"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 982,
                column: "CityGUID",
                value: new Guid("a5497743-ff1f-4d44-ba2b-8ef9336c3a01"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 983,
                column: "CityGUID",
                value: new Guid("27722162-c07d-45c5-9dc1-4d4049079a6f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 984,
                column: "CityGUID",
                value: new Guid("4f2e57b9-3b47-4e83-af07-a8d4b6afa46e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 985,
                column: "CityGUID",
                value: new Guid("e9071c89-dea6-4a53-ac83-13213aac870f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 986,
                column: "CityGUID",
                value: new Guid("8ec74d6e-9e6b-4af1-9dc8-2931d5dc9de9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 987,
                column: "CityGUID",
                value: new Guid("941a8b8f-c4a8-44b6-b92f-550a1ac76d19"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 988,
                column: "CityGUID",
                value: new Guid("5545dee6-fe77-488f-9386-b3be263a4c5a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 989,
                column: "CityGUID",
                value: new Guid("37ff5cbb-0acc-42ad-8503-fdef374f2adc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 990,
                column: "CityGUID",
                value: new Guid("830f0a48-e1ce-41bd-8c54-c62f711bb857"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 991,
                column: "CityGUID",
                value: new Guid("a5892dfc-ebc0-44b7-9686-461af36cc72f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 992,
                column: "CityGUID",
                value: new Guid("6a7e0703-e7c1-4a65-977b-5e0eae38cb89"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 993,
                column: "CityGUID",
                value: new Guid("187f261a-47b6-498f-9c21-cda59a3a725e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 994,
                column: "CityGUID",
                value: new Guid("0900af00-7281-4893-8d79-9b4dacbbd265"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 995,
                column: "CityGUID",
                value: new Guid("47b6cac1-7a4c-4dc3-b315-dcce751e12d2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 996,
                column: "CityGUID",
                value: new Guid("0a21605f-23dd-453c-8e6d-28bf71751aca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 997,
                column: "CityGUID",
                value: new Guid("d53a31cf-e450-4531-992f-aafe0167b5d8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 998,
                column: "CityGUID",
                value: new Guid("f7554158-61c6-408a-981e-92df39a64b8e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 999,
                column: "CityGUID",
                value: new Guid("9d6a7500-5b96-4c40-86a3-f1046b3e8cc6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1000,
                column: "CityGUID",
                value: new Guid("2dc90070-6616-4b13-8f1a-0c4c7105a287"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1001,
                column: "CityGUID",
                value: new Guid("76c55aac-8b24-494e-b9ca-c9d33302d6ca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1002,
                column: "CityGUID",
                value: new Guid("ff41722f-cdd9-46be-a57b-105f73161d15"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1003,
                column: "CityGUID",
                value: new Guid("a66d3a7e-61a0-4f6a-bcda-6fcfa7b87cf8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1004,
                column: "CityGUID",
                value: new Guid("f0ae88d5-e513-4c49-88d7-9898412e060b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1005,
                column: "CityGUID",
                value: new Guid("56f6ac19-5397-4b23-bbf0-e1bcc8133896"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1006,
                column: "CityGUID",
                value: new Guid("726465e1-ab26-440b-9ef3-a025a78e01a7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1007,
                column: "CityGUID",
                value: new Guid("591ef018-082b-4444-a334-86ec8ada3cc9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1008,
                column: "CityGUID",
                value: new Guid("c29d8deb-c1d6-4de6-b01f-40d4bd079399"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1009,
                column: "CityGUID",
                value: new Guid("94c4b87f-3efa-4c1a-8ca1-285cdf400ab5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1010,
                column: "CityGUID",
                value: new Guid("292594b1-6fbf-4455-8065-9499b7ba5f29"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1011,
                column: "CityGUID",
                value: new Guid("05441a4f-577b-46c7-84cd-70e8c827852a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1012,
                column: "CityGUID",
                value: new Guid("ef8cf9a3-b499-4cf2-98eb-86a74730538e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1013,
                column: "CityGUID",
                value: new Guid("9cf68a94-0e1c-4015-8761-f20577f952a8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1014,
                column: "CityGUID",
                value: new Guid("39447526-281f-4f7e-94e8-721dfb68eba2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1015,
                column: "CityGUID",
                value: new Guid("b36b1393-5120-4334-ade2-53220a297a25"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1016,
                column: "CityGUID",
                value: new Guid("9b5dcdb1-ddc6-407b-ad51-ae573e1b4c60"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1017,
                column: "CityGUID",
                value: new Guid("8fefe50c-cc40-42bc-a335-cdf64f04b165"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1018,
                column: "CityGUID",
                value: new Guid("f053d86f-2127-4213-8709-825ad3d26068"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1019,
                column: "CityGUID",
                value: new Guid("bcac8c52-098a-427b-a993-8f444c192533"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1020,
                column: "CityGUID",
                value: new Guid("7ad20699-8082-4559-b122-95effc048915"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1021,
                column: "CityGUID",
                value: new Guid("d6b2b750-5696-47f4-a6a0-beb306303d97"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1022,
                column: "CityGUID",
                value: new Guid("c23e842f-e6cc-40e3-9cca-074a6036b371"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1023,
                column: "CityGUID",
                value: new Guid("57a69e6e-ba30-4a52-957f-16887b9e5b36"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1024,
                column: "CityGUID",
                value: new Guid("e1c08e1b-4b35-4406-b6f4-a7b22d6b2960"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1025,
                column: "CityGUID",
                value: new Guid("a33539a8-a6c3-4a96-a7ad-7b35e915e1dc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1026,
                column: "CityGUID",
                value: new Guid("34f49d71-38f6-4de1-9566-8590b37ee406"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1027,
                column: "CityGUID",
                value: new Guid("e8c301b0-f503-4f67-8573-5b49f4becdd2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1028,
                column: "CityGUID",
                value: new Guid("ad3e3f29-b818-4a66-b98f-93df1960f788"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1029,
                column: "CityGUID",
                value: new Guid("886a7db5-606d-4a6c-8412-b4f66e891bcc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1030,
                column: "CityGUID",
                value: new Guid("b734ccb2-e8a8-4aa6-ba26-9fd0b204a8c7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1031,
                column: "CityGUID",
                value: new Guid("23492b75-1db8-4b8b-9f3b-1bddbe7f7961"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1032,
                column: "CityGUID",
                value: new Guid("0e9f3c87-cdef-42ad-87da-b257c3c089f4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1033,
                column: "CityGUID",
                value: new Guid("c9c8fd78-4b57-4cc3-b069-514af0bd24fa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1034,
                column: "CityGUID",
                value: new Guid("1b701886-2d63-4f20-a9f7-5473482e6e08"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1035,
                column: "CityGUID",
                value: new Guid("18c7a7fd-2503-477c-bf07-11ea72fb5e75"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1036,
                column: "CityGUID",
                value: new Guid("27ec8a91-5ea2-4d2a-863a-6a602e9ddb11"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1037,
                column: "CityGUID",
                value: new Guid("568f1fed-632d-47c5-a508-35fa380f98a1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1038,
                column: "CityGUID",
                value: new Guid("dac9e7a0-09b6-49e3-a2d2-e75717153e50"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1039,
                column: "CityGUID",
                value: new Guid("f71d74e6-0cfe-40fb-93a8-8ca57faf0475"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1040,
                column: "CityGUID",
                value: new Guid("06afa4f8-2d03-46c3-b677-c629d4d74067"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1041,
                column: "CityGUID",
                value: new Guid("aae83177-8724-4620-a706-6e62602a4f55"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1042,
                column: "CityGUID",
                value: new Guid("6a34d9c3-1e24-458b-a551-ce1544701830"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1043,
                column: "CityGUID",
                value: new Guid("8c21bee4-70d5-4c12-bddb-3e94a37b7bd5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1044,
                column: "CityGUID",
                value: new Guid("54188622-d77e-4e07-a0db-998f81fc0418"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1045,
                column: "CityGUID",
                value: new Guid("5fcc8bef-e8e9-4082-8e3b-80b4278ed34a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1046,
                column: "CityGUID",
                value: new Guid("5b4b57ca-c837-4904-8105-9dab2265bfe8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1047,
                column: "CityGUID",
                value: new Guid("b47ed56c-7457-45d2-a6fa-b0f1429f92ac"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1048,
                column: "CityGUID",
                value: new Guid("08621608-5d46-49ff-b505-db32130b2cdf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1049,
                column: "CityGUID",
                value: new Guid("a981fb02-bd58-46d8-a45d-833fa8b1909a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1050,
                column: "CityGUID",
                value: new Guid("e33aabb4-dc15-497d-9b2a-83aef6bc30ab"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1051,
                column: "CityGUID",
                value: new Guid("659242d7-6167-4656-a918-59fc0ff2e889"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1052,
                column: "CityGUID",
                value: new Guid("a22b50cd-84b3-4ea7-afe4-01676157d0f5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1053,
                column: "CityGUID",
                value: new Guid("58526d29-73b5-4919-85cc-0bbef9007806"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1054,
                column: "CityGUID",
                value: new Guid("8864fcc8-f855-44d5-b3d4-3acc2b09fac9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1055,
                column: "CityGUID",
                value: new Guid("1e0f8194-12b1-4871-92d0-3417d9dd5f6e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1056,
                column: "CityGUID",
                value: new Guid("d40922da-37af-458c-8ccc-bffab12e30a5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1057,
                column: "CityGUID",
                value: new Guid("844ed926-57c5-4441-b501-19f2ea870b8b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1058,
                column: "CityGUID",
                value: new Guid("df9a3e02-0f40-40a0-befb-759f08b24fbe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1059,
                column: "CityGUID",
                value: new Guid("dc2533d6-afde-4aa7-879c-5de0412663c3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1060,
                column: "CityGUID",
                value: new Guid("779964ea-bba9-4b17-bee8-2d9f6077f5d7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1061,
                column: "CityGUID",
                value: new Guid("f2e719e9-d0dc-4698-992c-b7feb2bfa912"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1062,
                column: "CityGUID",
                value: new Guid("36bdf76c-b9b6-43c0-a179-5b99686e0c5f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1063,
                column: "CityGUID",
                value: new Guid("9b04311a-8dd1-40cf-8062-29e6f7139a5a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1064,
                column: "CityGUID",
                value: new Guid("02d18972-7d0e-4012-9b46-e602a79f647d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1065,
                column: "CityGUID",
                value: new Guid("ed9407bf-7b82-4cb7-b076-1a5b39894f61"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1066,
                column: "CityGUID",
                value: new Guid("2c544ee0-5a72-492e-bb5f-80ef78d5d8f7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1067,
                column: "CityGUID",
                value: new Guid("456863a6-09bd-4972-ae06-e86ad0077dff"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1068,
                column: "CityGUID",
                value: new Guid("c552ff11-b237-41ff-b502-d04a4337401f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1069,
                column: "CityGUID",
                value: new Guid("bbe35d7c-e266-4008-a4bc-4c2b787b6fb6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1070,
                column: "CityGUID",
                value: new Guid("bb8d31e3-f993-4bad-b8fb-9ff03290cd62"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1071,
                column: "CityGUID",
                value: new Guid("3762781d-677b-45ed-ba3f-81d18bbee1a3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1072,
                column: "CityGUID",
                value: new Guid("98556432-0a37-4b65-9d02-64f2d4c77a54"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1073,
                column: "CityGUID",
                value: new Guid("9da4125e-fd9a-4a89-bb8c-684b37d235fc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1074,
                column: "CityGUID",
                value: new Guid("a4bc6f21-a9ba-4dc0-aa41-dc37f0c27449"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1075,
                column: "CityGUID",
                value: new Guid("32f05be8-4cd6-44c4-b7a2-a1c8b7200602"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1076,
                column: "CityGUID",
                value: new Guid("c3cc9fcf-e3d2-4afb-98bd-561173e2e825"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1077,
                column: "CityGUID",
                value: new Guid("e0384a0c-aa15-492b-9ead-28448c854900"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1078,
                column: "CityGUID",
                value: new Guid("183c79d5-84b6-4a96-ab1d-69c13040bd07"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1079,
                column: "CityGUID",
                value: new Guid("08aa97e6-fd72-422b-829f-ee267f59cc4e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1080,
                column: "CityGUID",
                value: new Guid("351564b8-a20d-43bb-9c97-d8a65ad8fd20"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1081,
                column: "CityGUID",
                value: new Guid("a9737a29-da55-4fd4-87d4-e46e9fd356ed"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1082,
                column: "CityGUID",
                value: new Guid("2f3aa7a7-543d-46b3-97fb-b780fd7c844b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1083,
                column: "CityGUID",
                value: new Guid("9557a2ec-5ee8-483b-8f9a-fac467819d39"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1084,
                column: "CityGUID",
                value: new Guid("15780489-d014-4114-ac19-c8a349be7433"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1085,
                column: "CityGUID",
                value: new Guid("b0ddf290-446b-4a1a-8eb3-5cc76f165f1c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1086,
                column: "CityGUID",
                value: new Guid("5992d472-3a05-4554-9c48-9e8880c3fc65"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1087,
                column: "CityGUID",
                value: new Guid("4d6dce1a-d30f-4fba-9944-4b7ea88d4ed4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1088,
                column: "CityGUID",
                value: new Guid("f3df68dd-c05e-4da6-b84d-2991c00fe42b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1089,
                column: "CityGUID",
                value: new Guid("4ab0904c-5718-4d49-85a7-0ebe032d77e5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1090,
                column: "CityGUID",
                value: new Guid("c9d2978e-24b2-446f-89bf-1ce869baa4b9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1091,
                column: "CityGUID",
                value: new Guid("ab6bd67e-ec9a-4df9-8e0f-36a21f3be889"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1092,
                column: "CityGUID",
                value: new Guid("5be58f89-0bc3-45c3-80b0-606280454722"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1093,
                column: "CityGUID",
                value: new Guid("bb78a937-0ed7-4d67-99fc-9171ae710fd9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1094,
                column: "CityGUID",
                value: new Guid("dda6f03d-9793-4009-b8e6-b9715ff8a355"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1095,
                column: "CityGUID",
                value: new Guid("51a51458-7020-4b82-875e-8ca6f83ef89c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1096,
                column: "CityGUID",
                value: new Guid("0b6085bb-61e7-4d8a-8348-b55ff07825ce"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1097,
                column: "CityGUID",
                value: new Guid("0c2bff49-c4ac-42db-bae5-f58f34a21f9f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1098,
                column: "CityGUID",
                value: new Guid("2344a9f9-8c8a-4a82-a3dc-8d642645eb83"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1099,
                column: "CityGUID",
                value: new Guid("67766be2-8d2b-4f63-940f-cab9f0fc58bd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1100,
                column: "CityGUID",
                value: new Guid("8fd56ac3-69dc-43bf-9b43-e4c718cc062a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1101,
                column: "CityGUID",
                value: new Guid("0acdab44-0593-4640-8800-a3bfd97f41fb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1102,
                column: "CityGUID",
                value: new Guid("567a9e0f-e896-4936-9043-7baabba648d7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1103,
                column: "CityGUID",
                value: new Guid("ec3c1932-005c-44cd-be96-8ae75a7a4eb0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1104,
                column: "CityGUID",
                value: new Guid("3c8e4077-dc90-4312-a94c-0c463c66e7b0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1105,
                column: "CityGUID",
                value: new Guid("6edc0add-6d38-4388-8cff-81b941aadc22"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1106,
                column: "CityGUID",
                value: new Guid("9b27c6d4-3e01-4376-a6d8-3a79efbaee18"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1107,
                column: "CityGUID",
                value: new Guid("b5c62039-e909-4f79-bb0f-276a19b11f6e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1108,
                column: "CityGUID",
                value: new Guid("e4ad0fce-c9a9-40ce-8584-64d3acecd618"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1109,
                column: "CityGUID",
                value: new Guid("a4c9a19d-040e-465e-8970-fa7cb88edf22"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1110,
                column: "CityGUID",
                value: new Guid("11803164-2dc5-4a9b-9a3d-1ff054de93e3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1111,
                column: "CityGUID",
                value: new Guid("4e8516d2-49d2-498d-a8c1-167cbc236999"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1112,
                column: "CityGUID",
                value: new Guid("95857cd2-ebf2-4892-ad3a-c650c1710768"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1113,
                column: "CityGUID",
                value: new Guid("cdd04c6b-097c-4155-88b1-de23888b86ec"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1114,
                column: "CityGUID",
                value: new Guid("3060787f-3b37-463b-81e2-1dfd0ed9de4a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1115,
                column: "CityGUID",
                value: new Guid("cb7f1f17-7833-4b28-b212-c15e7dfa7faf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1116,
                column: "CityGUID",
                value: new Guid("aaed73f5-5148-4953-80c0-a92c27313ee7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1117,
                column: "CityGUID",
                value: new Guid("c10fd1a6-a0b7-4cc0-9256-e1101b6ce809"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1118,
                column: "CityGUID",
                value: new Guid("b4dc7b6d-7449-476c-a2f6-31626b36f09b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1119,
                column: "CityGUID",
                value: new Guid("424dbbe8-0038-4195-b86e-dcfcd3fd777b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1120,
                column: "CityGUID",
                value: new Guid("ed9857c2-adc1-4a79-a884-c9e31cd757a2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1121,
                column: "CityGUID",
                value: new Guid("3573380e-34d2-4269-89ce-f20d1478e1cf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1122,
                column: "CityGUID",
                value: new Guid("e724c2bb-011b-4c6e-977c-4354ef883ce4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1123,
                column: "CityGUID",
                value: new Guid("c98270a1-1577-4ce4-af9e-5ace04f0e496"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1124,
                column: "CityGUID",
                value: new Guid("48396530-6027-4a8c-bde8-17d531f3a5d2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1125,
                column: "CityGUID",
                value: new Guid("ff3336de-3d33-4b26-b4c8-b40f778cecaf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1126,
                column: "CityGUID",
                value: new Guid("4e0be5ed-e18f-4d23-80db-1959f4b28da7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1127,
                column: "CityGUID",
                value: new Guid("412bec2f-01ec-48c1-93b3-0e344304de7c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1128,
                column: "CityGUID",
                value: new Guid("ead8898d-af2b-4f13-a7ff-7b5e93615eee"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1129,
                column: "CityGUID",
                value: new Guid("03fffec7-d146-4d7a-b0f8-b29539de36fc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1130,
                column: "CityGUID",
                value: new Guid("0304ac41-33b4-443d-8a1e-fb58f58842c6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1131,
                column: "CityGUID",
                value: new Guid("bcb677b0-aa82-46bb-a80b-1bf00456d16d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1132,
                column: "CityGUID",
                value: new Guid("52a367cc-9099-4a54-985c-6d2dd7a97179"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1133,
                column: "CityGUID",
                value: new Guid("f202a09e-6c06-42c9-9ae8-a9bf609a6e1b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1134,
                column: "CityGUID",
                value: new Guid("1a9c46cb-db05-4c5e-9209-d4c61538912b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1135,
                column: "CityGUID",
                value: new Guid("b94604d7-3dcd-4dd6-9607-41b5126db521"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1136,
                column: "CityGUID",
                value: new Guid("fb9ceee8-f37c-4f44-a7b0-e9e08c431565"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1137,
                column: "CityGUID",
                value: new Guid("d5eb9966-20d7-43ea-bcd2-5d18f1034443"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1138,
                column: "CityGUID",
                value: new Guid("236523bb-0238-4f13-bac5-80abeff2bb0c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1139,
                column: "CityGUID",
                value: new Guid("cd0ad001-8f5f-4e8f-b6f5-81c758c54296"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1140,
                column: "CityGUID",
                value: new Guid("71762eed-676d-4be3-a03c-e907468eac40"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1141,
                column: "CityGUID",
                value: new Guid("4d6c00a1-5bb3-4d7c-b1c4-395cc340fabf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1142,
                column: "CityGUID",
                value: new Guid("adc5777d-94c8-4e8d-9596-0511d83d22de"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1143,
                column: "CityGUID",
                value: new Guid("d1fe34c2-4066-41a6-9c48-8f956679706f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1144,
                column: "CityGUID",
                value: new Guid("a0bcdb70-2112-4a82-aed6-4e2de920c4d2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1145,
                column: "CityGUID",
                value: new Guid("45b9affc-935e-4740-a98b-31655bab7b93"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1146,
                column: "CityGUID",
                value: new Guid("3f2db67a-2610-4fd7-b4e6-32f0052d6e1e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1147,
                column: "CityGUID",
                value: new Guid("8f50ee68-abf7-4f3e-812f-d8004eb126d4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1148,
                column: "CityGUID",
                value: new Guid("1ce506f6-e924-4e19-92bf-8f98b2264d30"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1149,
                column: "CityGUID",
                value: new Guid("c40edd66-f9db-4925-9069-3c7ba085c9db"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1150,
                column: "CityGUID",
                value: new Guid("6b2e2e94-c94a-480f-ab2c-f678a53eca91"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1151,
                column: "CityGUID",
                value: new Guid("5f71fdf4-1d0e-43ba-a135-c2d282f0ffc5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1152,
                column: "CityGUID",
                value: new Guid("ffac352a-4380-4350-95f8-fbd4810ede35"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1153,
                column: "CityGUID",
                value: new Guid("6bae466c-f34a-464c-9556-5632d412f0d7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1154,
                column: "CityGUID",
                value: new Guid("c1833bae-0311-442d-91d2-550fed52d0a8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1155,
                column: "CityGUID",
                value: new Guid("4c5d86b4-61f4-4ac4-855a-e3252c80bf8e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1156,
                column: "CityGUID",
                value: new Guid("e9f728ac-6e88-4cf3-99be-e5b7f8cc251b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1157,
                column: "CityGUID",
                value: new Guid("cae7c13a-1b60-4a5e-894b-deda0645aadf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1158,
                column: "CityGUID",
                value: new Guid("64736b7d-8090-4bea-91f8-3376c089a2b0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1159,
                column: "CityGUID",
                value: new Guid("d6964ff4-fa22-4da2-b54f-c7d2f2f8b49f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1160,
                column: "CityGUID",
                value: new Guid("8cc37c92-dae5-45b3-a56e-97b8a61816c4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1161,
                column: "CityGUID",
                value: new Guid("55616f36-e164-475a-9f2f-99f88cb658b7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1162,
                column: "CityGUID",
                value: new Guid("aa38907c-4db6-433f-8173-e5132e7c41b5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1163,
                column: "CityGUID",
                value: new Guid("457d5e43-aacd-471c-988a-084288c8e189"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1164,
                column: "CityGUID",
                value: new Guid("a6213733-f155-44bf-a237-6f93e64ef496"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1165,
                column: "CityGUID",
                value: new Guid("f6a65b40-63bd-4370-b458-3db009b8d962"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1166,
                column: "CityGUID",
                value: new Guid("8728b5d2-7ca7-4ef9-b2a3-c3667959b06b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1167,
                column: "CityGUID",
                value: new Guid("d98e2e85-83d5-4141-a138-ac2fbc75ed26"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1168,
                column: "CityGUID",
                value: new Guid("335e4fd6-ee05-4640-af7e-505793cfb3be"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1169,
                column: "CityGUID",
                value: new Guid("0372ff90-e3da-4835-b853-1c75759ef64e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1170,
                column: "CityGUID",
                value: new Guid("cbf467fd-aeec-459c-ad5d-0370e821b21e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1171,
                column: "CityGUID",
                value: new Guid("63cb5b36-c8bf-41fb-83fc-3e0cd52688ca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1172,
                column: "CityGUID",
                value: new Guid("dcc1bfe9-c3c4-4eb2-a3e3-e23ddd7fb1c0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1173,
                column: "CityGUID",
                value: new Guid("fc72e74a-6c49-4cf3-aea5-5744cb50582c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1174,
                column: "CityGUID",
                value: new Guid("95517e3c-e681-435a-a3a8-1e61ac9c7568"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1175,
                column: "CityGUID",
                value: new Guid("71ccd518-b51a-47c4-bb8b-aab31d70afaf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1176,
                column: "CityGUID",
                value: new Guid("b4cc9a0f-6058-4282-a586-bdb6730ba976"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1177,
                column: "CityGUID",
                value: new Guid("234e73d3-ab57-4953-b9c0-38cba59b7c5f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1178,
                column: "CityGUID",
                value: new Guid("5fd64e4d-38e2-43a8-ae52-8e73b3b0df85"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1179,
                column: "CityGUID",
                value: new Guid("72517578-c740-48e3-bc5b-d93f4c32d6e4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1180,
                column: "CityGUID",
                value: new Guid("2d69c879-8aa5-450b-a6fd-0cff2e667f3d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1181,
                column: "CityGUID",
                value: new Guid("dc7ff656-dc7b-4e47-a2fa-46ed79cadb0f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1182,
                column: "CityGUID",
                value: new Guid("24468fb0-9b5f-4689-81cf-f922c942878a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1183,
                column: "CityGUID",
                value: new Guid("47d1604d-bd0f-450c-a3d8-2681056069c9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1184,
                column: "CityGUID",
                value: new Guid("42c15461-b3ca-4a53-bb42-87361105c89b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1185,
                column: "CityGUID",
                value: new Guid("25b25c21-f17d-4e2a-9be2-5f356858159a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1186,
                column: "CityGUID",
                value: new Guid("7f484e03-96a9-4d56-b20d-7749f2638c25"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1187,
                column: "CityGUID",
                value: new Guid("c8a0626d-c141-426f-9faa-1e798b5bf39c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1188,
                column: "CityGUID",
                value: new Guid("115a0325-06d2-465c-9476-ffcbb8e45560"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1189,
                column: "CityGUID",
                value: new Guid("81a6ceb7-100a-4801-8221-6124ed7dc67b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1190,
                column: "CityGUID",
                value: new Guid("3a72a913-3a2a-4445-9311-be6e1dfcfeec"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1191,
                column: "CityGUID",
                value: new Guid("2811e6af-9698-4852-9520-44b6abd88c09"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1192,
                column: "CityGUID",
                value: new Guid("734b8e44-b1e0-43e7-82ea-dbe40041198b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1193,
                column: "CityGUID",
                value: new Guid("1c2631e8-70e5-4d67-8265-e759cbd708ca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1194,
                column: "CityGUID",
                value: new Guid("6e47236c-53ca-439c-b581-a54fb73ebbf6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1195,
                column: "CityGUID",
                value: new Guid("25295e47-7eb4-4caa-9afc-72e8ce70c515"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1196,
                column: "CityGUID",
                value: new Guid("4ad66b6c-a292-4298-91f7-9231188ee24d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1197,
                column: "CityGUID",
                value: new Guid("667cfc35-f511-4a6d-9006-4cd2ea4907be"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1198,
                column: "CityGUID",
                value: new Guid("33b7c2b5-a121-4a1f-b1d9-80cd92bace14"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1199,
                column: "CityGUID",
                value: new Guid("a2d4d774-4acd-49cc-a7f3-b26bab8d0f18"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1200,
                column: "CityGUID",
                value: new Guid("71cad36a-4bb0-46f8-a6f9-9c925cd13fd6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1201,
                column: "CityGUID",
                value: new Guid("00a49533-8caf-41eb-88ac-9b354ab32248"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1202,
                column: "CityGUID",
                value: new Guid("a46dcd16-4554-4493-97e0-3e036444254c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1203,
                column: "CityGUID",
                value: new Guid("12820393-5c49-48f5-bef1-c67dc9e519d9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1204,
                column: "CityGUID",
                value: new Guid("9abc356b-91af-4e11-b848-4adec5c30c2e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1205,
                column: "CityGUID",
                value: new Guid("7e6813be-b82e-48a9-9d6d-65749522b08b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1206,
                column: "CityGUID",
                value: new Guid("2c981e6b-f347-4049-a697-5d47de86fa19"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1207,
                column: "CityGUID",
                value: new Guid("6feee037-b61a-4984-b2cf-55d4954839a3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1208,
                column: "CityGUID",
                value: new Guid("965628aa-37e0-4ba9-b6a9-8255b238a85e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1209,
                column: "CityGUID",
                value: new Guid("4c271d83-4f4b-4be7-b091-b7af84a2af80"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1210,
                column: "CityGUID",
                value: new Guid("26d4df02-86a4-4344-b42a-bbc51c2f042f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1211,
                column: "CityGUID",
                value: new Guid("81a7c5f0-363f-40b8-8b8a-7a17c4089bcb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1212,
                column: "CityGUID",
                value: new Guid("8f233867-e03e-4ef4-984c-f124a408e744"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1213,
                column: "CityGUID",
                value: new Guid("409048eb-4feb-4ad7-8c4e-5949dec97cab"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1214,
                column: "CityGUID",
                value: new Guid("8bb05dc0-d24b-49e0-8e2b-048387f9bf46"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1215,
                column: "CityGUID",
                value: new Guid("0c090e54-5238-4480-ac31-dfe69afc250a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1216,
                column: "CityGUID",
                value: new Guid("40ba44ff-55f5-4645-9645-b836d58416b7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1217,
                column: "CityGUID",
                value: new Guid("e92ad3f5-85b4-4378-8cf4-9a1e6b6ba1ec"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1218,
                column: "CityGUID",
                value: new Guid("bbbaa2b8-59b0-4390-8e16-cd8035834bff"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1219,
                column: "CityGUID",
                value: new Guid("8f955de8-170b-419f-b077-dc7465e18760"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1220,
                column: "CityGUID",
                value: new Guid("c75addab-ddbf-477a-a6e0-afba51a34ead"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1221,
                column: "CityGUID",
                value: new Guid("1b1b0263-af15-4ef3-8a46-fe924753fcf0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1222,
                column: "CityGUID",
                value: new Guid("1fa786f8-a9b9-412f-86fb-fdc28e0bb8c1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1223,
                column: "CityGUID",
                value: new Guid("d39da73d-c3d2-4266-87f2-2ac872131a88"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1224,
                column: "CityGUID",
                value: new Guid("9fce22dd-fd57-4a89-b509-e37bf989bb12"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1225,
                column: "CityGUID",
                value: new Guid("320a1af6-9b94-4e89-b515-f521beda83b0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1226,
                column: "CityGUID",
                value: new Guid("e6773d67-1d1b-499e-bf90-d7205a7416c4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1227,
                column: "CityGUID",
                value: new Guid("ff5e58ae-8712-4349-a747-071dcdfdc03d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1228,
                column: "CityGUID",
                value: new Guid("bd082910-f72f-4276-8551-3ddb87578c78"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1229,
                column: "CityGUID",
                value: new Guid("2f790631-62e8-4a8a-9824-a5769fb113b3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1230,
                column: "CityGUID",
                value: new Guid("a7c52cef-5707-4fbd-b8a1-d6a3334b743a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1231,
                column: "CityGUID",
                value: new Guid("43cce439-d222-40c1-9f7c-c856b8c4f86a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1232,
                column: "CityGUID",
                value: new Guid("99b228b9-53f1-4a5f-ae32-c17dc546d6d7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1233,
                column: "CityGUID",
                value: new Guid("0dece110-321c-4eda-9011-f8d30249aa68"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1234,
                column: "CityGUID",
                value: new Guid("454904fd-c803-4de8-b176-9a806c01067a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1235,
                column: "CityGUID",
                value: new Guid("b7455b67-f1a4-4b69-826b-904b21b4d5b6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1236,
                column: "CityGUID",
                value: new Guid("b05c4cf0-a5fb-4280-bf8f-fa710241bc6b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1237,
                column: "CityGUID",
                value: new Guid("11e433d0-a97f-464e-8ca5-49948679b521"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1238,
                column: "CityGUID",
                value: new Guid("8689bb81-5db7-4f53-a546-b51ad5a66fdc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1239,
                column: "CityGUID",
                value: new Guid("1316b11c-7b5f-444f-8186-fe4c7cfdf48d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1240,
                column: "CityGUID",
                value: new Guid("7f38c1ed-d22c-4850-be29-3cac708c7678"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1241,
                column: "CityGUID",
                value: new Guid("5f236593-c25a-4c5e-989f-9555c1184d75"));

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientID",
                keyValue: 1,
                columns: new[] { "ClientGUID", "ModifiedDate" },
                values: new object[] { new Guid("3e23042d-5287-4518-ae52-b65e0a536513"), new DateTime(2020, 7, 1, 17, 50, 21, 845, DateTimeKind.Local).AddTicks(6431) });

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 1,
                column: "CodeGUID",
                value: new Guid("fc20e91f-1eb1-4912-87be-1708f2706367"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 2,
                column: "CodeGUID",
                value: new Guid("3f009296-db7a-4fde-a659-4ca1541a2504"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 3,
                column: "CodeGUID",
                value: new Guid("3209341a-07d4-437b-9301-2d0f909ad713"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 4,
                column: "CodeGUID",
                value: new Guid("09cb21ac-d99e-42ba-904d-337bdd561e6e"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 5,
                column: "CodeGUID",
                value: new Guid("2383b70e-f41f-4b67-b0c9-c48706a70a46"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 6,
                column: "CodeGUID",
                value: new Guid("cf5a1929-db68-43d6-8fc7-e3b7ccc51678"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 7,
                column: "CodeGUID",
                value: new Guid("2b451e4c-c9b8-415a-bcb4-05da15447b89"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 8,
                column: "CodeGUID",
                value: new Guid("6e48b657-2c83-4481-a9c5-009ffe10158b"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 9,
                column: "CodeGUID",
                value: new Guid("b5d74bda-849b-427c-a6e0-463c1e5f615b"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 10,
                column: "CodeGUID",
                value: new Guid("10afdac9-a075-40e1-9207-1813befcf4d6"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 11,
                column: "CodeGUID",
                value: new Guid("2b9d07c8-5535-495e-8557-da32acb58600"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 12,
                column: "CodeGUID",
                value: new Guid("61960336-e912-4658-9ab3-59f4c58e0b23"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 13,
                column: "CodeGUID",
                value: new Guid("46a09d81-c57f-4655-a8f5-027c66a6cfb1"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 14,
                column: "CodeGUID",
                value: new Guid("91b3cdab-39c1-40fb-b077-a2d6e611f50a"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 15,
                column: "CodeGUID",
                value: new Guid("959b10a3-b8ed-4a9d-bdf3-17ec9b2ceb15"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 16,
                column: "CodeGUID",
                value: new Guid("a05c4f54-5999-42b9-a36f-6a04aa7cd476"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 17,
                column: "CodeGUID",
                value: new Guid("ccef9d1f-343b-442a-a041-1908e4cbc235"));

            migrationBuilder.UpdateData(
                table: "CodeGroup",
                keyColumn: "CodeGroupID",
                keyValue: 1,
                column: "CodeGroupGUID",
                value: new Guid("5b739a57-164e-4b39-8b1c-1129bc9d8991"));

            migrationBuilder.UpdateData(
                table: "CodeGroup",
                keyColumn: "CodeGroupID",
                keyValue: 2,
                column: "CodeGroupGUID",
                value: new Guid("2d9c9e83-39eb-42d7-b71f-ef26002c8470"));

            migrationBuilder.UpdateData(
                table: "CodeGroup",
                keyColumn: "CodeGroupID",
                keyValue: 3,
                column: "CodeGroupGUID",
                value: new Guid("a76da3ba-d12a-42c4-b7e1-732d0990af70"));

            migrationBuilder.UpdateData(
                table: "CodeGroup",
                keyColumn: "CodeGroupID",
                keyValue: 4,
                column: "CodeGroupGUID",
                value: new Guid("39c56245-8e42-4cef-8ddd-5e4c17782e8b"));

            migrationBuilder.UpdateData(
                table: "CodeGroup",
                keyColumn: "CodeGroupID",
                keyValue: 5,
                column: "CodeGroupGUID",
                value: new Guid("7e9db57a-0c09-47ff-98b5-f49363beff67"));

            migrationBuilder.UpdateData(
                table: "CodeGroup",
                keyColumn: "CodeGroupID",
                keyValue: 6,
                column: "CodeGroupGUID",
                value: new Guid("107a7244-6e66-4369-8ba6-dfb0636642c4"));

            migrationBuilder.UpdateData(
                table: "Contractor",
                keyColumn: "ContractorID",
                keyValue: 1,
                columns: new[] { "ContractorGUID", "ModifiedDate" },
                values: new object[] { new Guid("bbf24acc-56bc-4c0b-ae91-d95ff791923a"), new DateTime(2020, 7, 1, 17, 50, 21, 847, DateTimeKind.Local).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "Contractor",
                keyColumn: "ContractorID",
                keyValue: 2,
                columns: new[] { "ContractorGUID", "ModifiedDate" },
                values: new object[] { new Guid("fc96e2fd-9915-4865-93b1-8964671c44c5"), new DateTime(2020, 7, 1, 17, 50, 21, 847, DateTimeKind.Local).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 1,
                column: "ContractorCategoryGUID",
                value: new Guid("3277133e-7642-45fc-9bb1-9e6e59e8a4b2"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 2,
                column: "ContractorCategoryGUID",
                value: new Guid("fd3e034d-6694-4885-b6a2-59fb8ea33a85"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 3,
                column: "ContractorCategoryGUID",
                value: new Guid("4d593bb7-339a-4a7a-a9d5-38bc76a1f116"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 4,
                column: "ContractorCategoryGUID",
                value: new Guid("6971dd5c-37e7-4187-ac78-08dd762f96a7"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 5,
                column: "ContractorCategoryGUID",
                value: new Guid("37e03151-bd61-4c6f-ae9c-366b57cc339f"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 6,
                column: "ContractorCategoryGUID",
                value: new Guid("1733905a-45e7-445c-871b-21003f3f9660"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 7,
                column: "ContractorCategoryGUID",
                value: new Guid("eefb1d7b-9891-442c-8405-db18c10c2289"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 8,
                column: "ContractorCategoryGUID",
                value: new Guid("e31a3135-cbde-4aeb-9bfd-8b477b5742e1"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 9,
                column: "ContractorCategoryGUID",
                value: new Guid("0f63ded9-d44b-4840-915f-0b0355dac38f"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 10,
                column: "ContractorCategoryGUID",
                value: new Guid("e45e559a-ab48-4a20-ae7e-3560841ec480"));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "OrderGUID" },
                values: new object[] { new DateTime(2020, 7, 1, 17, 50, 21, 848, DateTimeKind.Local).AddTicks(9144), new Guid("1c520372-98e0-4cba-ad67-15188e35814c") });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "OrderGUID" },
                values: new object[] { new DateTime(2020, 7, 1, 17, 50, 21, 848, DateTimeKind.Local).AddTicks(9809), new Guid("538bb304-687d-41b0-b56d-6e84b184b327") });

            migrationBuilder.UpdateData(
                table: "OrderRequest",
                keyColumn: "OrderRequestID",
                keyValue: 1,
                columns: new[] { "IsAllow", "ModifiedDate", "OrderRequestGUID" },
                values: new object[] { true, new DateTime(2020, 7, 1, 17, 50, 21, 849, DateTimeKind.Local).AddTicks(6613), new Guid("0460d528-4960-4ddc-8002-946f2073967c") });

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 1,
                column: "ProvinceGUID",
                value: new Guid("049f24a9-922b-447b-a6da-cafd33fa6ad0"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 2,
                column: "ProvinceGUID",
                value: new Guid("435946e6-59c8-47cc-8484-a019a8ea084f"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 3,
                column: "ProvinceGUID",
                value: new Guid("c106c104-a017-48cd-a52f-82013289e339"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 4,
                column: "ProvinceGUID",
                value: new Guid("ca088632-e7bd-4a95-807d-049e6441836e"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 5,
                column: "ProvinceGUID",
                value: new Guid("c87ed4e2-ab08-4896-845b-b2651dbd51a2"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 6,
                column: "ProvinceGUID",
                value: new Guid("9df0d206-f22d-46cf-b62c-74a86d2e1ddc"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 7,
                column: "ProvinceGUID",
                value: new Guid("9637a662-757e-4dc1-8427-c8c6ae37df35"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 8,
                column: "ProvinceGUID",
                value: new Guid("57f4af45-fc7a-4649-bbab-5c16a628f2f4"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 9,
                column: "ProvinceGUID",
                value: new Guid("c09e16d3-2e69-4938-a752-316d0d711eab"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 10,
                column: "ProvinceGUID",
                value: new Guid("6d66ae37-fdd8-4a07-a250-53f59f73e663"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 11,
                column: "ProvinceGUID",
                value: new Guid("79de92ae-f82a-4be2-aedd-220f2500e75b"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 12,
                column: "ProvinceGUID",
                value: new Guid("4ef8883d-64af-475b-87b6-84a1ea844eaf"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 13,
                column: "ProvinceGUID",
                value: new Guid("b1e6046f-c3fd-4078-99cd-b7e093cfa2ca"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 14,
                column: "ProvinceGUID",
                value: new Guid("2f312968-c437-48d4-ae76-cb9e9315716c"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 15,
                column: "ProvinceGUID",
                value: new Guid("7671b2b3-f3fd-4537-a04b-5db52379a435"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 16,
                column: "ProvinceGUID",
                value: new Guid("a9057332-4e34-45df-b799-606b8742184d"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 17,
                column: "ProvinceGUID",
                value: new Guid("3854e368-e7d0-465f-8001-a1d9ca84df16"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 18,
                column: "ProvinceGUID",
                value: new Guid("cbab8b89-54f4-4cf6-b6ad-c807ce5a8d09"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 19,
                column: "ProvinceGUID",
                value: new Guid("dc48480f-413a-49f8-93c5-8c3200262fb4"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 20,
                column: "ProvinceGUID",
                value: new Guid("1b3c4262-60cb-4c3e-850e-98d8357cca23"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 21,
                column: "ProvinceGUID",
                value: new Guid("8badfaeb-1a90-4c08-88ea-db941b0390d1"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 22,
                column: "ProvinceGUID",
                value: new Guid("7a560427-246b-4131-b7e8-9e65cd48d12d"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 23,
                column: "ProvinceGUID",
                value: new Guid("0f252e84-e57c-4419-8e72-1c082d8f7160"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 24,
                column: "ProvinceGUID",
                value: new Guid("32f43383-d519-4cd3-85f3-aae2bced973d"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 25,
                column: "ProvinceGUID",
                value: new Guid("41071985-9f01-4f04-8cfb-d1971c1f4985"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 26,
                column: "ProvinceGUID",
                value: new Guid("5508de98-b4c9-446b-9deb-8ce04af525df"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 27,
                column: "ProvinceGUID",
                value: new Guid("2f4602be-4e89-4cd9-9627-01574e471f5f"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 28,
                column: "ProvinceGUID",
                value: new Guid("65e90853-048a-4d53-b748-300bc94cb925"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 29,
                column: "ProvinceGUID",
                value: new Guid("904706ed-88f9-45bb-859a-9d871ad6c829"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 30,
                column: "ProvinceGUID",
                value: new Guid("e65bea99-5db4-4152-99e3-8075aa5a896d"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 31,
                column: "ProvinceGUID",
                value: new Guid("e1429c98-2662-4a9b-bf5e-4fcb95f18275"));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RoleGUID" },
                values: new object[] { new DateTime(2020, 7, 1, 17, 50, 21, 839, DateTimeKind.Local).AddTicks(1679), new Guid("6a179ee6-dcfa-4517-8de2-8784c9d00bb4") });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "RoleGUID" },
                values: new object[] { new DateTime(2020, 7, 1, 17, 50, 21, 842, DateTimeKind.Local).AddTicks(1617), new Guid("1a4b2980-63de-43a5-96e9-9675fa25e87e") });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleID",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "RoleGUID" },
                values: new object[] { new DateTime(2020, 7, 1, 17, 50, 21, 842, DateTimeKind.Local).AddTicks(1680), new Guid("50349b52-3f20-427c-aaf8-b78367079ed9") });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "IsActive", "IsRegister", "ModifiedDate", "RegisteredDate", "UserGUID" },
                values: new object[] { true, true, new DateTime(2020, 7, 1, 17, 50, 21, 844, DateTimeKind.Local).AddTicks(491), new DateTime(2020, 7, 1, 17, 50, 21, 843, DateTimeKind.Local).AddTicks(9763), new Guid("b2628f56-2c51-479f-9417-cb6faacce20a") });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "IsActive", "IsRegister", "ModifiedDate", "RegisteredDate", "UserGUID" },
                values: new object[] { true, true, new DateTime(2020, 7, 1, 17, 50, 21, 844, DateTimeKind.Local).AddTicks(2699), new DateTime(2020, 7, 1, 17, 50, 21, 844, DateTimeKind.Local).AddTicks(2671), new Guid("73d24c15-b8c8-4da4-9db0-52ddded8f5d1") });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "IsActive", "IsRegister", "ModifiedDate", "RegisteredDate", "UserGUID" },
                values: new object[] { true, true, new DateTime(2020, 7, 1, 17, 50, 21, 844, DateTimeKind.Local).AddTicks(2791), new DateTime(2020, 7, 1, 17, 50, 21, 844, DateTimeKind.Local).AddTicks(2787), new Guid("f94fbb1c-d4e3-4162-8390-71cce6c7ab5f") });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "IsActive", "IsRegister", "ModifiedDate", "RegisteredDate", "UserGUID" },
                values: new object[] { true, true, new DateTime(2020, 7, 1, 17, 50, 21, 844, DateTimeKind.Local).AddTicks(2806), new DateTime(2020, 7, 1, 17, 50, 21, 844, DateTimeKind.Local).AddTicks(2803), new Guid("0419dfaa-190d-426f-a074-d6b3ba168b1e") });

            migrationBuilder.CreateIndex(
                name: "IX_Category_SecondPageCoverDocumentID",
                table: "Category",
                column: "SecondPageCoverDocumentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_SecondPageCoverDocument",
                table: "Category",
                column: "SecondPageCoverDocumentID",
                principalTable: "Document",
                principalColumn: "DocumentID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_SecondPageCoverDocument",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_SecondPageCoverDocumentID",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "SecondPageCoverDocumentID",
                table: "Category");

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "AdminID",
                keyValue: 1,
                columns: new[] { "AdminGUID", "ModifiedDate" },
                values: new object[] { new Guid("9707c971-426d-4dc9-bac0-eb5fa4560caf"), new DateTime(2020, 7, 1, 4, 1, 43, 348, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("c265fd02-0194-4d38-83e8-a93bc3698fcc"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("dec37f17-0ab2-4208-8ba7-11cc1120369b"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("69b561bb-9a82-407f-8933-11838efcd214"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 4,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("2799b953-510e-41a9-9a74-b315f7ed52d8"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 5,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("00350d88-fcea-413d-9716-e67e5da60a1f"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 6,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("10764b94-8153-4e64-b2db-d186b6ced6ac"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(3806) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 7,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("898723a2-2457-4136-abae-752a68771720"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 8,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("b0f2ac1d-5b23-45f1-8538-fabc9302a4b8"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(3824) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 9,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("41552a1c-a773-458a-9c1b-2dee640d5195"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 10,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("76d55030-f5a0-452a-b472-d6c85debc4bd"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(3967) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 11,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("5393befe-7c25-49e2-818c-28a95ee73796"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 12,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("344025c1-fc8f-4178-88ad-99fb2e174202"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 13,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("9f93d7f1-2b72-420e-bbe7-e7fcbb83c3df"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4001) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 14,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("6b3de4b8-836f-4559-ab5b-b686fcfa1eb2"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 15,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("0f8232b9-5fef-42c6-8096-d921f02a1cac"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 16,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("d20f47af-f372-4fce-8b12-3cd1e22e96bb"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 17,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("3db5bbbb-26da-4ff2-947e-90cb12df3e1c"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 18,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("1601b2f8-2c46-4718-885c-4077dbf5ae92"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 19,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("fab07a47-071c-4277-a3f1-5b2735925d69"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4059) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 20,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("4d931de7-4963-4e3e-9dd0-3ce70c9b28ce"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 21,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("e633afd7-fb69-4044-b93a-fc34ddd0485f"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4076) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 22,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("443eb6e5-8442-475e-9183-1d3c6d58cd0e"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4085) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 23,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("343d5fc0-f9ce-4f24-bf52-60ae87effd0b"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 24,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("17aa1213-c39c-4ba1-8675-e910f890125a"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 25,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("1f14c53b-dd94-4bf6-913d-a6f2171b8660"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 26,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("e15abbd7-574b-47f2-ba3a-424422f5fd9a"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 27,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("4e588b93-2e8e-4e52-8a32-e5004628e9b0"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 28,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("918df776-dccd-4a52-a692-9b73283f5a5e"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 29,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("d25d2a5e-e63d-444c-bfa1-2d3d2dc81783"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 30,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("518b8e6a-41dc-4dc7-8282-e0440afc333b"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 31,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("ac385d15-143d-4b98-9ccb-044e4919991e"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 32,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("45348ddb-73f6-455c-8c30-735e57ce04a0"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4236) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 33,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("286ef415-a51b-4dc7-875c-06aa3b8c2be4"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4245) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 34,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("f8c31135-bf20-4ea8-a47d-e3f3c6f20a48"), true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1,
                column: "CityGUID",
                value: new Guid("48105679-247b-45af-9ae4-0d1985e67285"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 2,
                column: "CityGUID",
                value: new Guid("f2d7a298-18d6-4ef2-be1f-2abfcc23b1cf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 3,
                column: "CityGUID",
                value: new Guid("dd34ef4e-6af8-4dbf-a5fe-a63f719e40a4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 4,
                column: "CityGUID",
                value: new Guid("949db81e-6eef-49c5-8a61-6f5a6f580d43"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 5,
                column: "CityGUID",
                value: new Guid("8e291c9d-2b05-4dd6-976a-e587a08a7338"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 6,
                column: "CityGUID",
                value: new Guid("1e41b7ad-797a-4d96-98fb-b0ce92c44abb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 7,
                column: "CityGUID",
                value: new Guid("5b193daf-59d3-4747-99a5-04d363d6eec7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 8,
                column: "CityGUID",
                value: new Guid("2080ce67-443c-486a-8939-3aa4cfd0b482"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 9,
                column: "CityGUID",
                value: new Guid("d4dfcb58-3198-486c-8bd9-bedf87eac399"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 10,
                column: "CityGUID",
                value: new Guid("4ee1a483-cc30-4e04-87d9-d78d68057119"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 11,
                column: "CityGUID",
                value: new Guid("c8426f1c-c25d-4435-bfa2-5470edcd8399"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 12,
                column: "CityGUID",
                value: new Guid("de0d91e3-d7ef-409e-820c-93dcca09eb64"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 13,
                column: "CityGUID",
                value: new Guid("4579d8df-03d8-4534-bde3-39e2bc8883db"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 14,
                column: "CityGUID",
                value: new Guid("75146164-0d58-4345-8fcc-e9180f6deda6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 15,
                column: "CityGUID",
                value: new Guid("46c993da-40dc-455b-897e-0cad23f69d79"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 16,
                column: "CityGUID",
                value: new Guid("c0534419-5b8d-452f-9c4b-107013f8d15f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 17,
                column: "CityGUID",
                value: new Guid("f14c3c50-70d8-4fa3-825b-9fc3657d660f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 18,
                column: "CityGUID",
                value: new Guid("c39def21-f1a5-438a-a7f7-6d664ce8fc40"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 19,
                column: "CityGUID",
                value: new Guid("79fa4faa-e8b7-4e94-8043-b1e63729fdb3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 20,
                column: "CityGUID",
                value: new Guid("ff16df95-ced9-44a8-96e0-4dcdba25e8ce"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 21,
                column: "CityGUID",
                value: new Guid("4463f97d-3d57-40db-81de-168ee2a8f5fa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 22,
                column: "CityGUID",
                value: new Guid("2c6c230a-460c-424a-a92b-ed55499bc563"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 23,
                column: "CityGUID",
                value: new Guid("ac80c203-4922-4822-8c0a-e0e2f6f3c8e6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 24,
                column: "CityGUID",
                value: new Guid("89e5d50f-304d-4e24-8c3a-99907f86388f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 25,
                column: "CityGUID",
                value: new Guid("57ad1acf-f559-460f-af4a-18299d9c4aa4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 26,
                column: "CityGUID",
                value: new Guid("8c7841d3-092a-41bf-989d-dbbb9d5be9bf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 27,
                column: "CityGUID",
                value: new Guid("d9d92815-47d1-442c-9fa9-e01389ad1b20"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 28,
                column: "CityGUID",
                value: new Guid("a8be92e1-8115-4afa-a3a9-717070ec4cde"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 29,
                column: "CityGUID",
                value: new Guid("b34cfa3f-6158-4f6c-ac27-561ffdedc55a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 30,
                column: "CityGUID",
                value: new Guid("bf4e05e8-8a0a-43d9-bd63-9dd8f6146ab9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 31,
                column: "CityGUID",
                value: new Guid("befe43e1-0412-4b0c-bf9e-b71020ad7970"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 32,
                column: "CityGUID",
                value: new Guid("c83decba-b41f-4348-8abe-e27f8ecc899b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 33,
                column: "CityGUID",
                value: new Guid("ff50f4c5-fd80-4796-bd8b-aa184afab551"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 34,
                column: "CityGUID",
                value: new Guid("dbe6bf1a-fcf6-4345-a13a-0215dcf35770"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 35,
                column: "CityGUID",
                value: new Guid("a57aea86-8f5c-4544-9c32-926dc2c4fd29"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 36,
                column: "CityGUID",
                value: new Guid("5e0acf2b-3a9f-4823-999f-0a482429f7ef"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 37,
                column: "CityGUID",
                value: new Guid("0a7b899d-908f-49f9-967a-246726a602d3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 38,
                column: "CityGUID",
                value: new Guid("b48e0a52-f6ad-4c12-84fb-0da305ed9227"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 39,
                column: "CityGUID",
                value: new Guid("f040568b-c444-4b21-ba10-81a546e18e57"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 40,
                column: "CityGUID",
                value: new Guid("7aa22d84-1776-4cf5-a38f-b8718706a6d5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 41,
                column: "CityGUID",
                value: new Guid("e8f493e7-873e-4391-a0ec-5598a0bdf8da"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 42,
                column: "CityGUID",
                value: new Guid("ce71a97a-1ab5-4710-bbff-0c05c7700911"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 43,
                column: "CityGUID",
                value: new Guid("a40f9b9f-95b5-41bf-83d4-7c57cc7159b5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 44,
                column: "CityGUID",
                value: new Guid("c60a0801-81ee-44b2-a006-817fcb851f33"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 45,
                column: "CityGUID",
                value: new Guid("e3963aed-abc2-4151-9ef4-bea902228b63"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 46,
                column: "CityGUID",
                value: new Guid("323cad32-b871-46cf-8133-076930e4fbb9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 47,
                column: "CityGUID",
                value: new Guid("cc0fb3aa-21c7-4d2f-89af-eca282f766aa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 48,
                column: "CityGUID",
                value: new Guid("e67c431c-254e-4df6-b377-f871f82077e4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 49,
                column: "CityGUID",
                value: new Guid("793f4457-0628-46c2-b3c2-ea13a8235ae6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 50,
                column: "CityGUID",
                value: new Guid("49262861-2a81-45ff-b30f-fe2ffc0794c0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 51,
                column: "CityGUID",
                value: new Guid("66a96dd5-f273-4a52-9e70-d1005a2bdba6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 52,
                column: "CityGUID",
                value: new Guid("35422fc2-012e-4888-bfe9-58836d4700a1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 53,
                column: "CityGUID",
                value: new Guid("d3ee2980-028a-4a83-83e8-1ae4a0ed19ec"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 54,
                column: "CityGUID",
                value: new Guid("57201e6d-2ab1-4ef6-89c9-e39427fe8dfb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 55,
                column: "CityGUID",
                value: new Guid("3643d17b-ecbf-4241-9536-f1887a4199fb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 56,
                column: "CityGUID",
                value: new Guid("00c67fed-a9a3-40fc-bc2b-f28e465aef53"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 57,
                column: "CityGUID",
                value: new Guid("dc1cb1ed-5815-406d-9389-d1e95ce4ac05"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 58,
                column: "CityGUID",
                value: new Guid("6bd6cc59-6467-4f18-8bc6-78eed32419e6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 59,
                column: "CityGUID",
                value: new Guid("c6ef4aeb-e14d-45ca-9b45-67076647a9c6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 60,
                column: "CityGUID",
                value: new Guid("9d832541-7133-425e-9f76-363ef8f153d3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 61,
                column: "CityGUID",
                value: new Guid("a65ce6d3-2d50-4983-8370-78dce0c040ea"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 62,
                column: "CityGUID",
                value: new Guid("50a265d9-ad85-44f1-b827-02f74924a56d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 63,
                column: "CityGUID",
                value: new Guid("2ead0e36-428b-45dc-bf18-fd8ee331c7e9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 64,
                column: "CityGUID",
                value: new Guid("858c51e4-8550-484b-8644-1fde69e29fa1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 65,
                column: "CityGUID",
                value: new Guid("020e3abe-1de4-4d9e-8d25-0ee5b8c03aca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 66,
                column: "CityGUID",
                value: new Guid("ce5229b0-32a1-4855-b1d7-fba5fcd06125"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 67,
                column: "CityGUID",
                value: new Guid("26b821ce-75cd-4c2b-adaa-a860f24bf35d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 68,
                column: "CityGUID",
                value: new Guid("0a302fe7-b748-4a33-b1fe-ab2894bbb2d5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 69,
                column: "CityGUID",
                value: new Guid("8018846e-e337-4da3-ac70-980acafda69c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 70,
                column: "CityGUID",
                value: new Guid("b939fa85-1cdb-46cd-be2d-a48bba35abe9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 71,
                column: "CityGUID",
                value: new Guid("82d9690e-a92d-4c23-ba62-e879183a19e2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 72,
                column: "CityGUID",
                value: new Guid("39284a32-503b-4469-a253-32143ffe29b3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 73,
                column: "CityGUID",
                value: new Guid("443faeab-9bd2-4bdb-84c7-07c9c2f6d0e8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 74,
                column: "CityGUID",
                value: new Guid("94bf1a69-d486-499e-aabd-1082204f0071"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 75,
                column: "CityGUID",
                value: new Guid("937ce8c7-24d1-4b95-9987-6c89ef5142ad"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 76,
                column: "CityGUID",
                value: new Guid("f086d162-b6d4-4828-9cc5-63a79240cc48"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 77,
                column: "CityGUID",
                value: new Guid("414848f3-ad16-4798-b748-883746b97fb9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 78,
                column: "CityGUID",
                value: new Guid("c996f1b8-22e9-4c09-aa2a-e06454ca4cd0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 79,
                column: "CityGUID",
                value: new Guid("b485a174-a465-4f82-a448-20881d244ef7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 80,
                column: "CityGUID",
                value: new Guid("91cf47a8-b60a-4b37-b7fa-27a320a5575f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 81,
                column: "CityGUID",
                value: new Guid("d4a2850a-97b0-45f3-8d47-762d449a1be5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 82,
                column: "CityGUID",
                value: new Guid("fefb737e-368b-4d79-b5cd-8a93a02f5939"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 83,
                column: "CityGUID",
                value: new Guid("d1e9ed53-ea88-492d-880c-e670ca4fa13b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 84,
                column: "CityGUID",
                value: new Guid("46b4748a-5dcc-4fe1-9e13-f5fa058e9636"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 85,
                column: "CityGUID",
                value: new Guid("d9597532-1225-41ae-8cd8-44cbd05ccf1e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 86,
                column: "CityGUID",
                value: new Guid("60c06ce1-e9d5-4fe3-936a-298e4b56dd6d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 87,
                column: "CityGUID",
                value: new Guid("e8789a9e-6277-442b-bbea-0fa694bdd8e1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 88,
                column: "CityGUID",
                value: new Guid("6d53a57f-0e87-4fcb-9469-33d6bd656603"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 89,
                column: "CityGUID",
                value: new Guid("503e4383-926c-4fac-beb5-41cf65f873c4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 90,
                column: "CityGUID",
                value: new Guid("92bb9bcd-bbf5-49d2-8773-28b86587e61e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 91,
                column: "CityGUID",
                value: new Guid("a4950b31-3777-4b32-bb0d-434b305e1a0e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 92,
                column: "CityGUID",
                value: new Guid("4fe8162d-a3ef-4f8c-a278-9afc86382cef"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 93,
                column: "CityGUID",
                value: new Guid("d38dd64e-8bb1-43bb-8c68-f356914c4046"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 94,
                column: "CityGUID",
                value: new Guid("d697215b-2a8c-42ef-ae43-5809d352ae5b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 95,
                column: "CityGUID",
                value: new Guid("437708cd-448f-4920-8843-351f2e18d374"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 96,
                column: "CityGUID",
                value: new Guid("8cbb4aae-9405-42fe-a4a4-4b7c1a22dcef"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 97,
                column: "CityGUID",
                value: new Guid("980dc0b2-122e-403f-9e44-b78a6bd79a19"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 98,
                column: "CityGUID",
                value: new Guid("120ab10c-f041-4828-bb25-c561d58b2faf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 99,
                column: "CityGUID",
                value: new Guid("7213bf7d-9fdf-44ef-8de4-fb3f12efb544"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 100,
                column: "CityGUID",
                value: new Guid("f54ece90-6f28-4a49-9539-1a339363ae74"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 101,
                column: "CityGUID",
                value: new Guid("6f15aef6-ae76-49e0-b8f4-7d5e3adf3e67"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 102,
                column: "CityGUID",
                value: new Guid("a124d0c1-d5d0-49ce-ba21-a50e99a21248"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 103,
                column: "CityGUID",
                value: new Guid("5ed90ac8-c336-49d0-ac50-e75b7f120cb4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 104,
                column: "CityGUID",
                value: new Guid("a00ca2eb-8554-4987-b3d7-530bae0f2157"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 105,
                column: "CityGUID",
                value: new Guid("cee37eed-6679-4433-a0a3-e576915b4678"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 106,
                column: "CityGUID",
                value: new Guid("4877ee53-04cb-4d4e-89e5-df6e58bb139c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 107,
                column: "CityGUID",
                value: new Guid("cb4c1724-0ff8-40c7-a002-78ede8436b71"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 108,
                column: "CityGUID",
                value: new Guid("c5d313e5-8d07-4a4e-a273-ac741507c39b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 109,
                column: "CityGUID",
                value: new Guid("7e037c33-a008-4a11-a2b3-2826061b2e30"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 110,
                column: "CityGUID",
                value: new Guid("b8180ab1-906f-4e85-b8c1-0af99ba47cdb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 111,
                column: "CityGUID",
                value: new Guid("69a14cfa-1696-43bb-ba77-d79dfe29ee37"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 112,
                column: "CityGUID",
                value: new Guid("804d4f02-3af0-4c7d-8bbc-ee3a44765c24"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 113,
                column: "CityGUID",
                value: new Guid("71d8e46b-1ac9-4217-abb0-06ab0da92805"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 114,
                column: "CityGUID",
                value: new Guid("a973f642-cb1e-4db1-99d0-919a18de9538"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 115,
                column: "CityGUID",
                value: new Guid("2a05435e-a8b9-4881-ab51-0a39696c4fd9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 116,
                column: "CityGUID",
                value: new Guid("9c7426fd-d939-43f6-ba9e-2421489df3d1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 117,
                column: "CityGUID",
                value: new Guid("a5622861-8864-40c5-8324-de7710297a7e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 118,
                column: "CityGUID",
                value: new Guid("cd258491-4abf-470a-97d7-bf4da6592c1a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 119,
                column: "CityGUID",
                value: new Guid("3e213f24-073b-4281-8911-863749cecccc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 120,
                column: "CityGUID",
                value: new Guid("0570a33d-e3e2-44e5-bd24-20fbec726215"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 121,
                column: "CityGUID",
                value: new Guid("6e43b525-a411-4902-9a2a-10514f47b0e1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 122,
                column: "CityGUID",
                value: new Guid("5556153e-4a41-4d7d-8037-3ba0af1b9583"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 123,
                column: "CityGUID",
                value: new Guid("c030ce5b-77b4-4b55-8cf4-ad6d96c91695"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 124,
                column: "CityGUID",
                value: new Guid("f1e9f41b-26a0-412e-a65c-5d21a662aae3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 125,
                column: "CityGUID",
                value: new Guid("3da229b4-6d67-4140-8c03-00494e8cea7e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 126,
                column: "CityGUID",
                value: new Guid("cc0810d1-bd1f-4f5f-ab41-6d837804eca5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 127,
                column: "CityGUID",
                value: new Guid("a721c2ad-c15b-4c06-b0cf-bbe565a8412b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 128,
                column: "CityGUID",
                value: new Guid("3ac31fce-42f3-4dc3-a9ec-6a613d059489"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 129,
                column: "CityGUID",
                value: new Guid("63bff4ab-350a-4663-a805-7854c75e42d1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 130,
                column: "CityGUID",
                value: new Guid("d3c7c0a1-8bc6-4b7a-9ce7-a4b0e0f2f91c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 131,
                column: "CityGUID",
                value: new Guid("567cf9a3-aea8-45a6-9706-c6b79edcee15"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 132,
                column: "CityGUID",
                value: new Guid("b15ff025-a356-496c-bc5a-38196c90da18"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 133,
                column: "CityGUID",
                value: new Guid("ca54b989-1457-42e5-a75d-5af51996a818"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 134,
                column: "CityGUID",
                value: new Guid("d8136b91-1292-4aa8-b7da-374407285c0e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 135,
                column: "CityGUID",
                value: new Guid("b01d5b9a-34f5-4500-8edb-2eebdf6bb6dc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 136,
                column: "CityGUID",
                value: new Guid("8f1b6574-542c-4e7e-aefa-704905f141d1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 137,
                column: "CityGUID",
                value: new Guid("18e968e5-cfe6-44a8-aa9e-855453e0fbe8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 138,
                column: "CityGUID",
                value: new Guid("bffee31d-615e-47fe-941a-f0044fa0a9de"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 139,
                column: "CityGUID",
                value: new Guid("9b04b34e-2f61-42c7-a881-12f9ab9c4db2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 140,
                column: "CityGUID",
                value: new Guid("684a1e91-e2bd-4d87-bb51-b80697496f14"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 141,
                column: "CityGUID",
                value: new Guid("cee3d57c-0405-4556-bc4b-2fb9d63b7206"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 142,
                column: "CityGUID",
                value: new Guid("2ef73fc7-791b-46ed-af66-c4126255accd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 143,
                column: "CityGUID",
                value: new Guid("efc1f69c-fa7b-44c7-9f08-3d8e32e2b6c1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 144,
                column: "CityGUID",
                value: new Guid("894b24a8-cb39-4404-8c54-d8da26f6f2f2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 145,
                column: "CityGUID",
                value: new Guid("fc115352-9893-40e3-9ab9-57865879a5d0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 146,
                column: "CityGUID",
                value: new Guid("2d310964-a7d3-47cc-8c01-17a3f867c1cb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 147,
                column: "CityGUID",
                value: new Guid("80b470fc-6881-45fe-84f6-3834c8fef4e9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 148,
                column: "CityGUID",
                value: new Guid("9c2e0bcb-c704-493a-a9a6-99bd7c2a2564"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 149,
                column: "CityGUID",
                value: new Guid("114c18ee-1487-4c74-b081-85192e89a2c9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 150,
                column: "CityGUID",
                value: new Guid("c2fb6694-f812-4884-abfa-4d145495f688"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 151,
                column: "CityGUID",
                value: new Guid("6c580e93-a843-42fb-896f-feed03640f64"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 152,
                column: "CityGUID",
                value: new Guid("d6abe064-2eb7-45d3-8845-8ab38d0437b9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 153,
                column: "CityGUID",
                value: new Guid("827b671f-d5a5-48a6-b2e3-464052a07bd9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 154,
                column: "CityGUID",
                value: new Guid("84c5f14b-6e51-46ec-8076-aa55001ec8b3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 155,
                column: "CityGUID",
                value: new Guid("0e697c9b-1a16-43f4-90fc-1b2d23aced6c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 156,
                column: "CityGUID",
                value: new Guid("6005f2a1-d524-403d-891c-6d18ad5525bc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 157,
                column: "CityGUID",
                value: new Guid("9b9bde73-6b65-4d83-925a-cf9020104578"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 158,
                column: "CityGUID",
                value: new Guid("890e25aa-c71e-4a18-9fa4-0786c3b151e8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 159,
                column: "CityGUID",
                value: new Guid("dde65b83-4677-41d8-8f75-0495c8100675"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 160,
                column: "CityGUID",
                value: new Guid("ae268708-474c-4a5b-bbc7-77c4a172bfb0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 161,
                column: "CityGUID",
                value: new Guid("49d3dad5-149d-4a9b-8185-c9d041725c12"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 162,
                column: "CityGUID",
                value: new Guid("1a1bb88f-156b-49ad-adbd-2034e5c074e0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 163,
                column: "CityGUID",
                value: new Guid("2af37224-0c4c-4db2-bced-a2d491d2a7db"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 164,
                column: "CityGUID",
                value: new Guid("e3886d14-37b8-408e-a95e-09261fb61fec"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 165,
                column: "CityGUID",
                value: new Guid("5850bacb-8b03-41f9-93ec-d9644116107f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 166,
                column: "CityGUID",
                value: new Guid("fa8e094a-cde4-4ffd-8e7e-af51eaa4bb7c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 167,
                column: "CityGUID",
                value: new Guid("4666876f-115a-4bc2-8c73-ca872e2a7c10"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 168,
                column: "CityGUID",
                value: new Guid("cfdb6395-38a7-474a-8511-3854acda25f6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 169,
                column: "CityGUID",
                value: new Guid("1326bf4a-08ac-47e7-a146-346be719be54"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 170,
                column: "CityGUID",
                value: new Guid("bed76a83-d40a-4263-a9f7-d91149bf506d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 171,
                column: "CityGUID",
                value: new Guid("2c5a1ad5-ced6-4167-99d3-b9613332a88a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 172,
                column: "CityGUID",
                value: new Guid("e25fa218-2514-488d-827d-5a308cc21d6d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 173,
                column: "CityGUID",
                value: new Guid("b34c1585-7b1a-4575-9bf9-3db59d644d20"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 174,
                column: "CityGUID",
                value: new Guid("dc96db18-5e03-4e32-89b2-84d03677b86a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 175,
                column: "CityGUID",
                value: new Guid("0bb8fffb-1733-4151-a068-9907cda5db29"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 176,
                column: "CityGUID",
                value: new Guid("f8dc0204-2a7c-43e7-9c45-309d72a60b54"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 177,
                column: "CityGUID",
                value: new Guid("e09336ae-b2e4-4570-8e1c-388afdd296f4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 178,
                column: "CityGUID",
                value: new Guid("754405f0-d359-4a47-9dc4-513fd8355561"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 179,
                column: "CityGUID",
                value: new Guid("6c1c30f2-2747-4669-bbfd-56ecc743355e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 180,
                column: "CityGUID",
                value: new Guid("0b370088-51e3-4c0c-be4d-088ade48e61d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 181,
                column: "CityGUID",
                value: new Guid("c8540b42-631b-461c-b547-3bee95bc751b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 182,
                column: "CityGUID",
                value: new Guid("979a4d1f-12c8-4c56-9d4d-c95376f54ed6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 183,
                column: "CityGUID",
                value: new Guid("c134ea94-f87f-44b9-a97b-69ef1539b3e7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 184,
                column: "CityGUID",
                value: new Guid("51f0a7a2-679d-42ac-8250-6a13642b79b4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 185,
                column: "CityGUID",
                value: new Guid("7465e3e4-2da6-463d-b95c-e5327faab412"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 186,
                column: "CityGUID",
                value: new Guid("833d66ab-7e3b-40a0-a4fc-201a78b7eb07"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 187,
                column: "CityGUID",
                value: new Guid("3d1d755d-2f8e-4319-a29b-1351ac79cbea"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 188,
                column: "CityGUID",
                value: new Guid("8857c774-136a-43fe-91ef-bf34faebe760"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 189,
                column: "CityGUID",
                value: new Guid("0cba2e7d-b0a7-4d8d-800c-7cfd33d11b3e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 190,
                column: "CityGUID",
                value: new Guid("a7ac29dc-14f1-4f49-9358-35dc30437386"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 191,
                column: "CityGUID",
                value: new Guid("3fec46e4-e062-4148-abfd-6c2a5683ca61"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 192,
                column: "CityGUID",
                value: new Guid("6b3b0503-3262-4980-821a-03717ffa2daa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 193,
                column: "CityGUID",
                value: new Guid("9038ceca-1c2e-41e1-99a2-95e16c8801c1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 194,
                column: "CityGUID",
                value: new Guid("a5cb07de-612b-49e9-88c5-7fde31cd38d1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 195,
                column: "CityGUID",
                value: new Guid("77444900-6426-4335-b4a2-9e99e482e2e1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 196,
                column: "CityGUID",
                value: new Guid("bedf1016-14d0-45cd-9a1d-a182880aefe6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 197,
                column: "CityGUID",
                value: new Guid("71d074a0-858d-47ba-874d-31e96db770e0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 198,
                column: "CityGUID",
                value: new Guid("1254f4b4-3fb8-462e-902d-1c2e48a34799"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 199,
                column: "CityGUID",
                value: new Guid("0d4ecf09-7953-4270-bac4-5d7d8e8b31f2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 200,
                column: "CityGUID",
                value: new Guid("4a6b4812-e96e-4c19-946f-26ec2199d94b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 201,
                column: "CityGUID",
                value: new Guid("5edbad3e-8518-44f7-b73d-42de9677d417"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 202,
                column: "CityGUID",
                value: new Guid("ace2321b-2dc3-4dc8-b052-632c0fc41149"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 203,
                column: "CityGUID",
                value: new Guid("a986518a-3c56-4b84-8140-35c517651ed8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 204,
                column: "CityGUID",
                value: new Guid("0d458bbd-f4d6-4d65-ae98-a437d3bf3bb2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 205,
                column: "CityGUID",
                value: new Guid("c3eb324f-57cc-43e7-82dd-6ab922991d8a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 206,
                column: "CityGUID",
                value: new Guid("3d80603a-b9c3-4281-944c-ca38f6b68eec"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 207,
                column: "CityGUID",
                value: new Guid("7dcc3fd4-5a9c-4321-a098-fe039e3bf678"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 208,
                column: "CityGUID",
                value: new Guid("fd59a3a4-ed62-42eb-b7f3-7c9ab0e44d62"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 209,
                column: "CityGUID",
                value: new Guid("a9122ca3-4fbc-4891-b92e-edc58ac7d27f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 210,
                column: "CityGUID",
                value: new Guid("80559580-404e-4aa2-8d24-5f93e43c8e14"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 211,
                column: "CityGUID",
                value: new Guid("54cbee65-e041-424d-bde0-090f07147fd9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 212,
                column: "CityGUID",
                value: new Guid("94788927-2057-49fc-b1c3-293564157930"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 213,
                column: "CityGUID",
                value: new Guid("f0efc539-7ffb-48a0-9e1b-9b92b9dd67ce"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 214,
                column: "CityGUID",
                value: new Guid("ef806725-ec31-46be-826d-8601c7ece96e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 215,
                column: "CityGUID",
                value: new Guid("74b6c819-aaca-4ed9-8408-aaeea19760dd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 216,
                column: "CityGUID",
                value: new Guid("d2fc91d9-7a51-4de3-9b2d-6e20eee2607b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 217,
                column: "CityGUID",
                value: new Guid("f3d27212-02ea-4a4a-a9e1-f9871c85ebfa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 218,
                column: "CityGUID",
                value: new Guid("eb0798a5-a989-458d-8cd3-1e55e86ad8bb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 219,
                column: "CityGUID",
                value: new Guid("521c522d-cb15-4cfe-b077-d5e2d76e7fdf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 220,
                column: "CityGUID",
                value: new Guid("33070ae8-a78e-45d4-add7-649c2cae42ff"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 221,
                column: "CityGUID",
                value: new Guid("835d0fca-4e33-4791-9e87-72a63ac70a43"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 222,
                column: "CityGUID",
                value: new Guid("cb029370-ce35-481b-8b52-05c5565b0f8f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 223,
                column: "CityGUID",
                value: new Guid("8e5e4304-f9a4-4daa-ae71-044c7acc8310"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 224,
                column: "CityGUID",
                value: new Guid("fa0b32a1-52ac-41ea-931a-ffaf76c3805f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 225,
                column: "CityGUID",
                value: new Guid("fcbd4045-3b27-4e3d-b63a-91c97d32b734"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 226,
                column: "CityGUID",
                value: new Guid("e6c63228-588c-4fbd-be86-7e5068e817a7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 227,
                column: "CityGUID",
                value: new Guid("1c621f30-f0b7-404b-9848-fe26f96808be"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 228,
                column: "CityGUID",
                value: new Guid("ea377c33-7d43-4279-bcff-e0aabbc012a4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 229,
                column: "CityGUID",
                value: new Guid("f59c3687-60b6-4a97-b58d-cbdf11ee6370"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 230,
                column: "CityGUID",
                value: new Guid("e515a3ce-8698-42d7-baa1-1398094d65d0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 231,
                column: "CityGUID",
                value: new Guid("cc323092-132d-4ab9-9ff8-29bb82d95524"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 232,
                column: "CityGUID",
                value: new Guid("022092c4-22b3-4d0d-b6d4-f53ff3b45746"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 233,
                column: "CityGUID",
                value: new Guid("2e09203c-0c84-4f6d-9d4a-e5ac83bffeac"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 234,
                column: "CityGUID",
                value: new Guid("3518a45c-fcbf-4435-98c9-b7deb578d8cb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 235,
                column: "CityGUID",
                value: new Guid("4c1503fe-ffa2-4ba1-bbe2-0e96726b67ae"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 236,
                column: "CityGUID",
                value: new Guid("40e76c12-8600-4da2-86ff-7ffa078c95d6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 237,
                column: "CityGUID",
                value: new Guid("2875ef19-ea74-4ca5-b544-6a421e9aff4b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 238,
                column: "CityGUID",
                value: new Guid("89a85a16-06c7-4fb7-827e-575ce9ed9594"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 239,
                column: "CityGUID",
                value: new Guid("efc02c39-7a72-421f-862b-8bc12cec5934"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 240,
                column: "CityGUID",
                value: new Guid("7ba6102a-f915-4fb4-b8ee-778e77e522c7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 241,
                column: "CityGUID",
                value: new Guid("2de437fd-89a5-4866-b038-31587688aca2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 242,
                column: "CityGUID",
                value: new Guid("05a1ef73-8a91-4b7c-bbdf-af4cd314acc3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 243,
                column: "CityGUID",
                value: new Guid("54a662e6-e96e-4b66-b5ea-f3a910839828"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 244,
                column: "CityGUID",
                value: new Guid("d76d76de-868d-4217-870a-d6685c11a551"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 245,
                column: "CityGUID",
                value: new Guid("4b7d843c-697d-4e7e-813b-558ab24f3252"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 246,
                column: "CityGUID",
                value: new Guid("8276dced-062d-4851-ae1c-eceb58bfde1f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 247,
                column: "CityGUID",
                value: new Guid("f725e5a5-baa1-49d2-992a-fd99262fc19a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 248,
                column: "CityGUID",
                value: new Guid("8294f128-2a8f-48c5-8d23-84d240964a88"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 249,
                column: "CityGUID",
                value: new Guid("6ce32819-34a5-4a05-a947-101f0e747945"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 250,
                column: "CityGUID",
                value: new Guid("1591b883-4f34-42e3-b18e-1f1abd126bbe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 251,
                column: "CityGUID",
                value: new Guid("d90066ce-4682-43f3-8e5f-7cd6f9643a3e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 252,
                column: "CityGUID",
                value: new Guid("589a1a13-507e-4c71-b6ce-c772f307c998"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 253,
                column: "CityGUID",
                value: new Guid("3721c358-5df9-424a-8a11-5c92115f0435"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 254,
                column: "CityGUID",
                value: new Guid("433340b4-d9da-486d-a96e-f08396bcf63c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 255,
                column: "CityGUID",
                value: new Guid("61974777-ac47-4df9-a62a-564938eb8c12"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 256,
                column: "CityGUID",
                value: new Guid("4b889fef-c3a8-4f8c-8dac-e0f0efeb153a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 257,
                column: "CityGUID",
                value: new Guid("c01d39d3-967f-4ec6-9753-af7514a050e2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 258,
                column: "CityGUID",
                value: new Guid("37a92de0-95ce-4c88-a899-fa9f98764e8f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 259,
                column: "CityGUID",
                value: new Guid("2dbcfe2e-5b31-491f-97fc-e66c0630bfb7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 260,
                column: "CityGUID",
                value: new Guid("5e61751b-fc79-4a3f-94bc-27599d5596ff"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 261,
                column: "CityGUID",
                value: new Guid("be38b55e-af17-42d6-a567-46115ad08e67"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 262,
                column: "CityGUID",
                value: new Guid("e230ad7b-b27b-4f0f-8a67-e668165a4c12"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 263,
                column: "CityGUID",
                value: new Guid("b1ad63db-b20b-4bc4-b8b1-4dc91941f6ee"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 264,
                column: "CityGUID",
                value: new Guid("8d452ab6-6a6e-4cf9-b506-fd7378f7ad6f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 265,
                column: "CityGUID",
                value: new Guid("a9f51812-0d84-45bd-ab15-217638b3690d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 266,
                column: "CityGUID",
                value: new Guid("1884279d-e119-428a-b337-0ac40a15bd94"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 267,
                column: "CityGUID",
                value: new Guid("ef3e0afa-77f8-45b6-8685-3215b564dbfd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 268,
                column: "CityGUID",
                value: new Guid("06e994d6-8fee-4120-8ff0-575a8fd397dc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 269,
                column: "CityGUID",
                value: new Guid("abf84dbe-69a9-45a9-b40e-4537aa2a02fb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 270,
                column: "CityGUID",
                value: new Guid("7b78a0a9-c86a-49aa-bf27-e694258eb261"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 271,
                column: "CityGUID",
                value: new Guid("26c42bd8-66ee-43e6-9ca8-281b1557257c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 272,
                column: "CityGUID",
                value: new Guid("1c9a465a-4a12-4dd0-80b5-4a15375999c5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 273,
                column: "CityGUID",
                value: new Guid("4202c9f5-91ce-4232-9957-7e662eb13add"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 274,
                column: "CityGUID",
                value: new Guid("33eba25f-29cc-4fa4-a7f6-2cc2ff3d5186"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 275,
                column: "CityGUID",
                value: new Guid("2b27e357-afde-4860-b4af-5b485a86c873"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 276,
                column: "CityGUID",
                value: new Guid("5e9c2a67-b5dd-41bc-a1ed-6ebc679f3f38"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 277,
                column: "CityGUID",
                value: new Guid("ce089471-af7d-4058-a51e-852937e124f6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 278,
                column: "CityGUID",
                value: new Guid("b56ee424-563c-4c4e-81d3-a89ffbf866c8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 279,
                column: "CityGUID",
                value: new Guid("c01391ba-69d7-4d82-80e3-7eb593c64d42"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 280,
                column: "CityGUID",
                value: new Guid("9b32f84a-be65-43cf-abfa-6159abd4ca29"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 281,
                column: "CityGUID",
                value: new Guid("d892b537-36cb-4a3e-9157-0be108f828df"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 282,
                column: "CityGUID",
                value: new Guid("c676c7a8-2a03-4104-bd34-7b982a1fe1c7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 283,
                column: "CityGUID",
                value: new Guid("54e1be45-c602-4d56-9d4e-a6ae927f926a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 284,
                column: "CityGUID",
                value: new Guid("b4f4ade2-f3c9-4056-823e-4b56d380c6ee"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 285,
                column: "CityGUID",
                value: new Guid("233b28f4-045f-475d-9df9-9d54c7bf6ef0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 286,
                column: "CityGUID",
                value: new Guid("b5456019-7df4-4d5e-be91-8f97f46392b6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 287,
                column: "CityGUID",
                value: new Guid("98643609-6901-49fb-9745-e665a6815bee"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 288,
                column: "CityGUID",
                value: new Guid("0e84e2e1-9275-4a82-a6bc-8604d80bf5c9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 289,
                column: "CityGUID",
                value: new Guid("014d5984-4d61-46e2-ba23-b1f0c5224424"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 290,
                column: "CityGUID",
                value: new Guid("f397b773-c6ea-4a39-855d-07212d250759"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 291,
                column: "CityGUID",
                value: new Guid("78fe6077-fb47-4932-bbcd-e416dfc87fea"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 292,
                column: "CityGUID",
                value: new Guid("7bcbb1d3-975d-4f14-badf-849df1a12cd1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 293,
                column: "CityGUID",
                value: new Guid("172726f5-283d-4848-a65d-81f6a97f7587"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 294,
                column: "CityGUID",
                value: new Guid("b35995c6-2c51-4680-ba6f-a85d5a4105ca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 295,
                column: "CityGUID",
                value: new Guid("4e4d4c2d-537e-4899-b26c-43cbb17da340"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 296,
                column: "CityGUID",
                value: new Guid("efe9ca39-81fe-436e-a3ed-d5d092dc14d7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 297,
                column: "CityGUID",
                value: new Guid("5ded6cf9-e16d-4836-978b-9951587b0542"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 298,
                column: "CityGUID",
                value: new Guid("2dd714fd-6617-4c27-8d3f-7a859d5f36d4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 299,
                column: "CityGUID",
                value: new Guid("ebcda3fe-a682-4cbe-bbb5-aa81e4cb2c40"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 300,
                column: "CityGUID",
                value: new Guid("ae594a5d-be13-4b6a-aea4-9cad40ace98b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 301,
                column: "CityGUID",
                value: new Guid("2182cedc-bd5d-410a-bb63-e6c4ac15f355"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 302,
                column: "CityGUID",
                value: new Guid("3d6ecec6-0d30-409b-963d-4eb0deef3d5e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 303,
                column: "CityGUID",
                value: new Guid("ef61cbb6-7d0e-4018-a4cd-c5da44283082"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 304,
                column: "CityGUID",
                value: new Guid("9b937f17-9790-4bde-b508-6a4a0a16e209"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 305,
                column: "CityGUID",
                value: new Guid("410398b9-aabf-4658-9dae-49fbedc32741"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 306,
                column: "CityGUID",
                value: new Guid("609d266c-d68a-4ee9-88e6-fd6d52919881"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 307,
                column: "CityGUID",
                value: new Guid("7b58bbb2-3356-46a2-b1d6-c9ebae199842"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 308,
                column: "CityGUID",
                value: new Guid("95ae5b8b-9ebc-4203-8f82-f631c686c8ff"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 309,
                column: "CityGUID",
                value: new Guid("350e0aa3-1c42-4c31-abd8-566bc8701b32"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 310,
                column: "CityGUID",
                value: new Guid("d26b3428-cf5d-41c9-99f2-35ad9e6d7aa0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 311,
                column: "CityGUID",
                value: new Guid("0eddd059-0a8f-4bc6-a8b3-d1ccabcb24b2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 312,
                column: "CityGUID",
                value: new Guid("1e6c1f1c-abfb-4606-92c4-a50cf3c6edb2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 313,
                column: "CityGUID",
                value: new Guid("6af7edc2-112c-4acd-bd4d-c821bc1ace13"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 314,
                column: "CityGUID",
                value: new Guid("2954af6a-75e5-45b0-80c4-2ad9b6fd0316"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 315,
                column: "CityGUID",
                value: new Guid("302bd469-0d13-409f-8a46-c8792e1d9711"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 316,
                column: "CityGUID",
                value: new Guid("1f2f15b2-b1ab-4826-ab42-1c3a490953dc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 317,
                column: "CityGUID",
                value: new Guid("05bbcb24-a414-4b1f-b292-d98e891ff385"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 318,
                column: "CityGUID",
                value: new Guid("79c696ef-fb5b-4ec1-b39b-5c0d2febce5d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 319,
                column: "CityGUID",
                value: new Guid("e186d740-de41-401b-9578-436e4c6f1e62"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 320,
                column: "CityGUID",
                value: new Guid("f94195c8-fba1-4edd-9ff2-e07be3346be8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 321,
                column: "CityGUID",
                value: new Guid("e7dfb112-9703-494a-ac71-79ecdedbc534"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 322,
                column: "CityGUID",
                value: new Guid("35b079e8-9226-45ad-b628-bd8dc68fe4cf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 323,
                column: "CityGUID",
                value: new Guid("33b939e3-3af4-40c5-95ea-cdb2a5e98118"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 324,
                column: "CityGUID",
                value: new Guid("61d35a74-9d4c-462b-af99-17412c47670e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 325,
                column: "CityGUID",
                value: new Guid("20784363-781d-4cff-b548-7fdc8dc72267"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 326,
                column: "CityGUID",
                value: new Guid("c72ed6df-61ae-4972-8515-2477eba35303"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 327,
                column: "CityGUID",
                value: new Guid("e19964c3-4114-4d0e-b0d8-c2b737a3ce29"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 328,
                column: "CityGUID",
                value: new Guid("f2b22e9a-792a-4080-8c5e-06beb71e0f72"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 329,
                column: "CityGUID",
                value: new Guid("bcce4166-699b-4b5d-8fca-26e5e3ea0d7d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 330,
                column: "CityGUID",
                value: new Guid("9be7e1e2-df0a-402a-9794-f12f69714c20"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 331,
                column: "CityGUID",
                value: new Guid("b787e204-b3ad-4c08-8915-4eacb2ed408d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 332,
                column: "CityGUID",
                value: new Guid("a7708118-3b2a-4add-b39c-a8e66af8c945"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 333,
                column: "CityGUID",
                value: new Guid("30d8340e-4292-4985-addd-f4520475b44d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 334,
                column: "CityGUID",
                value: new Guid("bb4c0772-9928-4cc2-b3b2-48e2343cb61d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 335,
                column: "CityGUID",
                value: new Guid("ceca708c-5853-442c-8f07-c3d50ae03185"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 336,
                column: "CityGUID",
                value: new Guid("0cf3051d-1d93-48c6-8c34-34ca96aa5913"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 337,
                column: "CityGUID",
                value: new Guid("6ce36252-a0b8-4739-ac2b-977b00b79714"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 338,
                column: "CityGUID",
                value: new Guid("6597ca40-31df-4e23-8709-1c39d195385a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 339,
                column: "CityGUID",
                value: new Guid("fcb211ef-583f-4f23-bb1a-aaf04312b178"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 340,
                column: "CityGUID",
                value: new Guid("033cead7-5e4d-41f9-ac94-d6aed5981db3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 341,
                column: "CityGUID",
                value: new Guid("2194a00c-6daf-41bd-9697-573781013193"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 342,
                column: "CityGUID",
                value: new Guid("901b07bc-49c5-42b7-b5df-f2eef77bbec0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 343,
                column: "CityGUID",
                value: new Guid("0cf4810d-eda0-4129-84b7-7db348dfaf4b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 344,
                column: "CityGUID",
                value: new Guid("b23a6215-7c61-4c7e-95ec-10506edbf9f7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 345,
                column: "CityGUID",
                value: new Guid("ceb9f1c6-07e7-40d6-9afc-cdeceeb6dfd4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 346,
                column: "CityGUID",
                value: new Guid("20f90a41-60f9-405d-b211-36cf125ef1fe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 347,
                column: "CityGUID",
                value: new Guid("c72a14ff-14d3-4b07-bb81-e13cd13ffc01"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 348,
                column: "CityGUID",
                value: new Guid("9d054af6-74a0-4717-8e1c-b57d9c69e976"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 349,
                column: "CityGUID",
                value: new Guid("76501229-bba9-48c4-afec-68d11f7e2131"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 350,
                column: "CityGUID",
                value: new Guid("5d5e540b-07d3-4230-a07e-fef022538158"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 351,
                column: "CityGUID",
                value: new Guid("62660b24-9efb-4b8a-98a4-17d5d7071a6e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 352,
                column: "CityGUID",
                value: new Guid("5f952802-912a-4c0c-a299-8c59d48427b0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 353,
                column: "CityGUID",
                value: new Guid("31ba9604-eced-4bfe-8375-a89473ce947d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 354,
                column: "CityGUID",
                value: new Guid("38884ef8-ac89-4983-a1d9-57fdfc8d2155"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 355,
                column: "CityGUID",
                value: new Guid("718afe90-9249-45a7-8d98-0d0e9e75cf0b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 356,
                column: "CityGUID",
                value: new Guid("0db3bcf5-8766-45f9-b8f0-8fd8916ec998"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 357,
                column: "CityGUID",
                value: new Guid("70821290-7449-4b14-ab1b-03f1aff058c8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 358,
                column: "CityGUID",
                value: new Guid("11102402-0125-4e96-b3a9-bbada4371fcb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 359,
                column: "CityGUID",
                value: new Guid("2424a2df-f2a7-41db-be10-705e6f6d970b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 360,
                column: "CityGUID",
                value: new Guid("a5392d54-6bc5-4475-a869-b02152502a9e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 361,
                column: "CityGUID",
                value: new Guid("07c7fa6b-f567-4a30-8d51-291f1691ed85"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 362,
                column: "CityGUID",
                value: new Guid("cfb9e8c1-a60c-4f64-ab9e-9f181261b691"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 363,
                column: "CityGUID",
                value: new Guid("e5c3bfbb-51f7-4c3e-b9d3-96c05e12c334"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 364,
                column: "CityGUID",
                value: new Guid("59d67d38-706b-44f5-8355-3cd2f57bf294"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 365,
                column: "CityGUID",
                value: new Guid("ecd1f084-5696-413b-b608-0e9bf02667b8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 366,
                column: "CityGUID",
                value: new Guid("8ebf94a7-5114-4a08-86fa-a08f904f6eb3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 367,
                column: "CityGUID",
                value: new Guid("223a073e-6c65-4c5a-8d77-1ac6cf9292ec"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 368,
                column: "CityGUID",
                value: new Guid("ff38165e-9659-4336-adfd-56f2b8a5885f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 369,
                column: "CityGUID",
                value: new Guid("34931d89-0815-4093-b0ae-2d3ae3f655dd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 370,
                column: "CityGUID",
                value: new Guid("0734878b-aca5-4fdc-9253-52d76b8422dc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 371,
                column: "CityGUID",
                value: new Guid("1fd7ff2b-5a13-48ee-a930-0608ec81c155"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 372,
                column: "CityGUID",
                value: new Guid("97fdeb3b-98b4-4006-8dc7-0e04433f933e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 373,
                column: "CityGUID",
                value: new Guid("ba34ae6f-c640-4dc7-8f98-3759ed0e3e29"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 374,
                column: "CityGUID",
                value: new Guid("d47300fe-9606-4cd4-9a96-68d9895b234e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 375,
                column: "CityGUID",
                value: new Guid("f9967dd1-bca3-4fdc-b39e-c033ea6bfb4c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 376,
                column: "CityGUID",
                value: new Guid("b8320b60-32e2-4c43-b51d-3b4d7707c5e2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 377,
                column: "CityGUID",
                value: new Guid("56ab8997-ac00-4fd8-8438-b48eaaf9e86b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 378,
                column: "CityGUID",
                value: new Guid("06490ea2-f840-473a-b89e-5e92ac67ce46"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 379,
                column: "CityGUID",
                value: new Guid("00d5672d-fd88-43a9-a7c5-93422f843009"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 380,
                column: "CityGUID",
                value: new Guid("d13503ae-0814-41e6-acb6-69842b1550fb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 381,
                column: "CityGUID",
                value: new Guid("a9b7ed7b-47ae-4568-afd4-814a2de2b085"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 382,
                column: "CityGUID",
                value: new Guid("8b317587-408a-484c-b8c3-f88b79850515"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 383,
                column: "CityGUID",
                value: new Guid("d4d8692a-917e-4619-991d-9a689c8bd33d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 384,
                column: "CityGUID",
                value: new Guid("6ec31ace-00fb-494d-b6e0-051a06fe7129"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 385,
                column: "CityGUID",
                value: new Guid("62f63882-a794-4fcb-a6e5-dd57f46275f7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 386,
                column: "CityGUID",
                value: new Guid("9fa080ad-7b0a-440d-8098-873d490cd05e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 387,
                column: "CityGUID",
                value: new Guid("0e029f04-b151-413c-9fac-0895f5979ff4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 388,
                column: "CityGUID",
                value: new Guid("b5d27dc9-bef8-4115-856b-fd16e2afc796"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 389,
                column: "CityGUID",
                value: new Guid("df36f471-ffca-465d-af4d-b79864bc89a1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 390,
                column: "CityGUID",
                value: new Guid("b3a206f2-04f6-4cde-bfb9-50ae54a9de33"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 391,
                column: "CityGUID",
                value: new Guid("d03f43b0-921b-49a2-b9ba-50e9f6557808"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 392,
                column: "CityGUID",
                value: new Guid("274d2ce0-d0ae-4a82-8f50-f24fd0d2eb34"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 393,
                column: "CityGUID",
                value: new Guid("fa600024-fc41-4b83-9776-3b251a9ec3ae"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 394,
                column: "CityGUID",
                value: new Guid("54b05484-3db2-4883-b209-457a16e7cd8e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 395,
                column: "CityGUID",
                value: new Guid("4658e1df-1bce-41a5-a597-c7e56cbaa3e5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 396,
                column: "CityGUID",
                value: new Guid("c8565f3f-c435-4950-9fd2-319ddba9c11a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 397,
                column: "CityGUID",
                value: new Guid("8a3ca343-a6e2-42e7-8d15-441cff2612fd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 398,
                column: "CityGUID",
                value: new Guid("c0863541-5f72-464b-b04e-4847b11fb818"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 399,
                column: "CityGUID",
                value: new Guid("04bf9000-4c1c-46d9-b588-4d2b64105325"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 400,
                column: "CityGUID",
                value: new Guid("07b843c3-ffbd-4985-b374-4bf3477811f5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 401,
                column: "CityGUID",
                value: new Guid("3735e9e3-eecc-416c-9e8a-94dceca1b26d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 402,
                column: "CityGUID",
                value: new Guid("e5c21a41-3c84-4b11-91b1-e8365e749e89"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 403,
                column: "CityGUID",
                value: new Guid("53addf49-3000-408b-9b95-1f580c37c086"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 404,
                column: "CityGUID",
                value: new Guid("75adbb26-15bb-422b-ac5e-0e439d8cbf9e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 405,
                column: "CityGUID",
                value: new Guid("40819b45-0c6e-497d-a3a9-572bafbb9c6d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 406,
                column: "CityGUID",
                value: new Guid("4edc23d5-e91a-4d07-bc9a-0ec93ea6849e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 407,
                column: "CityGUID",
                value: new Guid("3e0089e4-b018-42b4-a68a-3ef388781631"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 408,
                column: "CityGUID",
                value: new Guid("1b264930-37d0-4d88-8595-1d07d5157387"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 409,
                column: "CityGUID",
                value: new Guid("3809930b-32e2-472e-baf2-b717d358b718"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 410,
                column: "CityGUID",
                value: new Guid("466870f2-9131-4694-ba39-982300d1144e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 411,
                column: "CityGUID",
                value: new Guid("e3b9b9ae-e00a-4f6e-b6e1-e6c3e140ef05"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 412,
                column: "CityGUID",
                value: new Guid("e24644c2-83ab-4e68-84cf-ed09c4f08eb3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 413,
                column: "CityGUID",
                value: new Guid("f0d30d77-eb25-445a-8f20-46f535f2ddd4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 414,
                column: "CityGUID",
                value: new Guid("7ef286b1-ae12-4136-b8a3-ffc2e44bb4c4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 415,
                column: "CityGUID",
                value: new Guid("93128dee-37a9-4d19-87d3-9549ef2277d9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 416,
                column: "CityGUID",
                value: new Guid("72398398-07c4-4b26-843e-561496ae1f3c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 417,
                column: "CityGUID",
                value: new Guid("bc57396b-6062-411d-97cd-c222d34ffbfe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 418,
                column: "CityGUID",
                value: new Guid("ab1633b6-dc2a-4a42-bc28-d5c6d9a7a192"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 419,
                column: "CityGUID",
                value: new Guid("4b9f1bdc-c798-466f-90ec-08f909e88c18"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 420,
                column: "CityGUID",
                value: new Guid("ea7b01a6-ef10-40b6-9bc4-d669c5b7915d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 421,
                column: "CityGUID",
                value: new Guid("661bae16-5ed2-4c5d-97a2-07fd70baf5f6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 422,
                column: "CityGUID",
                value: new Guid("6b581a07-8236-48c6-9c4b-82e977375554"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 423,
                column: "CityGUID",
                value: new Guid("b9972591-f1b6-43ca-ab80-8a4dd085a167"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 424,
                column: "CityGUID",
                value: new Guid("0770568f-3a89-4fd9-b3bc-5109846cab53"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 425,
                column: "CityGUID",
                value: new Guid("27dc490f-6422-44d7-9587-b833d44302cb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 426,
                column: "CityGUID",
                value: new Guid("c0606b9d-cc96-453e-af23-100649c0ee01"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 427,
                column: "CityGUID",
                value: new Guid("7c5e4f3e-d75e-4518-9ab1-618cfb8610a0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 428,
                column: "CityGUID",
                value: new Guid("0352ba72-c25e-46bd-ac1d-8d9f5999e1a3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 429,
                column: "CityGUID",
                value: new Guid("52d242a6-f95f-4b8d-808b-29e86d58eb63"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 430,
                column: "CityGUID",
                value: new Guid("d1b0d84d-bcf2-4c51-b8c9-25679ca50dac"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 431,
                column: "CityGUID",
                value: new Guid("12c4753d-ff80-472c-97d9-011cf4b24de9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 432,
                column: "CityGUID",
                value: new Guid("0d792806-c9a6-493c-b3ca-1d12c8a3d9aa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 433,
                column: "CityGUID",
                value: new Guid("3835cc12-43d9-4520-90c0-46dcdd1a27e7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 434,
                column: "CityGUID",
                value: new Guid("516d6c29-c616-4eeb-8d41-0dd35548be78"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 435,
                column: "CityGUID",
                value: new Guid("e426e3e3-28c5-4e94-9a70-6eb967dfccfb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 436,
                column: "CityGUID",
                value: new Guid("6b497a7c-5fc4-493c-bda3-f463679a2a92"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 437,
                column: "CityGUID",
                value: new Guid("bffa41df-81b2-4a77-be41-d121c1eaad41"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 438,
                column: "CityGUID",
                value: new Guid("72446089-8cd0-457d-8dcf-f3eb9424a6d1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 439,
                column: "CityGUID",
                value: new Guid("9419cef1-7ed4-4dd0-af51-bb77c352c3eb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 440,
                column: "CityGUID",
                value: new Guid("01c6d0d3-c89e-4181-bdd9-7f4e18105114"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 441,
                column: "CityGUID",
                value: new Guid("01c00969-f821-4c38-8775-6ef8a0398cc2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 442,
                column: "CityGUID",
                value: new Guid("fddbe549-ecb1-40fc-9fc3-1874460d5f46"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 443,
                column: "CityGUID",
                value: new Guid("256c5138-ad5e-4e02-aceb-547363ebf709"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 444,
                column: "CityGUID",
                value: new Guid("d19c7a1e-bf0f-44b3-84e4-a2b072fe873d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 445,
                column: "CityGUID",
                value: new Guid("790547e2-6a61-4bcd-bf27-faf80ec1a5c7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 446,
                column: "CityGUID",
                value: new Guid("35daca05-d7df-4a49-bfe1-bbbc80d92b01"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 447,
                column: "CityGUID",
                value: new Guid("087485de-d0b3-41f0-bf63-45d92771d997"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 448,
                column: "CityGUID",
                value: new Guid("151ad079-868f-41d8-91e4-653e70497710"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 449,
                column: "CityGUID",
                value: new Guid("2b972a22-5ac0-4efa-b2cf-ed1e8f008a19"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 450,
                column: "CityGUID",
                value: new Guid("fbd55874-aeaa-48ab-89b1-ef452b2efc65"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 451,
                column: "CityGUID",
                value: new Guid("81bd558f-3bc5-4be9-a671-f0c09806bfac"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 452,
                column: "CityGUID",
                value: new Guid("69e603ca-07fe-4ce8-a565-ee65d28502c3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 453,
                column: "CityGUID",
                value: new Guid("826d0b13-63f4-459c-a472-fd70786b2e30"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 454,
                column: "CityGUID",
                value: new Guid("894026c5-7521-4ddd-8294-f5243f03cf7b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 455,
                column: "CityGUID",
                value: new Guid("c1f19142-b9ec-46e6-8c9d-1fee3435884f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 456,
                column: "CityGUID",
                value: new Guid("20a279a4-f8fc-4136-8a2c-0cedb5383f60"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 457,
                column: "CityGUID",
                value: new Guid("1849e8ca-7460-481c-ab86-edb6817e4b1d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 458,
                column: "CityGUID",
                value: new Guid("0dc82ac6-ca0f-4bae-ac91-4f18b7d3300c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 459,
                column: "CityGUID",
                value: new Guid("75ca4522-b129-4157-b186-fabbee727e23"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 460,
                column: "CityGUID",
                value: new Guid("03f6c1ad-1e28-497e-b1de-d9dd1a5769f3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 461,
                column: "CityGUID",
                value: new Guid("882b92f5-e2ea-488d-84c0-26a556539901"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 462,
                column: "CityGUID",
                value: new Guid("edc56fc6-19ae-4d4d-916f-f8a37ec57ee5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 463,
                column: "CityGUID",
                value: new Guid("9bf8942d-b4df-445c-98c8-b994c7473773"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 464,
                column: "CityGUID",
                value: new Guid("63760604-4d07-4565-92a9-3ba1cd2d5498"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 465,
                column: "CityGUID",
                value: new Guid("0742aca6-c099-460d-b5a5-d87409a49566"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 466,
                column: "CityGUID",
                value: new Guid("5d510a89-fdbc-48a7-8704-7660da8996b0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 467,
                column: "CityGUID",
                value: new Guid("ed3ced61-d12f-4bd8-93e5-3116dee358d0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 468,
                column: "CityGUID",
                value: new Guid("265f584a-0162-45f2-a0bc-51fbb6c5010f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 469,
                column: "CityGUID",
                value: new Guid("4785d550-bef6-4667-a1e4-80e9e30278cf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 470,
                column: "CityGUID",
                value: new Guid("9b80142f-9a86-4e6d-afc8-36ba4c6dd0a5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 471,
                column: "CityGUID",
                value: new Guid("140d8704-ec03-4116-9fd8-3cf23f4fd4da"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 472,
                column: "CityGUID",
                value: new Guid("1109b212-fa2a-44d2-8aa6-85f59c51e2d7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 473,
                column: "CityGUID",
                value: new Guid("3ea26196-83e8-4fe6-a433-6c00fa544d2a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 474,
                column: "CityGUID",
                value: new Guid("fc212a4b-df7d-4f4f-bc0b-042934e5738e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 475,
                column: "CityGUID",
                value: new Guid("b494398f-0609-4ac1-8c94-4e7f541e9b45"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 476,
                column: "CityGUID",
                value: new Guid("23af5130-6cfb-41dc-b68d-415dfe80c1a6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 477,
                column: "CityGUID",
                value: new Guid("7ea2312e-f5cf-4356-9d97-1ca79c757b43"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 478,
                column: "CityGUID",
                value: new Guid("c278679d-b7a9-49d1-8744-5501bd79d960"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 479,
                column: "CityGUID",
                value: new Guid("080a1551-8cf9-49d1-8c24-d52fbeb758f9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 480,
                column: "CityGUID",
                value: new Guid("1ff5c0fe-3f26-435b-a8ba-172e6e4e9cbd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 481,
                column: "CityGUID",
                value: new Guid("cb2e7df2-919a-4fcb-aaa7-c322b26941e7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 482,
                column: "CityGUID",
                value: new Guid("f9a060bd-afd2-4c92-9785-82354a741175"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 483,
                column: "CityGUID",
                value: new Guid("6fb27490-e253-437e-8d84-efeaec0cb2dd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 484,
                column: "CityGUID",
                value: new Guid("19ec9974-c01d-4acb-9732-5c174fd71e1d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 485,
                column: "CityGUID",
                value: new Guid("cff47934-0705-4654-87f6-6383a112d9f9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 486,
                column: "CityGUID",
                value: new Guid("bf32ab46-17ad-4be1-9033-1a08ebb14372"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 487,
                column: "CityGUID",
                value: new Guid("8e4592c8-6b7d-4a39-9a0a-f4c0f4f97cab"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 488,
                column: "CityGUID",
                value: new Guid("d2bed425-6c6b-4e86-a9ba-4116d140803c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 489,
                column: "CityGUID",
                value: new Guid("d7ec3c62-466c-42fc-9f4a-ca840d25fee2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 490,
                column: "CityGUID",
                value: new Guid("37a6184d-1cef-4729-aee9-863293a3c7ce"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 491,
                column: "CityGUID",
                value: new Guid("0616db74-0a8a-4594-b17e-ce03e66fce7d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 492,
                column: "CityGUID",
                value: new Guid("9c671ec4-5f4d-450e-ad87-c0b67ff9ca69"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 493,
                column: "CityGUID",
                value: new Guid("7ad960a4-cbce-4bb8-9db3-5ba48e688f42"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 494,
                column: "CityGUID",
                value: new Guid("955e9076-0cb5-419d-9992-a48b7de3f040"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 495,
                column: "CityGUID",
                value: new Guid("52ab65a4-4989-4594-a63a-b214b282bf95"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 496,
                column: "CityGUID",
                value: new Guid("08ff9f4c-9b9f-4abe-857b-40a9731bf570"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 497,
                column: "CityGUID",
                value: new Guid("6ebe628f-43fd-4532-a19b-a1d7c582dbf3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 498,
                column: "CityGUID",
                value: new Guid("fe581b0f-bc86-4585-a7f1-5d815743b366"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 499,
                column: "CityGUID",
                value: new Guid("5adb98e6-ebb6-4890-822d-6a61ca436009"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 500,
                column: "CityGUID",
                value: new Guid("d21d3809-1a18-4d41-a174-3b0e7d1b4224"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 501,
                column: "CityGUID",
                value: new Guid("4f4a7cae-2e8f-4433-a2ac-901facb4340a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 502,
                column: "CityGUID",
                value: new Guid("d0dba840-ab86-4b98-b14f-70177757071c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 503,
                column: "CityGUID",
                value: new Guid("cf63aa4d-7acb-473c-9b52-293731b4d136"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 504,
                column: "CityGUID",
                value: new Guid("a4fae4e7-d80d-4971-8d0f-87b7eb60d09a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 505,
                column: "CityGUID",
                value: new Guid("200008c8-5238-46a6-8aca-fb0743002799"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 506,
                column: "CityGUID",
                value: new Guid("f5ce20e7-0c85-404f-a44b-4c03e42ae6b0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 507,
                column: "CityGUID",
                value: new Guid("d6fda820-f48c-4a88-ac18-7547f4749860"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 508,
                column: "CityGUID",
                value: new Guid("6cbe5710-29ea-49a7-9674-54ef3711ffb5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 509,
                column: "CityGUID",
                value: new Guid("7b55f4d2-bfd8-42ba-ab30-72eda495bb2e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 510,
                column: "CityGUID",
                value: new Guid("93929491-7b6a-4127-8641-cc48b6354c16"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 511,
                column: "CityGUID",
                value: new Guid("8c3f8e51-63fc-4d98-9352-17237956294b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 512,
                column: "CityGUID",
                value: new Guid("b15b7c5a-4cab-4a2e-b2fe-afd6d6cb4f08"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 513,
                column: "CityGUID",
                value: new Guid("d3c4d33c-a767-421c-beaa-32e1fe65508d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 514,
                column: "CityGUID",
                value: new Guid("9ae84c93-f3db-4af2-87a1-462d37d544d2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 515,
                column: "CityGUID",
                value: new Guid("2d6c851a-d212-4f21-8434-c5d8d64aed82"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 516,
                column: "CityGUID",
                value: new Guid("c6f3d5f0-3f0e-4fbe-b6c4-a6ea675ef38c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 517,
                column: "CityGUID",
                value: new Guid("fccfc763-b0ea-4616-b51e-192e6b6ee335"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 518,
                column: "CityGUID",
                value: new Guid("7d6c8e66-26a5-420a-9d0c-e0e688debc39"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 519,
                column: "CityGUID",
                value: new Guid("97dce133-1566-453b-87d9-d3382cc30f7c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 520,
                column: "CityGUID",
                value: new Guid("957faaa2-ea1e-4958-aa4d-a92d96bcb551"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 521,
                column: "CityGUID",
                value: new Guid("3b7bcb85-79dc-467d-b83b-e33e9cbf65cb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 522,
                column: "CityGUID",
                value: new Guid("ba14cc94-1c11-4308-98db-588ab25bc3bd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 523,
                column: "CityGUID",
                value: new Guid("f10c7508-beec-4589-a6c9-318733f0912a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 524,
                column: "CityGUID",
                value: new Guid("b379a5f6-ffd5-4688-9db2-ca07c7d09dcd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 525,
                column: "CityGUID",
                value: new Guid("948ec376-5370-4bb1-8997-7a3d55d4434c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 526,
                column: "CityGUID",
                value: new Guid("69da730a-599c-4260-897f-9d59d32028c8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 527,
                column: "CityGUID",
                value: new Guid("fc34a355-0cdb-4dd4-9971-6e464a53b393"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 528,
                column: "CityGUID",
                value: new Guid("2876c7f7-2e69-45b2-baf1-5c026838fe9a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 529,
                column: "CityGUID",
                value: new Guid("4f7a0e61-3d3d-42e9-9279-672e46eacd43"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 530,
                column: "CityGUID",
                value: new Guid("4bafe4d8-cac8-4d2d-b7ce-c2556b33eb4c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 531,
                column: "CityGUID",
                value: new Guid("7147d2fe-5b56-41b5-ac96-e734ea83deed"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 532,
                column: "CityGUID",
                value: new Guid("6e52a345-5869-499c-b3e1-8fc65ea7707f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 533,
                column: "CityGUID",
                value: new Guid("f40a6156-538b-4e64-abfe-2b3f840862f6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 534,
                column: "CityGUID",
                value: new Guid("cd6c1ee3-da98-4089-ab6a-4f2a39270982"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 535,
                column: "CityGUID",
                value: new Guid("dd5d8eee-4b73-40ec-b388-9564b4c2c40a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 536,
                column: "CityGUID",
                value: new Guid("6dda8368-c3b6-433f-99fd-866e9b01c9a3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 537,
                column: "CityGUID",
                value: new Guid("052d0546-fb49-4a50-9cf4-23c19ed48353"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 538,
                column: "CityGUID",
                value: new Guid("9e73fcac-3069-4e35-96c7-f5aba2233ad4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 539,
                column: "CityGUID",
                value: new Guid("c8547624-7bb8-4b89-8027-e09b5b454296"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 540,
                column: "CityGUID",
                value: new Guid("1aac3a57-10ac-4766-a165-d55057118a5d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 541,
                column: "CityGUID",
                value: new Guid("86264d6a-dfd3-4b6c-8f36-98c05669c99a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 542,
                column: "CityGUID",
                value: new Guid("100e719d-b261-49d8-b62f-53586c707189"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 543,
                column: "CityGUID",
                value: new Guid("745017a1-849a-464c-a868-3045d747e2f4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 544,
                column: "CityGUID",
                value: new Guid("7c216c61-23d2-40c5-a8ef-bb5c21dda1ba"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 545,
                column: "CityGUID",
                value: new Guid("f001d625-20d5-4faa-b025-a8853753ab0c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 546,
                column: "CityGUID",
                value: new Guid("f9ef000f-70b2-4b33-8639-24f71fc23f23"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 547,
                column: "CityGUID",
                value: new Guid("83b62db0-dde4-4609-9b80-d43a96603080"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 548,
                column: "CityGUID",
                value: new Guid("d989fec2-c445-457c-ab06-ffafec1b1f6c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 549,
                column: "CityGUID",
                value: new Guid("b16625c7-2b38-4532-8089-76340ed8103c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 550,
                column: "CityGUID",
                value: new Guid("b383911a-4bc8-432c-8812-d1afed14c3b1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 551,
                column: "CityGUID",
                value: new Guid("c40c98bc-93a7-4226-8417-5ad91801de00"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 552,
                column: "CityGUID",
                value: new Guid("09da94a0-50db-46e9-9659-54c2cc4e16c6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 553,
                column: "CityGUID",
                value: new Guid("95c5639c-02d7-4d49-9494-30c954ab9424"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 554,
                column: "CityGUID",
                value: new Guid("540d8f51-5593-453f-ba09-c5faedbca7f7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 555,
                column: "CityGUID",
                value: new Guid("b0d19f40-05b5-4ffb-8e99-c6976ba6acf1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 556,
                column: "CityGUID",
                value: new Guid("adb3ad60-e7ed-436a-bc7d-939dccc2a3bd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 557,
                column: "CityGUID",
                value: new Guid("3530df9e-59d9-4c87-8354-2ac6b0515670"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 558,
                column: "CityGUID",
                value: new Guid("627c75f3-1cbe-4b43-ab99-e49e256c58fb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 559,
                column: "CityGUID",
                value: new Guid("9686c50c-d341-4ff5-b605-3134ee54b2c2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 560,
                column: "CityGUID",
                value: new Guid("bb7b925c-7471-4f46-987f-c38dea861f5f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 561,
                column: "CityGUID",
                value: new Guid("1ae6fa48-7960-4260-b39c-ce67ee4e1b2e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 562,
                column: "CityGUID",
                value: new Guid("57d985d5-b57b-4991-8d0a-147b49a2a473"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 563,
                column: "CityGUID",
                value: new Guid("4f4d994f-0a54-4548-bd16-5712787606af"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 564,
                column: "CityGUID",
                value: new Guid("a4bc2d17-b86c-4985-a0d2-693c8fe81c54"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 565,
                column: "CityGUID",
                value: new Guid("ea9229c0-bff1-4e4f-8b30-7edaa93220e9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 566,
                column: "CityGUID",
                value: new Guid("39b6c340-1eae-4090-8315-41cff906b256"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 567,
                column: "CityGUID",
                value: new Guid("431b797e-3b02-4a6c-a1e3-a3306956072b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 568,
                column: "CityGUID",
                value: new Guid("51abc298-7919-4675-babd-3b3060ec07da"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 569,
                column: "CityGUID",
                value: new Guid("cc091979-5371-4711-8eb6-7100839cb870"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 570,
                column: "CityGUID",
                value: new Guid("72cbdd06-9415-4463-9234-5a3937176d38"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 571,
                column: "CityGUID",
                value: new Guid("244ab40f-ce13-4f17-91f1-b181d73b9a5e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 572,
                column: "CityGUID",
                value: new Guid("c9b992f1-84d0-4fa8-b1ac-042b9df5a438"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 573,
                column: "CityGUID",
                value: new Guid("77c6f6f5-cd6a-4263-bc5f-783b39b83103"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 574,
                column: "CityGUID",
                value: new Guid("711c9e8b-ce2b-44e0-9725-380b3260c050"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 575,
                column: "CityGUID",
                value: new Guid("cb46595b-c902-4d0a-a82d-04bd0459e368"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 576,
                column: "CityGUID",
                value: new Guid("f1a969c1-d452-4c7a-817a-bbc36f9991c4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 577,
                column: "CityGUID",
                value: new Guid("f87c0fb0-8c09-4c1a-acf0-415340d4e688"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 578,
                column: "CityGUID",
                value: new Guid("e682a52b-57a7-4145-b8d3-f4ee37714a3c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 579,
                column: "CityGUID",
                value: new Guid("6772066c-023a-4560-8254-7013e7c362e0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 580,
                column: "CityGUID",
                value: new Guid("4cc6364f-7482-44cb-b58c-55888d6f7c5b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 581,
                column: "CityGUID",
                value: new Guid("ce8a5437-490c-46b0-8bef-2efd503065ee"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 582,
                column: "CityGUID",
                value: new Guid("f248fa12-c408-4701-83bc-fbde8c3ac784"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 583,
                column: "CityGUID",
                value: new Guid("80909a02-61dd-473d-bbf4-abe39cc9c98e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 584,
                column: "CityGUID",
                value: new Guid("a87e2bfe-22ea-4be7-8873-7cd5c0e62b3f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 585,
                column: "CityGUID",
                value: new Guid("2c517fb8-d992-4480-8c14-45565c34ceaa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 586,
                column: "CityGUID",
                value: new Guid("9438bc91-5d6b-43f4-9498-16c30862f8f6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 587,
                column: "CityGUID",
                value: new Guid("e070e1ef-b1ee-4aaf-a987-0140b8ea8973"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 588,
                column: "CityGUID",
                value: new Guid("7e1c6f63-e0cc-4682-9dee-1ed54899c528"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 589,
                column: "CityGUID",
                value: new Guid("ee34dcd8-a7cf-4e38-abfb-7b1cbe978f90"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 590,
                column: "CityGUID",
                value: new Guid("1c9a59a9-86c0-404e-805c-93c285fd71de"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 591,
                column: "CityGUID",
                value: new Guid("7739f795-ea8d-4f5f-917a-11a11e98fc05"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 592,
                column: "CityGUID",
                value: new Guid("4eb3f3bd-4f5c-4bfd-b4a2-23a719c73e42"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 593,
                column: "CityGUID",
                value: new Guid("fb3b78fb-39a1-46aa-b91c-b81776e91d3a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 594,
                column: "CityGUID",
                value: new Guid("f4eaa1aa-57ed-42e8-aeab-c40e7b94acd9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 595,
                column: "CityGUID",
                value: new Guid("92cd1b7e-36c5-404f-a9f2-f6d7dc50d23b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 596,
                column: "CityGUID",
                value: new Guid("56eaada3-7973-4464-ac41-e962c2169f00"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 597,
                column: "CityGUID",
                value: new Guid("7779373f-6fce-4c4e-8249-ea45a6aaf86c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 598,
                column: "CityGUID",
                value: new Guid("8f2cad58-8f4a-4e5e-99b1-f3e9e6ab49d0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 599,
                column: "CityGUID",
                value: new Guid("bbb0bd96-e5da-4a7c-acaa-7bcf778a1fac"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 600,
                column: "CityGUID",
                value: new Guid("c6c26abe-044f-48db-b883-8a63ad01e177"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 601,
                column: "CityGUID",
                value: new Guid("1e8dc1e4-3016-473e-aa3b-d7c5be76507f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 602,
                column: "CityGUID",
                value: new Guid("3a086406-bc5b-4490-be4d-6213e4c67d2a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 603,
                column: "CityGUID",
                value: new Guid("019c29a0-7973-45de-9c66-795b949df2fd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 604,
                column: "CityGUID",
                value: new Guid("7f0cb124-a6a2-4427-84b8-8f161a872e42"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 605,
                column: "CityGUID",
                value: new Guid("0ae497d7-99c4-4adc-96b2-ed3e03ebb4f5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 606,
                column: "CityGUID",
                value: new Guid("ee0132ce-afd7-4efa-b3b3-d786da027735"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 607,
                column: "CityGUID",
                value: new Guid("662203ec-01eb-460e-b374-b7319186f293"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 608,
                column: "CityGUID",
                value: new Guid("d3b45614-70fa-4834-ab82-b4178846d8df"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 609,
                column: "CityGUID",
                value: new Guid("719fcd58-3c94-49f7-8c12-2b913439e6ff"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 610,
                column: "CityGUID",
                value: new Guid("6ce5957d-ac4e-4952-9712-5cc50701dcb5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 611,
                column: "CityGUID",
                value: new Guid("6d8ee7f9-a730-4628-8ad5-5c87d99ef76a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 612,
                column: "CityGUID",
                value: new Guid("46d3b289-fa9e-4243-87d8-279e1d4db9ce"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 613,
                column: "CityGUID",
                value: new Guid("8d819561-54d2-4806-a593-4e974183fb46"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 614,
                column: "CityGUID",
                value: new Guid("cfab8c66-af83-4e54-84fa-07a13ea9550e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 615,
                column: "CityGUID",
                value: new Guid("9f601e8b-96c4-4756-adf5-64eab02f3fd2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 616,
                column: "CityGUID",
                value: new Guid("b7d39995-685b-496a-85cc-0a01c6af7104"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 617,
                column: "CityGUID",
                value: new Guid("37382e36-6a18-49de-9567-208535fe26b4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 618,
                column: "CityGUID",
                value: new Guid("f33010af-dfa1-4557-b910-42e8e1626861"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 619,
                column: "CityGUID",
                value: new Guid("63637bb0-142c-4397-a09c-8195602541da"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 620,
                column: "CityGUID",
                value: new Guid("47ac0ac9-9651-4cb5-8e5d-fdc4caca6569"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 621,
                column: "CityGUID",
                value: new Guid("da2fe109-f453-409c-8f69-17d832e36ed6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 622,
                column: "CityGUID",
                value: new Guid("c8f417aa-ff11-47f2-b289-b41ddb8efb6f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 623,
                column: "CityGUID",
                value: new Guid("81e7808b-9909-4c3a-bee0-d0b0e6353a87"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 624,
                column: "CityGUID",
                value: new Guid("b0bd6d33-f3b5-4b3f-88a4-c84d6d75377e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 625,
                column: "CityGUID",
                value: new Guid("8abad7b2-5281-4b23-a5c9-04a29b2a1347"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 626,
                column: "CityGUID",
                value: new Guid("97bc0089-6e99-4a3e-a94d-998f22e3de1e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 627,
                column: "CityGUID",
                value: new Guid("60c9c346-1689-46d1-80b3-d50afe14d277"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 628,
                column: "CityGUID",
                value: new Guid("e41621ae-ccb4-46c5-a8bb-6e68c9daed97"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 629,
                column: "CityGUID",
                value: new Guid("d88c64d6-c367-4fe1-9ffd-807bf6cb1beb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 630,
                column: "CityGUID",
                value: new Guid("1dc6207f-9ee8-4768-b127-a61b3b800235"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 631,
                column: "CityGUID",
                value: new Guid("edbc7731-c51e-4be7-b548-908917f74b1c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 632,
                column: "CityGUID",
                value: new Guid("ddac2403-541b-493d-9ee5-0c492a6ac9c7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 633,
                column: "CityGUID",
                value: new Guid("1a1f5518-9fab-490a-958d-dd2143a03e03"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 634,
                column: "CityGUID",
                value: new Guid("fc8bf5cf-037d-4617-bc04-75f9b8de9fd9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 635,
                column: "CityGUID",
                value: new Guid("de54caff-8926-441d-bfc8-84952212642d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 636,
                column: "CityGUID",
                value: new Guid("03207074-ce60-4140-b6e6-ba8b81b9b5a5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 637,
                column: "CityGUID",
                value: new Guid("683a8289-7fab-4af3-8abc-656591953f38"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 638,
                column: "CityGUID",
                value: new Guid("ad61af53-02d4-4dc1-8d0e-482cd18a53c0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 639,
                column: "CityGUID",
                value: new Guid("4b869f15-deea-43e4-8019-cc9b8fd1c9cb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 640,
                column: "CityGUID",
                value: new Guid("7fd00bed-ebc7-4c33-bf84-7384b0e59142"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 641,
                column: "CityGUID",
                value: new Guid("75bd649e-13e3-4523-94f7-cc5c512b688a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 642,
                column: "CityGUID",
                value: new Guid("c40e1738-3b7d-4729-8f02-7a887394dd61"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 643,
                column: "CityGUID",
                value: new Guid("2e55b6a2-ad7a-4668-93d1-40c250909999"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 644,
                column: "CityGUID",
                value: new Guid("4c95ff35-9a02-4797-9ded-34cb7d2d66a9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 645,
                column: "CityGUID",
                value: new Guid("16551f8b-5a80-4af7-9048-c0eee0a56b8f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 646,
                column: "CityGUID",
                value: new Guid("d6544660-8a0e-46a2-97b9-bb7c53c484f5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 647,
                column: "CityGUID",
                value: new Guid("82ef117f-37da-4a47-b754-fd97033accf6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 648,
                column: "CityGUID",
                value: new Guid("5a7e3f8a-6be1-4cde-919d-ab991eb115ae"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 649,
                column: "CityGUID",
                value: new Guid("ae808e82-2cd4-4fe6-93ef-8e16a88fd01f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 650,
                column: "CityGUID",
                value: new Guid("47cb16ec-0c04-445d-9a0f-3e5f3af519a7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 651,
                column: "CityGUID",
                value: new Guid("76ba9e13-ebcc-4f4a-8acd-d7518a0e3f1e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 652,
                column: "CityGUID",
                value: new Guid("259e0ee9-88fc-4f63-8046-1c65414117be"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 653,
                column: "CityGUID",
                value: new Guid("64cef554-99b4-4f88-8081-29f98be0c51c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 654,
                column: "CityGUID",
                value: new Guid("259f78db-93e6-42ce-8eb3-25963220ff1c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 655,
                column: "CityGUID",
                value: new Guid("0abe54e4-90c6-435b-8dae-7c69682b6377"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 656,
                column: "CityGUID",
                value: new Guid("8d5767cb-760d-4c21-8060-ccdef818c07f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 657,
                column: "CityGUID",
                value: new Guid("62137eef-fb00-4322-a2c6-0c77a4a76da6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 658,
                column: "CityGUID",
                value: new Guid("5f552c98-7990-4881-bce3-4387c4d6515a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 659,
                column: "CityGUID",
                value: new Guid("933134d9-29c5-404e-9463-3b092d3f10e5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 660,
                column: "CityGUID",
                value: new Guid("16b2697b-3266-499b-a5fc-0bfba3613a93"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 661,
                column: "CityGUID",
                value: new Guid("e00b94ca-c7b2-4e79-adc2-7941aa23e8a0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 662,
                column: "CityGUID",
                value: new Guid("e92c55dc-7586-4dca-b955-7ba9661a2679"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 663,
                column: "CityGUID",
                value: new Guid("3e47f81f-974c-4af5-a2a5-0dd13975a3b6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 664,
                column: "CityGUID",
                value: new Guid("97d5b4f4-28ab-4452-87ce-7e96c7bc7f89"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 665,
                column: "CityGUID",
                value: new Guid("9fc5e1d9-49c6-4863-a8f1-b379f5793e21"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 666,
                column: "CityGUID",
                value: new Guid("5a4a8946-d3dd-48f1-968a-8728f98cef4b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 667,
                column: "CityGUID",
                value: new Guid("15538f80-0754-44ab-b534-2c6ea112dcb8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 668,
                column: "CityGUID",
                value: new Guid("d906737d-0c2f-4547-9643-4a14ab7610de"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 669,
                column: "CityGUID",
                value: new Guid("63b6f893-56ec-4e67-a45e-84387d86782f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 670,
                column: "CityGUID",
                value: new Guid("9848df69-aa9d-4b17-a484-e251ecc4c47d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 671,
                column: "CityGUID",
                value: new Guid("e9aedaaa-35f7-4477-8671-65c7636ac924"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 672,
                column: "CityGUID",
                value: new Guid("ac8c83fb-be9d-4785-8f3b-2adce1320fc2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 673,
                column: "CityGUID",
                value: new Guid("c112d400-9667-4305-a43a-85d9abfbf087"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 674,
                column: "CityGUID",
                value: new Guid("f19fb6fc-3e44-49ba-9581-9cb6fc80ea7c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 675,
                column: "CityGUID",
                value: new Guid("1709d388-b289-4ef4-93e7-47ab55ea4e55"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 676,
                column: "CityGUID",
                value: new Guid("c9114e8a-641b-4fd6-a984-7a6cfbc54a8d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 677,
                column: "CityGUID",
                value: new Guid("53db7dfa-6eb5-4814-9c51-3671ee9880e1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 678,
                column: "CityGUID",
                value: new Guid("d507f714-dfb5-4872-8443-4f04fbe72419"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 679,
                column: "CityGUID",
                value: new Guid("d5de4c3a-e25e-45fc-b55d-ec5eba3e2814"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 680,
                column: "CityGUID",
                value: new Guid("fa0428ec-84d8-439d-bcc2-ee326f361bfb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 681,
                column: "CityGUID",
                value: new Guid("7d31c191-df54-44e5-93c2-d583e213ed6b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 682,
                column: "CityGUID",
                value: new Guid("e01f3e25-ee23-45f7-8d6d-a7a3935a696d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 683,
                column: "CityGUID",
                value: new Guid("b15863e9-40e4-4741-b17f-52024c6fda87"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 684,
                column: "CityGUID",
                value: new Guid("b59e3d97-411c-4b39-a224-3f1509efa7a4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 685,
                column: "CityGUID",
                value: new Guid("8bbadd2b-15eb-443b-8104-fc65815b36d2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 686,
                column: "CityGUID",
                value: new Guid("1fd7a064-aebe-45e6-aef2-8e96f425891b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 687,
                column: "CityGUID",
                value: new Guid("a3a05c2c-4c47-40bb-a777-4db157adbeee"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 688,
                column: "CityGUID",
                value: new Guid("5f2da656-5714-49ba-bc1d-a66c56af3bb4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 689,
                column: "CityGUID",
                value: new Guid("7a1bbaa6-8796-4ba8-9ae4-09de0b1a4361"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 690,
                column: "CityGUID",
                value: new Guid("0256bbd9-0591-4bd6-a996-555aedda4e6c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 691,
                column: "CityGUID",
                value: new Guid("32ef5072-5e9c-4cfb-afea-fe31bbb5ef6e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 692,
                column: "CityGUID",
                value: new Guid("1903bd62-1ac9-4037-bdab-d793658b1a18"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 693,
                column: "CityGUID",
                value: new Guid("843a6cf6-18f8-4630-be5a-576d72b7a5e0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 694,
                column: "CityGUID",
                value: new Guid("f475e4e8-757a-4574-82da-fd21e3afabc4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 695,
                column: "CityGUID",
                value: new Guid("72bde7f4-a238-421b-b987-5726187bb8a5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 696,
                column: "CityGUID",
                value: new Guid("7b7c809b-1080-4253-8040-5e0804046b47"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 697,
                column: "CityGUID",
                value: new Guid("97bcfe2c-105a-4bd6-86b5-3d8fb62181bc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 698,
                column: "CityGUID",
                value: new Guid("767ac762-c7c8-4420-a4a8-3d34b0b854f3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 699,
                column: "CityGUID",
                value: new Guid("622e5433-4ac3-469c-aeaa-865a2ebbe4e7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 700,
                column: "CityGUID",
                value: new Guid("c7a87338-ae06-4202-b968-e1c17f41662c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 701,
                column: "CityGUID",
                value: new Guid("58ebcfef-5a8e-45bb-8cc5-3a5a96e3c290"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 702,
                column: "CityGUID",
                value: new Guid("bb17d753-1422-4637-aa46-b763f3a08577"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 703,
                column: "CityGUID",
                value: new Guid("b986d8f4-3b1f-40a0-a822-f82892817c81"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 704,
                column: "CityGUID",
                value: new Guid("fa744380-5a0a-4702-ab89-1aed6d594422"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 705,
                column: "CityGUID",
                value: new Guid("c990a0c0-e5a5-4243-9df9-abd6185e682f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 706,
                column: "CityGUID",
                value: new Guid("e218794e-87df-459f-8362-227f755ffcad"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 707,
                column: "CityGUID",
                value: new Guid("88687c4d-34a9-4a33-9432-eb2fd82fa364"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 708,
                column: "CityGUID",
                value: new Guid("f59d8c47-2d4b-4de6-929e-d6f36033ceae"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 709,
                column: "CityGUID",
                value: new Guid("69582eef-a14c-454f-accd-4ef9b471f1eb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 710,
                column: "CityGUID",
                value: new Guid("aa7ac99e-167b-4401-8713-943889b8854d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 711,
                column: "CityGUID",
                value: new Guid("727fc34a-8d57-403f-9d24-b7a463502301"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 712,
                column: "CityGUID",
                value: new Guid("2c08ddaa-cbfe-44e8-9b56-4af54378e383"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 713,
                column: "CityGUID",
                value: new Guid("7c85eda8-4026-4a04-b3cf-91d5f2a74fa2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 714,
                column: "CityGUID",
                value: new Guid("395c8ebe-0ef9-4143-8c2b-39226cec45ad"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 715,
                column: "CityGUID",
                value: new Guid("c1c854a0-a7e6-4e51-a5cb-6ba5974f5e1f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 716,
                column: "CityGUID",
                value: new Guid("b180b1f4-b6e5-4cdc-b6c6-38fe21eef395"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 717,
                column: "CityGUID",
                value: new Guid("d68f8101-b760-4acb-8659-13e68f94c8d9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 718,
                column: "CityGUID",
                value: new Guid("8072799a-73bd-4497-8a7d-ca7ce427c76c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 719,
                column: "CityGUID",
                value: new Guid("d4f46b46-1eff-464c-a603-199c9bfdffc4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 720,
                column: "CityGUID",
                value: new Guid("88b9f428-8122-4b58-b5be-1641bfdb3541"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 721,
                column: "CityGUID",
                value: new Guid("18a5ebe8-90ee-4bfe-8e53-28d7c5729e9a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 722,
                column: "CityGUID",
                value: new Guid("180bc47a-5ab2-4f93-a691-cc3d4a220e75"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 723,
                column: "CityGUID",
                value: new Guid("4ad8e4c6-0ffa-46da-930c-44287bdc190b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 724,
                column: "CityGUID",
                value: new Guid("d12ddbe3-9c00-49fc-9634-9b06b58d6dec"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 725,
                column: "CityGUID",
                value: new Guid("c27de786-cdcd-4306-9ffe-f3231ae0a282"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 726,
                column: "CityGUID",
                value: new Guid("a1344071-ce64-4742-8a2b-4dec0f0cb708"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 727,
                column: "CityGUID",
                value: new Guid("5fe9eeed-8e86-4207-bc99-a495dd4b4e2d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 728,
                column: "CityGUID",
                value: new Guid("63cf4afe-390a-493d-b353-a725e736f93b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 729,
                column: "CityGUID",
                value: new Guid("4f887d29-3845-4a73-a299-aa1a5741b1a4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 730,
                column: "CityGUID",
                value: new Guid("8e4c1d65-31c8-46a6-821b-feb04127a2e4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 731,
                column: "CityGUID",
                value: new Guid("b328f447-e5a9-40c7-a143-d1456aa536e5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 732,
                column: "CityGUID",
                value: new Guid("5c62ced4-47b7-4791-8970-5401357a734f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 733,
                column: "CityGUID",
                value: new Guid("9de21481-c43a-4a27-8d39-4583e94cd0a2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 734,
                column: "CityGUID",
                value: new Guid("5268299b-10c6-4072-a431-1c1e8de8e83d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 735,
                column: "CityGUID",
                value: new Guid("513a5ed4-b6b9-4b74-9ced-313aef482cf0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 736,
                column: "CityGUID",
                value: new Guid("8f162892-a75c-41c4-9f07-a8ce520cc8e9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 737,
                column: "CityGUID",
                value: new Guid("197ab6d5-9c44-46a3-8eeb-7d7d593bd53e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 738,
                column: "CityGUID",
                value: new Guid("890ea33b-cd54-43d4-ae3a-299ed763c1ac"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 739,
                column: "CityGUID",
                value: new Guid("e2bd5bab-9e31-4400-899f-125fc8311960"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 740,
                column: "CityGUID",
                value: new Guid("42c8e031-2b72-44fd-85de-bc5f8585ad10"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 741,
                column: "CityGUID",
                value: new Guid("33ffdcf5-5be6-42c2-9c8d-b58278ef5f67"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 742,
                column: "CityGUID",
                value: new Guid("9a70aa11-259c-441d-8bf9-a0e446632817"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 743,
                column: "CityGUID",
                value: new Guid("5dfe2625-a99c-4bed-890d-bc6cbc2743f0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 744,
                column: "CityGUID",
                value: new Guid("ce762df8-14ef-4438-a24a-123fcfc40647"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 745,
                column: "CityGUID",
                value: new Guid("e260b08d-e9b4-4b2c-857f-bf291ab13cc3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 746,
                column: "CityGUID",
                value: new Guid("156b074c-3d2b-43bc-95fe-ae43f1f6d091"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 747,
                column: "CityGUID",
                value: new Guid("21263f2d-d694-4585-9314-b6257358bfd8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 748,
                column: "CityGUID",
                value: new Guid("090a774b-159f-4dd2-8340-9c076f5c30eb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 749,
                column: "CityGUID",
                value: new Guid("7562b13f-7fee-4ea3-a107-09e1084e2bdb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 750,
                column: "CityGUID",
                value: new Guid("389ad7c1-9c19-4658-98ce-dd2c9685cf75"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 751,
                column: "CityGUID",
                value: new Guid("2d612d42-388c-4619-bd72-cdad6d6b7e09"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 752,
                column: "CityGUID",
                value: new Guid("48d6a6cc-abaa-4648-95dd-7af721379fcc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 753,
                column: "CityGUID",
                value: new Guid("3d0c23b4-da03-45c9-b924-361904538082"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 754,
                column: "CityGUID",
                value: new Guid("10490229-72ec-4d2e-8a73-5591629b6682"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 755,
                column: "CityGUID",
                value: new Guid("93dbb0dd-ac94-4c76-a5f6-ee478b63a5b3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 756,
                column: "CityGUID",
                value: new Guid("c2ee75db-f0ec-41ae-8838-7273ad1afb60"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 757,
                column: "CityGUID",
                value: new Guid("621d5e67-ece9-45f1-9af1-40d71102575e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 758,
                column: "CityGUID",
                value: new Guid("6f9e80c2-d7bf-406d-a9cb-92e3b1383ee5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 759,
                column: "CityGUID",
                value: new Guid("8145bf23-cf8f-45a3-89d7-0ec86fe096b9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 760,
                column: "CityGUID",
                value: new Guid("906bf29f-0f81-4a5b-95f7-650a1d3d3005"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 761,
                column: "CityGUID",
                value: new Guid("25ca9a38-2f5d-47d7-bb33-af914fc21d50"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 762,
                column: "CityGUID",
                value: new Guid("36da974f-303b-4630-95fa-883406e77aec"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 763,
                column: "CityGUID",
                value: new Guid("abc55fd2-ba7c-4e80-a6a9-90e4afc66a9a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 764,
                column: "CityGUID",
                value: new Guid("aa43ce4d-36ff-4d15-8649-c68492802e34"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 765,
                column: "CityGUID",
                value: new Guid("262f2a16-0799-4f3d-a128-0eed8f426b72"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 766,
                column: "CityGUID",
                value: new Guid("462d2b15-fede-4ec2-95e6-73960c493b53"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 767,
                column: "CityGUID",
                value: new Guid("37706b30-9d67-4975-bad2-e5fadfe392ee"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 768,
                column: "CityGUID",
                value: new Guid("b3cab41c-0cf4-432d-9b82-95c418c20bbe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 769,
                column: "CityGUID",
                value: new Guid("a68b581c-f082-4c91-ac68-e3f2720e3588"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 770,
                column: "CityGUID",
                value: new Guid("bbe07848-51ea-497b-8036-02bae62aa5ce"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 771,
                column: "CityGUID",
                value: new Guid("78ce1e59-25f4-4c70-8e96-4ca1a329316d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 772,
                column: "CityGUID",
                value: new Guid("163a7567-8f72-4a03-8e32-a6aca20b8f88"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 773,
                column: "CityGUID",
                value: new Guid("813fec07-562c-4bad-8f14-30f6f3b23814"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 774,
                column: "CityGUID",
                value: new Guid("c1c6b4ff-f107-46f3-acbe-03227391c616"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 775,
                column: "CityGUID",
                value: new Guid("f6c7cbf6-9fd1-47b5-b905-7a4b61ad378a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 776,
                column: "CityGUID",
                value: new Guid("26547d5b-259a-4f6c-8135-f85046b273c8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 777,
                column: "CityGUID",
                value: new Guid("c5ab7e30-d4a8-4864-b21c-6ab3cace9044"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 778,
                column: "CityGUID",
                value: new Guid("7688c6f2-390d-4d9a-b446-b74efa1f0687"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 779,
                column: "CityGUID",
                value: new Guid("36adbe30-11b1-4931-80e7-718152315b82"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 780,
                column: "CityGUID",
                value: new Guid("a7e3b1a6-8248-4887-9f72-a807f7c69f5b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 781,
                column: "CityGUID",
                value: new Guid("412a5b94-d54c-41ad-bccf-044cd7e6fd37"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 782,
                column: "CityGUID",
                value: new Guid("b0e49ac1-0252-42b2-87c6-a18cda117bf0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 783,
                column: "CityGUID",
                value: new Guid("f45029ac-e1d8-43b8-b441-60a6aeeb57ae"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 784,
                column: "CityGUID",
                value: new Guid("fc549c80-c126-4e32-b549-b5260099b203"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 785,
                column: "CityGUID",
                value: new Guid("ed5e28c2-487a-407f-88bb-ee56ab995706"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 786,
                column: "CityGUID",
                value: new Guid("f0011b14-16ff-4746-9130-00e28ca83e45"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 787,
                column: "CityGUID",
                value: new Guid("acf00b6a-326a-4d80-8488-6e4c5d9291c9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 788,
                column: "CityGUID",
                value: new Guid("976668c7-6c94-4398-9f88-28bf841ea9f1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 789,
                column: "CityGUID",
                value: new Guid("07cae751-8757-46ef-9456-3d85cf552b64"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 790,
                column: "CityGUID",
                value: new Guid("0fb329f7-7a4a-4473-b995-550d0cd64246"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 791,
                column: "CityGUID",
                value: new Guid("40be4aee-41a7-4d7d-b379-817301e4ab43"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 792,
                column: "CityGUID",
                value: new Guid("e8abeaae-7e4e-4cd4-81ee-8085ef3a5228"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 793,
                column: "CityGUID",
                value: new Guid("66f52245-73b9-482e-954f-548832037c4a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 794,
                column: "CityGUID",
                value: new Guid("a62b569c-4e30-455a-a5bc-4879cacb164a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 795,
                column: "CityGUID",
                value: new Guid("2e215852-bf09-445d-8d78-96e7835a3219"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 796,
                column: "CityGUID",
                value: new Guid("928b4347-f5e1-4c72-9a19-de9c58df36f9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 797,
                column: "CityGUID",
                value: new Guid("cfbfa297-dc4c-4fa1-a09b-6941c17e0db5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 798,
                column: "CityGUID",
                value: new Guid("50a131ee-aacf-4b3d-8b92-9d1ac4c35c4f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 799,
                column: "CityGUID",
                value: new Guid("293fc4cf-9e4d-4b97-ba12-41cfdbbfb49e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 800,
                column: "CityGUID",
                value: new Guid("be84f9db-6f72-42d5-86c1-f6211425a269"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 801,
                column: "CityGUID",
                value: new Guid("0a8171a4-b5a1-4644-9736-918713ce070b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 802,
                column: "CityGUID",
                value: new Guid("4347ee6a-947a-4aa4-9ea7-3ea43ab1c6d8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 803,
                column: "CityGUID",
                value: new Guid("d205fa6b-8703-464e-9234-d6aec57dbb82"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 804,
                column: "CityGUID",
                value: new Guid("682452b8-f07b-47a7-b279-426bbed5cb81"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 805,
                column: "CityGUID",
                value: new Guid("bcc93a88-850b-4041-8f35-6d7fcf11de5b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 806,
                column: "CityGUID",
                value: new Guid("4b2b549d-2466-42e1-85d1-ddf86936917a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 807,
                column: "CityGUID",
                value: new Guid("d5f45149-4845-4829-a8e4-f07ef496ae27"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 808,
                column: "CityGUID",
                value: new Guid("fc6d8c5c-357d-4093-b542-a979dfc4331c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 809,
                column: "CityGUID",
                value: new Guid("3aad5a72-ef74-4ff6-bf95-0a9705487f95"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 810,
                column: "CityGUID",
                value: new Guid("5a140b93-b8d2-4372-be39-63fb6aeee587"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 811,
                column: "CityGUID",
                value: new Guid("e59d46ae-afe9-4cc9-9dd7-d4a667357c17"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 812,
                column: "CityGUID",
                value: new Guid("945076da-07cc-4957-b5ee-6a89d7aeb353"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 813,
                column: "CityGUID",
                value: new Guid("90e90a27-fcfe-46dd-81ee-0aa99e9afc40"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 814,
                column: "CityGUID",
                value: new Guid("84f10d49-f662-4209-bca1-6bf41075b080"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 815,
                column: "CityGUID",
                value: new Guid("38099c8e-6b7a-4d0a-ae70-cb85e7c8db73"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 816,
                column: "CityGUID",
                value: new Guid("54b60a13-8f8f-459b-b810-e2a23dfa8211"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 817,
                column: "CityGUID",
                value: new Guid("75d232c3-80f4-477b-8022-e39d2d79d87f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 818,
                column: "CityGUID",
                value: new Guid("f0f37662-583c-4b4b-9fc0-1c6b6fe4b9a5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 819,
                column: "CityGUID",
                value: new Guid("fee40265-1fec-4cb2-aa95-7482fdc50ed6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 820,
                column: "CityGUID",
                value: new Guid("95385568-5dbb-4fc7-af63-2ff8f419a2db"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 821,
                column: "CityGUID",
                value: new Guid("48d38316-74cf-4cea-9a29-9b37eece63c6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 822,
                column: "CityGUID",
                value: new Guid("38d7f715-6be7-49aa-bbcf-c799c890535d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 823,
                column: "CityGUID",
                value: new Guid("1e9e44f8-5774-490d-8bf8-2ebb5a0db7b5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 824,
                column: "CityGUID",
                value: new Guid("1f50663f-ed04-416d-bd5c-28b81143bbfc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 825,
                column: "CityGUID",
                value: new Guid("c26a56c4-4db1-45e7-a503-a658cbfdd558"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 826,
                column: "CityGUID",
                value: new Guid("343798c1-b3aa-4768-96b5-8669f3820d6c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 827,
                column: "CityGUID",
                value: new Guid("9eb2ee2b-2ffa-4063-8162-72c061172173"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 828,
                column: "CityGUID",
                value: new Guid("c72b11d8-2674-4342-a23a-050300113cf5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 829,
                column: "CityGUID",
                value: new Guid("f84e61b9-e870-4e59-b4a7-4434ed7783bc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 830,
                column: "CityGUID",
                value: new Guid("2d4447f8-29ed-4e9c-864c-36fb86e795bf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 831,
                column: "CityGUID",
                value: new Guid("cb926306-d9d6-4c85-9dbe-311b33d5406b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 832,
                column: "CityGUID",
                value: new Guid("a03ba768-3e5a-4d9a-af45-3d07a2c3c2bd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 833,
                column: "CityGUID",
                value: new Guid("d5eb2e02-bdb7-42b8-814f-c679d4c01c55"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 834,
                column: "CityGUID",
                value: new Guid("6a4f5e5a-0a63-4b2e-aa94-babe14c36875"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 835,
                column: "CityGUID",
                value: new Guid("df980ef7-2616-45cb-a9a8-506a04d42117"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 836,
                column: "CityGUID",
                value: new Guid("73e88d8a-d1de-4e56-82f1-b0b9d786a321"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 837,
                column: "CityGUID",
                value: new Guid("ec7737c2-85e8-46bf-93e8-478b69d8034e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 838,
                column: "CityGUID",
                value: new Guid("1e14e13c-1c8c-43c0-9b00-421b5c32f89e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 839,
                column: "CityGUID",
                value: new Guid("abc8d4e5-c820-4f39-95e9-ebef6b739c63"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 840,
                column: "CityGUID",
                value: new Guid("e27b7f90-4f2e-4b5e-88a8-c436e6805f56"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 841,
                column: "CityGUID",
                value: new Guid("45c4a4e3-e66e-45cf-8836-6c5bf6618601"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 842,
                column: "CityGUID",
                value: new Guid("0e04ae18-680e-42af-8668-ea44321d9d6e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 843,
                column: "CityGUID",
                value: new Guid("4b867372-3a9c-42cd-8a73-c4ce9618818b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 844,
                column: "CityGUID",
                value: new Guid("ea02db6b-798e-48e2-865e-b78cf717e837"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 845,
                column: "CityGUID",
                value: new Guid("42b945fe-bfb5-4698-95d8-9867053b9d63"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 846,
                column: "CityGUID",
                value: new Guid("9158b326-60e6-4ee8-94b6-41ad4de6d3be"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 847,
                column: "CityGUID",
                value: new Guid("a48e919a-1dc1-44f0-af71-9fb115fa4cbb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 848,
                column: "CityGUID",
                value: new Guid("61e60cad-0e7d-485b-b879-0ea6c5230379"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 849,
                column: "CityGUID",
                value: new Guid("1a359304-7cbb-46cc-ab00-9ebef5766418"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 850,
                column: "CityGUID",
                value: new Guid("2c30ca00-200b-4fcb-8c95-883e7ea95181"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 851,
                column: "CityGUID",
                value: new Guid("2e048063-be79-40e6-882d-7a45784da975"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 852,
                column: "CityGUID",
                value: new Guid("c7ece4ae-b33b-4899-84ea-4ecd9b03196f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 853,
                column: "CityGUID",
                value: new Guid("09b483a1-5728-4362-b742-f2a39a54eabe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 854,
                column: "CityGUID",
                value: new Guid("57823ece-c820-4745-8f33-5f40e2da3dde"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 855,
                column: "CityGUID",
                value: new Guid("bf86bba2-5e5c-497f-96b5-c498ebd06ea9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 856,
                column: "CityGUID",
                value: new Guid("174de023-2e6c-40c1-b65e-720dd43b2d97"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 857,
                column: "CityGUID",
                value: new Guid("3a67acbb-4423-4c77-9394-b3ce539c69e0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 858,
                column: "CityGUID",
                value: new Guid("5185f17c-b194-4c9b-ba16-a68f34bc5c01"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 859,
                column: "CityGUID",
                value: new Guid("99f5ad97-e7df-40a0-a8d5-946044c76b82"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 860,
                column: "CityGUID",
                value: new Guid("67d3d6c1-f086-4122-a5d5-a996913b3d16"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 861,
                column: "CityGUID",
                value: new Guid("38f5cfdb-b36f-49a6-9386-d3f3c27c4dfc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 862,
                column: "CityGUID",
                value: new Guid("0723f3df-8fe4-4093-a4c9-6d67a320ad01"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 863,
                column: "CityGUID",
                value: new Guid("eaf05985-e5b9-478f-b998-6446f9d74599"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 864,
                column: "CityGUID",
                value: new Guid("2be00c21-0186-4a76-a60b-e213c41bce28"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 865,
                column: "CityGUID",
                value: new Guid("bd910263-25ce-4f7a-a239-1c5bb1d181d2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 866,
                column: "CityGUID",
                value: new Guid("893c4540-6ca3-434c-aba3-c9308de365e7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 867,
                column: "CityGUID",
                value: new Guid("c28007fb-db87-40e1-a592-1075d79d50a4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 868,
                column: "CityGUID",
                value: new Guid("c2e3c50f-981f-43ca-aa83-a688daf68be6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 869,
                column: "CityGUID",
                value: new Guid("39ba8354-41ad-484e-ac4c-90543430e31e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 870,
                column: "CityGUID",
                value: new Guid("0cc94898-44f2-477b-8ffd-df7c4de95188"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 871,
                column: "CityGUID",
                value: new Guid("dd2cedc5-10bb-4054-ace3-52b79fda7c94"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 872,
                column: "CityGUID",
                value: new Guid("7309f884-0830-4d69-9602-aa7743f9e1a4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 873,
                column: "CityGUID",
                value: new Guid("5215eaa3-8b0f-48b5-96dd-10ae3363933c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 874,
                column: "CityGUID",
                value: new Guid("bd50bcfd-df84-4ee9-ad0b-0b1d55f708c2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 875,
                column: "CityGUID",
                value: new Guid("b3fb7218-53b9-4d33-8004-6e9bbdb2ea64"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 876,
                column: "CityGUID",
                value: new Guid("22bfd9e2-b8a8-45c1-b457-4b8d194127ff"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 877,
                column: "CityGUID",
                value: new Guid("3d59abf7-684d-4019-b09d-8d3959448b5d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 878,
                column: "CityGUID",
                value: new Guid("6d54c6c2-bacd-4dc6-bdc5-a5823c3ca146"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 879,
                column: "CityGUID",
                value: new Guid("8081a1dc-23e6-4ff8-95ce-97bfec3f5da4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 880,
                column: "CityGUID",
                value: new Guid("ee921608-ca60-4ef7-9a4b-5bef8ab50ab9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 881,
                column: "CityGUID",
                value: new Guid("dad480b4-0c0e-4be4-8a17-cb836d97eb9c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 882,
                column: "CityGUID",
                value: new Guid("ad152136-b207-4245-8e7d-d680397b3b69"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 883,
                column: "CityGUID",
                value: new Guid("5e8c378d-7e37-450d-9199-50be991a2467"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 884,
                column: "CityGUID",
                value: new Guid("a936d2a2-aa3f-4f50-a62c-8f239756b8e9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 885,
                column: "CityGUID",
                value: new Guid("1d174281-e391-4c70-8586-4f200a83b07e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 886,
                column: "CityGUID",
                value: new Guid("00bc5c55-d028-4395-8829-830eb00ebe9b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 887,
                column: "CityGUID",
                value: new Guid("8d936c69-907a-4cdd-a909-4c69bc1dabbf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 888,
                column: "CityGUID",
                value: new Guid("041bf6a6-a357-4e6e-b4cb-34e508d46de8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 889,
                column: "CityGUID",
                value: new Guid("9e3fe009-25a4-4b79-bd16-abfd4122a058"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 890,
                column: "CityGUID",
                value: new Guid("c98ee983-fdee-409b-9ee7-4e93e52ae76e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 891,
                column: "CityGUID",
                value: new Guid("35674d2d-76bd-437a-9718-7ac98deeb6f1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 892,
                column: "CityGUID",
                value: new Guid("ab811e65-876b-4ebe-8860-da0b70d9c4d0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 893,
                column: "CityGUID",
                value: new Guid("cf4e3529-8110-4369-a272-a21c4fab53e7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 894,
                column: "CityGUID",
                value: new Guid("148b1d2f-2e1a-46a3-ac21-b973a253ebbf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 895,
                column: "CityGUID",
                value: new Guid("bb95eeec-30c0-4741-8279-dbad88e528a1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 896,
                column: "CityGUID",
                value: new Guid("049be95c-df10-4e1a-9de1-d520187ff3f1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 897,
                column: "CityGUID",
                value: new Guid("91ff0814-51fe-4df6-a6cc-c62d8a11ce3c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 898,
                column: "CityGUID",
                value: new Guid("eabd8b2e-0442-45e2-9b19-28d0256fe231"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 899,
                column: "CityGUID",
                value: new Guid("c5543d11-8dbc-4e28-8aba-f0ca904a633d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 900,
                column: "CityGUID",
                value: new Guid("1313bbaf-05e2-45e3-b9c2-84946d5005e2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 901,
                column: "CityGUID",
                value: new Guid("6a66687c-4937-478f-9900-6c0d26090e9e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 902,
                column: "CityGUID",
                value: new Guid("d0882fff-0185-4cd7-8767-d81bb2456861"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 903,
                column: "CityGUID",
                value: new Guid("48c37bb6-f1de-4060-9670-e2bd092f9f2c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 904,
                column: "CityGUID",
                value: new Guid("08ad4300-03f5-4771-ba1c-bad92324a7fb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 905,
                column: "CityGUID",
                value: new Guid("44f029cf-466b-47ab-ae6d-40643ed3c7ed"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 906,
                column: "CityGUID",
                value: new Guid("426d2e37-35a5-461e-a01b-713467da3f9e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 907,
                column: "CityGUID",
                value: new Guid("6103c0c9-33b7-4d14-9742-b4749a5dc2eb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 908,
                column: "CityGUID",
                value: new Guid("884978c4-cb92-4af5-9429-d0ba67abbc15"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 909,
                column: "CityGUID",
                value: new Guid("b5a6fcf8-e1c8-4fce-96f3-ef647cc6db40"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 910,
                column: "CityGUID",
                value: new Guid("9cff5128-aa0a-4478-a546-5e8edea02454"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 911,
                column: "CityGUID",
                value: new Guid("6a141108-8a38-4183-8a4d-97f97dce96ad"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 912,
                column: "CityGUID",
                value: new Guid("f95148ec-06ea-4417-b6dd-314ac578841e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 913,
                column: "CityGUID",
                value: new Guid("87ec90d1-5874-4a27-ad8e-2a5e2e7b441d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 914,
                column: "CityGUID",
                value: new Guid("0199798d-6377-41b3-9350-9f18c7d2e0ab"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 915,
                column: "CityGUID",
                value: new Guid("d725d963-7646-4b5e-aa96-a7602271b765"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 916,
                column: "CityGUID",
                value: new Guid("97f2811b-2556-4946-9fcc-af1e35e3ec25"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 917,
                column: "CityGUID",
                value: new Guid("d0f65dce-34c9-42a9-9fc0-3f8e7d2891fd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 918,
                column: "CityGUID",
                value: new Guid("ba492ef3-526b-40e7-8729-cc08c8779f02"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 919,
                column: "CityGUID",
                value: new Guid("a78ce588-a82f-4672-8f0f-1a17fca206a7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 920,
                column: "CityGUID",
                value: new Guid("68edbce4-5310-455e-a5bb-6974ff326f5c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 921,
                column: "CityGUID",
                value: new Guid("cc4350c4-6874-4b89-82d5-f634255ac694"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 922,
                column: "CityGUID",
                value: new Guid("f6b08904-107e-43d1-a507-f83d65fd7e4b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 923,
                column: "CityGUID",
                value: new Guid("8395e7e8-bd4e-4cc8-8ff7-5ad1f8674579"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 924,
                column: "CityGUID",
                value: new Guid("5ee8a929-d340-4866-8c6c-533f829b728a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 925,
                column: "CityGUID",
                value: new Guid("4a19c609-cc02-4805-a1ac-ef22b66f7b2d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 926,
                column: "CityGUID",
                value: new Guid("ef85bd0c-4ef0-4169-822d-17918d19b616"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 927,
                column: "CityGUID",
                value: new Guid("08fb9d55-542d-4413-9607-c1381199f196"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 928,
                column: "CityGUID",
                value: new Guid("f3a8a871-0064-48ad-b11d-18ef37a69cc6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 929,
                column: "CityGUID",
                value: new Guid("f2f6f20c-0f0f-4a92-8223-676c705adca6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 930,
                column: "CityGUID",
                value: new Guid("05a2d574-670d-47d8-ac38-088796c3098a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 931,
                column: "CityGUID",
                value: new Guid("cf1e3aef-0730-4dd8-8cbb-e9663afa52d2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 932,
                column: "CityGUID",
                value: new Guid("5bede573-d653-42d7-a824-06be022af69d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 933,
                column: "CityGUID",
                value: new Guid("fbf3995d-80e7-4e3d-8666-9719d44779d5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 934,
                column: "CityGUID",
                value: new Guid("df7703a4-bd6f-4288-ad00-2cd14d9d6006"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 935,
                column: "CityGUID",
                value: new Guid("cd439732-e8d5-43e2-80d1-48d3980b89a1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 936,
                column: "CityGUID",
                value: new Guid("56a3a97f-7da7-4f59-a48f-668a9722e10f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 937,
                column: "CityGUID",
                value: new Guid("9690c76a-b48f-4bd4-b528-030cb5fa4368"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 938,
                column: "CityGUID",
                value: new Guid("a27b7230-9635-46ba-a8f6-cbf96d94ef5a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 939,
                column: "CityGUID",
                value: new Guid("5da7ddd6-c272-411e-8020-84253e1c83b5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 940,
                column: "CityGUID",
                value: new Guid("446a4199-21a3-4547-a082-0ae50f5724b8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 941,
                column: "CityGUID",
                value: new Guid("4ed3479e-200f-43f0-8828-fbaecea90ece"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 942,
                column: "CityGUID",
                value: new Guid("477db973-9842-4508-bd05-a9f8e47260f3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 943,
                column: "CityGUID",
                value: new Guid("9ef0f439-ec89-4238-80be-aeab17c1b64d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 944,
                column: "CityGUID",
                value: new Guid("83e76b68-e843-4191-adc6-df18b10b95e9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 945,
                column: "CityGUID",
                value: new Guid("4a9e8926-5cbb-43f2-a06f-2424c64ea7e7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 946,
                column: "CityGUID",
                value: new Guid("d8ed4e6e-a35a-441b-8472-f300b864e8e1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 947,
                column: "CityGUID",
                value: new Guid("61bc2c16-0489-453b-a910-43f6ade5d3ad"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 948,
                column: "CityGUID",
                value: new Guid("1cc179e0-62f7-4adb-aeff-101d2e2f72ad"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 949,
                column: "CityGUID",
                value: new Guid("e4b05c62-c950-4d87-9406-a1b1dbb6c0d7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 950,
                column: "CityGUID",
                value: new Guid("5092c84b-038f-46fa-81fc-1bc69ab9be1a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 951,
                column: "CityGUID",
                value: new Guid("2b1d7725-4343-42c9-87f2-057ec81b1e9a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 952,
                column: "CityGUID",
                value: new Guid("60415d1c-b34d-4389-87f5-a999f9c31118"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 953,
                column: "CityGUID",
                value: new Guid("3e9267c4-fd58-4010-bdd7-d213e2c0637c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 954,
                column: "CityGUID",
                value: new Guid("2fdc15d3-a786-46ff-ba5a-1ac6d70008e4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 955,
                column: "CityGUID",
                value: new Guid("70304e9e-0b02-49ef-98c1-bca698d63be1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 956,
                column: "CityGUID",
                value: new Guid("68e537e1-58bc-4f42-a65c-550279d0e9b8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 957,
                column: "CityGUID",
                value: new Guid("92505885-14ef-4215-bd5e-88ff27bba513"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 958,
                column: "CityGUID",
                value: new Guid("23815fba-9523-4853-8453-f84b1fc51168"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 959,
                column: "CityGUID",
                value: new Guid("37f9ba05-f915-45a3-a417-c6d89fa241cf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 960,
                column: "CityGUID",
                value: new Guid("6ab4645c-122e-4e89-bf00-2f5ffc766fa4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 961,
                column: "CityGUID",
                value: new Guid("bc9c2c7d-a0b5-4f8a-8a26-45ca0dc0a1b5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 962,
                column: "CityGUID",
                value: new Guid("561b093e-902a-4aec-99a7-1c59ad619fab"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 963,
                column: "CityGUID",
                value: new Guid("3206425d-39f1-40ff-9152-92312512235f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 964,
                column: "CityGUID",
                value: new Guid("b8ab4178-e8fe-4385-890f-ed921cbfbe15"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 965,
                column: "CityGUID",
                value: new Guid("7ee9ca22-9c17-40de-8018-38489e175cba"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 966,
                column: "CityGUID",
                value: new Guid("d878b161-b00d-46da-9b6c-5034cc0d9ef0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 967,
                column: "CityGUID",
                value: new Guid("d1f2ab6f-8ec7-42c7-b546-490bce4aca20"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 968,
                column: "CityGUID",
                value: new Guid("a99c9c16-d706-41ab-a5c5-7194b8ac3c13"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 969,
                column: "CityGUID",
                value: new Guid("793ec5e3-7b88-4507-85a3-dfbb13bf8405"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 970,
                column: "CityGUID",
                value: new Guid("83870e99-eddb-4996-864a-e2ad0027e325"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 971,
                column: "CityGUID",
                value: new Guid("9e6f3a67-4622-44fb-b8d7-ed3619094c24"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 972,
                column: "CityGUID",
                value: new Guid("5fe86d26-11dd-42c4-a49c-61b133f55b14"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 973,
                column: "CityGUID",
                value: new Guid("cd703c45-20eb-4884-b9d3-adce9996aa73"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 974,
                column: "CityGUID",
                value: new Guid("829870cc-df45-4c1b-9ddd-c481c5cdc78d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 975,
                column: "CityGUID",
                value: new Guid("b01d34a1-90da-480c-8b6a-1ca12d4dfdbe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 976,
                column: "CityGUID",
                value: new Guid("c606aa68-054a-4a51-8606-5bc114012a60"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 977,
                column: "CityGUID",
                value: new Guid("706320f4-110c-4e65-b3aa-4aafd813e0e0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 978,
                column: "CityGUID",
                value: new Guid("2dad8c1d-0f14-4882-a2d8-8cba64ef2b54"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 979,
                column: "CityGUID",
                value: new Guid("34459fb6-4246-48b5-8b2f-e664ed99f56a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 980,
                column: "CityGUID",
                value: new Guid("6c4508e2-6d6a-49fe-bd3d-e3371404c3be"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 981,
                column: "CityGUID",
                value: new Guid("804a44b2-2aeb-4505-b1ee-0cfce3bd7b98"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 982,
                column: "CityGUID",
                value: new Guid("1b8a1902-d2e0-4531-93f2-ca1b9c2a0216"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 983,
                column: "CityGUID",
                value: new Guid("b8e152d7-0173-4fa2-810b-cee4a41738b2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 984,
                column: "CityGUID",
                value: new Guid("663f95f5-ea85-4b8c-8316-044a3c31b2b0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 985,
                column: "CityGUID",
                value: new Guid("d32bdd86-766a-424a-9279-f22883a03b4c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 986,
                column: "CityGUID",
                value: new Guid("6fa88514-1487-4731-88c2-35cd825fe464"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 987,
                column: "CityGUID",
                value: new Guid("1baab39c-d49e-4d0d-896c-847092e3a04f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 988,
                column: "CityGUID",
                value: new Guid("da86ecad-00fc-4687-8866-784c337b9353"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 989,
                column: "CityGUID",
                value: new Guid("29d66f5b-9e04-4b59-850b-cc7b545881c1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 990,
                column: "CityGUID",
                value: new Guid("a037437d-1311-41a0-a0a7-fab220ea836e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 991,
                column: "CityGUID",
                value: new Guid("a35aadb7-602a-4dbb-aeff-ab4c392d092d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 992,
                column: "CityGUID",
                value: new Guid("d49ff199-7f70-4ace-b44d-8fce69577576"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 993,
                column: "CityGUID",
                value: new Guid("a408f1d6-2dc8-417d-a862-506cb66d71b9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 994,
                column: "CityGUID",
                value: new Guid("f72abd39-c90d-49ba-80d8-b0c015e451dd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 995,
                column: "CityGUID",
                value: new Guid("14243b51-5ca2-44f5-bb04-f6cec9ee431f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 996,
                column: "CityGUID",
                value: new Guid("546646e4-1e5a-4497-b421-172a35068409"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 997,
                column: "CityGUID",
                value: new Guid("9b987373-e6f7-4fef-a23b-e0d701ba130d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 998,
                column: "CityGUID",
                value: new Guid("f7f7ebed-0271-4ac6-8bae-9a16221f68a0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 999,
                column: "CityGUID",
                value: new Guid("f334cbae-de5e-4d6d-8d0c-fdf44c81116d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1000,
                column: "CityGUID",
                value: new Guid("c1f15002-3c1f-45a5-a8c0-c896b28ff9c4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1001,
                column: "CityGUID",
                value: new Guid("51885cea-f8b8-4fd7-a8a7-0ed2ccb9b22b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1002,
                column: "CityGUID",
                value: new Guid("7ade8064-e2b5-4b37-b7ee-f69c46aece14"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1003,
                column: "CityGUID",
                value: new Guid("f8466169-0e2f-4c33-b687-a1d5669acef3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1004,
                column: "CityGUID",
                value: new Guid("4950533d-4145-4150-830e-4e358c049978"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1005,
                column: "CityGUID",
                value: new Guid("04da504b-45c2-462f-b55a-6bf58bdcaefb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1006,
                column: "CityGUID",
                value: new Guid("9baf1c1e-1961-41fe-a5cc-74d3cb24abe2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1007,
                column: "CityGUID",
                value: new Guid("be13e6f3-86ee-49a3-b190-34c21836267d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1008,
                column: "CityGUID",
                value: new Guid("278ab022-80fe-45bb-bb6a-94dbe2450ca9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1009,
                column: "CityGUID",
                value: new Guid("85bc9dbc-5888-4517-ae05-7a27999e8de4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1010,
                column: "CityGUID",
                value: new Guid("5c8ea3f1-b8eb-470e-a533-c2c228c4ebcf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1011,
                column: "CityGUID",
                value: new Guid("6d90737b-9e9e-43dc-8e21-a301cbdbf312"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1012,
                column: "CityGUID",
                value: new Guid("529c52a8-7e2d-46dd-86eb-7c1694e40257"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1013,
                column: "CityGUID",
                value: new Guid("4f2965f2-0028-4077-b30c-3c8daedee806"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1014,
                column: "CityGUID",
                value: new Guid("d374885b-4711-42c4-ae2c-ada444e31fc2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1015,
                column: "CityGUID",
                value: new Guid("021cc6d2-2128-46ce-9605-50adc4c06249"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1016,
                column: "CityGUID",
                value: new Guid("783e23e7-5ee9-44f5-815a-fd9520cf3024"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1017,
                column: "CityGUID",
                value: new Guid("86394bc5-75e2-4011-93a2-1e7e7d2c2d75"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1018,
                column: "CityGUID",
                value: new Guid("0be15695-4f89-4297-baea-9159620e8aa9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1019,
                column: "CityGUID",
                value: new Guid("a024881a-bc3a-4a2b-a2ac-809b53479d0d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1020,
                column: "CityGUID",
                value: new Guid("6b2390c2-b349-4b34-a731-c81263805ca4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1021,
                column: "CityGUID",
                value: new Guid("dde2ed6f-f76c-4e2d-96e0-6d4d39e97d22"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1022,
                column: "CityGUID",
                value: new Guid("1edd72e3-78a2-455f-8722-81e66b89be0b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1023,
                column: "CityGUID",
                value: new Guid("5ba3a508-3457-4ce2-898e-4f15d38ffe6c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1024,
                column: "CityGUID",
                value: new Guid("6f202ce6-cb32-458e-b8a3-847e1a87fcc7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1025,
                column: "CityGUID",
                value: new Guid("8d6c7dda-2da4-4275-a952-fdfeeac7c5d3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1026,
                column: "CityGUID",
                value: new Guid("38cbf24d-2c6b-4153-9b37-b8a4897cb09a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1027,
                column: "CityGUID",
                value: new Guid("7f8be5a4-ea49-4a24-91ab-810b39f64d38"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1028,
                column: "CityGUID",
                value: new Guid("af7b742c-ae76-45c8-960f-45d488770386"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1029,
                column: "CityGUID",
                value: new Guid("c4f49e40-d833-4281-bdb8-8ba0c5622372"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1030,
                column: "CityGUID",
                value: new Guid("7a85be18-a047-4ebe-ba06-eea365848ce6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1031,
                column: "CityGUID",
                value: new Guid("64a9a3f3-184f-4ee2-b72c-cbd0d258291c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1032,
                column: "CityGUID",
                value: new Guid("72ee4a18-a9ee-4285-b3d1-99f639889533"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1033,
                column: "CityGUID",
                value: new Guid("bcf609ad-7d0b-48f5-aa28-a2e2a7bde87e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1034,
                column: "CityGUID",
                value: new Guid("a83d19bd-3b5b-4346-bbde-83692fd6ff1f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1035,
                column: "CityGUID",
                value: new Guid("75251b81-5875-41f6-9350-35e7eed82e8c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1036,
                column: "CityGUID",
                value: new Guid("d5449bd2-7edc-404e-aee2-b0f93809db35"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1037,
                column: "CityGUID",
                value: new Guid("93ea4724-4aa2-44d3-8ac7-7d24e126f5b4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1038,
                column: "CityGUID",
                value: new Guid("60279414-68a7-4962-a11e-db4b1d6d7e39"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1039,
                column: "CityGUID",
                value: new Guid("08c6dd16-33b3-44ba-855c-741867c1c888"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1040,
                column: "CityGUID",
                value: new Guid("44e2524c-fa70-469d-abd2-92a92b92250d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1041,
                column: "CityGUID",
                value: new Guid("a6051661-2276-4233-abe7-cf9f9fc9a7e2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1042,
                column: "CityGUID",
                value: new Guid("66ab0f44-dfa0-4d39-a077-340b5414ffbd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1043,
                column: "CityGUID",
                value: new Guid("026ea70e-7766-4589-8841-c0965ade68e6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1044,
                column: "CityGUID",
                value: new Guid("ce798908-58ae-45a5-8e1c-1ba13bd0cf5a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1045,
                column: "CityGUID",
                value: new Guid("3526eb22-bd67-4294-8d31-01c83ff5da5c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1046,
                column: "CityGUID",
                value: new Guid("dec299ad-33d1-4f1f-a62a-1b9b30275ac5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1047,
                column: "CityGUID",
                value: new Guid("23930bcb-8a5a-4bd5-959d-89f22fa9abec"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1048,
                column: "CityGUID",
                value: new Guid("6d106ec7-7c91-41c9-86a4-e7a721c9ae91"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1049,
                column: "CityGUID",
                value: new Guid("d9b3ad63-caab-431f-9999-49673ae77cad"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1050,
                column: "CityGUID",
                value: new Guid("ca39a169-9e88-4b6e-8929-4742008f9c3f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1051,
                column: "CityGUID",
                value: new Guid("41659e52-0b19-438e-b0b3-e856d9e4e455"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1052,
                column: "CityGUID",
                value: new Guid("17539a94-562d-494a-8c5d-c97625077095"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1053,
                column: "CityGUID",
                value: new Guid("39317f60-f3e4-4a57-bebf-8827958ea12d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1054,
                column: "CityGUID",
                value: new Guid("a91eb89f-5821-4a36-a843-2359d30e7e61"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1055,
                column: "CityGUID",
                value: new Guid("03d9564e-86cf-4ad4-b8ad-ad81c8950f22"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1056,
                column: "CityGUID",
                value: new Guid("70fd5c8a-89a7-497c-b374-cf4830548284"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1057,
                column: "CityGUID",
                value: new Guid("07fb5033-6c4e-41d8-bc9d-9fa5dca7dc51"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1058,
                column: "CityGUID",
                value: new Guid("b66c1d9d-6b86-4bf7-b675-f788eefd87bf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1059,
                column: "CityGUID",
                value: new Guid("da2f73ef-9a9b-4c8e-92f7-f543004fbb59"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1060,
                column: "CityGUID",
                value: new Guid("c977c0a5-9c7f-4bce-a292-697cd2be1ff2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1061,
                column: "CityGUID",
                value: new Guid("c992438d-d223-4be3-990c-8d6d8d21c2b6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1062,
                column: "CityGUID",
                value: new Guid("7662c9b9-8df5-4c22-a87d-2f9a91914eae"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1063,
                column: "CityGUID",
                value: new Guid("00a71743-77d5-4ea0-aa82-1af1c61a9b18"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1064,
                column: "CityGUID",
                value: new Guid("01ba4d23-6bcd-4829-b229-36d2aff4b845"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1065,
                column: "CityGUID",
                value: new Guid("0e72e0cd-7940-4f69-a2e5-54e05a798fdf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1066,
                column: "CityGUID",
                value: new Guid("0107960f-843c-4352-92e1-fa1790ee85e5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1067,
                column: "CityGUID",
                value: new Guid("af7a2841-1981-411a-b844-8a5a75c4b865"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1068,
                column: "CityGUID",
                value: new Guid("089fe70b-98d6-4c16-8ff3-4b255351c8e6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1069,
                column: "CityGUID",
                value: new Guid("ece8f9a2-9d0d-4b02-8d86-96e0d8796da4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1070,
                column: "CityGUID",
                value: new Guid("1715714b-15a8-4c54-b895-50dfb191123b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1071,
                column: "CityGUID",
                value: new Guid("5b46f983-c48f-4e1c-9c36-9f95d52ee9b1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1072,
                column: "CityGUID",
                value: new Guid("52f7bc68-a360-4327-8543-72a491d8b8ee"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1073,
                column: "CityGUID",
                value: new Guid("627018ce-7a68-47fd-8c60-bf4afc13ce48"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1074,
                column: "CityGUID",
                value: new Guid("1daa2d83-92c6-48c4-9e2e-7ba3236f0329"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1075,
                column: "CityGUID",
                value: new Guid("9dcc34c4-bfe4-45fc-9d83-ee46a2d86b63"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1076,
                column: "CityGUID",
                value: new Guid("803e39f4-4172-4cce-91eb-b15b50483a5b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1077,
                column: "CityGUID",
                value: new Guid("4f6334ad-9643-4893-9365-46d6379b13b4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1078,
                column: "CityGUID",
                value: new Guid("1b87faa7-8a67-4a54-b3f7-0eb0ecea8f7f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1079,
                column: "CityGUID",
                value: new Guid("bf3dd0a1-80b2-4d70-8d27-fc1471093ac2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1080,
                column: "CityGUID",
                value: new Guid("86a498f5-fab6-4138-8a26-dd45e9a24f06"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1081,
                column: "CityGUID",
                value: new Guid("8c0d0a13-798d-4305-b917-f142714b0ecd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1082,
                column: "CityGUID",
                value: new Guid("80ba45d1-5064-42f6-940a-133fa29a2aee"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1083,
                column: "CityGUID",
                value: new Guid("02d21c51-163e-40be-9feb-aba3f21071d9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1084,
                column: "CityGUID",
                value: new Guid("d3891d99-8431-4492-8278-d56d1bfd2151"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1085,
                column: "CityGUID",
                value: new Guid("f43fbede-1d69-47be-81ee-9452b8dc0564"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1086,
                column: "CityGUID",
                value: new Guid("26cbc253-3ac4-4573-a380-a7da1595a1df"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1087,
                column: "CityGUID",
                value: new Guid("60ac8050-0445-4e8b-a85c-c2905a8acc24"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1088,
                column: "CityGUID",
                value: new Guid("4eb3eb22-37fe-4891-8a2c-16d6b71f2aca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1089,
                column: "CityGUID",
                value: new Guid("18962054-2aab-46e8-9597-a4c0e9782d37"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1090,
                column: "CityGUID",
                value: new Guid("84a06216-684e-4856-85ac-2ff6312716b5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1091,
                column: "CityGUID",
                value: new Guid("dd4e1645-2d75-426a-8178-171871a219da"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1092,
                column: "CityGUID",
                value: new Guid("acc5790f-3dc3-4e89-9a9d-fd9ea34f0c8d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1093,
                column: "CityGUID",
                value: new Guid("da9806db-e360-4a44-ad90-678d3928f7ad"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1094,
                column: "CityGUID",
                value: new Guid("fe2de318-7ef7-41cf-85ee-474edd970b6d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1095,
                column: "CityGUID",
                value: new Guid("7d0adb9f-0df0-464d-ab85-acbda2b93cbf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1096,
                column: "CityGUID",
                value: new Guid("b26b00af-6a32-4a90-8225-bd3f562257f6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1097,
                column: "CityGUID",
                value: new Guid("638bb611-f70c-4fc2-ad16-5763adc34fa6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1098,
                column: "CityGUID",
                value: new Guid("1d270bce-affa-4fcc-b0ce-ab4b49e6f5f3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1099,
                column: "CityGUID",
                value: new Guid("138f2fd5-a6e1-4418-8eab-ab3c40217d74"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1100,
                column: "CityGUID",
                value: new Guid("536afefb-baae-4cf4-bdcb-b030c9d2b3ac"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1101,
                column: "CityGUID",
                value: new Guid("f8da348d-2490-449e-9504-0289f822a200"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1102,
                column: "CityGUID",
                value: new Guid("a6386a16-40bb-4c6f-97d7-6df092d91291"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1103,
                column: "CityGUID",
                value: new Guid("867a1ad4-3f04-495a-8e87-85336bc83628"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1104,
                column: "CityGUID",
                value: new Guid("80bd1434-6018-4eaf-9a30-857330597e4a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1105,
                column: "CityGUID",
                value: new Guid("0e122f7e-8983-46a7-829f-422f9f5d2e4f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1106,
                column: "CityGUID",
                value: new Guid("f3efc977-c44c-42ce-8add-1ff9b3333edb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1107,
                column: "CityGUID",
                value: new Guid("b57398d6-492e-47fc-82d7-d67ae476f4ca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1108,
                column: "CityGUID",
                value: new Guid("fb4e7b4b-9884-440f-a063-b4e43c5423d2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1109,
                column: "CityGUID",
                value: new Guid("4928350b-990a-4436-8a81-0d3523ebe529"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1110,
                column: "CityGUID",
                value: new Guid("b923db38-20d8-48e4-9044-f2426e45087e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1111,
                column: "CityGUID",
                value: new Guid("ae5d4dd3-0ba8-4899-999f-d6bb3147e4e5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1112,
                column: "CityGUID",
                value: new Guid("7d844106-b62a-408b-b692-a40ac07d3580"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1113,
                column: "CityGUID",
                value: new Guid("df5ef7d3-5b63-4c65-ac41-92a6a498e4c5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1114,
                column: "CityGUID",
                value: new Guid("54601d73-5ec1-4a99-b378-93fe8e412d1a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1115,
                column: "CityGUID",
                value: new Guid("6bf96ced-7d69-4860-8827-21dfeb660f6a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1116,
                column: "CityGUID",
                value: new Guid("1ebac366-5378-49a9-9564-98889f44a48b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1117,
                column: "CityGUID",
                value: new Guid("9cf7744b-6b7b-45a8-b4d4-7b2b81b472e8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1118,
                column: "CityGUID",
                value: new Guid("360bdc4d-4dc2-47ad-8f36-d5d8e2e32051"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1119,
                column: "CityGUID",
                value: new Guid("2af83a57-26a2-4e13-931a-d4bfc9990ef8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1120,
                column: "CityGUID",
                value: new Guid("d6a6fadd-c8f8-46e6-978b-a883fcf16fb6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1121,
                column: "CityGUID",
                value: new Guid("3d5f07e5-606f-4314-bf96-5b64c326d79a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1122,
                column: "CityGUID",
                value: new Guid("36e689c0-b47d-4dab-a3c3-73332ab2564b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1123,
                column: "CityGUID",
                value: new Guid("9817529e-b714-49b9-ab02-3dab8956b5e2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1124,
                column: "CityGUID",
                value: new Guid("aa8f9baf-bb4b-4391-9358-a954d39b67e8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1125,
                column: "CityGUID",
                value: new Guid("0821323a-02fb-44f3-ac54-e6949b926862"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1126,
                column: "CityGUID",
                value: new Guid("ce204e1d-8e47-4aef-8d83-4b9df2f6687e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1127,
                column: "CityGUID",
                value: new Guid("a381d5eb-ba7d-414a-87ab-17d88856011a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1128,
                column: "CityGUID",
                value: new Guid("e7896c08-0ca5-413f-8a3e-bff89ef2eea9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1129,
                column: "CityGUID",
                value: new Guid("ace87a76-9ad1-4141-8d38-5bb3062ac602"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1130,
                column: "CityGUID",
                value: new Guid("953718b1-062b-4cc3-9236-2b5b53d3839d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1131,
                column: "CityGUID",
                value: new Guid("cf830d87-7079-4576-9623-a68187c54f13"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1132,
                column: "CityGUID",
                value: new Guid("da66dda4-895e-4813-86c4-bfb7443c80f3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1133,
                column: "CityGUID",
                value: new Guid("97944f0c-12df-4bd4-9452-54ca3716a7d5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1134,
                column: "CityGUID",
                value: new Guid("fb1648ae-5f7a-43cc-a774-acb6a088551c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1135,
                column: "CityGUID",
                value: new Guid("de401282-c52b-40fe-9cf9-cacdb1a9f81b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1136,
                column: "CityGUID",
                value: new Guid("69c9a291-9c71-4671-bcca-201d47517968"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1137,
                column: "CityGUID",
                value: new Guid("069652d2-5949-4516-9ff9-4c4324c58f1d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1138,
                column: "CityGUID",
                value: new Guid("73d6fd25-6d7b-4f98-be25-5d24e62e31ef"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1139,
                column: "CityGUID",
                value: new Guid("614e6be0-5985-4348-bf50-cb7d36667b4c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1140,
                column: "CityGUID",
                value: new Guid("5a3d76ef-ce35-4c59-9ffd-11fc736d56dc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1141,
                column: "CityGUID",
                value: new Guid("ac5d01be-850c-4c3a-aed8-902bf7f71e83"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1142,
                column: "CityGUID",
                value: new Guid("d0a0596d-d16d-4de7-8aab-5930ca81c0aa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1143,
                column: "CityGUID",
                value: new Guid("23d6f3ed-dbea-429a-9b49-097be357f2d3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1144,
                column: "CityGUID",
                value: new Guid("19bf04b4-ab68-48d6-8835-a8af3040fd5e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1145,
                column: "CityGUID",
                value: new Guid("8a0f2d8c-7a77-4062-b8e1-9bd94d3fab70"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1146,
                column: "CityGUID",
                value: new Guid("8ecefa7d-0fd5-44c6-9e3b-fdf5252ec9c0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1147,
                column: "CityGUID",
                value: new Guid("373487e5-e63a-47ab-afd6-fdc94cb5d228"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1148,
                column: "CityGUID",
                value: new Guid("507d8828-63e0-46ac-8217-a1fa66036aec"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1149,
                column: "CityGUID",
                value: new Guid("57ff1083-916b-412d-b6e9-52817afe39de"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1150,
                column: "CityGUID",
                value: new Guid("63d2d292-4026-407f-95ea-a8baef6a7bb5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1151,
                column: "CityGUID",
                value: new Guid("a3c146e6-1eb2-442d-a907-8c822e0e7cda"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1152,
                column: "CityGUID",
                value: new Guid("9cbe3944-7923-4642-a079-f403f836d076"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1153,
                column: "CityGUID",
                value: new Guid("d1950f16-e1cc-4db6-8f4a-e9658a44ac5d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1154,
                column: "CityGUID",
                value: new Guid("2d96ae14-2442-48c6-9f08-4e48c10ab9ed"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1155,
                column: "CityGUID",
                value: new Guid("b548e338-b622-45ce-8cd5-cfaf3233f338"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1156,
                column: "CityGUID",
                value: new Guid("bf8d6c72-e057-4de0-bca3-1eb541eef7eb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1157,
                column: "CityGUID",
                value: new Guid("d9a5f80e-bb02-4aeb-b033-cd4311c7e24f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1158,
                column: "CityGUID",
                value: new Guid("c64c4456-468a-4629-a631-216c139ef078"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1159,
                column: "CityGUID",
                value: new Guid("51a6c709-2d65-44fc-9191-120c451b4fdd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1160,
                column: "CityGUID",
                value: new Guid("5b3cebb5-4674-422c-a487-5d156ee868b9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1161,
                column: "CityGUID",
                value: new Guid("bbefc8fb-e20b-4d90-b1c4-03a8641664f8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1162,
                column: "CityGUID",
                value: new Guid("95a38c37-7ba1-4020-b682-ff36cd0f01d1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1163,
                column: "CityGUID",
                value: new Guid("d751afe9-3db4-4107-92f0-8901a5f5220b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1164,
                column: "CityGUID",
                value: new Guid("e9b31f29-6513-4585-8527-a9d200b7eaeb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1165,
                column: "CityGUID",
                value: new Guid("1686fe89-a377-45dd-a174-e1921f4a8cd3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1166,
                column: "CityGUID",
                value: new Guid("c9590a61-f6e3-4ebd-8726-6d35fa81f68c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1167,
                column: "CityGUID",
                value: new Guid("7c05d59c-b1b2-48cc-9192-5c256ab4ef40"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1168,
                column: "CityGUID",
                value: new Guid("ab84f6ef-6776-4340-8c00-790225df866e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1169,
                column: "CityGUID",
                value: new Guid("8a065294-384a-49ac-9bd6-96ece5ce0b11"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1170,
                column: "CityGUID",
                value: new Guid("7456c33a-c1b5-46b9-8eaa-006a8ce0c74c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1171,
                column: "CityGUID",
                value: new Guid("39f4c7ca-1ef5-49bd-81d2-8574e934fdd4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1172,
                column: "CityGUID",
                value: new Guid("6d1b883b-0a21-427b-aa3a-4596713372ec"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1173,
                column: "CityGUID",
                value: new Guid("b7b1072e-83e1-45a0-bc4a-dc3f2974bfa9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1174,
                column: "CityGUID",
                value: new Guid("2df6abba-6c2b-45ba-be20-9bcacd7f6c3b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1175,
                column: "CityGUID",
                value: new Guid("1a39e7db-4f76-4f11-b70c-031490fbfa70"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1176,
                column: "CityGUID",
                value: new Guid("60325595-2b3d-427c-931d-39c4b7a53653"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1177,
                column: "CityGUID",
                value: new Guid("e0c69471-6577-4c48-9502-cc8a9cf85d36"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1178,
                column: "CityGUID",
                value: new Guid("8fcd99bd-ab62-4410-a516-20f5362555cd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1179,
                column: "CityGUID",
                value: new Guid("d196f294-8d79-4e52-9dc3-08f5f5d38e2d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1180,
                column: "CityGUID",
                value: new Guid("fe470f25-1c44-4520-8e86-2febe3c1c0c4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1181,
                column: "CityGUID",
                value: new Guid("edd2d92a-aa59-43fa-8890-bf2161f7e9b3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1182,
                column: "CityGUID",
                value: new Guid("12d3c8b3-6706-4271-891a-e82ef5416a04"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1183,
                column: "CityGUID",
                value: new Guid("f085fba8-13f2-4cbc-b8c6-c693ad3bf629"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1184,
                column: "CityGUID",
                value: new Guid("dc81751a-6c76-4c5a-a9ff-94aa2167d4e1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1185,
                column: "CityGUID",
                value: new Guid("2b12f95f-ce8d-43cb-87e7-36f9af968382"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1186,
                column: "CityGUID",
                value: new Guid("c8a8d934-8d93-4392-a21b-732ed5903724"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1187,
                column: "CityGUID",
                value: new Guid("2a717caf-cdff-4e73-953d-508ae4e544a4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1188,
                column: "CityGUID",
                value: new Guid("b9e9e7ae-af9f-4b44-bab1-1b32edcc69aa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1189,
                column: "CityGUID",
                value: new Guid("25865038-20c8-4943-a3f0-406f378833be"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1190,
                column: "CityGUID",
                value: new Guid("fc60b26f-9ebf-4e06-a3d8-b2798c37d157"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1191,
                column: "CityGUID",
                value: new Guid("895be8ca-7535-4c54-8c47-d8e38f3fa9f4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1192,
                column: "CityGUID",
                value: new Guid("9be4abc9-7e5f-446a-b1c7-955835a4b4a3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1193,
                column: "CityGUID",
                value: new Guid("139cd18a-1d4b-41c8-8909-c060b74e657e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1194,
                column: "CityGUID",
                value: new Guid("1bd3bc8a-9e4a-490f-b2a6-05f1efe11416"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1195,
                column: "CityGUID",
                value: new Guid("e93b3557-1962-4b5d-8dd8-4d46f1c7544a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1196,
                column: "CityGUID",
                value: new Guid("3900f655-af9a-4955-a31f-834e7a0df9a1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1197,
                column: "CityGUID",
                value: new Guid("ad319dcd-ff03-4a62-81f6-184ed725805c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1198,
                column: "CityGUID",
                value: new Guid("21e4dd3c-2582-42e9-a74a-3701ce1fce28"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1199,
                column: "CityGUID",
                value: new Guid("6ebd7874-23fe-4ead-b496-8f6326cc4e0f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1200,
                column: "CityGUID",
                value: new Guid("23970635-5b05-4cd4-963c-ca6915ebd566"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1201,
                column: "CityGUID",
                value: new Guid("0740343c-c543-47d1-b8ff-b47cd564009c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1202,
                column: "CityGUID",
                value: new Guid("40928f53-f026-40fa-9295-e3bd8cd65777"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1203,
                column: "CityGUID",
                value: new Guid("8ad73508-9ea9-43da-8248-41e5ac82769f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1204,
                column: "CityGUID",
                value: new Guid("7223121d-f3b6-4e2e-ab73-b5411fb5ffa0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1205,
                column: "CityGUID",
                value: new Guid("ced1d2cd-2bb2-4d9a-a553-fd072357651b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1206,
                column: "CityGUID",
                value: new Guid("c4b73751-c984-4a34-a8ed-63d74c98e958"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1207,
                column: "CityGUID",
                value: new Guid("97c8c115-70d0-418b-949b-f5e095014d3c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1208,
                column: "CityGUID",
                value: new Guid("b3edf3a1-7dc5-47fc-a1f9-9ed418e8b9f2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1209,
                column: "CityGUID",
                value: new Guid("1e382b05-9ab9-4216-b201-fdb4dbf6e0f2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1210,
                column: "CityGUID",
                value: new Guid("1566d91f-22d3-4d95-a377-c48ff4251eb7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1211,
                column: "CityGUID",
                value: new Guid("9f0a5ad4-dfaa-44f7-8b94-fb259e2fff04"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1212,
                column: "CityGUID",
                value: new Guid("f91e1820-00b0-4d19-93c7-786a823ed525"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1213,
                column: "CityGUID",
                value: new Guid("6d20f283-977d-48ce-a675-63602a9422b5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1214,
                column: "CityGUID",
                value: new Guid("fcb4b2db-8410-46ae-af12-2cd689a121e4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1215,
                column: "CityGUID",
                value: new Guid("2b7c5ec4-5d97-40d4-bf7b-3c86966ce3c4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1216,
                column: "CityGUID",
                value: new Guid("60aa3bd0-47da-4bec-b0a9-c5fa758249be"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1217,
                column: "CityGUID",
                value: new Guid("eca355fb-bc3b-44fb-a7ea-56f346ab0de7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1218,
                column: "CityGUID",
                value: new Guid("fb461f34-5d0f-4e71-80d3-e24457dfc131"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1219,
                column: "CityGUID",
                value: new Guid("54e67897-bf70-4182-b2a4-23b486073006"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1220,
                column: "CityGUID",
                value: new Guid("7c786378-71b5-4f59-8625-2c14a53ccfa1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1221,
                column: "CityGUID",
                value: new Guid("aee29965-7e61-40d6-9252-d0267d29a48d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1222,
                column: "CityGUID",
                value: new Guid("3dea9526-330a-41ef-9bdc-3842faa8635a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1223,
                column: "CityGUID",
                value: new Guid("80228196-e178-4c3e-bce2-e542b81d2f77"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1224,
                column: "CityGUID",
                value: new Guid("1383267d-dfa2-4c4d-a915-f66c3be839da"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1225,
                column: "CityGUID",
                value: new Guid("03273975-8034-4ee9-890e-1620f9c75200"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1226,
                column: "CityGUID",
                value: new Guid("4baf65e5-1bf4-4eed-9381-cbebd955e9a5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1227,
                column: "CityGUID",
                value: new Guid("ef2f8827-1c5a-46e2-a1e0-d709c42e6145"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1228,
                column: "CityGUID",
                value: new Guid("8be0d644-2622-4191-a93d-4174e2c47c2a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1229,
                column: "CityGUID",
                value: new Guid("3673f239-f575-4d12-b367-5d056092f374"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1230,
                column: "CityGUID",
                value: new Guid("3114cb5b-e52d-4455-87ad-9f4ef2d9a612"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1231,
                column: "CityGUID",
                value: new Guid("c870fce2-0747-4277-89b2-2d34dd1a18c3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1232,
                column: "CityGUID",
                value: new Guid("9aee5465-92a3-438a-831a-ced74a2750d6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1233,
                column: "CityGUID",
                value: new Guid("b0f964c3-630d-4e70-8836-93a077769e4d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1234,
                column: "CityGUID",
                value: new Guid("65d447b1-0d6b-4bda-8368-4ede7eac5223"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1235,
                column: "CityGUID",
                value: new Guid("a8254660-1a5a-4223-aa93-b8a04484da27"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1236,
                column: "CityGUID",
                value: new Guid("3a557afc-c8f4-4c16-bc82-00b4a0d153b5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1237,
                column: "CityGUID",
                value: new Guid("92b74fb7-1575-4e58-89db-054b772b041b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1238,
                column: "CityGUID",
                value: new Guid("d27fe5bf-9aa0-4edd-a5c8-562f5364c644"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1239,
                column: "CityGUID",
                value: new Guid("959ccbfc-73e8-4810-af1c-3c2418ee2cd4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1240,
                column: "CityGUID",
                value: new Guid("f5ada876-e480-4a17-b4c3-5de9201f4a78"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1241,
                column: "CityGUID",
                value: new Guid("f6416139-0142-4f18-9988-3909dfc5fd89"));

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientID",
                keyValue: 1,
                columns: new[] { "ClientGUID", "ModifiedDate" },
                values: new object[] { new Guid("87a70e70-e7ee-4778-82da-43fc0fab184b"), new DateTime(2020, 7, 1, 4, 1, 43, 348, DateTimeKind.Local).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 1,
                column: "CodeGUID",
                value: new Guid("fc20e91f-1eb1-4912-87be-1708f2706367"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 2,
                column: "CodeGUID",
                value: new Guid("3f009296-db7a-4fde-a659-4ca1541a2504"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 3,
                column: "CodeGUID",
                value: new Guid("3209341a-07d4-437b-9301-2d0f909ad713"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 4,
                column: "CodeGUID",
                value: new Guid("09cb21ac-d99e-42ba-904d-337bdd561e6e"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 5,
                column: "CodeGUID",
                value: new Guid("2383b70e-f41f-4b67-b0c9-c48706a70a46"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 6,
                column: "CodeGUID",
                value: new Guid("cf5a1929-db68-43d6-8fc7-e3b7ccc51678"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 7,
                column: "CodeGUID",
                value: new Guid("2b451e4c-c9b8-415a-bcb4-05da15447b89"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 8,
                column: "CodeGUID",
                value: new Guid("6e48b657-2c83-4481-a9c5-009ffe10158b"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 9,
                column: "CodeGUID",
                value: new Guid("b5d74bda-849b-427c-a6e0-463c1e5f615b"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 10,
                column: "CodeGUID",
                value: new Guid("10afdac9-a075-40e1-9207-1813befcf4d6"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 11,
                column: "CodeGUID",
                value: new Guid("2b9d07c8-5535-495e-8557-da32acb58600"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 12,
                column: "CodeGUID",
                value: new Guid("61960336-e912-4658-9ab3-59f4c58e0b23"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 13,
                column: "CodeGUID",
                value: new Guid("46a09d81-c57f-4655-a8f5-027c66a6cfb1"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 14,
                column: "CodeGUID",
                value: new Guid("91b3cdab-39c1-40fb-b077-a2d6e611f50a"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 15,
                column: "CodeGUID",
                value: new Guid("959b10a3-b8ed-4a9d-bdf3-17ec9b2ceb15"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 16,
                column: "CodeGUID",
                value: new Guid("a05c4f54-5999-42b9-a36f-6a04aa7cd476"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 17,
                column: "CodeGUID",
                value: new Guid("ccef9d1f-343b-442a-a041-1908e4cbc235"));

            migrationBuilder.UpdateData(
                table: "CodeGroup",
                keyColumn: "CodeGroupID",
                keyValue: 1,
                column: "CodeGroupGUID",
                value: new Guid("5b739a57-164e-4b39-8b1c-1129bc9d8991"));

            migrationBuilder.UpdateData(
                table: "CodeGroup",
                keyColumn: "CodeGroupID",
                keyValue: 2,
                column: "CodeGroupGUID",
                value: new Guid("2d9c9e83-39eb-42d7-b71f-ef26002c8470"));

            migrationBuilder.UpdateData(
                table: "CodeGroup",
                keyColumn: "CodeGroupID",
                keyValue: 3,
                column: "CodeGroupGUID",
                value: new Guid("a76da3ba-d12a-42c4-b7e1-732d0990af70"));

            migrationBuilder.UpdateData(
                table: "CodeGroup",
                keyColumn: "CodeGroupID",
                keyValue: 4,
                column: "CodeGroupGUID",
                value: new Guid("39c56245-8e42-4cef-8ddd-5e4c17782e8b"));

            migrationBuilder.UpdateData(
                table: "CodeGroup",
                keyColumn: "CodeGroupID",
                keyValue: 5,
                column: "CodeGroupGUID",
                value: new Guid("7e9db57a-0c09-47ff-98b5-f49363beff67"));

            migrationBuilder.UpdateData(
                table: "CodeGroup",
                keyColumn: "CodeGroupID",
                keyValue: 6,
                column: "CodeGroupGUID",
                value: new Guid("107a7244-6e66-4369-8ba6-dfb0636642c4"));

            migrationBuilder.UpdateData(
                table: "Contractor",
                keyColumn: "ContractorID",
                keyValue: 1,
                columns: new[] { "ContractorGUID", "ModifiedDate" },
                values: new object[] { new Guid("81c724dc-72be-4889-8f88-f5a692f48d20"), new DateTime(2020, 7, 1, 4, 1, 43, 350, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "Contractor",
                keyColumn: "ContractorID",
                keyValue: 2,
                columns: new[] { "ContractorGUID", "ModifiedDate" },
                values: new object[] { new Guid("90d1abf8-f680-40d4-b1a5-b6184f639f02"), new DateTime(2020, 7, 1, 4, 1, 43, 350, DateTimeKind.Local).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 1,
                column: "ContractorCategoryGUID",
                value: new Guid("784ce03b-5df0-4ef7-b6a0-4e7403ff89c0"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 2,
                column: "ContractorCategoryGUID",
                value: new Guid("578d47a5-50d8-436c-a88b-1177dee8befd"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 3,
                column: "ContractorCategoryGUID",
                value: new Guid("7f3dcfc7-e499-45cb-8327-80665b5eeb8b"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 4,
                column: "ContractorCategoryGUID",
                value: new Guid("b9b73534-b7eb-4557-aad0-72719de48594"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 5,
                column: "ContractorCategoryGUID",
                value: new Guid("43fac927-5536-4bc1-b07f-339de5d03af6"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 6,
                column: "ContractorCategoryGUID",
                value: new Guid("fcc61465-7646-4e91-9fcc-5fb075c4679d"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 7,
                column: "ContractorCategoryGUID",
                value: new Guid("1214be88-2d49-4f92-85c1-3bfd84b97959"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 8,
                column: "ContractorCategoryGUID",
                value: new Guid("6d762fc9-6176-46e8-a960-12ef6ed0ee86"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 9,
                column: "ContractorCategoryGUID",
                value: new Guid("cb15e071-5256-4572-9da7-799b59c30ee0"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 10,
                column: "ContractorCategoryGUID",
                value: new Guid("e76f079b-4eb3-477f-b97f-c741bfa5dfed"));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "OrderGUID" },
                values: new object[] { new DateTime(2020, 7, 1, 4, 1, 43, 351, DateTimeKind.Local).AddTicks(9162), new Guid("6ee994c6-ee2e-4edc-a6d4-190b34d18fa2") });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "OrderGUID" },
                values: new object[] { new DateTime(2020, 7, 1, 4, 1, 43, 351, DateTimeKind.Local).AddTicks(9991), new Guid("7a3b3856-b6c3-46a8-80bc-daf39045b2d1") });

            migrationBuilder.UpdateData(
                table: "OrderRequest",
                keyColumn: "OrderRequestID",
                keyValue: 1,
                columns: new[] { "IsAllow", "ModifiedDate", "OrderRequestGUID" },
                values: new object[] { true, new DateTime(2020, 7, 1, 4, 1, 43, 352, DateTimeKind.Local).AddTicks(7723), new Guid("c051b3c7-a4a1-4a0e-b35f-09f7c6daa548") });

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 1,
                column: "ProvinceGUID",
                value: new Guid("3b6151ae-b18b-45c5-a96a-1f8c510d5372"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 2,
                column: "ProvinceGUID",
                value: new Guid("19b3ef96-498c-4a2f-b045-a502fbe7cefc"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 3,
                column: "ProvinceGUID",
                value: new Guid("74af6cfd-09cc-42e6-93e9-04b73b044f18"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 4,
                column: "ProvinceGUID",
                value: new Guid("d40b7bb2-f85d-414f-9f3a-9f497ed001bf"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 5,
                column: "ProvinceGUID",
                value: new Guid("f9778c67-8805-4410-9fc6-861b70d30a09"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 6,
                column: "ProvinceGUID",
                value: new Guid("1e109a59-fc8a-47bc-af25-7b9280c35b34"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 7,
                column: "ProvinceGUID",
                value: new Guid("f0a03a67-8e50-4f2b-8f90-117f481262d3"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 8,
                column: "ProvinceGUID",
                value: new Guid("a97551e0-01e4-468c-9a53-a126aba25619"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 9,
                column: "ProvinceGUID",
                value: new Guid("a9125243-e789-4d86-8f15-07bdd8876fe3"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 10,
                column: "ProvinceGUID",
                value: new Guid("29fb89c9-597b-4a4a-8afa-bd605d6ec39f"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 11,
                column: "ProvinceGUID",
                value: new Guid("c5e273b5-365c-4f5e-8eca-4b40079d8d44"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 12,
                column: "ProvinceGUID",
                value: new Guid("0ac642dd-0d4f-4f27-ad18-b53051ff29e8"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 13,
                column: "ProvinceGUID",
                value: new Guid("1321dba4-6c5a-43cf-9335-7afd6182e17e"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 14,
                column: "ProvinceGUID",
                value: new Guid("d037c4c4-4596-430b-9a41-be8ca59f70cb"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 15,
                column: "ProvinceGUID",
                value: new Guid("8f1255c3-fe26-4730-bfb1-afabf9a260ac"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 16,
                column: "ProvinceGUID",
                value: new Guid("a62de112-963b-4a33-8b09-c52a6a959ccd"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 17,
                column: "ProvinceGUID",
                value: new Guid("38c029a0-7b3a-44c0-aed6-7c6893a75b0f"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 18,
                column: "ProvinceGUID",
                value: new Guid("0ee7dfea-0e1b-4576-99f8-d0e8dcb52b54"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 19,
                column: "ProvinceGUID",
                value: new Guid("5e71a692-51e5-427c-842a-4ac6e10fbe7e"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 20,
                column: "ProvinceGUID",
                value: new Guid("0e3aa043-6307-4b9f-95cb-e6d79325f250"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 21,
                column: "ProvinceGUID",
                value: new Guid("d04183e8-e2e6-4f7f-8b3c-8fb3401f8dbf"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 22,
                column: "ProvinceGUID",
                value: new Guid("1ce6316d-abab-4d21-bdfa-994af98a2d59"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 23,
                column: "ProvinceGUID",
                value: new Guid("f6632ad6-ccfe-46b0-8de7-a0b966fb91f0"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 24,
                column: "ProvinceGUID",
                value: new Guid("0c3cb1ce-0c46-4776-bc0d-4f0581775859"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 25,
                column: "ProvinceGUID",
                value: new Guid("bf540cd4-b042-419d-9f95-f342273b3c67"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 26,
                column: "ProvinceGUID",
                value: new Guid("2321bc24-e5ad-4a93-8cb0-bfb745204b8b"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 27,
                column: "ProvinceGUID",
                value: new Guid("04575b66-8178-419b-bfa5-f07a51c09f70"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 28,
                column: "ProvinceGUID",
                value: new Guid("c302d03f-0f76-49a2-920f-03905dd0c9bb"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 29,
                column: "ProvinceGUID",
                value: new Guid("fd9c29cf-96ac-4c27-b2ab-73664eb56731"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 30,
                column: "ProvinceGUID",
                value: new Guid("6b446111-b7cf-414d-aea8-af3a99cfdd9f"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 31,
                column: "ProvinceGUID",
                value: new Guid("9774e4bc-ddaa-453d-ab49-cb20beaf38cb"));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RoleGUID" },
                values: new object[] { new DateTime(2020, 7, 1, 4, 1, 43, 341, DateTimeKind.Local).AddTicks(9879), new Guid("e56d3d73-50a8-4e68-8a5b-1ad2e25eeb01") });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "RoleGUID" },
                values: new object[] { new DateTime(2020, 7, 1, 4, 1, 43, 345, DateTimeKind.Local).AddTicks(3825), new Guid("7654b9c7-b371-4e7e-96e9-d5d0af9e7814") });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleID",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "RoleGUID" },
                values: new object[] { new DateTime(2020, 7, 1, 4, 1, 43, 345, DateTimeKind.Local).AddTicks(3962), new Guid("a7d157d3-62a7-416e-bbbd-05b648c967e2") });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "IsActive", "IsRegister", "ModifiedDate", "RegisteredDate", "UserGUID" },
                values: new object[] { true, true, new DateTime(2020, 7, 1, 4, 1, 43, 347, DateTimeKind.Local).AddTicks(8120), new DateTime(2020, 7, 1, 4, 1, 43, 347, DateTimeKind.Local).AddTicks(7460), new Guid("d2f247d1-51ef-4968-8729-7484181040b3") });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "IsActive", "IsRegister", "ModifiedDate", "RegisteredDate", "UserGUID" },
                values: new object[] { true, true, new DateTime(2020, 7, 1, 4, 1, 43, 348, DateTimeKind.Local).AddTicks(613), new DateTime(2020, 7, 1, 4, 1, 43, 348, DateTimeKind.Local).AddTicks(583), new Guid("b74fd445-e911-4a7f-991d-951cfc7f28c3") });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "IsActive", "IsRegister", "ModifiedDate", "RegisteredDate", "UserGUID" },
                values: new object[] { true, true, new DateTime(2020, 7, 1, 4, 1, 43, 348, DateTimeKind.Local).AddTicks(695), new DateTime(2020, 7, 1, 4, 1, 43, 348, DateTimeKind.Local).AddTicks(690), new Guid("6437387a-1b10-4572-95a7-7ecd273a7ed9") });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "IsActive", "IsRegister", "ModifiedDate", "RegisteredDate", "UserGUID" },
                values: new object[] { true, true, new DateTime(2020, 7, 1, 4, 1, 43, 348, DateTimeKind.Local).AddTicks(712), new DateTime(2020, 7, 1, 4, 1, 43, 348, DateTimeKind.Local).AddTicks(707), new Guid("aebca3a5-9959-46bf-8906-af6d06a70faa") });
        }
    }
}
