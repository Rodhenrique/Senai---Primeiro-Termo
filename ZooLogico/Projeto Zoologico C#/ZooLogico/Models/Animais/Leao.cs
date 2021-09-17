using ZooLogico.Interfaces;

namespace ZooLogico.Models
{
   public class Leao : Animal, ITerrestre
    {
        public string Andar()
        {
            return this.GetType().Name + " pode caminhar";
        }
    }
}