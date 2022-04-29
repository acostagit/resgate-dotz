using Dotz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Infra.Data.Mapping
{
    public class EnderecoEntregaMapping : IEntityTypeConfiguration<EnderecoEntrega>
    {
        public void Configure(EntityTypeBuilder<EnderecoEntrega> builder)
        {
            builder.HasKey(p => p.Id);
            
            builder.Property(c => c.Descricao)
                .IsRequired()
                .HasColumnName("Descricao").HasMaxLength(100);

            builder.Property(c => c.Cidade)
                .IsRequired()
                .HasColumnName("Cidade").HasMaxLength(50);

            builder.Property(c => c.UF)
                .IsRequired()
                .HasColumnName("UF").HasMaxLength(2);

            builder.ToTable("EnderecoEntrega");
        }
    }
}
