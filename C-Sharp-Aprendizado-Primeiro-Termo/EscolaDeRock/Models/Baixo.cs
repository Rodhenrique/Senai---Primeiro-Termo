using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    class Baixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            Console.WriteLine("Mantendo o ritmo do baixo");
            return true;
        }
        public bool TocarAcordes()
        {
            Console.WriteLine("Tocando acordes do baixo");
            return true;
        }
    }
}