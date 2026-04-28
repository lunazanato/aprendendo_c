using Exercicio12;
using System;

class Program
{
    static void Main()
    {
        Cadastro p1 = new Cadastro();
        Cadastro p2 = new Cadastro();
        p1.Nome = "Lapiseira";
        p1.Categoria = "Papelaria";
        p1.Preco = 12;

        p2.Nome = "Suco de uva";
        p2.Categoria = "Geladeira";
        p2.Preco = 4.5;

        p1.ExibirDados();
        Console.WriteLine();
        p2.ExibirDados();
        Console.WriteLine();
        p1.AplicarDesconto(20);
        Console.WriteLine();
        p2.AplicarDesconto(5);
        Console.WriteLine();

        p1.ExibirDados();
        Console.WriteLine();
        p2.ExibirDados();
        Console.WriteLine();


    }
}
