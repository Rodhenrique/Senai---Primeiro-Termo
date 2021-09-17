using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    class Teclado : InstrumentoMusical,IPercussao,IHarmonia
    {
        public bool ManterRitmo()
        {
            Console.WriteLine("Mantendo o ritmo do teclado");
            return true;
        }
        public bool TocarSolo()
        {
            Console.WriteLine("tocando solo o telcado");
            return true;
        }
        public bool TocarAcordes()
        {
            Console.WriteLine("Mantendo harmonia do teclado");
            return true;
        }
    }
    
}