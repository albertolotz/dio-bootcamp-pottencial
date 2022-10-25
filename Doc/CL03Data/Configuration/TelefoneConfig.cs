using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CL04Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Doc.CL03Data.Configuration
{
    public class TelefoneConfig : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Telefone> builder)
        {
            //builder se refere ao telefone...
            // configuração é a convenção... apenas exemplo
            //builder.HasOne(p => p.Cliente).WithMany(p => p.Telefones)
            //        .IsRequired()
            //        .OnDelete(DeleteBehavior.Cascade);

            builder.HasKey(p => new { p.ClienteId, p.Numero }); // definição de uma chave composta...
            //builder.Property(p => p.Numero).HasMaxLength(56).IsRequired();
        }
    }
}