using Atividade1205;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SIMULADOR DE PLACAR (POO) ===");

        Console.WriteLine("\n>> Iniciando Partida de Futebol...");
        Esporte partidaFutebol = new Futebol("Flamengo", "Palmeiras");

        partidaFutebol.MarcarPontoCasa();      
        partidaFutebol.MarcarPontoVisitante(); 
        partidaFutebol.MarcarPontoCasa();      

        partidaFutebol.ExibirResultado();
       
        Console.WriteLine("\n>> Iniciando Partida de Basquete...");
        Esporte partidaBasquete = new Basquete("Lakers", "Bulls");

        partidaBasquete.MarcarPontoCasa();      
        partidaBasquete.MarcarPontoVisitante(); 
        partidaBasquete.MarcarPontoVisitante(); 
        partidaBasquete.MarcarPontoVisitante(); 

        partidaBasquete.ExibirResultado();

        Console.ReadLine();
    }
}
