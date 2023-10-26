namespace ComprarJogo
{
    public class Jogo
    {
        private int IdJogo;
        private string? Nome;
        private string? DataLançamento;
        private string? Genero;
        private int ClassificaoIndicativa;
        private double  Preço;
        private string? Descricao;



        public double GetPreço()
        {
            return Preço;
        }
    }
}
