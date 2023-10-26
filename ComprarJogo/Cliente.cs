namespace ComprarJogo
{
    public class Cliente
    {
        private int IdCliente;
        private string? Nome;
        private string? Senha;
        private string? Email;
        private string? CPF;
        private string? DataNascimento;
        private List<Jogo>? JogosPossuidos;

        public Cliente() 
        {
                    
        }

        public void SetId(int id)
        {
            this.IdCliente = id;
        }

        public int GetId()
        {
            return IdCliente;   
        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }

        public string getNome() 
        {
            return Nome;
        }

        public void SetSenha(string senha)
        {
            this.Senha = senha;
        }

        public string GetSenha() 
        {
            return Senha;
        }

        public void setEmail(string email) 
        {
            this.Email = email;
        }

        public string getEmail() 
        {
            return Email;
        }

        public void setCPF(string cpf)
        {
            this.CPF = cpf;
        }

        public string getCPF()
        {
            return CPF;
        }

        public void setDataNascimento(string data)
        {
            this.DataNascimento = data;
        }
        public string getDataNascimento()
        {
            return DataNascimento;
        }

        

    }
}
