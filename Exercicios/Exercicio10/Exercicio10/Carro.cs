using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio10
{
    internal class Carro
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public double VelocidadeAtual {  get; set; }

        public void ExibirDados()
        {
            Console.WriteLine($"""
                Modelo: {Modelo}
                Marca: {Marca}
                Velocidade Atual: {VelocidadeAtual}
                """);
        }
        public void Acelerar()
        {
            Console.WriteLine("Acelerando...");
            VelocidadeAtual += 10;
        }
        public void Frear()
        {
            if (VelocidadeAtual >0)
            {
                Console.WriteLine("Desacelerando...");
                VelocidadeAtual -= 10;
            } else
            {
                Console.WriteLine("O valor não pode ser negativo.");
            }
            
        }
    }
}
