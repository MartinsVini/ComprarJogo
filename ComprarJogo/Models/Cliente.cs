using System.ComponentModel.DataAnnotations;

namespace ComprarJogo.Models
{
    public class Cliente
    {
        //Formas de Encapsulamento em C#
        //public int IdCliente { get => idCliente; set => idCliente = value;}
       
        private string? _nome;

        public string? Nome
        {
            get { return _nome; }
            set { _nome = value; }
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

        public string?   CPF
        {
            get { return _CPF; }
            set { _CPF = value; }
        }

        private DateTime? _DataNascimento;

        public DateTime? DataNascimento
        {
            get { return _DataNascimento;}
            set { _DataNascimento = value;}
        }

        private int _IdCliente;

        public int IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }

        private Compra? _Compra;

        public virtual Compra? Compra
        {
            get { return _Compra; }
            set { _Compra = value; }   
        }


        //private List<Jogo>? JogosPossuidos;


    }
}
