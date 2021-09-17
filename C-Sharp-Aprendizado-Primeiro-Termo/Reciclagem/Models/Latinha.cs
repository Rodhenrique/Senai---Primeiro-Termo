using System;
using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class Latinha : lixos, ILixeiraAmarelo
    {
        public string RecicladoMetal()
        {
            return this.GetType().Name;
        }
    }
}