using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    class CascaBanana : lixos, ILixeiraPreta
    {
        public string RecicladoMaterialOrgânico()
        {
            return this.GetType().Name;
        }
    }
}