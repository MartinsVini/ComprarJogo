using ComprarJogo.Models;
using ComprarJogo.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ComprarJogo.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class JogoController : ControllerBase
    {
        private readonly IJogoDAO jogoDAO;

        public JogoController(IJogoDAO jogoDAO) 
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
