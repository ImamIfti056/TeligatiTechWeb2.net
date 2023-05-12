using Microsoft.EntityFrameworkCore;
using TeligatiTechWeb2.Models;

namespace TeligatiTechWeb2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
    }
}
