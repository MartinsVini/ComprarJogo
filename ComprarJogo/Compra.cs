namespace ComprarJogo
{
    public class Compra
    {
        private int IdCompra;
        private string? DataCompra;
        private double? Valor;
        private Cliente? Cliente;
        private Jogo? JogoComprado;

        public Compra(Jogo jogo)
        {
            JogoComprado = jogo;
            DataCompra = null;
            Valor = jogo.GetPreço();
        }
    }
}
