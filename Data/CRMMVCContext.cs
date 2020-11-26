using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRMMVC.Models;

namespace CRMMVC.Data
{
    public class CRMMVCContext : DbContext
    {
        public CRMMVCContext (DbContextOptions<CRMMVCContext> options)
            : base(options)
        {
        }

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
