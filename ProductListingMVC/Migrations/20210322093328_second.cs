using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductListingMVC.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "products",
                newName: "Varchar(100)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Varchar(100)",
                table: "products",
                newName: "ProductName");
        }
    }
}
