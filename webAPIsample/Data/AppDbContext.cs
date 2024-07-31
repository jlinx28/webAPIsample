using Microsoft.EntityFrameworkCore;
using webAPIsample.Data.Models;

namespace webAPIsample.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        public DbSet<Book> Books { get; set; }
    }
}
