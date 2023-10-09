namespace ProjetoControleEstacionamento
{
    public class Ticket
    {
        private Automovel AutomovelAtual { get; set; }
        private decimal Total { get; set; }
        private DateTime HoraEntrada { get; set; }
        private DateTime? HoraSaida { get; set; }

        public decimal CalcularPreco()
        {
            this.Total = (this.HoraEntrada.CompareTo(this.HoraSaida)) * this.AutomovelAtual.PrecoHora;
            return this.Total;
        }
    }
}
