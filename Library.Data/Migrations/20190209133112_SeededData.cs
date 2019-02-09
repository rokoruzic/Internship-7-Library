using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Data.Migrations
{
    public partial class SeededData : Migration
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
                columns: new[] { "StudentId", "Class", "DateOfBirth", "FirstName", "Gender", "IsRentActive", "LastName", "Name" },
                values: new object[] { 1, "2.b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(13), "Kristian", 1, true, "Zolo", null });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Genre", "IsRentActive", "Name", "Pages", "PublisherId" },
                values: new object[] { 1, 4, true, "Milenium", 123, 1 });

            migrationBuilder.InsertData(
                table: "AuthorsBooks",
                columns: new[] { "BookId", "AuthorId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "BookRents",
                columns: new[] { "BookId", "StudentId", "DateOfRent", "DateOfReturn" },
                values: new object[] { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(100), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthorsBooks",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "BookRents",
                keyColumns: new[] { "BookId", "StudentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
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
