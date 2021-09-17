using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class GuardaChuva : lixos, ILixeiraCinza
    {
        public string RecicladoIndefinidos()
        {
            return this.GetType().Name;
        }
    }
}