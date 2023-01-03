using asp_practice.Models;
using Microsoft.EntityFrameworkCore;

namespace asp_practice.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
