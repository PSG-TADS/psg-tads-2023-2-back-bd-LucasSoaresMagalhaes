namespace ProjetoControleEstacionamento
{
    public class Admin
    {
        private readonly string Login;
        private readonly string Senha;

        public Admin(string Login, string Senha)
        {
            this.Login = Login;
            this.Senha = Senha;
        }

        public bool VerificarLogin(string Senha, string Login)
        {
           return this.Login == Login && this.Senha == Senha;
        }

        //TODO Gerar relatório de faturamento do estacionamento
        public string GerarRelatorio() {
            return "";
        }

    }
}
