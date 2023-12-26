using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kursach_Jewelry.Migrations
{
    public partial class Biba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    IdClient = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameClient = table.Column<string>(nullable: false),
                    PhoneClient = table.Column<string>(nullable: false),
                    OrderClient = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.IdClient);
                });

            migrationBuilder.CreateTable(
                name: "masters",
                columns: table => new
                {
                    IdMaster = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameMaster = table.Column<string>(nullable: false),
                    PhoneMaster = table.Column<string>(nullable: false),
                    OrderMaster = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_masters", x => x.IdMaster);
                });

            migrationBuilder.CreateTable(
                name: "materials",
                columns: table => new
                {
                    IdMaterials = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameMaterial = table.Column<string>(nullable: false),
                    ColorMaterial = table.Column<string>(nullable: false),
                    SampleMaterial = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materials", x => x.IdMaterials);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    IDProducts = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameProduct = table.Column<string>(nullable: false),
                    PriceProduct = table.Column<int>(nullable: false),
                    TypeProduct = table.Column<string>(nullable: false),
                    CountProduct = table.Column<int>(nullable: false),
                    MaterialID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.IDProducts);
                    table.ForeignKey(
                        name: "FK_products_materials_MaterialID",
                        column: x => x.MaterialID,
                        principalTable: "materials",
                        principalColumn: "IdMaterials",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    IdOrder = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientID = table.Column<int>(nullable: false),
                    DateOrder = table.Column<DateTime>(nullable: false),
                    CountOrder = table.Column<int>(nullable: false),
                    MasterOrder = table.Column<int>(nullable: false),
                    OrderCost = table.Column<int>(nullable: false),
                    ProductsID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.IdOrder);
                    table.ForeignKey(
                        name: "FK_orders_Client_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Client",
                        principalColumn: "IdClient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orders_masters_MasterOrder",
                        column: x => x.MasterOrder,
                        principalTable: "masters",
                        principalColumn: "IdMaster",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orders_products_ProductsID",
                        column: x => x.ProductsID,
                        principalTable: "products",
                        principalColumn: "IDProducts",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_orders_ClientID",
                table: "orders",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_orders_MasterOrder",
                table: "orders",
                column: "MasterOrder");

            migrationBuilder.CreateIndex(
                name: "IX_orders_ProductsID",
                table: "orders",
                column: "ProductsID");

            migrationBuilder.CreateIndex(
                name: "IX_products_MaterialID",
                table: "products",
                column: "MaterialID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "masters");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "materials");
        }
    }
}
