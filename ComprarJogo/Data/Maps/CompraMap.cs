using ComprarJogo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComprarJogo.Data.Maps
{
    public class CompraMap : IEntityTypeConfiguration<Compra>
    {
        public void Configure(EntityTypeBuilder<Compra> builder)
        {
            builder.HasKey(c => c.GetIdCompra());
            builder.Property(c => c.GetIdCompra()).UseIdentityColumn();
            builder.Property(c => c.GetDataCompra()).IsRequired();
            builder.Property(c => c.GetValor()).IsRequired();
        }
    }
}
