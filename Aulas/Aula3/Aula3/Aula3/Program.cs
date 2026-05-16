namespace Aula03;

public class Program
{
    static void Main()
    {
        /* int number = 30;

         number = 20; //atribuir outro valor à variável

         number = 10; //última declaração é a que permanece

         Console.WriteLine("O valor antigo da variável era: " + number);

         number = 5;

         Console.WriteLine("O valor novo da variável é: " + number);

         const int num = 1000; //constante, não muda

         Console.WriteLine($"O valor da constante é: {num}");

         num = 2000; //ocasiona em erros

         Console.WriteLine($"O valor da constante é: {num}"); */

        var variable = "Luna"; //Definimos que var é string

        variable = "Zanato";

        // variable = 500; //Não tem como definir um número pois ela foi definida como string

        Console.WriteLine($"O valor da variável é: {variable}");

        var numero = 500; //Variável agora foi definida como número

        numero = 400; //Conseguimos mudar apenas para números

        Console.WriteLine($"O valor da variável é: {numero}");

        dynamic variavel = 15; //variável do tipo dinamico, onde conseguimos mudar de number para string

        variavel = "Luna"; //Não houve erros

        Console.WriteLine(variavel);
    }
}
