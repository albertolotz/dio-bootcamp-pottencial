using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CL04Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Doc.CL03Data.Configuration
{
    public class EnderecoConfig : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            // exemplo de como cong. relaçcao 1:1 manual, porem pela convenção o resultado é o mesmo.
            //builder.HasOne(p => p.Cliente)
            //    .WithOne(p => p.Endereco)
            //    .HasForeignKey<Endereco>(p => p.ClienteId); // relação 1:1 um cliente tem um endereço ligados por clienteID

            builder.HasKey(p => p.ClienteId);

            builder.Property(p => p.Cep).HasMaxLength(8).IsRequired();
            builder.Property(p => p.Numero).HasMaxLength(56).IsRequired();
            builder.Property(p => p.Estado).HasMaxLength(2).IsRequired();
            builder.Property(p => p.Cidade).HasMaxLength(120).IsRequired();
            builder.Property(p => p.Complemento).HasMaxLength(60);
        }
    }
}