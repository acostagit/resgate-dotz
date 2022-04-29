using Dotz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Infra.Data.Mapping
{
    class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(p => p.Id);
            
            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnName("Nome").HasMaxLength(100);

            builder.Property(c => c.CPF)
                .IsRequired()
                .HasColumnName("CPF").HasMaxLength(11);

            builder.ToTable("Cliente");
        }
    }
}
