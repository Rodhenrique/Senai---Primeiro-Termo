using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    class Garrafa : lixos, ILixeiraVerde
    {
        public string RecicladoVidro()
        {
            return this.GetType().Name;
        }

    }
}