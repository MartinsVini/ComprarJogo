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

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        private DateTime? _DataCompra;

        public DateTime? DataCompra
        {
            get { return _DataCompra; } 
            set { _DataCompra = value; }
        }

        private double? _Valor;

        public double? Valor
        {
            get { return _Valor; }
            set { _Valor = value; }
        }
        public virtual Cliente? Cliente { get => Cliente; set => Cliente = value; }
        public virtual Jogo? Jogo { get => Jogo; set => Jogo = value; }

        
    }
}
