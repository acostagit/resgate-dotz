using Dotz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Infra.Data.Mapping
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Descricao)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.Valor)
                .IsRequired()
                .HasColumnType("decimal");

            builder.Property(c => c.QuantidadeEstoque)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(c => c.PontuacaoMinima)
              .IsRequired()
              .HasColumnType("int");

            builder.Property(c => c.DataCadastro)
                   .IsRequired()
                   .HasColumnName("DataCadastro")
                   .HasColumnType("datetime");

            //re-ver 
            /*builder.OwnsOne(c => c.SubCategorias, cm =>
            {
                cm.Property(c => c.Nome)
                    .HasColumnName("Nome")
                    .HasColumnType("varchar(200)");

                *//*cm.Property(c => c.CategoriaId)
                    .HasColumnName("CategoriaId")
                    .HasColumnType("int");*//*
            });*/

            builder.ToTable("Produto");

        }
    }
}
