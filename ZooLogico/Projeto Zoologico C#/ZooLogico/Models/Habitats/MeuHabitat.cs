using ZooLogico.Models;
using System.Collections.Generic;

namespace ZooLogico.Models.Habitats
{
    public class MeuHabitat
    {
        public static Dictionary<int, HoraDoshow> natural = new Dictionary<int, HoraDoshow>()
        {
            {1, new Aquario()},
            {2, new CasaDaArvore()},
            {3, new CavernaDePedra()},
            {4, new Gaiola()},
            {5, new Pasto()},
            {6, new Piscina()},
            {7, new PiscinaGelada()}
        };

    }
}