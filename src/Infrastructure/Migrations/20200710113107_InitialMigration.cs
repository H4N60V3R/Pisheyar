using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pisheyar.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CodeGroup",
                columns: table => new
                {
                    CodeGroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeGroupGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    Name = table.Column<string>(maxLength: 128, nullable: true),
                    DisplayName = table.Column<string>(maxLength: 128, nullable: true),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeGroup", x => x.CodeGroupID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentProvider",
                columns: table => new
                {
                    PaymentProviderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentProviderGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentProvider", x => x.PaymentProviderID);
                });

            migrationBuilder.CreateTable(
                name: "PermissionGroup",
                columns: table => new
                {
                    PermissionGroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionGroupGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    DisplayName = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionGroup", x => x.PermissionGroupID);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    ProvinceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.ProvinceID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    DisplayName = table.Column<string>(maxLength: 128, nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    SettingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SettingGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserInitialCredit = table.Column<int>(nullable: false),
                    OrderRequestPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.SettingID);
                });

            migrationBuilder.CreateTable(
                name: "SMSProvider",
                columns: table => new
                {
                    SMSProviderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SMSProviderGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSProvider", x => x.SMSProviderID);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    TagID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Usage = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.TagID);
                });

            migrationBuilder.CreateTable(
                name: "Code",
                columns: table => new
                {
                    CodeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    CodeGroupID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: true),
                    DisplayName = table.Column<string>(maxLength: 128, nullable: true),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Code", x => x.CodeID);
                    table.ForeignKey(
                        name: "FK_Code_CodeGroup",
                        column: x => x.CodeGroupID,
                        principalTable: "CodeGroup",
                        principalColumn: "CodeGroupID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentProviderSetting",
                columns: table => new
                {
                    PaymentProviderSettingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentProviderSettingGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    PaymentProviderID = table.Column<int>(nullable: false),
                    Username = table.Column<string>(maxLength: 128, nullable: false),
                    Password = table.Column<string>(maxLength: 128, nullable: false),
                    APIKey = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentProviderSetting", x => x.PaymentProviderSettingID);
                    table.ForeignKey(
                        name: "FK_PaymentProviderSetting_PaymentProvider",
                        column: x => x.PaymentProviderID,
                        principalTable: "PaymentProvider",
                        principalColumn: "PaymentProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    PermissionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    PermissionGroupID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    DisplayName = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.PermissionID);
                    table.ForeignKey(
                        name: "FK_Permission_PermissionGroup",
                        column: x => x.PermissionGroupID,
                        principalTable: "PermissionGroup",
                        principalColumn: "PermissionGroupID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ProvinceID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityID);
                    table.ForeignKey(
                        name: "FK_City_Province",
                        column: x => x.ProvinceID,
                        principalTable: "Province",
                        principalColumn: "ProvinceID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SMSProviderSetting",
                columns: table => new
                {
                    SMSProviderSettingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SMSProviderSettingGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    SMSProviderID = table.Column<int>(nullable: false),
                    Username = table.Column<string>(maxLength: 128, nullable: false),
                    Password = table.Column<string>(maxLength: 128, nullable: false),
                    APIKey = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSProviderSetting", x => x.SMSProviderSettingID);
                    table.ForeignKey(
                        name: "FK_SMSProviderSetting_SMSProvider",
                        column: x => x.SMSProviderID,
                        principalTable: "SMSProvider",
                        principalColumn: "SMSProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContactUs",
                columns: table => new
                {
                    ContactUsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactUsGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ContactUsBusinessTypeCodeID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Email = table.Column<string>(maxLength: 128, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 128, nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUs", x => x.ContactUsID);
                    table.ForeignKey(
                        name: "FK_ContactUs_Code",
                        column: x => x.ContactUsBusinessTypeCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    DocumentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    TypeCodeID = table.Column<int>(nullable: false),
                    Path = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Size = table.Column<long>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.DocumentID);
                    table.ForeignKey(
                        name: "FK_Document_Code",
                        column: x => x.TypeCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PublicDiscount",
                columns: table => new
                {
                    PublicDiscountID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicDiscountGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    TypeCodeID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(maxLength: 128, nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicDiscount", x => x.PublicDiscountID);
                    table.ForeignKey(
                        name: "FK_PublicDiscount_Code",
                        column: x => x.TypeCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    TransactionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    TypeCodeID = table.Column<int>(nullable: false),
                    Cost = table.Column<long>(nullable: false),
                    Serial = table.Column<string>(maxLength: 128, nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_Transaction_Code",
                        column: x => x.TypeCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RolePermission",
                columns: table => new
                {
                    RolePermissionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolePermissionGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    PermissionID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermission", x => x.RolePermissionID);
                    table.ForeignKey(
                        name: "FK_RolePermission_Permission",
                        column: x => x.PermissionID,
                        principalTable: "Permission",
                        principalColumn: "PermissionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RolePermission_Role",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SMSProviderSettingNumber",
                columns: table => new
                {
                    SMSProviderSettingNumberID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SMSProviderSettingNumberGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    SMSProviderSettingID = table.Column<int>(nullable: false),
                    Value = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSProviderSettingNumber", x => x.SMSProviderSettingNumberID);
                    table.ForeignKey(
                        name: "FK_SMSProviderSettingNumber_SMSProviderSetting",
                        column: x => x.SMSProviderSettingID,
                        principalTable: "SMSProviderSetting",
                        principalColumn: "SMSProviderSettingID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SMSTemplate",
                columns: table => new
                {
                    SMSTemplateID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SMSTemplateGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    SMSProviderSettingID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSTemplate", x => x.SMSTemplateID);
                    table.ForeignKey(
                        name: "FK_SMSTemplate_SMSProviderSetting",
                        column: x => x.SMSProviderSettingID,
                        principalTable: "SMSProviderSetting",
                        principalColumn: "SMSProviderSettingID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Advertisement",
                columns: table => new
                {
                    AdvertisementID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvertisementGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    DocumentID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    IsShow = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisement", x => x.AdvertisementID);
                    table.ForeignKey(
                        name: "FK_Advertisement_Document",
                        column: x => x.DocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ParentCategoryID = table.Column<int>(nullable: true),
                    CoverDocumentID = table.Column<int>(nullable: true),
                    SecondPageCoverDocumentID = table.Column<int>(nullable: true),
                    ActiveIconDocumentID = table.Column<int>(nullable: true),
                    InactiveIconDocumentID = table.Column<int>(nullable: true),
                    QuadMenuDocumentID = table.Column<int>(nullable: true),
                    DisplayName = table.Column<string>(maxLength: 128, nullable: false),
                    Abstract = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                    table.ForeignKey(
                        name: "FK_Category_ActiveIconDocument",
                        column: x => x.ActiveIconDocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Category_CoverDocument",
                        column: x => x.CoverDocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Category_InactiveIconDocument",
                        column: x => x.InactiveIconDocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Category_ParentCategory",
                        column: x => x.ParentCategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Category_QuadMenuDocument",
                        column: x => x.QuadMenuDocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Category_SecondPageCoverDocument",
                        column: x => x.SecondPageCoverDocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    RoleID = table.Column<int>(nullable: false),
                    GenderCodeID = table.Column<int>(nullable: true),
                    ProfileDocumentID = table.Column<int>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 128, nullable: false),
                    LastName = table.Column<string>(maxLength: 128, nullable: false),
                    Email = table.Column<string>(maxLength: 128, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    IsRegister = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    RegisteredDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_User_Code",
                        column: x => x.GenderCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Document_ProfileDocumentID",
                        column: x => x.ProfileDocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Role",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CategoryTag",
                columns: table => new
                {
                    CategoryTagID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryTagGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    CategoryID = table.Column<int>(nullable: false),
                    TagID = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTag", x => x.CategoryTagID);
                    table.ForeignKey(
                        name: "FK_CategoryTag_Category",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CategoryTag_Tag",
                        column: x => x.TagID,
                        principalTable: "Tag",
                        principalColumn: "TagID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AdminID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.AdminID);
                    table.ForeignKey(
                        name: "FK_Admin_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    CityID = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientID);
                    table.ForeignKey(
                        name: "FK_Client_City",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Client_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    Message = table.Column<string>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comment_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Complaint",
                columns: table => new
                {
                    ComplaintID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComplaintGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    Subject = table.Column<string>(maxLength: 512, nullable: false),
                    Description = table.Column<string>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaint", x => x.ComplaintID);
                    table.ForeignKey(
                        name: "FK_Complaint_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contractor",
                columns: table => new
                {
                    ContractorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractorGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    BusinessTypeCodeID = table.Column<int>(nullable: false),
                    CityID = table.Column<int>(nullable: false),
                    Latitude = table.Column<string>(maxLength: 128, nullable: false),
                    Longitude = table.Column<string>(maxLength: 128, nullable: false),
                    Credit = table.Column<int>(nullable: false),
                    AverageRate = table.Column<double>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    AboutMe = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(maxLength: 128, nullable: true),
                    Website = table.Column<string>(maxLength: 128, nullable: true),
                    Instagram = table.Column<string>(maxLength: 128, nullable: true),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contractor", x => x.ContractorID);
                    table.ForeignKey(
                        name: "FK_Contractor_Code",
                        column: x => x.BusinessTypeCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contractor_City",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contractor_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    PostID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    DocumentID = table.Column<int>(nullable: false),
                    ViewCount = table.Column<int>(nullable: false),
                    LikeCount = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Abstract = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    IsShow = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsSuggested = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    IsInSlider = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.PostID);
                    table.ForeignKey(
                        name: "FK_Post_Document",
                        column: x => x.DocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Post_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SMSResponse",
                columns: table => new
                {
                    SMSResponseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SMSResponseGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    SMSTemplateID = table.Column<int>(nullable: true),
                    UserID = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    StatusText = table.Column<string>(nullable: false),
                    Sender = table.Column<string>(maxLength: 128, nullable: false),
                    Receptor = table.Column<string>(maxLength: 128, nullable: false),
                    Token = table.Column<string>(maxLength: 128, nullable: true),
                    Token1 = table.Column<string>(maxLength: 128, nullable: true),
                    Token2 = table.Column<string>(maxLength: 128, nullable: true),
                    Message = table.Column<string>(nullable: false),
                    Cost = table.Column<long>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    SentDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSResponse", x => x.SMSResponseID);
                    table.ForeignKey(
                        name: "FK_SMSResponse_SMSTemplate",
                        column: x => x.SMSTemplateID,
                        principalTable: "SMSTemplate",
                        principalColumn: "SMSTemplateID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SMSResponse_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Suggestion",
                columns: table => new
                {
                    SuggestionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuggestionGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    Subject = table.Column<string>(maxLength: 512, nullable: false),
                    Description = table.Column<string>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suggestion", x => x.SuggestionID);
                    table.ForeignKey(
                        name: "FK_Suggestion_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Token",
                columns: table => new
                {
                    TokenID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TokenGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    RoleCodeID = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false),
                    ExpireDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Token", x => x.TokenID);
                    table.ForeignKey(
                        name: "FK_Token_Code",
                        column: x => x.RoleCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Token_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserPermission",
                columns: table => new
                {
                    UserPermissionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserPermissionGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    PermissionID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPermission", x => x.UserPermissionID);
                    table.ForeignKey(
                        name: "FK_UserPermission_Permission",
                        column: x => x.PermissionID,
                        principalTable: "Permission",
                        principalColumn: "PermissionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserPermission_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContractorCategory",
                columns: table => new
                {
                    ContractorCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractorCategoryGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ContractorID = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractorCategory", x => x.ContractorCategoryID);
                    table.ForeignKey(
                        name: "FK_ContractorCategory_Category",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContractorCategory_Contractor",
                        column: x => x.ContractorID,
                        principalTable: "Contractor",
                        principalColumn: "ContractorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContractorDiscount",
                columns: table => new
                {
                    ContractorDiscountID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractorDiscountGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ContractorID = table.Column<int>(nullable: false),
                    PublicDiscountID = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractorDiscount", x => x.ContractorDiscountID);
                    table.ForeignKey(
                        name: "FK_ContractorDiscount_Contractor",
                        column: x => x.ContractorID,
                        principalTable: "Contractor",
                        principalColumn: "ContractorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContractorDiscount_PublicDiscount",
                        column: x => x.PublicDiscountID,
                        principalTable: "PublicDiscount",
                        principalColumn: "PublicDiscountID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContractorDocument",
                columns: table => new
                {
                    ContractorDocumentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractorDocumentGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ContractorID = table.Column<int>(nullable: false),
                    TitleCodeID = table.Column<int>(nullable: false),
                    DocumentID = table.Column<int>(nullable: false),
                    IsAccept = table.Column<bool>(nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractorDocument", x => x.ContractorDocumentID);
                    table.ForeignKey(
                        name: "FK_ContractorDocument_Contractor",
                        column: x => x.ContractorID,
                        principalTable: "Contractor",
                        principalColumn: "ContractorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContractorDocument_Document",
                        column: x => x.DocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContractorDocument_Code",
                        column: x => x.TitleCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ClientID = table.Column<int>(nullable: false),
                    ContractorID = table.Column<int>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false),
                    StateCodeID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    Rate = table.Column<double>(nullable: true),
                    Cost = table.Column<int>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    DeadlineDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Order_Category",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Client",
                        column: x => x.ClientID,
                        principalTable: "Client",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Contractor",
                        column: x => x.ContractorID,
                        principalTable: "Contractor",
                        principalColumn: "ContractorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Code",
                        column: x => x.StateCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    PaymentProviderSettingID = table.Column<int>(nullable: false),
                    ContractorID = table.Column<int>(nullable: false),
                    Cost = table.Column<int>(nullable: false),
                    Discount = table.Column<int>(nullable: false),
                    TrackingToken = table.Column<long>(nullable: true),
                    IsSuccessful = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_Payment_Contractor",
                        column: x => x.ContractorID,
                        principalTable: "Contractor",
                        principalColumn: "ContractorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payment_PaymentProviderSetting_PaymentProviderSettingID",
                        column: x => x.PaymentProviderSettingID,
                        principalTable: "PaymentProviderSetting",
                        principalColumn: "PaymentProviderSettingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrivateDiscount",
                columns: table => new
                {
                    PrivateDiscountID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrivateDiscountGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ContractorID = table.Column<int>(nullable: false),
                    TypeCodeID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(maxLength: 128, nullable: false),
                    MaximumUsesNumber = table.Column<int>(nullable: false),
                    NumberUsed = table.Column<int>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivateDiscount", x => x.PrivateDiscountID);
                    table.ForeignKey(
                        name: "FK_PrivateDiscount_Contractor",
                        column: x => x.ContractorID,
                        principalTable: "Contractor",
                        principalColumn: "ContractorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrivateDiscount_Code",
                        column: x => x.TypeCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostCategory",
                columns: table => new
                {
                    PostCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostCategoryGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    CategoryID = table.Column<int>(nullable: false),
                    PostID = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostCategory", x => x.PostCategoryID);
                    table.ForeignKey(
                        name: "FK_PostCategory_Category",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostCategory_Post",
                        column: x => x.PostID,
                        principalTable: "Post",
                        principalColumn: "PostID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostComment",
                columns: table => new
                {
                    PostCommentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostCommentGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    CommentID = table.Column<int>(nullable: false),
                    PostID = table.Column<int>(nullable: false),
                    IsAccept = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostComment", x => x.PostCommentID);
                    table.ForeignKey(
                        name: "FK_PostComment_Comment",
                        column: x => x.CommentID,
                        principalTable: "Comment",
                        principalColumn: "CommentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostComment_Post",
                        column: x => x.PostID,
                        principalTable: "Post",
                        principalColumn: "PostID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostTag",
                columns: table => new
                {
                    PostTagID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostTagGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    PostID = table.Column<int>(nullable: false),
                    TagID = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTag", x => x.PostTagID);
                    table.ForeignKey(
                        name: "FK_PostTag_Post",
                        column: x => x.PostID,
                        principalTable: "Post",
                        principalColumn: "PostID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostTag_Tag",
                        column: x => x.TagID,
                        principalTable: "Tag",
                        principalColumn: "TagID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderRequest",
                columns: table => new
                {
                    OrderRequestID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderRequestGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ContractorID = table.Column<int>(nullable: false),
                    OrderID = table.Column<int>(nullable: false),
                    Message = table.Column<string>(nullable: false),
                    OfferedPrice = table.Column<long>(nullable: false),
                    IsAllow = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    IsAccept = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderRequest", x => x.OrderRequestID);
                    table.ForeignKey(
                        name: "FK_OrderRequest_Contractor",
                        column: x => x.ContractorID,
                        principalTable: "Contractor",
                        principalColumn: "ContractorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderRequest_Order",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChatMessage",
                columns: table => new
                {
                    ChatMessageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChatMessageGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    OrderRequestID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: false),
                    IsSeen = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    IsModified = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    SentAt = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatMessage", x => x.ChatMessageID);
                    table.ForeignKey(
                        name: "FK_ChatMessage_OrderRequest",
                        column: x => x.OrderRequestID,
                        principalTable: "OrderRequest",
                        principalColumn: "OrderRequestID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChatMessage_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "Abstract", "ActiveIconDocumentID", "CategoryGUID", "CoverDocumentID", "Description", "DisplayName", "InactiveIconDocumentID", "IsActive", "ModifiedDate", "ParentCategoryID", "QuadMenuDocumentID", "SecondPageCoverDocumentID", "Sort" },
                values: new object[,]
                {
                    { 1, null, null, new Guid("c265fd02-0194-4d38-83e8-a93bc3698fcc"), null, null, "سایت اصلی", null, true, new DateTime(2020, 7, 10, 16, 1, 6, 408, DateTimeKind.Local).AddTicks(7741), null, null, null, 1 },
                    { 2, null, null, new Guid("dec37f17-0ab2-4208-8ba7-11cc1120369b"), null, null, "وبلاگ", null, true, new DateTime(2020, 7, 10, 16, 1, 6, 408, DateTimeKind.Local).AddTicks(9451), null, null, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "CodeGroup",
                columns: new[] { "CodeGroupID", "CodeGroupGUID", "DisplayName", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("5b739a57-164e-4b39-8b1c-1129bc9d8991"), "نوع فایل", "FilepondType" },
                    { 2, new Guid("2d9c9e83-39eb-42d7-b71f-ef26002c8470"), "نوع کسب و کار", "BusinessType" },
                    { 3, new Guid("a76da3ba-d12a-42c4-b7e1-732d0990af70"), "جنسیت", "Gender" },
                    { 4, new Guid("39c56245-8e42-4cef-8ddd-5e4c17782e8b"), "وضعیت سفارش", "OrderState" },
                    { 5, new Guid("7e9db57a-0c09-47ff-98b5-f49363beff67"), "نقش", "Role" },
                    { 6, new Guid("107a7244-6e66-4369-8ba6-dfb0636642c4"), "نوع کسب و کار بخش ارتباط با ما", "ContactUsBusinessType" }
                });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceID", "Name", "ProvinceGUID" },
                values: new object[,]
                {
                    { 19, "اصفهان", new Guid("8922ce26-ecea-471f-a388-e78892235187") },
                    { 20, "ايلام", new Guid("4b56c539-2854-4e75-b867-02ac089b853e") },
                    { 21, "تهران", new Guid("0e8dda85-255f-49af-83ae-d268100cafd5") },
                    { 22, "آذربايجان شرقي", new Guid("9d34ac17-f11b-4578-9774-cbde6c938ef2") },
                    { 23, "فارس", new Guid("e9ff5312-9386-4a25-85a9-d298f34ec74f") },
                    { 24, "کرمانشاه", new Guid("e8315d99-21a4-4e21-8dd3-117a6958427d") },
                    { 28, "همدان", new Guid("f955d220-ef3c-4d26-96d3-b461bf2d2a22") },
                    { 26, "مرکزي", new Guid("ea07369b-2106-45f2-9712-3a7659c83cfe") },
                    { 27, "گيلان", new Guid("9f72cc24-8219-4cd1-87bc-8bf145f97c9e") },
                    { 18, "اردبيل", new Guid("6881e147-a9d1-4f16-97e9-2f90371c0014") },
                    { 29, "کرمان", new Guid("e5eb7d25-8ed0-48a0-8463-c6ee144e3cba") },
                    { 30, "سمنان", new Guid("1e8263e9-0929-4e2b-9e7c-8ec22ef35e0b") },
                    { 31, "کهگيلويه و بويراحمد", new Guid("e4130afd-05cf-4f05-8c30-0309cddd04f6") },
                    { 25, "هرمزگان", new Guid("c40c8db9-072c-4065-b376-8b8bd4a2c2c5") },
                    { 17, "لرستان", new Guid("19266ab2-b9fa-4508-b243-9352cb371151") },
                    { 14, "گلستان", new Guid("ed9de64c-8968-4c1e-87fd-ed36c19efd0a") },
                    { 15, "مازندران", new Guid("9c05b1d3-ffc8-4fa1-ae1c-e0ba2ad4c5c9") },
                    { 1, "يزد", new Guid("a2aed523-1fbb-4aff-8d8d-9094e8771c9d") },
                    { 2, "چهار محال و بختياري", new Guid("95ad337f-f28c-44a8-866d-5eb055bed706") },
                    { 3, "خراسان شمالي", new Guid("00ee8457-52ee-4c93-a746-f273ee44ad2c") },
                    { 4, "البرز", new Guid("ba7656f8-8f96-41ce-acb3-3a7401f95a88") },
                    { 5, "قم", new Guid("8a3ec851-58c0-4922-a970-5e37867ccbde") },
                    { 16, "قزوين", new Guid("c3e5a2a0-233b-4b44-a594-73ecbf8d63fb") },
                    { 7, "آذربايجان غربي", new Guid("6e5d2c4a-5802-48c5-9206-4cb25cdf4bc5") },
                    { 6, "کردستان", new Guid("5f61b3d9-dc7c-42c8-b760-2b262c336a14") },
                    { 9, "سيستان و بلوچستان", new Guid("d55d89ba-9039-49b5-bed9-787b78ee44c7") },
                    { 10, "خراسان جنوبي", new Guid("b00d563a-db0a-4580-bdaf-3e1955bcda63") },
                    { 11, "خوزستان", new Guid("5c351930-1c4b-41a6-af17-e49103b4240a") },
                    { 12, "بوشهر", new Guid("72e0cc0f-8101-41fe-8cb8-105b628da43c") },
                    { 13, "زنجان", new Guid("6f8e069e-4bb4-46f7-8f3b-93f8cd88b824") },
                    { 8, "خراسان رضوي", new Guid("4554b0f7-9bef-4e43-ba0c-6a04e7ac8fe1") }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleID", "DisplayName", "ModifiedDate", "Name", "RoleGUID" },
                values: new object[,]
                {
                    { 3, "سرویس گیرنده", new DateTime(2020, 7, 10, 16, 1, 6, 400, DateTimeKind.Local).AddTicks(9109), "Client", new Guid("a52717f9-f975-4bbf-9200-89a9a7affa4a") },
                    { 1, "ادمین", new DateTime(2020, 7, 10, 16, 1, 6, 398, DateTimeKind.Local).AddTicks(5750), "Admin", new Guid("398e7535-8cd1-4428-b861-00d2db21281f") },
                    { 2, "سرویس دهنده", new DateTime(2020, 7, 10, 16, 1, 6, 400, DateTimeKind.Local).AddTicks(9053), "Contractor", new Guid("1d5fafe9-5c43-44c6-89da-689ed36779c7") }
                });

            migrationBuilder.InsertData(
                table: "SMSProvider",
                columns: new[] { "SMSProviderID", "Name" },
                values: new object[] { 1, "Kavenegar" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "Abstract", "ActiveIconDocumentID", "CategoryGUID", "CoverDocumentID", "Description", "DisplayName", "InactiveIconDocumentID", "IsActive", "ModifiedDate", "ParentCategoryID", "QuadMenuDocumentID", "SecondPageCoverDocumentID", "Sort" },
                values: new object[,]
                {
                    { 3, null, null, new Guid("e3b1e3a1-4d79-454d-8b1f-6c9e24e290b2"), null, null, "تاسیسات", null, true, new DateTime(2020, 7, 10, 16, 1, 6, 408, DateTimeKind.Local).AddTicks(9504), 1, null, null, 1 },
                    { 4, null, null, new Guid("ecdefff5-a542-46b6-8aab-c916f813bda4"), null, null, "ماشین آلات صنعتی", null, true, new DateTime(2020, 7, 10, 16, 1, 6, 408, DateTimeKind.Local).AddTicks(9540), 1, null, null, 2 },
                    { 5, null, null, new Guid("a19a1e1c-f2f8-4597-a4c2-40b5bf807b8e"), null, null, "تامین کالا", null, true, new DateTime(2020, 7, 10, 16, 1, 6, 408, DateTimeKind.Local).AddTicks(9547), 1, null, null, 3 },
                    { 6, null, null, new Guid("83e94707-2a47-494c-9448-c860551d1659"), null, null, "ساخت و ساز", null, true, new DateTime(2020, 7, 10, 16, 1, 6, 408, DateTimeKind.Local).AddTicks(9555), 1, null, null, 4 },
                    { 7, null, null, new Guid("ada60fa2-e1d8-478c-a0ae-94483356972d"), null, null, "تعمیرات", null, true, new DateTime(2020, 7, 10, 16, 1, 6, 408, DateTimeKind.Local).AddTicks(9563), 1, null, null, 5 },
                    { 8, null, null, new Guid("f9d214c2-b531-4cea-973b-05a8064893c6"), null, null, "خدمات", null, true, new DateTime(2020, 7, 10, 16, 1, 6, 408, DateTimeKind.Local).AddTicks(9570), 1, null, null, 6 },
                    { 9, null, null, new Guid("ceaee6dd-e92a-4d5f-bf0b-42fd379cd6a1"), null, null, "زیرساخت", null, true, new DateTime(2020, 7, 10, 16, 1, 6, 408, DateTimeKind.Local).AddTicks(9577), 1, null, null, 7 },
                    { 10, null, null, new Guid("f645d713-0e63-4940-91fc-3090277e06f8"), null, null, "حمل و نقل", null, true, new DateTime(2020, 7, 10, 16, 1, 6, 408, DateTimeKind.Local).AddTicks(9595), 1, null, null, 8 }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityGUID", "Name", "ProvinceID" },
                values: new object[,]
                {
                    { 826, new Guid("68363d75-29d1-44fb-bbe4-c5d3c7406151"), "ليلان", 22 },
                    { 825, new Guid("e8fe5df0-9be8-493d-b82c-16bb937032f3"), "قره آغاج", 22 },
                    { 824, new Guid("0a08e432-15dc-41d7-a22b-1558731d52a0"), "عجب شير", 22 },
                    { 823, new Guid("dc15e729-3b5d-4e4f-8215-c3451e9ca0ae"), "صوفيان", 22 },
                    { 822, new Guid("919ed3ff-756d-4872-b4d3-4be4fcc9db32"), "شهر جديد سهند", 22 },
                    { 821, new Guid("7804002d-00aa-46ae-97f5-b753b64ce067"), "شند آباد", 22 },
                    { 820, new Guid("f99e5afa-ba5b-4e02-a1f5-9786d4f8ed87"), "شرفخانه", 22 },
                    { 816, new Guid("c70cbae5-3ffe-456c-bf0a-c3d67ab6f2e9"), "سيس", 22 },
                    { 818, new Guid("0a12a4c7-3506-4bf6-8fde-65115b58aa0d"), "شبستر", 22 },
                    { 817, new Guid("777cc844-99a1-4d1c-9daa-330b49243618"), "سيه رود", 22 },
                    { 827, new Guid("57c265b3-7824-4b33-945f-7c8ae76edbbf"), "مبارک شهر", 22 },
                    { 815, new Guid("cb217723-0605-4b77-891c-d6ebfdbefa05"), "سردرود", 22 },
                    { 814, new Guid("7d369f16-79d7-4121-ab9f-da5dd06f6db7"), "سراب", 22 },
                    { 813, new Guid("a4a0d073-378c-4ac7-87c1-40551c885440"), "زنوز", 22 },
                    { 812, new Guid("7f860802-d4c6-4c6a-9eba-48c4abe1b9c6"), "زرنق", 22 },
                    { 819, new Guid("dc1ea727-7a87-4566-a8aa-ebb336a2365f"), "شربيان", 22 },
                    { 828, new Guid("ae2a336e-291e-4fa5-ab03-2f0573401f6e"), "مراغه", 22 },
                    { 832, new Guid("a27e08ed-4cb5-46ed-94a3-5a45ee7cee3f"), "مهربان", 22 },
                    { 830, new Guid("4fe9ef8a-1ea9-4acf-95a9-702b91dd21f3"), "ملکان", 22 },
                    { 846, new Guid("884ae464-9ccc-46d5-a02d-30a1ea40d25d"), "گوگان", 22 },
                    { 845, new Guid("cfceed7d-2d3e-4dab-9351-61996508aab2"), "کوزه کنان", 22 },
                    { 844, new Guid("7838532a-42d6-4e3d-be39-1fd092008aa5"), "کليبر", 22 },
                    { 843, new Guid("d649d496-d6a2-439f-bae5-7c1bda22936d"), "کلوانق", 22 },
                    { 842, new Guid("fdcf561f-5c25-4776-a126-e75360424c6f"), "کشکسراي", 22 },
                    { 841, new Guid("eb18ea96-ebc4-4e42-859b-9148d8deb6a4"), "يامچي", 22 },
                    { 840, new Guid("38e1e92d-93cd-4b4c-ab80-47dac3428e31"), "ورزقان", 22 },
                    { 829, new Guid("537a0b7f-78b6-4d29-9880-30aa527ff2d3"), "مرند", 22 },
                    { 839, new Guid("716c7354-5497-4bcf-9198-82833b16a995"), "وايقان", 22 },
                    { 837, new Guid("f8cc01fd-33e0-44d5-845e-ec980a63c752"), "هشترود", 22 },
                    { 836, new Guid("0e1b882b-b51b-4cef-a83c-235bf5db9cf8"), "هريس", 22 },
                    { 835, new Guid("0aed3929-4067-405d-a36f-55cc9b0d1a12"), "هاديشهر", 22 },
                    { 834, new Guid("ecf52417-adae-40c2-b301-56399a620006"), "نظرکهريزي", 22 },
                    { 833, new Guid("4556b8fb-6406-4896-809c-057c736bb3b8"), "ميانه", 22 },
                    { 811, new Guid("4f8abe51-3c24-45c8-b136-11e8040da882"), "دوزدوزان", 22 },
                    { 831, new Guid("5c93a6bb-6431-47f4-81c0-08d50cc40ccb"), "ممقان", 22 },
                    { 838, new Guid("41faac75-e594-408a-8686-c58da29a3488"), "هوراند", 22 },
                    { 810, new Guid("dee49a4b-0cc0-4b1c-a0fc-e793cb6f1611"), "خواجه", 22 },
                    { 806, new Guid("a8244778-c5a2-48c9-bcca-3c128fd5024a"), "خامنه", 22 },
                    { 808, new Guid("f9333573-c418-4b05-8cc0-4f272a6464de"), "خسروشاه", 22 },
                    { 787, new Guid("d9467176-b0c0-4841-a159-6a1c9b9884a1"), "آقکند", 22 },
                    { 786, new Guid("6c1cd0c1-dd6d-403a-aaa1-485ff6ca77e7"), "آذرشهر", 22 },
                    { 785, new Guid("a0eeea67-7d9c-4384-8e3b-0493aeb45537"), "آبش احمد", 22 },
                    { 784, new Guid("da4fcb9e-5eec-4105-8008-8a8425d25af7"), "گلستان", 21 },
                    { 783, new Guid("0e2bec28-f583-4482-8ae9-caf731466f3a"), "کيلان", 21 },
                    { 782, new Guid("e1a51f0d-bc25-4739-adcf-cc9c48d60704"), "کهريزک", 21 },
                    { 781, new Guid("61a1cb32-2751-437b-aa98-fcb66f7df066"), "چهاردانگه", 21 },
                    { 780, new Guid("0eb2bd7e-bd3f-459e-9a4d-b631b82c8a6f"), "پيشوا", 21 },
                    { 779, new Guid("acbaca6a-fd1f-48eb-8fe0-f2ee62915850"), "پرديس", 21 },
                    { 778, new Guid("79567837-cc72-4965-81de-09d716304d13"), "پاکدشت", 21 },
                    { 777, new Guid("fccac8b0-6278-4d9b-a7f5-ef84fd340096"), "ورامين", 21 },
                    { 776, new Guid("51bf8c84-57d5-49f6-92e1-9a0bb5f70aba"), "وحيديه", 21 },
                    { 775, new Guid("be56aefc-bdea-4e5b-b577-0bffbf42fb95"), "نصيرشهر", 21 },
                    { 774, new Guid("51ebb167-0ba2-4dff-a0ab-69f80794da18"), "نسيم شهر", 21 },
                    { 773, new Guid("67c1ca27-1cc5-4671-80e3-16116fbd7f82"), "ملارد", 21 },
                    { 788, new Guid("edc32508-4e8f-4df4-af30-eb773bf37ace"), "آچاچي", 22 },
                    { 789, new Guid("c222ddc4-0934-4e9c-a504-55526a335993"), "اسکو", 22 },
                    { 790, new Guid("a8da6ee2-c44e-4396-b3e6-742c7f9c236d"), "اهر", 22 },
                    { 791, new Guid("1591df89-4906-42bf-9822-e036a43f2e96"), "ايلخچي", 22 },
                    { 807, new Guid("529bf66d-f932-4d24-8d48-3d4e24fae900"), "خداجو", 22 },
                    { 847, new Guid("67485782-0ab8-431b-9fcf-1e78b39c232a"), "آباده", 23 },
                    { 805, new Guid("ca7f6dfb-721e-4a89-9d1d-25c947e301d1"), "خاروانا", 22 },
                    { 804, new Guid("1370a7bc-0672-41b1-b1fa-f8e66806cf52"), "جوان قلعه", 22 },
                    { 803, new Guid("c021b84d-a319-4939-93c7-6a952341b1e8"), "جلفا", 22 },
                    { 802, new Guid("d2720b11-23fd-44f0-94c2-829594ce0764"), "تيکمه داش", 22 },
                    { 801, new Guid("72d7748b-8257-4ae7-bea6-04015be5974a"), "تيمورلو", 22 },
                    { 809, new Guid("631c0249-8383-4bcd-8180-f056e147273d"), "خمارلو", 22 },
                    { 800, new Guid("e509cf94-032f-4cd3-af28-f71a6d3ada61"), "تسوج", 22 },
                    { 798, new Guid("9200afdf-8edc-4fd3-bd0e-1582b8dce5e7"), "ترک", 22 },
                    { 797, new Guid("927b9957-5056-43b2-9c5e-8cda7a30552c"), "تبريز", 22 },
                    { 796, new Guid("9432c5a2-cc6b-4f9f-b753-bf60be7f2bd1"), "بناب مرند", 22 },
                    { 795, new Guid("9182308c-49fa-4e75-823f-ad5b4b531a0b"), "بناب", 22 },
                    { 794, new Guid("68bdd6cf-adc4-4c3b-96b0-0575dab9999b"), "بستان آباد", 22 },
                    { 793, new Guid("fc9955bb-1a07-43d9-a3bb-5ab505285fba"), "بخشايش", 22 },
                    { 792, new Guid("2cc26e62-d463-4099-af0e-6869fbb47355"), "باسمنج", 22 },
                    { 799, new Guid("ee65801e-bffd-4c1e-aacf-36af1faa637b"), "ترکمانچاي", 22 },
                    { 848, new Guid("ff016f56-c1e3-426e-b2ae-7c0297f0cbc6"), "آباده طشک", 23 },
                    { 852, new Guid("4f71fa67-81b8-42c9-8870-3e9f0fb6353e"), "اسير", 23 },
                    { 850, new Guid("467c83a0-468c-458c-bdca-81cf8f4e8f32"), "ارسنجان", 23 },
                    { 905, new Guid("5c7c0c79-8dad-4c38-97fe-30065f7fa3c2"), "صغاد", 23 },
                    { 904, new Guid("c7fa6ade-47f6-4506-9068-1aba9170e957"), "شيراز", 23 },
                    { 903, new Guid("d24bbd6b-2af2-479c-a0b1-7f7285e00c03"), "شهر پير", 23 },
                    { 902, new Guid("93ea050d-c1bd-4b9f-8831-b1c507e3a478"), "شهر جديد صدرا", 23 },
                    { 901, new Guid("8aa73ea8-0fae-482a-a92c-83c7e2d6e4a9"), "ششده", 23 },
                    { 900, new Guid("b370a2db-a9db-48a6-b04e-e2bc3d016ca8"), "سيدان", 23 },
                    { 899, new Guid("6e6173bd-a722-4357-9e44-bacf1b4417f3"), "سورمق", 23 },
                    { 898, new Guid("8f5ff7ee-4514-4a86-bfd0-9ee9064a5bed"), "سلطان شهر", 23 },
                    { 897, new Guid("bf5ccc9d-99b4-4aa4-ada4-87aaf92a4926"), "سعادت شهر", 23 },
                    { 896, new Guid("426a142e-a1ab-4307-b6b9-817417a85c0a"), "سروستان", 23 },
                    { 895, new Guid("eb4eb366-6557-4c55-bc86-f62302b8990e"), "سده", 23 },
                    { 894, new Guid("c417750d-d20b-44f8-8ad5-66bed4bcd8de"), "زرقان", 23 },
                    { 893, new Guid("76b242fd-8e56-4fea-8e71-c535c7316bd2"), "زاهد شهر", 23 },
                    { 892, new Guid("5bacb979-f95c-44ae-b7a3-bfbe6fbb7a33"), "رونيز", 23 },
                    { 891, new Guid("ad788603-eaaa-4810-a09b-d82039c21e41"), "رامجرد", 23 },
                    { 906, new Guid("af30bb3b-e122-4c8c-8234-5948cccdfa17"), "صفا شهر", 23 },
                    { 907, new Guid("64c97fd1-27c5-4cb8-9e20-43f7b7b1e94c"), "علامرودشت", 23 },
                    { 908, new Guid("834043fd-4ded-494a-bc4d-c2125fc5ac29"), "عماد ده", 23 },
                    { 909, new Guid("7d7a9369-5fc2-4b51-a617-1cd5411b1144"), "فدامي", 23 },
                    { 925, new Guid("9978d6f9-8d82-451a-a05d-3369e167a3fc"), "مرودشت", 23 },
                    { 924, new Guid("3fd59b45-252f-4f7a-a423-2217cb2babdb"), "مبارک آباد", 23 },
                    { 923, new Guid("2a91d1c4-735d-4b7a-af61-bf52f1d77b8b"), "مادرسليمان", 23 },
                    { 922, new Guid("3c7f15fa-761e-487f-a829-7e0921b0d840"), "لپوئي", 23 },
                    { 921, new Guid("bddf5373-3497-44bd-afbc-cc45aff3b9b1"), "لطيفي", 23 },
                    { 920, new Guid("b7bdf1e7-b820-49c1-80e6-e3a605e15b92"), "لامرد", 23 },
                    { 919, new Guid("508399fe-4863-4c67-a3d1-0bd1df7e43e3"), "لار", 23 },
                    { 890, new Guid("2316d0d5-7df7-4cdd-836e-d5577f26d2f6"), "دژکرد", 23 },
                    { 918, new Guid("48dd77f6-d9dd-411d-b054-90ed4cfdc059"), "قير", 23 },
                    { 916, new Guid("71a9f70d-7d10-4a86-9337-212ce70a065f"), "قطب آباد", 23 },
                    { 915, new Guid("f64d24cd-79a6-4abb-9421-e28b0c73c7e2"), "قره بلاغ", 23 },
                    { 914, new Guid("b3bbcd42-b453-4845-af87-9858ccce9e87"), "قادرآباد", 23 },
                    { 913, new Guid("4ab9e5fa-b5bf-4670-9577-b73d4f579c82"), "قائميه", 23 },
                    { 912, new Guid("f297e71b-efba-4008-b6a3-dce9cc5fbbbf"), "فيروزآباد", 23 },
                    { 911, new Guid("86473304-fcac-491d-ab88-cccdbe82ed0f"), "فسا", 23 },
                    { 910, new Guid("4fb2f6ea-ae1c-4746-881d-48fa8bbdfff2"), "فراشبند", 23 },
                    { 917, new Guid("140759ae-d49c-4a81-ad6b-27b896ec41a9"), "قطرويه", 23 },
                    { 889, new Guid("f5fe469e-b3cc-4da3-bc54-9eadaf084393"), "دوزه", 23 },
                    { 888, new Guid("5690098d-031c-4154-9ce4-bb36bdc9f1a7"), "دوبرجي", 23 },
                    { 887, new Guid("36f701e3-ca6c-4cf7-a902-877d5aacfb06"), "دهرم", 23 },
                    { 866, new Guid("5ec077e8-bda4-415f-aa98-df660e7901a4"), "بوانات", 23 },
                    { 865, new Guid("28745477-5cde-4da7-9bca-5af209134b9e"), "بهمن", 23 },
                    { 864, new Guid("c66f4938-9ae3-4f18-9b8b-b6dfdc43cc1d"), "بنارويه", 23 },
                    { 863, new Guid("8992334d-4e75-4e5f-9747-85dc43ff6ff8"), "بالاده", 23 },
                    { 862, new Guid("881e817a-c4e4-437f-81ec-f0d53c333bbd"), "بابامنير", 23 },
                    { 861, new Guid("9a2f2b6d-3912-43db-bc67-d75564d855d2"), "باب انار", 23 },
                    { 860, new Guid("4422bb86-d7d6-4040-abfb-c24d6d1e0df3"), "ايزد خواست", 23 },
                    { 867, new Guid("31f31abf-3978-458b-90a6-afc6dc944a27"), "بيرم", 23 },
                    { 859, new Guid("7a9d036f-9b43-4e29-a300-f430a552c925"), "ايج", 23 },
                    { 857, new Guid("0bc17558-3586-42bc-91dc-b4971be03695"), "اهل", 23 },
                    { 856, new Guid("9670f1a6-88bc-42c9-801e-d26e4fda0f5c"), "امام شهر", 23 },
                    { 855, new Guid("f1696616-ac2b-407b-b33d-d8b54425de3b"), "اقليد", 23 },
                    { 854, new Guid("15297023-568f-4418-984b-f3ad02d25d0b"), "افزر", 23 },
                    { 853, new Guid("6333423b-a8f1-4609-875c-76d2f6b027bd"), "اشکنان", 23 },
                    { 772, new Guid("ed59f2bf-c822-4197-a37f-ec81d80b0358"), "لواسان", 21 },
                    { 851, new Guid("801a6c5c-d247-445e-b5fc-0fee69b8889e"), "استهبان", 23 },
                    { 858, new Guid("f78d159e-240b-477b-8939-56255bbdbc77"), "اوز", 23 },
                    { 849, new Guid("382ff45b-1b1f-42a2-a5e7-f69be9428d00"), "اردکان", 23 },
                    { 868, new Guid("cceca3c4-26c4-44e7-8da6-f35879cde431"), "بيضا", 23 },
                    { 870, new Guid("221d05c8-5ce2-4431-92f3-fa359e34a548"), "جهرم", 23 },
                    { 886, new Guid("0395456b-44a7-4e58-92ab-5f73846ed03a"), "دبيران", 23 },
                    { 885, new Guid("8a7fa512-10cc-4a81-9fe3-bfe163ddd867"), "داريان", 23 },
                    { 884, new Guid("5375ab16-9099-42cf-9a0e-78834f875304"), "داراب", 23 },
                    { 883, new Guid("21a48684-02de-4d60-9077-cb824f2e8728"), "خومه زار", 23 },
                    { 882, new Guid("09d69293-a293-4792-8ed0-7812953acab7"), "خوزي", 23 },
                    { 881, new Guid("c0aa8b42-bbf8-433e-9f4d-1d94026e7bd7"), "خور", 23 },
                    { 880, new Guid("20116922-1afe-477c-ac53-f0e47681a5ca"), "خنج", 23 },
                    { 869, new Guid("2ca5d94e-270f-42ad-9f70-029fa4cb79b8"), "جنت شهر", 23 },
                    { 879, new Guid("7d157189-2b2b-43a6-ba2d-a984277b5847"), "خشت", 23 },
                    { 877, new Guid("ab61ff53-54da-4c09-9895-ab8799fd3a0d"), "خاوران", 23 },
                    { 876, new Guid("410f26d5-093d-4987-9516-b76b6275d927"), "خانيمن", 23 },
                    { 875, new Guid("05f0c135-3444-43d9-9725-2122db068bbc"), "خانه زنيان", 23 },
                    { 874, new Guid("f09c493c-a52c-4f2f-84ee-4bd20dcf8ef0"), "حسن آباد", 23 },
                    { 873, new Guid("9434f882-4fbe-46a9-84a7-cda946246ab4"), "حسامي", 23 },
                    { 872, new Guid("525800b1-4953-4164-8848-d63008d175d0"), "حاجي آباد", 23 },
                    { 871, new Guid("b2442655-1cb8-471e-a99d-ab6066b2427d"), "جويم", 23 },
                    { 878, new Guid("bec9b649-d621-4043-b1d9-4cb9fd55825a"), "خرامه", 23 },
                    { 771, new Guid("a58d5a0b-760d-488a-80f8-818f6e033412"), "قرچک", 21 },
                    { 767, new Guid("b0a55780-22da-4649-8c5b-c8f0301ad33e"), "فرون آباد", 21 },
                    { 769, new Guid("50cbf287-6d4e-415d-9907-46ac924fb68d"), "فيروزکوه", 21 },
                    { 669, new Guid("e3a1a533-6e33-49c0-93c9-73aa6078c097"), "عسگران", 19 },
                    { 668, new Guid("b00e46cf-a414-4143-abeb-687b01b4b734"), "طرق رود", 19 },
                    { 667, new Guid("1909ef35-b10a-436e-9582-4f4fe8335940"), "طالخونچه", 19 },
                    { 666, new Guid("d2c81812-f2da-42c6-a366-3cd7dbeafb2e"), "شهرضا", 19 },
                    { 665, new Guid("d93d6df8-4f82-44ac-b007-21d888cdc547"), "شاپورآباد", 19 },
                    { 664, new Guid("83f385a7-a5ca-47bb-802a-140ae8445dbf"), "شاهين شهر", 19 },
                    { 663, new Guid("1f9ecad5-22a8-409f-bd15-307b66bfd159"), "سگزي", 19 },
                    { 662, new Guid("e5e3ec5a-e796-4d08-b752-5418bed90468"), "سين", 19 },
                    { 661, new Guid("befea716-d086-4407-ba7f-73077ef1e6b7"), "سميرم", 19 },
                    { 660, new Guid("408373ed-7809-4d12-838d-c84731190834"), "سفيد شهر", 19 },
                    { 659, new Guid("f47c30ba-6a48-45ac-affb-9bebe9a5db3a"), "سده لنجان", 19 },
                    { 658, new Guid("c73697ea-17b3-47f6-8c6c-b572211f6841"), "زيباشهر", 19 },
                    { 657, new Guid("8ec74164-0247-417b-85a6-4c3441483a55"), "زيار", 19 },
                    { 656, new Guid("1d9e3cfe-8ad5-4820-b8d6-3db544b2e556"), "زواره", 19 },
                    { 655, new Guid("1135c2df-48c2-49ea-872d-a6333a159489"), "زرين شهر", 19 },
                    { 670, new Guid("a2e8576c-eafe-4b49-bce0-9a5e5fbe08b8"), "علويچه", 19 },
                    { 671, new Guid("05b5c60b-a3ea-4152-903e-8f796e83b7b5"), "فرخي", 19 },
                    { 672, new Guid("a8ca2dfd-2d38-4795-b7bd-6eeadc50a6ce"), "فريدونشهر", 19 },
                    { 673, new Guid("19c74d7a-1df8-486b-8dc5-a63d37460015"), "فلاورجان", 19 },
                    { 689, new Guid("53eb13ff-ee98-40c0-828f-9580e9dd08d2"), "نوش آباد", 19 },
                    { 688, new Guid("5deda541-6dfd-4dfd-8989-bace538a592b"), "نطنز", 19 },
                    { 687, new Guid("35fbf7f0-d6be-4974-a47b-9e68b270718d"), "نصرآباد", 19 },
                    { 686, new Guid("c455e5a8-88c3-4ec6-8519-e7435164ab96"), "نجف آباد", 19 },
                    { 685, new Guid("c98a9f5c-34a4-4644-8b4b-e870f71db5bc"), "نائين", 19 },
                    { 684, new Guid("a15de7e6-3c59-4743-a39c-ebff7a324fe3"), "ميمه", 19 },
                    { 683, new Guid("6ddae0a5-17b6-4cbb-ac1f-e84c80a35069"), "مهاباد", 19 },
                    { 654, new Guid("ccfa4548-ec4f-4cc2-a548-237582b6c91d"), "زاينده رود", 19 },
                    { 682, new Guid("6e1190e6-bed8-4856-b897-fa44bfcae918"), "منظريه", 19 },
                    { 680, new Guid("b135a01e-f8ce-40c0-a951-b6f8e2c3f918"), "محمد آباد", 19 },
                    { 679, new Guid("3758b8db-df06-4052-9a93-c07cba1c1625"), "مبارکه", 19 },
                    { 678, new Guid("f5f56361-f4d0-452b-bb52-43e8e2b33867"), "لاي بيد", 19 },
                    { 677, new Guid("6af8f93c-5134-4b69-ac86-ed8e2b9cea15"), "قهدريجان", 19 },
                    { 676, new Guid("96e20804-7e8c-4192-b56b-db5eead68f41"), "قهجاورستان", 19 },
                    { 675, new Guid("e54228e0-ddc0-42cb-b5eb-6e78954f31af"), "قمصر", 19 },
                    { 674, new Guid("94d4f155-9876-407b-abdb-10ed4105d460"), "فولاد شهر", 19 },
                    { 681, new Guid("015461e5-ff8d-4523-90ea-53771ae10ea7"), "مشکات", 19 },
                    { 653, new Guid("c86c5701-2c6f-4dd9-b34f-32b5a7aeb0b0"), "زازران", 19 },
                    { 652, new Guid("8f2d6fef-4188-441f-b83e-6ee730650fcc"), "رضوانشهر", 19 },
                    { 651, new Guid("9da24f4c-f8d4-40de-b165-deb0da293298"), "رزوه", 19 },
                    { 630, new Guid("eea135e8-ab97-446d-a5b4-5ed3acf860ba"), "تودشک", 19 },
                    { 629, new Guid("52c8551e-9a7f-4e9c-8114-5c9aa4ac8fcc"), "بوئين مياندشت", 19 },
                    { 628, new Guid("8d8686e9-75e2-4c85-aaef-29dd165befd7"), "بهارستان", 19 },
                    { 627, new Guid("28b84e01-9e30-4516-8de7-f159614bbb53"), "بهاران شهر", 19 },
                    { 626, new Guid("552d2b60-26ef-42e1-ad60-4622a2f686ab"), "برف انبار", 19 },
                    { 625, new Guid("7c93b9e2-18ac-4253-ba59-a72d476cf7d8"), "برزک", 19 },
                    { 624, new Guid("5090de24-ef33-4350-9696-656b2867ac1a"), "بافران", 19 },
                    { 631, new Guid("e5d1f449-d2af-4071-a25e-a52f73c5270c"), "تيران", 19 },
                    { 623, new Guid("6230b44b-1b93-4d6a-a18a-1bf2760edd4c"), "باغشاد", 19 },
                    { 621, new Guid("8de031c6-9191-4a03-833b-7c14d9b566fa"), "بادرود", 19 },
                    { 620, new Guid("6d1847a6-5242-4b03-9c62-c276b46f8371"), "اژيه", 19 },
                    { 619, new Guid("4ea33686-2b6c-4037-9dc0-38a440ed1723"), "ايمانشهر", 19 },
                    { 618, new Guid("2e0839d6-d5c1-4600-8a64-d771031f5d60"), "انارک", 19 },
                    { 617, new Guid("c42884a9-0d43-42a6-bc3d-38a676f05905"), "افوس", 19 },
                    { 616, new Guid("9e1c46c6-5084-421a-99b7-ae05071e76e4"), "اصفهان", 19 },
                    { 615, new Guid("1c0785bb-0e4d-4dac-84f3-bfd5d3506742"), "اصغرآباد", 19 },
                    { 622, new Guid("4a7c7e9d-3665-4c31-b863-f1247c8420e4"), "باغ بهادران", 19 },
                    { 690, new Guid("e0f16ed9-e6f9-4324-97c5-b2ba1f7fa087"), "نياسر", 19 },
                    { 632, new Guid("c1124367-fac1-490d-8421-313ad5601fc3"), "جندق", 19 },
                    { 634, new Guid("fac65561-0724-4699-bea9-5dac212dbf24"), "جوشقان قالي", 19 },
                    { 650, new Guid("e5940ced-9f40-4555-83ac-725a6bbc9d3a"), "ديزيچه", 19 },
                    { 649, new Guid("efe8a3d4-c3d0-4780-bc26-4051852dfca1"), "دولت آباد", 19 },
                    { 648, new Guid("5be2104f-659e-4b3f-9ae4-808c1e129b42"), "دهق", 19 },
                    { 647, new Guid("dc56177b-f619-4bb0-a4df-85f41211f9d8"), "دهاقان", 19 },
                    { 646, new Guid("b48b1e73-0255-4798-90ed-8485af24a0c8"), "دستگرد", 19 },
                    { 645, new Guid("95a27294-50a5-4bc5-804f-1812bb54fcde"), "درچه پياز", 19 },
                    { 644, new Guid("f3cb2758-a673-4ec9-96c7-61eaad21c310"), "دامنه", 19 },
                    { 633, new Guid("067d2b7e-ef60-4436-bca8-e168f2366c06"), "جوزدان", 19 },
                    { 643, new Guid("d6e54d96-f4df-4971-b7b0-583d5b1671cd"), "داران", 19 },
                    { 641, new Guid("46228013-8196-4b4e-a28c-6b06983a56be"), "خور", 19 },
                    { 640, new Guid("a3b61192-8ccc-498f-9474-38e586dbe344"), "خوانسار", 19 },
                    { 639, new Guid("ced21302-2517-467c-a5d6-66b7a130139a"), "خميني شهر", 19 },
                    { 638, new Guid("5fb241f0-7f01-4463-b3ec-422403a64378"), "خالد آباد", 19 },
                    { 637, new Guid("5abf6b08-72f9-4256-88b4-ec146e690d97"), "حنا", 19 },
                    { 636, new Guid("4e2e6c8a-225c-4d52-8dc9-44473d094cd4"), "حسن آباد", 19 },
                    { 635, new Guid("3f7d75c4-d549-45ad-88f0-2dcc0208902f"), "حبيب آباد", 19 },
                    { 642, new Guid("0c2750f6-8bd2-457b-94a7-2f98f4d07e68"), "خورزوق", 19 },
                    { 770, new Guid("f3288307-eee4-42b6-8d9c-9d6d4161c702"), "قدس", 21 },
                    { 691, new Guid("93b7366d-91de-42c2-acce-187889436c38"), "نيک آباد", 19 },
                    { 693, new Guid("4e56e2b1-b609-4a9d-a092-12258280349c"), "ورزنه", 19 },
                    { 748, new Guid("6596bb98-8cd4-462e-b8af-15ee02b36386"), "باقرشهر", 21 },
                    { 747, new Guid("5c1972af-811d-4109-829b-a9bdd98746d0"), "باغستان", 21 },
                    { 746, new Guid("3ce8edc1-d761-4280-9e10-dd698341b03c"), "انديشه", 21 },
                    { 745, new Guid("41a48fe1-ffda-40cf-be84-ae9f7c1853b1"), "اسلامشهر", 21 },
                    { 744, new Guid("87eb3536-d045-486e-b2a7-1753c2fbd369"), "ارجمند", 21 },
                    { 743, new Guid("7517d480-ec6f-4a81-b057-8255eb367805"), "آبعلي", 21 },
                    { 742, new Guid("58fa3743-8f43-4969-bd21-643b59149afb"), "آبسرد", 21 },
                    { 741, new Guid("dcf49e01-9727-490a-88f7-d0d37a641065"), "چوار", 20 },
                    { 740, new Guid("fe94f760-6f38-4336-9f1b-7c01d99485d8"), "پهله", 20 },
                    { 739, new Guid("1264a5a6-f4f3-48d9-be14-64e88e2c4d26"), "ميمه", 20 },
                    { 738, new Guid("872024e7-2876-4d34-acb5-763387d038ed"), "موسيان", 20 },
                    { 737, new Guid("852be572-c1e6-484e-acf1-29bb9a5fe191"), "مورموري", 20 },
                    { 736, new Guid("6a723692-00e4-45c8-9166-97e3e5f82395"), "مهران", 20 },
                    { 735, new Guid("88042723-faee-4b2d-a551-004ebc43e01a"), "مهر", 20 },
                    { 734, new Guid("11487f74-c37c-4416-914e-bfd7ca507c4f"), "ماژين", 20 },
                    { 749, new Guid("550710e3-1e18-4348-8a5a-5a36f2e3bc3d"), "بومهن", 21 },
                    { 750, new Guid("6ebdd09c-35a4-405b-8d78-3a8fce643d28"), "تجريش", 21 },
                    { 751, new Guid("83b63835-7740-46fd-aa25-f2ae8d9513c2"), "تهران", 21 },
                    { 752, new Guid("cd9118f1-9fb6-476b-8683-73f6bcd1650c"), "جواد آباد", 21 },
                    { 768, new Guid("2d245afb-5444-46f6-a231-f5a570532f8e"), "فشم", 21 },
                    { 926, new Guid("ddc5c2f8-39bf-4461-b7ae-61a615d2cd9e"), "مزايجان", 23 },
                    { 766, new Guid("c28c17e1-4d3e-46a2-96b0-a64c1626ae19"), "فردوسيه", 21 },
                    { 765, new Guid("d4dc177e-5bc1-43ac-8c00-07419d5b7535"), "صفادشت", 21 },
                    { 764, new Guid("f6f79305-9994-45f6-a119-16dacaa5840c"), "صبا شهر", 21 },
                    { 763, new Guid("ef8ab52b-e387-434c-92d9-3e875e982af2"), "صالحيه", 21 },
                    { 762, new Guid("70b1a02c-1565-4e03-b0ec-fa0636a9d635"), "شهريار", 21 },
                    { 733, new Guid("8e84dcb5-b3e0-41be-bd7b-bacc313750e6"), "لومار", 20 },
                    { 761, new Guid("4aafc049-7bde-4e08-9959-074a37dfd03a"), "شهر جديد پرند", 21 },
                    { 759, new Guid("1d94c56c-cd28-4ccf-b1dc-9a618d497a34"), "شريف آباد", 21 },
                    { 758, new Guid("343311f3-ab21-4367-a517-7d1ce8385b07"), "شاهدشهر", 21 },
                    { 757, new Guid("db9aa667-a9ef-4dc6-a5c4-633ee53a46ed"), "ري", 21 },
                    { 756, new Guid("499bc24d-5a00-4851-8281-1aea4b9eb7c4"), "رودهن", 21 },
                    { 755, new Guid("f1248f62-2794-4e59-8dc8-9933a2794550"), "رباط کريم", 21 },
                    { 754, new Guid("b20b7da1-9b26-4f9b-8f7b-82ccf556f07a"), "دماوند", 21 },
                    { 753, new Guid("8bc86eb3-9fe2-4059-a26f-d9cf6c45b061"), "حسن آباد", 21 },
                    { 760, new Guid("6d39f581-76b5-44d8-8a15-505628b7e5df"), "شمشک", 21 },
                    { 732, new Guid("a55622e9-43a4-4380-a1be-fd7c455d2999"), "صالح آباد", 20 },
                    { 731, new Guid("c0ff8c99-27d9-448f-a3b8-17e7c540c052"), "شباب", 20 },
                    { 730, new Guid("cbfc6b52-5f62-4cc0-ba59-e358f3236233"), "سرابله", 20 },
                    { 709, new Guid("57a53887-91fa-4656-9e46-a4a66d64b189"), "کوهپايه", 19 },
                    { 708, new Guid("3d60acad-5978-4c56-a72d-cbf8e4c8bc75"), "کوشک", 19 },
                    { 707, new Guid("a135bef8-4683-4497-a58c-a2d511d0650a"), "کهريزسنگ", 19 },
                    { 706, new Guid("e7a9e93f-0b2f-4b9c-8915-a0c6d43d3b06"), "کمه", 19 },
                    { 705, new Guid("64745eaf-2471-4ff9-96cb-d754a0e00274"), "کمشجه", 19 },
                    { 704, new Guid("334c68db-c959-4162-a95d-ee616c750d08"), "کليشاد و سودرجان", 19 },
                    { 703, new Guid("058f94f9-9133-4df9-84bf-016497876653"), "کرکوند", 19 },
                    { 710, new Guid("8710675a-8ac0-4c43-b78e-94db7a063001"), "گرگاب", 19 },
                    { 702, new Guid("9e925123-ac5e-46c5-8876-c917d51347d9"), "کامو و چوگان", 19 },
                    { 700, new Guid("11850282-3296-43d2-8b8a-1fbffc611e8a"), "چمگردان", 19 },
                    { 699, new Guid("3d740999-c269-4eb4-8eda-1b6fe7a6942a"), "چرمهين", 19 },
                    { 698, new Guid("c82d2485-99e7-4a96-acce-0fdae3c8a7ac"), "چادگان", 19 },
                    { 697, new Guid("780fc974-aebe-4487-b89d-718bde3cd69d"), "پير بکران", 19 },
                    { 696, new Guid("c33904ef-e0e8-4cb6-9e80-a687a7939a20"), "ونک", 19 },
                    { 695, new Guid("62ad4c1b-7f0a-46be-a5ef-24a5a4b202eb"), "وزوان", 19 },
                    { 694, new Guid("56292d5d-f9a7-4996-9ecf-daea276f7468"), "ورنامخواست", 19 },
                    { 701, new Guid("6751a547-33ea-496a-b1fe-83807faceb9f"), "کاشان", 19 },
                    { 692, new Guid("13e2ac5f-beff-439e-ab3e-af7a5882ad79"), "هرند", 19 },
                    { 711, new Guid("d1cf0a93-ab60-4a29-963d-d8d1034e8488"), "گز برخوار", 19 },
                    { 713, new Guid("ad277d84-95e8-4a9e-9341-7dc9923e8381"), "گلشن", 19 },
                    { 729, new Guid("529aa010-8805-4fd4-b81d-7e266d89af7e"), "سراب باغ", 20 },
                    { 728, new Guid("39ffe53d-450b-4213-90c6-c2bdfdee3958"), "زرنه", 20 },
                    { 727, new Guid("8bb0ed48-6065-4d34-b168-5772194e79f2"), "دهلران", 20 },
                    { 726, new Guid("a99a58c3-93c5-4f46-b2ea-ccf9d213b019"), "دلگشا", 20 },
                    { 725, new Guid("639f686e-7cf6-4b50-82e1-cc3a6aca681a"), "دره شهر", 20 },
                    { 724, new Guid("6dbab51b-fdd2-44da-8814-a26fd9dcda44"), "توحيد", 20 },
                    { 723, new Guid("24f475a5-574f-4aea-8fa3-f11f159d4bfe"), "بلاوه", 20 },
                    { 712, new Guid("2624f608-66f4-404c-bb02-38ccb10dceb2"), "گلدشت", 19 },
                    { 722, new Guid("eb5447c7-840b-462a-9bd1-df374e0f6575"), "بدره", 20 },
                    { 720, new Guid("f74cd1f5-f7af-415f-987a-6faede395597"), "ايلام", 20 },
                    { 719, new Guid("5984f7da-de9d-4a00-b124-7db5aa9b3735"), "ارکواز", 20 },
                    { 718, new Guid("3b922583-49ca-4d10-ae55-8c362fcbdd36"), "آسمان آباد", 20 },
                    { 717, new Guid("73b793e7-0abc-4e3c-a9dd-a40ac27a94e8"), "آبدانان", 20 },
                    { 716, new Guid("1db7cb28-027d-41fa-9ba7-b592cc69bcf4"), "گوگد", 19 },
                    { 715, new Guid("741e5926-a32d-4d91-8f1c-bf26d05f6801"), "گلپايگان", 19 },
                    { 714, new Guid("d296cdc1-1544-4d08-b150-2b2d63240281"), "گلشهر", 19 },
                    { 721, new Guid("c566cf8c-fb81-4871-8a71-f889f56a8181"), "ايوان", 20 },
                    { 927, new Guid("e26ca4c9-2fb8-4a09-b076-383258309be5"), "مشکان", 23 },
                    { 931, new Guid("c831558c-53fe-483c-8873-9ff0449aa0ab"), "ميمند", 23 },
                    { 929, new Guid("fb40740b-5cf4-4fca-9d39-e6d00350484e"), "مهر", 23 },
                    { 1141, new Guid("d45e8bca-6c88-4d2b-a48b-e05b2d7c0583"), "بردسير", 29 },
                    { 1140, new Guid("a55fbe80-1bf6-4e4e-b7fc-0268e7b41f9b"), "بافت", 29 },
                    { 1139, new Guid("d8ea37f0-f29c-49ef-ba1d-3337c5881540"), "باغين", 29 },
                    { 1138, new Guid("6abba578-faf2-4476-97d4-645dc9fbf645"), "اندوهجرد", 29 },
                    { 1137, new Guid("8e72c1ea-7191-4f2e-9f79-d8d8111cc35d"), "انار", 29 },
                    { 1136, new Guid("cdb05a46-2539-473e-8b25-a6295f12dd01"), "امين شهر", 29 },
                    { 1135, new Guid("c0e786af-ffc7-4e67-9fe8-ba2fef98de16"), "ارزوئيه", 29 },
                    { 1134, new Guid("f2cfee2f-5834-49f8-b88e-bc2ba3942a46"), "اختيار آباد", 29 },
                    { 1133, new Guid("218a74be-f12f-445e-b846-8378ca2b285b"), "گيان", 28 },
                    { 1132, new Guid("0a19b6c9-d4c2-4bd9-b207-37d0ed6c6f88"), "گل تپه", 28 },
                    { 1131, new Guid("e8780506-27ce-4b21-a136-9b47d8f736a2"), "کبودر آهنگ", 28 },
                    { 1130, new Guid("e55f8881-c3e2-471a-a149-7f15233d34af"), "همدان", 28 },
                    { 1129, new Guid("28a919ba-2b28-4c32-8c50-e503aed69be9"), "نهاوند", 28 },
                    { 1128, new Guid("bff4af33-fa6a-4fe0-952c-40c3683c7ec7"), "مهاجران", 28 },
                    { 1127, new Guid("b276485a-0eb1-448e-a02a-c74a95272b27"), "ملاير", 28 },
                    { 1142, new Guid("d3d46b1e-7dd9-43f6-aa4a-dfb8a25e84ff"), "بروات", 29 },
                    { 1143, new Guid("dc27b961-1677-49f9-ad8f-15429f706427"), "بزنجان", 29 },
                    { 1144, new Guid("e2701a60-c31e-43ce-8dfb-9a63638064d1"), "بلورد", 29 },
                    { 1145, new Guid("c2057ddf-41f7-46c1-9210-afdcd54bdaff"), "بلوک", 29 },
                    { 1161, new Guid("c2785679-eaa7-465f-a227-db4b682b545f"), "راور", 29 },
                    { 1160, new Guid("0643782c-6ffd-4ecc-b0f3-fca53c205453"), "رابر", 29 },
                    { 1159, new Guid("50f3e1b1-362b-46d9-bbfb-0534029914d2"), "دوساري", 29 },
                    { 1158, new Guid("681c0b82-b5bf-4e65-b430-ca44651f5dfc"), "دهج", 29 },
                    { 1157, new Guid("a2cf7657-24fb-466b-80b9-935d5a3b41d1"), "دشتکار", 29 },
                    { 1156, new Guid("4da44d99-56fd-4025-b727-a62066f1fef8"), "درب بهشت", 29 },
                    { 1155, new Guid("a33b79ea-2edb-462e-8cac-a12c4312872c"), "خورسند", 29 },
                    { 1126, new Guid("1b094245-6317-4a4a-af43-b65e27d24a67"), "مريانج", 28 },
                    { 1154, new Guid("d08e01f4-0de9-4ab7-abc7-5729914ececf"), "خواجوشهر", 29 },
                    { 1152, new Guid("306eaba0-6ced-455d-9a34-b8cc3633a9ea"), "خاتون آباد", 29 },
                    { 1151, new Guid("546cc97a-0ae8-4adf-bdc3-d82ec8d9cecf"), "جيرفت", 29 },
                    { 1150, new Guid("cc3346fc-64d7-441d-89e8-cc69aa4dc57c"), "جوپار", 29 },
                    { 1149, new Guid("162774e0-2835-4cb9-aca7-8e56ddd17b53"), "جوزم", 29 },
                    { 1148, new Guid("2b3722b1-e8c8-488b-9712-015d06c63642"), "جبالبارز", 29 },
                    { 1147, new Guid("b24c0926-a61a-416e-bccd-b757e66a78a2"), "بهرمان", 29 },
                    { 1146, new Guid("41ade539-a332-40bd-bf66-ad98eee9cd87"), "بم", 29 },
                    { 1153, new Guid("aa2363d7-8ba6-45ba-aac6-1587979e52df"), "خانوک", 29 },
                    { 1162, new Guid("52d5e202-ce7b-4fb4-ad63-7fe098427693"), "راين", 29 },
                    { 1125, new Guid("53de8408-5adb-4ad6-85cf-b553c59fec68"), "لالجين", 28 },
                    { 1123, new Guid("c538b3fc-bb17-4d97-9683-6c77d1bbb61d"), "قروه در جزين", 28 },
                    { 1102, new Guid("5b9898d0-8427-4a1a-8186-b0df24e22194"), "کوچصفهان", 27 },
                    { 1101, new Guid("3860d4d6-1b1c-4e56-ba5c-5828cc43f240"), "کومله", 27 },
                    { 1100, new Guid("3ef0ebcb-a522-4d5f-8d36-c20227ead8b6"), "کلاچاي", 27 },
                    { 1099, new Guid("cae2049c-a0ea-4032-a27f-6f2aef34332d"), "چوبر", 27 },
                    { 1098, new Guid("8ff62a02-d2a3-4294-a31a-21f63b861fb5"), "چاف و چمخاله", 27 },
                    { 1097, new Guid("0c193263-eab8-4020-bcbb-d1087f616eca"), "چابکسر", 27 },
                    { 1096, new Guid("5b893aba-fb9e-4660-b4fe-5b51a5125c13"), "پره سر", 27 },
                    { 1095, new Guid("01d53d8a-e70f-4845-9c6d-a0e44dfa80ea"), "واجارگاه", 27 },
                    { 1094, new Guid("e30fb631-7eda-41ce-b8de-a2a3bfe9ac01"), "هشتپر", 27 },
                    { 1093, new Guid("e0895117-8911-45e3-b8dc-1c0ea634c2a3"), "منجيل", 27 },
                    { 1092, new Guid("7e721163-3a3a-45e2-a032-38d243e65634"), "مرجقل", 27 },
                    { 1091, new Guid("74e0cb97-c813-42ff-824a-a2481cd04004"), "ماکلوان", 27 },
                    { 1090, new Guid("bbf0d3b8-0821-43f6-a19c-f22f899a9250"), "ماسوله", 27 },
                    { 1089, new Guid("3fcb1588-c70c-451d-beef-e577711c7ba0"), "ماسال", 27 },
                    { 1088, new Guid("e47d8f24-1137-41ce-a129-8d97789e1a84"), "ليسار", 27 },
                    { 1103, new Guid("f3b1c55e-a27b-41c1-9b4f-6b55178f3a37"), "کياشهر", 27 },
                    { 1104, new Guid("dc949afd-0596-4bc5-a552-f757f7920d34"), "گوراب زرميخ", 27 },
                    { 1105, new Guid("186d3e57-c2d2-45a2-9e66-0f2d3acdb55b"), "آجين", 28 },
                    { 1106, new Guid("41f7d647-79d8-486b-b67d-4d82d7f7b8ca"), "ازندريان", 28 },
                    { 1122, new Guid("44a30879-80b4-4080-be0d-cca800fc2e4c"), "فيروزان", 28 },
                    { 1121, new Guid("b2a3b2f2-365a-452a-8a74-f92f03d6b566"), "فرسفج", 28 },
                    { 1120, new Guid("aa4d77c5-7d92-4960-bc90-4754dafdb3d9"), "فامنين", 28 },
                    { 1119, new Guid("bb4a5f9a-0615-4ce5-87ad-1d9e81db8c9a"), "صالح آباد", 28 },
                    { 1118, new Guid("a88c5121-5a26-485b-a4a8-a71c02020469"), "شيرين سو", 28 },
                    { 1117, new Guid("a444edfc-4348-4d2c-adab-8ba9433e7742"), "سرکان", 28 },
                    { 1116, new Guid("c61ca5eb-e733-432c-b8ff-4a67cc352245"), "سامن", 28 },
                    { 1124, new Guid("a965bfa3-d763-4541-a8be-ffad08f6bd8c"), "قهاوند", 28 },
                    { 1115, new Guid("51b621ec-c99b-4d66-930d-3f0612ba72ad"), "زنگنه", 28 },
                    { 1113, new Guid("d9531d16-fbc3-4e51-b737-19407fdb4486"), "دمق", 28 },
                    { 1112, new Guid("719c6687-5d8e-42e5-af88-25df6b634ddc"), "جوکار", 28 },
                    { 1111, new Guid("59b2ccfd-887b-4b04-b30f-af29a1543bb2"), "جورقان", 28 },
                    { 1110, new Guid("6e8ff115-3031-468e-9c70-ebe30e9fcf05"), "تويسرکان", 28 },
                    { 1109, new Guid("d79d6f1e-6988-4d6b-8304-f1dd49093f38"), "بهار", 28 },
                    { 1108, new Guid("35bddc27-ad04-45a0-a4f6-17b98908c71a"), "برزول", 28 },
                    { 1107, new Guid("8421f660-4dc4-4f20-82c8-66529b55bbea"), "اسد آباد", 28 },
                    { 1114, new Guid("ca7e54ba-30ef-4050-b55e-8981f8c640cf"), "رزن", 28 },
                    { 1163, new Guid("22ccaed0-6dd8-4b78-9d05-a35862ef8f43"), "رفسنجان", 29 },
                    { 1164, new Guid("7de81d8b-2981-47ec-8c78-7b13ce110879"), "رودبار", 29 },
                    { 1165, new Guid("ed7babc6-634e-42f7-9f7b-b6ec4d25fd77"), "ريحان", 29 },
                    { 1220, new Guid("6d45f178-0afc-4713-bb2c-92e694d3cf66"), "ميامي", 30 },
                    { 1219, new Guid("34854f2c-4800-4c9e-9f53-1351ba8f7a67"), "مهدي شهر", 30 },
                    { 1218, new Guid("63b61202-b99a-4670-a42f-f1dfa7d1f046"), "مجن", 30 },
                    { 1217, new Guid("012f4664-8e54-45f0-a39a-c135e83da15d"), "شهميرزاد", 30 },
                    { 1216, new Guid("55d53dfc-3078-41fc-bf17-746b971b7569"), "شاهرود", 30 },
                    { 1215, new Guid("5dfef70d-0084-4fc3-8722-59735ea295f9"), "سمنان", 30 },
                    { 1214, new Guid("13182a4e-490a-4dd8-a063-45911c5f988f"), "سرخه", 30 },
                    { 1213, new Guid("3d95c2e9-0eb5-41b6-a0d6-4835cbbe34cb"), "روديان", 30 },
                    { 1212, new Guid("bc47bf28-939d-4f92-a02b-4bd467303a69"), "ديباج", 30 },
                    { 1211, new Guid("3433b789-bb4d-496d-9654-74e18166e792"), "درجزين", 30 },
                    { 1210, new Guid("dea631f0-2a3c-4ee3-bb8f-099f09b564f0"), "دامغان", 30 },
                    { 1209, new Guid("89fa07c4-0ca5-460b-a953-1156a4ab4cdb"), "بيارجمند", 30 },
                    { 1208, new Guid("c73a67b5-b3ff-49ff-b621-692bca831531"), "بسطام", 30 },
                    { 1207, new Guid("f5acf7dd-bf61-4ead-91c6-2d94c547be53"), "ايوانکي", 30 },
                    { 1206, new Guid("231f1779-5960-440e-9c2d-a597ef6d4821"), "اميريه", 30 },
                    { 1221, new Guid("f39f8d44-c60a-464a-a76a-a4bb56a73f4e"), "کلاته", 30 },
                    { 1222, new Guid("c6842908-17c6-4cfe-b920-b4b5b81c04aa"), "کلاته خيج", 30 },
                    { 1223, new Guid("8dca101e-abf8-4961-bd1c-3ac93fd57545"), "کهن آباد", 30 },
                    { 1224, new Guid("fee27c25-baca-4960-ab9b-8e41a8ababeb"), "گرمسار", 30 },
                    { 1240, new Guid("5d8fb3f0-719b-43b7-8676-d55106262172"), "چيتاب", 31 },
                    { 1239, new Guid("0f1a4535-5a1e-488f-b272-a3c749cec000"), "چرام", 31 },
                    { 1238, new Guid("fb87dad9-e644-4761-b1bc-20e9a9ad62d6"), "پاتاوه", 31 },
                    { 1237, new Guid("30f9b632-7ed8-4e01-b0d3-9173012ba954"), "ياسوج", 31 },
                    { 1236, new Guid("036ce1c3-0280-4df5-9f31-ea2f80fd5625"), "مارگون", 31 },
                    { 1235, new Guid("f6483c99-a8b9-4272-88ff-effd0a852d33"), "مادوان", 31 },
                    { 1234, new Guid("e33780b4-0d38-4c5c-a6ed-14492c1c4dde"), "ليکک", 31 },
                    { 1205, new Guid("c3411e16-d391-4d22-a75f-7cf87be352ef"), "آرادان", 30 },
                    { 1233, new Guid("939e4921-ce41-4917-8dfc-62a72f382083"), "لنده", 31 },
                    { 1231, new Guid("1bfe37ac-57be-4ae2-b2c6-a1cf093eeeac"), "سي سخت", 31 },
                    { 1230, new Guid("f99c4bbd-5322-418e-a4a4-4891d5661083"), "سوق", 31 },
                    { 1229, new Guid("5b5e2516-fe7c-4454-bf27-58dbb85611f6"), "سرفارياب", 31 },
                    { 1228, new Guid("4fc22a1f-ef50-4ee6-975b-c3d571748052"), "ديشموک", 31 },
                    { 1227, new Guid("bbef05af-9070-4046-b634-d277e3ac1590"), "دوگنبدان", 31 },
                    { 1226, new Guid("b6cb3714-d227-40a1-bab5-d16abcb7756f"), "دهدشت", 31 },
                    { 1225, new Guid("cf85660c-8a47-4143-b1bd-7cc87e6413ba"), "باشت", 31 },
                    { 1232, new Guid("d3c5c1ea-fe6d-47b2-9b80-164da3c73ada"), "قلعه رئيسي", 31 },
                    { 1204, new Guid("943163ca-3917-460c-8ad0-406c6bba0ee8"), "گنبکي", 29 },
                    { 1203, new Guid("6c29482f-7c23-48e3-bf9f-c137dd57cb22"), "گلزار", 29 },
                    { 1202, new Guid("c40fa63b-5b68-4fb7-8fb8-ac26f122c987"), "گلباف", 29 },
                    { 1181, new Guid("aaf09256-c396-41b9-9ad6-26d1076e9cb3"), "محي آباد", 29 },
                    { 1180, new Guid("c0d3bdfc-837c-4395-b128-0157cd2c2e20"), "محمد آباد", 29 },
                    { 1179, new Guid("a6603fef-5b02-4c66-9582-96432a5306e5"), "ماهان", 29 },
                    { 1178, new Guid("3db2074c-eab5-4c03-bebe-46c02739837d"), "لاله زار", 29 },
                    { 1177, new Guid("96e9683f-a0cc-4c85-bf6b-630445ea4679"), "قلعه گنج", 29 },
                    { 1176, new Guid("ae8780de-e539-433f-afd4-51fc7c3668b2"), "فهرج", 29 },
                    { 1175, new Guid("ab3fb5e9-1e64-4294-b55c-9118b257d0fd"), "فارياب", 29 },
                    { 1182, new Guid("7c8efd22-65c0-48f2-a177-14fc6ae54801"), "مردهک", 29 },
                    { 1174, new Guid("da70d526-920b-452b-b23d-0ae3819e4e9d"), "عنبر آباد", 29 },
                    { 1172, new Guid("f6b0f964-d2bc-46e8-9486-d808a0d23c08"), "شهر بابک", 29 },
                    { 1171, new Guid("9a79fe53-4101-4c3f-b76c-bc7707850e82"), "شهداد", 29 },
                    { 1170, new Guid("a9a91471-fcbb-49b8-beab-d87611adcc14"), "سيرجان", 29 },
                    { 1169, new Guid("f6552a98-44da-4b9c-b8bc-f2500e7865b0"), "زيد آباد", 29 },
                    { 1168, new Guid("dee63d13-0b19-4db9-87a8-c0555f637aa5"), "زهکلوت", 29 },
                    { 1167, new Guid("d21560c0-1ef2-4403-b21e-232c842292dd"), "زنگي آباد", 29 },
                    { 1166, new Guid("9b221738-70c5-41d6-ad03-b914515ae6b6"), "زرند", 29 },
                    { 1173, new Guid("48ac8b62-a34a-4fd2-bc9e-905369a56f4c"), "صفائيه", 29 },
                    { 1087, new Guid("d349ce61-2026-4e20-8148-aa07da95ca0b"), "لوندويل", 27 },
                    { 1183, new Guid("7c8d9e29-0d74-49a2-8678-b046213d6c34"), "مس سرچشمه", 29 },
                    { 1185, new Guid("a60939a6-489a-4698-8092-b92048cdd260"), "نجف شهر", 29 },
                    { 1201, new Guid("b7d869f6-4060-442d-9849-ce3454342b4a"), "کيانشهر", 29 },
                    { 1200, new Guid("6cdba23d-4d57-4faa-b912-a193966c8931"), "کوهبنان", 29 },
                    { 1199, new Guid("b288433c-b781-456c-af18-edf0ea76bde3"), "کهنوج", 29 },
                    { 1198, new Guid("2639ff94-3a1e-412f-b5d6-26c85941a948"), "کشکوئيه", 29 },
                    { 1197, new Guid("db51e36c-55a0-417f-a795-dfbdbd940974"), "کرمان", 29 },
                    { 1196, new Guid("e0d27dbc-115a-4906-8e85-6c5c6005d005"), "کاظم آباد", 29 },
                    { 1195, new Guid("4c41ff87-69a9-4abf-8146-eb68021ab526"), "چترود", 29 },
                    { 1184, new Guid("27bcdd22-88c3-4a01-b9d7-c0cbc5dc90fa"), "منوجان", 29 },
                    { 1194, new Guid("7b1076fb-0a2b-40c1-87d0-f9eb43c7fa6a"), "پاريز", 29 },
                    { 1192, new Guid("faff05c9-2e47-4e67-a5f2-7a71f566c9d9"), "هنزا", 29 },
                    { 1191, new Guid("99f4509f-6123-4539-a887-7e45230417ba"), "هماشهر", 29 },
                    { 1190, new Guid("fb57ad66-d1cb-481b-949c-f9b592af32aa"), "هجدک", 29 },
                    { 1189, new Guid("60251136-83e9-4862-ae98-c344b18ee456"), "نگار", 29 },
                    { 1188, new Guid("b83a5475-4857-4984-a08e-6b08ef4dca11"), "نودژ", 29 },
                    { 1187, new Guid("6cafaf7c-6e73-4100-bffb-a714a3d9e020"), "نظام شهر", 29 },
                    { 1186, new Guid("ba8bca05-3b7b-4b54-a4c9-6b917f65f60e"), "نرماشير", 29 },
                    { 1193, new Guid("19354046-dc27-4ea9-9f27-3072be5d309d"), "يزدان شهر", 29 },
                    { 1086, new Guid("1fcfb93e-7bc4-4565-9e32-781ff0112765"), "لولمان", 27 },
                    { 1085, new Guid("9c6445a2-59ea-43b4-8097-b1eefe339d42"), "لوشان", 27 },
                    { 1084, new Guid("0bc3ad4f-25ae-4a1a-aa8e-a719e9814fb2"), "لنگرود", 27 },
                    { 984, new Guid("d3d9db71-4566-432e-ae30-69f875c44a88"), "بندر عباس", 25 },
                    { 983, new Guid("1c680e22-5290-4a0d-a239-58b21c23e4a4"), "بندر جاسک", 25 },
                    { 982, new Guid("7b141073-ed27-4a83-8e97-6e31467bca2d"), "بستک", 25 },
                    { 981, new Guid("635a9ec0-6204-4d37-9b5d-381b4c9c50dd"), "ابوموسي", 25 },
                    { 980, new Guid("9fa6f361-6db4-4cbe-ae6d-176c9cdf260f"), "گيلانغرب", 24 },
                    { 979, new Guid("4758caaf-41aa-4191-900a-6c1221f0bd54"), "گودين", 24 },
                    { 978, new Guid("7274b535-8b20-46ae-a3b4-27a46575d0a8"), "گهواره", 24 },
                    { 977, new Guid("daa932d3-01fe-4d45-aaeb-29ef149a7be4"), "کوزران", 24 },
                    { 976, new Guid("1e5a55e4-90d7-494f-a6fd-794022d75c0a"), "کنگاور", 24 },
                    { 975, new Guid("04be587f-9aaa-4961-b344-d16428740082"), "کرند غرب", 24 },
                    { 974, new Guid("82e2885c-5d05-4816-b761-689dc7368439"), "کرمانشاه", 24 },
                    { 973, new Guid("45213eca-9220-439d-866d-670e3c048882"), "پاوه", 24 },
                    { 972, new Guid("c1f4ccaa-8432-4e45-8949-605f37509126"), "هلشي", 24 },
                    { 971, new Guid("64db8cbc-6cf7-4ec2-9be4-f520bcc14c55"), "هرسين", 24 },
                    { 970, new Guid("b2dae3cd-3950-4d12-ba6b-0a9d9f5d10d5"), "نوسود", 24 },
                    { 985, new Guid("9d344f68-ae24-4306-99df-264b41f80e5e"), "بندر لنگه", 25 },
                    { 986, new Guid("a65ea6df-2709-4f90-8a57-ac4523f51807"), "بيکاه", 25 },
                    { 987, new Guid("54133e21-5727-45d5-890c-a4380bf1e3f0"), "تازيان پائين", 25 },
                    { 988, new Guid("8da49ed7-f7ae-4d4e-94f7-b4decaa69b05"), "تخت", 25 },
                    { 1004, new Guid("e99441fd-bce0-48ba-a20d-893711e2f759"), "فين", 25 },
                    { 1003, new Guid("9c7129ac-4f55-446a-8e3a-39fe565b8f8e"), "فارغان", 25 },
                    { 1002, new Guid("328589ea-4f9b-4b31-a91d-7f5ead391521"), "سيريک", 25 },
                    { 1001, new Guid("ecacd44e-6896-4f4e-9aea-b8fb4ca41ef3"), "سوزا", 25 },
                    { 1000, new Guid("286c57ae-4982-4615-859d-cce415e116a7"), "سندرک", 25 }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityGUID", "Name", "ProvinceID" },
                values: new object[,]
                {
                    { 999, new Guid("aae70142-ef99-4557-84d9-761097c883bf"), "سرگز", 25 },
                    { 998, new Guid("419fb680-560f-4a2e-8937-bae60d1b4bd9"), "سردشت", 25 },
                    { 969, new Guid("4ab97fe3-438e-42b0-86c2-d309352c7b7b"), "نودشه", 24 },
                    { 997, new Guid("0c79431c-6246-4677-ba0c-19f8728a469e"), "زيارتعلي", 25 },
                    { 995, new Guid("c606f527-9ced-4aaf-93ba-4a4c98976eb4"), "دهبارز", 25 },
                    { 994, new Guid("1114927d-ca66-4e53-9ec5-19d93119917f"), "دشتي", 25 },
                    { 993, new Guid("7ff864e9-ff84-4661-9cf1-4e25819d9371"), "درگهان", 25 },
                    { 992, new Guid("e9f0f160-4731-415b-bdfb-df723aee228d"), "خمير", 25 },
                    { 991, new Guid("343d4835-4f7b-41be-bbe6-43f8792824ae"), "حاجي آباد", 25 },
                    { 990, new Guid("5ecac553-0b23-47e3-969c-40a3eb6e171f"), "جناح", 25 },
                    { 989, new Guid("55b1563b-c6c5-4fc9-b3e9-d1cbfe1fbcf2"), "تيرور", 25 },
                    { 996, new Guid("11fa0d30-8e4b-4e8f-bcfc-4b4035bf1cb2"), "رويدر", 25 },
                    { 968, new Guid("24c3fac2-e589-4bd6-88cd-4cab38ffdfd2"), "ميان راهان", 24 },
                    { 967, new Guid("a9798f76-d9dc-4742-bfec-6ddd8634b19f"), "قصر شيرين", 24 },
                    { 966, new Guid("e3a65f92-5c7f-4959-80aa-68bbc2eba642"), "صحنه", 24 },
                    { 945, new Guid("4fdbefcb-2502-4c19-84a2-1f2f7b11345a"), "کوهنجان", 23 },
                    { 944, new Guid("a89a9fa1-aac4-40e5-a991-4d1426f95095"), "کوار", 23 },
                    { 943, new Guid("d4350afc-ba66-492e-86d2-8e54400bbfcb"), "کنار تخته", 23 },
                    { 942, new Guid("d2f86329-f7bb-420d-a35c-111afbb0b8b7"), "کره اي", 23 },
                    { 941, new Guid("421d21a9-ca63-4932-97bc-98ebc21dd1f7"), "کامفيروز", 23 },
                    { 940, new Guid("869fb78f-2912-4c1c-b0ec-b7d10445fd81"), "کازرون", 23 },
                    { 939, new Guid("4c29df35-d230-4025-8bd6-bb0905a836eb"), "کارزين", 23 },
                    { 946, new Guid("bd61168a-df5c-4d84-a27c-eef89cb8c7d8"), "کوپن", 23 },
                    { 938, new Guid("570cc5b9-6e04-4182-bf40-9907bd4898ca"), "وراوي", 23 },
                    { 936, new Guid("9f8c13df-4c31-47ab-b176-57bfb22e65d0"), "ني ريز", 23 },
                    { 935, new Guid("bf300307-4453-4cdf-84da-57786927406f"), "نورآباد", 23 },
                    { 934, new Guid("c7d2ed9e-f759-4c60-bdff-7f30a06165de"), "نودان", 23 },
                    { 933, new Guid("e309365f-7214-494c-8d84-03991c666d3c"), "نوجين", 23 },
                    { 932, new Guid("04370a41-f7cb-4c76-b623-111cc2d5f8c8"), "نوبندگان", 23 },
                    { 614, new Guid("52c9cf42-b467-423b-a07b-4e4ee24af191"), "اردستان", 19 },
                    { 930, new Guid("41e9d9d5-1b59-4e3b-b65e-4209d11c9027"), "ميانشهر", 23 },
                    { 937, new Guid("73d0fec2-8671-4d22-8592-b57d49279d33"), "هماشهر", 23 },
                    { 1005, new Guid("b655be91-bab2-45ba-8eb7-ccd73cb6e4ca"), "قشم", 25 },
                    { 947, new Guid("339032d8-f2c4-4efb-8a33-435c8a4f388c"), "گراش", 23 },
                    { 949, new Guid("ff49b4f0-860a-40db-9fb9-850974f98df5"), "ازگله", 24 },
                    { 965, new Guid("3f336959-ed8e-46aa-9e66-35177c5fbe98"), "شاهو", 24 },
                    { 964, new Guid("befc00f8-0b5e-4f2c-8f9b-887a30f36ec9"), "سومار", 24 },
                    { 963, new Guid("c8ec1454-72ee-4935-9257-00218feec017"), "سنقر", 24 },
                    { 962, new Guid("382e5def-21be-412a-a75d-f82e524632b0"), "سطر", 24 },
                    { 961, new Guid("b7839e04-f8e2-4ef8-8ac0-242a9ee31c70"), "سرمست", 24 },
                    { 960, new Guid("df05702f-c8df-4372-a0e3-0bf538b6eb8a"), "سر پل ذهاب", 24 },
                    { 959, new Guid("5129da87-cafb-45e3-82d4-d97a450c3189"), "ريجاب", 24 },
                    { 948, new Guid("276fd2f7-6845-4f9b-8930-777654472dd3"), "گله دار", 23 },
                    { 958, new Guid("bb1a4b2e-ea5f-4f6c-8c39-1a22b686f97a"), "روانسر", 24 },
                    { 956, new Guid("f61d4983-f701-4e6e-845e-c8da46ba5e2f"), "حميل", 24 },
                    { 955, new Guid("769aec3e-a0dd-4742-8293-67ce9fb8e9b8"), "جوانرود", 24 },
                    { 954, new Guid("59f44eb9-2299-4279-9488-620d5d96a1df"), "تازه آباد", 24 },
                    { 953, new Guid("63f32145-ff92-41fc-887a-b7ea94da02ec"), "بيستون", 24 },
                    { 952, new Guid("06a7b0f6-dac5-487f-b37d-1282123b1fed"), "باينگان", 24 },
                    { 951, new Guid("203f8f01-3fbc-4d34-8c02-625899d24413"), "بانوره", 24 },
                    { 950, new Guid("b7ba1af3-ff3c-42ea-afae-a041c81b7cde"), "اسلام آباد غرب", 24 },
                    { 957, new Guid("ae1d9a6c-ceab-4690-8b6e-a8df95ece726"), "رباط", 24 },
                    { 928, new Guid("3d1b11ac-5870-476c-800a-6396c7d74494"), "مصيري", 23 },
                    { 1006, new Guid("b01ef76b-095d-4e09-9dde-c995afa23a72"), "قلعه قاضي", 25 },
                    { 1008, new Guid("11045327-f83c-4456-a2c7-5dc9cf50e843"), "ميناب", 25 },
                    { 1063, new Guid("e8a55a1b-ec33-4f91-ac7f-d2b193311083"), "جيرنده", 27 },
                    { 1062, new Guid("16ab278b-0375-4f66-9314-c222d3f1a719"), "توتکابن", 27 },
                    { 1061, new Guid("9f380186-9def-4ed4-a307-692f5fcc448a"), "بندر انزلي", 27 },
                    { 1060, new Guid("020de4ab-7a37-429e-9382-e261f652f2d2"), "بره سر", 27 },
                    { 1059, new Guid("ed4b92c5-7017-4290-b3f8-8b9e8450bf07"), "بازار جمعه", 27 },
                    { 1058, new Guid("bb4234a0-d24f-4ddf-94c5-53e3c21e3a6e"), "املش", 27 },
                    { 1057, new Guid("2cbd4b1a-52b5-45ff-bdc9-76dba62e0282"), "اطاقور", 27 },
                    { 1056, new Guid("595a03c6-aef4-4bcc-85eb-cd78682e22c4"), "اسالم", 27 },
                    { 1055, new Guid("6d0fb387-1afb-48b7-a296-f500a9e6b906"), "احمد سرگوراب", 27 },
                    { 1054, new Guid("15043c9d-c9e5-4db5-aa41-a5b2b2d9f816"), "آستانه اشرفيه", 27 },
                    { 1053, new Guid("bdde9d8e-fb56-46f4-94a3-b458cfa858e0"), "آستارا", 27 },
                    { 1052, new Guid("7841e547-fa72-4eeb-ac5f-601a0a2430ae"), "کميجان", 26 },
                    { 1051, new Guid("1cef754a-7cc5-410b-9f30-5741925e2c4b"), "کارچان", 26 },
                    { 1050, new Guid("3ac0536a-a2bb-4338-a366-5fa7cb93d15a"), "پرندک", 26 },
                    { 1049, new Guid("d0a66241-192c-4416-8445-d3d6fc50bb4e"), "هندودر", 26 },
                    { 1064, new Guid("3c38adf4-4451-4b83-80e4-037ad41a3318"), "حويق", 27 },
                    { 1065, new Guid("5467ce24-da99-4108-b3b8-cd571642a987"), "خشکبيجار", 27 },
                    { 1066, new Guid("b68f1578-6e7d-40ef-98df-edd065368316"), "خمام", 27 },
                    { 1067, new Guid("474da862-0b42-4609-9ba3-3bac8d8f6734"), "ديلمان", 27 },
                    { 1083, new Guid("52e07eaf-1fe2-42a9-867b-03a4c7f12172"), "لشت نشاء", 27 },
                    { 1082, new Guid("fdfabdeb-4403-4f74-b392-6dbc72ca14be"), "لاهيجان", 27 },
                    { 1081, new Guid("d293a334-fe44-4cc3-a283-536c45dffc71"), "فومن", 27 },
                    { 1080, new Guid("e3b96a23-e56b-4505-b0c0-e1054f1dbda4"), "صومعه سرا", 27 },
                    { 1079, new Guid("63966e64-9fdb-462b-ab70-91dd23f45d40"), "شلمان", 27 },
                    { 1078, new Guid("8c4cd6b1-19d0-4b85-9c64-146ee73fb8f1"), "شفت", 27 },
                    { 1077, new Guid("73fa9b9c-2ceb-4192-a168-d7cfe56d33fa"), "سياهکل", 27 },
                    { 1048, new Guid("a29e286d-c289-4afb-b0cd-57dd5e0e3e51"), "نيمور", 26 },
                    { 1076, new Guid("78b56b43-e939-4263-926d-12b622efaab3"), "سنگر", 27 },
                    { 1074, new Guid("1d926246-ae02-4409-9346-6af675c11b1f"), "رودبنه", 27 },
                    { 1073, new Guid("affe675f-5dfa-4907-8859-f215064037f0"), "رودبار", 27 },
                    { 1072, new Guid("be70bbec-0a71-4175-afd3-474c5f30a237"), "رضوانشهر", 27 },
                    { 1071, new Guid("e02113cb-638e-4ac8-b289-1cbdfdd6c59f"), "رشت", 27 },
                    { 1070, new Guid("360958d4-792e-41fc-bc6a-99692383f7f9"), "رستم آباد", 27 },
                    { 1069, new Guid("f51e6b66-c69c-4399-85de-842f1480de96"), "رحيم آباد", 27 },
                    { 1068, new Guid("b886299a-d8d3-4e88-9926-5433afb2cd4e"), "رانکوه", 27 },
                    { 1075, new Guid("6b9c3d3d-bc61-4072-aac2-278d3ec6d903"), "رودسر", 27 },
                    { 1047, new Guid("55c073e4-acaa-47d5-adbd-3894c9495f93"), "نوبران", 26 },
                    { 1046, new Guid("158112c3-f57b-4ca1-b5d3-f3127add6da1"), "نراق", 26 },
                    { 1045, new Guid("d19cdf19-940f-42d2-b345-5a529f085a89"), "ميلاجرد", 26 },
                    { 1024, new Guid("64ee0fb1-c636-494f-ad5e-e7da7b48a3d0"), "تفرش", 26 },
                    { 1023, new Guid("c00139fb-9c3e-40b0-a464-58ac32feb83d"), "اراک", 26 },
                    { 1022, new Guid("5a208dc9-1631-4879-a3b4-e3bf02a66655"), "آوه", 26 },
                    { 1021, new Guid("466bd9ad-fab5-4109-ac10-7c432eb88ea9"), "آشتيان", 26 },
                    { 1020, new Guid("8018f123-e91e-46aa-a9c1-9121bf23b797"), "آستانه", 26 },
                    { 1019, new Guid("5512192e-4f4b-4b42-9264-be0c44a09a63"), "گوهران", 25 },
                    { 1018, new Guid("a9d55c2e-b3dc-4a6f-8c61-2cfaff4a8af5"), "گروک", 25 },
                    { 1025, new Guid("d081b0e6-3ac9-43ea-b444-6d8d8ce5582f"), "توره", 26 },
                    { 1017, new Guid("013e4f69-9128-42ec-8a12-a3c88ab64285"), "کيش", 25 },
                    { 1015, new Guid("81444dbc-d001-4c6f-b098-b236d4579165"), "کوشکنار", 25 },
                    { 1014, new Guid("e9795fd1-bf52-4e72-937e-2d55a72039c8"), "کوخردهرنگ", 25 },
                    { 1013, new Guid("c6eccd55-7d33-4cf2-961d-4467f602c9fb"), "کنگ", 25 },
                    { 1012, new Guid("1880d8c0-3eee-4db2-a754-acb82171beb0"), "چارک", 25 },
                    { 1011, new Guid("f4095bc8-df54-4b17-aa9d-78ab532de8fb"), "پارسيان", 25 },
                    { 1010, new Guid("209f4bb4-7f7a-49d6-bcc9-2f4a95191537"), "هشتبندي", 25 },
                    { 1009, new Guid("f05156a2-97d5-471a-ba30-cdb76d8de526"), "هرمز", 25 },
                    { 1016, new Guid("ae8ce78b-84b7-4577-9df0-edf568836be9"), "کوهستک", 25 },
                    { 1007, new Guid("5fe51476-e6ab-4bbe-bd4f-7552cda24aea"), "لمزان", 25 },
                    { 1026, new Guid("845c6540-d7f0-4a04-96fd-c98ca0d0eadb"), "جاورسيان", 26 },
                    { 1028, new Guid("bd0e743e-bac7-4da5-9313-b8cd3a2a8fef"), "خمين", 26 },
                    { 1044, new Guid("9e14e9c2-f316-4dfe-83b6-d88cd270fd8b"), "محلات", 26 },
                    { 1043, new Guid("59502bcf-3916-49dd-8952-a8498cc1e35a"), "مامونيه", 26 },
                    { 1042, new Guid("bfa03057-84f9-4910-ab0c-ac2960b6a6db"), "قورچي باشي", 26 },
                    { 1041, new Guid("4a20719f-0e88-4e1f-b10b-3a8e9bd6d624"), "فرمهين", 26 },
                    { 1040, new Guid("1e2c2cef-eade-452a-9998-b568e197d5f9"), "غرق آباد", 26 },
                    { 1039, new Guid("b91343ac-ce0a-4882-8663-9daee601866f"), "شهر جديد مهاجران", 26 },
                    { 1038, new Guid("532e5b5b-b31c-40bb-b3b8-e274ee56171f"), "شهباز", 26 },
                    { 1027, new Guid("9ec84650-fd16-4dff-802f-ac1daa77cf08"), "خشکرود", 26 },
                    { 1037, new Guid("c7a1a2cf-4892-4192-b08b-ab843d3a1e5d"), "شازند", 26 },
                    { 1035, new Guid("b232ee50-e0fd-46a4-addd-3ead9b765bd0"), "ساروق", 26 },
                    { 1034, new Guid("80dbced9-bffd-48fd-be13-6b4576002765"), "زاويه", 26 },
                    { 1033, new Guid("2729bf28-250b-42d6-b9dc-37281c6f7c28"), "رازقان", 26 },
                    { 1032, new Guid("ca0b2baf-33e4-4b7c-a0e8-a1c629a4c0cc"), "دليجان", 26 },
                    { 1031, new Guid("539429e1-fc84-4850-bc07-f07d51365f0e"), "داود آباد", 26 },
                    { 1030, new Guid("0ede83f7-10f2-43de-b7b4-94c2d2a14c87"), "خنداب", 26 },
                    { 1029, new Guid("aa0b8a9c-fcb1-4cb1-bc65-7a6b535b74ef"), "خنجين", 26 },
                    { 1036, new Guid("e289620b-091c-45d1-9a2a-abe5b24d035c"), "ساوه", 26 },
                    { 613, new Guid("bcb98b37-bc9a-4a86-aded-2d3939517442"), "ابوزيد آباد", 19 },
                    { 609, new Guid("d3fdd9c6-34d5-4eae-bf6b-a2625f67bcd9"), "گرمي", 18 },
                    { 611, new Guid("2c011e3b-673a-4101-99ee-43d6083d28dc"), "آران و بيدگل", 19 },
                    { 207, new Guid("4e5d3e29-8b41-4fe4-af61-fe4af2bea140"), "سلامي", 8 },
                    { 206, new Guid("9f8f8092-badd-4c84-a1a4-459ec361574c"), "سفيد سنگ", 8 },
                    { 205, new Guid("87a8af02-4c60-4a61-9368-9c89096e5d9f"), "سرخس", 8 },
                    { 204, new Guid("2e6c9ea1-7825-4435-935d-b540b5944154"), "سبزوار", 8 },
                    { 203, new Guid("580eaa94-3d5d-4ac6-bfd8-71a607b26043"), "ريوش", 8 },
                    { 202, new Guid("a3c248b8-ce7f-4258-97b8-6885c4f53fc6"), "روداب", 8 },
                    { 201, new Guid("5d2b7ed6-0205-4d96-9778-ff42f2f43e98"), "رضويه", 8 },
                    { 200, new Guid("4496e85e-7a21-4b4e-b1c7-d08794f65513"), "رشتخوار", 8 },
                    { 199, new Guid("c07c17ac-a9a4-4e11-ac53-a8906e580c38"), "رباط سنگ", 8 },
                    { 198, new Guid("4813530d-8a04-4e4b-afdd-f8c9323203d0"), "دولت آباد", 8 },
                    { 197, new Guid("74424480-f5af-4240-b175-d70ffbfe1337"), "درگز", 8 },
                    { 196, new Guid("e0a045b1-79b9-4dde-9439-a69079f57861"), "درود", 8 },
                    { 195, new Guid("923f7948-3e29-4ca5-9bbc-0ca3acf706d4"), "داورزن", 8 },
                    { 194, new Guid("9bc17158-6a90-4fa2-96fc-c08cfd2fda4d"), "خواف", 8 },
                    { 193, new Guid("871f741d-612a-4824-b610-6dccbe7f7df8"), "خليل آباد", 8 },
                    { 208, new Guid("6df0b189-28aa-4bbf-bd57-07bea27bb846"), "سلطان آباد", 8 },
                    { 192, new Guid("db9ffdf6-60ba-41f2-9b26-e10f4efcaf1d"), "خرو", 8 },
                    { 209, new Guid("7e6c7bc9-a0e3-423a-8e84-d573579820f5"), "سنگان", 8 },
                    { 211, new Guid("32796d09-00f3-4f91-86e0-11b6015e3a4b"), "شانديز", 8 },
                    { 226, new Guid("7f224e25-2ecb-4dbf-940d-b1c08608ebbb"), "لطف آباد", 8 },
                    { 225, new Guid("e91fc4ab-8370-4b43-a126-54f5352610f9"), "قوچان", 8 },
                    { 224, new Guid("400930a9-daec-4013-a6d3-fe663eb53ea8"), "قلندر آباد", 8 },
                    { 223, new Guid("a7073338-e845-49cd-af43-df22359ad5b8"), "قدمگاه", 8 },
                    { 222, new Guid("5bd60117-44b7-40eb-a1e8-1b84ed2e024d"), "قاسم آباد", 8 },
                    { 221, new Guid("11f596da-8e6b-4469-9aff-1a359b28bfa6"), "فيض آباد", 8 },
                    { 220, new Guid("9d273020-295a-4807-87ca-41d9614570be"), "فيروزه", 8 },
                    { 219, new Guid("5c8deaa8-1697-4256-ab30-0573289bd5dc"), "فريمان", 8 },
                    { 218, new Guid("2c5c2b3e-5e26-4e71-a3d6-7c03e1acd5a9"), "فرهاد گرد", 8 },
                    { 217, new Guid("f85b090d-173c-49d7-aa8b-cb7536866a2e"), "عشق آباد", 8 },
                    { 216, new Guid("0599df2d-9b61-42ca-a1c1-2eb954de87b7"), "طرقبه", 8 },
                    { 215, new Guid("5ecf19d7-4f2a-4b9c-9b66-faf9dc0bce35"), "صالح آباد", 8 },
                    { 214, new Guid("a6392454-3f6b-42bf-a1c9-801d9c24c2bf"), "شهرآباد", 8 },
                    { 213, new Guid("4bc988f6-9eb1-4a33-bf74-c68fb493cd2f"), "شهر زو", 8 },
                    { 212, new Guid("1d8f4826-d3d1-470c-88f5-45bfccdd9ef7"), "ششتمد", 8 },
                    { 210, new Guid("dc067f7a-2e2a-4681-82d6-bf3802dc55a8"), "شادمهر", 8 },
                    { 227, new Guid("c3843c0a-6a51-4a51-ad5a-bc4d4d29e623"), "مزدآوند", 8 },
                    { 191, new Guid("089e9f3c-ef20-4359-ba26-a689990ff2d8"), "جنگل", 8 },
                    { 189, new Guid("56554cb4-5329-42e4-889b-038b91a5dc7d"), "تربت حيدريه", 8 },
                    { 169, new Guid("22c86ac2-8a39-406d-bdac-373d49522767"), "نازک عليا", 7 },
                    { 168, new Guid("af1ae943-8361-4f51-92d5-1a3d17d404c7"), "ميرآباد", 7 },
                    { 167, new Guid("6799d280-58fa-48c3-b3df-0154e21180ec"), "مياندوآب", 7 },
                    { 166, new Guid("0a59dcd3-af24-4679-9307-97057ac14eb3"), "مهاباد", 7 },
                    { 165, new Guid("83aba8ad-a45d-4975-9b26-d566261e9d05"), "مرگنلر", 7 },
                    { 164, new Guid("92a6cba9-7cc0-4ab1-96fe-6f0f6e432ab0"), "محمود آباد", 7 },
                    { 163, new Guid("2daf70be-5ba4-4675-b1ed-00de44f1e9c1"), "محمد يار", 7 },
                    { 162, new Guid("6b31cb01-2e61-466d-b9ac-fcbe6bc46da3"), "ماکو", 7 },
                    { 161, new Guid("76f7d6eb-754c-4177-a23b-32dbe3f3c86e"), "قوشچي", 7 },
                    { 160, new Guid("935334d9-982a-4280-940e-3996fea296cf"), "قطور", 7 },
                    { 159, new Guid("9758cae2-961d-4c59-a79e-7e7e9bae49d1"), "قره ضياء الدين", 7 },
                    { 158, new Guid("a950c6e5-f789-4355-a748-af451b6529be"), "فيرورق", 7 },
                    { 157, new Guid("5931ef84-cc97-4d85-af71-40902254a972"), "شوط", 7 },
                    { 156, new Guid("1063d50a-e5e6-4b2a-ad19-6076c167759f"), "شاهين دژ", 7 },
                    { 155, new Guid("df2f2520-76b2-4866-8fd7-d32e00f55875"), "سيه چشمه", 7 },
                    { 170, new Guid("0b5dc863-67e1-4154-bf4c-296b4b2b557d"), "نالوس", 7 },
                    { 190, new Guid("bf9a3826-c8b8-4f1d-98ed-02bbf5bf9d39"), "جغتاي", 8 },
                    { 171, new Guid("93ff452e-9963-41bb-9478-d96f74ee3e17"), "نقده", 7 },
                    { 173, new Guid("4c98ea70-4b6b-4222-91b5-35eefd38e9ca"), "پلدشت", 7 },
                    { 188, new Guid("6edd181e-9cd5-45cd-8437-f492ed9ec8e3"), "تربت جام", 8 },
                    { 187, new Guid("482fe1f0-4695-4169-9bf6-f51b20fb18c1"), "تايباد", 8 },
                    { 186, new Guid("71b281f5-3655-4ddd-a738-a0fe8b4a260a"), "بيدخت", 8 },
                    { 185, new Guid("8599b74b-ef0b-49dd-ba22-9f1174c23a63"), "بردسکن", 8 },
                    { 184, new Guid("1e56ed63-8afe-4b5e-971e-86c0508b7b98"), "بجستان", 8 },
                    { 183, new Guid("18892bac-c57f-4acb-930d-871ed190b4d8"), "بايک", 8 },
                    { 182, new Guid("b3db6ba5-299d-479b-902d-0b1be20adc9e"), "بار", 8 },
                    { 181, new Guid("ce7031d2-9720-4f84-a0e9-6493932ae341"), "باخرز", 8 },
                    { 180, new Guid("a7b8b8d3-7db1-4986-83fb-7ee7be862d68"), "باجگيران", 8 },
                    { 179, new Guid("d0a7b812-304d-4a05-84f9-8e1649497401"), "انابد", 8 },
                    { 178, new Guid("1675ece4-cf7e-4c75-9ecb-027a55ca8888"), "احمدآباد صولت", 8 },
                    { 177, new Guid("6eff9277-70f3-4c4b-a441-e7f89fe086c2"), "گردکشانه", 7 },
                    { 176, new Guid("cdc64517-07d1-4fab-8a08-b33adcea1411"), "کشاورز", 7 },
                    { 175, new Guid("60cdebd9-9583-4e19-896c-db1d8d1e978e"), "چهار برج", 7 },
                    { 174, new Guid("5cd05f00-c781-4f4c-b9d4-a513ad09dbf9"), "پيرانشهر", 7 },
                    { 172, new Guid("e4f23fe8-72fe-4a57-955d-52cb5fb5226d"), "نوشين", 7 },
                    { 228, new Guid("1939518c-e1de-42db-ae49-0b3a906efc03"), "مشهد", 8 },
                    { 229, new Guid("6a0b6630-8d69-4cea-915f-64d859c70806"), "مشهدريزه", 8 },
                    { 230, new Guid("d49e09b3-2d25-4244-b929-a36e6d6b913f"), "ملک آباد", 8 },
                    { 284, new Guid("e7323243-d23c-41c2-9e7b-ef1f425c75f9"), "کنارک", 9 },
                    { 283, new Guid("ad5050e9-c33f-44cc-b785-b105b56f2b3d"), "چاه بهار", 9 },
                    { 282, new Guid("bf7ffc35-8d3f-431d-b124-eeacda86b07b"), "پيشين", 9 },
                    { 281, new Guid("f53aa947-6cfe-4920-abb0-0213504f25a3"), "هيدوچ", 9 },
                    { 280, new Guid("c5e100fe-2e12-43d2-ac7e-66d479c84e6b"), "نگور", 9 },
                    { 279, new Guid("862cff50-b6e3-4ebe-b460-fceee48a8dab"), "نيک شهر", 9 },
                    { 278, new Guid("ed7e26aa-75ca-42be-95c5-5da939a53461"), "نوک آباد", 9 },
                    { 277, new Guid("dfde4832-96e3-4478-a270-1e0762c73d5f"), "نصرت آباد", 9 },
                    { 276, new Guid("25d2b4eb-cde6-4c37-88e5-e24a56a329ab"), "ميرجاوه", 9 },
                    { 275, new Guid("6e942b20-6e6f-4bcf-85cf-742d85109bf0"), "مهرستان", 9 },
                    { 274, new Guid("1f78e047-ac6d-4e7e-885a-f099c3e6b598"), "محمدي", 9 },
                    { 273, new Guid("1cdf56ab-613d-4909-8e63-c1d5368dcee1"), "محمدان", 9 },
                    { 272, new Guid("5390a014-34f8-4030-86ef-fed1ce78d612"), "محمد آباد", 9 },
                    { 271, new Guid("6863bd21-cae7-44c0-907e-ea73d8e35cc0"), "قصر قند", 9 },
                    { 270, new Guid("b633547d-e078-4a5d-8dd5-faa13e07e37f"), "فنوج", 9 },
                    { 285, new Guid("f9f51ba9-1b3b-42f0-8ce0-a19588a119b9"), "گشت", 9 },
                    { 269, new Guid("8e3de938-a307-4918-b5bf-7a2eb1550767"), "علي اکبر", 9 },
                    { 286, new Guid("1e88a09d-7207-427c-bfe3-b5a2b383e51e"), "گلمورتي", 9 },
                    { 288, new Guid("74d8e8fc-5d3c-4cd1-9c9e-f71c89cd8736"), "آيسک", 10 },
                    { 303, new Guid("d5821ff8-0e29-4d9d-b5b4-4de436f6713b"), "شوسف", 10 },
                    { 302, new Guid("f2727fe0-5c08-4ce2-b4b0-9d6697519470"), "سه قلعه", 10 },
                    { 301, new Guid("7208b953-4b61-4392-ae43-b8d147af8f1c"), "سربيشه", 10 },
                    { 300, new Guid("24dc0952-609f-4a94-b373-2f330cc69178"), "سرايان", 10 },
                    { 299, new Guid("4cf40229-1055-4f6f-9e8e-41b539e983c7"), "زهان", 10 },
                    { 298, new Guid("01dfbb52-9c36-4e8a-97d7-e81dae5a7981"), "ديهوک", 10 },
                    { 612, new Guid("7fbfff66-5b25-44a0-bb92-b3a264bfcc05"), "ابريشم", 19 },
                    { 296, new Guid("8eb6a49a-2c10-4326-8921-7d56f1821d15"), "خضري دشت بياض", 10 },
                    { 295, new Guid("d7bb869b-03d0-41ad-a09f-c38166cbc89e"), "حاجي آباد", 10 },
                    { 294, new Guid("6ef49fec-1d4d-4e36-bb00-140fe8b7ffc8"), "بيرجند", 10 },
                    { 293, new Guid("fcc87bb3-e497-4ff3-a511-bc501de8acfe"), "بشرويه", 10 },
                    { 292, new Guid("f33a0fce-9dd3-43b9-9bfd-58dce2b05790"), "اسلاميه", 10 },
                    { 291, new Guid("1e229244-0031-4e92-a960-9ec759ac8b4c"), "اسفدن", 10 },
                    { 290, new Guid("de807835-e4a4-49b2-aae3-dc542d39a595"), "اسديه", 10 },
                    { 289, new Guid("4a421890-50c2-4e33-a95b-01f8e31258a6"), "ارسک", 10 },
                    { 287, new Guid("b40195ac-42b6-419d-a8b1-115fb1512c52"), "آرين شهر", 10 },
                    { 268, new Guid("1de388fc-b002-4348-9abb-67504b2f450c"), "سيرکان", 9 },
                    { 267, new Guid("a7d8502a-b7f2-4981-bfd0-abcef0596026"), "سوران", 9 },
                    { 266, new Guid("d2f0022f-1605-46cf-9c2f-f86851909e98"), "سرباز", 9 },
                    { 245, new Guid("29a55bb3-74e6-45da-b5df-c026e0f6a7e2"), "کدکن", 8 },
                    { 244, new Guid("5eee7c66-63ed-440a-a83c-f8b8f07933fa"), "کاشمر", 8 },
                    { 243, new Guid("91f54536-d53f-43db-9edb-b7fb842d765a"), "کاريز", 8 },
                    { 242, new Guid("736e0ed4-9f7d-4fd6-8e81-dd71bd6c11a6"), "کاخک", 8 },
                    { 241, new Guid("57a3bd16-b198-4aa7-85ca-617ca2516f93"), "چکنه", 8 },
                    { 240, new Guid("9c7815b8-b4ae-41aa-8224-8f71b781213b"), "چناران", 8 },
                    { 239, new Guid("74ecc677-4188-4958-b000-dcfeaeac3940"), "چاپشلو", 8 },
                    { 238, new Guid("d8795cab-b59e-40aa-9f90-41f195ea6ce2"), "يونسي", 8 },
                    { 237, new Guid("d99a6427-23ff-4747-9bce-b54a6324bc88"), "همت آباد", 8 },
                    { 236, new Guid("1603e4ed-3095-48ce-9a75-f42c39cf2c0f"), "نيل شهر", 8 },
                    { 235, new Guid("6288dac0-20c5-48f2-bd35-b87beb02786e"), "نيشابور", 8 },
                    { 234, new Guid("951433fd-c49d-493d-9163-535447e3f97a"), "نوخندان", 8 },
                    { 233, new Guid("1f94d409-a857-49f1-9c7f-a8a5a7a295f9"), "نقاب", 8 },
                    { 232, new Guid("5a11177f-873b-4986-a271-7d0daa84bf52"), "نصرآباد", 8 },
                    { 231, new Guid("17a4c26e-d9b9-47cd-9c87-bf6ccd32c21f"), "نشتيفان", 8 },
                    { 246, new Guid("cc1105fc-e9ac-4cc9-8f9d-7a794dc8fbf5"), "کلات", 8 },
                    { 247, new Guid("f111019e-cd7e-4650-abce-c90d9d7224f5"), "کندر", 8 },
                    { 248, new Guid("bf834623-dc12-4d94-ad1a-b99c51e755ca"), "گلمکان", 8 },
                    { 249, new Guid("a3b55056-869a-4914-bb03-584b2359290b"), "گناباد", 8 },
                    { 265, new Guid("04f537a3-940c-4c96-bc2d-a8ba0da42d6e"), "سراوان", 9 },
                    { 264, new Guid("41e6d02e-d376-4f62-b217-b07478b736e0"), "زهک", 9 },
                    { 263, new Guid("c45a0aa1-5632-4969-9857-78d51a30c979"), "زرآباد", 9 },
                    { 262, new Guid("e79ead04-be1a-4166-b35d-c240edac8b75"), "زاهدان", 9 },
                    { 261, new Guid("15009389-77ee-4f8b-9f36-1126e57e3be0"), "زابل", 9 },
                    { 260, new Guid("8583184b-c16b-4e90-be13-3aec7fd6101a"), "راسک", 9 },
                    { 259, new Guid("e111da88-e6ac-42de-98f0-ef8fe24e43dc"), "دوست محمد", 9 },
                    { 154, new Guid("5fdce959-a23a-46da-9a78-f7c5cf3cffad"), "سيمينه", 7 },
                    { 258, new Guid("b8d9ed89-84ae-43ef-9711-8e1d6f388f38"), "خاش", 9 },
                    { 256, new Guid("5d3fa641-0584-474f-acbb-faf947fce473"), "بنجار", 9 },
                    { 255, new Guid("0c27dc52-9b0e-406f-8403-de1edda8a7e5"), "بنت", 9 },
                    { 254, new Guid("b4a77bad-137d-4458-9d35-66d4e0c95ab7"), "بمپور", 9 },
                    { 253, new Guid("ecdbe535-993e-4d8c-b101-07dc1c339933"), "بزمان", 9 },
                    { 252, new Guid("55a406a2-1329-44aa-a3f6-d0853da46376"), "ايرانشهر", 9 },
                    { 251, new Guid("6ef6fa83-9a78-4c1a-9c94-d95eda3878fc"), "اسپکه", 9 },
                    { 250, new Guid("8934ccbc-802f-4267-9378-228136786437"), "اديمي", 9 },
                    { 257, new Guid("ad2b8fe4-bf1f-441a-9c58-5779a9a12a84"), "جالق", 9 },
                    { 153, new Guid("13aeabaa-d49b-4967-83cf-cea58e841773"), "سيلوانه", 7 },
                    { 152, new Guid("a1b845a4-f2ed-4277-80b6-bfefa75d3ea8"), "سلماس", 7 },
                    { 151, new Guid("30cd9324-0f18-49d2-8ce4-711c3ba9f833"), "سرو", 7 },
                    { 54, new Guid("fe8dd094-1b3c-42fa-881a-b91da6b8d8b1"), "پردنجان", 2 },
                    { 53, new Guid("157abd09-5789-4366-95d9-8bed71ff0ed7"), "وردنجان", 2 },
                    { 52, new Guid("f9e9a5f0-44b5-4b4e-8451-ffdf0aaf9eb2"), "هفشجان", 2 },
                    { 51, new Guid("bb7c1572-1520-4f04-a25e-963232535968"), "هاروني", 2 },
                    { 50, new Guid("09325241-f7c5-47a2-97a7-f5c75a9fcd99"), "نقنه", 2 },
                    { 49, new Guid("71d254ef-b498-4244-bf8f-e71674f2caaf"), "نافچ", 2 },
                    { 48, new Guid("88ba71f6-a5f1-46fa-bd06-d4281646c15c"), "ناغان", 2 },
                    { 47, new Guid("cf7639b9-d974-4c05-961c-4d3d98fb7cb1"), "منج", 2 },
                    { 46, new Guid("4fe9eb09-ff89-4015-9301-942d23055d54"), "مال خليفه", 2 },
                    { 45, new Guid("b179f8e5-c219-401e-9b49-8f24153e857a"), "لردگان", 2 },
                    { 44, new Guid("eceb5ab5-ffd3-4a82-ae47-1eff8d0ea177"), "فرخ شهر", 2 },
                    { 43, new Guid("31c44ca3-4c14-485c-8b40-91f7fd8a7b3c"), "فرادنبه", 2 },
                    { 42, new Guid("6a3ba0f6-766c-47db-b2ce-ad2b488e0614"), "فارسان", 2 },
                    { 41, new Guid("47d4c318-325a-4e6b-8e11-9851105d2862"), "طاقانک", 2 },
                    { 40, new Guid("e8496f6c-df27-4841-896f-2b39db7d7eb1"), "صمصامي", 2 },
                    { 55, new Guid("325a3e26-144f-453a-a056-f7ecdc70e87a"), "چليچه", 2 },
                    { 39, new Guid("35521e03-8301-4955-8887-6e259976caa3"), "شهرکرد", 2 },
                    { 56, new Guid("f94861e3-a1ea-4f47-84a7-730768ec0181"), "چلگرد", 2 },
                    { 58, new Guid("79ae471d-d5b4-4b2b-a58c-52813374ade6"), "کيان", 2 },
                    { 73, new Guid("f825c445-9d15-4734-9994-37e9cb1d6afa"), "سنخواست", 3 },
                    { 72, new Guid("76f972ff-7948-4b8b-9d4e-2e9c6f948631"), "زيارت", 3 },
                    { 71, new Guid("7d9fcaad-b784-4042-81e9-3c4a34d9fa5c"), "راز", 3 },
                    { 70, new Guid("e4576bd3-7767-4805-a31f-35ab5f4485cc"), "درق", 3 },
                    { 69, new Guid("865f4931-834f-40d3-8e03-7e81e7d7a830"), "حصارگرمخان", 3 },
                    { 68, new Guid("e60edcb1-67eb-43d2-b872-74349a9b87ed"), "جاجرم", 3 },
                    { 67, new Guid("ba52ca17-9171-4521-8b15-f541f7d1677d"), "تيتکانلو", 3 },
                    { 66, new Guid("f82eade6-9555-4bf1-8ca6-9c7fa1b30264"), "بجنورد", 3 },
                    { 65, new Guid("b21d2bc5-6bb7-4ea1-949c-b036c7f6e7c8"), "ايور", 3 },
                    { 64, new Guid("928822e7-fbcc-4de9-9976-8079dc76b2fe"), "اسفراين", 3 },
                    { 63, new Guid("83727f6f-6b9f-4d42-9bbe-372fdf8ab48d"), "آوا", 3 },
                    { 62, new Guid("652b255a-b2fa-4c63-ab8a-8ff7c607f7ee"), "آشخانه", 3 },
                    { 61, new Guid("ad6fe8b2-c9b7-4e96-8898-b802788ca826"), "گوجان", 2 },
                    { 60, new Guid("273a4a00-e2ac-4809-a2ea-882c9d3f8f78"), "گهرو", 2 },
                    { 59, new Guid("d98a1c59-dd16-4226-a31a-7fa229613e94"), "گندمان", 2 },
                    { 57, new Guid("bdcf5706-0863-4201-a026-c0311d5b01d3"), "کاج", 2 },
                    { 38, new Guid("a0d35178-5423-41ce-8ee2-758690d29c98"), "شلمزار", 2 },
                    { 37, new Guid("07d3fe3a-ccde-4bc8-8715-dffe20c81e0d"), "سورشجان", 2 },
                    { 36, new Guid("5961e84a-6db5-4c51-8df8-e006324df68b"), "سودجان", 2 },
                    { 15, new Guid("185f7d0f-787c-49ad-a108-c87f238ed0e3"), "مهردشت", 1 },
                    { 14, new Guid("56478868-0c4c-471c-a39b-ca73d25f9a11"), "مروست", 1 },
                    { 13, new Guid("c4e6cba3-5399-43df-9e0c-816fb05e4c8f"), "عقدا", 1 },
                    { 12, new Guid("862a4586-4e5c-4045-8e49-17749f88b925"), "شاهديه", 1 },
                    { 11, new Guid("d0830d8f-575c-4a14-bc25-f4670e9e0b01"), "زارچ", 1 },
                    { 10, new Guid("2108f94f-ac9d-4960-b620-7f80f4aac90a"), "خضر آباد", 1 },
                    { 9, new Guid("4eb22e27-38ae-4183-a843-b6f8243acbda"), "حميديا", 1 },
                    { 8, new Guid("af44bb0e-db35-4a5e-b31a-a2246b260d82"), "تفت", 1 },
                    { 7, new Guid("0ea176be-c82f-443a-968b-041c41b59dff"), "بهاباد", 1 },
                    { 6, new Guid("6bfc19ad-8b2e-4d3a-8498-296520afc1bd"), "بفروئيه", 1 },
                    { 5, new Guid("a7102750-e0a7-4195-a267-da01b35f5547"), "بافق", 1 },
                    { 4, new Guid("7e0ffed7-cf10-4868-92a6-7bb8d34320a6"), "اشکذر", 1 },
                    { 3, new Guid("388f0f60-86f6-4644-816f-49e602c225f2"), "اردکان", 1 },
                    { 2, new Guid("38cb394d-5f4e-4033-82e8-9ab8d2761e56"), "احمد آباد", 1 },
                    { 1, new Guid("ac0b6dc8-45a8-4a52-b158-6368ffcf0749"), "ابرکوه", 1 },
                    { 16, new Guid("f52f085f-d928-48d5-a8c9-86fa9754e5db"), "مهريز", 1 },
                    { 17, new Guid("70264603-019c-4f0d-9cc0-aef5a1f20942"), "ميبد", 1 },
                    { 18, new Guid("31546ab4-d1af-424a-85e1-9a98063d2052"), "ندوشن", 1 },
                    { 19, new Guid("eb83e8dd-5f5c-474d-af53-2895c96b754d"), "نير", 1 },
                    { 35, new Guid("40ce9a39-3647-47d4-bb75-eec33835280d"), "سفيد دشت", 2 },
                    { 34, new Guid("91dd2d4e-ad92-4155-a700-213ddaf07024"), "سردشت لردگان", 2 },
                    { 33, new Guid("fc1b7322-5fd5-486d-8c9e-4130289c7006"), "سرخون", 2 },
                    { 32, new Guid("7eccb080-2d2e-4682-9238-ac359397fa0e"), "سامان", 2 },
                    { 31, new Guid("e6d0c637-2bbc-466a-ad44-b1b7df18764c"), "دشتک", 2 },
                    { 30, new Guid("d9162f98-6c98-4f41-b282-94a52a83b48a"), "دستناء", 2 },
                    { 29, new Guid("13918234-0fd1-4a4d-9841-8b17d10b5d2d"), "جونقان", 2 },
                    { 74, new Guid("504b0e30-ba99-4595-adeb-5fdb51917983"), "شوقان", 3 },
                    { 28, new Guid("186c04cf-03e4-48d2-9849-1f6e3f265c51"), "بن", 2 },
                    { 26, new Guid("1a8af783-0af5-484e-aa34-3a472f8964d0"), "بروجن", 2 },
                    { 25, new Guid("50e94e56-5edc-4535-9643-8c016530d9ce"), "بازفت", 2 },
                    { 24, new Guid("306074d9-dbcc-46a3-8622-7ea7c4a19c22"), "باباحيدر", 2 },
                    { 23, new Guid("cb3ffaf4-8857-400d-916e-19b2e36a339c"), "اردل", 2 },
                    { 22, new Guid("7019a782-b0bb-4391-93b8-47da29b93421"), "آلوني", 2 },
                    { 21, new Guid("ac89a78d-c614-4592-90a5-b80ec5b31e6f"), "يزد", 1 },
                    { 20, new Guid("257f41ca-24cf-4162-a10e-fec71a29069f"), "هرات", 1 },
                    { 27, new Guid("0f4d091e-4d2f-4eee-bcc1-29f9ee4e4b3d"), "بلداجي", 2 },
                    { 304, new Guid("30c9fca9-a3c3-4282-aebc-25275166c566"), "طبس", 10 },
                    { 75, new Guid("f5c7c0fa-56e1-4eaf-a635-4a1785f34e04"), "شيروان", 3 },
                    { 77, new Guid("1d027447-91cd-433b-9ea8-530e1bd19760"), "فاروج", 3 },
                    { 131, new Guid("babf4022-418b-4676-aade-05e488d4a606"), "پيرتاج", 6 },
                    { 130, new Guid("3217e6ce-5327-4b09-bb26-b86db9881a3a"), "ياسوکند", 6 },
                    { 129, new Guid("a85ea9e0-688a-4fb8-bda9-27590c7e2afb"), "موچش", 6 },
                    { 128, new Guid("1904d7c6-96fe-4ac4-8853-f4d7f127f17e"), "مريوان", 6 },
                    { 127, new Guid("14944512-039e-4e62-a2b3-7ae2025f908c"), "قروه", 6 },
                    { 126, new Guid("a249efb3-d5a2-4d9f-80a9-c90016d49159"), "صاحب", 6 },
                    { 125, new Guid("4f1dee07-a6b9-4123-bf95-6531d3e28dac"), "شويشه", 6 },
                    { 124, new Guid("f6fd84e2-158f-4f33-a3d7-824aefc44a42"), "سنندج", 6 },
                    { 123, new Guid("6af07759-a6d1-4fbd-b84f-77a7b5c7609b"), "سقز", 6 },
                    { 122, new Guid("57a252b2-b35a-41d9-b075-1f35e4d514b2"), "سريش آباد", 6 },
                    { 121, new Guid("9cb5c660-3f88-4398-a2a7-1db3e1a578b4"), "سرو آباد", 6 },
                    { 120, new Guid("68b7f624-38a5-446b-93dd-db2319dc6d00"), "زرينه", 6 },
                    { 119, new Guid("fbdadabe-38fb-4886-8b83-6f67a4fd1f46"), "ديواندره", 6 },
                    { 118, new Guid("57bcaca9-5f9d-44b5-9764-235777120623"), "دهگلان", 6 },
                    { 117, new Guid("b1bf09dd-e0b8-42c9-931d-6e4605a48fbf"), "دلبران", 6 },
                    { 132, new Guid("6574e386-991a-4b59-95a1-ccd85e823f5f"), "چناره", 6 },
                    { 116, new Guid("b04f724b-2ae1-4a19-b1f3-4bd14fea8960"), "دزج", 6 },
                    { 133, new Guid("bc454815-b795-471f-b946-d4fdc0dfa6ca"), "کامياران", 6 },
                    { 135, new Guid("7909862e-e9c5-4e01-a46e-73cea98076ba"), "کاني سور", 6 },
                    { 150, new Guid("123de9d7-f7e6-414b-b8be-0e4a0189fb11"), "سردشت", 7 },
                    { 149, new Guid("67e751e6-22b4-464b-893e-21fc1f217d8e"), "زرآباد", 7 },
                    { 148, new Guid("5882e4ee-d484-485f-a699-3bc1d575c121"), "ربط", 7 },
                    { 147, new Guid("759892af-e334-4ac7-93cb-630cae72370f"), "ديزج ديز", 7 },
                    { 146, new Guid("9fe818a3-acf4-4e59-b6ed-d8acf0bda379"), "خوي", 7 },
                    { 145, new Guid("218fead6-1ed6-4d0e-a10a-7a45c181c771"), "خليفان", 7 },
                    { 144, new Guid("74f437c6-9576-42e8-8ec2-db6e21093e07"), "تکاب", 7 },
                    { 143, new Guid("1c7c0da0-73ba-4d3c-98ee-5302dee1ae58"), "تازه شهر", 7 },
                    { 142, new Guid("37e09ff2-58fa-4a97-9e2a-748b294a590e"), "بوکان", 7 },
                    { 141, new Guid("1fd8a755-2eee-4e74-a912-8c60e68c1e11"), "بازرگان", 7 },
                    { 140, new Guid("c0b1daed-2e48-4ba6-956c-82b70dbf623b"), "باروق", 7 },
                    { 139, new Guid("6bd475c4-ae8a-43dd-9fbc-99bdcc9e877a"), "ايواوغلي", 7 },
                    { 138, new Guid("9b5b7daf-e6d0-4c5b-9261-0e27d4a91d72"), "اشنويه", 7 },
                    { 137, new Guid("ee5e59b9-7041-48af-ae7e-3519aa8cbb9e"), "اروميه", 7 },
                    { 136, new Guid("03590364-7c10-4e32-ae68-7e2606e7c5d5"), "آواجيق", 7 },
                    { 134, new Guid("56e2b3c1-1cda-4ec1-88bd-e2de8480c2c7"), "کاني دينار", 6 },
                    { 115, new Guid("eaa0f2f9-ba3d-42af-9acd-01ed894f32a4"), "توپ آغاج", 6 },
                    { 114, new Guid("f8a66d57-8015-446e-9f2e-be307194bfcc"), "بيجار", 6 },
                    { 113, new Guid("f00a5e2d-d719-45a2-9ca5-7e18a0a7d58b"), "بوئين سفلي", 6 },
                    { 92, new Guid("4c581a1f-909d-4333-a6a1-17a89a23b80c"), "مشکين دشت", 4 },
                    { 91, new Guid("489ed15c-2a48-4f34-8ba9-be0ca844ffc2"), "محمد شهر", 4 },
                    { 90, new Guid("baaa4310-04d5-4d1b-9fe7-659c97735301"), "ماهدشت", 4 },
                    { 89, new Guid("9a001ed6-1bc2-4eef-8a6b-ec16bec956b1"), "فرديس", 4 },
                    { 88, new Guid("63d06292-a75b-49bd-9046-2f80956b9600"), "طالقان", 4 },
                    { 87, new Guid("9d04f358-34b1-47dd-b359-fc0a111ad8bc"), "شهر جديد هشتگرد", 4 },
                    { 86, new Guid("f7d542b4-da60-477c-88f1-750ca0b6df46"), "تنکمان", 4 },
                    { 85, new Guid("f2a6d8a4-742f-45be-b158-3839efbc4f38"), "اشتهارد", 4 },
                    { 84, new Guid("f923e3e7-8127-4d35-a045-3c2c566d2baa"), "آسارا", 4 },
                    { 83, new Guid("2e05b4c0-b69e-4cbb-b73e-269e39725f67"), "گرمه", 3 },
                    { 82, new Guid("1955a325-ab5b-4b81-a4b8-d157bd70d6ba"), "چناران شهر", 3 },
                    { 81, new Guid("4a7ed99d-6240-4152-a0ed-45e7df9b92f9"), "پيش قلعه", 3 },
                    { 80, new Guid("218e82c8-1ff0-49d7-b1da-5c4e42dd61c8"), "لوجلي", 3 },
                    { 79, new Guid("cb392171-0a2f-4456-8538-1613888b2301"), "قوشخانه", 3 },
                    { 78, new Guid("24f3e72b-bb9b-4d9a-9585-9afa7b60887c"), "قاضي", 3 },
                    { 93, new Guid("a2f3af8e-2b00-43ea-a8f3-ff88a9ef2f3c"), "نظر آباد", 4 },
                    { 94, new Guid("e255f4a6-4d7d-4a8e-8a83-37134d27a77d"), "هشتگرد", 4 },
                    { 95, new Guid("37c17818-e3dc-47ab-94f3-551ecab2dba6"), "چهارباغ", 4 },
                    { 96, new Guid("57436870-6d73-4fee-a1b7-c3810908fa72"), "کرج", 4 },
                    { 112, new Guid("4c591754-b325-423c-ae68-246b15080de6"), "بلبان آباد", 6 },
                    { 111, new Guid("d11a6d71-1cbf-4321-9066-8498ab41a133"), "برده رشه", 6 },
                    { 110, new Guid("edc7b3f7-23f2-4bf9-bea1-02b8b9fd19ef"), "بانه", 6 },
                    { 109, new Guid("aff1afed-98bf-496e-9044-cb7d2f4451df"), "بابارشاني", 6 },
                    { 108, new Guid("ed43be38-7c39-4f21-95b0-b004ffb164f8"), "اورامان تخت", 6 },
                    { 107, new Guid("abd169ee-3ba8-4469-9b9c-960ca11250c0"), "آرمرده", 6 },
                    { 106, new Guid("5318e259-15dc-48d3-a051-6dc89f1f99bb"), "کهک", 5 },
                    { 76, new Guid("bccce536-f62f-4173-877f-22e1691c2ea2"), "صفي آباد", 3 },
                    { 105, new Guid("c37943e8-0af4-4287-9128-154724a82e09"), "قنوات", 5 },
                    { 103, new Guid("12d41324-bd72-4a30-8a33-b28497631513"), "سلفچگان", 5 },
                    { 102, new Guid("6095bde1-17ea-4180-9caa-fbc1a79c7288"), "دستجرد", 5 },
                    { 101, new Guid("4fbc7d3c-a9bf-4bb4-acaf-ea0f366a0cd8"), "جعفريه", 5 },
                    { 100, new Guid("14bb1fa7-e788-411c-81fd-400b6e48e3e6"), "گلسار", 4 },
                    { 99, new Guid("c24130a8-46d2-40b2-89a2-d164e73d85b8"), "گرمدره", 4 },
                    { 98, new Guid("806a13b0-6c21-4586-be44-b8541b902a63"), "کوهسار", 4 },
                    { 97, new Guid("7b185069-6783-44bf-b826-5da5b012b337"), "کمال شهر", 4 },
                    { 104, new Guid("a29456a2-422e-4a45-8fa4-349e940e2dc7"), "قم", 5 },
                    { 305, new Guid("d50a3128-a20e-4417-b41a-000183691bc8"), "طبس مسينا", 10 },
                    { 297, new Guid("503efb75-5f3a-4314-94e2-34f584750eab"), "خوسف", 10 },
                    { 307, new Guid("47d553a9-2733-4ee6-859c-80f3483ed6ed"), "فردوس", 10 },
                    { 514, new Guid("d482a99c-312e-4885-9291-89d21bd8727b"), "نشتارود", 15 },
                    { 513, new Guid("bc44728c-2c96-4167-a3b9-07909018f503"), "مرزيکلا", 15 },
                    { 512, new Guid("b89bb35d-f295-4815-8a3c-e7371ffac85c"), "مرزن آباد", 15 },
                    { 511, new Guid("bd73d5b9-7491-433d-8036-9bcbc8764aaf"), "محمود آباد", 15 },
                    { 510, new Guid("3d7240d7-1e6c-439c-bd5f-6c5d5eff23a7"), "قائم شهر", 15 },
                    { 509, new Guid("7427b77b-60b9-4a80-83f6-add8793dc5a4"), "فريم", 15 },
                    { 508, new Guid("1d65c15f-a9a8-433a-873e-1bc838df749c"), "فريدونکنار", 15 },
                    { 507, new Guid("b83f78b4-69e3-451d-8b3a-181d5d07d1da"), "عباس آباد", 15 },
                    { 506, new Guid("b6606041-1838-4f50-a6e9-0262769b0418"), "شيرگاه", 15 },
                    { 505, new Guid("9b4eb19c-6791-4811-9216-adbc251fcda4"), "شيرود", 15 },
                    { 504, new Guid("58b0fc86-865d-44b1-8d32-a6629391ca6c"), "سورک", 15 },
                    { 503, new Guid("7c238321-01e0-4737-a557-42114a42fb8c"), "سلمان شهر", 15 },
                    { 502, new Guid("2fe083b0-c8f9-4324-8962-455213ccdee3"), "سرخرود", 15 },
                    { 501, new Guid("21d6698b-48bf-4f96-96ea-63101b0226e4"), "ساري", 15 },
                    { 500, new Guid("a4ea1185-a993-4689-b77c-0f1ac5660181"), "زيرآب", 15 },
                    { 515, new Guid("2b94a69f-4ace-45ce-86be-aa7bbac6137e"), "نور", 15 },
                    { 499, new Guid("5a039661-bc68-4206-8347-85538903b92d"), "زرگر محله", 15 },
                    { 516, new Guid("dfe33407-3969-4860-a192-1c2e4a73c9dd"), "نوشهر", 15 },
                    { 518, new Guid("248de60d-c321-4ea1-9b85-93dd3be0f9a1"), "هادي شهر", 15 },
                    { 533, new Guid("a24595ed-84d8-4c38-be50-cdcf43c089e4"), "گزنک", 15 },
                    { 532, new Guid("10888018-8e4c-45c4-9a2b-1c53ff5d5559"), "گتاب", 15 },
                    { 531, new Guid("5234ffda-5dc4-4b7d-9ccf-6857ac1154b7"), "کياکلا", 15 },
                    { 530, new Guid("27208155-a23f-443d-bbeb-1905e4bdd8bc"), "کياسر", 15 },
                    { 529, new Guid("818fb960-5cb5-4a20-9f1a-e1e74cc14c3c"), "کوهي خيل", 15 },
                    { 528, new Guid("ed39724e-5689-480e-ac6d-8cfd6c32b44a"), "کلاردشت", 15 },
                    { 527, new Guid("bc1925f4-ec49-4d47-a83e-c4be6c5d9e16"), "کلارآباد", 15 },
                    { 526, new Guid("737814be-16d3-429f-a3a8-b28a001d4722"), "کجور", 15 },
                    { 525, new Guid("273c21f9-3098-47c3-9301-7b43c5c49fbe"), "کتالم و سادات شهر", 15 },
                    { 524, new Guid("998b2850-533e-4a9a-b1ed-77ddc5fdb661"), "چمستان", 15 },
                    { 523, new Guid("07b6088f-9d7f-4186-9ea2-16ce73ecd243"), "چالوس", 15 },
                    { 522, new Guid("edf6414d-7456-45bf-94c8-4fbe96deee78"), "پول", 15 },
                    { 521, new Guid("8e13725c-e000-43fe-be26-bf127f2fa1d4"), "پل سفيد", 15 },
                    { 520, new Guid("cd35c773-3712-4f1f-9ab1-cf1eedf5b0d1"), "پايين هولار", 15 },
                    { 519, new Guid("d81b33d0-a628-4968-a044-b1912852953e"), "هچيرود", 15 },
                    { 517, new Guid("f9440d03-9106-44ba-a112-1709791d8280"), "نکا", 15 },
                    { 534, new Guid("80bcc9ad-4d7c-4274-ba58-42d530b98ea0"), "گلوگاه", 15 },
                    { 498, new Guid("fcfbeb2d-dffe-4e60-a456-e69ce9b5bbe5"), "رينه", 15 },
                    { 496, new Guid("dfac42e6-655f-4b67-a960-0b6820b84230"), "رستمکلا", 15 },
                    { 476, new Guid("69d51724-32b7-4973-86db-9e6180f9cad9"), "گميش تپه", 14 },
                    { 475, new Guid("8220c038-de0d-42c3-8959-07b2f226701d"), "گرگان", 14 },
                    { 474, new Guid("42fae1c4-60e6-4288-843c-163f74b43a03"), "گاليکش", 14 },
                    { 473, new Guid("ec3cac08-a4bf-45da-a0b7-7b99e0b8f675"), "کلاله", 14 },
                    { 472, new Guid("f79f91a1-6e5d-4ad1-a6e0-e4874b361490"), "کرد کوي", 14 },
                    { 471, new Guid("df495183-e58e-4223-ae20-f8b886549adb"), "نگين شهر", 14 },
                    { 470, new Guid("754360ea-8d72-4c7e-be3c-9c5232ddcda1"), "نوکنده", 14 },
                    { 469, new Guid("20352461-81d2-4e96-88d9-aa61a6739353"), "نوده خاندوز", 14 },
                    { 306, new Guid("484067de-cd41-4601-b8eb-445d1e219a39"), "عشق آباد", 10 },
                    { 467, new Guid("6871c781-e3a1-4d1a-b640-c69bc3168e70"), "مزرعه", 14 },
                    { 466, new Guid("967120bf-be9b-47ad-a572-ff726fb46f69"), "مراوه تپه", 14 },
                    { 465, new Guid("43e9c7da-111d-45bd-8e50-9417f044b61e"), "فراغي", 14 },
                    { 464, new Guid("75b2d383-ff4e-4ae6-8a73-71741fa61693"), "فاضل آباد", 14 },
                    { 463, new Guid("0580c9e9-67b9-432d-bdcb-0d5a0dffd2d1"), "علي آباد", 14 },
                    { 462, new Guid("8205eb63-642b-4388-a403-0eb5af8bd919"), "سيمين شهر", 14 },
                    { 477, new Guid("185457e8-f111-4545-be4a-7ec3a63ffa7d"), "گنبدکاووس", 14 },
                    { 497, new Guid("524cb6dd-72b5-4bf1-8cfe-17c972b2a141"), "رويان", 15 },
                    { 478, new Guid("0816c9df-524c-456e-a1e6-cef3aeb5574c"), "آلاشت", 15 },
                    { 480, new Guid("0b293aa1-bed6-4005-a682-d0b3c7a19a40"), "ارطه", 15 },
                    { 495, new Guid("5fb3932a-e7c2-4323-8fe6-bf864e32bdb9"), "رامسر", 15 },
                    { 494, new Guid("656dceb3-4f3e-450f-8de3-0daf4b37a261"), "دابودشت", 15 },
                    { 493, new Guid("3365ef30-1769-4fb0-8c26-ea56fd4c1bf2"), "خوش رودپي", 15 },
                    { 492, new Guid("c7f92458-fc02-49c5-9c5a-5b27d10870cf"), "خليل شهر", 15 },
                    { 491, new Guid("90c58a84-e132-4849-88c8-7fa9da29a0de"), "خرم آباد", 15 },
                    { 490, new Guid("2f13e3d2-be0c-4434-8c05-d83c1a9e2a15"), "جويبار", 15 },
                    { 489, new Guid("06d34b9f-188f-4c39-a9c7-379d0af43beb"), "تنکابن", 15 },
                    { 488, new Guid("c9ab734f-4f54-4002-948d-c4aa683932c7"), "بهنمير", 15 },
                    { 487, new Guid("dfd5172c-3827-49d5-8527-9a1caa75b3aa"), "بهشهر", 15 },
                    { 486, new Guid("3f669e70-2fde-4cf9-b82c-bbe73ab05d31"), "بلده", 15 },
                    { 485, new Guid("60a796c3-b963-46db-a679-b0a921b68963"), "بابلسر", 15 },
                    { 484, new Guid("94f34a08-33c2-415f-ba59-1b37316ef6b8"), "بابل", 15 },
                    { 483, new Guid("e35454f6-e48f-4c27-be3f-df6cf92e11ac"), "ايزد شهر", 15 },
                    { 482, new Guid("2f870c45-3bd0-43d8-a87d-93efdd3b7433"), "امير کلا", 15 },
                    { 481, new Guid("57b46866-d797-485f-9a76-345fb379bed8"), "امامزاده عبدالله", 15 },
                    { 479, new Guid("ed75fe7a-1b36-439a-a387-e283c904b63b"), "آمل", 15 },
                    { 535, new Guid("65a7c820-9af1-4999-b4ce-daf5f41ed60a"), "آبيک", 16 },
                    { 536, new Guid("f42b93d5-0d0b-4022-94bd-7c88239994d4"), "آبگرم", 16 },
                    { 537, new Guid("5efa4312-8a05-4d9c-a427-338e3d3eb0d0"), "آوج", 16 },
                    { 591, new Guid("547b6265-b124-4178-9067-8403de3ad408"), "تازه کند انگوت", 18 },
                    { 590, new Guid("976141b6-4678-4812-8de7-7b21a36f0f59"), "تازه کند", 18 },
                    { 589, new Guid("27a21025-d531-4d94-ba74-79a1277446b4"), "بيله سوار", 18 },
                    { 588, new Guid("3b85e196-44da-4dc7-a8cf-25cfb0947456"), "اصلاندوز", 18 },
                    { 587, new Guid("7659fdb3-20ed-4b65-aef9-575d741eb1ce"), "اسلام آباد", 18 },
                    { 586, new Guid("d1f32b41-e589-476e-addf-ffd963601995"), "اردبيل", 18 },
                    { 585, new Guid("1a4a5df4-0c78-4ace-8275-5135b13fd7a4"), "آبي بيگلو", 18 }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityGUID", "Name", "ProvinceID" },
                values: new object[,]
                {
                    { 584, new Guid("87b1f192-b472-44b8-b06a-a034607f92d3"), "گراب", 17 },
                    { 583, new Guid("49dcf9c9-56f6-4a38-b85f-b9527a121167"), "کوهناني", 17 },
                    { 582, new Guid("73d6debb-cb1b-476d-8e2d-357c426c88e3"), "کوهدشت", 17 },
                    { 581, new Guid("35c0c214-f689-44d9-ac8d-d4083c3d230b"), "چقابل", 17 },
                    { 580, new Guid("2939cf81-43cd-42b7-a1ff-6c3da97eb07d"), "چالانچولان", 17 },
                    { 579, new Guid("d0e01ea5-1ed6-42df-8119-4c146ee36b5f"), "پلدختر", 17 },
                    { 578, new Guid("f534254d-1de4-4ddc-a9ac-82d867162fee"), "ويسيان", 17 },
                    { 577, new Guid("70fde840-848e-402c-9191-324a82158905"), "هفت چشمه", 17 },
                    { 592, new Guid("85c1649f-2152-449a-bc8a-84d7811341ca"), "جعفر آباد", 18 },
                    { 576, new Guid("0ac1f964-15de-48fa-8623-9263946b2211"), "نورآباد", 17 },
                    { 593, new Guid("b2c860da-4951-42cc-80dd-e89d8c175df6"), "خلخال", 18 },
                    { 595, new Guid("b9e68ca6-ec33-4e5c-a66f-871daee406e4"), "سرعين", 18 },
                    { 610, new Guid("d28fac78-ce9c-4cea-9d3d-653766ce9fc2"), "گيوي", 18 },
                    { 1241, new Guid("2d3a16f3-2c96-4daa-9ca2-528906e7ecf3"), "گراب سفلي", 31 },
                    { 608, new Guid("9af9d1b0-2f2e-4b66-b981-e72894437d45"), "کورائيم", 18 },
                    { 607, new Guid("5c5e6905-3479-4c6f-8653-18a522b49927"), "کلور", 18 },
                    { 606, new Guid("4c53169f-1bd9-4a06-96b1-c2d1e9daa954"), "پارس آباد", 18 },
                    { 605, new Guid("1d265a87-637b-4860-bdfe-c3182c764288"), "هير", 18 },
                    { 604, new Guid("d83e858c-09f7-4ac6-9c19-5d9d650a9b67"), "هشتجين", 18 },
                    { 603, new Guid("24848a64-df0f-4e2d-9b80-d31290752ada"), "نير", 18 },
                    { 602, new Guid("f2251c30-e923-42cb-a936-3e51a837833a"), "نمين", 18 },
                    { 601, new Guid("d3388884-97b4-4487-a5d6-bb32b8e7cf9e"), "مشگين شهر", 18 },
                    { 600, new Guid("49008135-0abf-403d-80c2-b52ba64c7d8b"), "مرادلو", 18 },
                    { 599, new Guid("b2756f79-b499-4876-8cda-b760b1555c62"), "لاهرود", 18 },
                    { 598, new Guid("07015af0-9cd5-48bc-830f-05db49dd1e85"), "قصابه", 18 },
                    { 597, new Guid("24d03c92-9409-43be-9297-0eee599afaac"), "فخرآباد", 18 },
                    { 596, new Guid("42391e9f-ec84-45b2-8f85-0bc940ddaccc"), "عنبران", 18 },
                    { 594, new Guid("50268cd0-ac1c-4bfe-92b7-7cdbf83a7466"), "رضي", 18 },
                    { 575, new Guid("1cf17b57-ed19-4836-9567-ac46d55346fa"), "مومن آباد", 17 },
                    { 574, new Guid("2fd181b0-f0f1-488a-8893-dfaa4a10031b"), "معمولان", 17 },
                    { 573, new Guid("cebd19d7-850a-4c8c-b452-5a23eef23892"), "فيروزآباد", 17 },
                    { 552, new Guid("78c22871-589d-4fb9-80dd-5ec966d69dff"), "شريفيه", 16 },
                    { 551, new Guid("de459de8-d26f-4496-b99a-e49ec1d27820"), "شال", 16 },
                    { 550, new Guid("6a03de5a-d60e-40e5-9a25-dc305cdb46ec"), "سگز آباد", 16 },
                    { 549, new Guid("fb6202e2-072c-4add-81f1-6e3fcc679684"), "سيردان", 16 },
                    { 548, new Guid("195c8038-c4d5-4409-9300-3df42e8288db"), "رازميان", 16 },
                    { 547, new Guid("6e40d1e9-aba5-452f-9c5d-4e75f955a27b"), "دانسفهان", 16 },
                    { 546, new Guid("0689cd64-14c8-4e26-86c8-ab0bee344401"), "خرمدشت", 16 },
                    { 545, new Guid("5cb200bd-6337-461b-bd2d-65e3a70ddba1"), "خاکعلي", 16 },
                    { 544, new Guid("010e24ee-2199-4133-bbb0-7c9ab6ab5318"), "تاکستان", 16 },
                    { 543, new Guid("b7cff8ec-ee88-43ca-b378-b0835284d37c"), "بيدستان", 16 },
                    { 542, new Guid("d04e349d-8394-4926-8e2e-7a149310527e"), "بوئين زهرا", 16 },
                    { 541, new Guid("915721fd-588b-4607-8099-fa71ee39d6b6"), "الوند", 16 },
                    { 540, new Guid("afeec9c4-3921-49bb-a53a-8e82ce34684e"), "اقباليه", 16 },
                    { 539, new Guid("4e38bc4e-da87-43a7-9554-4cc5483adea6"), "اسفرورين", 16 },
                    { 538, new Guid("bab021bd-1076-4e05-a2c1-fbbdca3af6be"), "ارداق", 16 },
                    { 553, new Guid("cfc6cdd2-2b1d-463f-80fe-a97f16d44ace"), "ضياء آباد", 16 },
                    { 554, new Guid("ed09e930-31a8-4470-a37e-f83a4cd96f7b"), "قزوين", 16 },
                    { 555, new Guid("4177001e-44be-46c7-bf4c-15c03d7b71b0"), "محمديه", 16 },
                    { 556, new Guid("17d9464a-8ca2-4151-8e0d-649ae7794c46"), "محمود آباد نمونه", 16 },
                    { 572, new Guid("cf52ec34-be32-4cbb-b2cb-ff37ee757e12"), "شول آباد", 17 },
                    { 571, new Guid("8c829697-01d6-482c-a9bd-4ed35444ba74"), "سپيد دشت", 17 },
                    { 570, new Guid("6db829fe-1f54-41c3-aed8-51ef268150be"), "سراب دوره", 17 },
                    { 569, new Guid("a790512b-ee14-49d5-aeba-61d21ca41d74"), "زاغه", 17 },
                    { 568, new Guid("280b0381-cafe-4114-bc52-352afbea26e0"), "دورود", 17 },
                    { 567, new Guid("f7145ddf-daac-401e-a562-e55527ab9a43"), "درب گنبد", 17 },
                    { 566, new Guid("e23e8a99-e03a-42c0-a528-d99cadf323d2"), "خرم آباد", 17 },
                    { 461, new Guid("e68ae575-5707-4c27-87f0-71b70b8b2eba"), "سنگدوين", 14 },
                    { 565, new Guid("6d89f647-6f93-4f5e-86ee-0040073326bd"), "بيرانشهر", 17 },
                    { 563, new Guid("c3f76894-924c-4085-b196-c59100202d48"), "اليگودرز", 17 },
                    { 562, new Guid("b903107e-95c8-47e0-8c34-9f861e2d5a44"), "الشتر", 17 },
                    { 561, new Guid("0ef4e02c-143c-4f9b-a29c-730f59899f3c"), "اشترينان", 17 },
                    { 560, new Guid("be6bd4f7-d9e3-4c3b-ac77-598f49f28f90"), "ازنا", 17 },
                    { 559, new Guid("466275ec-9fb6-483f-975e-4ef4dc586071"), "کوهين", 16 },
                    { 558, new Guid("8f8a7aa3-de8b-4aa3-8a52-cce5cd66e4c0"), "نرجه", 16 },
                    { 557, new Guid("4a81e553-86bd-4d12-9fba-87b558169da0"), "معلم کلايه", 16 },
                    { 564, new Guid("e3746718-830d-4c4f-8af3-6de9e74734ac"), "بروجرد", 17 },
                    { 460, new Guid("4bb2f523-9586-4a86-87b1-d9dcf8191b1c"), "سرخنکلاته", 14 },
                    { 468, new Guid("8c0c1420-9697-4664-9bc5-41617178eedb"), "مينودشت", 14 },
                    { 458, new Guid("9457a7f3-8cf2-4820-be45-5169f8873ae0"), "دلند", 14 },
                    { 361, new Guid("54d4a412-1c27-4121-95f0-ebc65cc29d65"), "شوش", 11 },
                    { 360, new Guid("433a5100-b433-4e7c-90c1-df606ec92473"), "شهر امام", 11 },
                    { 359, new Guid("489c8b98-39f4-4c86-a326-7838d68b16cd"), "شمس آباد", 11 },
                    { 358, new Guid("9c92ceee-50c7-4652-9a20-30d12b7af731"), "شرافت", 11 },
                    { 357, new Guid("239fe9b2-4f20-4375-a4e0-942ffdea264f"), "شاوور", 11 },
                    { 356, new Guid("2ec9cffb-cc27-4cbe-9ce8-b2922c1d3de9"), "شادگان", 11 },
                    { 355, new Guid("a767893a-dc83-4275-bdf9-91cf49bf1603"), "سياه منصور", 11 },
                    { 354, new Guid("dd32110c-8ce7-42bb-9f9e-14f2158ee439"), "سوسنگرد", 11 },
                    { 353, new Guid("1e2d29b2-3b0e-4981-a568-943ec263ad51"), "سماله", 11 },
                    { 352, new Guid("90af2767-c8e5-4735-aab6-7e93cf0091be"), "سردشت", 11 },
                    { 351, new Guid("d5cd61db-e20a-4b90-917c-66ba1d9328dd"), "سرداران", 11 },
                    { 350, new Guid("2c82ad13-2ffa-44be-80bb-c363abb43c5f"), "سالند", 11 },
                    { 349, new Guid("d7761d4f-5c0b-40e3-bc2b-7f0b2dd07ba1"), "زهره", 11 },
                    { 348, new Guid("6dc8a68c-4d2e-41bc-a4dc-b1b713c6f3f1"), "رفيع", 11 },
                    { 347, new Guid("8a0873af-2f93-448a-a0ff-0f8bebec720f"), "رامهرمز", 11 },
                    { 362, new Guid("f9168ff8-61a9-45d1-9785-78f176964f15"), "شوشتر", 11 },
                    { 346, new Guid("4f314cd3-34af-4866-8c0b-77ef5a674ba4"), "رامشير", 11 },
                    { 363, new Guid("8af8f1a1-230a-4d48-8ff8-ccae1e533bfa"), "شيبان", 11 },
                    { 365, new Guid("8ea1123d-e011-4371-a1eb-5934d74d6f73"), "صفي آباد", 11 },
                    { 380, new Guid("2583bf4a-389e-43f0-b184-918307048682"), "هنديجان", 11 },
                    { 379, new Guid("4535b08a-75ae-4556-bc3e-280da7e8c005"), "هفتگل", 11 },
                    { 378, new Guid("9b7b42b9-bd22-446a-800e-08280f5b8006"), "مينوشهر", 11 },
                    { 377, new Guid("a9a878a8-78f7-427f-b71b-140bf1abd401"), "ميداود", 11 },
                    { 376, new Guid("e52c1d6f-7ddb-43a5-b645-492d0ecf8af9"), "ميانرود", 11 },
                    { 375, new Guid("411ed634-823a-4b0d-be56-090ce0f83914"), "منصوريه", 11 },
                    { 459, new Guid("9ca684cc-18da-4aa1-8e49-013279dbac28"), "راميان", 14 },
                    { 373, new Guid("5d88540b-7d3c-4d2d-8dbd-70c6a3b5e76e"), "مقاومت", 11 },
                    { 372, new Guid("440a108c-d197-4dad-98f1-1621f12c809b"), "مشراگه", 11 },
                    { 371, new Guid("eef6db20-8ce5-48ab-93be-7b238a615427"), "مسجد سليمان", 11 },
                    { 370, new Guid("682978a8-bb67-4dfa-9984-f3f2f549cf1a"), "لالي", 11 },
                    { 369, new Guid("a6a2272a-356e-4073-a1dd-04053ae99af1"), "قلعه خواجه", 11 },
                    { 368, new Guid("a0c4221c-df67-45d6-b8cd-29597a0fbafe"), "قلعه تل", 11 },
                    { 367, new Guid("70daf5cb-a371-4244-b65c-c3de6f913498"), "فتح المبين", 11 },
                    { 366, new Guid("01cd8435-74b0-4ca2-b786-3756178d089e"), "صيدون", 11 },
                    { 364, new Guid("a9c6ebb1-ac36-4fa6-bd67-8846bf129071"), "صالح شهر", 11 },
                    { 345, new Guid("9711a6d2-9f6e-4d31-ae3c-26396a7a4737"), "دهدز", 11 },
                    { 344, new Guid("c3527be4-baa5-4ed8-b663-6b1d06cb4149"), "دزفول", 11 },
                    { 343, new Guid("114b20ad-8c4a-403a-b935-665f2dc900df"), "دارخوين", 11 },
                    { 322, new Guid("568861c8-4fa4-461a-b977-2d3ffe0de07d"), "الوان", 11 },
                    { 321, new Guid("aa188959-0a36-4fa3-9434-16e081833699"), "الهايي", 11 },
                    { 320, new Guid("d0bf19f1-db23-4df0-adee-7b710494f553"), "اروند کنار", 11 },
                    { 319, new Guid("d5f56d9c-e385-44d4-bdc3-eb5a359f3bb1"), "ابوحميظه", 11 },
                    { 318, new Guid("290c6286-65c1-43ab-91dd-50ca524a9959"), "آغاجاري", 11 },
                    { 317, new Guid("ff2f4d72-db6d-4f44-94e0-80489079b0ce"), "آزادي", 11 },
                    { 316, new Guid("e473a013-ef4b-4a79-a28a-549c3c638bd4"), "آبژدان", 11 },
                    { 315, new Guid("6b3de67e-c91d-4cd8-a561-3608baaa7580"), "آبادان", 11 },
                    { 314, new Guid("2c938876-f10b-48fc-a2c4-4eade906d31f"), "گزيک", 10 },
                    { 313, new Guid("b5afa1de-a38e-4e79-9493-d58bbd6613ac"), "نيمبلوک", 10 },
                    { 312, new Guid("ce9f54f9-0f1f-40ac-9201-aa0bf5786c9a"), "نهبندان", 10 },
                    { 311, new Guid("a65362ae-d20f-4a7e-86f2-7b9c234b4ad7"), "مود", 10 },
                    { 310, new Guid("5eb18fcb-2036-4ab4-9578-f4b957f2fdd7"), "محمدشهر", 10 },
                    { 309, new Guid("b03500e5-ccfa-49c3-bcd9-5c7c9b8d996c"), "قهستان", 10 },
                    { 308, new Guid("920aee76-4ff5-4e1e-910c-6b25b5d7f206"), "قائن", 10 },
                    { 323, new Guid("c14bc6b9-149a-452c-859f-a19c89ea928a"), "اميديه", 11 },
                    { 324, new Guid("7c1ad858-bfd9-400c-9b18-1965c1f3cb8a"), "انديمشک", 11 },
                    { 325, new Guid("bf0bd7ae-4bcf-4dfb-ba0a-749a2455463c"), "اهواز", 11 },
                    { 326, new Guid("9a6fa7b9-2b5b-49d0-bbf5-36a953d62307"), "ايذه", 11 },
                    { 342, new Guid("5eb7d31d-4e25-4885-8666-c5a367db5223"), "خنافره", 11 },
                    { 341, new Guid("fbb16bcf-6f25-41f4-9727-85503085e419"), "خرمشهر", 11 },
                    { 340, new Guid("0f80a6d9-9f4f-42b2-a47b-adc719ce7a27"), "حميديه", 11 },
                    { 339, new Guid("a202b53a-af13-44b7-b3f1-9a7b85763501"), "حمزه", 11 },
                    { 338, new Guid("383613f7-820e-438f-9fae-d3f3ec60b777"), "حسينيه", 11 },
                    { 337, new Guid("2228def6-6bfb-45f6-b028-0cdd64a079c8"), "حر", 11 },
                    { 336, new Guid("aecf580d-2b39-4b90-af92-15f643d92bac"), "جنت مکان", 11 },
                    { 381, new Guid("57b516d7-4d1f-4eb2-ba5f-de31a14b72f8"), "هويزه", 11 },
                    { 335, new Guid("b73787de-6ae5-4361-84ec-ca7be3b9aba9"), "جايزان", 11 },
                    { 333, new Guid("35a35d4b-3a79-4748-b65a-1a52d25c2ee4"), "ترکالکي", 11 },
                    { 332, new Guid("af3f0dd9-1f64-45e1-8940-d1fc853a25d4"), "بيدروبه", 11 },
                    { 331, new Guid("50d4fac7-7a46-46cf-9dd0-c2294ad69a81"), "بهبهان", 11 },
                    { 330, new Guid("c7e40d1e-c82f-46ba-9e03-ae05a605e7ac"), "بندر ماهشهر", 11 },
                    { 329, new Guid("727169f0-7f48-4356-b6ee-ffcd36209c7e"), "بندر امام خميني", 11 },
                    { 328, new Guid("15f79e57-ce60-46fe-a4a8-da9a978281f6"), "بستان", 11 },
                    { 327, new Guid("3590e01a-bb39-4e9d-833b-eb17e6de805f"), "باغ ملک", 11 },
                    { 334, new Guid("c5620213-c34c-48eb-98e9-c5a605409b6f"), "تشان", 11 },
                    { 382, new Guid("f2d1784a-2ce9-47f2-a5e3-075d00b2593c"), "ويس", 11 },
                    { 374, new Guid("cf34d345-966f-407a-9087-fcc81adf834f"), "ملاثاني", 11 },
                    { 384, new Guid("b9028f41-9a61-4514-a7c9-9e166e83aab1"), "چم گلک", 11 },
                    { 438, new Guid("9dcfc609-691a-436f-ac18-1e84df30e13f"), "سلطانيه", 13 },
                    { 437, new Guid("87e28d88-0c29-4d61-9ed6-ad1a370411b0"), "سجاس", 13 },
                    { 436, new Guid("74ae5535-34de-4b4f-8de5-cff2a9646db2"), "زنجان", 13 },
                    { 435, new Guid("f2126da5-4611-40c9-91cf-dde442c518f6"), "زرين رود", 13 },
                    { 434, new Guid("c5c8546d-906c-409c-b09f-0fb09d055745"), "زرين آباد", 13 },
                    { 433, new Guid("9cf53c10-682f-4604-9d23-435b96eb2519"), "دندي", 13 },
                    { 432, new Guid("d1aa9788-cffb-4911-9978-1d8cb14f8f47"), "خرمدره", 13 },
                    { 431, new Guid("7dab1fc0-2304-4fe7-a584-985e7a070fe9"), "حلب", 13 },
                    { 383, new Guid("403be46e-ec4c-45e1-a22c-364dd39fde65"), "چغاميش", 11 },
                    { 429, new Guid("93331d99-6f2e-46a0-8415-eaec3e8efd43"), "ابهر", 13 },
                    { 428, new Guid("4794452c-fc59-4a89-8095-7641fbb18122"), "آب بر", 13 },
                    { 427, new Guid("28494be8-8810-428f-9aa4-f12e22e4997d"), "کلمه", 12 },
                    { 426, new Guid("cfce779f-f4f5-4285-89d6-89ce7299bcea"), "کاکي", 12 },
                    { 425, new Guid("be1d28e2-a8e7-4e1d-8bc8-5871a4a1c795"), "چغادک", 12 },
                    { 424, new Guid("147b833e-6aab-43bf-a83d-e8a8e7c00889"), "وحدتيه", 12 },
                    { 439, new Guid("be7f301b-e1e6-4b83-a0f6-654de3533697"), "سهرورد", 13 },
                    { 423, new Guid("5d9eda0d-6f04-43e1-828d-801166871da8"), "نخل تقي", 12 },
                    { 440, new Guid("ed0455ac-9061-425a-b61d-f074eca30f7f"), "صائين قلعه", 13 },
                    { 442, new Guid("2a5e01b3-99f5-4109-8ffd-3f8a1c91c368"), "ماه نشان", 13 },
                    { 457, new Guid("317c37bf-a23a-47c3-acb6-cddfb7e615b3"), "خان ببين", 14 },
                    { 456, new Guid("1d4456e9-9d9e-4e7f-997f-627bca24af42"), "جلين", 14 },
                    { 455, new Guid("589de1e4-eeb6-48aa-976c-e418639e5a5b"), "تاتار عليا", 14 },
                    { 454, new Guid("6cdfbaaa-7df0-49d5-b324-93ed53940ef5"), "بندر گز", 14 },
                    { 453, new Guid("71d41f21-04f9-44c3-b0ec-c9eec9a01477"), "بندر ترکمن", 14 },
                    { 452, new Guid("5a59bb4e-0248-404d-9eb6-ff12e6349827"), "اينچه برون", 14 },
                    { 451, new Guid("779e21e4-afb5-4a51-bf7d-d67c2209f691"), "انبار آلوم", 14 },
                    { 450, new Guid("3f21de46-241a-4a25-9c78-819c2f42876b"), "آق قلا", 14 },
                    { 449, new Guid("3d8759c0-4482-474b-8264-42e0ea92e0cb"), "آزاد شهر", 14 },
                    { 448, new Guid("3d619d43-90d4-48b7-a89a-ff1213acd4b8"), "گرماب", 13 },
                    { 447, new Guid("8410496a-1318-4c84-82bf-1d72fe5c594a"), "کرسف", 13 },
                    { 446, new Guid("b6501ba6-3bbd-4b74-a7c1-be34cb8dcf20"), "چورزق", 13 },
                    { 445, new Guid("3eb4f252-9b28-432a-a1be-92f5cf1ced51"), "هيدج", 13 },
                    { 444, new Guid("8bd01714-8697-46ac-b3ed-6b778c5f776d"), "نيک پي", 13 },
                    { 443, new Guid("6f6cc3e1-c4b6-4e3a-8f17-16bd7bbcafad"), "نوربهار", 13 },
                    { 441, new Guid("f020b02e-8b18-4ec5-827d-d7ecd5a1b077"), "قيدار", 13 },
                    { 422, new Guid("7212fbb9-99a6-456e-aed9-55f6337a16ce"), "عسلويه", 12 },
                    { 430, new Guid("56f61dd0-304c-4228-b052-f1511d002a08"), "ارمخانخانه", 13 },
                    { 420, new Guid("39a7ad27-9900-4ca2-a8f7-3053e79ffbb0"), "شبانکاره", 12 },
                    { 399, new Guid("c66d7163-4ea2-4aec-b216-fc316ff4836d"), "برازجان", 12 },
                    { 398, new Guid("e3e82b87-5755-4ef2-84ed-4c87c9f14aa9"), "بادوله", 12 },
                    { 397, new Guid("123b767f-d39e-4b22-977d-ca1652c1a8b0"), "اهرم", 12 },
                    { 396, new Guid("be948705-de24-4b14-b460-2577cfb18cb9"), "انارستان", 12 },
                    { 395, new Guid("5be090e4-fc4b-4f53-aaba-5732dfc405a5"), "امام حسن", 12 },
                    { 394, new Guid("ac4bf4e1-e3b0-4493-b9a4-38f2586a3de7"), "آبپخش", 12 },
                    { 421, new Guid("c82d300a-9845-49cc-9b29-1b9cc4fabd76"), "شنبه", 12 },
                    { 392, new Guid("3cdf8b07-8971-478b-9fe9-85af78177665"), "آباد", 12 },
                    { 391, new Guid("c86b0ee3-f0f7-40f5-af3e-2081395b580a"), "گوريه", 11 },
                    { 390, new Guid("bae41662-ea39-4df6-aadc-07dd8203369d"), "گلگير", 11 },
                    { 389, new Guid("ced01c67-2c03-46b8-aa9b-01bee68ff9b1"), "گتوند", 11 },
                    { 388, new Guid("58f275ef-5b1f-4fe4-8f1d-5e185deb32b8"), "کوت عبدالله", 11 },
                    { 387, new Guid("acc105d4-ebdc-493e-b89d-5201385ec582"), "کوت سيدنعيم", 11 },
                    { 386, new Guid("a3599156-cc77-4a4c-816f-3dbed96f2c91"), "چوئبده", 11 },
                    { 385, new Guid("d7a6fb4b-ccec-420a-b57b-045a8b840d4f"), "چمران", 11 },
                    { 400, new Guid("ba154eab-f908-46de-bc2d-da682df7ff53"), "بردخون", 12 },
                    { 401, new Guid("94ded0e0-a131-4e5e-856d-dfbb46fd13a1"), "بردستان", 12 },
                    { 393, new Guid("da96f206-1280-42fd-8417-ad2e2b9d934c"), "آبدان", 12 },
                    { 403, new Guid("21ed03cf-48a3-47fe-a636-010da7e26da5"), "بندر ديلم", 12 },
                    { 402, new Guid("b95a9aae-2616-4651-b1a2-4fa6bba69bd7"), "بندر دير", 12 },
                    { 419, new Guid("67a3fdaf-17ec-4529-ae95-0e5ce638d886"), "سيراف", 12 },
                    { 418, new Guid("b448922b-5bf8-4362-8c27-31659c09e727"), "سعد آباد", 12 },
                    { 417, new Guid("bbed7b57-004a-45ff-ae24-08d391a26d79"), "ريز", 12 },
                    { 416, new Guid("c47ebd57-57ef-48f1-a55b-a776a099ed9d"), "دوراهک", 12 },
                    { 414, new Guid("f042b07d-75e2-4f07-bcb5-383aab7a3d58"), "دالکي", 12 },
                    { 413, new Guid("c25e5e06-711c-4d58-a101-54235d2ad06a"), "خورموج", 12 },
                    { 412, new Guid("580f4b01-31c5-43cb-8293-8ebbb83a884c"), "خارک", 12 },
                    { 415, new Guid("15c71f12-72be-4b90-bccc-366511ccad1d"), "دلوار", 12 },
                    { 410, new Guid("88ce6c33-ee64-4128-ab5e-8360ec83656a"), "تنگ ارم", 12 },
                    { 409, new Guid("7ced9a2c-4424-47de-9319-48bdcd9c9b16"), "بوشکان", 12 },
                    { 408, new Guid("22b85d5c-70a9-4ac4-9c4b-d915b102941b"), "بوشهر", 12 },
                    { 407, new Guid("7604ea7f-bc65-46e3-8f38-f4a1d49603d5"), "بنک", 12 },
                    { 406, new Guid("e3884f25-e5f2-47b8-aba2-be62681e5aad"), "بندر گناوه", 12 },
                    { 405, new Guid("984557d9-93be-4692-8fe6-8207ab712a9a"), "بندر کنگان", 12 },
                    { 404, new Guid("6b5a02f1-56d7-4409-937a-10bac2fb482b"), "بندر ريگ", 12 },
                    { 411, new Guid("f97fd624-d5ba-43fc-916f-16708c0d20bb"), "جم", 12 }
                });

            migrationBuilder.InsertData(
                table: "Code",
                columns: new[] { "CodeID", "CodeGroupID", "CodeGUID", "DisplayName", "Name" },
                values: new object[,]
                {
                    { 7, 3, new Guid("2b451e4c-c9b8-415a-bcb4-05da15447b89"), "زن", "Female" },
                    { 1, 1, new Guid("fc20e91f-1eb1-4912-87be-1708f2706367"), "png", "image/png" },
                    { 2, 1, new Guid("3f009296-db7a-4fde-a659-4ca1541a2504"), "jpg", "image/jpg" },
                    { 3, 1, new Guid("3209341a-07d4-437b-9301-2d0f909ad713"), "jpeg", "image/jpeg" },
                    { 4, 2, new Guid("09cb21ac-d99e-42ba-904d-337bdd561e6e"), "به صورت شخصی فعالیت میکنم", "به صورت شخصی فعالیت میکنم" },
                    { 5, 2, new Guid("2383b70e-f41f-4b67-b0c9-c48706a70a46"), "نماینده یک شرکت هستم", "نماینده یک شرکت هستم" },
                    { 6, 2, new Guid("cf5a1929-db68-43d6-8fc7-e3b7ccc51678"), "نماینده یک واحد، آموزشگاه یا دیگر مجوز ها هستم", "نماینده یک واحد، آموزشگاه یا دیگر مجوز ها هستم" },
                    { 8, 3, new Guid("6e48b657-2c83-4481-a9c5-009ffe10158b"), "مرد", "Male" },
                    { 17, 6, new Guid("ccef9d1f-343b-442a-a041-1908e4cbc235"), "حقیقی", "Natural" },
                    { 10, 4, new Guid("10afdac9-a075-40e1-9207-1813befcf4d6"), "در حال انجام", "Doing" },
                    { 11, 4, new Guid("2b9d07c8-5535-495e-8557-da32acb58600"), "انجام شده", "Done" },
                    { 12, 4, new Guid("61960336-e912-4658-9ab3-59f4c58e0b23"), "لغو شده", "Canceled" },
                    { 13, 4, new Guid("46a09d81-c57f-4655-a8f5-027c66a6cfb1"), "ادمین", "Admin" },
                    { 14, 4, new Guid("91b3cdab-39c1-40fb-b077-a2d6e611f50a"), "سرویس گیرنده", "Client" },
                    { 15, 4, new Guid("959b10a3-b8ed-4a9d-bdf3-17ec9b2ceb15"), "سرویس دهنده", "Contractor" },
                    { 16, 6, new Guid("a05c4f54-5999-42b9-a36f-6a04aa7cd476"), "حقوقی", "Legal" },
                    { 9, 4, new Guid("b5d74bda-849b-427c-a6e0-463c1e5f615b"), "در انتظار تایید", "Waiting" }
                });

            migrationBuilder.InsertData(
                table: "SMSProviderSetting",
                columns: new[] { "SMSProviderSettingID", "APIKey", "Password", "SMSProviderID", "Username" },
                values: new object[] { 1, "532B514B4E305A456D5A737669687A5161444B355544557462576650737634545959532F76517A572B65733D", "raffi1234", 1, "raffi.hovanes@gmail.com" });

            migrationBuilder.InsertData(
                table: "SMSTemplate",
                columns: new[] { "SMSTemplateID", "Name", "SMSProviderSettingID" },
                values: new object[,]
                {
                    { 1, "VerifyAccount", 1 },
                    { 2, "RegisterMessage", 1 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "Email", "FirstName", "GenderCodeID", "IsActive", "IsRegister", "LastName", "ModifiedDate", "PhoneNumber", "ProfileDocumentID", "RegisteredDate", "RoleID", "UserGUID" },
                values: new object[,]
                {
                    { 1, "mahdiroudaki@hotmail.com", "سید مهدی", 8, true, true, "رودکی", new DateTime(2020, 7, 10, 16, 1, 6, 403, DateTimeKind.Local).AddTicks(370), "09126842446", null, new DateTime(2020, 7, 10, 16, 1, 6, 402, DateTimeKind.Local).AddTicks(9773), 1, new Guid("73d4886e-7249-4559-bfb4-9b6c94cdaca5") },
                    { 2, "roozbehshamekhi@hotmail.com", "روزبه", 8, true, true, "شامخی", new DateTime(2020, 7, 10, 16, 1, 6, 403, DateTimeKind.Local).AddTicks(2703), "09128277075", null, new DateTime(2020, 7, 10, 16, 1, 6, 403, DateTimeKind.Local).AddTicks(2681), 3, new Guid("491a32b2-0caf-4f0d-baac-37ac3546b15f") },
                    { 3, "mahdiih@ymail.com", "مهدی", 8, true, true, "حکمی زاده", new DateTime(2020, 7, 10, 16, 1, 6, 403, DateTimeKind.Local).AddTicks(2750), "09199390494", null, new DateTime(2020, 7, 10, 16, 1, 6, 403, DateTimeKind.Local).AddTicks(2746), 1, new Guid("d8ad1e8c-da98-4d82-a263-955242cbb652") },
                    { 4, "white.luciferrr@gmail.com", "محمد", 8, true, true, "میرزایی", new DateTime(2020, 7, 10, 16, 1, 6, 403, DateTimeKind.Local).AddTicks(2763), "09147830093", null, new DateTime(2020, 7, 10, 16, 1, 6, 403, DateTimeKind.Local).AddTicks(2759), 1, new Guid("33e98efa-7cc7-4d5b-820a-2a4431e88ebd") },
                    { 5, "raffi.hovanes@gmail.com", "رافی", 8, true, true, "اوانسیان", new DateTime(2020, 7, 10, 16, 1, 6, 403, DateTimeKind.Local).AddTicks(2788), "09125344652", null, new DateTime(2020, 7, 10, 16, 1, 6, 403, DateTimeKind.Local).AddTicks(2785), 1, new Guid("bb11d6b4-b545-4f16-bb45-845721fb83f5") },
                    { 6, "dead.hh98@gmail.com", "حامد", 8, true, true, "حقیقیان", new DateTime(2020, 7, 10, 16, 1, 6, 403, DateTimeKind.Local).AddTicks(2801), "09108347428", null, new DateTime(2020, 7, 10, 16, 1, 6, 403, DateTimeKind.Local).AddTicks(2798), 2, new Guid("2c40658c-728b-41f8-ac2c-e9718aa42ee3") }
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "AdminID", "AdminGUID", "ModifiedDate", "UserID" },
                values: new object[,]
                {
                    { 1, new Guid("3e585c35-bbb5-4caf-8a9e-8c02323a0f06"), new DateTime(2020, 7, 10, 16, 1, 6, 403, DateTimeKind.Local).AddTicks(6233), 1 },
                    { 2, new Guid("2b6d7410-067c-4919-b4eb-2c31582502af"), new DateTime(2020, 7, 10, 16, 1, 6, 403, DateTimeKind.Local).AddTicks(7324), 3 },
                    { 3, new Guid("d678fbf4-809c-4d62-a671-82c17ad5e052"), new DateTime(2020, 7, 10, 16, 1, 6, 403, DateTimeKind.Local).AddTicks(7385), 4 },
                    { 4, new Guid("bf0959c5-87a5-4bb6-9297-7a5928aec7d1"), new DateTime(2020, 7, 10, 16, 1, 6, 403, DateTimeKind.Local).AddTicks(7391), 5 }
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientID", "CityID", "ClientGUID", "ModifiedDate", "UserID" },
                values: new object[] { 1, 751, new Guid("020c429a-d2be-4d9d-aa4c-79c2f57e5eca"), new DateTime(2020, 7, 10, 16, 1, 6, 404, DateTimeKind.Local).AddTicks(2513), 2 });

            migrationBuilder.InsertData(
                table: "Contractor",
                columns: new[] { "ContractorID", "AboutMe", "Address", "AverageRate", "BusinessTypeCodeID", "CityID", "ContractorGUID", "Credit", "Instagram", "Latitude", "Longitude", "ModifiedDate", "Telephone", "UserID", "Website" },
                values: new object[] { 1, null, null, null, 4, 751, new Guid("e56dc092-eae9-447a-92e8-37abac8fca90"), 0, null, "111", "222", new DateTime(2020, 7, 10, 16, 1, 6, 406, DateTimeKind.Local).AddTicks(4278), null, 6, null });

            migrationBuilder.InsertData(
                table: "ContractorCategory",
                columns: new[] { "ContractorCategoryID", "CategoryID", "ContractorCategoryGUID", "ContractorID" },
                values: new object[] { 1, 3, new Guid("d3802121-8bcd-407d-bcc0-c6527c0aa64c"), 1 });

            migrationBuilder.InsertData(
                table: "ContractorCategory",
                columns: new[] { "ContractorCategoryID", "CategoryID", "ContractorCategoryGUID", "ContractorID" },
                values: new object[] { 2, 4, new Guid("908647ee-1818-4837-a851-c40c5cf4a7e6"), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Admin_UserID",
                table: "Admin",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisement_DocumentID",
                table: "Advertisement",
                column: "DocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_ActiveIconDocumentID",
                table: "Category",
                column: "ActiveIconDocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_CoverDocumentID",
                table: "Category",
                column: "CoverDocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_InactiveIconDocumentID",
                table: "Category",
                column: "InactiveIconDocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_ParentCategoryID",
                table: "Category",
                column: "ParentCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_QuadMenuDocumentID",
                table: "Category",
                column: "QuadMenuDocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_SecondPageCoverDocumentID",
                table: "Category",
                column: "SecondPageCoverDocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTag_CategoryID",
                table: "CategoryTag",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTag_TagID",
                table: "CategoryTag",
                column: "TagID");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessage_OrderRequestID",
                table: "ChatMessage",
                column: "OrderRequestID");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessage_UserID",
                table: "ChatMessage",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_City_ProvinceID",
                table: "City",
                column: "ProvinceID");

            migrationBuilder.CreateIndex(
                name: "IX_Client_CityID",
                table: "Client",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Client_UserID",
                table: "Client",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Code_Code_CGID",
                table: "Code",
                column: "CodeGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_UserID",
                table: "Comment",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_UserID",
                table: "Complaint",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ContactUs_ContactUsBusinessTypeCodeID",
                table: "ContactUs",
                column: "ContactUsBusinessTypeCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Contractor_BusinessTypeCodeID",
                table: "Contractor",
                column: "BusinessTypeCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Contractor_CityID",
                table: "Contractor",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Contractor_UserID",
                table: "Contractor",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorCategory_CategoryID",
                table: "ContractorCategory",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorCategory_ContractorID",
                table: "ContractorCategory",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorDiscount_ContractorID",
                table: "ContractorDiscount",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorDiscount_PublicDiscountID",
                table: "ContractorDiscount",
                column: "PublicDiscountID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorDocument_ContractorID",
                table: "ContractorDocument",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorDocument_DocumentID",
                table: "ContractorDocument",
                column: "DocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorDocument_TitleCodeID",
                table: "ContractorDocument",
                column: "TitleCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Document_Document_TypeCodeID",
                table: "Document",
                column: "TypeCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CategoryID",
                table: "Order",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ClientID",
                table: "Order",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ContractorID",
                table: "Order",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StateCodeID",
                table: "Order",
                column: "StateCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRequest_ContractorID",
                table: "OrderRequest",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRequest_OrderID",
                table: "OrderRequest",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_ContractorID",
                table: "Payment",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PaymentProviderSettingID",
                table: "Payment",
                column: "PaymentProviderSettingID");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentProviderSetting_PaymentProviderID",
                table: "PaymentProviderSetting",
                column: "PaymentProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Permission_PermissionGroupID",
                table: "Permission",
                column: "PermissionGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Post_DocumentID",
                table: "Post",
                column: "DocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Post_UserID",
                table: "Post",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_PostCategory_CategoryID",
                table: "PostCategory",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_PostCategory_PostID",
                table: "PostCategory",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_PostComment_CommentID",
                table: "PostComment",
                column: "CommentID");

            migrationBuilder.CreateIndex(
                name: "IX_PostComment_PostID",
                table: "PostComment",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_PostID",
                table: "PostTag",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_TagID",
                table: "PostTag",
                column: "TagID");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateDiscount_ContractorID",
                table: "PrivateDiscount",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateDiscount_TypeCodeID",
                table: "PrivateDiscount",
                column: "TypeCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_PublicDiscount_TypeCodeID",
                table: "PublicDiscount",
                column: "TypeCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_RolePermission_RP_PermissionID",
                table: "RolePermission",
                column: "PermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_RolePermission_RP_RoleID",
                table: "RolePermission",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_SMSProviderSetting_SMSProviderID",
                table: "SMSProviderSetting",
                column: "SMSProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_SMSProviderNumber_SPN_SPCID",
                table: "SMSProviderSettingNumber",
                column: "SMSProviderSettingID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_SMSResponse_SMS_STID",
                table: "SMSResponse",
                column: "SMSTemplateID");

            migrationBuilder.CreateIndex(
                name: "IX_SMSResponse_UserID",
                table: "SMSResponse",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_SMSTemplate_ST_SSID",
                table: "SMSTemplate",
                column: "SMSProviderSettingID");

            migrationBuilder.CreateIndex(
                name: "IX_Suggestion_UserID",
                table: "Suggestion",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Token_RoleCodeID",
                table: "Token",
                column: "RoleCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Token_UserID",
                table: "Token",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_TypeCodeID",
                table: "Transaction",
                column: "TypeCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_User_GenderCodeID",
                table: "User",
                column: "GenderCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_User_ProfileDocumentID",
                table: "User",
                column: "ProfileDocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleID",
                table: "User",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_UserPermission_UP_PermissionID",
                table: "UserPermission",
                column: "PermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_UserPermission_UserID",
                table: "UserPermission",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Advertisement");

            migrationBuilder.DropTable(
                name: "CategoryTag");

            migrationBuilder.DropTable(
                name: "ChatMessage");

            migrationBuilder.DropTable(
                name: "Complaint");

            migrationBuilder.DropTable(
                name: "ContactUs");

            migrationBuilder.DropTable(
                name: "ContractorCategory");

            migrationBuilder.DropTable(
                name: "ContractorDiscount");

            migrationBuilder.DropTable(
                name: "ContractorDocument");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "PostCategory");

            migrationBuilder.DropTable(
                name: "PostComment");

            migrationBuilder.DropTable(
                name: "PostTag");

            migrationBuilder.DropTable(
                name: "PrivateDiscount");

            migrationBuilder.DropTable(
                name: "RolePermission");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DropTable(
                name: "SMSProviderSettingNumber");

            migrationBuilder.DropTable(
                name: "SMSResponse");

            migrationBuilder.DropTable(
                name: "Suggestion");

            migrationBuilder.DropTable(
                name: "Token");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "UserPermission");

            migrationBuilder.DropTable(
                name: "OrderRequest");

            migrationBuilder.DropTable(
                name: "PublicDiscount");

            migrationBuilder.DropTable(
                name: "PaymentProviderSetting");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "SMSTemplate");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "PaymentProvider");

            migrationBuilder.DropTable(
                name: "SMSProviderSetting");

            migrationBuilder.DropTable(
                name: "PermissionGroup");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Contractor");

            migrationBuilder.DropTable(
                name: "SMSProvider");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Code");

            migrationBuilder.DropTable(
                name: "CodeGroup");
        }
    }
}
