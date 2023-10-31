using ComprarJogo.Data;
using ComprarJogo.Models;
using ComprarJogo.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace ComprarJogo.Repository
{
    public class ClienteDAO : DAO<Cliente>
    {
        private readonly CompraDbContext dbContext;
        public ClienteDAO(CompraDbContext compraDbContext)
        {
            dbContext = compraDbContext;

        }

        public Cliente BuscarPorId(int IdCliente)
        {

            Cliente? clientePorId = dbContext.Clientes.FirstOrDefault(x => x.IdCliente == IdCliente);

            return clientePorId ?? throw new Exception($"Cliente para o id: {IdCliente} não foi encontrado!");
        }

        public List<Cliente> BuscarTodos()
        {
            return dbContext.Clientes.AsNoTracking().ToList();
        }
        public Cliente Adicionar(Cliente cliente)
        {
            dbContext.Clientes.Add(cliente);
            dbContext.SaveChanges();

            return cliente;
        }

        public bool Apagar(int id)
        {
            Cliente clientePorId = BuscarPorId(id) ?? throw new Exception($"Cliente para o email: {id} não foi encontrado!");

            dbContext.Clientes.Remove(clientePorId);
            dbContext.SaveChanges();

            return true;
        }

        public Cliente Atualizar(Cliente cliente, int id)
        {

            Cliente clientePorId = BuscarPorId(id) ?? throw new Exception($"Cliente para o id: {id} não foi encontrado!");
            clientePorId.Nome = cliente.Nome;
            clientePorId.CPF = cliente.CPF;
            clientePorId.DataNascimento = cliente.DataNascimento;
            clientePorId.Senha = cliente.Senha;
            dbContext.Clientes.Update(clientePorId);
            dbContext.SaveChanges();

            return clientePorId;

        }
    }


        public static class MetodosExtensaoCliente
        {
            public static bool Logar(this DAO<Cliente> dao, string email, string senha, CompraDbContext dbContext)
            {
                Cliente clientePorId = BuscarPorEmail(dao, email, dbContext) ?? throw new Exception($"Cliente para o email: {email} não foi encontrado!");
                if (clientePorId.Email == email && clientePorId.Senha == senha)
                {
                    return true;
                }

                return false;
            }

            public static Cliente BuscarPorEmail(this DAO<Cliente> dao, string email, CompraDbContext dbContext)
            {
                Cliente? clientePorEmail = dbContext.Clientes.FirstOrDefault(x => x.Email == email);

                return clientePorEmail ?? throw new Exception($"Cliente para o email: {email} não foi encontrado!");
            }

        }

        
    
}
