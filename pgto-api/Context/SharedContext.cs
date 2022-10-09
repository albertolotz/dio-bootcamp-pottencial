using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pgto_api.Models;

namespace pgto_api.Context
{
    public class SharedContext : DbContext
    {
        public SharedContext(DbContextOptions<SharedContext> options) : base(options)
        {
        }
        public DbSet<Vendedor> Vendedores{ get; set; }
        public DbSet<Produto> Produtos{ get; set; }
        public DbSet<Venda> Vendas{ get; set; }
        
    }
}