using System.ComponentModel.DataAnnotations;

namespace ComprarJogo.Models
{
    public class Jogo
    {
        private int _IdJogo;

        public int IdJogo
        {
            get { return _IdJogo; }
            set { _IdJogo = value; }
        }

        private string? _Nome;

        public string? Nome
        {
            get { return _Nome; }
            set { _Nome = value; } 
        }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        private DateTime? _DataLançamento;

        public DateTime? DataLançamento
        {
            get { return _DataLançamento; }
            set { _DataLançamento = value; }
        }

        private string? _Genero;

        public string? Genero
        {
            get { return _Genero; }
            set { _Genero = value; }
        }

        private int _ClassificaoIndicativa;

        public int ClassificaoIndicativa
        {
            get { return _ClassificaoIndicativa; }
            set { _ClassificaoIndicativa = value; }
        }
        private double _Preço;

        public double Preço
        {
            get { return _Preço; }
            set { _Preço = value; }
        }
        private string? _Descricao;

        public string? Descricao
        {
            get { return _Descricao; }
            set { _Descricao = value; }
        }

        
    }
}
