using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BicycleRental.Migrations
{
    public partial class AddedSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bicycle_brands",
                columns: table => new
                {
                    Brand_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bicycle_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bicycle_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avilability = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bicycle_brands", x => x.Brand_id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Customer_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_First_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Customer_Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone_number = table.Column<long>(type: "BigInt", nullable: false),
                    E_mail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Customer_id);
                });

            migrationBuilder.CreateTable(
                name: "DatabaseOwners",
                columns: table => new
                {
                    OwnersFirstName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OwnersLastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatabaseOwners", x => x.OwnersFirstName);
                });

            migrationBuilder.CreateTable(
                name: "Bicycles",
                columns: table => new
                {
                    Bicycle_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Frame_number = table.Column<int>(type: "int", nullable: false),
                    Brand_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bicycles", x => x.Bicycle_id);
                    table.ForeignKey(
                        name: "FK_Bicycles_Bicycle_brands_Brand_id",
                        column: x => x.Brand_id,
                        principalTable: "Bicycle_brands",
                        principalColumn: "Brand_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Booking_details",
                columns: table => new
                {
                    Booking_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Booking_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Return_due_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rental_price = table.Column<float>(type: "real", nullable: false),
                    Customer_id = table.Column<int>(type: "int", nullable: false),
                    Bicycle_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking_details", x => x.Booking_id);
                    table.ForeignKey(
                        name: "FK_Booking_details_Bicycles_Bicycle_id",
                        column: x => x.Bicycle_id,
                        principalTable: "Bicycles",
                        principalColumn: "Bicycle_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_details_Customers_Customer_id",
                        column: x => x.Customer_id,
                        principalTable: "Customers",
                        principalColumn: "Customer_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bicycles_Brand_id",
                table: "Bicycles",
                column: "Brand_id");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_details_Bicycle_id",
                table: "Booking_details",
                column: "Bicycle_id");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_details_Customer_id",
                table: "Booking_details",
                column: "Customer_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking_details");

            migrationBuilder.DropTable(
                name: "DatabaseOwners");

            migrationBuilder.DropTable(
                name: "Bicycles");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Bicycle_brands");
        }
    }
}
