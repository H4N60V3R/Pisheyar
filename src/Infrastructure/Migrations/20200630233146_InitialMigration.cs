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
                columns: new[] { "CategoryID", "Abstract", "ActiveIconDocumentID", "CategoryGUID", "CoverDocumentID", "Description", "DisplayName", "InactiveIconDocumentID", "IsActive", "ModifiedDate", "ParentCategoryID", "QuadMenuDocumentID", "Sort" },
                values: new object[,]
                {
                    { 1, null, null, new Guid("c265fd02-0194-4d38-83e8-a93bc3698fcc"), null, null, "سایت اصلی", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(1702), null, null, 1 },
                    { 2, null, null, new Guid("dec37f17-0ab2-4208-8ba7-11cc1120369b"), null, null, "وبلاگ", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(3705), null, null, 2 }
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
                    { 19, "اصفهان", new Guid("5e71a692-51e5-427c-842a-4ac6e10fbe7e") },
                    { 20, "ايلام", new Guid("0e3aa043-6307-4b9f-95cb-e6d79325f250") },
                    { 21, "تهران", new Guid("d04183e8-e2e6-4f7f-8b3c-8fb3401f8dbf") },
                    { 22, "آذربايجان شرقي", new Guid("1ce6316d-abab-4d21-bdfa-994af98a2d59") },
                    { 23, "فارس", new Guid("f6632ad6-ccfe-46b0-8de7-a0b966fb91f0") },
                    { 24, "کرمانشاه", new Guid("0c3cb1ce-0c46-4776-bc0d-4f0581775859") },
                    { 28, "همدان", new Guid("c302d03f-0f76-49a2-920f-03905dd0c9bb") },
                    { 26, "مرکزي", new Guid("2321bc24-e5ad-4a93-8cb0-bfb745204b8b") },
                    { 27, "گيلان", new Guid("04575b66-8178-419b-bfa5-f07a51c09f70") },
                    { 18, "اردبيل", new Guid("0ee7dfea-0e1b-4576-99f8-d0e8dcb52b54") },
                    { 29, "کرمان", new Guid("fd9c29cf-96ac-4c27-b2ab-73664eb56731") },
                    { 30, "سمنان", new Guid("6b446111-b7cf-414d-aea8-af3a99cfdd9f") },
                    { 31, "کهگيلويه و بويراحمد", new Guid("9774e4bc-ddaa-453d-ab49-cb20beaf38cb") },
                    { 25, "هرمزگان", new Guid("bf540cd4-b042-419d-9f95-f342273b3c67") },
                    { 17, "لرستان", new Guid("38c029a0-7b3a-44c0-aed6-7c6893a75b0f") },
                    { 14, "گلستان", new Guid("d037c4c4-4596-430b-9a41-be8ca59f70cb") },
                    { 15, "مازندران", new Guid("8f1255c3-fe26-4730-bfb1-afabf9a260ac") },
                    { 1, "يزد", new Guid("3b6151ae-b18b-45c5-a96a-1f8c510d5372") },
                    { 2, "چهار محال و بختياري", new Guid("19b3ef96-498c-4a2f-b045-a502fbe7cefc") },
                    { 3, "خراسان شمالي", new Guid("74af6cfd-09cc-42e6-93e9-04b73b044f18") },
                    { 4, "البرز", new Guid("d40b7bb2-f85d-414f-9f3a-9f497ed001bf") },
                    { 5, "قم", new Guid("f9778c67-8805-4410-9fc6-861b70d30a09") },
                    { 16, "قزوين", new Guid("a62de112-963b-4a33-8b09-c52a6a959ccd") },
                    { 7, "آذربايجان غربي", new Guid("f0a03a67-8e50-4f2b-8f90-117f481262d3") },
                    { 6, "کردستان", new Guid("1e109a59-fc8a-47bc-af25-7b9280c35b34") },
                    { 9, "سيستان و بلوچستان", new Guid("a9125243-e789-4d86-8f15-07bdd8876fe3") },
                    { 10, "خراسان جنوبي", new Guid("29fb89c9-597b-4a4a-8afa-bd605d6ec39f") },
                    { 11, "خوزستان", new Guid("c5e273b5-365c-4f5e-8eca-4b40079d8d44") },
                    { 12, "بوشهر", new Guid("0ac642dd-0d4f-4f27-ad18-b53051ff29e8") },
                    { 13, "زنجان", new Guid("1321dba4-6c5a-43cf-9335-7afd6182e17e") },
                    { 8, "خراسان رضوي", new Guid("a97551e0-01e4-468c-9a53-a126aba25619") }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleID", "DisplayName", "ModifiedDate", "Name", "RoleGUID" },
                values: new object[,]
                {
                    { 3, "سرویس گیرنده", new DateTime(2020, 7, 1, 4, 1, 43, 345, DateTimeKind.Local).AddTicks(3962), "Client", new Guid("a7d157d3-62a7-416e-bbbd-05b648c967e2") },
                    { 1, "ادمین", new DateTime(2020, 7, 1, 4, 1, 43, 341, DateTimeKind.Local).AddTicks(9879), "Admin", new Guid("e56d3d73-50a8-4e68-8a5b-1ad2e25eeb01") },
                    { 2, "سرویس دهنده", new DateTime(2020, 7, 1, 4, 1, 43, 345, DateTimeKind.Local).AddTicks(3825), "Contractor", new Guid("7654b9c7-b371-4e7e-96e9-d5d0af9e7814") }
                });

            migrationBuilder.InsertData(
                table: "SMSProvider",
                columns: new[] { "SMSProviderID", "Name" },
                values: new object[] { 1, "Kavenegar" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "Abstract", "ActiveIconDocumentID", "CategoryGUID", "CoverDocumentID", "Description", "DisplayName", "InactiveIconDocumentID", "IsActive", "ModifiedDate", "ParentCategoryID", "QuadMenuDocumentID", "Sort" },
                values: new object[,]
                {
                    { 3, null, null, new Guid("69b561bb-9a82-407f-8933-11838efcd214"), null, null, "خانه", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(3776), 1, null, 1 },
                    { 4, null, null, new Guid("2799b953-510e-41a9-9a74-b315f7ed52d8"), null, null, "حمل و نقل", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(3788), 1, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityGUID", "Name", "ProvinceID" },
                values: new object[,]
                {
                    { 826, new Guid("343798c1-b3aa-4768-96b5-8669f3820d6c"), "ليلان", 22 },
                    { 825, new Guid("c26a56c4-4db1-45e7-a503-a658cbfdd558"), "قره آغاج", 22 },
                    { 824, new Guid("1f50663f-ed04-416d-bd5c-28b81143bbfc"), "عجب شير", 22 },
                    { 823, new Guid("1e9e44f8-5774-490d-8bf8-2ebb5a0db7b5"), "صوفيان", 22 },
                    { 822, new Guid("38d7f715-6be7-49aa-bbcf-c799c890535d"), "شهر جديد سهند", 22 },
                    { 821, new Guid("48d38316-74cf-4cea-9a29-9b37eece63c6"), "شند آباد", 22 },
                    { 820, new Guid("95385568-5dbb-4fc7-af63-2ff8f419a2db"), "شرفخانه", 22 },
                    { 819, new Guid("fee40265-1fec-4cb2-aa95-7482fdc50ed6"), "شربيان", 22 },
                    { 818, new Guid("f0f37662-583c-4b4b-9fc0-1c6b6fe4b9a5"), "شبستر", 22 },
                    { 817, new Guid("75d232c3-80f4-477b-8022-e39d2d79d87f"), "سيه رود", 22 },
                    { 816, new Guid("54b60a13-8f8f-459b-b810-e2a23dfa8211"), "سيس", 22 },
                    { 815, new Guid("38099c8e-6b7a-4d0a-ae70-cb85e7c8db73"), "سردرود", 22 },
                    { 814, new Guid("84f10d49-f662-4209-bca1-6bf41075b080"), "سراب", 22 },
                    { 813, new Guid("90e90a27-fcfe-46dd-81ee-0aa99e9afc40"), "زنوز", 22 },
                    { 812, new Guid("945076da-07cc-4957-b5ee-6a89d7aeb353"), "زرنق", 22 },
                    { 827, new Guid("9eb2ee2b-2ffa-4063-8162-72c061172173"), "مبارک شهر", 22 },
                    { 828, new Guid("c72b11d8-2674-4342-a23a-050300113cf5"), "مراغه", 22 },
                    { 829, new Guid("f84e61b9-e870-4e59-b4a7-4434ed7783bc"), "مرند", 22 },
                    { 830, new Guid("2d4447f8-29ed-4e9c-864c-36fb86e795bf"), "ملکان", 22 },
                    { 846, new Guid("9158b326-60e6-4ee8-94b6-41ad4de6d3be"), "گوگان", 22 },
                    { 845, new Guid("42b945fe-bfb5-4698-95d8-9867053b9d63"), "کوزه کنان", 22 },
                    { 844, new Guid("ea02db6b-798e-48e2-865e-b78cf717e837"), "کليبر", 22 },
                    { 843, new Guid("4b867372-3a9c-42cd-8a73-c4ce9618818b"), "کلوانق", 22 },
                    { 842, new Guid("0e04ae18-680e-42af-8668-ea44321d9d6e"), "کشکسراي", 22 },
                    { 841, new Guid("45c4a4e3-e66e-45cf-8836-6c5bf6618601"), "يامچي", 22 },
                    { 840, new Guid("e27b7f90-4f2e-4b5e-88a8-c436e6805f56"), "ورزقان", 22 },
                    { 811, new Guid("e59d46ae-afe9-4cc9-9dd7-d4a667357c17"), "دوزدوزان", 22 },
                    { 839, new Guid("abc8d4e5-c820-4f39-95e9-ebef6b739c63"), "وايقان", 22 },
                    { 837, new Guid("ec7737c2-85e8-46bf-93e8-478b69d8034e"), "هشترود", 22 },
                    { 836, new Guid("73e88d8a-d1de-4e56-82f1-b0b9d786a321"), "هريس", 22 },
                    { 835, new Guid("df980ef7-2616-45cb-a9a8-506a04d42117"), "هاديشهر", 22 },
                    { 834, new Guid("6a4f5e5a-0a63-4b2e-aa94-babe14c36875"), "نظرکهريزي", 22 },
                    { 833, new Guid("d5eb2e02-bdb7-42b8-814f-c679d4c01c55"), "ميانه", 22 },
                    { 832, new Guid("a03ba768-3e5a-4d9a-af45-3d07a2c3c2bd"), "مهربان", 22 },
                    { 831, new Guid("cb926306-d9d6-4c85-9dbe-311b33d5406b"), "ممقان", 22 },
                    { 838, new Guid("1e14e13c-1c8c-43c0-9b00-421b5c32f89e"), "هوراند", 22 },
                    { 810, new Guid("5a140b93-b8d2-4372-be39-63fb6aeee587"), "خواجه", 22 },
                    { 809, new Guid("3aad5a72-ef74-4ff6-bf95-0a9705487f95"), "خمارلو", 22 },
                    { 808, new Guid("fc6d8c5c-357d-4093-b542-a979dfc4331c"), "خسروشاه", 22 },
                    { 787, new Guid("acf00b6a-326a-4d80-8488-6e4c5d9291c9"), "آقکند", 22 },
                    { 786, new Guid("f0011b14-16ff-4746-9130-00e28ca83e45"), "آذرشهر", 22 },
                    { 785, new Guid("ed5e28c2-487a-407f-88bb-ee56ab995706"), "آبش احمد", 22 },
                    { 784, new Guid("fc549c80-c126-4e32-b549-b5260099b203"), "گلستان", 21 },
                    { 783, new Guid("f45029ac-e1d8-43b8-b441-60a6aeeb57ae"), "کيلان", 21 },
                    { 782, new Guid("b0e49ac1-0252-42b2-87c6-a18cda117bf0"), "کهريزک", 21 },
                    { 781, new Guid("412a5b94-d54c-41ad-bccf-044cd7e6fd37"), "چهاردانگه", 21 },
                    { 780, new Guid("a7e3b1a6-8248-4887-9f72-a807f7c69f5b"), "پيشوا", 21 },
                    { 779, new Guid("36adbe30-11b1-4931-80e7-718152315b82"), "پرديس", 21 },
                    { 778, new Guid("7688c6f2-390d-4d9a-b446-b74efa1f0687"), "پاکدشت", 21 },
                    { 777, new Guid("c5ab7e30-d4a8-4864-b21c-6ab3cace9044"), "ورامين", 21 },
                    { 776, new Guid("26547d5b-259a-4f6c-8135-f85046b273c8"), "وحيديه", 21 },
                    { 775, new Guid("f6c7cbf6-9fd1-47b5-b905-7a4b61ad378a"), "نصيرشهر", 21 },
                    { 774, new Guid("c1c6b4ff-f107-46f3-acbe-03227391c616"), "نسيم شهر", 21 },
                    { 773, new Guid("813fec07-562c-4bad-8f14-30f6f3b23814"), "ملارد", 21 },
                    { 788, new Guid("976668c7-6c94-4398-9f88-28bf841ea9f1"), "آچاچي", 22 },
                    { 789, new Guid("07cae751-8757-46ef-9456-3d85cf552b64"), "اسکو", 22 },
                    { 790, new Guid("0fb329f7-7a4a-4473-b995-550d0cd64246"), "اهر", 22 },
                    { 791, new Guid("40be4aee-41a7-4d7d-b379-817301e4ab43"), "ايلخچي", 22 },
                    { 807, new Guid("d5f45149-4845-4829-a8e4-f07ef496ae27"), "خداجو", 22 },
                    { 806, new Guid("4b2b549d-2466-42e1-85d1-ddf86936917a"), "خامنه", 22 },
                    { 805, new Guid("bcc93a88-850b-4041-8f35-6d7fcf11de5b"), "خاروانا", 22 },
                    { 804, new Guid("682452b8-f07b-47a7-b279-426bbed5cb81"), "جوان قلعه", 22 },
                    { 803, new Guid("d205fa6b-8703-464e-9234-d6aec57dbb82"), "جلفا", 22 },
                    { 802, new Guid("4347ee6a-947a-4aa4-9ea7-3ea43ab1c6d8"), "تيکمه داش", 22 },
                    { 801, new Guid("0a8171a4-b5a1-4644-9736-918713ce070b"), "تيمورلو", 22 },
                    { 847, new Guid("a48e919a-1dc1-44f0-af71-9fb115fa4cbb"), "آباده", 23 },
                    { 800, new Guid("be84f9db-6f72-42d5-86c1-f6211425a269"), "تسوج", 22 },
                    { 798, new Guid("50a131ee-aacf-4b3d-8b92-9d1ac4c35c4f"), "ترک", 22 },
                    { 797, new Guid("cfbfa297-dc4c-4fa1-a09b-6941c17e0db5"), "تبريز", 22 },
                    { 796, new Guid("928b4347-f5e1-4c72-9a19-de9c58df36f9"), "بناب مرند", 22 },
                    { 795, new Guid("2e215852-bf09-445d-8d78-96e7835a3219"), "بناب", 22 },
                    { 794, new Guid("a62b569c-4e30-455a-a5bc-4879cacb164a"), "بستان آباد", 22 },
                    { 793, new Guid("66f52245-73b9-482e-954f-548832037c4a"), "بخشايش", 22 },
                    { 792, new Guid("e8abeaae-7e4e-4cd4-81ee-8085ef3a5228"), "باسمنج", 22 },
                    { 799, new Guid("293fc4cf-9e4d-4b97-ba12-41cfdbbfb49e"), "ترکمانچاي", 22 },
                    { 848, new Guid("61e60cad-0e7d-485b-b879-0ea6c5230379"), "آباده طشک", 23 },
                    { 849, new Guid("1a359304-7cbb-46cc-ab00-9ebef5766418"), "اردکان", 23 },
                    { 850, new Guid("2c30ca00-200b-4fcb-8c95-883e7ea95181"), "ارسنجان", 23 },
                    { 905, new Guid("44f029cf-466b-47ab-ae6d-40643ed3c7ed"), "صغاد", 23 },
                    { 904, new Guid("08ad4300-03f5-4771-ba1c-bad92324a7fb"), "شيراز", 23 },
                    { 903, new Guid("48c37bb6-f1de-4060-9670-e2bd092f9f2c"), "شهر پير", 23 },
                    { 902, new Guid("d0882fff-0185-4cd7-8767-d81bb2456861"), "شهر جديد صدرا", 23 },
                    { 901, new Guid("6a66687c-4937-478f-9900-6c0d26090e9e"), "ششده", 23 },
                    { 900, new Guid("1313bbaf-05e2-45e3-b9c2-84946d5005e2"), "سيدان", 23 },
                    { 899, new Guid("c5543d11-8dbc-4e28-8aba-f0ca904a633d"), "سورمق", 23 },
                    { 898, new Guid("eabd8b2e-0442-45e2-9b19-28d0256fe231"), "سلطان شهر", 23 },
                    { 897, new Guid("91ff0814-51fe-4df6-a6cc-c62d8a11ce3c"), "سعادت شهر", 23 },
                    { 896, new Guid("049be95c-df10-4e1a-9de1-d520187ff3f1"), "سروستان", 23 },
                    { 895, new Guid("bb95eeec-30c0-4741-8279-dbad88e528a1"), "سده", 23 },
                    { 894, new Guid("148b1d2f-2e1a-46a3-ac21-b973a253ebbf"), "زرقان", 23 },
                    { 893, new Guid("cf4e3529-8110-4369-a272-a21c4fab53e7"), "زاهد شهر", 23 },
                    { 892, new Guid("ab811e65-876b-4ebe-8860-da0b70d9c4d0"), "رونيز", 23 },
                    { 891, new Guid("35674d2d-76bd-437a-9718-7ac98deeb6f1"), "رامجرد", 23 },
                    { 906, new Guid("426d2e37-35a5-461e-a01b-713467da3f9e"), "صفا شهر", 23 },
                    { 907, new Guid("6103c0c9-33b7-4d14-9742-b4749a5dc2eb"), "علامرودشت", 23 },
                    { 908, new Guid("884978c4-cb92-4af5-9429-d0ba67abbc15"), "عماد ده", 23 },
                    { 909, new Guid("b5a6fcf8-e1c8-4fce-96f3-ef647cc6db40"), "فدامي", 23 },
                    { 925, new Guid("4a19c609-cc02-4805-a1ac-ef22b66f7b2d"), "مرودشت", 23 },
                    { 924, new Guid("5ee8a929-d340-4866-8c6c-533f829b728a"), "مبارک آباد", 23 },
                    { 923, new Guid("8395e7e8-bd4e-4cc8-8ff7-5ad1f8674579"), "مادرسليمان", 23 },
                    { 922, new Guid("f6b08904-107e-43d1-a507-f83d65fd7e4b"), "لپوئي", 23 },
                    { 921, new Guid("cc4350c4-6874-4b89-82d5-f634255ac694"), "لطيفي", 23 },
                    { 920, new Guid("68edbce4-5310-455e-a5bb-6974ff326f5c"), "لامرد", 23 },
                    { 919, new Guid("a78ce588-a82f-4672-8f0f-1a17fca206a7"), "لار", 23 },
                    { 890, new Guid("c98ee983-fdee-409b-9ee7-4e93e52ae76e"), "دژکرد", 23 },
                    { 918, new Guid("ba492ef3-526b-40e7-8729-cc08c8779f02"), "قير", 23 },
                    { 916, new Guid("97f2811b-2556-4946-9fcc-af1e35e3ec25"), "قطب آباد", 23 },
                    { 915, new Guid("d725d963-7646-4b5e-aa96-a7602271b765"), "قره بلاغ", 23 },
                    { 914, new Guid("0199798d-6377-41b3-9350-9f18c7d2e0ab"), "قادرآباد", 23 },
                    { 913, new Guid("87ec90d1-5874-4a27-ad8e-2a5e2e7b441d"), "قائميه", 23 },
                    { 912, new Guid("f95148ec-06ea-4417-b6dd-314ac578841e"), "فيروزآباد", 23 },
                    { 911, new Guid("6a141108-8a38-4183-8a4d-97f97dce96ad"), "فسا", 23 },
                    { 910, new Guid("9cff5128-aa0a-4478-a546-5e8edea02454"), "فراشبند", 23 },
                    { 917, new Guid("d0f65dce-34c9-42a9-9fc0-3f8e7d2891fd"), "قطرويه", 23 },
                    { 889, new Guid("9e3fe009-25a4-4b79-bd16-abfd4122a058"), "دوزه", 23 },
                    { 888, new Guid("041bf6a6-a357-4e6e-b4cb-34e508d46de8"), "دوبرجي", 23 },
                    { 887, new Guid("8d936c69-907a-4cdd-a909-4c69bc1dabbf"), "دهرم", 23 },
                    { 866, new Guid("893c4540-6ca3-434c-aba3-c9308de365e7"), "بوانات", 23 },
                    { 865, new Guid("bd910263-25ce-4f7a-a239-1c5bb1d181d2"), "بهمن", 23 },
                    { 864, new Guid("2be00c21-0186-4a76-a60b-e213c41bce28"), "بنارويه", 23 },
                    { 863, new Guid("eaf05985-e5b9-478f-b998-6446f9d74599"), "بالاده", 23 },
                    { 862, new Guid("0723f3df-8fe4-4093-a4c9-6d67a320ad01"), "بابامنير", 23 },
                    { 861, new Guid("38f5cfdb-b36f-49a6-9386-d3f3c27c4dfc"), "باب انار", 23 },
                    { 860, new Guid("67d3d6c1-f086-4122-a5d5-a996913b3d16"), "ايزد خواست", 23 },
                    { 867, new Guid("c28007fb-db87-40e1-a592-1075d79d50a4"), "بيرم", 23 },
                    { 859, new Guid("99f5ad97-e7df-40a0-a8d5-946044c76b82"), "ايج", 23 },
                    { 857, new Guid("3a67acbb-4423-4c77-9394-b3ce539c69e0"), "اهل", 23 },
                    { 856, new Guid("174de023-2e6c-40c1-b65e-720dd43b2d97"), "امام شهر", 23 },
                    { 855, new Guid("bf86bba2-5e5c-497f-96b5-c498ebd06ea9"), "اقليد", 23 },
                    { 854, new Guid("57823ece-c820-4745-8f33-5f40e2da3dde"), "افزر", 23 },
                    { 853, new Guid("09b483a1-5728-4362-b742-f2a39a54eabe"), "اشکنان", 23 },
                    { 852, new Guid("c7ece4ae-b33b-4899-84ea-4ecd9b03196f"), "اسير", 23 },
                    { 851, new Guid("2e048063-be79-40e6-882d-7a45784da975"), "استهبان", 23 },
                    { 858, new Guid("5185f17c-b194-4c9b-ba16-a68f34bc5c01"), "اوز", 23 },
                    { 772, new Guid("163a7567-8f72-4a03-8e32-a6aca20b8f88"), "لواسان", 21 },
                    { 868, new Guid("c2e3c50f-981f-43ca-aa83-a688daf68be6"), "بيضا", 23 },
                    { 870, new Guid("0cc94898-44f2-477b-8ffd-df7c4de95188"), "جهرم", 23 },
                    { 886, new Guid("00bc5c55-d028-4395-8829-830eb00ebe9b"), "دبيران", 23 },
                    { 885, new Guid("1d174281-e391-4c70-8586-4f200a83b07e"), "داريان", 23 },
                    { 884, new Guid("a936d2a2-aa3f-4f50-a62c-8f239756b8e9"), "داراب", 23 },
                    { 883, new Guid("5e8c378d-7e37-450d-9199-50be991a2467"), "خومه زار", 23 },
                    { 882, new Guid("ad152136-b207-4245-8e7d-d680397b3b69"), "خوزي", 23 },
                    { 881, new Guid("dad480b4-0c0e-4be4-8a17-cb836d97eb9c"), "خور", 23 },
                    { 880, new Guid("ee921608-ca60-4ef7-9a4b-5bef8ab50ab9"), "خنج", 23 },
                    { 869, new Guid("39ba8354-41ad-484e-ac4c-90543430e31e"), "جنت شهر", 23 },
                    { 879, new Guid("8081a1dc-23e6-4ff8-95ce-97bfec3f5da4"), "خشت", 23 },
                    { 877, new Guid("3d59abf7-684d-4019-b09d-8d3959448b5d"), "خاوران", 23 },
                    { 876, new Guid("22bfd9e2-b8a8-45c1-b457-4b8d194127ff"), "خانيمن", 23 },
                    { 875, new Guid("b3fb7218-53b9-4d33-8004-6e9bbdb2ea64"), "خانه زنيان", 23 },
                    { 874, new Guid("bd50bcfd-df84-4ee9-ad0b-0b1d55f708c2"), "حسن آباد", 23 },
                    { 873, new Guid("5215eaa3-8b0f-48b5-96dd-10ae3363933c"), "حسامي", 23 },
                    { 872, new Guid("7309f884-0830-4d69-9602-aa7743f9e1a4"), "حاجي آباد", 23 },
                    { 871, new Guid("dd2cedc5-10bb-4054-ace3-52b79fda7c94"), "جويم", 23 },
                    { 878, new Guid("6d54c6c2-bacd-4dc6-bdc5-a5823c3ca146"), "خرامه", 23 },
                    { 771, new Guid("78ce1e59-25f4-4c70-8e96-4ca1a329316d"), "قرچک", 21 },
                    { 770, new Guid("bbe07848-51ea-497b-8036-02bae62aa5ce"), "قدس", 21 },
                    { 769, new Guid("a68b581c-f082-4c91-ac68-e3f2720e3588"), "فيروزکوه", 21 },
                    { 669, new Guid("63b6f893-56ec-4e67-a45e-84387d86782f"), "عسگران", 19 },
                    { 668, new Guid("d906737d-0c2f-4547-9643-4a14ab7610de"), "طرق رود", 19 },
                    { 667, new Guid("15538f80-0754-44ab-b534-2c6ea112dcb8"), "طالخونچه", 19 },
                    { 666, new Guid("5a4a8946-d3dd-48f1-968a-8728f98cef4b"), "شهرضا", 19 },
                    { 665, new Guid("9fc5e1d9-49c6-4863-a8f1-b379f5793e21"), "شاپورآباد", 19 },
                    { 664, new Guid("97d5b4f4-28ab-4452-87ce-7e96c7bc7f89"), "شاهين شهر", 19 },
                    { 663, new Guid("3e47f81f-974c-4af5-a2a5-0dd13975a3b6"), "سگزي", 19 },
                    { 662, new Guid("e92c55dc-7586-4dca-b955-7ba9661a2679"), "سين", 19 },
                    { 661, new Guid("e00b94ca-c7b2-4e79-adc2-7941aa23e8a0"), "سميرم", 19 },
                    { 660, new Guid("16b2697b-3266-499b-a5fc-0bfba3613a93"), "سفيد شهر", 19 },
                    { 659, new Guid("933134d9-29c5-404e-9463-3b092d3f10e5"), "سده لنجان", 19 },
                    { 658, new Guid("5f552c98-7990-4881-bce3-4387c4d6515a"), "زيباشهر", 19 },
                    { 657, new Guid("62137eef-fb00-4322-a2c6-0c77a4a76da6"), "زيار", 19 },
                    { 656, new Guid("8d5767cb-760d-4c21-8060-ccdef818c07f"), "زواره", 19 },
                    { 655, new Guid("0abe54e4-90c6-435b-8dae-7c69682b6377"), "زرين شهر", 19 },
                    { 670, new Guid("9848df69-aa9d-4b17-a484-e251ecc4c47d"), "علويچه", 19 },
                    { 671, new Guid("e9aedaaa-35f7-4477-8671-65c7636ac924"), "فرخي", 19 },
                    { 672, new Guid("ac8c83fb-be9d-4785-8f3b-2adce1320fc2"), "فريدونشهر", 19 },
                    { 673, new Guid("c112d400-9667-4305-a43a-85d9abfbf087"), "فلاورجان", 19 },
                    { 689, new Guid("7a1bbaa6-8796-4ba8-9ae4-09de0b1a4361"), "نوش آباد", 19 },
                    { 688, new Guid("5f2da656-5714-49ba-bc1d-a66c56af3bb4"), "نطنز", 19 },
                    { 687, new Guid("a3a05c2c-4c47-40bb-a777-4db157adbeee"), "نصرآباد", 19 },
                    { 686, new Guid("1fd7a064-aebe-45e6-aef2-8e96f425891b"), "نجف آباد", 19 },
                    { 685, new Guid("8bbadd2b-15eb-443b-8104-fc65815b36d2"), "نائين", 19 },
                    { 684, new Guid("b59e3d97-411c-4b39-a224-3f1509efa7a4"), "ميمه", 19 },
                    { 683, new Guid("b15863e9-40e4-4741-b17f-52024c6fda87"), "مهاباد", 19 },
                    { 654, new Guid("259f78db-93e6-42ce-8eb3-25963220ff1c"), "زاينده رود", 19 },
                    { 682, new Guid("e01f3e25-ee23-45f7-8d6d-a7a3935a696d"), "منظريه", 19 },
                    { 680, new Guid("fa0428ec-84d8-439d-bcc2-ee326f361bfb"), "محمد آباد", 19 },
                    { 679, new Guid("d5de4c3a-e25e-45fc-b55d-ec5eba3e2814"), "مبارکه", 19 },
                    { 678, new Guid("d507f714-dfb5-4872-8443-4f04fbe72419"), "لاي بيد", 19 },
                    { 677, new Guid("53db7dfa-6eb5-4814-9c51-3671ee9880e1"), "قهدريجان", 19 },
                    { 676, new Guid("c9114e8a-641b-4fd6-a984-7a6cfbc54a8d"), "قهجاورستان", 19 },
                    { 675, new Guid("1709d388-b289-4ef4-93e7-47ab55ea4e55"), "قمصر", 19 },
                    { 674, new Guid("f19fb6fc-3e44-49ba-9581-9cb6fc80ea7c"), "فولاد شهر", 19 },
                    { 681, new Guid("7d31c191-df54-44e5-93c2-d583e213ed6b"), "مشکات", 19 },
                    { 653, new Guid("64cef554-99b4-4f88-8081-29f98be0c51c"), "زازران", 19 },
                    { 652, new Guid("259e0ee9-88fc-4f63-8046-1c65414117be"), "رضوانشهر", 19 },
                    { 651, new Guid("76ba9e13-ebcc-4f4a-8acd-d7518a0e3f1e"), "رزوه", 19 },
                    { 630, new Guid("1dc6207f-9ee8-4768-b127-a61b3b800235"), "تودشک", 19 },
                    { 629, new Guid("d88c64d6-c367-4fe1-9ffd-807bf6cb1beb"), "بوئين مياندشت", 19 },
                    { 628, new Guid("e41621ae-ccb4-46c5-a8bb-6e68c9daed97"), "بهارستان", 19 },
                    { 627, new Guid("60c9c346-1689-46d1-80b3-d50afe14d277"), "بهاران شهر", 19 },
                    { 626, new Guid("97bc0089-6e99-4a3e-a94d-998f22e3de1e"), "برف انبار", 19 },
                    { 625, new Guid("8abad7b2-5281-4b23-a5c9-04a29b2a1347"), "برزک", 19 },
                    { 624, new Guid("b0bd6d33-f3b5-4b3f-88a4-c84d6d75377e"), "بافران", 19 },
                    { 631, new Guid("edbc7731-c51e-4be7-b548-908917f74b1c"), "تيران", 19 },
                    { 623, new Guid("81e7808b-9909-4c3a-bee0-d0b0e6353a87"), "باغشاد", 19 },
                    { 621, new Guid("da2fe109-f453-409c-8f69-17d832e36ed6"), "بادرود", 19 },
                    { 620, new Guid("47ac0ac9-9651-4cb5-8e5d-fdc4caca6569"), "اژيه", 19 },
                    { 619, new Guid("63637bb0-142c-4397-a09c-8195602541da"), "ايمانشهر", 19 },
                    { 618, new Guid("f33010af-dfa1-4557-b910-42e8e1626861"), "انارک", 19 },
                    { 617, new Guid("37382e36-6a18-49de-9567-208535fe26b4"), "افوس", 19 },
                    { 616, new Guid("b7d39995-685b-496a-85cc-0a01c6af7104"), "اصفهان", 19 },
                    { 615, new Guid("9f601e8b-96c4-4756-adf5-64eab02f3fd2"), "اصغرآباد", 19 },
                    { 622, new Guid("c8f417aa-ff11-47f2-b289-b41ddb8efb6f"), "باغ بهادران", 19 },
                    { 690, new Guid("0256bbd9-0591-4bd6-a996-555aedda4e6c"), "نياسر", 19 },
                    { 632, new Guid("ddac2403-541b-493d-9ee5-0c492a6ac9c7"), "جندق", 19 },
                    { 634, new Guid("fc8bf5cf-037d-4617-bc04-75f9b8de9fd9"), "جوشقان قالي", 19 },
                    { 650, new Guid("47cb16ec-0c04-445d-9a0f-3e5f3af519a7"), "ديزيچه", 19 },
                    { 649, new Guid("ae808e82-2cd4-4fe6-93ef-8e16a88fd01f"), "دولت آباد", 19 },
                    { 648, new Guid("5a7e3f8a-6be1-4cde-919d-ab991eb115ae"), "دهق", 19 },
                    { 647, new Guid("82ef117f-37da-4a47-b754-fd97033accf6"), "دهاقان", 19 },
                    { 646, new Guid("d6544660-8a0e-46a2-97b9-bb7c53c484f5"), "دستگرد", 19 },
                    { 645, new Guid("16551f8b-5a80-4af7-9048-c0eee0a56b8f"), "درچه پياز", 19 },
                    { 644, new Guid("4c95ff35-9a02-4797-9ded-34cb7d2d66a9"), "دامنه", 19 },
                    { 633, new Guid("1a1f5518-9fab-490a-958d-dd2143a03e03"), "جوزدان", 19 },
                    { 643, new Guid("2e55b6a2-ad7a-4668-93d1-40c250909999"), "داران", 19 },
                    { 641, new Guid("75bd649e-13e3-4523-94f7-cc5c512b688a"), "خور", 19 },
                    { 640, new Guid("7fd00bed-ebc7-4c33-bf84-7384b0e59142"), "خوانسار", 19 },
                    { 639, new Guid("4b869f15-deea-43e4-8019-cc9b8fd1c9cb"), "خميني شهر", 19 },
                    { 638, new Guid("ad61af53-02d4-4dc1-8d0e-482cd18a53c0"), "خالد آباد", 19 },
                    { 637, new Guid("683a8289-7fab-4af3-8abc-656591953f38"), "حنا", 19 },
                    { 636, new Guid("03207074-ce60-4140-b6e6-ba8b81b9b5a5"), "حسن آباد", 19 },
                    { 635, new Guid("de54caff-8926-441d-bfc8-84952212642d"), "حبيب آباد", 19 },
                    { 642, new Guid("c40e1738-3b7d-4729-8f02-7a887394dd61"), "خورزوق", 19 },
                    { 926, new Guid("ef85bd0c-4ef0-4169-822d-17918d19b616"), "مزايجان", 23 },
                    { 691, new Guid("32ef5072-5e9c-4cfb-afea-fe31bbb5ef6e"), "نيک آباد", 19 },
                    { 693, new Guid("843a6cf6-18f8-4630-be5a-576d72b7a5e0"), "ورزنه", 19 },
                    { 748, new Guid("090a774b-159f-4dd2-8340-9c076f5c30eb"), "باقرشهر", 21 },
                    { 747, new Guid("21263f2d-d694-4585-9314-b6257358bfd8"), "باغستان", 21 },
                    { 746, new Guid("156b074c-3d2b-43bc-95fe-ae43f1f6d091"), "انديشه", 21 },
                    { 745, new Guid("e260b08d-e9b4-4b2c-857f-bf291ab13cc3"), "اسلامشهر", 21 },
                    { 744, new Guid("ce762df8-14ef-4438-a24a-123fcfc40647"), "ارجمند", 21 },
                    { 743, new Guid("5dfe2625-a99c-4bed-890d-bc6cbc2743f0"), "آبعلي", 21 },
                    { 742, new Guid("9a70aa11-259c-441d-8bf9-a0e446632817"), "آبسرد", 21 },
                    { 741, new Guid("33ffdcf5-5be6-42c2-9c8d-b58278ef5f67"), "چوار", 20 },
                    { 740, new Guid("42c8e031-2b72-44fd-85de-bc5f8585ad10"), "پهله", 20 },
                    { 739, new Guid("e2bd5bab-9e31-4400-899f-125fc8311960"), "ميمه", 20 },
                    { 738, new Guid("890ea33b-cd54-43d4-ae3a-299ed763c1ac"), "موسيان", 20 },
                    { 737, new Guid("197ab6d5-9c44-46a3-8eeb-7d7d593bd53e"), "مورموري", 20 },
                    { 736, new Guid("8f162892-a75c-41c4-9f07-a8ce520cc8e9"), "مهران", 20 },
                    { 735, new Guid("513a5ed4-b6b9-4b74-9ced-313aef482cf0"), "مهر", 20 },
                    { 734, new Guid("5268299b-10c6-4072-a431-1c1e8de8e83d"), "ماژين", 20 },
                    { 749, new Guid("7562b13f-7fee-4ea3-a107-09e1084e2bdb"), "بومهن", 21 },
                    { 750, new Guid("389ad7c1-9c19-4658-98ce-dd2c9685cf75"), "تجريش", 21 },
                    { 751, new Guid("2d612d42-388c-4619-bd72-cdad6d6b7e09"), "تهران", 21 },
                    { 752, new Guid("48d6a6cc-abaa-4648-95dd-7af721379fcc"), "جواد آباد", 21 },
                    { 768, new Guid("b3cab41c-0cf4-432d-9b82-95c418c20bbe"), "فشم", 21 },
                    { 767, new Guid("37706b30-9d67-4975-bad2-e5fadfe392ee"), "فرون آباد", 21 },
                    { 766, new Guid("462d2b15-fede-4ec2-95e6-73960c493b53"), "فردوسيه", 21 },
                    { 765, new Guid("262f2a16-0799-4f3d-a128-0eed8f426b72"), "صفادشت", 21 },
                    { 764, new Guid("aa43ce4d-36ff-4d15-8649-c68492802e34"), "صبا شهر", 21 },
                    { 763, new Guid("abc55fd2-ba7c-4e80-a6a9-90e4afc66a9a"), "صالحيه", 21 },
                    { 762, new Guid("36da974f-303b-4630-95fa-883406e77aec"), "شهريار", 21 },
                    { 733, new Guid("9de21481-c43a-4a27-8d39-4583e94cd0a2"), "لومار", 20 },
                    { 761, new Guid("25ca9a38-2f5d-47d7-bb33-af914fc21d50"), "شهر جديد پرند", 21 },
                    { 759, new Guid("8145bf23-cf8f-45a3-89d7-0ec86fe096b9"), "شريف آباد", 21 },
                    { 758, new Guid("6f9e80c2-d7bf-406d-a9cb-92e3b1383ee5"), "شاهدشهر", 21 },
                    { 757, new Guid("621d5e67-ece9-45f1-9af1-40d71102575e"), "ري", 21 },
                    { 756, new Guid("c2ee75db-f0ec-41ae-8838-7273ad1afb60"), "رودهن", 21 },
                    { 755, new Guid("93dbb0dd-ac94-4c76-a5f6-ee478b63a5b3"), "رباط کريم", 21 },
                    { 754, new Guid("10490229-72ec-4d2e-8a73-5591629b6682"), "دماوند", 21 },
                    { 753, new Guid("3d0c23b4-da03-45c9-b924-361904538082"), "حسن آباد", 21 },
                    { 760, new Guid("906bf29f-0f81-4a5b-95f7-650a1d3d3005"), "شمشک", 21 },
                    { 732, new Guid("5c62ced4-47b7-4791-8970-5401357a734f"), "صالح آباد", 20 },
                    { 731, new Guid("b328f447-e5a9-40c7-a143-d1456aa536e5"), "شباب", 20 },
                    { 730, new Guid("8e4c1d65-31c8-46a6-821b-feb04127a2e4"), "سرابله", 20 },
                    { 709, new Guid("69582eef-a14c-454f-accd-4ef9b471f1eb"), "کوهپايه", 19 },
                    { 708, new Guid("f59d8c47-2d4b-4de6-929e-d6f36033ceae"), "کوشک", 19 },
                    { 707, new Guid("88687c4d-34a9-4a33-9432-eb2fd82fa364"), "کهريزسنگ", 19 },
                    { 706, new Guid("e218794e-87df-459f-8362-227f755ffcad"), "کمه", 19 },
                    { 705, new Guid("c990a0c0-e5a5-4243-9df9-abd6185e682f"), "کمشجه", 19 },
                    { 704, new Guid("fa744380-5a0a-4702-ab89-1aed6d594422"), "کليشاد و سودرجان", 19 },
                    { 703, new Guid("b986d8f4-3b1f-40a0-a822-f82892817c81"), "کرکوند", 19 },
                    { 710, new Guid("aa7ac99e-167b-4401-8713-943889b8854d"), "گرگاب", 19 },
                    { 702, new Guid("bb17d753-1422-4637-aa46-b763f3a08577"), "کامو و چوگان", 19 },
                    { 700, new Guid("c7a87338-ae06-4202-b968-e1c17f41662c"), "چمگردان", 19 },
                    { 699, new Guid("622e5433-4ac3-469c-aeaa-865a2ebbe4e7"), "چرمهين", 19 },
                    { 698, new Guid("767ac762-c7c8-4420-a4a8-3d34b0b854f3"), "چادگان", 19 },
                    { 697, new Guid("97bcfe2c-105a-4bd6-86b5-3d8fb62181bc"), "پير بکران", 19 },
                    { 696, new Guid("7b7c809b-1080-4253-8040-5e0804046b47"), "ونک", 19 },
                    { 695, new Guid("72bde7f4-a238-421b-b987-5726187bb8a5"), "وزوان", 19 },
                    { 694, new Guid("f475e4e8-757a-4574-82da-fd21e3afabc4"), "ورنامخواست", 19 },
                    { 701, new Guid("58ebcfef-5a8e-45bb-8cc5-3a5a96e3c290"), "کاشان", 19 },
                    { 692, new Guid("1903bd62-1ac9-4037-bdab-d793658b1a18"), "هرند", 19 },
                    { 711, new Guid("727fc34a-8d57-403f-9d24-b7a463502301"), "گز برخوار", 19 },
                    { 713, new Guid("7c85eda8-4026-4a04-b3cf-91d5f2a74fa2"), "گلشن", 19 },
                    { 729, new Guid("4f887d29-3845-4a73-a299-aa1a5741b1a4"), "سراب باغ", 20 },
                    { 728, new Guid("63cf4afe-390a-493d-b353-a725e736f93b"), "زرنه", 20 },
                    { 727, new Guid("5fe9eeed-8e86-4207-bc99-a495dd4b4e2d"), "دهلران", 20 },
                    { 726, new Guid("a1344071-ce64-4742-8a2b-4dec0f0cb708"), "دلگشا", 20 },
                    { 725, new Guid("c27de786-cdcd-4306-9ffe-f3231ae0a282"), "دره شهر", 20 },
                    { 724, new Guid("d12ddbe3-9c00-49fc-9634-9b06b58d6dec"), "توحيد", 20 },
                    { 723, new Guid("4ad8e4c6-0ffa-46da-930c-44287bdc190b"), "بلاوه", 20 },
                    { 712, new Guid("2c08ddaa-cbfe-44e8-9b56-4af54378e383"), "گلدشت", 19 },
                    { 722, new Guid("180bc47a-5ab2-4f93-a691-cc3d4a220e75"), "بدره", 20 },
                    { 720, new Guid("88b9f428-8122-4b58-b5be-1641bfdb3541"), "ايلام", 20 },
                    { 719, new Guid("d4f46b46-1eff-464c-a603-199c9bfdffc4"), "ارکواز", 20 },
                    { 718, new Guid("8072799a-73bd-4497-8a7d-ca7ce427c76c"), "آسمان آباد", 20 },
                    { 717, new Guid("d68f8101-b760-4acb-8659-13e68f94c8d9"), "آبدانان", 20 },
                    { 716, new Guid("b180b1f4-b6e5-4cdc-b6c6-38fe21eef395"), "گوگد", 19 },
                    { 715, new Guid("c1c854a0-a7e6-4e51-a5cb-6ba5974f5e1f"), "گلپايگان", 19 },
                    { 714, new Guid("395c8ebe-0ef9-4143-8c2b-39226cec45ad"), "گلشهر", 19 },
                    { 721, new Guid("18a5ebe8-90ee-4bfe-8e53-28d7c5729e9a"), "ايوان", 20 },
                    { 927, new Guid("08fb9d55-542d-4413-9607-c1381199f196"), "مشکان", 23 },
                    { 928, new Guid("f3a8a871-0064-48ad-b11d-18ef37a69cc6"), "مصيري", 23 },
                    { 929, new Guid("f2f6f20c-0f0f-4a92-8223-676c705adca6"), "مهر", 23 },
                    { 1141, new Guid("ac5d01be-850c-4c3a-aed8-902bf7f71e83"), "بردسير", 29 },
                    { 1140, new Guid("5a3d76ef-ce35-4c59-9ffd-11fc736d56dc"), "بافت", 29 },
                    { 1139, new Guid("614e6be0-5985-4348-bf50-cb7d36667b4c"), "باغين", 29 },
                    { 1138, new Guid("73d6fd25-6d7b-4f98-be25-5d24e62e31ef"), "اندوهجرد", 29 },
                    { 1137, new Guid("069652d2-5949-4516-9ff9-4c4324c58f1d"), "انار", 29 },
                    { 1136, new Guid("69c9a291-9c71-4671-bcca-201d47517968"), "امين شهر", 29 },
                    { 1135, new Guid("de401282-c52b-40fe-9cf9-cacdb1a9f81b"), "ارزوئيه", 29 },
                    { 1134, new Guid("fb1648ae-5f7a-43cc-a774-acb6a088551c"), "اختيار آباد", 29 },
                    { 1133, new Guid("97944f0c-12df-4bd4-9452-54ca3716a7d5"), "گيان", 28 },
                    { 1132, new Guid("da66dda4-895e-4813-86c4-bfb7443c80f3"), "گل تپه", 28 },
                    { 1131, new Guid("cf830d87-7079-4576-9623-a68187c54f13"), "کبودر آهنگ", 28 },
                    { 1130, new Guid("953718b1-062b-4cc3-9236-2b5b53d3839d"), "همدان", 28 },
                    { 1129, new Guid("ace87a76-9ad1-4141-8d38-5bb3062ac602"), "نهاوند", 28 },
                    { 1128, new Guid("e7896c08-0ca5-413f-8a3e-bff89ef2eea9"), "مهاجران", 28 },
                    { 1127, new Guid("a381d5eb-ba7d-414a-87ab-17d88856011a"), "ملاير", 28 },
                    { 1142, new Guid("d0a0596d-d16d-4de7-8aab-5930ca81c0aa"), "بروات", 29 },
                    { 1143, new Guid("23d6f3ed-dbea-429a-9b49-097be357f2d3"), "بزنجان", 29 },
                    { 1144, new Guid("19bf04b4-ab68-48d6-8835-a8af3040fd5e"), "بلورد", 29 },
                    { 1145, new Guid("8a0f2d8c-7a77-4062-b8e1-9bd94d3fab70"), "بلوک", 29 },
                    { 1161, new Guid("bbefc8fb-e20b-4d90-b1c4-03a8641664f8"), "راور", 29 },
                    { 1160, new Guid("5b3cebb5-4674-422c-a487-5d156ee868b9"), "رابر", 29 },
                    { 1159, new Guid("51a6c709-2d65-44fc-9191-120c451b4fdd"), "دوساري", 29 },
                    { 1158, new Guid("c64c4456-468a-4629-a631-216c139ef078"), "دهج", 29 },
                    { 1157, new Guid("d9a5f80e-bb02-4aeb-b033-cd4311c7e24f"), "دشتکار", 29 },
                    { 1156, new Guid("bf8d6c72-e057-4de0-bca3-1eb541eef7eb"), "درب بهشت", 29 },
                    { 1155, new Guid("b548e338-b622-45ce-8cd5-cfaf3233f338"), "خورسند", 29 },
                    { 1126, new Guid("ce204e1d-8e47-4aef-8d83-4b9df2f6687e"), "مريانج", 28 },
                    { 1154, new Guid("2d96ae14-2442-48c6-9f08-4e48c10ab9ed"), "خواجوشهر", 29 },
                    { 1152, new Guid("9cbe3944-7923-4642-a079-f403f836d076"), "خاتون آباد", 29 },
                    { 1151, new Guid("a3c146e6-1eb2-442d-a907-8c822e0e7cda"), "جيرفت", 29 },
                    { 1150, new Guid("63d2d292-4026-407f-95ea-a8baef6a7bb5"), "جوپار", 29 },
                    { 1149, new Guid("57ff1083-916b-412d-b6e9-52817afe39de"), "جوزم", 29 },
                    { 1148, new Guid("507d8828-63e0-46ac-8217-a1fa66036aec"), "جبالبارز", 29 },
                    { 1147, new Guid("373487e5-e63a-47ab-afd6-fdc94cb5d228"), "بهرمان", 29 },
                    { 1146, new Guid("8ecefa7d-0fd5-44c6-9e3b-fdf5252ec9c0"), "بم", 29 },
                    { 1153, new Guid("d1950f16-e1cc-4db6-8f4a-e9658a44ac5d"), "خانوک", 29 },
                    { 1162, new Guid("95a38c37-7ba1-4020-b682-ff36cd0f01d1"), "راين", 29 },
                    { 1125, new Guid("0821323a-02fb-44f3-ac54-e6949b926862"), "لالجين", 28 },
                    { 1123, new Guid("9817529e-b714-49b9-ab02-3dab8956b5e2"), "قروه در جزين", 28 },
                    { 1102, new Guid("a6386a16-40bb-4c6f-97d7-6df092d91291"), "کوچصفهان", 27 },
                    { 1101, new Guid("f8da348d-2490-449e-9504-0289f822a200"), "کومله", 27 },
                    { 1100, new Guid("536afefb-baae-4cf4-bdcb-b030c9d2b3ac"), "کلاچاي", 27 },
                    { 1099, new Guid("138f2fd5-a6e1-4418-8eab-ab3c40217d74"), "چوبر", 27 },
                    { 1098, new Guid("1d270bce-affa-4fcc-b0ce-ab4b49e6f5f3"), "چاف و چمخاله", 27 },
                    { 1097, new Guid("638bb611-f70c-4fc2-ad16-5763adc34fa6"), "چابکسر", 27 },
                    { 1096, new Guid("b26b00af-6a32-4a90-8225-bd3f562257f6"), "پره سر", 27 },
                    { 1095, new Guid("7d0adb9f-0df0-464d-ab85-acbda2b93cbf"), "واجارگاه", 27 },
                    { 1094, new Guid("fe2de318-7ef7-41cf-85ee-474edd970b6d"), "هشتپر", 27 },
                    { 1093, new Guid("da9806db-e360-4a44-ad90-678d3928f7ad"), "منجيل", 27 },
                    { 1092, new Guid("acc5790f-3dc3-4e89-9a9d-fd9ea34f0c8d"), "مرجقل", 27 },
                    { 1091, new Guid("dd4e1645-2d75-426a-8178-171871a219da"), "ماکلوان", 27 },
                    { 1090, new Guid("84a06216-684e-4856-85ac-2ff6312716b5"), "ماسوله", 27 },
                    { 1089, new Guid("18962054-2aab-46e8-9597-a4c0e9782d37"), "ماسال", 27 },
                    { 1088, new Guid("4eb3eb22-37fe-4891-8a2c-16d6b71f2aca"), "ليسار", 27 },
                    { 1103, new Guid("867a1ad4-3f04-495a-8e87-85336bc83628"), "کياشهر", 27 },
                    { 1104, new Guid("80bd1434-6018-4eaf-9a30-857330597e4a"), "گوراب زرميخ", 27 },
                    { 1105, new Guid("0e122f7e-8983-46a7-829f-422f9f5d2e4f"), "آجين", 28 },
                    { 1106, new Guid("f3efc977-c44c-42ce-8add-1ff9b3333edb"), "ازندريان", 28 },
                    { 1122, new Guid("36e689c0-b47d-4dab-a3c3-73332ab2564b"), "فيروزان", 28 },
                    { 1121, new Guid("3d5f07e5-606f-4314-bf96-5b64c326d79a"), "فرسفج", 28 },
                    { 1120, new Guid("d6a6fadd-c8f8-46e6-978b-a883fcf16fb6"), "فامنين", 28 },
                    { 1119, new Guid("2af83a57-26a2-4e13-931a-d4bfc9990ef8"), "صالح آباد", 28 },
                    { 1118, new Guid("360bdc4d-4dc2-47ad-8f36-d5d8e2e32051"), "شيرين سو", 28 },
                    { 1117, new Guid("9cf7744b-6b7b-45a8-b4d4-7b2b81b472e8"), "سرکان", 28 },
                    { 1116, new Guid("1ebac366-5378-49a9-9564-98889f44a48b"), "سامن", 28 },
                    { 1124, new Guid("aa8f9baf-bb4b-4391-9358-a954d39b67e8"), "قهاوند", 28 },
                    { 1115, new Guid("6bf96ced-7d69-4860-8827-21dfeb660f6a"), "زنگنه", 28 },
                    { 1113, new Guid("df5ef7d3-5b63-4c65-ac41-92a6a498e4c5"), "دمق", 28 },
                    { 1112, new Guid("7d844106-b62a-408b-b692-a40ac07d3580"), "جوکار", 28 },
                    { 1111, new Guid("ae5d4dd3-0ba8-4899-999f-d6bb3147e4e5"), "جورقان", 28 },
                    { 1110, new Guid("b923db38-20d8-48e4-9044-f2426e45087e"), "تويسرکان", 28 },
                    { 1109, new Guid("4928350b-990a-4436-8a81-0d3523ebe529"), "بهار", 28 },
                    { 1108, new Guid("fb4e7b4b-9884-440f-a063-b4e43c5423d2"), "برزول", 28 },
                    { 1107, new Guid("b57398d6-492e-47fc-82d7-d67ae476f4ca"), "اسد آباد", 28 },
                    { 1114, new Guid("54601d73-5ec1-4a99-b378-93fe8e412d1a"), "رزن", 28 },
                    { 1163, new Guid("d751afe9-3db4-4107-92f0-8901a5f5220b"), "رفسنجان", 29 },
                    { 1164, new Guid("e9b31f29-6513-4585-8527-a9d200b7eaeb"), "رودبار", 29 },
                    { 1165, new Guid("1686fe89-a377-45dd-a174-e1921f4a8cd3"), "ريحان", 29 },
                    { 1220, new Guid("7c786378-71b5-4f59-8625-2c14a53ccfa1"), "ميامي", 30 },
                    { 1219, new Guid("54e67897-bf70-4182-b2a4-23b486073006"), "مهدي شهر", 30 },
                    { 1218, new Guid("fb461f34-5d0f-4e71-80d3-e24457dfc131"), "مجن", 30 },
                    { 1217, new Guid("eca355fb-bc3b-44fb-a7ea-56f346ab0de7"), "شهميرزاد", 30 },
                    { 1216, new Guid("60aa3bd0-47da-4bec-b0a9-c5fa758249be"), "شاهرود", 30 },
                    { 1215, new Guid("2b7c5ec4-5d97-40d4-bf7b-3c86966ce3c4"), "سمنان", 30 },
                    { 1214, new Guid("fcb4b2db-8410-46ae-af12-2cd689a121e4"), "سرخه", 30 },
                    { 1213, new Guid("6d20f283-977d-48ce-a675-63602a9422b5"), "روديان", 30 },
                    { 1212, new Guid("f91e1820-00b0-4d19-93c7-786a823ed525"), "ديباج", 30 },
                    { 1211, new Guid("9f0a5ad4-dfaa-44f7-8b94-fb259e2fff04"), "درجزين", 30 },
                    { 1210, new Guid("1566d91f-22d3-4d95-a377-c48ff4251eb7"), "دامغان", 30 },
                    { 1209, new Guid("1e382b05-9ab9-4216-b201-fdb4dbf6e0f2"), "بيارجمند", 30 },
                    { 1208, new Guid("b3edf3a1-7dc5-47fc-a1f9-9ed418e8b9f2"), "بسطام", 30 },
                    { 1207, new Guid("97c8c115-70d0-418b-949b-f5e095014d3c"), "ايوانکي", 30 },
                    { 1206, new Guid("c4b73751-c984-4a34-a8ed-63d74c98e958"), "اميريه", 30 },
                    { 1221, new Guid("aee29965-7e61-40d6-9252-d0267d29a48d"), "کلاته", 30 },
                    { 1222, new Guid("3dea9526-330a-41ef-9bdc-3842faa8635a"), "کلاته خيج", 30 },
                    { 1223, new Guid("80228196-e178-4c3e-bce2-e542b81d2f77"), "کهن آباد", 30 },
                    { 1224, new Guid("1383267d-dfa2-4c4d-a915-f66c3be839da"), "گرمسار", 30 },
                    { 1240, new Guid("f5ada876-e480-4a17-b4c3-5de9201f4a78"), "چيتاب", 31 },
                    { 1239, new Guid("959ccbfc-73e8-4810-af1c-3c2418ee2cd4"), "چرام", 31 },
                    { 1238, new Guid("d27fe5bf-9aa0-4edd-a5c8-562f5364c644"), "پاتاوه", 31 },
                    { 1237, new Guid("92b74fb7-1575-4e58-89db-054b772b041b"), "ياسوج", 31 },
                    { 1236, new Guid("3a557afc-c8f4-4c16-bc82-00b4a0d153b5"), "مارگون", 31 },
                    { 1235, new Guid("a8254660-1a5a-4223-aa93-b8a04484da27"), "مادوان", 31 },
                    { 1234, new Guid("65d447b1-0d6b-4bda-8368-4ede7eac5223"), "ليکک", 31 },
                    { 1205, new Guid("ced1d2cd-2bb2-4d9a-a553-fd072357651b"), "آرادان", 30 },
                    { 1233, new Guid("b0f964c3-630d-4e70-8836-93a077769e4d"), "لنده", 31 },
                    { 1231, new Guid("c870fce2-0747-4277-89b2-2d34dd1a18c3"), "سي سخت", 31 },
                    { 1230, new Guid("3114cb5b-e52d-4455-87ad-9f4ef2d9a612"), "سوق", 31 },
                    { 1229, new Guid("3673f239-f575-4d12-b367-5d056092f374"), "سرفارياب", 31 },
                    { 1228, new Guid("8be0d644-2622-4191-a93d-4174e2c47c2a"), "ديشموک", 31 },
                    { 1227, new Guid("ef2f8827-1c5a-46e2-a1e0-d709c42e6145"), "دوگنبدان", 31 },
                    { 1226, new Guid("4baf65e5-1bf4-4eed-9381-cbebd955e9a5"), "دهدشت", 31 },
                    { 1225, new Guid("03273975-8034-4ee9-890e-1620f9c75200"), "باشت", 31 },
                    { 1232, new Guid("9aee5465-92a3-438a-831a-ced74a2750d6"), "قلعه رئيسي", 31 },
                    { 1204, new Guid("7223121d-f3b6-4e2e-ab73-b5411fb5ffa0"), "گنبکي", 29 },
                    { 1203, new Guid("8ad73508-9ea9-43da-8248-41e5ac82769f"), "گلزار", 29 },
                    { 1202, new Guid("40928f53-f026-40fa-9295-e3bd8cd65777"), "گلباف", 29 },
                    { 1181, new Guid("edd2d92a-aa59-43fa-8890-bf2161f7e9b3"), "محي آباد", 29 },
                    { 1180, new Guid("fe470f25-1c44-4520-8e86-2febe3c1c0c4"), "محمد آباد", 29 },
                    { 1179, new Guid("d196f294-8d79-4e52-9dc3-08f5f5d38e2d"), "ماهان", 29 },
                    { 1178, new Guid("8fcd99bd-ab62-4410-a516-20f5362555cd"), "لاله زار", 29 },
                    { 1177, new Guid("e0c69471-6577-4c48-9502-cc8a9cf85d36"), "قلعه گنج", 29 },
                    { 1176, new Guid("60325595-2b3d-427c-931d-39c4b7a53653"), "فهرج", 29 },
                    { 1175, new Guid("1a39e7db-4f76-4f11-b70c-031490fbfa70"), "فارياب", 29 },
                    { 1182, new Guid("12d3c8b3-6706-4271-891a-e82ef5416a04"), "مردهک", 29 },
                    { 1174, new Guid("2df6abba-6c2b-45ba-be20-9bcacd7f6c3b"), "عنبر آباد", 29 },
                    { 1172, new Guid("6d1b883b-0a21-427b-aa3a-4596713372ec"), "شهر بابک", 29 },
                    { 1171, new Guid("39f4c7ca-1ef5-49bd-81d2-8574e934fdd4"), "شهداد", 29 },
                    { 1170, new Guid("7456c33a-c1b5-46b9-8eaa-006a8ce0c74c"), "سيرجان", 29 },
                    { 1169, new Guid("8a065294-384a-49ac-9bd6-96ece5ce0b11"), "زيد آباد", 29 },
                    { 1168, new Guid("ab84f6ef-6776-4340-8c00-790225df866e"), "زهکلوت", 29 },
                    { 1167, new Guid("7c05d59c-b1b2-48cc-9192-5c256ab4ef40"), "زنگي آباد", 29 },
                    { 1166, new Guid("c9590a61-f6e3-4ebd-8726-6d35fa81f68c"), "زرند", 29 },
                    { 1173, new Guid("b7b1072e-83e1-45a0-bc4a-dc3f2974bfa9"), "صفائيه", 29 },
                    { 1087, new Guid("60ac8050-0445-4e8b-a85c-c2905a8acc24"), "لوندويل", 27 },
                    { 1183, new Guid("f085fba8-13f2-4cbc-b8c6-c693ad3bf629"), "مس سرچشمه", 29 },
                    { 1185, new Guid("2b12f95f-ce8d-43cb-87e7-36f9af968382"), "نجف شهر", 29 },
                    { 1201, new Guid("0740343c-c543-47d1-b8ff-b47cd564009c"), "کيانشهر", 29 },
                    { 1200, new Guid("23970635-5b05-4cd4-963c-ca6915ebd566"), "کوهبنان", 29 },
                    { 1199, new Guid("6ebd7874-23fe-4ead-b496-8f6326cc4e0f"), "کهنوج", 29 },
                    { 1198, new Guid("21e4dd3c-2582-42e9-a74a-3701ce1fce28"), "کشکوئيه", 29 },
                    { 1197, new Guid("ad319dcd-ff03-4a62-81f6-184ed725805c"), "کرمان", 29 },
                    { 1196, new Guid("3900f655-af9a-4955-a31f-834e7a0df9a1"), "کاظم آباد", 29 },
                    { 1195, new Guid("e93b3557-1962-4b5d-8dd8-4d46f1c7544a"), "چترود", 29 },
                    { 1184, new Guid("dc81751a-6c76-4c5a-a9ff-94aa2167d4e1"), "منوجان", 29 },
                    { 1194, new Guid("1bd3bc8a-9e4a-490f-b2a6-05f1efe11416"), "پاريز", 29 },
                    { 1192, new Guid("9be4abc9-7e5f-446a-b1c7-955835a4b4a3"), "هنزا", 29 },
                    { 1191, new Guid("895be8ca-7535-4c54-8c47-d8e38f3fa9f4"), "هماشهر", 29 },
                    { 1190, new Guid("fc60b26f-9ebf-4e06-a3d8-b2798c37d157"), "هجدک", 29 },
                    { 1189, new Guid("25865038-20c8-4943-a3f0-406f378833be"), "نگار", 29 },
                    { 1188, new Guid("b9e9e7ae-af9f-4b44-bab1-1b32edcc69aa"), "نودژ", 29 },
                    { 1187, new Guid("2a717caf-cdff-4e73-953d-508ae4e544a4"), "نظام شهر", 29 },
                    { 1186, new Guid("c8a8d934-8d93-4392-a21b-732ed5903724"), "نرماشير", 29 },
                    { 1193, new Guid("139cd18a-1d4b-41c8-8909-c060b74e657e"), "يزدان شهر", 29 },
                    { 1086, new Guid("26cbc253-3ac4-4573-a380-a7da1595a1df"), "لولمان", 27 },
                    { 1085, new Guid("f43fbede-1d69-47be-81ee-9452b8dc0564"), "لوشان", 27 },
                    { 1084, new Guid("d3891d99-8431-4492-8278-d56d1bfd2151"), "لنگرود", 27 },
                    { 984, new Guid("663f95f5-ea85-4b8c-8316-044a3c31b2b0"), "بندر عباس", 25 },
                    { 983, new Guid("b8e152d7-0173-4fa2-810b-cee4a41738b2"), "بندر جاسک", 25 },
                    { 982, new Guid("1b8a1902-d2e0-4531-93f2-ca1b9c2a0216"), "بستک", 25 },
                    { 981, new Guid("804a44b2-2aeb-4505-b1ee-0cfce3bd7b98"), "ابوموسي", 25 },
                    { 980, new Guid("6c4508e2-6d6a-49fe-bd3d-e3371404c3be"), "گيلانغرب", 24 },
                    { 979, new Guid("34459fb6-4246-48b5-8b2f-e664ed99f56a"), "گودين", 24 },
                    { 978, new Guid("2dad8c1d-0f14-4882-a2d8-8cba64ef2b54"), "گهواره", 24 },
                    { 977, new Guid("706320f4-110c-4e65-b3aa-4aafd813e0e0"), "کوزران", 24 },
                    { 976, new Guid("c606aa68-054a-4a51-8606-5bc114012a60"), "کنگاور", 24 },
                    { 975, new Guid("b01d34a1-90da-480c-8b6a-1ca12d4dfdbe"), "کرند غرب", 24 },
                    { 974, new Guid("829870cc-df45-4c1b-9ddd-c481c5cdc78d"), "کرمانشاه", 24 },
                    { 973, new Guid("cd703c45-20eb-4884-b9d3-adce9996aa73"), "پاوه", 24 },
                    { 972, new Guid("5fe86d26-11dd-42c4-a49c-61b133f55b14"), "هلشي", 24 },
                    { 971, new Guid("9e6f3a67-4622-44fb-b8d7-ed3619094c24"), "هرسين", 24 },
                    { 970, new Guid("83870e99-eddb-4996-864a-e2ad0027e325"), "نوسود", 24 },
                    { 985, new Guid("d32bdd86-766a-424a-9279-f22883a03b4c"), "بندر لنگه", 25 },
                    { 986, new Guid("6fa88514-1487-4731-88c2-35cd825fe464"), "بيکاه", 25 },
                    { 987, new Guid("1baab39c-d49e-4d0d-896c-847092e3a04f"), "تازيان پائين", 25 },
                    { 988, new Guid("da86ecad-00fc-4687-8866-784c337b9353"), "تخت", 25 },
                    { 1004, new Guid("4950533d-4145-4150-830e-4e358c049978"), "فين", 25 },
                    { 1003, new Guid("f8466169-0e2f-4c33-b687-a1d5669acef3"), "فارغان", 25 },
                    { 1002, new Guid("7ade8064-e2b5-4b37-b7ee-f69c46aece14"), "سيريک", 25 },
                    { 1001, new Guid("51885cea-f8b8-4fd7-a8a7-0ed2ccb9b22b"), "سوزا", 25 },
                    { 1000, new Guid("c1f15002-3c1f-45a5-a8c0-c896b28ff9c4"), "سندرک", 25 },
                    { 999, new Guid("f334cbae-de5e-4d6d-8d0c-fdf44c81116d"), "سرگز", 25 },
                    { 998, new Guid("f7f7ebed-0271-4ac6-8bae-9a16221f68a0"), "سردشت", 25 },
                    { 969, new Guid("793ec5e3-7b88-4507-85a3-dfbb13bf8405"), "نودشه", 24 },
                    { 997, new Guid("9b987373-e6f7-4fef-a23b-e0d701ba130d"), "زيارتعلي", 25 },
                    { 995, new Guid("14243b51-5ca2-44f5-bb04-f6cec9ee431f"), "دهبارز", 25 },
                    { 994, new Guid("f72abd39-c90d-49ba-80d8-b0c015e451dd"), "دشتي", 25 },
                    { 993, new Guid("a408f1d6-2dc8-417d-a862-506cb66d71b9"), "درگهان", 25 },
                    { 992, new Guid("d49ff199-7f70-4ace-b44d-8fce69577576"), "خمير", 25 },
                    { 991, new Guid("a35aadb7-602a-4dbb-aeff-ab4c392d092d"), "حاجي آباد", 25 },
                    { 990, new Guid("a037437d-1311-41a0-a0a7-fab220ea836e"), "جناح", 25 },
                    { 989, new Guid("29d66f5b-9e04-4b59-850b-cc7b545881c1"), "تيرور", 25 },
                    { 996, new Guid("546646e4-1e5a-4497-b421-172a35068409"), "رويدر", 25 },
                    { 968, new Guid("a99c9c16-d706-41ab-a5c5-7194b8ac3c13"), "ميان راهان", 24 },
                    { 967, new Guid("d1f2ab6f-8ec7-42c7-b546-490bce4aca20"), "قصر شيرين", 24 },
                    { 966, new Guid("d878b161-b00d-46da-9b6c-5034cc0d9ef0"), "صحنه", 24 },
                    { 945, new Guid("4a9e8926-5cbb-43f2-a06f-2424c64ea7e7"), "کوهنجان", 23 },
                    { 944, new Guid("83e76b68-e843-4191-adc6-df18b10b95e9"), "کوار", 23 },
                    { 943, new Guid("9ef0f439-ec89-4238-80be-aeab17c1b64d"), "کنار تخته", 23 },
                    { 942, new Guid("477db973-9842-4508-bd05-a9f8e47260f3"), "کره اي", 23 },
                    { 941, new Guid("4ed3479e-200f-43f0-8828-fbaecea90ece"), "کامفيروز", 23 },
                    { 940, new Guid("446a4199-21a3-4547-a082-0ae50f5724b8"), "کازرون", 23 },
                    { 939, new Guid("5da7ddd6-c272-411e-8020-84253e1c83b5"), "کارزين", 23 }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityGUID", "Name", "ProvinceID" },
                values: new object[,]
                {
                    { 946, new Guid("d8ed4e6e-a35a-441b-8472-f300b864e8e1"), "کوپن", 23 },
                    { 938, new Guid("a27b7230-9635-46ba-a8f6-cbf96d94ef5a"), "وراوي", 23 },
                    { 936, new Guid("56a3a97f-7da7-4f59-a48f-668a9722e10f"), "ني ريز", 23 },
                    { 935, new Guid("cd439732-e8d5-43e2-80d1-48d3980b89a1"), "نورآباد", 23 },
                    { 934, new Guid("df7703a4-bd6f-4288-ad00-2cd14d9d6006"), "نودان", 23 },
                    { 933, new Guid("fbf3995d-80e7-4e3d-8666-9719d44779d5"), "نوجين", 23 },
                    { 932, new Guid("5bede573-d653-42d7-a824-06be022af69d"), "نوبندگان", 23 },
                    { 931, new Guid("cf1e3aef-0730-4dd8-8cbb-e9663afa52d2"), "ميمند", 23 },
                    { 930, new Guid("05a2d574-670d-47d8-ac38-088796c3098a"), "ميانشهر", 23 },
                    { 937, new Guid("9690c76a-b48f-4bd4-b528-030cb5fa4368"), "هماشهر", 23 },
                    { 1005, new Guid("04da504b-45c2-462f-b55a-6bf58bdcaefb"), "قشم", 25 },
                    { 947, new Guid("61bc2c16-0489-453b-a910-43f6ade5d3ad"), "گراش", 23 },
                    { 949, new Guid("e4b05c62-c950-4d87-9406-a1b1dbb6c0d7"), "ازگله", 24 },
                    { 965, new Guid("7ee9ca22-9c17-40de-8018-38489e175cba"), "شاهو", 24 },
                    { 964, new Guid("b8ab4178-e8fe-4385-890f-ed921cbfbe15"), "سومار", 24 },
                    { 963, new Guid("3206425d-39f1-40ff-9152-92312512235f"), "سنقر", 24 },
                    { 962, new Guid("561b093e-902a-4aec-99a7-1c59ad619fab"), "سطر", 24 },
                    { 961, new Guid("bc9c2c7d-a0b5-4f8a-8a26-45ca0dc0a1b5"), "سرمست", 24 },
                    { 960, new Guid("6ab4645c-122e-4e89-bf00-2f5ffc766fa4"), "سر پل ذهاب", 24 },
                    { 959, new Guid("37f9ba05-f915-45a3-a417-c6d89fa241cf"), "ريجاب", 24 },
                    { 948, new Guid("1cc179e0-62f7-4adb-aeff-101d2e2f72ad"), "گله دار", 23 },
                    { 958, new Guid("23815fba-9523-4853-8453-f84b1fc51168"), "روانسر", 24 },
                    { 956, new Guid("68e537e1-58bc-4f42-a65c-550279d0e9b8"), "حميل", 24 },
                    { 955, new Guid("70304e9e-0b02-49ef-98c1-bca698d63be1"), "جوانرود", 24 },
                    { 954, new Guid("2fdc15d3-a786-46ff-ba5a-1ac6d70008e4"), "تازه آباد", 24 },
                    { 953, new Guid("3e9267c4-fd58-4010-bdd7-d213e2c0637c"), "بيستون", 24 },
                    { 952, new Guid("60415d1c-b34d-4389-87f5-a999f9c31118"), "باينگان", 24 },
                    { 951, new Guid("2b1d7725-4343-42c9-87f2-057ec81b1e9a"), "بانوره", 24 },
                    { 950, new Guid("5092c84b-038f-46fa-81fc-1bc69ab9be1a"), "اسلام آباد غرب", 24 },
                    { 957, new Guid("92505885-14ef-4215-bd5e-88ff27bba513"), "رباط", 24 },
                    { 614, new Guid("cfab8c66-af83-4e54-84fa-07a13ea9550e"), "اردستان", 19 },
                    { 1006, new Guid("9baf1c1e-1961-41fe-a5cc-74d3cb24abe2"), "قلعه قاضي", 25 },
                    { 1008, new Guid("278ab022-80fe-45bb-bb6a-94dbe2450ca9"), "ميناب", 25 },
                    { 1063, new Guid("00a71743-77d5-4ea0-aa82-1af1c61a9b18"), "جيرنده", 27 },
                    { 1062, new Guid("7662c9b9-8df5-4c22-a87d-2f9a91914eae"), "توتکابن", 27 },
                    { 1061, new Guid("c992438d-d223-4be3-990c-8d6d8d21c2b6"), "بندر انزلي", 27 },
                    { 1060, new Guid("c977c0a5-9c7f-4bce-a292-697cd2be1ff2"), "بره سر", 27 },
                    { 1059, new Guid("da2f73ef-9a9b-4c8e-92f7-f543004fbb59"), "بازار جمعه", 27 },
                    { 1058, new Guid("b66c1d9d-6b86-4bf7-b675-f788eefd87bf"), "املش", 27 },
                    { 1057, new Guid("07fb5033-6c4e-41d8-bc9d-9fa5dca7dc51"), "اطاقور", 27 },
                    { 1056, new Guid("70fd5c8a-89a7-497c-b374-cf4830548284"), "اسالم", 27 },
                    { 1055, new Guid("03d9564e-86cf-4ad4-b8ad-ad81c8950f22"), "احمد سرگوراب", 27 },
                    { 1054, new Guid("a91eb89f-5821-4a36-a843-2359d30e7e61"), "آستانه اشرفيه", 27 },
                    { 1053, new Guid("39317f60-f3e4-4a57-bebf-8827958ea12d"), "آستارا", 27 },
                    { 1052, new Guid("17539a94-562d-494a-8c5d-c97625077095"), "کميجان", 26 },
                    { 1051, new Guid("41659e52-0b19-438e-b0b3-e856d9e4e455"), "کارچان", 26 },
                    { 1050, new Guid("ca39a169-9e88-4b6e-8929-4742008f9c3f"), "پرندک", 26 },
                    { 1049, new Guid("d9b3ad63-caab-431f-9999-49673ae77cad"), "هندودر", 26 },
                    { 1064, new Guid("01ba4d23-6bcd-4829-b229-36d2aff4b845"), "حويق", 27 },
                    { 1065, new Guid("0e72e0cd-7940-4f69-a2e5-54e05a798fdf"), "خشکبيجار", 27 },
                    { 1066, new Guid("0107960f-843c-4352-92e1-fa1790ee85e5"), "خمام", 27 },
                    { 1067, new Guid("af7a2841-1981-411a-b844-8a5a75c4b865"), "ديلمان", 27 },
                    { 1083, new Guid("02d21c51-163e-40be-9feb-aba3f21071d9"), "لشت نشاء", 27 },
                    { 1082, new Guid("80ba45d1-5064-42f6-940a-133fa29a2aee"), "لاهيجان", 27 },
                    { 1081, new Guid("8c0d0a13-798d-4305-b917-f142714b0ecd"), "فومن", 27 },
                    { 1080, new Guid("86a498f5-fab6-4138-8a26-dd45e9a24f06"), "صومعه سرا", 27 },
                    { 1079, new Guid("bf3dd0a1-80b2-4d70-8d27-fc1471093ac2"), "شلمان", 27 },
                    { 1078, new Guid("1b87faa7-8a67-4a54-b3f7-0eb0ecea8f7f"), "شفت", 27 },
                    { 1077, new Guid("4f6334ad-9643-4893-9365-46d6379b13b4"), "سياهکل", 27 },
                    { 1048, new Guid("6d106ec7-7c91-41c9-86a4-e7a721c9ae91"), "نيمور", 26 },
                    { 1076, new Guid("803e39f4-4172-4cce-91eb-b15b50483a5b"), "سنگر", 27 },
                    { 1074, new Guid("1daa2d83-92c6-48c4-9e2e-7ba3236f0329"), "رودبنه", 27 },
                    { 1073, new Guid("627018ce-7a68-47fd-8c60-bf4afc13ce48"), "رودبار", 27 },
                    { 1072, new Guid("52f7bc68-a360-4327-8543-72a491d8b8ee"), "رضوانشهر", 27 },
                    { 1071, new Guid("5b46f983-c48f-4e1c-9c36-9f95d52ee9b1"), "رشت", 27 },
                    { 1070, new Guid("1715714b-15a8-4c54-b895-50dfb191123b"), "رستم آباد", 27 },
                    { 1069, new Guid("ece8f9a2-9d0d-4b02-8d86-96e0d8796da4"), "رحيم آباد", 27 },
                    { 1068, new Guid("089fe70b-98d6-4c16-8ff3-4b255351c8e6"), "رانکوه", 27 },
                    { 1075, new Guid("9dcc34c4-bfe4-45fc-9d83-ee46a2d86b63"), "رودسر", 27 },
                    { 1047, new Guid("23930bcb-8a5a-4bd5-959d-89f22fa9abec"), "نوبران", 26 },
                    { 1046, new Guid("dec299ad-33d1-4f1f-a62a-1b9b30275ac5"), "نراق", 26 },
                    { 1045, new Guid("3526eb22-bd67-4294-8d31-01c83ff5da5c"), "ميلاجرد", 26 },
                    { 1024, new Guid("6f202ce6-cb32-458e-b8a3-847e1a87fcc7"), "تفرش", 26 },
                    { 1023, new Guid("5ba3a508-3457-4ce2-898e-4f15d38ffe6c"), "اراک", 26 },
                    { 1022, new Guid("1edd72e3-78a2-455f-8722-81e66b89be0b"), "آوه", 26 },
                    { 1021, new Guid("dde2ed6f-f76c-4e2d-96e0-6d4d39e97d22"), "آشتيان", 26 },
                    { 1020, new Guid("6b2390c2-b349-4b34-a731-c81263805ca4"), "آستانه", 26 },
                    { 1019, new Guid("a024881a-bc3a-4a2b-a2ac-809b53479d0d"), "گوهران", 25 },
                    { 1018, new Guid("0be15695-4f89-4297-baea-9159620e8aa9"), "گروک", 25 },
                    { 1025, new Guid("8d6c7dda-2da4-4275-a952-fdfeeac7c5d3"), "توره", 26 },
                    { 1017, new Guid("86394bc5-75e2-4011-93a2-1e7e7d2c2d75"), "کيش", 25 },
                    { 1015, new Guid("021cc6d2-2128-46ce-9605-50adc4c06249"), "کوشکنار", 25 },
                    { 1014, new Guid("d374885b-4711-42c4-ae2c-ada444e31fc2"), "کوخردهرنگ", 25 },
                    { 1013, new Guid("4f2965f2-0028-4077-b30c-3c8daedee806"), "کنگ", 25 },
                    { 1012, new Guid("529c52a8-7e2d-46dd-86eb-7c1694e40257"), "چارک", 25 },
                    { 1011, new Guid("6d90737b-9e9e-43dc-8e21-a301cbdbf312"), "پارسيان", 25 },
                    { 1010, new Guid("5c8ea3f1-b8eb-470e-a533-c2c228c4ebcf"), "هشتبندي", 25 },
                    { 1009, new Guid("85bc9dbc-5888-4517-ae05-7a27999e8de4"), "هرمز", 25 },
                    { 1016, new Guid("783e23e7-5ee9-44f5-815a-fd9520cf3024"), "کوهستک", 25 },
                    { 1007, new Guid("be13e6f3-86ee-49a3-b190-34c21836267d"), "لمزان", 25 },
                    { 1026, new Guid("38cbf24d-2c6b-4153-9b37-b8a4897cb09a"), "جاورسيان", 26 },
                    { 1028, new Guid("af7b742c-ae76-45c8-960f-45d488770386"), "خمين", 26 },
                    { 1044, new Guid("ce798908-58ae-45a5-8e1c-1ba13bd0cf5a"), "محلات", 26 },
                    { 1043, new Guid("026ea70e-7766-4589-8841-c0965ade68e6"), "مامونيه", 26 },
                    { 1042, new Guid("66ab0f44-dfa0-4d39-a077-340b5414ffbd"), "قورچي باشي", 26 },
                    { 1041, new Guid("a6051661-2276-4233-abe7-cf9f9fc9a7e2"), "فرمهين", 26 },
                    { 1040, new Guid("44e2524c-fa70-469d-abd2-92a92b92250d"), "غرق آباد", 26 },
                    { 1039, new Guid("08c6dd16-33b3-44ba-855c-741867c1c888"), "شهر جديد مهاجران", 26 },
                    { 1038, new Guid("60279414-68a7-4962-a11e-db4b1d6d7e39"), "شهباز", 26 },
                    { 1027, new Guid("7f8be5a4-ea49-4a24-91ab-810b39f64d38"), "خشکرود", 26 },
                    { 1037, new Guid("93ea4724-4aa2-44d3-8ac7-7d24e126f5b4"), "شازند", 26 },
                    { 1035, new Guid("75251b81-5875-41f6-9350-35e7eed82e8c"), "ساروق", 26 },
                    { 1034, new Guid("a83d19bd-3b5b-4346-bbde-83692fd6ff1f"), "زاويه", 26 },
                    { 1033, new Guid("bcf609ad-7d0b-48f5-aa28-a2e2a7bde87e"), "رازقان", 26 },
                    { 1032, new Guid("72ee4a18-a9ee-4285-b3d1-99f639889533"), "دليجان", 26 },
                    { 1031, new Guid("64a9a3f3-184f-4ee2-b72c-cbd0d258291c"), "داود آباد", 26 },
                    { 1030, new Guid("7a85be18-a047-4ebe-ba06-eea365848ce6"), "خنداب", 26 },
                    { 1029, new Guid("c4f49e40-d833-4281-bdb8-8ba0c5622372"), "خنجين", 26 },
                    { 1036, new Guid("d5449bd2-7edc-404e-aee2-b0f93809db35"), "ساوه", 26 },
                    { 613, new Guid("8d819561-54d2-4806-a593-4e974183fb46"), "ابوزيد آباد", 19 },
                    { 612, new Guid("46d3b289-fa9e-4243-87d8-279e1d4db9ce"), "ابريشم", 19 },
                    { 611, new Guid("6d8ee7f9-a730-4628-8ad5-5c87d99ef76a"), "آران و بيدگل", 19 },
                    { 207, new Guid("7dcc3fd4-5a9c-4321-a098-fe039e3bf678"), "سلامي", 8 },
                    { 206, new Guid("3d80603a-b9c3-4281-944c-ca38f6b68eec"), "سفيد سنگ", 8 },
                    { 205, new Guid("c3eb324f-57cc-43e7-82dd-6ab922991d8a"), "سرخس", 8 },
                    { 204, new Guid("0d458bbd-f4d6-4d65-ae98-a437d3bf3bb2"), "سبزوار", 8 },
                    { 203, new Guid("a986518a-3c56-4b84-8140-35c517651ed8"), "ريوش", 8 },
                    { 202, new Guid("ace2321b-2dc3-4dc8-b052-632c0fc41149"), "روداب", 8 },
                    { 201, new Guid("5edbad3e-8518-44f7-b73d-42de9677d417"), "رضويه", 8 },
                    { 200, new Guid("4a6b4812-e96e-4c19-946f-26ec2199d94b"), "رشتخوار", 8 },
                    { 199, new Guid("0d4ecf09-7953-4270-bac4-5d7d8e8b31f2"), "رباط سنگ", 8 },
                    { 198, new Guid("1254f4b4-3fb8-462e-902d-1c2e48a34799"), "دولت آباد", 8 },
                    { 197, new Guid("71d074a0-858d-47ba-874d-31e96db770e0"), "درگز", 8 },
                    { 196, new Guid("bedf1016-14d0-45cd-9a1d-a182880aefe6"), "درود", 8 },
                    { 195, new Guid("77444900-6426-4335-b4a2-9e99e482e2e1"), "داورزن", 8 },
                    { 194, new Guid("a5cb07de-612b-49e9-88c5-7fde31cd38d1"), "خواف", 8 },
                    { 193, new Guid("9038ceca-1c2e-41e1-99a2-95e16c8801c1"), "خليل آباد", 8 },
                    { 208, new Guid("fd59a3a4-ed62-42eb-b7f3-7c9ab0e44d62"), "سلطان آباد", 8 },
                    { 192, new Guid("6b3b0503-3262-4980-821a-03717ffa2daa"), "خرو", 8 },
                    { 209, new Guid("a9122ca3-4fbc-4891-b92e-edc58ac7d27f"), "سنگان", 8 },
                    { 211, new Guid("54cbee65-e041-424d-bde0-090f07147fd9"), "شانديز", 8 },
                    { 226, new Guid("e6c63228-588c-4fbd-be86-7e5068e817a7"), "لطف آباد", 8 },
                    { 225, new Guid("fcbd4045-3b27-4e3d-b63a-91c97d32b734"), "قوچان", 8 },
                    { 224, new Guid("fa0b32a1-52ac-41ea-931a-ffaf76c3805f"), "قلندر آباد", 8 },
                    { 223, new Guid("8e5e4304-f9a4-4daa-ae71-044c7acc8310"), "قدمگاه", 8 },
                    { 222, new Guid("cb029370-ce35-481b-8b52-05c5565b0f8f"), "قاسم آباد", 8 },
                    { 221, new Guid("835d0fca-4e33-4791-9e87-72a63ac70a43"), "فيض آباد", 8 },
                    { 220, new Guid("33070ae8-a78e-45d4-add7-649c2cae42ff"), "فيروزه", 8 },
                    { 219, new Guid("521c522d-cb15-4cfe-b077-d5e2d76e7fdf"), "فريمان", 8 },
                    { 218, new Guid("eb0798a5-a989-458d-8cd3-1e55e86ad8bb"), "فرهاد گرد", 8 },
                    { 217, new Guid("f3d27212-02ea-4a4a-a9e1-f9871c85ebfa"), "عشق آباد", 8 },
                    { 216, new Guid("d2fc91d9-7a51-4de3-9b2d-6e20eee2607b"), "طرقبه", 8 },
                    { 215, new Guid("74b6c819-aaca-4ed9-8408-aaeea19760dd"), "صالح آباد", 8 },
                    { 214, new Guid("ef806725-ec31-46be-826d-8601c7ece96e"), "شهرآباد", 8 },
                    { 213, new Guid("f0efc539-7ffb-48a0-9e1b-9b92b9dd67ce"), "شهر زو", 8 },
                    { 212, new Guid("94788927-2057-49fc-b1c3-293564157930"), "ششتمد", 8 },
                    { 210, new Guid("80559580-404e-4aa2-8d24-5f93e43c8e14"), "شادمهر", 8 },
                    { 227, new Guid("1c621f30-f0b7-404b-9848-fe26f96808be"), "مزدآوند", 8 },
                    { 191, new Guid("3fec46e4-e062-4148-abfd-6c2a5683ca61"), "جنگل", 8 },
                    { 189, new Guid("0cba2e7d-b0a7-4d8d-800c-7cfd33d11b3e"), "تربت حيدريه", 8 },
                    { 169, new Guid("1326bf4a-08ac-47e7-a146-346be719be54"), "نازک عليا", 7 },
                    { 168, new Guid("cfdb6395-38a7-474a-8511-3854acda25f6"), "ميرآباد", 7 },
                    { 167, new Guid("4666876f-115a-4bc2-8c73-ca872e2a7c10"), "مياندوآب", 7 },
                    { 166, new Guid("fa8e094a-cde4-4ffd-8e7e-af51eaa4bb7c"), "مهاباد", 7 },
                    { 165, new Guid("5850bacb-8b03-41f9-93ec-d9644116107f"), "مرگنلر", 7 },
                    { 164, new Guid("e3886d14-37b8-408e-a95e-09261fb61fec"), "محمود آباد", 7 },
                    { 163, new Guid("2af37224-0c4c-4db2-bced-a2d491d2a7db"), "محمد يار", 7 },
                    { 162, new Guid("1a1bb88f-156b-49ad-adbd-2034e5c074e0"), "ماکو", 7 },
                    { 161, new Guid("49d3dad5-149d-4a9b-8185-c9d041725c12"), "قوشچي", 7 },
                    { 160, new Guid("ae268708-474c-4a5b-bbc7-77c4a172bfb0"), "قطور", 7 },
                    { 159, new Guid("dde65b83-4677-41d8-8f75-0495c8100675"), "قره ضياء الدين", 7 },
                    { 158, new Guid("890e25aa-c71e-4a18-9fa4-0786c3b151e8"), "فيرورق", 7 },
                    { 157, new Guid("9b9bde73-6b65-4d83-925a-cf9020104578"), "شوط", 7 },
                    { 156, new Guid("6005f2a1-d524-403d-891c-6d18ad5525bc"), "شاهين دژ", 7 },
                    { 155, new Guid("0e697c9b-1a16-43f4-90fc-1b2d23aced6c"), "سيه چشمه", 7 },
                    { 170, new Guid("bed76a83-d40a-4263-a9f7-d91149bf506d"), "نالوس", 7 },
                    { 190, new Guid("a7ac29dc-14f1-4f49-9358-35dc30437386"), "جغتاي", 8 },
                    { 171, new Guid("2c5a1ad5-ced6-4167-99d3-b9613332a88a"), "نقده", 7 },
                    { 173, new Guid("b34c1585-7b1a-4575-9bf9-3db59d644d20"), "پلدشت", 7 },
                    { 188, new Guid("8857c774-136a-43fe-91ef-bf34faebe760"), "تربت جام", 8 },
                    { 187, new Guid("3d1d755d-2f8e-4319-a29b-1351ac79cbea"), "تايباد", 8 },
                    { 186, new Guid("833d66ab-7e3b-40a0-a4fc-201a78b7eb07"), "بيدخت", 8 },
                    { 185, new Guid("7465e3e4-2da6-463d-b95c-e5327faab412"), "بردسکن", 8 },
                    { 184, new Guid("51f0a7a2-679d-42ac-8250-6a13642b79b4"), "بجستان", 8 },
                    { 183, new Guid("c134ea94-f87f-44b9-a97b-69ef1539b3e7"), "بايک", 8 },
                    { 182, new Guid("979a4d1f-12c8-4c56-9d4d-c95376f54ed6"), "بار", 8 },
                    { 181, new Guid("c8540b42-631b-461c-b547-3bee95bc751b"), "باخرز", 8 },
                    { 180, new Guid("0b370088-51e3-4c0c-be4d-088ade48e61d"), "باجگيران", 8 },
                    { 179, new Guid("6c1c30f2-2747-4669-bbfd-56ecc743355e"), "انابد", 8 },
                    { 178, new Guid("754405f0-d359-4a47-9dc4-513fd8355561"), "احمدآباد صولت", 8 },
                    { 177, new Guid("e09336ae-b2e4-4570-8e1c-388afdd296f4"), "گردکشانه", 7 },
                    { 176, new Guid("f8dc0204-2a7c-43e7-9c45-309d72a60b54"), "کشاورز", 7 },
                    { 175, new Guid("0bb8fffb-1733-4151-a068-9907cda5db29"), "چهار برج", 7 },
                    { 174, new Guid("dc96db18-5e03-4e32-89b2-84d03677b86a"), "پيرانشهر", 7 },
                    { 172, new Guid("e25fa218-2514-488d-827d-5a308cc21d6d"), "نوشين", 7 },
                    { 228, new Guid("ea377c33-7d43-4279-bcff-e0aabbc012a4"), "مشهد", 8 },
                    { 229, new Guid("f59c3687-60b6-4a97-b58d-cbdf11ee6370"), "مشهدريزه", 8 },
                    { 230, new Guid("e515a3ce-8698-42d7-baa1-1398094d65d0"), "ملک آباد", 8 },
                    { 284, new Guid("b4f4ade2-f3c9-4056-823e-4b56d380c6ee"), "کنارک", 9 },
                    { 283, new Guid("54e1be45-c602-4d56-9d4e-a6ae927f926a"), "چاه بهار", 9 },
                    { 282, new Guid("c676c7a8-2a03-4104-bd34-7b982a1fe1c7"), "پيشين", 9 },
                    { 281, new Guid("d892b537-36cb-4a3e-9157-0be108f828df"), "هيدوچ", 9 },
                    { 280, new Guid("9b32f84a-be65-43cf-abfa-6159abd4ca29"), "نگور", 9 },
                    { 279, new Guid("c01391ba-69d7-4d82-80e3-7eb593c64d42"), "نيک شهر", 9 },
                    { 278, new Guid("b56ee424-563c-4c4e-81d3-a89ffbf866c8"), "نوک آباد", 9 },
                    { 277, new Guid("ce089471-af7d-4058-a51e-852937e124f6"), "نصرت آباد", 9 },
                    { 276, new Guid("5e9c2a67-b5dd-41bc-a1ed-6ebc679f3f38"), "ميرجاوه", 9 },
                    { 275, new Guid("2b27e357-afde-4860-b4af-5b485a86c873"), "مهرستان", 9 },
                    { 274, new Guid("33eba25f-29cc-4fa4-a7f6-2cc2ff3d5186"), "محمدي", 9 },
                    { 273, new Guid("4202c9f5-91ce-4232-9957-7e662eb13add"), "محمدان", 9 },
                    { 272, new Guid("1c9a465a-4a12-4dd0-80b5-4a15375999c5"), "محمد آباد", 9 },
                    { 271, new Guid("26c42bd8-66ee-43e6-9ca8-281b1557257c"), "قصر قند", 9 },
                    { 270, new Guid("7b78a0a9-c86a-49aa-bf27-e694258eb261"), "فنوج", 9 },
                    { 285, new Guid("233b28f4-045f-475d-9df9-9d54c7bf6ef0"), "گشت", 9 },
                    { 269, new Guid("abf84dbe-69a9-45a9-b40e-4537aa2a02fb"), "علي اکبر", 9 },
                    { 286, new Guid("b5456019-7df4-4d5e-be91-8f97f46392b6"), "گلمورتي", 9 },
                    { 288, new Guid("0e84e2e1-9275-4a82-a6bc-8604d80bf5c9"), "آيسک", 10 },
                    { 303, new Guid("ef61cbb6-7d0e-4018-a4cd-c5da44283082"), "شوسف", 10 },
                    { 302, new Guid("3d6ecec6-0d30-409b-963d-4eb0deef3d5e"), "سه قلعه", 10 },
                    { 301, new Guid("2182cedc-bd5d-410a-bb63-e6c4ac15f355"), "سربيشه", 10 },
                    { 300, new Guid("ae594a5d-be13-4b6a-aea4-9cad40ace98b"), "سرايان", 10 },
                    { 299, new Guid("ebcda3fe-a682-4cbe-bbb5-aa81e4cb2c40"), "زهان", 10 },
                    { 298, new Guid("2dd714fd-6617-4c27-8d3f-7a859d5f36d4"), "ديهوک", 10 },
                    { 1241, new Guid("f6416139-0142-4f18-9988-3909dfc5fd89"), "گراب سفلي", 31 },
                    { 296, new Guid("efe9ca39-81fe-436e-a3ed-d5d092dc14d7"), "خضري دشت بياض", 10 },
                    { 295, new Guid("4e4d4c2d-537e-4899-b26c-43cbb17da340"), "حاجي آباد", 10 },
                    { 294, new Guid("b35995c6-2c51-4680-ba6f-a85d5a4105ca"), "بيرجند", 10 },
                    { 293, new Guid("172726f5-283d-4848-a65d-81f6a97f7587"), "بشرويه", 10 },
                    { 292, new Guid("7bcbb1d3-975d-4f14-badf-849df1a12cd1"), "اسلاميه", 10 },
                    { 291, new Guid("78fe6077-fb47-4932-bbcd-e416dfc87fea"), "اسفدن", 10 },
                    { 290, new Guid("f397b773-c6ea-4a39-855d-07212d250759"), "اسديه", 10 },
                    { 289, new Guid("014d5984-4d61-46e2-ba23-b1f0c5224424"), "ارسک", 10 },
                    { 287, new Guid("98643609-6901-49fb-9745-e665a6815bee"), "آرين شهر", 10 },
                    { 268, new Guid("06e994d6-8fee-4120-8ff0-575a8fd397dc"), "سيرکان", 9 },
                    { 267, new Guid("ef3e0afa-77f8-45b6-8685-3215b564dbfd"), "سوران", 9 },
                    { 266, new Guid("1884279d-e119-428a-b337-0ac40a15bd94"), "سرباز", 9 },
                    { 245, new Guid("4b7d843c-697d-4e7e-813b-558ab24f3252"), "کدکن", 8 },
                    { 244, new Guid("d76d76de-868d-4217-870a-d6685c11a551"), "کاشمر", 8 },
                    { 243, new Guid("54a662e6-e96e-4b66-b5ea-f3a910839828"), "کاريز", 8 },
                    { 242, new Guid("05a1ef73-8a91-4b7c-bbdf-af4cd314acc3"), "کاخک", 8 },
                    { 241, new Guid("2de437fd-89a5-4866-b038-31587688aca2"), "چکنه", 8 },
                    { 240, new Guid("7ba6102a-f915-4fb4-b8ee-778e77e522c7"), "چناران", 8 },
                    { 239, new Guid("efc02c39-7a72-421f-862b-8bc12cec5934"), "چاپشلو", 8 },
                    { 238, new Guid("89a85a16-06c7-4fb7-827e-575ce9ed9594"), "يونسي", 8 },
                    { 237, new Guid("2875ef19-ea74-4ca5-b544-6a421e9aff4b"), "همت آباد", 8 },
                    { 236, new Guid("40e76c12-8600-4da2-86ff-7ffa078c95d6"), "نيل شهر", 8 },
                    { 235, new Guid("4c1503fe-ffa2-4ba1-bbe2-0e96726b67ae"), "نيشابور", 8 },
                    { 234, new Guid("3518a45c-fcbf-4435-98c9-b7deb578d8cb"), "نوخندان", 8 },
                    { 233, new Guid("2e09203c-0c84-4f6d-9d4a-e5ac83bffeac"), "نقاب", 8 },
                    { 232, new Guid("022092c4-22b3-4d0d-b6d4-f53ff3b45746"), "نصرآباد", 8 },
                    { 231, new Guid("cc323092-132d-4ab9-9ff8-29bb82d95524"), "نشتيفان", 8 },
                    { 246, new Guid("8276dced-062d-4851-ae1c-eceb58bfde1f"), "کلات", 8 },
                    { 247, new Guid("f725e5a5-baa1-49d2-992a-fd99262fc19a"), "کندر", 8 },
                    { 248, new Guid("8294f128-2a8f-48c5-8d23-84d240964a88"), "گلمکان", 8 },
                    { 249, new Guid("6ce32819-34a5-4a05-a947-101f0e747945"), "گناباد", 8 },
                    { 265, new Guid("a9f51812-0d84-45bd-ab15-217638b3690d"), "سراوان", 9 },
                    { 264, new Guid("8d452ab6-6a6e-4cf9-b506-fd7378f7ad6f"), "زهک", 9 },
                    { 263, new Guid("b1ad63db-b20b-4bc4-b8b1-4dc91941f6ee"), "زرآباد", 9 },
                    { 262, new Guid("e230ad7b-b27b-4f0f-8a67-e668165a4c12"), "زاهدان", 9 },
                    { 261, new Guid("be38b55e-af17-42d6-a567-46115ad08e67"), "زابل", 9 },
                    { 260, new Guid("5e61751b-fc79-4a3f-94bc-27599d5596ff"), "راسک", 9 },
                    { 259, new Guid("2dbcfe2e-5b31-491f-97fc-e66c0630bfb7"), "دوست محمد", 9 },
                    { 154, new Guid("84c5f14b-6e51-46ec-8076-aa55001ec8b3"), "سيمينه", 7 },
                    { 258, new Guid("37a92de0-95ce-4c88-a899-fa9f98764e8f"), "خاش", 9 },
                    { 256, new Guid("4b889fef-c3a8-4f8c-8dac-e0f0efeb153a"), "بنجار", 9 },
                    { 255, new Guid("61974777-ac47-4df9-a62a-564938eb8c12"), "بنت", 9 },
                    { 254, new Guid("433340b4-d9da-486d-a96e-f08396bcf63c"), "بمپور", 9 },
                    { 253, new Guid("3721c358-5df9-424a-8a11-5c92115f0435"), "بزمان", 9 },
                    { 252, new Guid("589a1a13-507e-4c71-b6ce-c772f307c998"), "ايرانشهر", 9 },
                    { 251, new Guid("d90066ce-4682-43f3-8e5f-7cd6f9643a3e"), "اسپکه", 9 },
                    { 250, new Guid("1591b883-4f34-42e3-b18e-1f1abd126bbe"), "اديمي", 9 },
                    { 257, new Guid("c01d39d3-967f-4ec6-9753-af7514a050e2"), "جالق", 9 },
                    { 153, new Guid("827b671f-d5a5-48a6-b2e3-464052a07bd9"), "سيلوانه", 7 },
                    { 152, new Guid("d6abe064-2eb7-45d3-8845-8ab38d0437b9"), "سلماس", 7 },
                    { 151, new Guid("6c580e93-a843-42fb-896f-feed03640f64"), "سرو", 7 },
                    { 54, new Guid("57201e6d-2ab1-4ef6-89c9-e39427fe8dfb"), "پردنجان", 2 },
                    { 53, new Guid("d3ee2980-028a-4a83-83e8-1ae4a0ed19ec"), "وردنجان", 2 },
                    { 52, new Guid("35422fc2-012e-4888-bfe9-58836d4700a1"), "هفشجان", 2 },
                    { 51, new Guid("66a96dd5-f273-4a52-9e70-d1005a2bdba6"), "هاروني", 2 },
                    { 50, new Guid("49262861-2a81-45ff-b30f-fe2ffc0794c0"), "نقنه", 2 },
                    { 49, new Guid("793f4457-0628-46c2-b3c2-ea13a8235ae6"), "نافچ", 2 },
                    { 48, new Guid("e67c431c-254e-4df6-b377-f871f82077e4"), "ناغان", 2 },
                    { 47, new Guid("cc0fb3aa-21c7-4d2f-89af-eca282f766aa"), "منج", 2 },
                    { 46, new Guid("323cad32-b871-46cf-8133-076930e4fbb9"), "مال خليفه", 2 },
                    { 45, new Guid("e3963aed-abc2-4151-9ef4-bea902228b63"), "لردگان", 2 },
                    { 44, new Guid("c60a0801-81ee-44b2-a006-817fcb851f33"), "فرخ شهر", 2 },
                    { 43, new Guid("a40f9b9f-95b5-41bf-83d4-7c57cc7159b5"), "فرادنبه", 2 },
                    { 42, new Guid("ce71a97a-1ab5-4710-bbff-0c05c7700911"), "فارسان", 2 },
                    { 41, new Guid("e8f493e7-873e-4391-a0ec-5598a0bdf8da"), "طاقانک", 2 },
                    { 40, new Guid("7aa22d84-1776-4cf5-a38f-b8718706a6d5"), "صمصامي", 2 },
                    { 55, new Guid("3643d17b-ecbf-4241-9536-f1887a4199fb"), "چليچه", 2 },
                    { 39, new Guid("f040568b-c444-4b21-ba10-81a546e18e57"), "شهرکرد", 2 },
                    { 56, new Guid("00c67fed-a9a3-40fc-bc2b-f28e465aef53"), "چلگرد", 2 },
                    { 58, new Guid("6bd6cc59-6467-4f18-8bc6-78eed32419e6"), "کيان", 2 },
                    { 73, new Guid("443faeab-9bd2-4bdb-84c7-07c9c2f6d0e8"), "سنخواست", 3 },
                    { 72, new Guid("39284a32-503b-4469-a253-32143ffe29b3"), "زيارت", 3 },
                    { 71, new Guid("82d9690e-a92d-4c23-ba62-e879183a19e2"), "راز", 3 },
                    { 70, new Guid("b939fa85-1cdb-46cd-be2d-a48bba35abe9"), "درق", 3 },
                    { 69, new Guid("8018846e-e337-4da3-ac70-980acafda69c"), "حصارگرمخان", 3 },
                    { 68, new Guid("0a302fe7-b748-4a33-b1fe-ab2894bbb2d5"), "جاجرم", 3 },
                    { 67, new Guid("26b821ce-75cd-4c2b-adaa-a860f24bf35d"), "تيتکانلو", 3 },
                    { 66, new Guid("ce5229b0-32a1-4855-b1d7-fba5fcd06125"), "بجنورد", 3 },
                    { 65, new Guid("020e3abe-1de4-4d9e-8d25-0ee5b8c03aca"), "ايور", 3 },
                    { 64, new Guid("858c51e4-8550-484b-8644-1fde69e29fa1"), "اسفراين", 3 },
                    { 63, new Guid("2ead0e36-428b-45dc-bf18-fd8ee331c7e9"), "آوا", 3 },
                    { 62, new Guid("50a265d9-ad85-44f1-b827-02f74924a56d"), "آشخانه", 3 },
                    { 61, new Guid("a65ce6d3-2d50-4983-8370-78dce0c040ea"), "گوجان", 2 },
                    { 60, new Guid("9d832541-7133-425e-9f76-363ef8f153d3"), "گهرو", 2 },
                    { 59, new Guid("c6ef4aeb-e14d-45ca-9b45-67076647a9c6"), "گندمان", 2 },
                    { 57, new Guid("dc1cb1ed-5815-406d-9389-d1e95ce4ac05"), "کاج", 2 },
                    { 38, new Guid("b48e0a52-f6ad-4c12-84fb-0da305ed9227"), "شلمزار", 2 },
                    { 37, new Guid("0a7b899d-908f-49f9-967a-246726a602d3"), "سورشجان", 2 },
                    { 36, new Guid("5e0acf2b-3a9f-4823-999f-0a482429f7ef"), "سودجان", 2 },
                    { 15, new Guid("46c993da-40dc-455b-897e-0cad23f69d79"), "مهردشت", 1 },
                    { 14, new Guid("75146164-0d58-4345-8fcc-e9180f6deda6"), "مروست", 1 },
                    { 13, new Guid("4579d8df-03d8-4534-bde3-39e2bc8883db"), "عقدا", 1 },
                    { 12, new Guid("de0d91e3-d7ef-409e-820c-93dcca09eb64"), "شاهديه", 1 },
                    { 11, new Guid("c8426f1c-c25d-4435-bfa2-5470edcd8399"), "زارچ", 1 },
                    { 10, new Guid("4ee1a483-cc30-4e04-87d9-d78d68057119"), "خضر آباد", 1 },
                    { 9, new Guid("d4dfcb58-3198-486c-8bd9-bedf87eac399"), "حميديا", 1 },
                    { 8, new Guid("2080ce67-443c-486a-8939-3aa4cfd0b482"), "تفت", 1 },
                    { 7, new Guid("5b193daf-59d3-4747-99a5-04d363d6eec7"), "بهاباد", 1 },
                    { 6, new Guid("1e41b7ad-797a-4d96-98fb-b0ce92c44abb"), "بفروئيه", 1 },
                    { 5, new Guid("8e291c9d-2b05-4dd6-976a-e587a08a7338"), "بافق", 1 },
                    { 4, new Guid("949db81e-6eef-49c5-8a61-6f5a6f580d43"), "اشکذر", 1 },
                    { 3, new Guid("dd34ef4e-6af8-4dbf-a5fe-a63f719e40a4"), "اردکان", 1 },
                    { 2, new Guid("f2d7a298-18d6-4ef2-be1f-2abfcc23b1cf"), "احمد آباد", 1 },
                    { 1, new Guid("48105679-247b-45af-9ae4-0d1985e67285"), "ابرکوه", 1 },
                    { 16, new Guid("c0534419-5b8d-452f-9c4b-107013f8d15f"), "مهريز", 1 },
                    { 17, new Guid("f14c3c50-70d8-4fa3-825b-9fc3657d660f"), "ميبد", 1 },
                    { 18, new Guid("c39def21-f1a5-438a-a7f7-6d664ce8fc40"), "ندوشن", 1 },
                    { 19, new Guid("79fa4faa-e8b7-4e94-8043-b1e63729fdb3"), "نير", 1 },
                    { 35, new Guid("a57aea86-8f5c-4544-9c32-926dc2c4fd29"), "سفيد دشت", 2 },
                    { 34, new Guid("dbe6bf1a-fcf6-4345-a13a-0215dcf35770"), "سردشت لردگان", 2 },
                    { 33, new Guid("ff50f4c5-fd80-4796-bd8b-aa184afab551"), "سرخون", 2 },
                    { 32, new Guid("c83decba-b41f-4348-8abe-e27f8ecc899b"), "سامان", 2 },
                    { 31, new Guid("befe43e1-0412-4b0c-bf9e-b71020ad7970"), "دشتک", 2 },
                    { 30, new Guid("bf4e05e8-8a0a-43d9-bd63-9dd8f6146ab9"), "دستناء", 2 },
                    { 29, new Guid("b34cfa3f-6158-4f6c-ac27-561ffdedc55a"), "جونقان", 2 },
                    { 74, new Guid("94bf1a69-d486-499e-aabd-1082204f0071"), "شوقان", 3 },
                    { 28, new Guid("a8be92e1-8115-4afa-a3a9-717070ec4cde"), "بن", 2 },
                    { 26, new Guid("8c7841d3-092a-41bf-989d-dbbb9d5be9bf"), "بروجن", 2 },
                    { 25, new Guid("57ad1acf-f559-460f-af4a-18299d9c4aa4"), "بازفت", 2 },
                    { 24, new Guid("89e5d50f-304d-4e24-8c3a-99907f86388f"), "باباحيدر", 2 },
                    { 23, new Guid("ac80c203-4922-4822-8c0a-e0e2f6f3c8e6"), "اردل", 2 },
                    { 22, new Guid("2c6c230a-460c-424a-a92b-ed55499bc563"), "آلوني", 2 },
                    { 21, new Guid("4463f97d-3d57-40db-81de-168ee2a8f5fa"), "يزد", 1 },
                    { 20, new Guid("ff16df95-ced9-44a8-96e0-4dcdba25e8ce"), "هرات", 1 },
                    { 27, new Guid("d9d92815-47d1-442c-9fa9-e01389ad1b20"), "بلداجي", 2 },
                    { 304, new Guid("9b937f17-9790-4bde-b508-6a4a0a16e209"), "طبس", 10 },
                    { 75, new Guid("937ce8c7-24d1-4b95-9987-6c89ef5142ad"), "شيروان", 3 },
                    { 77, new Guid("414848f3-ad16-4798-b748-883746b97fb9"), "فاروج", 3 },
                    { 131, new Guid("567cf9a3-aea8-45a6-9706-c6b79edcee15"), "پيرتاج", 6 },
                    { 130, new Guid("d3c7c0a1-8bc6-4b7a-9ce7-a4b0e0f2f91c"), "ياسوکند", 6 },
                    { 129, new Guid("63bff4ab-350a-4663-a805-7854c75e42d1"), "موچش", 6 },
                    { 128, new Guid("3ac31fce-42f3-4dc3-a9ec-6a613d059489"), "مريوان", 6 },
                    { 127, new Guid("a721c2ad-c15b-4c06-b0cf-bbe565a8412b"), "قروه", 6 },
                    { 126, new Guid("cc0810d1-bd1f-4f5f-ab41-6d837804eca5"), "صاحب", 6 },
                    { 125, new Guid("3da229b4-6d67-4140-8c03-00494e8cea7e"), "شويشه", 6 },
                    { 124, new Guid("f1e9f41b-26a0-412e-a65c-5d21a662aae3"), "سنندج", 6 },
                    { 123, new Guid("c030ce5b-77b4-4b55-8cf4-ad6d96c91695"), "سقز", 6 },
                    { 122, new Guid("5556153e-4a41-4d7d-8037-3ba0af1b9583"), "سريش آباد", 6 },
                    { 121, new Guid("6e43b525-a411-4902-9a2a-10514f47b0e1"), "سرو آباد", 6 },
                    { 120, new Guid("0570a33d-e3e2-44e5-bd24-20fbec726215"), "زرينه", 6 },
                    { 119, new Guid("3e213f24-073b-4281-8911-863749cecccc"), "ديواندره", 6 },
                    { 118, new Guid("cd258491-4abf-470a-97d7-bf4da6592c1a"), "دهگلان", 6 },
                    { 117, new Guid("a5622861-8864-40c5-8324-de7710297a7e"), "دلبران", 6 },
                    { 132, new Guid("b15ff025-a356-496c-bc5a-38196c90da18"), "چناره", 6 },
                    { 116, new Guid("9c7426fd-d939-43f6-ba9e-2421489df3d1"), "دزج", 6 },
                    { 133, new Guid("ca54b989-1457-42e5-a75d-5af51996a818"), "کامياران", 6 },
                    { 135, new Guid("b01d5b9a-34f5-4500-8edb-2eebdf6bb6dc"), "کاني سور", 6 },
                    { 150, new Guid("c2fb6694-f812-4884-abfa-4d145495f688"), "سردشت", 7 },
                    { 149, new Guid("114c18ee-1487-4c74-b081-85192e89a2c9"), "زرآباد", 7 },
                    { 148, new Guid("9c2e0bcb-c704-493a-a9a6-99bd7c2a2564"), "ربط", 7 },
                    { 147, new Guid("80b470fc-6881-45fe-84f6-3834c8fef4e9"), "ديزج ديز", 7 },
                    { 146, new Guid("2d310964-a7d3-47cc-8c01-17a3f867c1cb"), "خوي", 7 },
                    { 145, new Guid("fc115352-9893-40e3-9ab9-57865879a5d0"), "خليفان", 7 },
                    { 144, new Guid("894b24a8-cb39-4404-8c54-d8da26f6f2f2"), "تکاب", 7 },
                    { 143, new Guid("efc1f69c-fa7b-44c7-9f08-3d8e32e2b6c1"), "تازه شهر", 7 },
                    { 142, new Guid("2ef73fc7-791b-46ed-af66-c4126255accd"), "بوکان", 7 },
                    { 141, new Guid("cee3d57c-0405-4556-bc4b-2fb9d63b7206"), "بازرگان", 7 },
                    { 140, new Guid("684a1e91-e2bd-4d87-bb51-b80697496f14"), "باروق", 7 },
                    { 139, new Guid("9b04b34e-2f61-42c7-a881-12f9ab9c4db2"), "ايواوغلي", 7 },
                    { 138, new Guid("bffee31d-615e-47fe-941a-f0044fa0a9de"), "اشنويه", 7 },
                    { 137, new Guid("18e968e5-cfe6-44a8-aa9e-855453e0fbe8"), "اروميه", 7 },
                    { 136, new Guid("8f1b6574-542c-4e7e-aefa-704905f141d1"), "آواجيق", 7 },
                    { 134, new Guid("d8136b91-1292-4aa8-b7da-374407285c0e"), "کاني دينار", 6 },
                    { 115, new Guid("2a05435e-a8b9-4881-ab51-0a39696c4fd9"), "توپ آغاج", 6 },
                    { 114, new Guid("a973f642-cb1e-4db1-99d0-919a18de9538"), "بيجار", 6 },
                    { 113, new Guid("71d8e46b-1ac9-4217-abb0-06ab0da92805"), "بوئين سفلي", 6 },
                    { 92, new Guid("4fe8162d-a3ef-4f8c-a278-9afc86382cef"), "مشکين دشت", 4 },
                    { 91, new Guid("a4950b31-3777-4b32-bb0d-434b305e1a0e"), "محمد شهر", 4 },
                    { 90, new Guid("92bb9bcd-bbf5-49d2-8773-28b86587e61e"), "ماهدشت", 4 },
                    { 89, new Guid("503e4383-926c-4fac-beb5-41cf65f873c4"), "فرديس", 4 },
                    { 88, new Guid("6d53a57f-0e87-4fcb-9469-33d6bd656603"), "طالقان", 4 },
                    { 87, new Guid("e8789a9e-6277-442b-bbea-0fa694bdd8e1"), "شهر جديد هشتگرد", 4 },
                    { 86, new Guid("60c06ce1-e9d5-4fe3-936a-298e4b56dd6d"), "تنکمان", 4 },
                    { 85, new Guid("d9597532-1225-41ae-8cd8-44cbd05ccf1e"), "اشتهارد", 4 },
                    { 84, new Guid("46b4748a-5dcc-4fe1-9e13-f5fa058e9636"), "آسارا", 4 },
                    { 83, new Guid("d1e9ed53-ea88-492d-880c-e670ca4fa13b"), "گرمه", 3 },
                    { 82, new Guid("fefb737e-368b-4d79-b5cd-8a93a02f5939"), "چناران شهر", 3 },
                    { 81, new Guid("d4a2850a-97b0-45f3-8d47-762d449a1be5"), "پيش قلعه", 3 },
                    { 80, new Guid("91cf47a8-b60a-4b37-b7fa-27a320a5575f"), "لوجلي", 3 },
                    { 79, new Guid("b485a174-a465-4f82-a448-20881d244ef7"), "قوشخانه", 3 },
                    { 78, new Guid("c996f1b8-22e9-4c09-aa2a-e06454ca4cd0"), "قاضي", 3 },
                    { 93, new Guid("d38dd64e-8bb1-43bb-8c68-f356914c4046"), "نظر آباد", 4 },
                    { 94, new Guid("d697215b-2a8c-42ef-ae43-5809d352ae5b"), "هشتگرد", 4 },
                    { 95, new Guid("437708cd-448f-4920-8843-351f2e18d374"), "چهارباغ", 4 },
                    { 96, new Guid("8cbb4aae-9405-42fe-a4a4-4b7c1a22dcef"), "کرج", 4 },
                    { 112, new Guid("804d4f02-3af0-4c7d-8bbc-ee3a44765c24"), "بلبان آباد", 6 },
                    { 111, new Guid("69a14cfa-1696-43bb-ba77-d79dfe29ee37"), "برده رشه", 6 },
                    { 110, new Guid("b8180ab1-906f-4e85-b8c1-0af99ba47cdb"), "بانه", 6 },
                    { 109, new Guid("7e037c33-a008-4a11-a2b3-2826061b2e30"), "بابارشاني", 6 },
                    { 108, new Guid("c5d313e5-8d07-4a4e-a273-ac741507c39b"), "اورامان تخت", 6 },
                    { 107, new Guid("cb4c1724-0ff8-40c7-a002-78ede8436b71"), "آرمرده", 6 },
                    { 106, new Guid("4877ee53-04cb-4d4e-89e5-df6e58bb139c"), "کهک", 5 },
                    { 76, new Guid("f086d162-b6d4-4828-9cc5-63a79240cc48"), "صفي آباد", 3 },
                    { 105, new Guid("cee37eed-6679-4433-a0a3-e576915b4678"), "قنوات", 5 },
                    { 103, new Guid("5ed90ac8-c336-49d0-ac50-e75b7f120cb4"), "سلفچگان", 5 },
                    { 102, new Guid("a124d0c1-d5d0-49ce-ba21-a50e99a21248"), "دستجرد", 5 },
                    { 101, new Guid("6f15aef6-ae76-49e0-b8f4-7d5e3adf3e67"), "جعفريه", 5 },
                    { 100, new Guid("f54ece90-6f28-4a49-9539-1a339363ae74"), "گلسار", 4 },
                    { 99, new Guid("7213bf7d-9fdf-44ef-8de4-fb3f12efb544"), "گرمدره", 4 },
                    { 98, new Guid("120ab10c-f041-4828-bb25-c561d58b2faf"), "کوهسار", 4 },
                    { 97, new Guid("980dc0b2-122e-403f-9e44-b78a6bd79a19"), "کمال شهر", 4 },
                    { 104, new Guid("a00ca2eb-8554-4987-b3d7-530bae0f2157"), "قم", 5 },
                    { 305, new Guid("410398b9-aabf-4658-9dae-49fbedc32741"), "طبس مسينا", 10 },
                    { 297, new Guid("5ded6cf9-e16d-4836-978b-9951587b0542"), "خوسف", 10 },
                    { 307, new Guid("7b58bbb2-3356-46a2-b1d6-c9ebae199842"), "فردوس", 10 },
                    { 514, new Guid("9ae84c93-f3db-4af2-87a1-462d37d544d2"), "نشتارود", 15 },
                    { 513, new Guid("d3c4d33c-a767-421c-beaa-32e1fe65508d"), "مرزيکلا", 15 },
                    { 512, new Guid("b15b7c5a-4cab-4a2e-b2fe-afd6d6cb4f08"), "مرزن آباد", 15 },
                    { 511, new Guid("8c3f8e51-63fc-4d98-9352-17237956294b"), "محمود آباد", 15 },
                    { 510, new Guid("93929491-7b6a-4127-8641-cc48b6354c16"), "قائم شهر", 15 },
                    { 509, new Guid("7b55f4d2-bfd8-42ba-ab30-72eda495bb2e"), "فريم", 15 },
                    { 508, new Guid("6cbe5710-29ea-49a7-9674-54ef3711ffb5"), "فريدونکنار", 15 },
                    { 507, new Guid("d6fda820-f48c-4a88-ac18-7547f4749860"), "عباس آباد", 15 },
                    { 506, new Guid("f5ce20e7-0c85-404f-a44b-4c03e42ae6b0"), "شيرگاه", 15 },
                    { 505, new Guid("200008c8-5238-46a6-8aca-fb0743002799"), "شيرود", 15 },
                    { 504, new Guid("a4fae4e7-d80d-4971-8d0f-87b7eb60d09a"), "سورک", 15 },
                    { 503, new Guid("cf63aa4d-7acb-473c-9b52-293731b4d136"), "سلمان شهر", 15 },
                    { 502, new Guid("d0dba840-ab86-4b98-b14f-70177757071c"), "سرخرود", 15 },
                    { 501, new Guid("4f4a7cae-2e8f-4433-a2ac-901facb4340a"), "ساري", 15 },
                    { 500, new Guid("d21d3809-1a18-4d41-a174-3b0e7d1b4224"), "زيرآب", 15 },
                    { 515, new Guid("2d6c851a-d212-4f21-8434-c5d8d64aed82"), "نور", 15 },
                    { 499, new Guid("5adb98e6-ebb6-4890-822d-6a61ca436009"), "زرگر محله", 15 },
                    { 516, new Guid("c6f3d5f0-3f0e-4fbe-b6c4-a6ea675ef38c"), "نوشهر", 15 },
                    { 518, new Guid("7d6c8e66-26a5-420a-9d0c-e0e688debc39"), "هادي شهر", 15 },
                    { 533, new Guid("f40a6156-538b-4e64-abfe-2b3f840862f6"), "گزنک", 15 },
                    { 532, new Guid("6e52a345-5869-499c-b3e1-8fc65ea7707f"), "گتاب", 15 },
                    { 531, new Guid("7147d2fe-5b56-41b5-ac96-e734ea83deed"), "کياکلا", 15 },
                    { 530, new Guid("4bafe4d8-cac8-4d2d-b7ce-c2556b33eb4c"), "کياسر", 15 },
                    { 529, new Guid("4f7a0e61-3d3d-42e9-9279-672e46eacd43"), "کوهي خيل", 15 },
                    { 528, new Guid("2876c7f7-2e69-45b2-baf1-5c026838fe9a"), "کلاردشت", 15 },
                    { 527, new Guid("fc34a355-0cdb-4dd4-9971-6e464a53b393"), "کلارآباد", 15 },
                    { 526, new Guid("69da730a-599c-4260-897f-9d59d32028c8"), "کجور", 15 },
                    { 525, new Guid("948ec376-5370-4bb1-8997-7a3d55d4434c"), "کتالم و سادات شهر", 15 },
                    { 524, new Guid("b379a5f6-ffd5-4688-9db2-ca07c7d09dcd"), "چمستان", 15 },
                    { 523, new Guid("f10c7508-beec-4589-a6c9-318733f0912a"), "چالوس", 15 },
                    { 522, new Guid("ba14cc94-1c11-4308-98db-588ab25bc3bd"), "پول", 15 },
                    { 521, new Guid("3b7bcb85-79dc-467d-b83b-e33e9cbf65cb"), "پل سفيد", 15 },
                    { 520, new Guid("957faaa2-ea1e-4958-aa4d-a92d96bcb551"), "پايين هولار", 15 },
                    { 519, new Guid("97dce133-1566-453b-87d9-d3382cc30f7c"), "هچيرود", 15 },
                    { 517, new Guid("fccfc763-b0ea-4616-b51e-192e6b6ee335"), "نکا", 15 },
                    { 534, new Guid("cd6c1ee3-da98-4089-ab6a-4f2a39270982"), "گلوگاه", 15 },
                    { 498, new Guid("fe581b0f-bc86-4585-a7f1-5d815743b366"), "رينه", 15 },
                    { 496, new Guid("08ff9f4c-9b9f-4abe-857b-40a9731bf570"), "رستمکلا", 15 },
                    { 476, new Guid("23af5130-6cfb-41dc-b68d-415dfe80c1a6"), "گميش تپه", 14 },
                    { 475, new Guid("b494398f-0609-4ac1-8c94-4e7f541e9b45"), "گرگان", 14 },
                    { 474, new Guid("fc212a4b-df7d-4f4f-bc0b-042934e5738e"), "گاليکش", 14 },
                    { 473, new Guid("3ea26196-83e8-4fe6-a433-6c00fa544d2a"), "کلاله", 14 },
                    { 472, new Guid("1109b212-fa2a-44d2-8aa6-85f59c51e2d7"), "کرد کوي", 14 },
                    { 471, new Guid("140d8704-ec03-4116-9fd8-3cf23f4fd4da"), "نگين شهر", 14 },
                    { 470, new Guid("9b80142f-9a86-4e6d-afc8-36ba4c6dd0a5"), "نوکنده", 14 },
                    { 469, new Guid("4785d550-bef6-4667-a1e4-80e9e30278cf"), "نوده خاندوز", 14 },
                    { 306, new Guid("609d266c-d68a-4ee9-88e6-fd6d52919881"), "عشق آباد", 10 },
                    { 467, new Guid("ed3ced61-d12f-4bd8-93e5-3116dee358d0"), "مزرعه", 14 },
                    { 466, new Guid("5d510a89-fdbc-48a7-8704-7660da8996b0"), "مراوه تپه", 14 },
                    { 465, new Guid("0742aca6-c099-460d-b5a5-d87409a49566"), "فراغي", 14 },
                    { 464, new Guid("63760604-4d07-4565-92a9-3ba1cd2d5498"), "فاضل آباد", 14 },
                    { 463, new Guid("9bf8942d-b4df-445c-98c8-b994c7473773"), "علي آباد", 14 },
                    { 462, new Guid("edc56fc6-19ae-4d4d-916f-f8a37ec57ee5"), "سيمين شهر", 14 },
                    { 477, new Guid("7ea2312e-f5cf-4356-9d97-1ca79c757b43"), "گنبدکاووس", 14 },
                    { 497, new Guid("6ebe628f-43fd-4532-a19b-a1d7c582dbf3"), "رويان", 15 },
                    { 478, new Guid("c278679d-b7a9-49d1-8744-5501bd79d960"), "آلاشت", 15 },
                    { 480, new Guid("1ff5c0fe-3f26-435b-a8ba-172e6e4e9cbd"), "ارطه", 15 },
                    { 495, new Guid("52ab65a4-4989-4594-a63a-b214b282bf95"), "رامسر", 15 },
                    { 494, new Guid("955e9076-0cb5-419d-9992-a48b7de3f040"), "دابودشت", 15 },
                    { 493, new Guid("7ad960a4-cbce-4bb8-9db3-5ba48e688f42"), "خوش رودپي", 15 },
                    { 492, new Guid("9c671ec4-5f4d-450e-ad87-c0b67ff9ca69"), "خليل شهر", 15 },
                    { 491, new Guid("0616db74-0a8a-4594-b17e-ce03e66fce7d"), "خرم آباد", 15 },
                    { 490, new Guid("37a6184d-1cef-4729-aee9-863293a3c7ce"), "جويبار", 15 },
                    { 489, new Guid("d7ec3c62-466c-42fc-9f4a-ca840d25fee2"), "تنکابن", 15 },
                    { 488, new Guid("d2bed425-6c6b-4e86-a9ba-4116d140803c"), "بهنمير", 15 },
                    { 487, new Guid("8e4592c8-6b7d-4a39-9a0a-f4c0f4f97cab"), "بهشهر", 15 },
                    { 486, new Guid("bf32ab46-17ad-4be1-9033-1a08ebb14372"), "بلده", 15 },
                    { 485, new Guid("cff47934-0705-4654-87f6-6383a112d9f9"), "بابلسر", 15 },
                    { 484, new Guid("19ec9974-c01d-4acb-9732-5c174fd71e1d"), "بابل", 15 },
                    { 483, new Guid("6fb27490-e253-437e-8d84-efeaec0cb2dd"), "ايزد شهر", 15 },
                    { 482, new Guid("f9a060bd-afd2-4c92-9785-82354a741175"), "امير کلا", 15 },
                    { 481, new Guid("cb2e7df2-919a-4fcb-aaa7-c322b26941e7"), "امامزاده عبدالله", 15 },
                    { 479, new Guid("080a1551-8cf9-49d1-8c24-d52fbeb758f9"), "آمل", 15 },
                    { 535, new Guid("dd5d8eee-4b73-40ec-b388-9564b4c2c40a"), "آبيک", 16 },
                    { 536, new Guid("6dda8368-c3b6-433f-99fd-866e9b01c9a3"), "آبگرم", 16 },
                    { 537, new Guid("052d0546-fb49-4a50-9cf4-23c19ed48353"), "آوج", 16 },
                    { 591, new Guid("7739f795-ea8d-4f5f-917a-11a11e98fc05"), "تازه کند انگوت", 18 },
                    { 590, new Guid("1c9a59a9-86c0-404e-805c-93c285fd71de"), "تازه کند", 18 },
                    { 589, new Guid("ee34dcd8-a7cf-4e38-abfb-7b1cbe978f90"), "بيله سوار", 18 },
                    { 588, new Guid("7e1c6f63-e0cc-4682-9dee-1ed54899c528"), "اصلاندوز", 18 },
                    { 587, new Guid("e070e1ef-b1ee-4aaf-a987-0140b8ea8973"), "اسلام آباد", 18 },
                    { 586, new Guid("9438bc91-5d6b-43f4-9498-16c30862f8f6"), "اردبيل", 18 },
                    { 585, new Guid("2c517fb8-d992-4480-8c14-45565c34ceaa"), "آبي بيگلو", 18 },
                    { 584, new Guid("a87e2bfe-22ea-4be7-8873-7cd5c0e62b3f"), "گراب", 17 },
                    { 583, new Guid("80909a02-61dd-473d-bbf4-abe39cc9c98e"), "کوهناني", 17 },
                    { 582, new Guid("f248fa12-c408-4701-83bc-fbde8c3ac784"), "کوهدشت", 17 },
                    { 581, new Guid("ce8a5437-490c-46b0-8bef-2efd503065ee"), "چقابل", 17 },
                    { 580, new Guid("4cc6364f-7482-44cb-b58c-55888d6f7c5b"), "چالانچولان", 17 },
                    { 579, new Guid("6772066c-023a-4560-8254-7013e7c362e0"), "پلدختر", 17 },
                    { 578, new Guid("e682a52b-57a7-4145-b8d3-f4ee37714a3c"), "ويسيان", 17 },
                    { 577, new Guid("f87c0fb0-8c09-4c1a-acf0-415340d4e688"), "هفت چشمه", 17 },
                    { 592, new Guid("4eb3f3bd-4f5c-4bfd-b4a2-23a719c73e42"), "جعفر آباد", 18 },
                    { 576, new Guid("f1a969c1-d452-4c7a-817a-bbc36f9991c4"), "نورآباد", 17 },
                    { 593, new Guid("fb3b78fb-39a1-46aa-b91c-b81776e91d3a"), "خلخال", 18 },
                    { 595, new Guid("92cd1b7e-36c5-404f-a9f2-f6d7dc50d23b"), "سرعين", 18 },
                    { 610, new Guid("6ce5957d-ac4e-4952-9712-5cc50701dcb5"), "گيوي", 18 },
                    { 609, new Guid("719fcd58-3c94-49f7-8c12-2b913439e6ff"), "گرمي", 18 },
                    { 608, new Guid("d3b45614-70fa-4834-ab82-b4178846d8df"), "کورائيم", 18 },
                    { 607, new Guid("662203ec-01eb-460e-b374-b7319186f293"), "کلور", 18 },
                    { 606, new Guid("ee0132ce-afd7-4efa-b3b3-d786da027735"), "پارس آباد", 18 },
                    { 605, new Guid("0ae497d7-99c4-4adc-96b2-ed3e03ebb4f5"), "هير", 18 },
                    { 604, new Guid("7f0cb124-a6a2-4427-84b8-8f161a872e42"), "هشتجين", 18 },
                    { 603, new Guid("019c29a0-7973-45de-9c66-795b949df2fd"), "نير", 18 },
                    { 602, new Guid("3a086406-bc5b-4490-be4d-6213e4c67d2a"), "نمين", 18 },
                    { 601, new Guid("1e8dc1e4-3016-473e-aa3b-d7c5be76507f"), "مشگين شهر", 18 }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityGUID", "Name", "ProvinceID" },
                values: new object[,]
                {
                    { 600, new Guid("c6c26abe-044f-48db-b883-8a63ad01e177"), "مرادلو", 18 },
                    { 599, new Guid("bbb0bd96-e5da-4a7c-acaa-7bcf778a1fac"), "لاهرود", 18 },
                    { 598, new Guid("8f2cad58-8f4a-4e5e-99b1-f3e9e6ab49d0"), "قصابه", 18 },
                    { 597, new Guid("7779373f-6fce-4c4e-8249-ea45a6aaf86c"), "فخرآباد", 18 },
                    { 596, new Guid("56eaada3-7973-4464-ac41-e962c2169f00"), "عنبران", 18 },
                    { 594, new Guid("f4eaa1aa-57ed-42e8-aeab-c40e7b94acd9"), "رضي", 18 },
                    { 575, new Guid("cb46595b-c902-4d0a-a82d-04bd0459e368"), "مومن آباد", 17 },
                    { 574, new Guid("711c9e8b-ce2b-44e0-9725-380b3260c050"), "معمولان", 17 },
                    { 573, new Guid("77c6f6f5-cd6a-4263-bc5f-783b39b83103"), "فيروزآباد", 17 },
                    { 552, new Guid("09da94a0-50db-46e9-9659-54c2cc4e16c6"), "شريفيه", 16 },
                    { 551, new Guid("c40c98bc-93a7-4226-8417-5ad91801de00"), "شال", 16 },
                    { 550, new Guid("b383911a-4bc8-432c-8812-d1afed14c3b1"), "سگز آباد", 16 },
                    { 549, new Guid("b16625c7-2b38-4532-8089-76340ed8103c"), "سيردان", 16 },
                    { 548, new Guid("d989fec2-c445-457c-ab06-ffafec1b1f6c"), "رازميان", 16 },
                    { 547, new Guid("83b62db0-dde4-4609-9b80-d43a96603080"), "دانسفهان", 16 },
                    { 546, new Guid("f9ef000f-70b2-4b33-8639-24f71fc23f23"), "خرمدشت", 16 },
                    { 545, new Guid("f001d625-20d5-4faa-b025-a8853753ab0c"), "خاکعلي", 16 },
                    { 544, new Guid("7c216c61-23d2-40c5-a8ef-bb5c21dda1ba"), "تاکستان", 16 },
                    { 543, new Guid("745017a1-849a-464c-a868-3045d747e2f4"), "بيدستان", 16 },
                    { 542, new Guid("100e719d-b261-49d8-b62f-53586c707189"), "بوئين زهرا", 16 },
                    { 541, new Guid("86264d6a-dfd3-4b6c-8f36-98c05669c99a"), "الوند", 16 },
                    { 540, new Guid("1aac3a57-10ac-4766-a165-d55057118a5d"), "اقباليه", 16 },
                    { 539, new Guid("c8547624-7bb8-4b89-8027-e09b5b454296"), "اسفرورين", 16 },
                    { 538, new Guid("9e73fcac-3069-4e35-96c7-f5aba2233ad4"), "ارداق", 16 },
                    { 553, new Guid("95c5639c-02d7-4d49-9494-30c954ab9424"), "ضياء آباد", 16 },
                    { 554, new Guid("540d8f51-5593-453f-ba09-c5faedbca7f7"), "قزوين", 16 },
                    { 555, new Guid("b0d19f40-05b5-4ffb-8e99-c6976ba6acf1"), "محمديه", 16 },
                    { 556, new Guid("adb3ad60-e7ed-436a-bc7d-939dccc2a3bd"), "محمود آباد نمونه", 16 },
                    { 572, new Guid("c9b992f1-84d0-4fa8-b1ac-042b9df5a438"), "شول آباد", 17 },
                    { 571, new Guid("244ab40f-ce13-4f17-91f1-b181d73b9a5e"), "سپيد دشت", 17 },
                    { 570, new Guid("72cbdd06-9415-4463-9234-5a3937176d38"), "سراب دوره", 17 },
                    { 569, new Guid("cc091979-5371-4711-8eb6-7100839cb870"), "زاغه", 17 },
                    { 568, new Guid("51abc298-7919-4675-babd-3b3060ec07da"), "دورود", 17 },
                    { 567, new Guid("431b797e-3b02-4a6c-a1e3-a3306956072b"), "درب گنبد", 17 },
                    { 566, new Guid("39b6c340-1eae-4090-8315-41cff906b256"), "خرم آباد", 17 },
                    { 461, new Guid("882b92f5-e2ea-488d-84c0-26a556539901"), "سنگدوين", 14 },
                    { 565, new Guid("ea9229c0-bff1-4e4f-8b30-7edaa93220e9"), "بيرانشهر", 17 },
                    { 563, new Guid("4f4d994f-0a54-4548-bd16-5712787606af"), "اليگودرز", 17 },
                    { 562, new Guid("57d985d5-b57b-4991-8d0a-147b49a2a473"), "الشتر", 17 },
                    { 561, new Guid("1ae6fa48-7960-4260-b39c-ce67ee4e1b2e"), "اشترينان", 17 },
                    { 560, new Guid("bb7b925c-7471-4f46-987f-c38dea861f5f"), "ازنا", 17 },
                    { 559, new Guid("9686c50c-d341-4ff5-b605-3134ee54b2c2"), "کوهين", 16 },
                    { 558, new Guid("627c75f3-1cbe-4b43-ab99-e49e256c58fb"), "نرجه", 16 },
                    { 557, new Guid("3530df9e-59d9-4c87-8354-2ac6b0515670"), "معلم کلايه", 16 },
                    { 564, new Guid("a4bc2d17-b86c-4985-a0d2-693c8fe81c54"), "بروجرد", 17 },
                    { 460, new Guid("03f6c1ad-1e28-497e-b1de-d9dd1a5769f3"), "سرخنکلاته", 14 },
                    { 468, new Guid("265f584a-0162-45f2-a0bc-51fbb6c5010f"), "مينودشت", 14 },
                    { 458, new Guid("0dc82ac6-ca0f-4bae-ac91-4f18b7d3300c"), "دلند", 14 },
                    { 361, new Guid("07c7fa6b-f567-4a30-8d51-291f1691ed85"), "شوش", 11 },
                    { 360, new Guid("a5392d54-6bc5-4475-a869-b02152502a9e"), "شهر امام", 11 },
                    { 359, new Guid("2424a2df-f2a7-41db-be10-705e6f6d970b"), "شمس آباد", 11 },
                    { 358, new Guid("11102402-0125-4e96-b3a9-bbada4371fcb"), "شرافت", 11 },
                    { 357, new Guid("70821290-7449-4b14-ab1b-03f1aff058c8"), "شاوور", 11 },
                    { 356, new Guid("0db3bcf5-8766-45f9-b8f0-8fd8916ec998"), "شادگان", 11 },
                    { 355, new Guid("718afe90-9249-45a7-8d98-0d0e9e75cf0b"), "سياه منصور", 11 },
                    { 354, new Guid("38884ef8-ac89-4983-a1d9-57fdfc8d2155"), "سوسنگرد", 11 },
                    { 353, new Guid("31ba9604-eced-4bfe-8375-a89473ce947d"), "سماله", 11 },
                    { 352, new Guid("5f952802-912a-4c0c-a299-8c59d48427b0"), "سردشت", 11 },
                    { 351, new Guid("62660b24-9efb-4b8a-98a4-17d5d7071a6e"), "سرداران", 11 },
                    { 350, new Guid("5d5e540b-07d3-4230-a07e-fef022538158"), "سالند", 11 },
                    { 349, new Guid("76501229-bba9-48c4-afec-68d11f7e2131"), "زهره", 11 },
                    { 348, new Guid("9d054af6-74a0-4717-8e1c-b57d9c69e976"), "رفيع", 11 },
                    { 347, new Guid("c72a14ff-14d3-4b07-bb81-e13cd13ffc01"), "رامهرمز", 11 },
                    { 362, new Guid("cfb9e8c1-a60c-4f64-ab9e-9f181261b691"), "شوشتر", 11 },
                    { 346, new Guid("20f90a41-60f9-405d-b211-36cf125ef1fe"), "رامشير", 11 },
                    { 363, new Guid("e5c3bfbb-51f7-4c3e-b9d3-96c05e12c334"), "شيبان", 11 },
                    { 365, new Guid("ecd1f084-5696-413b-b608-0e9bf02667b8"), "صفي آباد", 11 },
                    { 380, new Guid("d13503ae-0814-41e6-acb6-69842b1550fb"), "هنديجان", 11 },
                    { 379, new Guid("00d5672d-fd88-43a9-a7c5-93422f843009"), "هفتگل", 11 },
                    { 378, new Guid("06490ea2-f840-473a-b89e-5e92ac67ce46"), "مينوشهر", 11 },
                    { 377, new Guid("56ab8997-ac00-4fd8-8438-b48eaaf9e86b"), "ميداود", 11 },
                    { 376, new Guid("b8320b60-32e2-4c43-b51d-3b4d7707c5e2"), "ميانرود", 11 },
                    { 375, new Guid("f9967dd1-bca3-4fdc-b39e-c033ea6bfb4c"), "منصوريه", 11 },
                    { 459, new Guid("75ca4522-b129-4157-b186-fabbee727e23"), "راميان", 14 },
                    { 373, new Guid("ba34ae6f-c640-4dc7-8f98-3759ed0e3e29"), "مقاومت", 11 },
                    { 372, new Guid("97fdeb3b-98b4-4006-8dc7-0e04433f933e"), "مشراگه", 11 },
                    { 371, new Guid("1fd7ff2b-5a13-48ee-a930-0608ec81c155"), "مسجد سليمان", 11 },
                    { 370, new Guid("0734878b-aca5-4fdc-9253-52d76b8422dc"), "لالي", 11 },
                    { 369, new Guid("34931d89-0815-4093-b0ae-2d3ae3f655dd"), "قلعه خواجه", 11 },
                    { 368, new Guid("ff38165e-9659-4336-adfd-56f2b8a5885f"), "قلعه تل", 11 },
                    { 367, new Guid("223a073e-6c65-4c5a-8d77-1ac6cf9292ec"), "فتح المبين", 11 },
                    { 366, new Guid("8ebf94a7-5114-4a08-86fa-a08f904f6eb3"), "صيدون", 11 },
                    { 364, new Guid("59d67d38-706b-44f5-8355-3cd2f57bf294"), "صالح شهر", 11 },
                    { 345, new Guid("ceb9f1c6-07e7-40d6-9afc-cdeceeb6dfd4"), "دهدز", 11 },
                    { 344, new Guid("b23a6215-7c61-4c7e-95ec-10506edbf9f7"), "دزفول", 11 },
                    { 343, new Guid("0cf4810d-eda0-4129-84b7-7db348dfaf4b"), "دارخوين", 11 },
                    { 322, new Guid("35b079e8-9226-45ad-b628-bd8dc68fe4cf"), "الوان", 11 },
                    { 321, new Guid("e7dfb112-9703-494a-ac71-79ecdedbc534"), "الهايي", 11 },
                    { 320, new Guid("f94195c8-fba1-4edd-9ff2-e07be3346be8"), "اروند کنار", 11 },
                    { 319, new Guid("e186d740-de41-401b-9578-436e4c6f1e62"), "ابوحميظه", 11 },
                    { 318, new Guid("79c696ef-fb5b-4ec1-b39b-5c0d2febce5d"), "آغاجاري", 11 },
                    { 317, new Guid("05bbcb24-a414-4b1f-b292-d98e891ff385"), "آزادي", 11 },
                    { 316, new Guid("1f2f15b2-b1ab-4826-ab42-1c3a490953dc"), "آبژدان", 11 },
                    { 315, new Guid("302bd469-0d13-409f-8a46-c8792e1d9711"), "آبادان", 11 },
                    { 314, new Guid("2954af6a-75e5-45b0-80c4-2ad9b6fd0316"), "گزيک", 10 },
                    { 313, new Guid("6af7edc2-112c-4acd-bd4d-c821bc1ace13"), "نيمبلوک", 10 },
                    { 312, new Guid("1e6c1f1c-abfb-4606-92c4-a50cf3c6edb2"), "نهبندان", 10 },
                    { 311, new Guid("0eddd059-0a8f-4bc6-a8b3-d1ccabcb24b2"), "مود", 10 },
                    { 310, new Guid("d26b3428-cf5d-41c9-99f2-35ad9e6d7aa0"), "محمدشهر", 10 },
                    { 309, new Guid("350e0aa3-1c42-4c31-abd8-566bc8701b32"), "قهستان", 10 },
                    { 308, new Guid("95ae5b8b-9ebc-4203-8f82-f631c686c8ff"), "قائن", 10 },
                    { 323, new Guid("33b939e3-3af4-40c5-95ea-cdb2a5e98118"), "اميديه", 11 },
                    { 324, new Guid("61d35a74-9d4c-462b-af99-17412c47670e"), "انديمشک", 11 },
                    { 325, new Guid("20784363-781d-4cff-b548-7fdc8dc72267"), "اهواز", 11 },
                    { 326, new Guid("c72ed6df-61ae-4972-8515-2477eba35303"), "ايذه", 11 },
                    { 342, new Guid("901b07bc-49c5-42b7-b5df-f2eef77bbec0"), "خنافره", 11 },
                    { 341, new Guid("2194a00c-6daf-41bd-9697-573781013193"), "خرمشهر", 11 },
                    { 340, new Guid("033cead7-5e4d-41f9-ac94-d6aed5981db3"), "حميديه", 11 },
                    { 339, new Guid("fcb211ef-583f-4f23-bb1a-aaf04312b178"), "حمزه", 11 },
                    { 338, new Guid("6597ca40-31df-4e23-8709-1c39d195385a"), "حسينيه", 11 },
                    { 337, new Guid("6ce36252-a0b8-4739-ac2b-977b00b79714"), "حر", 11 },
                    { 336, new Guid("0cf3051d-1d93-48c6-8c34-34ca96aa5913"), "جنت مکان", 11 },
                    { 381, new Guid("a9b7ed7b-47ae-4568-afd4-814a2de2b085"), "هويزه", 11 },
                    { 335, new Guid("ceca708c-5853-442c-8f07-c3d50ae03185"), "جايزان", 11 },
                    { 333, new Guid("30d8340e-4292-4985-addd-f4520475b44d"), "ترکالکي", 11 },
                    { 332, new Guid("a7708118-3b2a-4add-b39c-a8e66af8c945"), "بيدروبه", 11 },
                    { 331, new Guid("b787e204-b3ad-4c08-8915-4eacb2ed408d"), "بهبهان", 11 },
                    { 330, new Guid("9be7e1e2-df0a-402a-9794-f12f69714c20"), "بندر ماهشهر", 11 },
                    { 329, new Guid("bcce4166-699b-4b5d-8fca-26e5e3ea0d7d"), "بندر امام خميني", 11 },
                    { 328, new Guid("f2b22e9a-792a-4080-8c5e-06beb71e0f72"), "بستان", 11 },
                    { 327, new Guid("e19964c3-4114-4d0e-b0d8-c2b737a3ce29"), "باغ ملک", 11 },
                    { 334, new Guid("bb4c0772-9928-4cc2-b3b2-48e2343cb61d"), "تشان", 11 },
                    { 382, new Guid("8b317587-408a-484c-b8c3-f88b79850515"), "ويس", 11 },
                    { 374, new Guid("d47300fe-9606-4cd4-9a96-68d9895b234e"), "ملاثاني", 11 },
                    { 384, new Guid("6ec31ace-00fb-494d-b6e0-051a06fe7129"), "چم گلک", 11 },
                    { 438, new Guid("72446089-8cd0-457d-8dcf-f3eb9424a6d1"), "سلطانيه", 13 },
                    { 437, new Guid("bffa41df-81b2-4a77-be41-d121c1eaad41"), "سجاس", 13 },
                    { 436, new Guid("6b497a7c-5fc4-493c-bda3-f463679a2a92"), "زنجان", 13 },
                    { 435, new Guid("e426e3e3-28c5-4e94-9a70-6eb967dfccfb"), "زرين رود", 13 },
                    { 434, new Guid("516d6c29-c616-4eeb-8d41-0dd35548be78"), "زرين آباد", 13 },
                    { 433, new Guid("3835cc12-43d9-4520-90c0-46dcdd1a27e7"), "دندي", 13 },
                    { 432, new Guid("0d792806-c9a6-493c-b3ca-1d12c8a3d9aa"), "خرمدره", 13 },
                    { 431, new Guid("12c4753d-ff80-472c-97d9-011cf4b24de9"), "حلب", 13 },
                    { 383, new Guid("d4d8692a-917e-4619-991d-9a689c8bd33d"), "چغاميش", 11 },
                    { 429, new Guid("52d242a6-f95f-4b8d-808b-29e86d58eb63"), "ابهر", 13 },
                    { 428, new Guid("0352ba72-c25e-46bd-ac1d-8d9f5999e1a3"), "آب بر", 13 },
                    { 427, new Guid("7c5e4f3e-d75e-4518-9ab1-618cfb8610a0"), "کلمه", 12 },
                    { 426, new Guid("c0606b9d-cc96-453e-af23-100649c0ee01"), "کاکي", 12 },
                    { 425, new Guid("27dc490f-6422-44d7-9587-b833d44302cb"), "چغادک", 12 },
                    { 424, new Guid("0770568f-3a89-4fd9-b3bc-5109846cab53"), "وحدتيه", 12 },
                    { 439, new Guid("9419cef1-7ed4-4dd0-af51-bb77c352c3eb"), "سهرورد", 13 },
                    { 423, new Guid("b9972591-f1b6-43ca-ab80-8a4dd085a167"), "نخل تقي", 12 },
                    { 440, new Guid("01c6d0d3-c89e-4181-bdd9-7f4e18105114"), "صائين قلعه", 13 },
                    { 442, new Guid("fddbe549-ecb1-40fc-9fc3-1874460d5f46"), "ماه نشان", 13 },
                    { 457, new Guid("1849e8ca-7460-481c-ab86-edb6817e4b1d"), "خان ببين", 14 },
                    { 456, new Guid("20a279a4-f8fc-4136-8a2c-0cedb5383f60"), "جلين", 14 },
                    { 455, new Guid("c1f19142-b9ec-46e6-8c9d-1fee3435884f"), "تاتار عليا", 14 },
                    { 454, new Guid("894026c5-7521-4ddd-8294-f5243f03cf7b"), "بندر گز", 14 },
                    { 453, new Guid("826d0b13-63f4-459c-a472-fd70786b2e30"), "بندر ترکمن", 14 },
                    { 452, new Guid("69e603ca-07fe-4ce8-a565-ee65d28502c3"), "اينچه برون", 14 },
                    { 451, new Guid("81bd558f-3bc5-4be9-a671-f0c09806bfac"), "انبار آلوم", 14 },
                    { 450, new Guid("fbd55874-aeaa-48ab-89b1-ef452b2efc65"), "آق قلا", 14 },
                    { 449, new Guid("2b972a22-5ac0-4efa-b2cf-ed1e8f008a19"), "آزاد شهر", 14 },
                    { 448, new Guid("151ad079-868f-41d8-91e4-653e70497710"), "گرماب", 13 },
                    { 447, new Guid("087485de-d0b3-41f0-bf63-45d92771d997"), "کرسف", 13 },
                    { 446, new Guid("35daca05-d7df-4a49-bfe1-bbbc80d92b01"), "چورزق", 13 },
                    { 445, new Guid("790547e2-6a61-4bcd-bf27-faf80ec1a5c7"), "هيدج", 13 },
                    { 444, new Guid("d19c7a1e-bf0f-44b3-84e4-a2b072fe873d"), "نيک پي", 13 },
                    { 443, new Guid("256c5138-ad5e-4e02-aceb-547363ebf709"), "نوربهار", 13 },
                    { 441, new Guid("01c00969-f821-4c38-8775-6ef8a0398cc2"), "قيدار", 13 },
                    { 422, new Guid("6b581a07-8236-48c6-9c4b-82e977375554"), "عسلويه", 12 },
                    { 430, new Guid("d1b0d84d-bcf2-4c51-b8c9-25679ca50dac"), "ارمخانخانه", 13 },
                    { 420, new Guid("ea7b01a6-ef10-40b6-9bc4-d669c5b7915d"), "شبانکاره", 12 },
                    { 399, new Guid("04bf9000-4c1c-46d9-b588-4d2b64105325"), "برازجان", 12 },
                    { 398, new Guid("c0863541-5f72-464b-b04e-4847b11fb818"), "بادوله", 12 },
                    { 397, new Guid("8a3ca343-a6e2-42e7-8d15-441cff2612fd"), "اهرم", 12 },
                    { 396, new Guid("c8565f3f-c435-4950-9fd2-319ddba9c11a"), "انارستان", 12 },
                    { 395, new Guid("4658e1df-1bce-41a5-a597-c7e56cbaa3e5"), "امام حسن", 12 },
                    { 394, new Guid("54b05484-3db2-4883-b209-457a16e7cd8e"), "آبپخش", 12 },
                    { 421, new Guid("661bae16-5ed2-4c5d-97a2-07fd70baf5f6"), "شنبه", 12 },
                    { 392, new Guid("274d2ce0-d0ae-4a82-8f50-f24fd0d2eb34"), "آباد", 12 },
                    { 391, new Guid("d03f43b0-921b-49a2-b9ba-50e9f6557808"), "گوريه", 11 },
                    { 390, new Guid("b3a206f2-04f6-4cde-bfb9-50ae54a9de33"), "گلگير", 11 },
                    { 389, new Guid("df36f471-ffca-465d-af4d-b79864bc89a1"), "گتوند", 11 },
                    { 388, new Guid("b5d27dc9-bef8-4115-856b-fd16e2afc796"), "کوت عبدالله", 11 },
                    { 387, new Guid("0e029f04-b151-413c-9fac-0895f5979ff4"), "کوت سيدنعيم", 11 },
                    { 386, new Guid("9fa080ad-7b0a-440d-8098-873d490cd05e"), "چوئبده", 11 },
                    { 385, new Guid("62f63882-a794-4fcb-a6e5-dd57f46275f7"), "چمران", 11 },
                    { 400, new Guid("07b843c3-ffbd-4985-b374-4bf3477811f5"), "بردخون", 12 },
                    { 401, new Guid("3735e9e3-eecc-416c-9e8a-94dceca1b26d"), "بردستان", 12 },
                    { 393, new Guid("fa600024-fc41-4b83-9776-3b251a9ec3ae"), "آبدان", 12 },
                    { 403, new Guid("53addf49-3000-408b-9b95-1f580c37c086"), "بندر ديلم", 12 },
                    { 402, new Guid("e5c21a41-3c84-4b11-91b1-e8365e749e89"), "بندر دير", 12 },
                    { 419, new Guid("4b9f1bdc-c798-466f-90ec-08f909e88c18"), "سيراف", 12 },
                    { 418, new Guid("ab1633b6-dc2a-4a42-bc28-d5c6d9a7a192"), "سعد آباد", 12 },
                    { 417, new Guid("bc57396b-6062-411d-97cd-c222d34ffbfe"), "ريز", 12 },
                    { 416, new Guid("72398398-07c4-4b26-843e-561496ae1f3c"), "دوراهک", 12 },
                    { 414, new Guid("7ef286b1-ae12-4136-b8a3-ffc2e44bb4c4"), "دالکي", 12 },
                    { 413, new Guid("f0d30d77-eb25-445a-8f20-46f535f2ddd4"), "خورموج", 12 },
                    { 412, new Guid("e24644c2-83ab-4e68-84cf-ed09c4f08eb3"), "خارک", 12 },
                    { 415, new Guid("93128dee-37a9-4d19-87d3-9549ef2277d9"), "دلوار", 12 },
                    { 410, new Guid("466870f2-9131-4694-ba39-982300d1144e"), "تنگ ارم", 12 },
                    { 409, new Guid("3809930b-32e2-472e-baf2-b717d358b718"), "بوشکان", 12 },
                    { 408, new Guid("1b264930-37d0-4d88-8595-1d07d5157387"), "بوشهر", 12 },
                    { 407, new Guid("3e0089e4-b018-42b4-a68a-3ef388781631"), "بنک", 12 },
                    { 406, new Guid("4edc23d5-e91a-4d07-bc9a-0ec93ea6849e"), "بندر گناوه", 12 },
                    { 405, new Guid("40819b45-0c6e-497d-a3a9-572bafbb9c6d"), "بندر کنگان", 12 },
                    { 404, new Guid("75adbb26-15bb-422b-ac5e-0e439d8cbf9e"), "بندر ريگ", 12 },
                    { 411, new Guid("e3b9b9ae-e00a-4f6e-b6e1-e6c3e140ef05"), "جم", 12 }
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
                table: "Category",
                columns: new[] { "CategoryID", "Abstract", "ActiveIconDocumentID", "CategoryGUID", "CoverDocumentID", "Description", "DisplayName", "InactiveIconDocumentID", "IsActive", "ModifiedDate", "ParentCategoryID", "QuadMenuDocumentID", "Sort" },
                values: new object[,]
                {
                    { 5, null, null, new Guid("00350d88-fcea-413d-9716-e67e5da60a1f"), null, null, "تاسیسات", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(3797), 3, null, 1 },
                    { 31, null, null, new Guid("ac385d15-143d-4b98-9ccb-044e4919991e"), null, null, "سرویس و تعمیر خودرو", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4227), 4, null, 3 },
                    { 30, null, null, new Guid("518b8e6a-41dc-4dc7-8282-e0440afc333b"), null, null, "اجاره خودرو", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4218), 4, null, 2 },
                    { 29, null, null, new Guid("d25d2a5e-e63d-444c-bfa1-2d3d2dc81783"), null, null, "اتوبار", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4209), 4, null, 1 },
                    { 21, null, null, new Guid("e633afd7-fb69-4044-b93a-fc34ddd0485f"), null, null, "کار در ارتفاع", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4076), 3, null, 17 },
                    { 20, null, null, new Guid("4d931de7-4963-4e3e-9dd0-3ce70c9b28ce"), null, null, "آسانسور و بالابر", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4068), 3, null, 16 },
                    { 19, null, null, new Guid("fab07a47-071c-4277-a3f1-5b2735925d69"), null, null, "نجاری", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4059), 3, null, 15 },
                    { 18, null, null, new Guid("1601b2f8-2c46-4718-885c-4077dbf5ae92"), null, null, "تعمیرات لوازم خانگی", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4046), 3, null, 14 },
                    { 16, null, null, new Guid("d20f47af-f372-4fce-8b12-3cd1e22e96bb"), null, null, "عایق کاری", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4029), 3, null, 12 },
                    { 15, null, null, new Guid("0f8232b9-5fef-42c6-8096-d921f02a1cac"), null, null, "عایق کاری", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4020), 3, null, 11 },
                    { 17, null, null, new Guid("3db5bbbb-26da-4ff2-947e-90cb12df3e1c"), null, null, "نرده و حفاظ استیل", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4038), 3, null, 13 },
                    { 13, null, null, new Guid("9f93d7f1-2b72-420e-bbe7-e7fcbb83c3df"), null, null, "بنایی", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4001), 3, null, 9 },
                    { 12, null, null, new Guid("344025c1-fc8f-4178-88ad-99fb2e174202"), null, null, "دکوراسیون داخلی", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(3992), 3, null, 8 },
                    { 11, null, null, new Guid("5393befe-7c25-49e2-818c-28a95ee73796"), null, null, "کابینت سازی", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(3983), 3, null, 7 },
                    { 10, null, null, new Guid("76d55030-f5a0-452a-b472-d6c85debc4bd"), null, null, "شیشه بری و قابسازی", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(3967), 3, null, 6 },
                    { 9, null, null, new Guid("41552a1c-a773-458a-9c1b-2dee640d5195"), null, null, "آلومینیوم سازی", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(3833), 3, null, 5 },
                    { 8, null, null, new Guid("b0f2ac1d-5b23-45f1-8538-fabc9302a4b8"), null, null, "مبلمان", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(3824), 3, null, 4 },
                    { 7, null, null, new Guid("898723a2-2457-4136-abae-752a68771720"), null, null, "ایمنی و امنیت", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(3815), 3, null, 3 },
                    { 6, null, null, new Guid("10764b94-8153-4e64-b2db-d186b6ced6ac"), null, null, "الکتریکی", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(3806), 3, null, 2 },
                    { 14, null, null, new Guid("6b3de4b8-836f-4559-ab5b-b686fcfa1eb2"), null, null, "آهنگری", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4010), 3, null, 10 }
                });

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
                    { 1, "mahdiroudaki@hotmail.com", "سید مهدی", 8, true, true, "رودکی", new DateTime(2020, 7, 1, 4, 1, 43, 347, DateTimeKind.Local).AddTicks(8120), "09227204305", null, new DateTime(2020, 7, 1, 4, 1, 43, 347, DateTimeKind.Local).AddTicks(7460), 1, new Guid("d2f247d1-51ef-4968-8729-7484181040b3") },
                    { 2, "roozbehshamekhi@hotmail.com", "روزبه", 8, true, true, "شامخی", new DateTime(2020, 7, 1, 4, 1, 43, 348, DateTimeKind.Local).AddTicks(613), "09128277075", null, new DateTime(2020, 7, 1, 4, 1, 43, 348, DateTimeKind.Local).AddTicks(583), 3, new Guid("b74fd445-e911-4a7f-991d-951cfc7f28c3") },
                    { 3, "dead.hh98@gmail.com", "حامد", 8, true, true, "حقیقیان", new DateTime(2020, 7, 1, 4, 1, 43, 348, DateTimeKind.Local).AddTicks(695), "09108347428", null, new DateTime(2020, 7, 1, 4, 1, 43, 348, DateTimeKind.Local).AddTicks(690), 2, new Guid("6437387a-1b10-4572-95a7-7ecd273a7ed9") },
                    { 4, "white.luciferrr@gmail.com", "محمد", 8, true, true, "میرزایی", new DateTime(2020, 7, 1, 4, 1, 43, 348, DateTimeKind.Local).AddTicks(712), "09147830093", null, new DateTime(2020, 7, 1, 4, 1, 43, 348, DateTimeKind.Local).AddTicks(707), 2, new Guid("aebca3a5-9959-46bf-8906-af6d06a70faa") }
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "AdminID", "AdminGUID", "ModifiedDate", "UserID" },
                values: new object[] { 1, new Guid("9707c971-426d-4dc9-bac0-eb5fa4560caf"), new DateTime(2020, 7, 1, 4, 1, 43, 348, DateTimeKind.Local).AddTicks(3620), 1 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "Abstract", "ActiveIconDocumentID", "CategoryGUID", "CoverDocumentID", "Description", "DisplayName", "InactiveIconDocumentID", "IsActive", "ModifiedDate", "ParentCategoryID", "QuadMenuDocumentID", "Sort" },
                values: new object[,]
                {
                    { 22, null, null, new Guid("443eb6e5-8442-475e-9183-1d3c6d58cd0e"), null, null, "سرویس کولر آبی", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4085), 5, null, 1 },
                    { 23, null, null, new Guid("343d5fc0-f9ce-4f24-bf52-60ae87effd0b"), null, null, "نقاشی ساختمان", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4094), 5, null, 2 },
                    { 24, null, null, new Guid("17aa1213-c39c-4ba1-8675-e910f890125a"), null, null, "رنگ کاری مبل", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4103), 8, null, 1 },
                    { 25, null, null, new Guid("1f14c53b-dd94-4bf6-913d-a6f2171b8660"), null, null, "تعمیر صندلی اداری", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4168), 8, null, 2 },
                    { 26, null, null, new Guid("e15abbd7-574b-47f2-ba3a-424422f5fd9a"), null, null, "ساخت مبلمان", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4178), 8, null, 3 },
                    { 27, null, null, new Guid("4e588b93-2e8e-4e52-8a32-e5004628e9b0"), null, null, "دوخت کاور مبل", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4190), 8, null, 4 },
                    { 28, null, null, new Guid("918df776-dccd-4a52-a692-9b73283f5a5e"), null, null, "تعمیر مبل", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4199), 8, null, 5 },
                    { 32, null, null, new Guid("45348ddb-73f6-455c-8c30-735e57ce04a0"), null, null, "وانت بار", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4236), 29, null, 1 },
                    { 33, null, null, new Guid("286ef415-a51b-4dc7-875c-06aa3b8c2be4"), null, null, "باربری و اتوبار", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4245), 29, null, 2 },
                    { 34, null, null, new Guid("f8c31135-bf20-4ea8-a47d-e3f3c6f20a48"), null, null, "کارگر اسباب کشی", null, true, new DateTime(2020, 7, 1, 4, 1, 43, 354, DateTimeKind.Local).AddTicks(4254), 29, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientID", "CityID", "ClientGUID", "ModifiedDate", "UserID" },
                values: new object[] { 1, 751, new Guid("87a70e70-e7ee-4778-82da-43fc0fab184b"), new DateTime(2020, 7, 1, 4, 1, 43, 348, DateTimeKind.Local).AddTicks(9748), 2 });

            migrationBuilder.InsertData(
                table: "Contractor",
                columns: new[] { "ContractorID", "AboutMe", "Address", "AverageRate", "BusinessTypeCodeID", "CityID", "ContractorGUID", "Credit", "Instagram", "Latitude", "Longitude", "ModifiedDate", "Telephone", "UserID", "Website" },
                values: new object[,]
                {
                    { 1, null, null, null, 4, 751, new Guid("81c724dc-72be-4889-8f88-f5a692f48d20"), 0, null, "1", "2", new DateTime(2020, 7, 1, 4, 1, 43, 350, DateTimeKind.Local).AddTicks(5704), null, 3, null },
                    { 2, null, null, null, 4, 751, new Guid("90d1abf8-f680-40d4-b1a5-b6184f639f02"), 10000, null, "1", "2", new DateTime(2020, 7, 1, 4, 1, 43, 350, DateTimeKind.Local).AddTicks(6508), null, 4, null }
                });

            migrationBuilder.InsertData(
                table: "ContractorCategory",
                columns: new[] { "ContractorCategoryID", "CategoryID", "ContractorCategoryGUID", "ContractorID" },
                values: new object[,]
                {
                    { 1, 4, new Guid("784ce03b-5df0-4ef7-b6a0-4e7403ff89c0"), 1 },
                    { 2, 5, new Guid("578d47a5-50d8-436c-a88b-1177dee8befd"), 1 },
                    { 3, 14, new Guid("7f3dcfc7-e499-45cb-8327-80665b5eeb8b"), 1 },
                    { 4, 22, new Guid("b9b73534-b7eb-4557-aad0-72719de48594"), 1 },
                    { 5, 25, new Guid("43fac927-5536-4bc1-b07f-339de5d03af6"), 1 },
                    { 6, 30, new Guid("fcc61465-7646-4e91-9fcc-5fb075c4679d"), 1 },
                    { 7, 33, new Guid("1214be88-2d49-4f92-85c1-3bfd84b97959"), 1 },
                    { 8, 34, new Guid("6d762fc9-6176-46e8-a960-12ef6ed0ee86"), 1 },
                    { 9, 27, new Guid("cb15e071-5256-4572-9da7-799b59c30ee0"), 1 },
                    { 10, 20, new Guid("e76f079b-4eb3-477f-b97f-c741bfa5dfed"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderID", "CategoryID", "ClientID", "Comment", "ContractorID", "Cost", "DeadlineDate", "Description", "ModifiedDate", "OrderGUID", "Rate", "StateCodeID", "Title" },
                values: new object[,]
                {
                    { 1, 14, 1, null, null, null, null, "توضیح", new DateTime(2020, 7, 1, 4, 1, 43, 351, DateTimeKind.Local).AddTicks(9162), new Guid("6ee994c6-ee2e-4edc-a6d4-190b34d18fa2"), null, 9, "تیتر" },
                    { 2, 22, 1, null, null, null, null, "کولر ماشین مشکل داره", new DateTime(2020, 7, 1, 4, 1, 43, 351, DateTimeKind.Local).AddTicks(9991), new Guid("7a3b3856-b6c3-46a8-80bc-daf39045b2d1"), null, 9, "مشکل" }
                });

            migrationBuilder.InsertData(
                table: "OrderRequest",
                columns: new[] { "OrderRequestID", "ContractorID", "IsAllow", "Message", "ModifiedDate", "OfferedPrice", "OrderID", "OrderRequestGUID" },
                values: new object[] { 1, 1, true, "پیام", new DateTime(2020, 7, 1, 4, 1, 43, 352, DateTimeKind.Local).AddTicks(7723), 250000L, 1, new Guid("c051b3c7-a4a1-4a0e-b35f-09f7c6daa548") });

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
