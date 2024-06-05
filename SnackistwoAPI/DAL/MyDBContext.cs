using Microsoft.EntityFrameworkCore;

namespace SnackistwoAPI.DAL
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
        }

        public DbSet<Models.Category> Category { get; set; }
    }
}
