namespace ComprarJogo.Models
{
    public class Pagamento
    {
        private int _IdPagamento;

        public int IdPagamento
        {
            get { return _IdPagamento; }
            set { _IdPagamento = value;}
        }

        private double _TotalPagamento;

        public double TotalPagamento
        {
            get { return _TotalPagamento;}
            set { _TotalPagamento = value;}
        }

        private string? _Cupom;

        public string? Cupom
        {
            get { return _Cupom; }
            set { _Cupom = value;}
        }


        public virtual Compra? Compra { get; set; }

        public Pagamento(double totalPagamento, string cupom) 
        {
            TotalPagamento = totalPagamento;
            Cupom = cupom;
        }

        public Pagamento(double totalPagamento)
        {
            TotalPagamento = totalPagamento;
        }

    }
}
