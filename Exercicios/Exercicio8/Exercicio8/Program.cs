using Exercicio8;
using System;

class Program
{
    static void Main()
    {
        ContaBancaria contaum = new ContaBancaria();
        contaum.NumeroConta = 2508;
        contaum.Titular = "Juluna";
        contaum.Saldo =1;

        contaum.ExibirDados();
        Console.WriteLine();
        contaum.Depositar(1000000);
        contaum.ExibirDados();
        Console.WriteLine();
        contaum.Sacar(1);
        Console.WriteLine();
        contaum.ExibirDados();

    }
}
