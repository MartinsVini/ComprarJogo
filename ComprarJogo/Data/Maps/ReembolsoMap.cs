using ComprarJogo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComprarJogo.Data.Maps
{
    public class ReembolsoMap : IEntityTypeConfiguration<Reembolso>
    {
        public void Configure(EntityTypeBuilder<Reembolso> builder)
        {
            builder.HasKey(c => c.IdReembolso);
            builder.Property(c => c.IdReembolso).UseIdentityColumn();
            builder.Property(c => c.Motivo).IsRequired(false);
            builder.Property(c => c.ChavePix).IsRequired(false);


        }   
    }
}
