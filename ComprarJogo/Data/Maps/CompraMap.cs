using ComprarJogo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComprarJogo.Data.Maps
{
    public class CompraMap : IEntityTypeConfiguration<Compra>
    {
        public void Configure(EntityTypeBuilder<Compra> builder)
        {
            builder.HasKey(c => c.IdCompra);
            builder.Property(c => c.IdCompra).UseIdentityColumn();
            builder.Property(c => c.DataCompra).IsRequired();
            builder.Property(c => c.Valor).IsRequired();
        }
    }
}
