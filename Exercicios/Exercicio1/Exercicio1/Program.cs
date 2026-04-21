using Exercicio1;
using System;

class Program
{
    static void Main()
    {
        PetShop pet1 = new PetShop();
        pet1.Nome = "Julia";
        pet1.Raca = "Border Collie";
        pet1.Idade = 5;

        PetShop pet2 = new PetShop();
        pet2.Nome = "Luna";
        pet2.Raca = "Pinsher";
        pet2.Idade = 4;

        Console.WriteLine($"""
            ---Dados do Pet 1---
            Nome: {pet1.Nome}
            Raça: {pet1.Raca}
            Idade: {pet1.Idade}
            """);
        pet1.Latir();
        pet1.Envelhecer();
        Console.WriteLine($"Nova idade de {pet1.Nome}: {pet1.Idade} anos");

        Console.WriteLine();

        Console.WriteLine($"""
            ---Dados do Pet 1---
            Nome: {pet2.Nome}
            Raça: {pet2.Raca}
            Idade: {pet2.Idade}
            """);
        pet2.Latir();
        Console.WriteLine($"Idade da {pet2.Nome}: Continua {pet2.Idade} anos");
    }
}
