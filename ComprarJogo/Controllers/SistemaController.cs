using ComprarJogo.Data;
using ComprarJogo.Models;
using ComprarJogo.Repository;
using ComprarJogo.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ComprarJogo.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SistemaController : ControllerBase
    {

        private readonly DAO<Jogo> jogoDAO;
        private readonly DAO<Compra> compraDAO;
        private readonly CompraDbContext dbContext;

        public SistemaController(DAO<Jogo> jogoDAO,DAO<Compra> compraDAO, CompraDbContext dbContext) 
        {
            this.jogoDAO = jogoDAO;
            this.compraDAO = compraDAO;
            this.dbContext = dbContext; 
        }

        [HttpGet("/ExibirCatologo")]
        public ActionResult<List<Jogo>> ExibirCatologoDeJogos() 
        { 
            List<Jogo> jogos = jogoDAO.BuscarTodos();
            return Ok(jogos);
        }

        [HttpGet("/ExibirCompras")]
        public ActionResult<List<Compra>> ExibirCompras()
        {
            List<Compra> compras = compraDAO.BuscarTodos();
            return Ok(compras);
        }

        [HttpGet("/ExibirJogo")]
        public ActionResult<List<Jogo>> ExibirJogo(string filtro) 
        {
            List<Jogo> jogos = jogoDAO.BuscarJogosPorGenero(filtro,dbContext);

            return Ok(jogos);
        }

        [HttpPost("/IniciarCompra")]
        public ActionResult<Compra> IniciarCompra([FromBody]Compra compra)
        {
            Compra compraIniciada = compraDAO.Adicionar(compra);

            return Ok(compraIniciada);
        }

        [HttpPut("/AtualizarPrecoCompra")]
        public ActionResult<Compra> AtualizarPrecoCompra([FromBody]Compra compra, int IdCompra)
        {
            compra.IdCompra = IdCompra;
            //Compra compraAtt = compraDAO.AtualizarPreco(compra, IdCompra);
            return Ok();
        }

        [HttpGet("ExibirFormaPagamento")]
        public ActionResult<Pagamento> ExibirFormaPagamento() 
        {

            return Ok();
        }

        [HttpGet("RealizarPagamento")]
        public ActionResult<Pagamento> RealizarPagamento()
        {

            return Ok();
        }


    }

    
}
