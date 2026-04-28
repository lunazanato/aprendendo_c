using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio11
{
    internal class Aluno
    {
        public string Nome {  get; set; } = string.Empty;
        public int Matricula { get; set; } 
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public double Media; 

        public void ExibirDados()
        {
            Console.WriteLine($"""
                Nome: {Nome}
                Matrícula: {Matricula}
                Notas: {Nota1}, {Nota2}, {Nota3}
                """);
        }

        public void CalcularMedia()
        {
            Media = (Nota1 + Nota2 + Nota3) / 3;
            Console.WriteLine($"Sua média é {Media}");
        }

        public void VerificarSituacao()
        {
            if (Media >= 6)
            {
                Console.WriteLine("Aprovado");
            } else
            {
                Console.WriteLine("Reprovado");
            }

        }

    }
}
