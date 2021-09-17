using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    class Violao : InstrumentoMusical,IHarmonia
    {
        public bool TocarAcordes()
        {
            Console.WriteLine("Tocando Acordes de Violão");
            return true;
        }
    }
}