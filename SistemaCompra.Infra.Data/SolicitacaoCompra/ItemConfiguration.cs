using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaCompra.Infra.Data.SolicitacaoCompra
{
    public class ItemConfiguration : IEntityTypeConfiguration<Domain.SolicitacaoCompraAggregate.Item>
    {
        public void Configure(EntityTypeBuilder<Domain.SolicitacaoCompraAggregate.Item> builder)
        {
            builder.ToTable("Item");
            builder.HasMany(c => c.Produtos).WithOne(b => b.Item);
        }
    }
}
