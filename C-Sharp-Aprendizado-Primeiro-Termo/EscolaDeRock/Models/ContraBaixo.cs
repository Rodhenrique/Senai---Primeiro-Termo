using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    class ContraBaixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            Console.WriteLine("Mantendo o ritmo do contrabaixo");
            return true;
        }
        public bool TocarSolo()
        {
            Console.WriteLine("tocando solo do contrabaixo");
            return true;
        }
        public bool TocarAcordes()
        {
            Console.WriteLine("Mantendo a harmonia do contrabaixo");
            return true;
        }
    }
}