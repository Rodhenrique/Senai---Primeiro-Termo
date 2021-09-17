using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Papelao : lixos, ILixeiraAzul
    {
        public string RecicladoPapel()
        {
            return this.GetType().Name;
        }
    }
}