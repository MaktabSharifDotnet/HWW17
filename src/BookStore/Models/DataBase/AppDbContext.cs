using BookStore.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Models.DataBase
{
    public class AppDbContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-M2BLLND\\SQLEXPRESS;Database=HWW17;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
        }
    }
}
