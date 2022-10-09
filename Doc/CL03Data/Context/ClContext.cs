using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CL04Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace CL03Data.Context
{
    public class ClContext : DbContext
    {
        public ClContext(DbContextOptions<ClContext> options) : base(options)
        {
        }
        
        public DbSet<Cliente> Clientes { get; set; }

    }
}
