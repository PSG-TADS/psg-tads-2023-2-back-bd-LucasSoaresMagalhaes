using MongoDB.Bson;
using MongoDB.Driver;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
namespace ProjetoControleEstacionamento.Models
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Configurar a conexão com o MongoDB
            string connectionString = "mongodb://localhost:27017";
            var mongoClient = new MongoClient(connectionString);
            var databaseName = "EstacionamentoDB";
            var db = mongoClient.GetDatabase(databaseName);

            builder.Services.AddSingleton(db);

            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.MapGet("/carros", async (IMongoDatabase database) =>
            {
                var collection = database.GetCollection<Usuario>("Usuarios");
                var produtos = await collection.Find(_ => true).ToListAsync();
                return Results.Ok(produtos);
            });

            // Outros endpoints (GET, POST, PUT, DELETE) podem ser configurados da mesma maneira

            app.Run();
        }
    }
}
