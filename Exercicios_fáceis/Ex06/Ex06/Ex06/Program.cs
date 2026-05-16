namespace Ex06;

class Program
{
    static void Main()
    {
        //int contador = 1;

        //while (contador <= 5)
        //{
        //    Console.WriteLine($"Número: {contador}");
        //    contador++;
        //}

        string senhaCorreta = "1234";
        string senhaDigitada = "";

        while(senhaDigitada != senhaCorreta)
        {
            Console.WriteLine("Digite a senha: ");
            senhaDigitada = Console.ReadLine();

            if (senhaDigitada != senhaCorreta)
            {
                Console.WriteLine("Senha incorreta, tente novamente");
            }
        }
        Console.WriteLine("Acesso Liberado!");

    }   
}
