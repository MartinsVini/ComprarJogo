using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.EntityFrameworkCore;

namespace ComprarJogo.Models
{ 
    public class BibliotecaCliente
    {
        private int _IdBiblioteca;
        public int IdBiblioteca
        {
            get { return _IdBiblioteca;}
            set { _IdBiblioteca = value;}
        }

        private int _IdCliente;
        public int IdCliente
        {
            get { return _IdCliente;} 
            set { _IdCliente = value; }
        }

        private List<int>? _IdJogos;

        public List<int>? IdJogos 
        {
            get { return _IdJogos;}
            set { _IdJogos = value;}
        }

        //public virtual Cliente Cliente { get; set; }
        //public virtual List<Jogo>? Jogos { get; set; }

 
    
    }
}
