using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1205
{
    internal class Basquete : Esporte
    {
        public Basquete(string nomeCasa, string nomeVisitante) : base(nomeCasa, nomeVisitante) { }

        public override void MarcarPontoCasa()
        {
            PontosCasa += 2; 
        }

        public override void MarcarPontoVisitante()
        {
            PontosVisitante += 2;
        }
    }
}
