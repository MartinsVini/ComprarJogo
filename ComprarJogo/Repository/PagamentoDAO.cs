using ComprarJogo.Data;
using ComprarJogo.Models;
using ComprarJogo.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ComprarJogo.Repository
{
    public class PagamentoDAO : IPagamentoDAO
    {
        private readonly CompraDbContext dbContext;

        public PagamentoDAO(CompraDbContext _dbContext) 
        {
            dbContext = _dbContext;
        }

        public Pagamento Adicionar(Pagamento pagamento)
        {
            dbContext.Pagamentos.Add(pagamento);
            dbContext.SaveChanges();

            return pagamento;
        }

        public Pagamento BuscarPorId(int idPagamento)
        {
            Pagamento? pagamentoPorId = dbContext.Pagamentos.AsNoTracking().FirstOrDefault(x => x.IdPagamento == idPagamento);

            return pagamentoPorId ?? throw new Exception($"pagamento para o ID: {idPagamento} não foi encontrado!");
        }

        public List<Pagamento> BuscarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
