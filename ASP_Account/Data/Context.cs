using Microsoft.EntityFrameworkCore;

namespace ASP_Account.Model
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options)
        : base(options)
        {
        }
        public DbSet<User> Users { get; set; } = null!;
    }
}
