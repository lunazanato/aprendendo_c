using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5
{
    internal class Termometro
    {
        public double TemperaturaCelsius {  get; set; }
        double Fahrenheit; 

        public void ExibirInfo()
        {
            Console.WriteLine($"Temperatura: {TemperaturaCelsius}");
        }
        public void AumentarTemp(double valor)
        {
            Console.WriteLine("Aumentando temperatura...");
            TemperaturaCelsius += valor;
        }

        public void TempFahren()
        {
         
            Fahrenheit = TemperaturaCelsius * 1.8 + 32;
            Console.WriteLine($"Temperatura em Fahrenheit: {Fahrenheit}");

        }
    }
}
