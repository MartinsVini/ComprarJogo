using ComprarJogo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComprarJogo.Data.Maps
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {

            builder.Property(c => c.IdCliente).UseIdentityColumn();
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(250);
            builder.Property(c => c.Email).IsRequired().HasMaxLength(250);
            builder.Property(c => c.Senha).IsRequired().HasMaxLength(250);
            builder.Property(c => c.DataNascimento).HasColumnType("date");
            builder.HasOne(c => c.Compra).WithOne(c => c.Cliente).HasForeignKey<Compra>(c => new {c.IdCliente, c.CpfCliente});





        }
    }
}
