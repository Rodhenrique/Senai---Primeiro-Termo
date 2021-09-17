using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
     class Tambores : InstrumentoMusical,IMelodia,IHarmonia
    {
        public bool ManterRitmo()
        {
            Console.WriteLine("Tocando acordes os tambores.");
            return true;
        }
        public bool TocarSolo()
        {
            Console.WriteLine("tocando solo os tambores");
            return true;
        }
        public bool TocarAcordes()
        {
            Console.WriteLine("Mantendo harmonia do tambores");
            return true;
        }
    }
}