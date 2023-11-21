namespace ComprarJogo.Models
{
    public class Reembolso
    {
        private int _IdReembolso;
        public int IdReembolso
        {
            get { return _IdReembolso; }
            set { _IdReembolso = value;}
        }

        private string? _Motivo;

        public string? Motivo
        {
            get { return _Motivo; }
            set { _Motivo = value;}
        }

        private string? _ChavePix;

        public string? ChavePix
        {
            get { return _ChavePix; }
            set { _ChavePix= value; }
        }

        public virtual Compra? Compra { get; set; }

        public Reembolso()
        {
        }

        public Reembolso(string motivo,string chavePix)
        {
            this.Motivo = motivo;
            this.ChavePix = chavePix;

        }

        public Reembolso(string motivo)
        {
            this.Motivo = motivo;
            this.ChavePix = null;

        }

        
       
    }
}
