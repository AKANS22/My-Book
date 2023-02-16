using Microsoft.EntityFrameworkCore;
using My_Book.Data.Model;

namespace My_Book.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) 
        { 
        
        
        }
        public DbSet<Book> books { get; set; }
    }
}
