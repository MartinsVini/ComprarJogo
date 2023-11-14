using ComprarJogo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComprarJogo.Data.Maps
{
    public class JogoMap : IEntityTypeConfiguration<Jogo>
    {
        public void Configure(EntityTypeBuilder<Jogo> builder)
        {
            builder.HasKey(c => c.IdJogo);
            builder.Property(c => c.IdJogo).UseIdentityColumn();
            builder.Property(c => c.Nome).IsRequired();
            builder.Property(c => c.DataLançamento).HasColumnType("date");
            builder.Property(c => c.Genero).IsRequired().HasMaxLength(250);
            builder.Property(c => c.ClassificaoIndicativa).IsRequired().HasMaxLength(250);
            builder.Property(c => c.Preço).IsRequired().HasMaxLength(250);
            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(250);
            builder.HasOne(c => c.Compra).WithOne(c => c.Jogo).HasForeignKey<Compra>(c => c.IdJogo);





        }

        
    }
}
