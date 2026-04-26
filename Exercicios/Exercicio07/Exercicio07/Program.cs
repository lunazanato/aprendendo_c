using Exercicio07;
using System;

class Program
{ 
    static void Main()
    {
        Funcionario funcionario1 = new Funcionario();
        funcionario1.Nome = "Adalberto Nunes";
        funcionario1.Cargo = "Analista de Segurança";
        funcionario1.Salario = 3200;

        Funcionario funcionario2 = new Funcionario();
        funcionario2.Nome = "Clotilde da Silva";
        funcionario2.Cargo = "Desenvolvedora Front-end";
        funcionario2.Salario = 2100;

        funcionario1.ExibirDados();
        Console.WriteLine();
        funcionario2.ExibirDados();
        Console.WriteLine();

        funcionario2.AumentarSalario(10);
        Console.WriteLine();
        funcionario2.ExibirDados();
    }
}
