using Microsoft.EntityFrameworkCore;

namespace MyWebApiNetCore6.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> opt) : base(opt)
        {

        }
        #region DbSet
        public DbSet<Book>? Books { get; set; }
        #endregion
    }
}
