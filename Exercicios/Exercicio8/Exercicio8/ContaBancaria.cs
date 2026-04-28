using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio8
{
    internal class ContaBancaria
    {
        public int NumeroConta { get; set; }
        public string Titular {  get; set; }
        public double Saldo { get; set; }

        public void ExibirDados()
        {
            Console.WriteLine($"Número da conta: {NumeroConta} \n Titular: {Titular} \n Saldo:R${Saldo}");

        }

        public void Depositar (double valor)
        {
            Saldo += valor;
            Console.WriteLine("Depositando..............................está demorando");
        }
        public void Sacar (double valor)
        {
            Saldo -= valor;
            Console.WriteLine($"Retirando R${valor} da sua conta. Pobre!");
        }
    }
}
