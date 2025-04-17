using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetCoreEFCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class addmigrationsp3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Basket",
                columns: table => new
                {
                    Id_Basket = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Total_Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basket", x => x.Id_Basket);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id_Categories = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_Categories = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id_Categories);
                });

            migrationBuilder.CreateTable(
                name: "PromoPackets",
                columns: table => new
                {
                    Id_Product = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price_Packet = table.Column<int>(type: "int", nullable: false),
                    Photo_Pack = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type_Pack = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoPackets", x => x.Id_Product);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    CNP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    born_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.CNP);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id_Product = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_Product = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price_Product = table.Column<int>(type: "int", nullable: false),
                    Image_Product = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_Product = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Categories = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id_Product);
                    table.ForeignKey(
                        name: "FK_Products_Categories_Id_Categories",
                        column: x => x.Id_Categories,
                        principalTable: "Categories",
                        principalColumn: "Id_Categories",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    Id_Feedback = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_Full = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.Id_Feedback);
                    table.ForeignKey(
                        name: "FK_Feedback_Users_CNP",
                        column: x => x.CNP,
                        principalTable: "Users",
                        principalColumn: "CNP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id_Order = table.Column<int>(type: "int", nullable: false),
                    Total_Price = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNP_Client = table.Column<int>(type: "int", nullable: false),
                    UsersCNP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id_Order);
                    table.ForeignKey(
                        name: "FK_Orders_Basket_Id_Order",
                        column: x => x.Id_Order,
                        principalTable: "Basket",
                        principalColumn: "Id_Basket",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UsersCNP",
                        column: x => x.UsersCNP,
                        principalTable: "Users",
                        principalColumn: "CNP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BasketDetails",
                columns: table => new
                {
                    Id_Product = table.Column<int>(type: "int", nullable: false),
                    Id_Basket = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketDetails", x => new { x.Id_Product, x.Id_Basket });
                    table.ForeignKey(
                        name: "FK_BasketDetails_Basket_Id_Basket",
                        column: x => x.Id_Basket,
                        principalTable: "Basket",
                        principalColumn: "Id_Basket",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketDetails_Products_Id_Product",
                        column: x => x.Id_Product,
                        principalTable: "Products",
                        principalColumn: "Id_Product",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PromoPackets_Products",
                columns: table => new
                {
                    Id_Packet = table.Column<int>(type: "int", nullable: false),
                    Id_Product = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoPackets_Products", x => new { x.Id_Packet, x.Id_Product });
                    table.ForeignKey(
                        name: "FK_PromoPackets_Products_Products_Id_Product",
                        column: x => x.Id_Product,
                        principalTable: "Products",
                        principalColumn: "Id_Product",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PromoPackets_Products_PromoPackets_Id_Packet",
                        column: x => x.Id_Packet,
                        principalTable: "PromoPackets",
                        principalColumn: "Id_Product",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order_Details",
                columns: table => new
                {
                    Id_Order = table.Column<int>(type: "int", nullable: false),
                    Id_Product = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_Details", x => new { x.Id_Order, x.Id_Product });
                    table.ForeignKey(
                        name: "FK_Order_Details_Orders_Id_Order",
                        column: x => x.Id_Order,
                        principalTable: "Orders",
                        principalColumn: "Id_Order",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Details_Products_Id_Product",
                        column: x => x.Id_Product,
                        principalTable: "Products",
                        principalColumn: "Id_Product",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasketDetails_Id_Basket",
                table: "BasketDetails",
                column: "Id_Basket");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_CNP",
                table: "Feedback",
                column: "CNP");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Details_Id_Product",
                table: "Order_Details",
                column: "Id_Product");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UsersCNP",
                table: "Orders",
                column: "UsersCNP");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Id_Categories",
                table: "Products",
                column: "Id_Categories");

            migrationBuilder.CreateIndex(
                name: "IX_PromoPackets_Products_Id_Product",
                table: "PromoPackets_Products",
                column: "Id_Product");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketDetails");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "Order_Details");

            migrationBuilder.DropTable(
                name: "PromoPackets_Products");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "PromoPackets");

            migrationBuilder.DropTable(
                name: "Basket");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
