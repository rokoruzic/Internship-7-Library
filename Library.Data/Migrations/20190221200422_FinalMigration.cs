using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Data.Migrations
{
    public partial class FinalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "FirstName", "LastName" },
                values: new object[] { 1, "Jure", "Radalj" });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 1, "Croatia" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Class", "DateOfBirth", "FirstName", "Gender", "LastName" },
                values: new object[] { 1, "2.b", new DateTime(2000, 2, 21, 21, 4, 21, 694, DateTimeKind.Local).AddTicks(8544), "Kristian", 1, "Zolo" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "Genre", "Name", "Pages", "PublisherId" },
                values: new object[] { 1, null, 4, "Milenium", 123, 1 });

            migrationBuilder.InsertData(
                table: "BookRents",
                columns: new[] { "BookRentId", "BookId", "DateOfRent", "DateOfReturn", "StudentId" },
                values: new object[] { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(100), null, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookRents",
                keyColumn: "BookRentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 1);
        }
    }
}
