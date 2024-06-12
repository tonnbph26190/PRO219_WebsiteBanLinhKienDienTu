using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    public partial class new_db_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillDetails_PhoneDetailds_IdPhoneDetail",
                table: "BillDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_CartDetails_Carts_IdAccount",
                table: "CartDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_CartDetails_PhoneDetailds_IdPhoneDetaild",
                table: "CartDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Accounts_IdAccount",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_ListImage_PhoneDetailds_IdPhoneDetaild",
                table: "ListImage");

            migrationBuilder.DropTable(
                name: "Imei");

            migrationBuilder.DropTable(
                name: "Refund");

            migrationBuilder.DropTable(
                name: "SalePhoneDetailds");

            migrationBuilder.DropTable(
                name: "SellDailys");

            migrationBuilder.DropTable(
                name: "SellMonthlys");

            migrationBuilder.DropTable(
                name: "SellYearlys");

            migrationBuilder.DropTable(
                name: "VW_Phone");

            migrationBuilder.DropTable(
                name: "VW_Phone_Group");

            migrationBuilder.DropTable(
                name: "VW_PhoneDetail");

            migrationBuilder.DropTable(
                name: "PhoneDetailds");

            migrationBuilder.DropTable(
                name: "Battery");

            migrationBuilder.DropTable(
                name: "ChargingportType");

            migrationBuilder.DropTable(
                name: "ChipCPUs");

            migrationBuilder.DropTable(
                name: "ChipGPUs");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "OperatingSystem");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "Ram");

            migrationBuilder.DropTable(
                name: "Rom");

            migrationBuilder.DropTable(
                name: "Sim");

            migrationBuilder.DropIndex(
                name: "IX_ListImage_IdPhoneDetaild",
                table: "ListImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_CartDetails_IdAccount",
                table: "CartDetails");

            migrationBuilder.DropIndex(
                name: "IX_BillDetails_IdPhoneDetail",
                table: "BillDetails");

            migrationBuilder.DropColumn(
                name: "IdPhone",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "CartDetails");

            migrationBuilder.RenameColumn(
                name: "TimeTo",
                table: "Sales",
                newName: "ToDate");

            migrationBuilder.RenameColumn(
                name: "TimeForm",
                table: "Sales",
                newName: "LastModifiedOnDate");

            migrationBuilder.RenameColumn(
                name: "IdPhoneDetaild",
                table: "ListImage",
                newName: "VirtualItemId");

            migrationBuilder.RenameColumn(
                name: "IdPhoneDetaild",
                table: "CartDetails",
                newName: "CartId");

            migrationBuilder.RenameColumn(
                name: "IdAccount",
                table: "CartDetails",
                newName: "LastModifiedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_CartDetails_IdPhoneDetaild",
                table: "CartDetails",
                newName: "IX_CartDetails_CartId");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByUserId",
                table: "Sales",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnDate",
                table: "Sales",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FromDate",
                table: "Sales",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByUserId",
                table: "Sales",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByUserId",
                table: "Reviews",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnDate",
                table: "Reviews",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByUserId",
                table: "Reviews",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOnDate",
                table: "Reviews",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "VirtualItemId",
                table: "Reviews",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ProductionCompany",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StatusVoucher",
                table: "Discount",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByUserId",
                table: "Discount",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnDate",
                table: "Discount",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByUserId",
                table: "Discount",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOnDate",
                table: "Discount",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdAccount",
                table: "Carts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Carts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByUserId",
                table: "Carts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnDate",
                table: "Carts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByUserId",
                table: "Carts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOnDate",
                table: "Carts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "CartDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByUserId",
                table: "CartDetails",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnDate",
                table: "CartDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Decription",
                table: "CartDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdUser",
                table: "CartDetails",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdVirtualItem",
                table: "CartDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOnDate",
                table: "CartDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetadataJson",
                table: "CartDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByUserId",
                table: "Accounts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnDate",
                table: "Accounts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByUserId",
                table: "Accounts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOnDate",
                table: "Accounts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserTypeEnum",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "RefundEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SerrialId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MetadataJson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusDetail = table.Column<int>(type: "int", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedOnDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefundEntity", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetails_Carts_CartId",
                table: "CartDetails",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Accounts_Id",
                table: "Carts",
                column: "Id",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartDetails_Carts_CartId",
                table: "CartDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Accounts_Id",
                table: "Carts");

            migrationBuilder.DropTable(
                name: "RefundEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "CreatedOnDate",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "FromDate",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "LastModifiedByUserId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "CreatedOnDate",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "LastModifiedByUserId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "LastModifiedOnDate",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "VirtualItemId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Discount");

            migrationBuilder.DropColumn(
                name: "CreatedOnDate",
                table: "Discount");

            migrationBuilder.DropColumn(
                name: "LastModifiedByUserId",
                table: "Discount");

            migrationBuilder.DropColumn(
                name: "LastModifiedOnDate",
                table: "Discount");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "CreatedOnDate",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "LastModifiedByUserId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "LastModifiedOnDate",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "CartDetails");

            migrationBuilder.DropColumn(
                name: "CreatedOnDate",
                table: "CartDetails");

            migrationBuilder.DropColumn(
                name: "Decription",
                table: "CartDetails");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "CartDetails");

            migrationBuilder.DropColumn(
                name: "IdVirtualItem",
                table: "CartDetails");

            migrationBuilder.DropColumn(
                name: "LastModifiedOnDate",
                table: "CartDetails");

            migrationBuilder.DropColumn(
                name: "MetadataJson",
                table: "CartDetails");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "CreatedOnDate",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "LastModifiedByUserId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "LastModifiedOnDate",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "UserTypeEnum",
                table: "Accounts");

            migrationBuilder.RenameColumn(
                name: "ToDate",
                table: "Sales",
                newName: "TimeTo");

            migrationBuilder.RenameColumn(
                name: "LastModifiedOnDate",
                table: "Sales",
                newName: "TimeForm");

            migrationBuilder.RenameColumn(
                name: "VirtualItemId",
                table: "ListImage",
                newName: "IdPhoneDetaild");

            migrationBuilder.RenameColumn(
                name: "LastModifiedByUserId",
                table: "CartDetails",
                newName: "IdAccount");

            migrationBuilder.RenameColumn(
                name: "CartId",
                table: "CartDetails",
                newName: "IdPhoneDetaild");

            migrationBuilder.RenameIndex(
                name: "IX_CartDetails_CartId",
                table: "CartDetails",
                newName: "IX_CartDetails_IdPhoneDetaild");

            migrationBuilder.AddColumn<Guid>(
                name: "IdPhone",
                table: "Reviews",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ProductionCompany",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "StatusVoucher",
                table: "Discount",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdAccount",
                table: "Carts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "CartDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "CartDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "IdAccount");

            migrationBuilder.CreateTable(
                name: "Battery",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Battery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChargingportType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChargingportType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChipCPUs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChipCPUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChipGPUs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChipGPUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperatingSystem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingSystem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdProductionCompany = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdWarranty = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phones_ProductionCompany_IdProductionCompany",
                        column: x => x.IdProductionCompany,
                        principalTable: "ProductionCompany",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Phones_Warranty_IdWarranty",
                        column: x => x.IdWarranty,
                        principalTable: "Warranty",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ram",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ram", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Refund",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Imei = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StatusDetail = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refund", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rom",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SellDailys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BestSeller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Refund = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SellOff = table.Column<int>(type: "int", nullable: true),
                    SellOnl = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalMoneys = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalQuantity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellDailys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SellMonthlys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BestSeller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Refund = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SellOff = table.Column<int>(type: "int", nullable: true),
                    SellOnl = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalMoneys = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalQuantity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellMonthlys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SellYearlys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BestSeller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Refund = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SellOff = table.Column<int>(type: "int", nullable: true),
                    SellOnl = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalMoneys = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalQuantity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellYearlys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sim",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VW_Phone",
                columns: table => new
                {
                    IdPhone = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdProductionComany = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductionComanyName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VW_Phone_Group",
                columns: table => new
                {
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdPhone = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceMax = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProductionComanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RamName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VW_PhoneDetail",
                columns: table => new
                {
                    BatteryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChargingportTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChipCPUName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChipGPUName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ColorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontCamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdPhone = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPhoneDetail = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperatingSystemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProductionCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RamID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RamName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReducedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Resolution = table.Column<int>(type: "int", nullable: true),
                    RomName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SimName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PhoneDetailds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdBattery = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChargingport = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChipCPU = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChipGPU = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdColor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDiscount = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdMaterial = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdOperatingSystem = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPhone = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdRam = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdRom = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSim = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontCamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainCamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Resolution = table.Column<int>(type: "int", nullable: true),
                    Sale = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Solid = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneDetailds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneDetailds_Battery_IdBattery",
                        column: x => x.IdBattery,
                        principalTable: "Battery",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneDetailds_ChargingportType_IdChargingport",
                        column: x => x.IdChargingport,
                        principalTable: "ChargingportType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneDetailds_ChipCPUs_IdChipCPU",
                        column: x => x.IdChipCPU,
                        principalTable: "ChipCPUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneDetailds_ChipGPUs_IdChipGPU",
                        column: x => x.IdChipGPU,
                        principalTable: "ChipGPUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneDetailds_Colors_IdColor",
                        column: x => x.IdColor,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneDetailds_Discount_IdDiscount",
                        column: x => x.IdDiscount,
                        principalTable: "Discount",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhoneDetailds_Material_IdMaterial",
                        column: x => x.IdMaterial,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneDetailds_OperatingSystem_IdOperatingSystem",
                        column: x => x.IdOperatingSystem,
                        principalTable: "OperatingSystem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneDetailds_Phones_IdPhone",
                        column: x => x.IdPhone,
                        principalTable: "Phones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneDetailds_Ram_IdRam",
                        column: x => x.IdRam,
                        principalTable: "Ram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneDetailds_Rom_IdRom",
                        column: x => x.IdRom,
                        principalTable: "Rom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneDetailds_Sim_IdSim",
                        column: x => x.IdSim,
                        principalTable: "Sim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Imei",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPhoneDetaild = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdBillDetail = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NameImei = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imei", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imei_PhoneDetailds_IdPhoneDetaild",
                        column: x => x.IdPhoneDetaild,
                        principalTable: "PhoneDetailds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SalePhoneDetailds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPhoneDetaild = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSales = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalePhoneDetailds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalePhoneDetailds_PhoneDetailds_IdPhoneDetaild",
                        column: x => x.IdPhoneDetaild,
                        principalTable: "PhoneDetailds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalePhoneDetailds_Sales_IdSales",
                        column: x => x.IdSales,
                        principalTable: "Sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListImage_IdPhoneDetaild",
                table: "ListImage",
                column: "IdPhoneDetaild");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_IdAccount",
                table: "CartDetails",
                column: "IdAccount");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_IdPhoneDetail",
                table: "BillDetails",
                column: "IdPhoneDetail");

            migrationBuilder.CreateIndex(
                name: "IX_Imei_IdPhoneDetaild",
                table: "Imei",
                column: "IdPhoneDetaild");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneDetailds_IdBattery",
                table: "PhoneDetailds",
                column: "IdBattery");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneDetailds_IdChargingport",
                table: "PhoneDetailds",
                column: "IdChargingport");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneDetailds_IdChipCPU",
                table: "PhoneDetailds",
                column: "IdChipCPU");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneDetailds_IdChipGPU",
                table: "PhoneDetailds",
                column: "IdChipGPU");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneDetailds_IdColor",
                table: "PhoneDetailds",
                column: "IdColor");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneDetailds_IdDiscount",
                table: "PhoneDetailds",
                column: "IdDiscount");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneDetailds_IdMaterial",
                table: "PhoneDetailds",
                column: "IdMaterial");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneDetailds_IdOperatingSystem",
                table: "PhoneDetailds",
                column: "IdOperatingSystem");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneDetailds_IdPhone",
                table: "PhoneDetailds",
                column: "IdPhone");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneDetailds_IdRam",
                table: "PhoneDetailds",
                column: "IdRam");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneDetailds_IdRom",
                table: "PhoneDetailds",
                column: "IdRom");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneDetailds_IdSim",
                table: "PhoneDetailds",
                column: "IdSim");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_IdProductionCompany",
                table: "Phones",
                column: "IdProductionCompany");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_IdWarranty",
                table: "Phones",
                column: "IdWarranty");

            migrationBuilder.CreateIndex(
                name: "IX_SalePhoneDetailds_IdPhoneDetaild",
                table: "SalePhoneDetailds",
                column: "IdPhoneDetaild");

            migrationBuilder.CreateIndex(
                name: "IX_SalePhoneDetailds_IdSales",
                table: "SalePhoneDetailds",
                column: "IdSales");

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetails_PhoneDetailds_IdPhoneDetail",
                table: "BillDetails",
                column: "IdPhoneDetail",
                principalTable: "PhoneDetailds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetails_Carts_IdAccount",
                table: "CartDetails",
                column: "IdAccount",
                principalTable: "Carts",
                principalColumn: "IdAccount");

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetails_PhoneDetailds_IdPhoneDetaild",
                table: "CartDetails",
                column: "IdPhoneDetaild",
                principalTable: "PhoneDetailds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Accounts_IdAccount",
                table: "Carts",
                column: "IdAccount",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListImage_PhoneDetailds_IdPhoneDetaild",
                table: "ListImage",
                column: "IdPhoneDetaild",
                principalTable: "PhoneDetailds",
                principalColumn: "Id");
        }
    }
}
