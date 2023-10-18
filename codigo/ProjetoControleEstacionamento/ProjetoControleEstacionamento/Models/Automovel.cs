namespace ProjetoControleEstacionamento.Models
{
    public class Automovel
    {
        protected string Placa { get; set; }
        protected string Marca { get; set; }
        protected string Modelo { get; set; }
        protected int Ano { get; set; }
        protected string Cor { get; set; }
        public virtual decimal PrecoHora { get; set; }


        public Automovel(string marca, string modelo, int ano, string cor, string placa)
        {
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            Placa = placa;
            Ano = ano;
        }

    }

    public class Moto : Automovel
    {
        public override decimal PrecoHora { get; set; } = 9.60m;

        public Moto(string marca, string modelo, int ano, string cor, string placa) : base(marca, modelo, ano, cor, placa)
        {

        }
    }

    public class Carro : Automovel
    {
        public override decimal PrecoHora { get; set; } = 17.00m;

        public Carro(string marca, string modelo, int ano, string cor, string placa) : base(marca, modelo, ano, cor, placa)
        {

        }
    }
}
