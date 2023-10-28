using ComprarJogo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComprarJogo.Data.Maps
{
    public class JogoMap : IEntityTypeConfiguration<Jogo>
    {
        public void Configure(EntityTypeBuilder<Jogo> builder)
        {
            builder.HasKey(c => c.GetIdJogo());
            builder.Property(c => c.GetIdJogo()).UseIdentityColumn();
            builder.Property(c => c.GetNome()).IsRequired();
            builder.Property(c => c.GetDataLançamento()).IsRequired().HasMaxLength(250);
            builder.Property(c => c.GetGenero()).IsRequired().HasMaxLength(250);
            builder.Property(c => c.GetClassificaoIndicativa()).IsRequired().HasMaxLength(250);
            builder.Property(c => c.GetPreço()).IsRequired().HasMaxLength(250);
            builder.Property(c => c.GetDescricao()).IsRequired().HasMaxLength(250);





        }

        
    }
}
