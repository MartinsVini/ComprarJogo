using ComprarJogo.Repository;
using ComprarJogo.Repository.Interfaces;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;


namespace ComprarJogo.Models
{
    public class Cliente
    {
        private int _IdCliente;

        public int IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }

        private string? _Nome;

        public string? Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private string? _Senha;

        public string? Senha
        {
            get { return _Senha; }
            set { _Senha = value; }
        }

        private string? _Email;

        public string? Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private string? _CPF;

        public string? CPF
        {
            get { return _CPF; }
            set { _CPF = value; }
        }

        private DateTime? _DataNascimento;
        
        public DateTime? DataNascimento
        {
            get { return _DataNascimento; }
            set { _DataNascimento = value; }
        }

        public virtual List<Compra>? Compras { get; set; }
        //public virtual BibliotecaCliente BibliotecaJogos { get; set; } = new BibliotecaCliente();

        

        
    }
}
