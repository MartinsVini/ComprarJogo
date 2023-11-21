using ComprarJogo.Data;
using ComprarJogo.Models;
using ComprarJogo.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;


namespace ComprarJogo.Repository
{
    public class ClienteDAO : IClienteDAO
    {
        private readonly CompraDbContext dbContext;
        public ClienteDAO(CompraDbContext _dbContext) 
        {
            dbContext = _dbContext;
        }

        public Cliente Adicionar(Cliente cliente)
        {
            dbContext.Clientes.Add(cliente);
            dbContext.SaveChanges();

            return cliente;
        }

        public List<Cliente> BuscarTodos()
        {
            return dbContext.Clientes.Include(c => c.Compras).ToList();
        }

        public Cliente BuscarPorId(int idCliente)
        {
            Cliente? clientePorId = dbContext.Clientes.FirstOrDefault(x => x.IdCliente == idCliente);

            return clientePorId ?? throw new Exception($"Cliente para o id: {idCliente} não foi encontrado!");
        }

        public Cliente BuscarPorEmail(string email)
        {
            Cliente? clientePorEmail = dbContext.Clientes.FirstOrDefault(x => x.Email == email);
            return clientePorEmail ?? throw new Exception($"Cliente para o email: {email} não foi encontrado!");
        }

    }     
    
}
