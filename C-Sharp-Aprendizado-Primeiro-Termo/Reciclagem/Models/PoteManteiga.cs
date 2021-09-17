using System;
using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class PoteManteiga : lixos, ILixeiraVerde
    {
        public string RecicladoVidro()
        {
            return this.GetType().Name;
        }
    }
}