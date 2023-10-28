using ComprarJogo.Data;
using ComprarJogo.Models;
using ComprarJogo.Repository;
using ComprarJogo.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ComprarJogo.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CompraController : ControllerBase
    {

        private readonly DAO<Jogo> jogoDAO;
        private readonly CompraDbContext dbContext;

        public CompraController(DAO<Jogo> jogoDAO,CompraDbContext dbContext) 
        {
            this.jogoDAO = jogoDAO;
            this.dbContext = dbContext; 
        }

        [HttpGet]
        public ActionResult<List<Jogo>> ExibirCatologoDeJogos() 
        { 
            return jogoDAO.BuscarTodos();   
        }

        [HttpGet]
        public List<Jogo> ExibirJogo(string filtro) 
        {
            List<Jogo> jogos = jogoDAO.BuscarJogosPorGenero(filtro,dbContext);

            return jogos;
        }

        [HttpPost]
        public Compra IniciarCompra(int idJogo, int idCliente)
        {


            return null;
        }


    }

    
}
