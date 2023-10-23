

namespace ProjetoControleEstacionamento.Models
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
        public void GerarTicket(Automovel Cobrar)
        {

            if (Vagas > NumAutomoveis)
            {
                Ticket novoTicket = new(Cobrar, DateTime.Now);
                NumAutomoveis++;
                //TODO: adicionar ticket no banco de dados
            }
            else
            {
                Console.WriteLine("Não há vagas disponíveis");
            }

        }

        public string PagarTicket(Ticket TicketAtual)
        {
            //TODO: Atualizar ticket do banco de dados como pago
            TicketAtual.Pagar();
            NumAutomoveis--;
            return "Ticket pago com sucesso";
        }

    }
}
