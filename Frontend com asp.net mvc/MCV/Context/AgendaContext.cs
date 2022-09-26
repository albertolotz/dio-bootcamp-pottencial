using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCV.Models;
using Microsoft.EntityFrameworkCore;

namespace MCV.Context
{
    public class AgendaContext : DbContext  
    {
       public AgendaContext(DbContextOptions<AgendaContext>options) : base(options)
       {

       }

       public DbSet<Contato> Contatos { get; set; }
        
    }
}