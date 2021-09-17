using System.Collections.Generic;

namespace Reciclagem.Models
{
    public class Deposito
    {
        public static Dictionary<int,lixos> lixo = new Dictionary<int, lixos>()
        {
            {1,new Garrafa()},
            {2,new GarrafaPet()},
            {3,new GuardaChuva()},
            {4,new PoteManteiga()},
            {5,new Latinha()},
            {6,new Papelao()},
            {7,new CascaBanana()}
        };
    }
}