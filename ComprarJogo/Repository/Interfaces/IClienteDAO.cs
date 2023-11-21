using ComprarJogo.Models;

namespace ComprarJogo.Repository.Interfaces
{
    public interface IClienteDAO
    {

        List<Cliente> BuscarTodos();
        Cliente BuscarPorId(int id);
        Cliente Adicionar(Cliente cliente);
        Cliente BuscarPorEmail(string email);


    }
}