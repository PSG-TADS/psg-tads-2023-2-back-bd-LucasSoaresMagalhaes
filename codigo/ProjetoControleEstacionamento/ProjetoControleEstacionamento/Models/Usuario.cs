using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
namespace ProjetoControleEstacionamento.Models

{
    public class Usuario
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("Login")]
        public readonly string Login;

        [BsonElement("Senha")]
        private readonly string Senha;

        public Usuario(string Login, string Senha)
        {
            this.Login = Login;
            this.Senha = Senha;

            InserirUsuarioNoBanco();
        }

        //Insere o usuário dentro do banco
        private void InserirUsuarioNoBanco()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("EstacionamentoDB");
            var collection = database.GetCollection<Usuario>("Usuarios");
            collection.InsertOne(this);
        }



        //Verifica se o usuário existe no banco e retorna verdadeiro ou falso
        public bool VerificarLogin(string senha)
        {
            //return BCrypt.Net.BCrypt.Verify(senha, this.Senha);
            return senha == this.Senha;
        }

        //TODO Gerar relatório de faturamento do estacionamento
        public string GerarRelatorio(Estacionamento Atual)
        {
            return "";
        }

    }
}
