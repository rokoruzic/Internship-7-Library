using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Data.Migrations
{
    public partial class addedStringExtensionsToModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BookRents",
                keyColumn: "BookRentId",
                keyValue: 1,
                column: "DateOfRent",
                value: new DateTime(2018, 2, 21, 21, 28, 32, 644, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2000, 2, 21, 21, 28, 32, 642, DateTimeKind.Local).AddTicks(7909));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BookRents",
                keyColumn: "BookRentId",
                keyValue: 1,
                column: "DateOfRent",
                value: new DateTime(2018, 2, 21, 21, 10, 18, 921, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2000, 2, 21, 21, 10, 18, 920, DateTimeKind.Local).AddTicks(3949));
        }
    }
}
