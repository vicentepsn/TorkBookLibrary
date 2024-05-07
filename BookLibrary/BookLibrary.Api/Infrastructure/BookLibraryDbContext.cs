using BookLibrary.Api.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Api.Infrastructure
{
    public class BookLibraryDbContext : DbContext
    {
        //entities
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SchoolDb;Trusted_Connection=True;");
        }
    }
}
