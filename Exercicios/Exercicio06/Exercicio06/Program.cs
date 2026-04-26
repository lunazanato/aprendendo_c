using Exercicio06;
using System;

class Program
{
    static void Main()
    {
        Livro livro1 = new Livro();
        livro1.Titulo = "Harry Potter e a Pedra Filosofal";
        livro1.Autor = "J. K. Rowling";
        livro1.AnoPublicacao = 1997;
        livro1.QuantidadePaginas = 290;
        livro1.Emprestado = false;

        Livro livro2 = new Livro();
        livro2.Titulo = "Harry Potter e a Câmara Secreta";
        livro2.Autor = "J. K. Rowling";
        livro2.AnoPublicacao = 1998;
        livro2.QuantidadePaginas = 310;
        livro2.Emprestado = false;

        livro1.ExibirInformacao();
        Console.WriteLine();
        livro2.ExibirInformacao();
        Console.WriteLine();
        livro1.Emprestar();
        Console.WriteLine();
        livro1.Emprestar();
        livro1.ExibirInformacao();

        Console.WriteLine();
        livro1.Devolver();
        livro1.ExibirInformacao();
    }
}
