using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class AddProductDataTableOnDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    price = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    description = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    image_url = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 2L, "Mug", "", "https://github.com/gabicantarini/microservices/blob/main/GeekShopping/ShoppingImages/10_milennium_falcon.jpg", "Mario Bross Mug", 69.9m },
                    { 3L, "Action Figure", "Star Wars Mission Fleet Han Solo Nave Milennium Falcon", "https://github.com/gabicantarini/microservices/blob/main/GeekShopping/ShoppingImages/10_milennium_falcon.jpg", "Milennium Falcon", 359.99m },
                    { 4L, "T-Shirt", "", "https://github.com/gabicantarini/microservices/blob/main/GeekShopping/ShoppingImages/10_milennium_falcon.jpg", "Gamer T-shirt", 69.9m },
                    { 5L, "T-Shirt", "", "https://github.com/gabicantarini/microservices/blob/main/GeekShopping/ShoppingImages/10_milennium_falcon.jpg", "Coffee Benefits T-shirt", 69.9m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "product");
        }
    }
}
