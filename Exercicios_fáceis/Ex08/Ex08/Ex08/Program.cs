namespace Ex08;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número: ");
        int Number = Convert.ToInt32 (Console.ReadLine());

        if (Number > 0)
        {
            Console.WriteLine($"O número {Number} é positivo!");
        }
        else
        {
            Console.WriteLine($"O número {Number} é negativo!");
        }

        for ( int i = 1; i <= Number; i++ )
        {
            Console.WriteLine(i);
            
        }
    }
}