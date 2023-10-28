using ComprarJogo.Models;

namespace ComprarJogo.Repository.Interfaces
{
    public interface DAO<T>
    {
        T BuscarPorId(int id);
        List<T> BuscarTodos();
        T Adicionar(T t);
        T Atualizar(T t, int id);
        bool Apagar(int id);
        
    }
}
