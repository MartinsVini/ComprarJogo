using ComprarJogo.Data;
using ComprarJogo.Data.Maps;
using ComprarJogo.Models;
using ComprarJogo.Repository;
using ComprarJogo.Repository.Interfaces;
using ComprarJogo.Services;
using Microsoft.AspNetCore.Mvc;

namespace ComprarJogo.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SistemaController : ControllerBase
    {

        private readonly IJogoDAO jogoDAO;
        private readonly ICompraDAO compraDAO;
        private readonly CompraService compraService;
        private readonly IClienteDAO clienteDAO;
        private readonly CompraDbContext dbContext;
        

        public SistemaController(IJogoDAO jogoDAO, ICompraDAO compraDAO,CompraService compraService, IClienteDAO clienteDAO, CompraDbContext dbContext) 
        {
            this.jogoDAO = jogoDAO;
            this.compraDAO = compraDAO;
            this.compraService = compraService;
            this.dbContext = dbContext; 
            this.clienteDAO = clienteDAO;
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
            List<Jogo> jogos = jogoDAO.BuscarJogosPorFiltros(nome,filtro1,filtro2,filtro3,filtro4);

            return Ok(jogos);
        }

        [HttpGet("/IniciarCompra")]
        public ActionResult<Compra> IniciarCompra(int idJogo, int idCliente)
        {
            Compra compraIniciada = compraService.IniciarCompra(idJogo, idCliente);

            return Ok(compraIniciada);
        }

        [HttpPut("/AtualizarPrecoCompra")]
        public ActionResult<Compra> AtualizarPrecoCompra(int idCompra, string cupom)
        {

            string cupomAutenticado = compraService.AtualizarPreco(idCompra, cupom);

            return Ok(cupomAutenticado);
        }


        [HttpPost("/RegistrarCompra")]
        public ActionResult<Compra> RegistrarCompra(Compra compra)
        {
            Compra compraIniciada = compraDAO.Adicionar(compra);

            return Ok(compraIniciada);
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
