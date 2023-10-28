using ComprarJogo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComprarJogo.Data.Maps
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(new string  []{"IdCliente","CPF"}); 
            builder.Property(c => c.GetType().GetProperty("Nome")).IsRequired().HasMaxLength(250);
            builder.Property(c => c.GetSenha()).IsRequired().HasMaxLength(250);
            builder.Property(c => c.getEmail()).IsRequired().HasMaxLength(250);
            builder.Property(c => c.getDataNascimento()).IsRequired().HasMaxLength(250);





        }
    }
}
