using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Context
{
    public class AgendaContext : DbContext
    {
       public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
       {
           // recebe conexão do banco, passa para o base que é dbcontext
           // enão inicia a conexao com banco de dados.
       } 

       public DbSet<Contato> Contatos{ get; set;}
       
    }
}