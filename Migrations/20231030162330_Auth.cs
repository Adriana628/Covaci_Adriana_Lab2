using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Covaci_Adriana_Lab2.Migrations
{
    public partial class Auth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCategory_Book_BookId",
                table: "BookCategory");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "BookCategory",
                newName: "BookID");

            migrationBuilder.RenameIndex(
                name: "IX_BookCategory_BookId",
                table: "BookCategory",
                newName: "IX_BookCategory_BookID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategory_Book_BookID",
                table: "BookCategory",
                column: "BookID",
                principalTable: "Book",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCategory_Book_BookID",
                table: "BookCategory");

            migrationBuilder.RenameColumn(
                name: "BookID",
                table: "BookCategory",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BookCategory_BookID",
                table: "BookCategory",
                newName: "IX_BookCategory_BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategory_Book_BookId",
                table: "BookCategory",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
