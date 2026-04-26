using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Exercicio06
{
    internal class Livro
    {
        public string Titulo { get; set; } = string.Empty;
        public string Autor {  get; set; } = string.Empty;
        public int AnoPublicacao { get; set; }
        public int QuantidadePaginas { get; set; }
        public bool Emprestado { get; set; }

        public void ExibirInformacao()
        {
            string Status = Emprestado ? "Emprestado" : "Disponivel";
            Console.WriteLine($"Título do livro: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Ano da publicação: {AnoPublicacao}");
            Console.WriteLine($"Quantidade de páginas: {QuantidadePaginas}");
            Console.WriteLine($"Status: {Status}");
        }
        public void Emprestar()
        {
            if (Emprestado)
            {
                Console.WriteLine($"O livro {Titulo} já está emprestado.");
            } else
            {
                Emprestado = true;
                Console.WriteLine($"Emprestando o livro...");
            }

        }

        public void Devolver()
        {
            Emprestado = false;
            Console.WriteLine($"O livro {Titulo} foi devolvido.");
        }
        
        public void EstaDisponivel()
        {
            Emprestado = false;
            Console.WriteLine($"O livro {Titulo} está disponível.");
        }

         
    }
}
