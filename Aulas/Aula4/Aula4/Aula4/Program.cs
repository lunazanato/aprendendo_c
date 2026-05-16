namespace Aula04;

class Program
{
    static void Main()
    {
        Console.WriteLine("----------CADASTRO DE USUÁRIO----------");

        //Solicitar o nome do usuário 
        Console.WriteLine("Digite seu Nome: ");

        string name = Console.ReadLine(); //Usuário consegue digitar
        //Console.WriteLine($"Nome do usuário: {name}");


        //Solicitar a Idade do usuário
        Console.Write("Digite sua Idade: ");
        //int age = Console.ReadLine(); //Deu erro pois o console.readline lê apenas strings
        int age = Convert.ToInt32(Console.ReadLine()); //conversor de numero inteiro para string

        Console.WriteLine("----------------------------------------");
        Console.WriteLine();
        Console.WriteLine($"Nome: {name} \nIdade: {age}");
        Console.WriteLine();
    }
}
