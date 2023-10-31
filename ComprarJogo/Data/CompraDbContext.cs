using ComprarJogo.Data.Maps;
using ComprarJogo.Models;
using Microsoft.EntityFrameworkCore;

namespace ComprarJogo.Data
{
    public class CompraDbContext : DbContext
    {
        public CompraDbContext(DbContextOptions<CompraDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Compra> Compras { get; set; }

        public DbSet<Pagamento> Pagamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasKey(c => new { c.IdCliente, c.CPF });
            modelBuilder.Entity<Cliente>().HasIndex(c => c.Email).IsUnique();
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new JogoMap());
            modelBuilder.ApplyConfiguration(new CompraMap());
            modelBuilder.ApplyConfiguration(new PagamentoMap());
            
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source = localhost; Persist Security Info = True; User ID = padrao; Password = 123456;TrustServerCertificate=True;");

        }

    }
}
