using ComprarJogo.Models;

namespace ComprarJogo.Repository.Interfaces
{
    public interface IPagamentoDAO
    {
        Pagamento Adicionar(Pagamento t);
        Pagamento BuscarPorId(int id);
        
    }
}
