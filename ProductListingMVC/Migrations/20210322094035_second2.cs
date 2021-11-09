using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductListingMVC.Migrations
{
    public partial class second2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Varchar(100)",
                table: "products",
                newName: "Supplier");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "Supplier",
                table: "products",
                newName: "Varchar(100)");
        }
    }
}
