using ComprarJogo.Data;
using ComprarJogo.Models;
using ComprarJogo.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ComprarJogo.Repository
{
    public class JogoDAO : IJogoDAO
    {


        private readonly CompraDbContext dbContext;
        public JogoDAO(CompraDbContext compraDbContext)
        {
            dbContext = compraDbContext;

        }

        public Jogo BuscarPorId(int id)
        {

            Jogo? jogoPorId = dbContext.Jogos.AsNoTracking().FirstOrDefault(x => x.IdJogo == id);

            return jogoPorId ?? throw new Exception($"jogo para o ID: {id} não foi encontrado!");
        }

        public List<Jogo> BuscarTodos()
        {
            return dbContext.Jogos.AsNoTracking().ToList();
        }

        public Jogo Adicionar(Jogo jogo)
        {
            dbContext.Jogos.Add(jogo);
            dbContext.SaveChanges();

            return jogo;
        }

        public List<Jogo> BuscarJogosPorFiltros(string? nome, string? filtro1, string? filtro2, string? filtro3, string? filtro4)
        {
            IQueryable<Jogo>? query = dbContext.Jogos.AsNoTracking();

            if (nome != null)
            {
                query = dbContext.Jogos.OrderByDescending(x => x.Nome.Contains(nome));
            }

            if (filtro1 != null)
            {
                query = dbContext.Jogos.OrderByDescending(x => x.Genero.Contains(filtro1));
            }

            if (filtro2 != null)
            {
                query.Concat(dbContext.Jogos.OrderByDescending(x => x.Genero.Contains(filtro2)));
                //query.Concat(dbContext.Jogos.Where(x => x.Genero == filtro2).AsNoTracking());
            }

            if (filtro3 != null)
            {
                query = dbContext.Jogos.AsNoTracking();
                query.Concat(dbContext.Jogos.Where(x => x.Genero == filtro3).AsNoTracking());
            }

            if (filtro4 != null)
            {
                query = dbContext.Jogos.AsNoTracking();
                query.Concat(dbContext.Jogos.Where(x => x.Genero == filtro4).AsNoTracking());
            }

            List<Jogo> jogosPorFiltro = query.ToList();

            return jogosPorFiltro;


        }




    }

   
}
