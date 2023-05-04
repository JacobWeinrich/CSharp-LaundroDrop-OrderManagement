using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaundryOrderAppMain.Migrations
{
    /// <inheritdoc />
    public partial class dbupdatedateorders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 27, 9, 1, 21, 285, DateTimeKind.Local).AddTicks(1109));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
