using ComprarJogo.Repository;
using System.ComponentModel.DataAnnotations;

namespace ComprarJogo.Models
{
    public class Compra
    {
       
        private int _IdCompra;

        public int IdCompra
        {
            get { return _IdCompra; } 
            set {  _IdCompra = value; }
        }

        private int _IdJogo;

        public int IdJogo
        {
            get { return _IdJogo; }
            set { _IdJogo = value; }
        }
        
        private int _IdCliente;

        public int IdCliente
        {
            get {return _IdCliente; }
            set { _IdCliente = value; }
        }

        private int _IdPagamento;

        public int IdPagamento
        {
            get { return _IdPagamento; }
            set { _IdPagamento = value; }
        }

        private string? _CpfCliente;

        public string? CpfCliente
        {
            get { return _CpfCliente; }
            set { _CpfCliente = value; }
        }
      
        private string? _DataCompra;

        public string ? DataCompra
        {
            get { return _DataCompra; } 
            set { _DataCompra = value; }
        }

 


        public virtual Pagamento? Pagamento { get; set; }
        public virtual Cliente? Cliente { get; set; }
        public virtual Jogo? Jogo { get; set; }

        public Compra(int idJogo, int idCliente, string cpfCliente)
        {

            this.IdJogo = idJogo;
            this.IdCliente = idCliente;
            this.CpfCliente = cpfCliente;
            this.DataCompra = DateTime.Now.ToString();
        }
    }
}
