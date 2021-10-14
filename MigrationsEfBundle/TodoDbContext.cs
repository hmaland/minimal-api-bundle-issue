using Microsoft.EntityFrameworkCore;

namespace MigrationsEfBundle
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions options) : base(options)
        {
        }

        protected TodoDbContext()
        {
        }
        public DbSet<TodoItem> TodoItems { get; set; }
    }

}
