using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {

        public MySQLContext() { }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }
    
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Mario Bross Mug",
                Price = new decimal(69.90),
                Description = "",
                ImageUrl = "https://github.com/gabicantarini/microservices/blob/main/GeekShopping/ShoppingImages/10_milennium_falcon.jpg",
                CategoryName = "Mug"

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Milennium Falcon",
                Price = new decimal(359.99),
                Description = "Star Wars Mission Fleet Han Solo Nave Milennium Falcon",
                ImageUrl = "https://github.com/gabicantarini/microservices/blob/main/GeekShopping/ShoppingImages/10_milennium_falcon.jpg",
                CategoryName = "Action Figure"

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Gamer T-shirt",
                Price = new decimal(69.90),
                Description = "",
                ImageUrl = "https://github.com/gabicantarini/microservices/blob/main/GeekShopping/ShoppingImages/10_milennium_falcon.jpg",
                CategoryName = "T-Shirt"

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Coffee Benefits T-shirt",
                Price = new decimal(69.90),
                Description = "",
                ImageUrl = "https://github.com/gabicantarini/microservices/blob/main/GeekShopping/ShoppingImages/10_milennium_falcon.jpg",
                CategoryName = "T-Shirt"

            });
        }
    
    }
}
