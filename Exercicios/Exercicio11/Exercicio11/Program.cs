using Exercicio11;
using System;

class Program
{
    static void Main()
    {
        Aluno aluno1 = new Aluno();
        aluno1.Nome = "Adalberto";
        aluno1.Matricula = 45632;
        aluno1.Nota1 = 7;
        aluno1.Nota2 = 6;
        aluno1.Nota3 = 9;

        aluno1.ExibirDados();
        Console.WriteLine();
        aluno1.CalcularMedia();
        Console.WriteLine();
        aluno1.VerificarSituacao();
        Console.WriteLine();

    }
}

