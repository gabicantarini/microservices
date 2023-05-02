using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 1L, "Mug", "", "https://github.com/gabicantarini/microservices/blob/main/GeekShopping/ShoppingImages/10_milennium_falcon.jpg", "Mario Bross Mug", 69.9m },
                    { 2L, "Action Figure", "Star Wars Mission Fleet Han Solo Nave Milennium Falcon", "https://github.com/gabicantarini/microservices/blob/main/GeekShopping/ShoppingImages/10_milennium_falcon.jpg", "Milennium Falcon", 359.99m },
                    { 3L, "T-Shirt", "", "https://github.com/gabicantarini/microservices/blob/main/GeekShopping/ShoppingImages/10_milennium_falcon.jpg", "Gamer T-shirt", 69.9m },
                    { 4L, "T-Shirt", "", "https://github.com/gabicantarini/microservices/blob/main/GeekShopping/ShoppingImages/10_milennium_falcon.jpg", "Coffee Benefits T-shirt", 69.9m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);
        }
    }
}
