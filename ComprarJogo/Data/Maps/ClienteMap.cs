using ComprarJogo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComprarJogo.Data.Maps
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.IdCliente);
            builder.Property(c => c.IdCliente).UseIdentityColumn();
            builder.HasKey(c => c.CPF);
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(250);
            builder.Property(c => c.Email).IsRequired().HasMaxLength(250);
            builder.Property(c => c.Senha).IsRequired().HasMaxLength(250);
            builder.Property(c => c.DataNascimento).IsRequired().HasMaxLength(250);





        }
    }
}
