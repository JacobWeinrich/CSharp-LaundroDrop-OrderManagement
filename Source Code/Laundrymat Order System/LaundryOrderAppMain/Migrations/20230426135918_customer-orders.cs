using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaundryOrderAppMain.Migrations
{
    /// <inheritdoc />
    public partial class customerorders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    IsComercial = table.Column<bool>(type: "bit", nullable: false),
                    IsPickedUp = table.Column<bool>(type: "bit", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    LaundryPounds = table.Column<double>(type: "float", nullable: false),
                    ComfortersTwin = table.Column<int>(type: "int", nullable: false),
                    ComfortersFull = table.Column<int>(type: "int", nullable: false),
                    ComfortersQueen = table.Column<int>(type: "int", nullable: false),
                    ComfortersKing = table.Column<int>(type: "int", nullable: false),
                    BlanketsTwin = table.Column<int>(type: "int", nullable: false),
                    BlanketsFull = table.Column<int>(type: "int", nullable: false),
                    BlanketsQueen = table.Column<int>(type: "int", nullable: false),
                    BlanketsKing = table.Column<int>(type: "int", nullable: false),
                    RugsSmall = table.Column<int>(type: "int", nullable: false),
                    RugsLarge = table.Column<int>(type: "int", nullable: false),
                    SleepingBagSingle = table.Column<int>(type: "int", nullable: false),
                    SleepingBagDouble = table.Column<int>(type: "int", nullable: false),
                    Pillows = table.Column<int>(type: "int", nullable: false),
                    HorseBlankets = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderID", "BlanketsFull", "BlanketsKing", "BlanketsQueen", "BlanketsTwin", "ComfortersFull", "ComfortersKing", "ComfortersQueen", "ComfortersTwin", "CustomerID", "HorseBlankets", "IsComercial", "IsPaid", "IsPickedUp", "LaundryPounds", "Pillows", "RugsLarge", "RugsSmall", "SleepingBagDouble", "SleepingBagSingle", "TotalPrice" },
                values: new object[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, false, false, false, 0.0, 0, 0, 0, 0, 0, 0.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
