using ComprarJogo.Models;
using Microsoft.EntityFrameworkCore;

namespace ComprarJogo.Repository.Interfaces
{
    public interface ICompraDAO
    {
        Compra BuscarPorId(int id);

        List<Compra> BuscarTodos();

        Compra Adicionar(Compra compra);
        

    }
}
