using ComprarJogo;
using Microsoft.EntityFrameworkCore;

namespace ComprarJogo
{
    public class CompraDbContext : DbContext
    {
        public CompraDbContext(DbContextOptions<CompraDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        

        //Mapeando Atributos de Cliente
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.GetId());    

            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.getCPF());

            modelBuilder.Entity<Cliente>()
                .Property(c => c.getNome()).IsRequired().HasMaxLength(250);

            modelBuilder.Entity<Cliente>()
                .Property(c => c.CPF).IsRequired().HasMaxLength(250);

            modelBuilder.Entity<Cliente>()
                .Property(c => c.Senha).IsRequired().HasMaxLength(250);

            modelBuilder.Entity<Cliente>()
                .Property(c => c.DataNascimento).IsRequired().HasMaxLength(250);

            base.OnModelCreating(modelBuilder);
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source = localhost; Persist Security Info = True; User ID = padrao; Password = 123456;TrustServerCertificate=True;");

        }

    }
}
