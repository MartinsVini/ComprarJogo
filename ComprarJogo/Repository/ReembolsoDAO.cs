using ComprarJogo.Data;
using ComprarJogo.Models;
using ComprarJogo.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ComprarJogo.Repository
{
    public class ReembolsoDAO : IReembolsoDAO
    { 
        private readonly CompraDbContext dbContext;
         ReembolsoDAO(CompraDbContext _dbContext) 
         {
            this.dbContext = _dbContext;
         }
        public Reembolso Adicionar(Reembolso reemboolso)
        {
           dbContext.Reembolsos.Add(reemboolso);
           dbContext.SaveChanges();

            return reemboolso;
        }

        public Reembolso BuscarPorId(int idReembolso)
        {
            Reembolso? reembolsoPorId = dbContext.Reembolsos.FirstOrDefault(x => x.IdReembolso == idReembolso);

            return reembolsoPorId ?? throw new Exception($"Cliente para o id: {idReembolso} não foi encontrado!");
        }

        public List<Reembolso> BuscarTodos()
        {
            return dbContext.Reembolsos.AsNoTracking().ToList();
        }
    }
}
