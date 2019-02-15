using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Data.Migrations
{
    public partial class ChangedBookRentIdFromCompositeToPrimary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookRents",
                table: "BookRents");

            migrationBuilder.DropColumn(
                name: "IsRentActive",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "BookRentId",
                table: "BookRents",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookRents",
                table: "BookRents",
                column: "BookRentId");

            migrationBuilder.CreateIndex(
                name: "IX_BookRents_BookId",
                table: "BookRents",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookRents",
                table: "BookRents");

            migrationBuilder.DropIndex(
                name: "IX_BookRents_BookId",
                table: "BookRents");

            migrationBuilder.DropColumn(
                name: "BookRentId",
                table: "BookRents");

            migrationBuilder.AddColumn<bool>(
                name: "IsRentActive",
                table: "Students",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookRents",
                table: "BookRents",
                columns: new[] { "BookId", "StudentId" });
        }
    }
}
