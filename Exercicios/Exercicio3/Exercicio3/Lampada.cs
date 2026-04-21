using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    internal class Lampada
    {
        public bool Ligada { get; set; }

        public void Ligar()
        {
                Console.WriteLine("Ligando...");
                Ligada = true;
        }

        public void Desligar()
        { 
                Console.WriteLine($"Desligando...");
                Ligada = false;
            
        }

        public void Status()
        {
            if(Ligada == false)
            {
                Console.WriteLine($"Status: Lâmpada desligada");
            } else
            {
                Console.WriteLine($"Status: Lâmpada ligada");
            }
        }
    }
}
