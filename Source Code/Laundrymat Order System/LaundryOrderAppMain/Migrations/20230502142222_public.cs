using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaundryOrderAppMain.Migrations
{
    /// <inheritdoc />
    public partial class @public : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 2, 9, 22, 22, 736, DateTimeKind.Local).AddTicks(6725));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 27, 9, 1, 21, 285, DateTimeKind.Local).AddTicks(1109));
        }
    }
}
