using System;
using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class GarrafaPet : lixos, ILixeiraVermelho
    {
        public string RecicladoPlastico()
        {
            return this.GetType().Name;
        }
    }
}