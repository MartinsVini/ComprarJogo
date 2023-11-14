﻿using ComprarJogo.Data;
using ComprarJogo.Models;
using ComprarJogo.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace ComprarJogo.Repository
{
    public class CompraDAO : DAO<Compra> 
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
            return dbContext.Compras.AsNoTracking().ToList();
        }

        public Compra Adicionar(Compra compra)
        {

            Compra compraCriada = new(compra.IdJogo,compra.IdCliente, compra.CpfCliente);

            dbContext.Compras.Add(compraCriada);
            dbContext.SaveChanges();

            return compraCriada;
        }


        public Compra Atualizar(Compra compra, int id)
        {

            Compra compraPorId = BuscarPorId(id) ?? throw new Exception($"Compra para o ID: {id} não foi encontrado!");
            //jogoPorId.Nome = jogo.Nome;
            //jogoPorId.Valor = jogo.Valor;
            //jogoPorId.Tipos = jogo.Tipos;
            //jogoPorId.Descrição = jogo.Descrição;

            dbContext.Compras.Update(compraPorId);
            dbContext.SaveChanges();

            return compraPorId;

        }
        public bool Apagar(int id)
        {
            Compra compraPorId = BuscarPorId(id) ?? throw new Exception($"compra para o ID: {id} não foi encontrado!");

            dbContext.Compras.Remove(compraPorId);
            dbContext.SaveChanges();

            return true;
        }

       
    }
    public static class MetodosDeExtensaoCompra
    {
        private static readonly DAO<Compra>? CompraDAO;

        public static string AtualizarPreco(this DAO<Compra> dao,int idCompra, string cupom, CompraDbContext dbContext)
        {
            double? descontoCupom = 0;
            Compra? compraPorId = CompraDAO.BuscarPorId(idCompra);

            if (cupom == "playstic10")
            {
                descontoCupom = compraPorId.Valor * (10 / 100);
                descontoCupom -= compraPorId.Valor;

                compraPorId.Valor = descontoCupom;
                dbContext.Compras.Update(compraPorId);
                dbContext.SaveChanges();

                return "Preço Atualizado Com Sucesso";
            }
            
            return "Cupom Inválido";
        }

        public static Compra IniciarCompra(this DAO<Compra>dao, int idJogo, int idCliente,string cpfCliente, CompraDbContext dbContext)
        {
            Compra compra = new(idJogo, idCliente,cpfCliente);
            
            


            return compra;
        }


    }

}