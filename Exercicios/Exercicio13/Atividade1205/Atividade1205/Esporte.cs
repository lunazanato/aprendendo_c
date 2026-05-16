using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1205
{
    internal class Esporte
    {
        public string NomeCasa { get; set; }
        public string NomeVisitante { get; set; }
        public int PontosCasa { get; protected set; }
        public int PontosVisitante { get; protected set; }

        public Esporte(string nomeCasa, string nomeVisitante)
        {
            NomeCasa = nomeCasa;
            NomeVisitante = nomeVisitante;
            PontosCasa = 0;
            PontosVisitante = 0;
        }

        public virtual void MarcarPontoCasa()
        {
            PontosCasa++;
        }

        public virtual void MarcarPontoVisitante()
        {
            PontosVisitante++;
        }

        public void ExibirResultado()
        {
            Console.WriteLine($"\n--- PLACAR FINAL ---");
            Console.WriteLine($"{NomeCasa} {PontosCasa} x {PontosVisitante} {NomeVisitante}");
            Console.WriteLine("--------------------");

            if (PontosCasa > PontosVisitante)
            {
                Console.WriteLine($"Resultado: Vitória do {NomeCasa}! (Derrota do {NomeVisitante})");
            }
            else if (PontosVisitante > PontosCasa)
            {
                Console.WriteLine($"Resultado: Vitória do {NomeVisitante}! (Derrota do {NomeCasa})");
            }
            else
            {
                Console.WriteLine("Resultado: Empate!");
            }
        }
    }
}
