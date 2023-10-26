namespace ComprarJogo
{
    public static class Loja
    {
        private static List<Jogo> JogosDiponiveis;

        public static void setJogos(Jogo jogo)
        {
            JogosDiponiveis.Add(jogo);
        }
        public static List<Jogo> GetJogos()
        {
            return JogosDiponiveis;
        }
    }
}
