using System;
using EscolaDeRock.Interfaces;
using EscolaDeRock.Models;

namespace EscolaDeRock.Models
{
    class Guitarra : InstrumentoMusical,IMelodia,IHarmonia
    {
        public bool TocarAcordes()
        {
            Console.WriteLine("Tocando acordes da guitrarra.");
            return true;
        }
        public bool TocarSolo()
        {
            Console.WriteLine("tocando solo a guitarra");
            return true;
        }
    }
}