﻿namespace ComprarJogo.Models
{
    public class Pagamento
    {
        private int _IdPagamento;

        public int IdPagamento
        {
            get { return _IdPagamento; }
            set { _IdPagamento = value;}
        }

        private double? _TotalPagamento;

        public double? TotalPagamento
        {
            get { return _TotalPagamento;}
            set { _TotalPagamento = value;}
        }

        private string? _StatusPagamento;

        public string? StatusPagamento
        {
            get { return _StatusPagamento;}
            set { _StatusPagamento = value;}
        }


        public virtual Compra? Compra { get; set; }

        public Pagamento()
        { }

        public Pagamento(double totalPagamento)
        {
            this.TotalPagamento = totalPagamento;
            this.StatusPagamento = "Pendente";
            
        }

    }
}
