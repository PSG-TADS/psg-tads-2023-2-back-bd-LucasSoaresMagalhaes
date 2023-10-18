using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProjetoControleEstacionamento.Models
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

        public Ticket(Automovel AutomovelAtual, DateTime HoraEntrada)
        {

            this.AutomovelAtual = AutomovelAtual;
            this.HoraEntrada = HoraEntrada;
            Pago = false;

        }

        public decimal Pagar()
        {
            Pago = true;
            HoraSaida = DateTime.Now;
            Total = HoraEntrada.CompareTo(HoraSaida) * AutomovelAtual.PrecoHora;
            return Total;
        }
    }
}
