using Microsoft.EntityFrameworkCore;
using CRMMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


/* FOR MIGRATIONS:
 * Add-Migration -context CRMMVCContext
 * Update-Database -context CRMMVCContext
 */


namespace CRMMVC.Data
{
    public class CRMMVCContext : IdentityDbContext<Users>
    {
        public CRMMVCContext(DbContextOptions<CRMMVCContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }
        public DbSet<CRMMVC.Models.Posts> Posts { get; set; }
        public DbSet<CRMMVC.Models.Departments> Departments { get; set; }
        override public DbSet<CRMMVC.Models.Users> Users { get; set; }
        public DbSet<CRMMVC.Models.Clients> Clients { get; set; }
        /*
        internal void Add(Clients clients)
        {
            throw new NotImplementedException();
        }

        internal Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }*/
    }
}
