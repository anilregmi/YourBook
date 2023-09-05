using Microsoft.EntityFrameworkCore;
using YourBookWeb.Models;

namespace YourBookWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category>categories { get; set; }
    }
}
