using Microsoft.AspNetCore.Mvc;

namespace ComprarJogo.Controllers
{
    public class CompraController
    {
        [HttpGet]
        public List<Jogo> ExibirCatologoDeJogos() 
        { 
         return Loja.GetJogos();   
        }

        [HttpGet]
        public List<Jogo> ExibirJogo(string filtro) 
        {
            List<Jogo> jogos = BuscarJogoPorFiltro(filtro);

            return jogos;
        }

        public Compra IniciarCompra(Jogo jogo)
        {
            Compra compra = new Compra(jogo);

            return compra;
        }


    }

    
}
