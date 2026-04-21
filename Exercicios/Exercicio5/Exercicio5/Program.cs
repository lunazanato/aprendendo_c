using Exercicio5;
using System;

class Program
{
    static void Main()
    {
        Termometro TempCelcius = new Termometro();
        TempCelcius.TemperaturaCelsius = 32;

        TempCelcius.ExibirInfo();
        Console.WriteLine();

        TempCelcius.AumentarTemp(2);
        Console.WriteLine();

        TempCelcius.ExibirInfo();
        Console.WriteLine();

        TempCelcius.TempFahren();
        Console.WriteLine();
    }
}

