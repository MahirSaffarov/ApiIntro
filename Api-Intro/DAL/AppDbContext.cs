using Api_Intro.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_Intro.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Country> Countries { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Azerbaijan"

                },
                new Country
                {
                    Id = 2,
                    Name = "Germany"
                }
                );
        }

    }
}
