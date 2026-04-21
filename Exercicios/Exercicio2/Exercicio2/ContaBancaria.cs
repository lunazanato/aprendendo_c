using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2
{
    internal class ContaBancaria
    {
        public string Titular {  get; set; }
        public double Saldo { get; set; }
        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo de {Titular}: R${Saldo}");
        }
    }
}
