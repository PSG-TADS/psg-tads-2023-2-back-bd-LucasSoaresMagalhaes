using MongoDB.Driver;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Data.SqlClient;

namespace ProjetoControleEstacionamento.Models
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Configurar a conex�o com o MongoDB
            string connectionStringMongo = "mongodb://localhost:27017";
            var mongoClient = new MongoClient(connectionStringMongo);
            var databaseNameMongo = "EstacionamentoDB";
            var dbMongo = mongoClient.GetDatabase(databaseNameMongo);

            // Configurar a conex�o com SQL

            string connectionStringSQL = "Server=DESKTOP-LRPRCIT\\SQLEXPRESS;Database=EstacionamentoBDSQL;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionStringSQL))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conex�o bem-sucedida!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro de conex�o: " + ex.Message);
                }
            }

            builder.Services.AddSingleton(dbMongo);

            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            //GET usuarios do sistema
            app.MapGet("/login", async (IMongoDatabase database, [FromQuery] string login, [FromQuery] string senha) =>
            {
                var collection = database.GetCollection<Usuario>("Usuarios");

                // Primeiro, encontramos o usu�rio com base no nome de usu�rio (Login)
                var filter = Builders<Usuario>.Filter.Eq(u => u.Login, login);
                var usuario = await collection.Find(filter).FirstOrDefaultAsync();

                if (usuario != null)
                {
                    // Verifique a senha
                    if (usuario.VerificarLogin(senha))
                    {
                        // A senha est� correta
                        return Results.Ok("Autenticado com sucesso");
                    }
                    else
                    {
                        // Senha incorreta
                        return Results.Unauthorized();
                    }
                }
                else
                {
                    // Usu�rio n�o encontrado
                    return Results.NotFound("Usu�rio n�o encontrado");
                }
            });

            _ = app.MapPost("/cadastrarUsuario", async (IMongoDatabase database, [FromBody] JsonElement requestBody) =>
            {
                var collection = database.GetCollection<Usuario>("Usuarios");

                // Verifique se a solicita��o possui um campo "login" e "senha"
                if (requestBody.TryGetProperty("login", out var EntradaLogin) && requestBody.TryGetProperty("senha", out var EntradaSenha))
                {
                    string login = EntradaLogin.GetString();
                    string senha = EntradaSenha.GetString();

                    if (login != null && senha != null)
                    {
                        // Primeiro, verifique se o usu�rio j� existe com base no nome de usu�rio (Login)
                        var filter = Builders<Usuario>.Filter.Eq(u => u.Login, login);
                        var usuarioExistente = await collection.Find(filter).FirstOrDefaultAsync();

                        if (usuarioExistente == null)
                        {
                            // O usu�rio n�o existe, ent�o voc� pode prosseguir com o cadastro.
                            // Crie um novo objeto Usuario com os dados do usu�rio e salve-o no banco de dados

                            var novoUsuario = new Usuario(login, BCrypt.Net.BCrypt.HashPassword(senha));
                            return Results.Ok("Cadastrado com sucesso");
                        }
                        else
                        {
                            return Results.Unauthorized();
                        }
                    }
                    else
                    {
                        return Results.BadRequest("Solicita��o inv�lida. Certifique-se de fornecer os campos 'login' e 'senha'.");
                    }
                }
                else
                {
                    return Results.BadRequest("Solicita��o inv�lida. Certifique-se de fornecer os campos 'login' e 'senha'.");
                }
            });


            // Outros endpoints (GET, POST, PUT, DELETE) podem ser configurados da mesma maneira

            app.Run();
        }
    }
}
