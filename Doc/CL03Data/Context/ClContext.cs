using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CL04Core.Domain;
using Doc.CL03Data.Configuration;
using Microsoft.EntityFrameworkCore;

namespace CL03Data.Context
{
    public class ClContext : DbContext
    {
        public ClContext(DbContextOptions<ClContext> options) : base(options)
        {
        }
        
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ClienteConfig());
            modelBuilder.ApplyConfiguration(new EnderecoConfig());
        }

    }
}
