using Dotz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Infra.Data.Mapping
{
    public class SubCategoriaMapping : IEntityTypeConfiguration<SubCategoria>
    {
        public void Configure(EntityTypeBuilder<SubCategoria> builder)
        {
            builder.HasKey(p => p.Id);
            
            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnName("Nome")
                .HasMaxLength(100);

         /*   builder.HasMany(c => c.Categorias)
                .WithOne(p => p.)*/

          /*  builder.OwnsOne(c => c.Categoria, cm =>
            {
                cm.Property(c => c.Nome)
                    .HasColumnName("Nome")
                    .HasColumnType("varchar(200)");
                
            });*/


            builder.ToTable("SubCategoria");
        }
    }
}
