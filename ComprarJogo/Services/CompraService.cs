using ComprarJogo.Data;
using ComprarJogo.Data.Maps;
using ComprarJogo.Models;
using ComprarJogo.Repository;
using ComprarJogo.Repository.Interfaces;

namespace ComprarJogo.Services
{
    public class CompraService
    {
        private readonly ICompraDAO compraDAO;
        private readonly IJogoDAO jogoDAO;
        private readonly IPagamentoDAO pagamentoDAO;
        private readonly CompraDbContext dbContext;

        public CompraService(ICompraDAO compraDAO, IPagamentoDAO pagamentoDAO , IJogoDAO jogoDAO,CompraDbContext _dbContext)
        {
            this.compraDAO = compraDAO;
            this.jogoDAO = jogoDAO;
            this.pagamentoDAO = pagamentoDAO;
            this.dbContext = _dbContext;
        }

        public string AtualizarPreco(int idCompra, string cupom)
        {
            double? descontoCupom;
            Compra? compraPorId = compraDAO.BuscarPorId(idCompra);
            Pagamento? pagamentoPorId = pagamentoDAO.BuscarPorId(compraPorId.IdPagamento);

            if (cupom == "playstic10")
            {
                descontoCupom = compraPorId.Valor * 0.1;
                descontoCupom = compraPorId.Valor - descontoCupom;
                pagamentoPorId.TotalPagamento = descontoCupom;
                compraPorId.Valor = descontoCupom;
                compraPorId.Cupom = "playstic10";
                dbContext.Pagamentos.Update(pagamentoPorId);
                dbContext.Compras.Update(compraPorId);
                dbContext.SaveChanges();

                return "Preço Atualizado Com Sucesso";
            }

            return "Cupom Inválido";
        }

        public Compra IniciarCompra(int idJogo, int idCliente)
        {
            Jogo jogo = jogoDAO.BuscarPorId(idJogo);

            Pagamento pagamento = new Pagamento(jogo.Preço);
            Reembolso reembolso = new Reembolso();
            Compra compra = new(idJogo, idCliente, jogo.Preço, pagamento,reembolso);

            Compra compraIniciada = compraDAO.Adicionar(compra);
            return compraIniciada;
        }
    }
}
