using ComprarJogo.Data;
using ComprarJogo.Models;
using ComprarJogo.Repository;
using ComprarJogo.Repository.Interfaces;

namespace ComprarJogo.Services
{
    public class ClienteService
    {
        private readonly CompraDbContext dbContext;
        private readonly IClienteDAO clienteDAO;

        public ClienteService(IClienteDAO clienteDAO, CompraDbContext _dbContext)
        {
            this.clienteDAO = clienteDAO;
            this.dbContext = _dbContext;
        }

        public bool Logar(string email, string senha)
        {
            Cliente clientePorId = clienteDAO.BuscarPorEmail(email) ?? throw new Exception($"Cliente para o email: {email} não foi encontrado!");
            if (clientePorId.Email == email && clientePorId.Senha == senha)
            {
                return true;
            }

            return false;
        }
    }
}
