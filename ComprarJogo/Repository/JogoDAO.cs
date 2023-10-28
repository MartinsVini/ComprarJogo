using ComprarJogo.Data;
using ComprarJogo.Models;
using ComprarJogo.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace ComprarJogo.Repository
{
    public class JogoDAO : DAO<Jogo>
    {


        private readonly CompraDbContext dbContext;
        public JogoDAO(CompraDbContext compraDbContext)
        {
            dbContext = compraDbContext;

        }

        [HttpGet]
        public Jogo BuscarPorId(int id)
        {

            Jogo? jogoPorId = dbContext.Jogos.AsNoTracking().FirstOrDefault(x => x.GetIdJogo() == id);

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
            jogoPorId.SetNome() = jogo.GetNome;
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

    public static class MetodosExtensao 
    {
        public static List<Jogo> BuscarJogosPorGenero(this DAO<Jogo> dao, string filtro, CompraDbContext dbContext)
        {
            //Implementar metodo com o context
            List<Jogo> jogosPorGenero = dbContext.Jogos.Where(x => x.GetGenero() == filtro).AsNoTracking().ToList();

            return jogosPorGenero;


        }
    }
}
