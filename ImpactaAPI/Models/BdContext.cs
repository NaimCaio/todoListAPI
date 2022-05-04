using Microsoft.EntityFrameworkCore;

namespace ImpactaAPI.Models
{
    public class BdContext : DbContext
    {
        public DbSet<Todo> todoList { get; set; }
        public DbSet<User> users { get; set; }


        public BdContext(DbContextOptions<BdContext> options) : base(options)
        {

        }
    }
}
