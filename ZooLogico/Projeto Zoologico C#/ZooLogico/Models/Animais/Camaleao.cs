using ZooLogico.Interfaces;

namespace ZooLogico.Models.Animais
{
    public class Camaleao : Animal,ITerrestre
    {
        public string Andar()
        {
            return this.GetType().Name + " pode caminhar";
        }
    }
}