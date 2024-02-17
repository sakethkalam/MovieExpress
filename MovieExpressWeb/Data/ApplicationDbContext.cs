using Microsoft.EntityFrameworkCore;
using MovieExpressWeb.Models;

namespace MovieExpressWeb.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        
        public DbSet<Category> Categories { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category { Id=1,MovieName = "Jalsa", Description = "Love Story", Genere = "Romance" },
                                                     new Category { Id=2, MovieName = "Salar", Description = "Friends story", Genere = "Action" },
                                                     new Category { Id=3, MovieName = "Karthikeya", Description = "Gods Story", Genere = "Thriller" });
                                                                            
        }
        
        
    }
}
