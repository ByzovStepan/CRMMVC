using Microsoft.EntityFrameworkCore;

namespace CRMMVC.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Clients> Clients { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        { }
        
    }
}
