using ComprarJogo.Data;
using ComprarJogo.Models;
using ComprarJogo.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace ComprarJogo.Repository
{
    public class CompraDAO : ICompraDAO
    {


        private readonly CompraDbContext dbContext;
        public CompraDAO(CompraDbContext compraDbContext)
        {
            dbContext = compraDbContext;

        }

        public Compra BuscarPorId(int id)
        {

            Compra? compraPorId = dbContext.Compras.AsNoTracking().FirstOrDefault(x => x.IdCompra == id);

            return compraPorId ?? throw new Exception($"compra para o ID: {id} não foi encontrado!");
        }

        public List<Compra> BuscarTodos()
        {
            return dbContext.Compras.Include(c => c.Cliente).ToList();
        }

        public Compra Adicionar(Compra compra)
        {
            dbContext.Compras.Add(compra);
            dbContext.SaveChanges();

            return compra;
        }

    }
        
        

}