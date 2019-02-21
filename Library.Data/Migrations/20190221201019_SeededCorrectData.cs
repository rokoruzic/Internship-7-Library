using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Data.Migrations
{
    public partial class SeededCorrectData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BookRents",
                keyColumn: "BookRentId",
                keyValue: 1,
                column: "DateOfRent",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2000, 2, 21, 21, 4, 21, 694, DateTimeKind.Local).AddTicks(8544));
        }
    }
}
