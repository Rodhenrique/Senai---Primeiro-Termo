using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    class Bateria : InstrumentoMusical, IPercussao
    {
        public bool ManterRitmo()
        {
            Console.WriteLine("Mantendo o ritmo da Bateria ");
            return true;
        }
    }
}