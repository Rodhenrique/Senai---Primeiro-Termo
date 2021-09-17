using ZooLogico.Interfaces;

namespace ZooLogico.Models
{
    public class Teiu : Animal,ITerrestre
    {
        public string Andar()
        {
            return this.GetType().Name + " pode caminhar";
        }
    }
}