using System.ComponentModel.DataAnnotations;

namespace ComprarJogo.Models
{
    public class Jogo
    {
        private int _IdJogo;
        private string? _Nome;
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        private DateTime? _DataLançamento;
        private string? _Genero;
        private int _ClassificaoIndicativa;
        private double _Preço;
        private string? _Descricao;

        
    }
}
