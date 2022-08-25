using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace resturant.productApi.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImgUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 4, "Category1", "dddd hhhhh dddd fffff", "/images/4.jpg", "sama", 15.0 },
                    { 6, "Category2", "dddd hhhhh dddd fffff", "/images/1.jpg", "rewan", 15.0 },
                    { 8, "Category3", "dddd hhhhh dddd fffff", "/images/2.jpg", "menna", 15.0 },
                    { 10, "Category4", "dddd hhhhh dddd fffff", "/images/3.jpg", "ahmed", 15.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);
        }
    }
}
