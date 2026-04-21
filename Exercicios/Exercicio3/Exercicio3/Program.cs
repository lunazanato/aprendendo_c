using Exercicio3;
using System;

class Program
{ 
    static void Main()
    {
        Lampada lampada = new Lampada();

        lampada.Ligar();

        lampada.Status();

        lampada.Desligar();

        lampada.Status();
    }
}
