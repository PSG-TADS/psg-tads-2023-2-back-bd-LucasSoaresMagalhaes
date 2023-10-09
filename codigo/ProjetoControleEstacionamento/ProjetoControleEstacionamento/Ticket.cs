using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProjetoControleEstacionamento
{
    public class Ticket
    {
        [BsonId]
        public ObjectId Id { get; set; }
        private Automovel AutomovelAtual { get; set; }
        private decimal Total { get; set; }
        private DateTime HoraEntrada { get; set; }
        private DateTime HoraSaida { get; set; }

        public bool Pago;

        public Ticket(Automovel AutomovelAtual, DateTime HoraEntrada) { 
        
        this.AutomovelAtual = AutomovelAtual;
        this.HoraEntrada = HoraEntrada;  
        
        }

        public decimal CalcularPreco()
        {
            this.HoraSaida = DateTime.Now;
            this.Total = (this.HoraEntrada.CompareTo(this.HoraSaida)) * this.AutomovelAtual.PrecoHora;
            return this.Total;
        }
    }
}
