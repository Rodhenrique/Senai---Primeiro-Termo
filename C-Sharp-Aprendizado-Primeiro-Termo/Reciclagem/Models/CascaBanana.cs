using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    class CascaBanana : lixos, ILixeiraPreta
    {
        public string RecicladoMaterialOrgĂ˘nico()
        {
            return this.GetType().Name;
        }
    }
}