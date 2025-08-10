using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class onetomanyrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "catId",
                table: "Products",
                type: "int",
                nullable: true);

            /*migrationBuilder.AddColumn<decimal>(
                name: "price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);*/

            migrationBuilder.CreateIndex(
                name: "IX_Products_catId",
                table: "Products",
                column: "catId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_catId",
                table: "Products",
                column: "catId",
                principalTable: "Categories",
                principalColumn: "categoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_catId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_catId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "catId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "price",
                table: "Products");
        }
    }
}
