using System;

namespace Automovel { 

public class Automovel
{
    private string Placa { get; set; }
    private string Marca { get; set; }
    private string Modelo { get; set; }
    private int Ano { get; set; }
    private string Cor { get; set; }
}

public class Moto : Automovel
{
    private decimal PrecoHora { get; set; } = 9.60m;

    public Moto(string marca, string modelo, int ano, string cor, string placa) : base(marca, modelo, ano, cor, placa)
    {

    }
}

public class Carro : Automovel
{
    private decimal PrecoHora { get; set; } = 17.00m;

    public Carro(string marca, string modelo, int ano, string cor, string placa) : base(marca, modelo, ano, cor, placa)
    {

    }
}
}