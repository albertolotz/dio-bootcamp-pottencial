using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CL04Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Doc.CL03Data.Configuration
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            //builder.HasKey(p => p.Id);
            //builder.Entity<Cliente>().ToTable("Cliente_novonome");
            //builder.Property(p => p.Nome).HasMaxLength(150).IsRequired();
            //builder.Property(p => p.Sexo).HasDefaultValue("I").IsRequired();
            //
            //builder.HasIndex(p => p.Nome);  // indeice simples
            //builder.HasIndex(p => new{p.Nome, p.Sexo}); // indice composto
        }
    }
}