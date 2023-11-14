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
            builder.Property(c => c.IdCliente);
            builder.Property(c => c.CpfCliente);
            builder.Property(c => c.IdPagamento);
            builder.Property(c => c.DataCompra).HasColumnType("date");
            builder.Property(c => c.Cupom);
            builder.Property(c => c.Valor);
            

            
            builder.HasOne(c => c.Jogo).WithOne(x => x.Compra);
            builder.HasOne(c => c.Cliente).WithOne(x => x.Compra);
            builder.HasOne(c => c.Pagamento).WithOne(x => x.Compra);


        }
    }


}
