using Microsoft.EntityFrameworkCore;
using resturant.productApi.Models.Dto;

namespace resturant.productApi.DbContexts

{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seed the data
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "sama",
                Price=15,
                Description="dddd hhhhh dddd fffff",
                ImgUrl= "/images/4.jpg",
                CategoryName="Category1"
            }) ;
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "rewan",
                Price = 15,
                Description = "dddd hhhhh dddd fffff",
                ImgUrl = "/images/1.jpg",
                CategoryName = "Category2"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "menna",
                Price = 15,
                Description = "dddd hhhhh dddd fffff",
                ImgUrl = "/images/2.jpg",
                CategoryName = "Category3"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "ahmed",
                Price = 15,
                Description = "dddd hhhhh dddd fffff",
                ImgUrl = "/images/3.jpg",
                CategoryName = "Category4"
            });
        }
        public DbSet<Product> Products { get; set; }
    }
}
