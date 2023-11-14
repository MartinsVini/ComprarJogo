using ComprarJogo.Data;
using ComprarJogo.Models;
using ComprarJogo.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ComprarJogo.Repository
{
    public class JogoDAO : DAO<Jogo>
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



        public Jogo Atualizar(Jogo jogo, int id)
        {

            Jogo jogoPorId = BuscarPorId(id) ?? throw new Exception($"Jogo para o ID: {id} não foi encontrado!");
            //jogoPorId.Nome = jogo.Nome;
            //jogoPorId.Valor = jogo.Valor;
            //jogoPorId.Tipos = jogo.Tipos;
            //jogoPorId.Descrição = jogo.Descrição;

            dbContext.Jogos.Update(jogoPorId);
            dbContext.SaveChanges();

            return jogoPorId;

        }
        public bool Apagar(int id)
        {
            Jogo jogoPorId = BuscarPorId(id) ?? throw new Exception($"Jogo para o ID: {id} não foi encontrado!");

            dbContext.Jogos.Remove(jogoPorId);
            dbContext.SaveChanges();

            return true;
        }


    }

    public static class MetodosExtensaoJogo 
    {
        public static List<Jogo> BuscarJogosPorFiltros(this DAO<Jogo> dao, string? nome,string? filtro1,string? filtro2, string? filtro3, string? filtro4, CompraDbContext dbContext)
        {
            IQueryable<Jogo>? query = dbContext.Jogos.AsNoTracking();
            
            if (nome != null)
            {
                query = dbContext.Jogos.OrderByDescending(x => x.Nome.Contains(nome));
            }

            if(filtro1 != null)
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
