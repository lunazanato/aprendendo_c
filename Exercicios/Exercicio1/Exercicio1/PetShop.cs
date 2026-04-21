using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    internal class PetShop
    {
        public string Nome { get; set; }
        public string Raca { get; set; }
        public int Idade { get; set; }

        public void Latir()
        {
            Console.WriteLine($"{Nome} diz: Au Au");
        }

        public void Envelhecer()
        {
            Idade++;
        }
    }
}
