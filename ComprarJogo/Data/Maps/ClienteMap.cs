using ComprarJogo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace ComprarJogo.Data.Maps
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.IdCliente);
            builder.Property(c => c.IdCliente).UseIdentityColumn();
            builder.Property(c => c.CPF).IsRequired();
            builder.HasIndex(c => c.CPF).IsUnique();
            builder.Property(c => c.Nome).IsRequired();
            builder.Property(c => c.Email).IsRequired();
            builder.HasIndex(c=> c.Email).IsUnique();
            builder.Property(c => c.Senha).IsRequired();
            builder.Property(c => c.DataNascimento).HasColumnType("date").IsRequired();

            /*builder.OwnsOne(c => c.BibliotecaJogos, bc =>
                {
                    bc.Property(bc => bc.IdBiblioteca).UseIdentityColumn();
                    bc.HasKey(bc => bc.IdBiblioteca);
                    bc.HasOne(bc => bc.).WithMany().HasForeignKey(bc => bc.IdJogos);
                });
            */

        }
    }
}
