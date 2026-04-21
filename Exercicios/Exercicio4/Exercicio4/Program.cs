using Exercicio4;
using System;

class Program
{
    static void Main()
    {
        Produto MolhoTomate = new Produto();
        MolhoTomate.Nome = "Molho de Tomate";
        MolhoTomate.Preco = 2.99;
        MolhoTomate.QuantidadeEstoque = 12;

        Produto AzeiteOliva = new Produto();
        AzeiteOliva.Nome = "Azeite de Oliva";
        AzeiteOliva.Preco = 39.9;
        AzeiteOliva.QuantidadeEstoque = 10;

        MolhoTomate.ExibirInformacoes();
        Console.WriteLine();
        MolhoTomate.AdicionarEstoque(5);
        Console.WriteLine();
        MolhoTomate.ExibirInformacoes();
        Console.WriteLine();
        AzeiteOliva.ExibirInformacoes();
        Console.WriteLine();
        AzeiteOliva.RemoverEstoque(2);
        Console.WriteLine();
        AzeiteOliva.ExibirInformacoes();

   
    }
}
