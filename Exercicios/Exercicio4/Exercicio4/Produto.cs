using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio4
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEstoque { get; set; }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"""
            --Produto: {Nome}--
            Preço: {Preco}
            Quantidade do estoque: {QuantidadeEstoque}
            """);
        }
        public void AdicionarEstoque(int quantidade)
        {
            Console.WriteLine("Adicionando...");
            QuantidadeEstoque += quantidade;
        }

        public void RemoverEstoque(int quantidade)
        {
            Console.WriteLine("Removendo...");
            QuantidadeEstoque -= quantidade;
        }
    }
}
