using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaCompra.Infra.Data.SolicitacaoCompra
{
    internal class SolicitacaoCompraConfiguration : IEntityTypeConfiguration<Domain.SolicitacaoCompraAggregate.SolicitacaoCompra>
    {
        public void Configure(EntityTypeBuilder<Domain.SolicitacaoCompraAggregate.SolicitacaoCompra> builder)
        {
            builder.ToTable("SolicitacaoCompra");
            builder.OwnsOne(c => c.TotalGeral, b => b.Property("Value").HasColumnName("TotalGeral"));
        }
    }
}
