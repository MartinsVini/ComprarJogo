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
            builder.Property(c => c.DataCompra).HasColumnType("date");
            builder.Property(c => c.StatusCompra).IsRequired();
            builder.Property(c => c.Cupom);
            builder.Property(c => c.Valor).IsRequired();
            

            
            builder.HasOne(c => c.Jogo).WithMany(x => x.Compras).HasForeignKey(c => c.IdJogo);
            builder.HasOne(c => c.Pagamento).WithOne(x => x.Compra).HasForeignKey<Compra>(c => c.IdPagamento);
            builder.HasOne(c => c.Reemboolso).WithOne(x => x.Compra).HasForeignKey<Compra>(c => c.IdReembolso).IsRequired(false);
            builder.HasOne(c => c.Cliente).WithMany(x => x.Compras).HasForeignKey(c => c.IdCliente);
            


        }
    }


}
