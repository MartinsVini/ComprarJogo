using ComprarJogo.Repository;
using Microsoft.AspNetCore.Server.IIS.Core;
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

        private int _IdReembolso;

        public int IdReembolso
        {
            get { return _IdReembolso; }
            set { _IdReembolso = value; }
        }

        private string? _StatusCompra;

        public string? StatusCompra
        {
            get { return _StatusCompra; }
            set { _StatusCompra = value; }
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

        private int _IdBiblioteca;

        public int IdBiblioteca
        {
            get { return _IdBiblioteca; }
            set { _IdBiblioteca = value; }
        }

        public virtual Pagamento? Pagamento { get; set; }
        public virtual Cliente? Cliente { get; set; }
        public virtual Jogo? Jogo { get; set; }
        public virtual Reembolso? Reemboolso { get; set; }

        public Compra() 
        { }

        public Compra(int idJogo, int idCliente, double valor, Pagamento pagamento, Reembolso reembolso)
        {
            this.IdJogo = idJogo;
            this.IdCliente = idCliente;
            this.Pagamento = pagamento;
            this.Reemboolso = reembolso;
            this.Valor = valor;
            this.DataCompra = DateTime.Now;
            this.StatusCompra = "Aguardando Pagamento";
            

        }
    }
}
