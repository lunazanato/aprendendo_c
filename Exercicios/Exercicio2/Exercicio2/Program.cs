using Exercicio2;
using System;

class Program
{
    static void Main()
    {
        ContaBancaria contaJulia = new ContaBancaria();
        contaJulia.Titular = "Júlia Carolina";
        contaJulia.Saldo = 100;

        ContaBancaria contaLuna = new ContaBancaria();
        contaLuna.Titular = "Luna Zanato";
        contaLuna.Saldo = 100;

        Console.WriteLine($"--Conta: {contaJulia.Titular}--");
        contaJulia.ExibirSaldo();

        Console.WriteLine($"Depositando R$100,00...");
        contaJulia.Depositar(100);

        contaJulia.ExibirSaldo();

        Console.WriteLine();

        Console.WriteLine($"--Conta: {contaLuna.Titular}--");
        contaLuna.ExibirSaldo();

        Console.WriteLine($"Depositando R$200,00...");
        contaLuna.Depositar(200);

        contaLuna.ExibirSaldo();
    }
}
