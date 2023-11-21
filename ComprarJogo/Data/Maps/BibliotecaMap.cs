using ComprarJogo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComprarJogo.Data.Maps
{
    public class BibliotecaMap : IEntityTypeConfiguration<BibliotecaCliente>
    {
        public void Configure(EntityTypeBuilder<BibliotecaCliente> builder)
        {
            builder.HasKey(c => c.IdBiblioteca);
            builder.Property(c => c.IdBiblioteca).UseIdentityColumn();


           // builder.HasMany(c => c.Jogos).WithMany(x => x.BibliotecaClientes).UsingEntity(j => j.ToTable("BibliotecaJogos"));
            
      
        }
    }
}
