using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using BCrypt.Net;
using ProjetoControleEstacionamento;

namespace ProjetoControleEstacionamento
{
    public class Estacionamento
    {
        private readonly int Vagas;
        private int NumAutomoveis;

        public Estacionamento(int Vagas)
        {
            this.Vagas = Vagas;
            NumAutomoveis = 0;
        }
        
        //Gerar o ticket se houver vagas disponíveis
        public void GerarTicket(Automovel Cobrar) {

            if(this.Vagas > NumAutomoveis) { 
            Ticket novoTicket =  new(Cobrar,DateTime.Now);
            NumAutomoveis++;
            //TODO: adicionar ticket no banco de dados
            }
            else {
                Console.WriteLine("Não há vagas disponíveis");
            }
            
        }

        public void PagarTicket(Ticket TicketAtual)
        {
            TicketAtual.Pago = true;
            //TODO: Remover ticket do banco de dados
            NumAutomoveis--;
        }

    }
}
