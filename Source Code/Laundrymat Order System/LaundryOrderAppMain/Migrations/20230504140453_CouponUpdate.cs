using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaundryOrderAppMain.Migrations
{
    /// <inheritdoc />
    public partial class CouponUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    CouponID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Used = table.Column<bool>(type: "bit", nullable: false),
                    ISDropOffServiceCoupon = table.Column<bool>(type: "bit", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.CouponID);
                });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "CouponID", "CreatedDate", "Description", "DiscountAmount", "ExpDate", "ISDropOffServiceCoupon", "Instructions", "StartDate", "Used" },
                values: new object[] { 1, new DateTime(2023, 5, 4, 9, 4, 53, 405, DateTimeKind.Local).AddTicks(8805), "1 Free Wash Any Size Washer", null, new DateTime(2023, 5, 4, 9, 4, 53, 405, DateTimeKind.Local).AddTicks(8808), false, "Start 1 Washer of any Size for Customer", new DateTime(2023, 5, 4, 9, 4, 53, 405, DateTimeKind.Local).AddTicks(8807), false });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 4, 9, 4, 53, 405, DateTimeKind.Local).AddTicks(8738));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 2, 9, 22, 22, 736, DateTimeKind.Local).AddTicks(6725));
        }
    }
}
