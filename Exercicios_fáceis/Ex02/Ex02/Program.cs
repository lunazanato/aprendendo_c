namespace Ex02; //OPERADORES E EXPRESSÕES

public class Program
{
    public static void Main()
    {
        int n1 = 5;
        int n2 = 15;
        int soma = n1 + n2;
        int sub = n1 - n2;
        int multi = n1 * n2;
        double divisao = n1 / n2;

        Console.WriteLine($"""
            Números: {n1}, {n2}
            Soma: {soma}
            Subtração: {sub}
            Multiplicação: {multi}
            Divisão: {divisao}
            """);
    }
}
//EXERCICIO OK  
