using Microsoft.EntityFrameworkCore;
using Bulky.Models;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Mystery", DisplayOrder = 3 }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product 
                { 
                    Id = 1, 
                    Title = "Fortune Of Time", 
                    Author = "Billy Spark",
                    Description = "Description",
                    ISBN = "SW4547684",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product 
                { 
                    Id = 2, 
                    Title = "The Monk Who sold His Ferrari", 
                    Author = "Robin Sharma",
                    Description = "Description of the Monk",
                    ISBN = "SW4547684",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 2,
                    ImageUrl = ""

                },
                new Product 
                { 
                    Id = 3, 
                    Title = "The second change", 
                    Author = "Robin Sharma",
                    Description = "About the second chance in life",
                    ISBN = "SW4547684",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 3,
                    ImageUrl = ""

                }
                );
        }

    }
}
