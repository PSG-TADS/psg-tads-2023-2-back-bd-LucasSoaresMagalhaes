namespace ProjetoControleEstacionamento
{
    public class Automovel
    {
        protected string Placa { get; set; }
        protected string Marca { get; set; }
        protected string Modelo { get; set; }
        protected int Ano { get; set; }
        protected string Cor { get; set; }
        public decimal PrecoHora { get; set; } = decimal.Zero;


        public Automovel (string marca, string modelo, int ano, string cor, string placa)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Cor = cor;
            this.Placa = placa;
            this.Ano = ano;
        }

    }

    public class Moto : Automovel
    {
        protected decimal PrecoHora { get; set; } = 9.60m;

        public Moto(string marca, string modelo, int ano, string cor, string placa) : base(marca, modelo, ano, cor, placa)
        {

        }
    }

    public class Carro : Automovel
    {
        protected decimal PrecoHora { get; set; } = 17.00m;

        public Carro(string marca, string modelo, int ano, string cor, string placa) : base(marca, modelo, ano, cor, placa)
        {

        }
    }
}
