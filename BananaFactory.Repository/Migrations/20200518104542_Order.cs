using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BananaFactory.Repository.Migrations
{
    public partial class Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderStatus = table.Column<int>(type: "int", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    PaymentType = table.Column<int>(type: "int", nullable: false),
                    DeliveryType = table.Column<int>(type: "int", nullable: false),
                    DeliveryStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                    table.CheckConstraint("CK_Order_DeliveryStatus_Enum_Constraint", "[DeliveryStatus] IN(0, 1, 2, 3, 4, 5, 6)");
                    table.CheckConstraint("CK_Order_DeliveryType_Enum_Constraint", "[DeliveryType] IN(0, 1, 2)");
                    table.CheckConstraint("CK_Order_OrderStatus_Enum_Constraint", "[OrderStatus] IN(0, 1, 2)");
                    table.CheckConstraint("CK_Order_PaymentStatus_Enum_Constraint", "[PaymentStatus] IN(0, 1, 2)");
                    table.CheckConstraint("CK_Order_PaymentType_Enum_Constraint", "[PaymentType] IN(0, 1, 2)");
                    table.ForeignKey(
                        name: "FK_Order_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerID",
                table: "Order",
                column: "CustomerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
