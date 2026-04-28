using Exercicio10;
using System;

class Program
{
    static void Main()
    {
        Carro carro1 = new Carro();
        carro1.Modelo = "Fiat Stilo";
        carro1.Marca = "Fiat";
        carro1.VelocidadeAtual = 10;

        carro1.ExibirDados();
        Console.WriteLine();

        carro1.Frear();
        carro1.Frear();

        carro1.ExibirDados();
    }
}
