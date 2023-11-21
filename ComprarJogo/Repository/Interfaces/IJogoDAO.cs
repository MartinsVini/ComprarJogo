using ComprarJogo.Models;
using Microsoft.EntityFrameworkCore;

namespace ComprarJogo.Repository.Interfaces
{
    public interface IJogoDAO
    {
        Jogo BuscarPorId(int id);
        List<Jogo> BuscarTodos();
        Jogo Adicionar(Jogo jogo);
        List<Jogo> BuscarJogosPorFiltros(string? nome, string? filtro1, string? filtro2, string? filtro3, string? filtro4);


    }
}
