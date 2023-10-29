using ComprarJogo.Models;
using ComprarJogo.Repository;
using ComprarJogo.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ComprarJogo.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class JogoController : ControllerBase
    {
        private readonly DAO<Jogo> jogoDAO;

        public JogoController(DAO<Jogo> jogoDAO) 
        {
            this.jogoDAO = jogoDAO;
        }

        [HttpPost("/AdicionarJogo")]
        public ActionResult<Jogo> AdicionarJogo([FromBody] Jogo jogo)
        {
            Jogo jogoAdicionado = jogoDAO.Adicionar(jogo);
            return Ok(jogoAdicionado);
        }

    }
}
