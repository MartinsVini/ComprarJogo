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
            builder.Property(c => c.Genero).IsRequired();
            builder.Property(c => c.ClassificaoIndicativa).IsRequired();
            builder.Property(c => c.Preço).IsRequired();
            builder.Property(c => c.Descricao).IsRequired();

            //builder.Property<Cliente>().WithOwner()
            //bc.HasOne(bc => bc.).WithMany().HasForeignKey(bc => bc.IdJogos);
            //builder.HasMany(c => c.).WithMany(x => x.Jogos).UsingEntity(j => j.ToTable("BibliotecaJogos"));
            //builder.HasOne(c => c.Compra).WithOne(c => c.Jogo).HasForeignKey<Compra>(c => c.IdJogo);





        }

        
    }
}
