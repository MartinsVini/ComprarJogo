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
            set { _IdCompra = value; }
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
            get { return _IdCliente; }
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

        private DateTime? _DataCompra;

        public DateTime? DataCompra
        {
            get { return _DataCompra; }
            set { _DataCompra = value; }
        }

        private string? _Cupom;

        public string? Cupom
        {
            get { return _Cupom; }
            set { _Cupom = value; }
        }

        private double? _Valor;

        public double? Valor
        {
            get { return _Valor; }
            set { _Valor = value; }
        }



        public virtual Pagamento? Pagamento { get; set; }
        public virtual Cliente? Cliente { get; set; }
        public virtual Jogo? Jogo { get; set; }

        public Compra(int idJogo, int idCliente, string cpfCliente)
        {

            this.IdJogo = idJogo;
            this.IdCliente = idCliente;
            this.CpfCliente = cpfCliente;
            this.DataCompra = DateTime.Now;
        }
    }
}
