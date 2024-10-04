using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_project.Migrations
{
    /// <inheritdoc />
    public partial class addTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Customer_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_IdCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Customer_Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Employee_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_IdCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Employee_Id);
                });

            migrationBuilder.CreateTable(
                name: "Offer",
                columns: table => new
                {
                    Offer_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Offer_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Offer_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Offer_Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Offer_Discount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Offer_Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offer", x => x.Offer_Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Payment_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Payment_Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Payment_Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Payment_Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Payment_Method = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Payment_Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Payment_Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Payment_Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Room_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Room_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Room_Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rent_Per_Day = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Room_Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rent_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Room_Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Room_ID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Service_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Service_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Service_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Service_Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Service_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Service_Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Service_Price = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Service_Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Frist_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Role = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_Id);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Booking_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Room_Id = table.Column<int>(type: "int", nullable: false),
                    Employee_Id = table.Column<int>(type: "int", nullable: false),
                    Customer_Id = table.Column<int>(type: "int", nullable: false),
                    Booking_Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckIn_Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckOut_Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Payment_Id = table.Column<int>(type: "int", nullable: false),
                    Offer_Id = table.Column<int>(type: "int", nullable: false),
                    Booking_Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Booking_Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Customers_Customer_Id",
                        column: x => x.Customer_Id,
                        principalTable: "Customers",
                        principalColumn: "Customer_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Employees_Employee_Id",
                        column: x => x.Employee_Id,
                        principalTable: "Employees",
                        principalColumn: "Employee_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Offer_Offer_Id",
                        column: x => x.Offer_Id,
                        principalTable: "Offer",
                        principalColumn: "Offer_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Payments_Payment_Id",
                        column: x => x.Payment_Id,
                        principalTable: "Payments",
                        principalColumn: "Payment_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Rooms_Room_Id",
                        column: x => x.Room_Id,
                        principalTable: "Rooms",
                        principalColumn: "Room_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Customer_Id",
                table: "Bookings",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Employee_Id",
                table: "Bookings",
                column: "Employee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Offer_Id",
                table: "Bookings",
                column: "Offer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Payment_Id",
                table: "Bookings",
                column: "Payment_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Room_Id",
                table: "Bookings",
                column: "Room_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Offer");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
