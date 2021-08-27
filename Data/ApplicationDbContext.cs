using dotnettutorial.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnettutorial.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Category { get; set; }
    }
}