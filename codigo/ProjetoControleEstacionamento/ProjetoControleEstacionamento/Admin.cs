using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using BCrypt.Net;
using ProjetoControleEstacionamento;

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

        public async Task<bool> VerificarLogin(string login, string senha)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("EstacionamentoDB");
            var collection = database.GetCollection<Admin>("Usuarios");

            var user = await collection.Find(x => x.Login == login).FirstOrDefaultAsync();

            if (user != null)
            {
                // Verificar a senha armazenada no banco de dados
                bool senhaValida = BCrypt.Net.BCrypt.Verify(senha, user.Senha);

                return senhaValida;
            }

            return false; // Usuário não encontrado
        }
        //TODO Gerar relatório de faturamento do estacionamento
        public string GerarRelatorio() {
            return "";
        }

    }
}
