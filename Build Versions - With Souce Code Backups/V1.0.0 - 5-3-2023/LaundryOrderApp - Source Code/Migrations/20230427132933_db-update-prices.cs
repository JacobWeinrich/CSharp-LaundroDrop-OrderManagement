using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LaundryOrderAppMain.Migrations
{
    /// <inheritdoc />
    public partial class dbupdateprices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    PricesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.PricesID);
                });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "PricesID", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "PricePerPound", 1.25 },
                    { 2, "PricePerPound-Comercial", 1.5 },
                    { 3, "Comforter-Twin", 17.0 },
                    { 4, "Comforter-Full", 18.0 },
                    { 5, "Comforter-Queen", 19.0 },
                    { 6, "Comforter-King", 20.0 },
                    { 7, "Blanket-Twin", 15.0 },
                    { 8, "Blanket-Full", 16.0 },
                    { 9, "Blanket-Queen", 17.0 },
                    { 10, "Blanket-King", 18.0 },
                    { 11, "Rug-Small", 15.0 },
                    { 12, "Rug-Large", 20.0 },
                    { 13, "SleepingBag-Single", 15.0 },
                    { 14, "SleepingBag-Large", 20.0 },
                    { 15, "Pillow", 5.0 },
                    { 16, "HorseBlanket", 25.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prices");
        }
    }
}
