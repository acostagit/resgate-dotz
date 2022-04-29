using Dotz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Infra.Data.Mapping
{
    class ContaMapping : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(c => c.DataCompra)
                .IsRequired()
                .HasColumnName("DataCompra")
                .HasColumnType("datetime");

            builder.Property(c => c.Pontos)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("Pontos");                

            builder.OwnsOne(c => c.Cliente, cm =>
            {
                cm.Property(c => c.Id)
                  .IsRequired()
                  .HasColumnType("int");

                cm.Property(c => c.Nome)
                    .IsRequired()
                    .HasColumnName("Nome")
                    .HasColumnType("varchar(200)");

                cm.Property(c => c.CPF)
                    .IsRequired()
                    .HasColumnName("CPF")
                    .HasColumnType("varchar(11)");
            });

            builder.OwnsOne(p => p.Produto, pc=>
            {               
                pc.Property(p => p.Id)
                  .IsRequired()
                  .HasColumnType("int");
                
                pc.Property(p => p.Descricao)
                    .IsRequired()
                    .HasColumnName("Descricao")
                    .HasColumnType("varchar(200)");

                pc.Property(p => p.DataCadastro)
                    .IsRequired()
                    .HasColumnName("DataCadastro");

                pc.Property(p => p.Valor)
                  .IsRequired()
                  .HasColumnType("decimal");

                pc.Property(p => p.QuantidadeEstoque)
                  .IsRequired()
                  .HasColumnType("int");

                pc.Property(p => p.PontuacaoMinima)
                  .IsRequired()
                  .HasColumnType("int");
            });           

            builder.ToTable("Conta");
        }
    }
}
