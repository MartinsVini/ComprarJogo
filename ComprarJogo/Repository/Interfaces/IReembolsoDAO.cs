using ComprarJogo.Models;
using Microsoft.EntityFrameworkCore;

namespace ComprarJogo.Repository.Interfaces
{
    public interface IReembolsoDAO
    {
        public Reembolso Adicionar(Reembolso reemboolso);

        public Reembolso BuscarPorId(int idReembolso);

        public List<Reembolso> BuscarTodos();
        
    }
}
