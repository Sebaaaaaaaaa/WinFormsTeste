using System;

public class Carro
{
    public string placa { get; set; }
    public string marca { get; set; }
    public string modelo { get; set; }
    public bool automatico { get; set; }
    public int ano { get; set; }

    public Carro(string placa, string marca, string modelo, bool automatico, int ano)
    {
        this.placa = placa;
        this.marca = marca;
        this.modelo = modelo;
        this.automatico = automatico;
        this.ano = ano;
    }
}

