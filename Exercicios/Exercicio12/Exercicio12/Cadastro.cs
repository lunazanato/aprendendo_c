using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio12
{
    internal class Cadastro
    {
        public string Nome {  get; set; } = string.Empty;
        public double Preco { get; set; }
        public string Categoria { get; set; } = string.Empty;

        public double Desconto;
        public void ExibirDados()
        {
            Console.WriteLine($"""
                Nome: {Nome}
                Preco: {Preco}
                Categoria: {Categoria}
                """);
        }

        public void AplicarDesconto(double percentual)
        {
            Console.WriteLine("Aplicando desconto...");
            Desconto = Preco - ((Preco * percentual) / 100);
            Preco = Desconto;
        }
    }
}
