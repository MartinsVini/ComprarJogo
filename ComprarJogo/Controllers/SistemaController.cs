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
        public ActionResult<List<Jogo>> ExibirJogo(string? nome ,string? filtro1, string? filtro2, string? filtro3, string? filtro4) 
        {
            List<Jogo> jogos = jogoDAO.BuscarJogosPorFiltros(nome,filtro1,filtro2,filtro3,filtro4,dbContext);

            return Ok(jogos);
        }

        [HttpGet("/IniciarCompra")]
        public ActionResult<Compra> IniciarCompra(int idJogo, int idCliente,string cpfCliente)
        {
            Compra compraIniciada = compraDAO.IniciarCompra(idJogo, idCliente,cpfCliente,dbContext);



            return Ok(compraIniciada);
        }


        [HttpPost("/RegistrarCompra")]
        public ActionResult<Compra> RegistrarCompra(Compra compra)
        {
            Compra compraIniciada = compraDAO.Adicionar(compra);

            return Ok(compraIniciada);
        }

        [HttpPut("/AtualizarPrecoCompra")]
        public ActionResult<Compra> AtualizarPrecoCompra(int idCompra, string cupom)
        {
            
            string cupomAutenticado = compraDAO.AtualizarPreco(idCompra,cupom,dbContext);

            return Ok(cupomAutenticado);
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
