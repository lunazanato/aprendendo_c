using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio07
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }

        public void ExibirDados()
        {
            Console.WriteLine($"""
                Nome: {Nome}
                Cargo: {Cargo}
                Salario atual: {Salario};
                """);
        }

        public void AumentarSalario(double Percentual)
        {
            Salario = Salario + ((Salario * Percentual) / 100);
            Console.WriteLine($"Reajustando o salário...");
        }

    }
}
