using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Oficina.Models
{
    public class OficinaContext : DbContext
    {
        public OficinaContext (DbContextOptions<OficinaContext> options)
            : base(options)
        {
        }

        public DbSet<Oficina.Models.Company> Company { get; set; }
    }
}
