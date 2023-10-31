using ComprarJogo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComprarJogo.Data.Maps
{
    public class PagamentoMap : IEntityTypeConfiguration<Pagamento>
    {
        
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.HasKey(c => c.IdPagamento);
            builder.Property(c => c.IdPagamento).UseIdentityColumn();
            builder.Property(c => c.TotalPagamento);
            builder.Property(c => c.Cupom);
            builder.HasOne(c => c.Compra).WithOne(c => c.Pagamento).HasForeignKey<Compra>(c => c.IdPagamento);

        }
    }
}
